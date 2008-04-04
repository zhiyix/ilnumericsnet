#region Copyright GPLv3
//
//  This file is part of ILNumerics.Net. 
//
//  ILNumerics.Net supports numeric application development for .NET 
//  Copyright (C) 2007, H. Kutschbach, http://ilnumerics.net 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.
// 
//  Non-free licenses are also available. Contact info@ilnumerics.net 
//  for details.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using ILNumerics.Exceptions;
using ILNumerics.Drawing.Internal;
using ILNumerics.BuiltInFunctions; 
using ILNumerics.Drawing.Interfaces; 
using ILNumerics.Drawing.Graphs; 

namespace ILNumerics.Drawing.Collections {
    
    
    /// <summary>
    /// Collection of graph objects - all graphs currently contained in a subfigure
    /// </summary>
    public class ILGraphCollection : List<ILGraph>, IDisposable {

        public event ILGraphCollectionChangedEvent CollectionChanged;

        #region members / properties
        private IILCreationFactory m_graphFact; 
        private ILClippingData m_clippingData;
        /// <summary>
        /// Clippping volume for data in all graphs of the collection
        /// </summary>
        /// <remarks>This gives back the real ILClippingData object (no copy)</remarks>
        public ILClippingData Clipping {
            get {
                return m_clippingData;
            }
        }
        #endregion 

        #region constructor / disposal
        /// <summary>
        /// Create new ILGraphCollection
        /// </summary>
        /// <param name="panel">Output panel </param>
        /// <param name="clippingData"></param>
        internal ILGraphCollection(IILCreationFactory vPainterFact) : base() {
            m_graphFact = vPainterFact; 
            m_clippingData = new ILClippingData();
        }
        /// <summary>
        /// dispose all graphs contained in this collection
        /// </summary>
        public void Dispose() {
            foreach (ILGraph graph in this) {
                if (graph != null) 
                    graph.Dispose(); 
            }
        }
        #endregion

        #region event handling
        /// <summary>
        /// signaled if one of the ILGraphs have changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Graph_Changed(object sender, EventArgs e) {
            OnChange((ILGraph)sender,GraphCollectionChangeReason.Changed); 
        }

        /// <summary>
        /// triggers the ILGraphCollectionChanged event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="reason"></param>
        void OnChange (ILGraph sender, GraphCollectionChangeReason reason) {
            if (CollectionChanged != null) 
                CollectionChanged(this, new ILGraphCollectionChangedEventArgs((ILGraph)sender,reason));
        }
        #endregion

        #region Collection manager
        public new void Clear() {
            lock (this) {
                foreach (ILGraph g in this) {
                    g.Dispose(); 
                }
                base.Clear(); 
            }
            m_clippingData.Reset();  
            Invalidate(); 
            OnChange(null,GraphCollectionChangeReason.Deleted); 
        }
        /// <summary>
        /// Add a new surface graph to collection
        /// </summary>
        /// <param name="data">matrix holding data to be plotted</param>
        /// <returns>List of keys used to identify the new graphs</returns>
        public ILSurfaceGraph AddSurfGraph(ILBaseArray data) {
            return (ILSurfaceGraph)Add(data,GraphType.Surf)[0]; 
        }
        /// <summary>
        /// Add a new imagesc graph to collection
        /// </summary>
        /// <param name="data">matrix holding data to be drawn</param>
        /// <returns>newly created graph</returns>
        public ILImageSCGraph AddImageSCGraph(ILBaseArray data) {
            return (ILImageSCGraph)Add(data,GraphType.Imagesc)[0]; 
        }
        /// <summary>
        /// Add new line graph(s) (2D) to collection
        /// </summary>
        /// <param name="data">vector/array with date to be plotted. For arrays, the columns will be used.</param>
        /// <returns>Array of newly created graph(s)</returns>
        public ILPlot2DGraph[] AddPlot2DGraph(ILBaseArray data) {
            List<ILGraph> graphs = Add(data,GraphType.Plot2D);    
            List<ILPlot2DGraph> ret = new List<ILPlot2DGraph>(); 
            foreach (ILGraph g in graphs) 
                ret.Add((ILPlot2DGraph)g); 
            ILColorProvider.Colorize(ret);
            return ret.ToArray(); 
        }
        /// <summary>
        /// Add new X/Y 2D line graph(s) to collection
        /// </summary>
        /// <param name="data">vector/array with date to be plotted. For arrays, the columns will be used.</param>
        /// <returns>Array of newly created graph(s)</returns>
        public ILPlot2DGraph[] AddPlot2DGraph(ILBaseArray XData, ILBaseArray YData) {
            List<ILGraph> graphs = Add(XData,YData,GraphType.Plot2D);    
            List<ILPlot2DGraph> ret = new List<ILPlot2DGraph>(); 
            foreach (ILGraph g in graphs) 
                ret.Add((ILPlot2DGraph)g); 
            ILColorProvider.Colorize(ret);
            return ret.ToArray(); 
        }
        /// <summary>
        /// Add new graph(s) of arbitrary type
        /// </summary>
        /// <param name="data">data to be plotted</param>
        /// <param name="properties">determine GraphType</param>
        /// <returns>List with newly created graph(s)</returns>
        public List<ILGraph> Add (ILBaseArray data, GraphType graphType) {
            if (!data.IsNumeric) 
                throw new ILArgumentException("Add graph: data array must be numeric!");
            List<ILGraph> ret = new List<ILGraph>();
            ILGraph newGraph; 
            ILArray<float> tmpData;
            lock (this) {
                #region add each graph type seperately
                switch (graphType) {
                    case GraphType.Plot2D: 
                        if (data.IsVector || data.IsScalar) {
                            newGraph = m_graphFact.CreateGraph(data,graphType); 
                            Add(newGraph); 
                            newGraph.Changed += new EventHandler(Graph_Changed);
                            m_clippingData.Update(newGraph.Limits); 
                            ret.Add(newGraph);
                        } else if (data.IsMatrix) {
                            // plot columns
                            m_clippingData.EventingSuspend();
                            tmpData = ILMath.tosingle(data); 
                            for (int c = 0; c < tmpData.Dimensions[1]; c++) {
                                newGraph = m_graphFact.CreateGraph(tmpData[null,c],graphType);  
                                Add(newGraph);
                                newGraph.Changed += new EventHandler(Graph_Changed);
                                ret.Add(newGraph); 
                                m_clippingData.Update(newGraph.Limits); 
                            } 
                            m_clippingData.EventingResume(); 
                        }
                        // trigger change event
                        OnChange(ret[0],GraphCollectionChangeReason.Added); 
                        break; 
                    case GraphType.Plot3D: 
                        break; 
                    case GraphType.Mesh: 

                        break; 
                    case GraphType.Surf: 
                        if (data.Dimensions.NonSingletonDimensions != 2) 
                            throw new ILArgumentException("Surf: source data must be a matrix!"); 
                        tmpData = ILMath.tosingle(data); 
                        m_clippingData.EventingSuspend(); 
                        // margin for Z-Direction
                        float min = tmpData.MinValue; 
                        float max = tmpData.MaxValue; 
                        float zmarg = (max - min > 0)? (float)(Math.Abs(max-min)/10.0) : 0.0f; 
                        m_clippingData.Update(new ILPoint3Df(0,0,min - zmarg),new ILPoint3Df(data.Dimensions[1]-1,data.Dimensions[0]-1,max+zmarg)); 
                        m_clippingData.EventingResume(); 
                        newGraph = m_graphFact.CreateGraph(tmpData,graphType);
                        Add(newGraph);
                        newGraph.Changed += new EventHandler(Graph_Changed);
                        // trigger change event
                        ret.Add(newGraph);
                        OnChange(newGraph,GraphCollectionChangeReason.Added); 
                        break;
                    case GraphType.Imagesc:
                        if (!data.IsMatrix) 
                            throw new ILArgumentException("Surf: source data must be a matrix!"); 
                        tmpData = ILMath.tosingle(data); 
                        // note, ImageSC does not contribute to global clipping, except that the clipping 
                        // will be updated to include z = 0! 
                        m_clippingData.EventingSuspend(); 
                        m_clippingData.Update(new ILPoint3Df(-0.5f,-.5f,0),new ILPoint3Df(data.Dimensions[1]-0.5f,data.Dimensions[0]-0.5f,0)); 
                        m_clippingData.EventingResume(); 
                        newGraph = m_graphFact.CreateGraph(tmpData,graphType);
                        Add(newGraph);
                        newGraph.Changed += new EventHandler(Graph_Changed);
                        // trigger change event
                        OnChange(newGraph,GraphCollectionChangeReason.Added); 
                        ret.Add(newGraph);
                        break;
                    default: 
                        throw new ILDrawingException ("the type of drawing is not supported!");
                }
                #endregion
            }
            return ret; 
        }
        /// <summary>
        /// Add new graph(s) of arbitrary type, provide both axis data
        /// </summary>
        /// <param name="xData">data to be plotted</param>
        /// <param name="properties">determine GraphType</param>
        /// <returns>List with newly created graph(s)</returns>
        public List<ILGraph> Add (ILBaseArray xData, ILBaseArray yData, GraphType graphType) {
            if (!yData.IsNumeric || !xData.IsNumeric) 
                throw new ILArgumentException("Add graph: data arrays must be numeric!");
            List<ILGraph> ret = new List<ILGraph>();
            ILGraph newGraph; 
            ILArray<float> tmpDataY, tmpDataX;
            lock (this) {
                #region add each graph type seperately
                switch (graphType) {
                    case GraphType.Plot2D: 
                        if (!yData.Dimensions.IsSameSize(xData.Dimensions))
                            throw new ILArgumentException("Add graph: for X/Y plots, the size of X and Y must be equal!");
                        if (yData.IsVector || yData.IsScalar) {
                            newGraph = m_graphFact.CreateGraph(yData,graphType,xData); 
                            Add(newGraph); 
                            newGraph.Changed += new EventHandler(Graph_Changed);
                            m_clippingData.Update(newGraph.Limits); 
                            ret.Add(newGraph);
                        } else if (yData.IsMatrix) {
                            // plot columns
                            m_clippingData.EventingSuspend();
                            tmpDataY = ILMath.tosingle(yData); 
                            tmpDataX = ILMath.tosingle(xData); 
                            for (int c = 0; c < tmpDataY.Dimensions[1]; c++) {
                                newGraph = m_graphFact.CreateGraph(tmpDataY[null,c],graphType,tmpDataX[null,c]);  
                                Add(newGraph);
                                newGraph.Changed += new EventHandler(Graph_Changed);
                                ret.Add(newGraph); 
                                m_clippingData.Update(newGraph.Limits); 
                            } 
                            m_clippingData.EventingResume(); 
                        }
                        // trigger change event
                        OnChange(ret[0],GraphCollectionChangeReason.Added); 
                        break; 
                    default: 
                        throw new ILDrawingException ("that graph type is not supported yet!");
                }
                #endregion
            }
            return ret; 
        }

        /// <summary>
        /// Remove a graph from the collection and rescale data limits
        /// </summary>
        /// <param name="key">key of graph to be removed</param>
        /// <returns>the ILGraph removed or null, if the key does not exist</returns>
        /// <remarks>If the graph has been removed, the clipping data will be updated and a change event will be fired. </remarks>
        public new bool Remove(ILGraph graph) {
            lock (this) {
                if (!Contains(graph)) return false; 
                base.Remove(graph); 
                // recreate clipping regions 
                m_clippingData.EventingSuspend(); 
                m_clippingData.Reset();  
                foreach (ILGraph gr in this) {
                    m_clippingData.Update (gr.Limits); 
                }
                m_clippingData.EventingResume(); 
                OnChange(graph,GraphCollectionChangeReason.Deleted); 
                Invalidate();
                return true;
            }
        }
        
        #endregion

        #region public interface 
        public void Invalidate() {
            foreach (ILGraph g in this) {
                g.Invalidate(); 
            }
        }
        #endregion

        #region private helper
        #endregion

    }
}
