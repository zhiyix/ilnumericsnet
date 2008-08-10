//////////////////////////////////////////////////////////////////
//                                                              //
//  This is an auto - manipulated source file.                  //
//  Edits inside regions of HYCALPER AUTO GENERATED CODE        //
//  will be lost and overwritten on the next build!             //
//                                                              //
//////////////////////////////////////////////////////////////////
#region LGPL License
/*    
    This file is part of ILNumerics.Net Core Module.

    ILNumerics.Net Core Module is free software: you can redistribute it 
    and/or modify it under the terms of the GNU Lesser General Public 
    License as published by the Free Software Foundation, either version 3
    of the License, or (at your option) any later version.

    ILNumerics.Net Core Module is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with ILNumerics.Net Core Module.  
    If not, see <http://www.gnu.org/licenses/>.
*/
#endregion

using System;
using System.Collections.Generic;
using System.Text;
using ILNumerics.Storage;
using ILNumerics.Misc;
using ILNumerics.Exceptions;
using ILNumerics.BuiltInFunctions;
/*!HC:TYPELIST:
<hycalper>
<type>
    <source locate="after">
        TinCls
    </source>
    <destination><![CDATA[ILArray<complex>]]></destination>
    <destination><![CDATA[ILArray<float>]]></destination>
    <destination><![CDATA[ILArray<fcomplex>]]></destination>
    <destination><![CDATA[ILArray<byte>]]></destination>
    <destination><![CDATA[ILArray<char>]]></destination>
    <destination><![CDATA[ILArray<Int16>]]></destination>
    <destination><![CDATA[ILArray<Int32>]]></destination>
    <destination><![CDATA[ILArray<Int64>]]></destination>
    <destination><![CDATA[ILArray<UInt16>]]></destination>
    <destination><![CDATA[ILArray<UInt32>]]></destination>
    <destination><![CDATA[ILArray<UInt64>]]></destination>
</type>
<type>
    <source locate="after">
        ToutCls
    </source>
    <destination><![CDATA[ILArray<complex>]]></destination>
    <destination><![CDATA[ILArray<float>]]></destination>
    <destination><![CDATA[ILArray<fcomplex>]]></destination>
    <destination><![CDATA[ILLogicalArray]]></destination>
    <destination><![CDATA[ILArray<char>]]></destination>
    <destination><![CDATA[ILArray<Int16>]]></destination>
    <destination><![CDATA[ILArray<Int32>]]></destination>
    <destination><![CDATA[ILArray<Int64>]]></destination>
    <destination><![CDATA[ILArray<UInt16>]]></destination>
    <destination><![CDATA[ILArray<UInt32>]]></destination>
    <destination><![CDATA[ILArray<UInt64>]]></destination>
</type>
<type>
    <source locate="after">
        TindCls
    </source>
    <destination><![CDATA[ILArray<double>]]></destination>
    <destination><![CDATA[ILArray<double>]]></destination>
    <destination><![CDATA[ILArray<double>]]></destination>
    <destination><![CDATA[ILArray<double>]]></destination>
    <destination><![CDATA[ILArray<double>]]></destination>
    <destination><![CDATA[ILArray<double>]]></destination>
    <destination><![CDATA[ILArray<double>]]></destination>
    <destination><![CDATA[ILArray<double>]]></destination>
    <destination><![CDATA[ILArray<double>]]></destination>
    <destination><![CDATA[ILArray<double>]]></destination>
    <destination><![CDATA[ILArray<double>]]></destination>
</type>
<type>
    <source locate="after">
        TinArr
    </source>
    <destination>complex</destination>
    <destination>float</destination>
    <destination>fcomplex</destination>
    <destination>byte</destination>
    <destination>char</destination>
    <destination>Int16</destination>
    <destination>Int32</destination>
    <destination>Int64</destination>
    <destination>UInt16</destination>
    <destination>UInt32</destination>
    <destination>UInt64</destination>
</type>
<type>
    <source locate="after">
        ToutArr
    </source>
    <destination>complex</destination>
    <destination>float</destination>
    <destination>fcomplex</destination>
    <destination>byte</destination>
    <destination>char</destination>
    <destination>Int16</destination>
    <destination>Int32</destination>
    <destination>Int64</destination>
    <destination>UInt16</destination>
    <destination>UInt32</destination>
    <destination>UInt64</destination>
</type>
<type>
    <source locate="after">
        TindArr
    </source>
    <destination>double</destination>
    <destination>double</destination>
    <destination>double</destination>
    <destination>double</destination>
    <destination>double</destination>
    <destination>double</destination>
    <destination>double</destination>
    <destination>double</destination>
    <destination>double</destination>
    <destination>double</destination>
    <destination>double</destination>
</type>
<type>
    <source locate="nextline">
        INIT_VALS
    </source>
    <destination>double result; double curval;</destination>
    <destination>float result; float curval;</destination>
    <destination>float result; float curval;</destination>
    <destination>byte result; byte curval;</destination>
    <destination>char result; char curval;</destination>
    <destination>Int16 result; Int16 curval;</destination>
    <destination>Int32 result; Int32 curval;</destination>
    <destination>Int64 result; Int64 curval;</destination>
    <destination>UInt16 result; UInt16 curval;</destination>
    <destination>UInt32 result; UInt32 curval;</destination>
    <destination>UInt64 result; UInt64 curval;</destination>
</type>
<type>
    <source locate="endregion">
        INIT_COMPLEX
    </source>
    <destination>double curabsval; double curabsmaxval; </destination>
    <destination></destination>
    <destination>float curabsval; float curabsmaxval; </destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
    <destination></destination>
</type>
<type>
    <source locate="endregion">
        #region HYCALPER PRELOOP
    </source>
    <destination>curabsmaxval = double.MinValue; result = new complex(); </destination>
    <destination>result = float.MinValue;</destination>
    <destination>curabsmaxval = float.MinValue; result = new fcomplex();</destination>
    <destination>result = byte.MinValue;</destination>
    <destination>result = char.MinValue;</destination>
    <destination>result = Int16.MinValue;</destination>
    <destination>result = Int32.MinValue;</destination>
    <destination>result = Int64.MinValue;</destination>
    <destination>result = UInt16.MinValue;</destination>
    <destination>result = UInt32.MinValue;</destination>
    <destination>result = UInt64.MinValue;</destination>
</type>
<type>
    <source locate="endregion">#region HYCALPER INNERLOOP</source>
    <destination><![CDATA[curabsval = complex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            ]]></destination>
    <destination><![CDATA[if (curval > result) {
                                                result = curval;
                                            ]]></destination>
    <destination><![CDATA[curabsval = fcomplex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            ]]></destination>
    <destination><![CDATA[if (curval > result) {
                                                result = curval;
                                            ]]></destination>
    <destination><![CDATA[if (curval > result) {
                                                result = curval;
                                            ]]></destination>
    <destination><![CDATA[if (curval > result) {
                                                result = curval;
                                            ]]></destination>
    <destination><![CDATA[if (curval > result) {
                                                result = curval;
                                            ]]></destination>
    <destination><![CDATA[if (curval > result) {
                                                result = curval;
                                            ]]></destination>
    <destination><![CDATA[if (curval > result) {
                                                result = curval;
                                            ]]></destination>
    <destination><![CDATA[if (curval > result) {
                                                result = curval;
                                            ]]></destination>
    <destination><![CDATA[if (curval > result) {
                                                result = curval;
                                            ]]></destination>
</type>
</hycalper>
 */
namespace ILNumerics.BuiltInFunctions  {
	public partial class ILMath {
        #region HYCALPER LOOPSTART R=op(A)
        /// <summary>
        /// Find max value elements along first non singleton dimension
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static /*!HC:ToutCls*/ ILArray<double> max(/*!HC:TinCls*/ ILArray<double> A) {
            if (A.IsScalar)
                return new /*!HC:ToutCls*/ ILArray<double> (A);
            /*!HC:TindCls*/ ILArray<double> dummy = null;  
            return max(A,ref dummy, A.m_dimensions.FirstNonSingleton());
        }
        #endregion HYCALPER LOOPEND R=op(A)
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
        /// <summary>
        /// Find max value elements along first non singleton dimension
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static  ILArray<UInt64> max( ILArray<UInt64> A) {
            if (A.IsScalar)
                return new  ILArray<UInt64> (A);
            ILArray<double> dummy = null;  
            return max(A,ref dummy, A.m_dimensions.FirstNonSingleton());
        }
        /// <summary>
        /// Find max value elements along first non singleton dimension
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static  ILArray<UInt32> max( ILArray<UInt32> A) {
            if (A.IsScalar)
                return new  ILArray<UInt32> (A);
            ILArray<double> dummy = null;  
            return max(A,ref dummy, A.m_dimensions.FirstNonSingleton());
        }
        /// <summary>
        /// Find max value elements along first non singleton dimension
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static  ILArray<UInt16> max( ILArray<UInt16> A) {
            if (A.IsScalar)
                return new  ILArray<UInt16> (A);
            ILArray<double> dummy = null;  
            return max(A,ref dummy, A.m_dimensions.FirstNonSingleton());
        }
        /// <summary>
        /// Find max value elements along first non singleton dimension
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static  ILArray<Int64> max( ILArray<Int64> A) {
            if (A.IsScalar)
                return new  ILArray<Int64> (A);
            ILArray<double> dummy = null;  
            return max(A,ref dummy, A.m_dimensions.FirstNonSingleton());
        }
        /// <summary>
        /// Find max value elements along first non singleton dimension
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static  ILArray<Int32> max( ILArray<Int32> A) {
            if (A.IsScalar)
                return new  ILArray<Int32> (A);
            ILArray<double> dummy = null;  
            return max(A,ref dummy, A.m_dimensions.FirstNonSingleton());
        }
        /// <summary>
        /// Find max value elements along first non singleton dimension
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static  ILArray<Int16> max( ILArray<Int16> A) {
            if (A.IsScalar)
                return new  ILArray<Int16> (A);
            ILArray<double> dummy = null;  
            return max(A,ref dummy, A.m_dimensions.FirstNonSingleton());
        }
        /// <summary>
        /// Find max value elements along first non singleton dimension
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static  ILArray<char> max( ILArray<char> A) {
            if (A.IsScalar)
                return new  ILArray<char> (A);
            ILArray<double> dummy = null;  
            return max(A,ref dummy, A.m_dimensions.FirstNonSingleton());
        }
        /// <summary>
        /// Find max value elements along first non singleton dimension
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static  ILLogicalArray max( ILArray<byte> A) {
            if (A.IsScalar)
                return new  ILLogicalArray (A);
            ILArray<double> dummy = null;  
            return max(A,ref dummy, A.m_dimensions.FirstNonSingleton());
        }
        /// <summary>
        /// Find max value elements along first non singleton dimension
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static  ILArray<fcomplex> max( ILArray<fcomplex> A) {
            if (A.IsScalar)
                return new  ILArray<fcomplex> (A);
            ILArray<double> dummy = null;  
            return max(A,ref dummy, A.m_dimensions.FirstNonSingleton());
        }
        /// <summary>
        /// Find max value elements along first non singleton dimension
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static  ILArray<float> max( ILArray<float> A) {
            if (A.IsScalar)
                return new  ILArray<float> (A);
            ILArray<double> dummy = null;  
            return max(A,ref dummy, A.m_dimensions.FirstNonSingleton());
        }
        /// <summary>
        /// Find max value elements along first non singleton dimension
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public static  ILArray<complex> max( ILArray<complex> A) {
            if (A.IsScalar)
                return new  ILArray<complex> (A);
            ILArray<double> dummy = null;  
            return max(A,ref dummy, A.m_dimensions.FirstNonSingleton());
        }

#endregion HYCALPER AUTO GENERATED CODE

        #region HYCALPER LOOPSTART R=op(A, refI, dim)
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="A">input array, N-dimensional</param>
        /// <param name="I">return value. If this is an instance of an ILArray 
        /// (f.e. 'empty'), on return I will hold the indices into leadDim of  
        /// the maximum values. If, on entering the function, I is null, those indices 
        /// will not be computed and I will be ignored.</param>
        /// <param name="leadDim">index of dimension to operate along</param>
        /// <returns>ILArray of type double. If I was empty  having the dimension 'leadDim' 
        /// reduced to 1 and holding maximum values </returns>
        public static /*!HC:ToutCls*/ ILArray<double> max(/*!HC:TinCls*/ ILArray<double> A, ref /*!HC:TindCls*/ ILArray<double> I, int leadDim) {
			if (A.IsEmpty) {
                if (!object.Equals (I,null))
                    I = /*!HC:TindCls*/ ILArray<double> .empty(); 
                return  /*!HC:ToutCls*/ ILArray<double> .empty(); 
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            if (leadDim == newDims.Length || inDim[leadDim] == 1)
				// scalar or sum over singleton -> return copy
                return (/*!HC:ToutCls*/ ILArray<double> )A.Clone();

			int newLength;
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
            /*!HC:ToutArr*/ double [] retSystemArr;
            retSystemArr = new /*!HC:ToutArr*/ double [newLength];
            int leadDimLen = inDim[leadDim];
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            #region HYCALPER GLOBAL_INIT

            /*!HC:TinArr*/ double result;
            /*!HC:TinArr*/ double curval;
            /*!HC:TindArr*/ double [] indices = null;
            bool createIndices = false; 
            if (!Object.Equals(I,null)) {
                indices = new /*!HC:TindArr*/ double [retSystemArr.Length];
                createIndices = true; 
            } 
            #endregion HYCALPER GLOBAL_INIT
            #region HYCALPER INIT_COMPLEX

            #endregion HYCALPER INIT_COMPLEX

            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
                            fixed (/*!HC:ToutArr*/ double * pOutArr = retSystemArr)
                            fixed (/*!HC:TinArr*/ double * pInArr = A.m_data)
                            fixed (/*!HC:TindArr*/ double * pIndices = indices) {
                                /*!HC:ToutArr*/ double * tmpOut = pOutArr;
                                /*!HC:TindArr*/ double * tmpInd = pIndices;
                                /*!HC:ToutArr*/ double * lastElementOut = tmpOut + retSystemArr.Length;
                                /*!HC:TinArr*/ double * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
                                // start at first element
                                if (createIndices) {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        #region HYCALPER PRELOOP
                                        result = /*!HC:LIMITS*/ double.MinValue;
                                        #endregion HYCALPER PRELOOP
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = (*(tmpIn + *leadDimIdx));
                                            #region HYCALPER INNERLOOP
                                            if (curval > result) {
                                                result = curval;
                                            #endregion HYCALPER INNERLOOP
                                                *tmpInd = (/*!HC:TindArr*/ double )(leadDimIdx - leadDimStart);
                                            }
                                            leadDimIdx ++; 
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = (/*!HC:ToutArr*/ double )result;
                                        #endregion HYCALPER POSTLOOP
                                        tmpInd++;
                                    }
                                } else {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        #region HYCALPER PRELOOP
                                        result = /*!HC:LIMITS*/ double.MinValue;
                                        #endregion HYCALPER PRELOOP
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = *(tmpIn + *leadDimIdx++);
                                            #region HYCALPER INNERLOOP
                                            if (curval > result) {
                                                result = curval;
                                            #endregion HYCALPER INNERLOOP
                                            }
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = (/*!HC:ToutArr*/ double )result;
                                        #endregion HYCALPER POSTLOOP
                                    }
                                }
							}
						}
					} 
#endregion
				} else if (A.IsVector) {
#region Vector
					////////////////////////////   VECTOR   ///////////////////////
                    unsafe {
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int[] curPosition = new int[2];
                        int secDim = (leadDim + 1) % 2;
                        fixed (int* leadDimStart = idxOffset[leadDim])
                        fixed (/*!HC:ToutArr*/ double * pOutArr = retSystemArr)
                        fixed (/*!HC:TinArr*/ double * pInArr = A.m_data) {
                            /*!HC:ToutArr*/ double * tmpOut = pOutArr;
                            /*!HC:TinArr*/ double * tmpIn = pInArr;
                            int* leadDimIdx = leadDimStart;
                            int* leadDimEnd = leadDimStart + leadDimLen;
                            #region HYCALPER PRELOOP
                            result = /*!HC:LIMITS*/ double.MinValue;
                            #endregion HYCALPER PRELOOP
                            // start at first element
                            if (createIndices) {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx);
                                    #region HYCALPER INNERLOOP
                                    if (curval > result) {
                                        result = curval;
                                    #endregion HYCALPER INNERLOOP 
                                        indices[0] = leadDimIdx - leadDimStart;
                                    }
                                    leadDimIdx++; 
                                }
                            } else {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx++);
                                    #region HYCALPER INNERLOOP
                                    if (curval > result) {
                                        result = curval;
                                    #endregion HYCALPER INNERLOOP
                                    }
                                }
                                #region HYCALPER POSTLOOP
                                *tmpOut = (/*!HC:ToutArr*/ double )result;
                                #endregion HYCALPER POSTLOOP
                            }
                        }
                    }
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim])
						fixed (/*!HC:ToutArr*/ double * pOutArr = retSystemArr)
                        fixed (/*!HC:TinArr*/ double * pInArr = A.m_data)
                        fixed (/*!HC:TindArr*/ double * pIndices = indices) {
                            /*!HC:ToutArr*/ double * tmpOut = pOutArr;
                            /*!HC:ToutArr*/ double * lastElementOut = tmpOut + retSystemArr.Length - 1;
                            /*!HC:TinArr*/ double * tmpIn = pInArr;
                            /*!HC:TindArr*/ double * tmpInd = pIndices; 
							int* leadDimIdx = leadDimStart;
							int* leadDimEnd = leadDimStart + leadDimLen;
                            int inc = inDim.SequentialIndexDistance(leadDim); 
							int dimLen = curPosition.Length;
							int d, curD;
                            int outLength = newLength - 1;
                            int outCount = 0; 
                            // start at first element
							if (createIndices) {
                                while (outCount < retSystemArr.Length) {
								    leadDimIdx = leadDimStart;
                                    #region HYCALPER PRELOOP
                                    result = /*!HC:LIMITS*/ double.MinValue;
                                    #endregion HYCALPER PRELOOP
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx);
                                        #region HYCALPER INNERLOOP
                                        if (curval > result) {
                                            result = curval;
                                        #endregion HYCALPER INNERLOOP
                                            *tmpInd = (double)(leadDimIdx - leadDimStart);
                                        }
                                        leadDimIdx++;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = (/*!HC:ToutArr*/ double )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    outCount++; 
                                    // increment higher dimensions 
								    d = 1;
								    while (d < dimLen) {
									    curD = (d + leadDim) % dimLen;
									    tmpIn -= idxOffset[curD, curPosition[curD]];
									    curPosition[curD]++;
									    if (curPosition[curD] < idxOffset[curD].Length) {
										    tmpIn += idxOffset[curD, curPosition[curD]];
										    break;
									    }
									    curPosition[curD] = 0;
									    tmpIn += idxOffset[curD, curPosition[curD]];
									    d++;
								    }
							    }
                            } else {
                                while (outCount < retSystemArr.Length) {
                                    leadDimIdx = leadDimStart;
                                    #region HYCALPER PRELOOP
                                    result = /*!HC:LIMITS*/ double.MinValue;
                                    #endregion HYCALPER PRELOOP
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx++);
                                        #region HYCALPER INNERLOOP
                                        if (curval > result) {
                                            result = curval;
                                        #endregion HYCALPER INNERLOOP
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = (/*!HC:ToutArr*/ double )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= outLength;
                                    outCount++;
                                    // increment higher dimensions 
                                    d = 1;
                                    while (d < dimLen) {
                                        curD = (d + leadDim) % dimLen;
                                        tmpIn -= idxOffset[curD, curPosition[curD]];
                                        curPosition[curD]++;
                                        if (curPosition[curD] < idxOffset[curD].Length) {
                                            tmpIn += idxOffset[curD, curPosition[curD]];
                                            break;
                                        }
                                        curPosition[curD] = 0;
                                        tmpIn += idxOffset[curD, curPosition[curD]];
                                        d++;
                                    }
                                }
                            }
						}
                    }
#endregion
                }
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed (/*!HC:ToutArr*/ double * pOutArr = retSystemArr)
                        fixed (/*!HC:TinArr*/ double * pInArr = A.m_data)
                        fixed (/*!HC:TindArr*/ double * pIndices = indices) {
                            /*!HC:TinArr*/ double * lastElement; 
                            /*!HC:ToutArr*/ double * tmpOut = pOutArr;
                            /*!HC:TinArr*/ double * tmpIn = pInArr;
                            if (createIndices) {
                                /*!HC:TindArr*/ double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    #region HYCALPER PRELOOP
                                    result = /*!HC:LIMITS*/ double.MinValue;
                                    #endregion HYCALPER PRELOOP
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn;
                                        #region HYCALPER INNERLOOP
                                        if (curval > result) {
                                            result = curval;
                                        #endregion HYCALPER INNERLOOP
                                            *tmpInd = (/*!HC:TindArr*/ double )(tmpIn - (lastElement - leadDimLen));
                                        }
                                        tmpIn++;
                                    }
                                    *(tmpOut++) = (/*!HC:ToutArr*/ double )result;
                                    tmpInd++; 
                                }
                            } else {
                                /*!HC:TindArr*/ double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    #region HYCALPER PRELOOP
                                    result = /*!HC:LIMITS*/ double.MinValue;
                                    #endregion HYCALPER PRELOOP
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn++;
                                        #region HYCALPER INNERLOOP
                                        if (curval > result) {
                                            result = curval;
                                        #endregion HYCALPER INNERLOOP
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut++) = (/*!HC:ToutArr*/ double )result;
                                    #endregion HYCALPER POSTLOOP
                                }
                            }
                        }
                    }
#endregion physical along 1st leading dimension
                } else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed (/*!HC:ToutArr*/ double * pOutArr = retSystemArr)
                        fixed (/*!HC:TinArr*/ double * pInArr = A.m_data)
                        fixed (/*!HC:TindArr*/ double * pIndices = indices) {
                            /*!HC:ToutArr*/ double * lastElementOut = newLength + pOutArr - 1;
                            int inLength = inDim.NumberOfElements -1;
                            /*!HC:TinArr*/ double * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim);
                            /*!HC:ToutArr*/ double * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            /*!HC:TinArr*/ double * leadEnd;
                            /*!HC:TinArr*/ double * tmpIn = pInArr;
                            if (createIndices) {
                                /*!HC:TindArr*/ double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    #region HYCALPER PRELOOP
                                    result = /*!HC:LIMITS*/ double.MinValue;
                                    #endregion HYCALPER PRELOOP
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        #region HYCALPER INNERLOOP
                                        if (curval > result) {
                                            result = curval;
                                        #endregion HYCALPER INNERLOOP
                                            *tmpInd = (/*!HC:TindArr*/ double )(leadDimLen - (leadEnd - tmpIn) / inc);
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = (/*!HC:ToutArr*/ double ) result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            } else {
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    #region HYCALPER PRELOOP
                                    result = /*!HC:LIMITS*/ double.MinValue;
                                    #endregion HYCALPER PRELOOP
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        #region HYCALPER INNERLOOP
                                        if (curval > result) {
                                            result = curval;
                                        #endregion HYCALPER INNERLOOP
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = (/*!HC:ToutArr*/ double )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            }
                        }
					}
#endregion
				}
			}
            if (createIndices) {
                I = new /*!HC:TindCls*/ ILArray<double> (indices, newDims);
            }
            return new /*!HC:ToutCls*/ ILArray<double> (retSystemArr, newDims);  
		}
        #endregion HYCALPER LOOPEND R=op(A,refI,dim)
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="A">input array, N-dimensional</param>
        /// <param name="I">return value. If this is an instance of an ILArray 
        /// (f.e. 'empty'), on return I will hold the indices into leadDim of  
        /// the maximum values. If, on entering the function, I is null, those indices 
        /// will not be computed and I will be ignored.</param>
        /// <param name="leadDim">index of dimension to operate along</param>
        /// <returns>ILArray of type double. If I was empty  having the dimension 'leadDim' 
        /// reduced to 1 and holding maximum values </returns>
        public static  ILArray<UInt64> max( ILArray<UInt64> A, ref  ILArray<double> I, int leadDim) {
			if (A.IsEmpty) {
                if (!object.Equals (I,null))
                    I =  ILArray<double> .empty(); 
                return  ILArray<UInt64> .empty(); 
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            if (leadDim == newDims.Length || inDim[leadDim] == 1)
				// scalar or sum over singleton -> return copy
                return ( ILArray<UInt64> )A.Clone();

			int newLength;
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
            UInt64 [] retSystemArr;
            retSystemArr = new  UInt64 [newLength];
            int leadDimLen = inDim[leadDim];
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            #region HYCALPER GLOBAL_INIT

            UInt64 result;
            UInt64 curval;
            double [] indices = null;
            bool createIndices = false; 
            if (!Object.Equals(I,null)) {
                indices = new  double [retSystemArr.Length];
                createIndices = true; 
            } 
            #endregion HYCALPER GLOBAL_INIT
            

            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
                            fixed ( UInt64 * pOutArr = retSystemArr)
                            fixed ( UInt64 * pInArr = A.m_data)
                            fixed ( double * pIndices = indices) {
                                UInt64 * tmpOut = pOutArr;
                                double * tmpInd = pIndices;
                                UInt64 * lastElementOut = tmpOut + retSystemArr.Length;
                                UInt64 * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
                                // start at first element
                                if (createIndices) {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = UInt64.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = (*(tmpIn + *leadDimIdx));
                                            if (curval > result) {
                                                result = curval;
                                            
                                                *tmpInd = ( double )(leadDimIdx - leadDimStart);
                                            }
                                            leadDimIdx ++; 
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( UInt64 )result;
                                        #endregion HYCALPER POSTLOOP
                                        tmpInd++;
                                    }
                                } else {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = UInt64.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = *(tmpIn + *leadDimIdx++);
                                            if (curval > result) {
                                                result = curval;
                                            
                                            }
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( UInt64 )result;
                                        #endregion HYCALPER POSTLOOP
                                    }
                                }
							}
						}
					} 
#endregion
				} else if (A.IsVector) {
#region Vector
					////////////////////////////   VECTOR   ///////////////////////
                    unsafe {
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int[] curPosition = new int[2];
                        int secDim = (leadDim + 1) % 2;
                        fixed (int* leadDimStart = idxOffset[leadDim])
                        fixed ( UInt64 * pOutArr = retSystemArr)
                        fixed ( UInt64 * pInArr = A.m_data) {
                            UInt64 * tmpOut = pOutArr;
                            UInt64 * tmpIn = pInArr;
                            int* leadDimIdx = leadDimStart;
                            int* leadDimEnd = leadDimStart + leadDimLen;
                            result = UInt64.MinValue;
                            // start at first element
                            if (createIndices) {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx);
                                    if (curval > result) {
                                                result = curval;
                                            
                                        indices[0] = leadDimIdx - leadDimStart;
                                    }
                                    leadDimIdx++; 
                                }
                            } else {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx++);
                                    if (curval > result) {
                                                result = curval;
                                            
                                    }
                                }
                                #region HYCALPER POSTLOOP
                                *tmpOut = ( UInt64 )result;
                                #endregion HYCALPER POSTLOOP
                            }
                        }
                    }
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim])
						fixed ( UInt64 * pOutArr = retSystemArr)
                        fixed ( UInt64 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            UInt64 * tmpOut = pOutArr;
                            UInt64 * lastElementOut = tmpOut + retSystemArr.Length - 1;
                            UInt64 * tmpIn = pInArr;
                            double * tmpInd = pIndices; 
							int* leadDimIdx = leadDimStart;
							int* leadDimEnd = leadDimStart + leadDimLen;
                            int inc = inDim.SequentialIndexDistance(leadDim); 
							int dimLen = curPosition.Length;
							int d, curD;
                            int outLength = newLength - 1;
                            int outCount = 0; 
                            // start at first element
							if (createIndices) {
                                while (outCount < retSystemArr.Length) {
								    leadDimIdx = leadDimStart;
                                    result = UInt64.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx);
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = (double)(leadDimIdx - leadDimStart);
                                        }
                                        leadDimIdx++;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( UInt64 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    outCount++; 
                                    // increment higher dimensions 
								    d = 1;
								    while (d < dimLen) {
									    curD = (d + leadDim) % dimLen;
									    tmpIn -= idxOffset[curD, curPosition[curD]];
									    curPosition[curD]++;
									    if (curPosition[curD] < idxOffset[curD].Length) {
										    tmpIn += idxOffset[curD, curPosition[curD]];
										    break;
									    }
									    curPosition[curD] = 0;
									    tmpIn += idxOffset[curD, curPosition[curD]];
									    d++;
								    }
							    }
                            } else {
                                while (outCount < retSystemArr.Length) {
                                    leadDimIdx = leadDimStart;
                                    result = UInt64.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx++);
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( UInt64 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= outLength;
                                    outCount++;
                                    // increment higher dimensions 
                                    d = 1;
                                    while (d < dimLen) {
                                        curD = (d + leadDim) % dimLen;
                                        tmpIn -= idxOffset[curD, curPosition[curD]];
                                        curPosition[curD]++;
                                        if (curPosition[curD] < idxOffset[curD].Length) {
                                            tmpIn += idxOffset[curD, curPosition[curD]];
                                            break;
                                        }
                                        curPosition[curD] = 0;
                                        tmpIn += idxOffset[curD, curPosition[curD]];
                                        d++;
                                    }
                                }
                            }
						}
                    }
#endregion
                }
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( UInt64 * pOutArr = retSystemArr)
                        fixed ( UInt64 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            UInt64 * lastElement; 
                            UInt64 * tmpOut = pOutArr;
                            UInt64 * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = UInt64.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(tmpIn - (lastElement - leadDimLen));
                                        }
                                        tmpIn++;
                                    }
                                    *(tmpOut++) = ( UInt64 )result;
                                    tmpInd++; 
                                }
                            } else {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = UInt64.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn++;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut++) = ( UInt64 )result;
                                    #endregion HYCALPER POSTLOOP
                                }
                            }
                        }
                    }
#endregion physical along 1st leading dimension
                } else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( UInt64 * pOutArr = retSystemArr)
                        fixed ( UInt64 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            UInt64 * lastElementOut = newLength + pOutArr - 1;
                            int inLength = inDim.NumberOfElements -1;
                            UInt64 * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim);
                            UInt64 * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            UInt64 * leadEnd;
                            UInt64 * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = UInt64.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(leadDimLen - (leadEnd - tmpIn) / inc);
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( UInt64 ) result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            } else {
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = UInt64.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( UInt64 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            }
                        }
					}
#endregion
				}
			}
            if (createIndices) {
                I = new  ILArray<double> (indices, newDims);
            }
            return new  ILArray<UInt64> (retSystemArr, newDims);  
		}
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="A">input array, N-dimensional</param>
        /// <param name="I">return value. If this is an instance of an ILArray 
        /// (f.e. 'empty'), on return I will hold the indices into leadDim of  
        /// the maximum values. If, on entering the function, I is null, those indices 
        /// will not be computed and I will be ignored.</param>
        /// <param name="leadDim">index of dimension to operate along</param>
        /// <returns>ILArray of type double. If I was empty  having the dimension 'leadDim' 
        /// reduced to 1 and holding maximum values </returns>
        public static  ILArray<UInt32> max( ILArray<UInt32> A, ref  ILArray<double> I, int leadDim) {
			if (A.IsEmpty) {
                if (!object.Equals (I,null))
                    I =  ILArray<double> .empty(); 
                return  ILArray<UInt32> .empty(); 
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            if (leadDim == newDims.Length || inDim[leadDim] == 1)
				// scalar or sum over singleton -> return copy
                return ( ILArray<UInt32> )A.Clone();

			int newLength;
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
            UInt32 [] retSystemArr;
            retSystemArr = new  UInt32 [newLength];
            int leadDimLen = inDim[leadDim];
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            #region HYCALPER GLOBAL_INIT

            UInt32 result;
            UInt32 curval;
            double [] indices = null;
            bool createIndices = false; 
            if (!Object.Equals(I,null)) {
                indices = new  double [retSystemArr.Length];
                createIndices = true; 
            } 
            #endregion HYCALPER GLOBAL_INIT
            

            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
                            fixed ( UInt32 * pOutArr = retSystemArr)
                            fixed ( UInt32 * pInArr = A.m_data)
                            fixed ( double * pIndices = indices) {
                                UInt32 * tmpOut = pOutArr;
                                double * tmpInd = pIndices;
                                UInt32 * lastElementOut = tmpOut + retSystemArr.Length;
                                UInt32 * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
                                // start at first element
                                if (createIndices) {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = UInt32.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = (*(tmpIn + *leadDimIdx));
                                            if (curval > result) {
                                                result = curval;
                                            
                                                *tmpInd = ( double )(leadDimIdx - leadDimStart);
                                            }
                                            leadDimIdx ++; 
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( UInt32 )result;
                                        #endregion HYCALPER POSTLOOP
                                        tmpInd++;
                                    }
                                } else {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = UInt32.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = *(tmpIn + *leadDimIdx++);
                                            if (curval > result) {
                                                result = curval;
                                            
                                            }
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( UInt32 )result;
                                        #endregion HYCALPER POSTLOOP
                                    }
                                }
							}
						}
					} 
#endregion
				} else if (A.IsVector) {
#region Vector
					////////////////////////////   VECTOR   ///////////////////////
                    unsafe {
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int[] curPosition = new int[2];
                        int secDim = (leadDim + 1) % 2;
                        fixed (int* leadDimStart = idxOffset[leadDim])
                        fixed ( UInt32 * pOutArr = retSystemArr)
                        fixed ( UInt32 * pInArr = A.m_data) {
                            UInt32 * tmpOut = pOutArr;
                            UInt32 * tmpIn = pInArr;
                            int* leadDimIdx = leadDimStart;
                            int* leadDimEnd = leadDimStart + leadDimLen;
                            result = UInt32.MinValue;
                            // start at first element
                            if (createIndices) {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx);
                                    if (curval > result) {
                                                result = curval;
                                            
                                        indices[0] = leadDimIdx - leadDimStart;
                                    }
                                    leadDimIdx++; 
                                }
                            } else {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx++);
                                    if (curval > result) {
                                                result = curval;
                                            
                                    }
                                }
                                #region HYCALPER POSTLOOP
                                *tmpOut = ( UInt32 )result;
                                #endregion HYCALPER POSTLOOP
                            }
                        }
                    }
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim])
						fixed ( UInt32 * pOutArr = retSystemArr)
                        fixed ( UInt32 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            UInt32 * tmpOut = pOutArr;
                            UInt32 * lastElementOut = tmpOut + retSystemArr.Length - 1;
                            UInt32 * tmpIn = pInArr;
                            double * tmpInd = pIndices; 
							int* leadDimIdx = leadDimStart;
							int* leadDimEnd = leadDimStart + leadDimLen;
                            int inc = inDim.SequentialIndexDistance(leadDim); 
							int dimLen = curPosition.Length;
							int d, curD;
                            int outLength = newLength - 1;
                            int outCount = 0; 
                            // start at first element
							if (createIndices) {
                                while (outCount < retSystemArr.Length) {
								    leadDimIdx = leadDimStart;
                                    result = UInt32.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx);
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = (double)(leadDimIdx - leadDimStart);
                                        }
                                        leadDimIdx++;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( UInt32 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    outCount++; 
                                    // increment higher dimensions 
								    d = 1;
								    while (d < dimLen) {
									    curD = (d + leadDim) % dimLen;
									    tmpIn -= idxOffset[curD, curPosition[curD]];
									    curPosition[curD]++;
									    if (curPosition[curD] < idxOffset[curD].Length) {
										    tmpIn += idxOffset[curD, curPosition[curD]];
										    break;
									    }
									    curPosition[curD] = 0;
									    tmpIn += idxOffset[curD, curPosition[curD]];
									    d++;
								    }
							    }
                            } else {
                                while (outCount < retSystemArr.Length) {
                                    leadDimIdx = leadDimStart;
                                    result = UInt32.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx++);
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( UInt32 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= outLength;
                                    outCount++;
                                    // increment higher dimensions 
                                    d = 1;
                                    while (d < dimLen) {
                                        curD = (d + leadDim) % dimLen;
                                        tmpIn -= idxOffset[curD, curPosition[curD]];
                                        curPosition[curD]++;
                                        if (curPosition[curD] < idxOffset[curD].Length) {
                                            tmpIn += idxOffset[curD, curPosition[curD]];
                                            break;
                                        }
                                        curPosition[curD] = 0;
                                        tmpIn += idxOffset[curD, curPosition[curD]];
                                        d++;
                                    }
                                }
                            }
						}
                    }
#endregion
                }
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( UInt32 * pOutArr = retSystemArr)
                        fixed ( UInt32 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            UInt32 * lastElement; 
                            UInt32 * tmpOut = pOutArr;
                            UInt32 * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = UInt32.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(tmpIn - (lastElement - leadDimLen));
                                        }
                                        tmpIn++;
                                    }
                                    *(tmpOut++) = ( UInt32 )result;
                                    tmpInd++; 
                                }
                            } else {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = UInt32.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn++;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut++) = ( UInt32 )result;
                                    #endregion HYCALPER POSTLOOP
                                }
                            }
                        }
                    }
#endregion physical along 1st leading dimension
                } else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( UInt32 * pOutArr = retSystemArr)
                        fixed ( UInt32 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            UInt32 * lastElementOut = newLength + pOutArr - 1;
                            int inLength = inDim.NumberOfElements -1;
                            UInt32 * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim);
                            UInt32 * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            UInt32 * leadEnd;
                            UInt32 * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = UInt32.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(leadDimLen - (leadEnd - tmpIn) / inc);
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( UInt32 ) result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            } else {
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = UInt32.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( UInt32 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            }
                        }
					}
#endregion
				}
			}
            if (createIndices) {
                I = new  ILArray<double> (indices, newDims);
            }
            return new  ILArray<UInt32> (retSystemArr, newDims);  
		}
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="A">input array, N-dimensional</param>
        /// <param name="I">return value. If this is an instance of an ILArray 
        /// (f.e. 'empty'), on return I will hold the indices into leadDim of  
        /// the maximum values. If, on entering the function, I is null, those indices 
        /// will not be computed and I will be ignored.</param>
        /// <param name="leadDim">index of dimension to operate along</param>
        /// <returns>ILArray of type double. If I was empty  having the dimension 'leadDim' 
        /// reduced to 1 and holding maximum values </returns>
        public static  ILArray<UInt16> max( ILArray<UInt16> A, ref  ILArray<double> I, int leadDim) {
			if (A.IsEmpty) {
                if (!object.Equals (I,null))
                    I =  ILArray<double> .empty(); 
                return  ILArray<UInt16> .empty(); 
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            if (leadDim == newDims.Length || inDim[leadDim] == 1)
				// scalar or sum over singleton -> return copy
                return ( ILArray<UInt16> )A.Clone();

			int newLength;
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
            UInt16 [] retSystemArr;
            retSystemArr = new  UInt16 [newLength];
            int leadDimLen = inDim[leadDim];
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            #region HYCALPER GLOBAL_INIT

            UInt16 result;
            UInt16 curval;
            double [] indices = null;
            bool createIndices = false; 
            if (!Object.Equals(I,null)) {
                indices = new  double [retSystemArr.Length];
                createIndices = true; 
            } 
            #endregion HYCALPER GLOBAL_INIT
            

            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
                            fixed ( UInt16 * pOutArr = retSystemArr)
                            fixed ( UInt16 * pInArr = A.m_data)
                            fixed ( double * pIndices = indices) {
                                UInt16 * tmpOut = pOutArr;
                                double * tmpInd = pIndices;
                                UInt16 * lastElementOut = tmpOut + retSystemArr.Length;
                                UInt16 * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
                                // start at first element
                                if (createIndices) {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = UInt16.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = (*(tmpIn + *leadDimIdx));
                                            if (curval > result) {
                                                result = curval;
                                            
                                                *tmpInd = ( double )(leadDimIdx - leadDimStart);
                                            }
                                            leadDimIdx ++; 
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( UInt16 )result;
                                        #endregion HYCALPER POSTLOOP
                                        tmpInd++;
                                    }
                                } else {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = UInt16.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = *(tmpIn + *leadDimIdx++);
                                            if (curval > result) {
                                                result = curval;
                                            
                                            }
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( UInt16 )result;
                                        #endregion HYCALPER POSTLOOP
                                    }
                                }
							}
						}
					} 
#endregion
				} else if (A.IsVector) {
#region Vector
					////////////////////////////   VECTOR   ///////////////////////
                    unsafe {
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int[] curPosition = new int[2];
                        int secDim = (leadDim + 1) % 2;
                        fixed (int* leadDimStart = idxOffset[leadDim])
                        fixed ( UInt16 * pOutArr = retSystemArr)
                        fixed ( UInt16 * pInArr = A.m_data) {
                            UInt16 * tmpOut = pOutArr;
                            UInt16 * tmpIn = pInArr;
                            int* leadDimIdx = leadDimStart;
                            int* leadDimEnd = leadDimStart + leadDimLen;
                            result = UInt16.MinValue;
                            // start at first element
                            if (createIndices) {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx);
                                    if (curval > result) {
                                                result = curval;
                                            
                                        indices[0] = leadDimIdx - leadDimStart;
                                    }
                                    leadDimIdx++; 
                                }
                            } else {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx++);
                                    if (curval > result) {
                                                result = curval;
                                            
                                    }
                                }
                                #region HYCALPER POSTLOOP
                                *tmpOut = ( UInt16 )result;
                                #endregion HYCALPER POSTLOOP
                            }
                        }
                    }
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim])
						fixed ( UInt16 * pOutArr = retSystemArr)
                        fixed ( UInt16 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            UInt16 * tmpOut = pOutArr;
                            UInt16 * lastElementOut = tmpOut + retSystemArr.Length - 1;
                            UInt16 * tmpIn = pInArr;
                            double * tmpInd = pIndices; 
							int* leadDimIdx = leadDimStart;
							int* leadDimEnd = leadDimStart + leadDimLen;
                            int inc = inDim.SequentialIndexDistance(leadDim); 
							int dimLen = curPosition.Length;
							int d, curD;
                            int outLength = newLength - 1;
                            int outCount = 0; 
                            // start at first element
							if (createIndices) {
                                while (outCount < retSystemArr.Length) {
								    leadDimIdx = leadDimStart;
                                    result = UInt16.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx);
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = (double)(leadDimIdx - leadDimStart);
                                        }
                                        leadDimIdx++;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( UInt16 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    outCount++; 
                                    // increment higher dimensions 
								    d = 1;
								    while (d < dimLen) {
									    curD = (d + leadDim) % dimLen;
									    tmpIn -= idxOffset[curD, curPosition[curD]];
									    curPosition[curD]++;
									    if (curPosition[curD] < idxOffset[curD].Length) {
										    tmpIn += idxOffset[curD, curPosition[curD]];
										    break;
									    }
									    curPosition[curD] = 0;
									    tmpIn += idxOffset[curD, curPosition[curD]];
									    d++;
								    }
							    }
                            } else {
                                while (outCount < retSystemArr.Length) {
                                    leadDimIdx = leadDimStart;
                                    result = UInt16.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx++);
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( UInt16 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= outLength;
                                    outCount++;
                                    // increment higher dimensions 
                                    d = 1;
                                    while (d < dimLen) {
                                        curD = (d + leadDim) % dimLen;
                                        tmpIn -= idxOffset[curD, curPosition[curD]];
                                        curPosition[curD]++;
                                        if (curPosition[curD] < idxOffset[curD].Length) {
                                            tmpIn += idxOffset[curD, curPosition[curD]];
                                            break;
                                        }
                                        curPosition[curD] = 0;
                                        tmpIn += idxOffset[curD, curPosition[curD]];
                                        d++;
                                    }
                                }
                            }
						}
                    }
#endregion
                }
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( UInt16 * pOutArr = retSystemArr)
                        fixed ( UInt16 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            UInt16 * lastElement; 
                            UInt16 * tmpOut = pOutArr;
                            UInt16 * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = UInt16.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(tmpIn - (lastElement - leadDimLen));
                                        }
                                        tmpIn++;
                                    }
                                    *(tmpOut++) = ( UInt16 )result;
                                    tmpInd++; 
                                }
                            } else {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = UInt16.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn++;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut++) = ( UInt16 )result;
                                    #endregion HYCALPER POSTLOOP
                                }
                            }
                        }
                    }
#endregion physical along 1st leading dimension
                } else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( UInt16 * pOutArr = retSystemArr)
                        fixed ( UInt16 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            UInt16 * lastElementOut = newLength + pOutArr - 1;
                            int inLength = inDim.NumberOfElements -1;
                            UInt16 * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim);
                            UInt16 * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            UInt16 * leadEnd;
                            UInt16 * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = UInt16.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(leadDimLen - (leadEnd - tmpIn) / inc);
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( UInt16 ) result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            } else {
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = UInt16.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( UInt16 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            }
                        }
					}
#endregion
				}
			}
            if (createIndices) {
                I = new  ILArray<double> (indices, newDims);
            }
            return new  ILArray<UInt16> (retSystemArr, newDims);  
		}
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="A">input array, N-dimensional</param>
        /// <param name="I">return value. If this is an instance of an ILArray 
        /// (f.e. 'empty'), on return I will hold the indices into leadDim of  
        /// the maximum values. If, on entering the function, I is null, those indices 
        /// will not be computed and I will be ignored.</param>
        /// <param name="leadDim">index of dimension to operate along</param>
        /// <returns>ILArray of type double. If I was empty  having the dimension 'leadDim' 
        /// reduced to 1 and holding maximum values </returns>
        public static  ILArray<Int64> max( ILArray<Int64> A, ref  ILArray<double> I, int leadDim) {
			if (A.IsEmpty) {
                if (!object.Equals (I,null))
                    I =  ILArray<double> .empty(); 
                return  ILArray<Int64> .empty(); 
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            if (leadDim == newDims.Length || inDim[leadDim] == 1)
				// scalar or sum over singleton -> return copy
                return ( ILArray<Int64> )A.Clone();

			int newLength;
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
            Int64 [] retSystemArr;
            retSystemArr = new  Int64 [newLength];
            int leadDimLen = inDim[leadDim];
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            #region HYCALPER GLOBAL_INIT

            Int64 result;
            Int64 curval;
            double [] indices = null;
            bool createIndices = false; 
            if (!Object.Equals(I,null)) {
                indices = new  double [retSystemArr.Length];
                createIndices = true; 
            } 
            #endregion HYCALPER GLOBAL_INIT
            

            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
                            fixed ( Int64 * pOutArr = retSystemArr)
                            fixed ( Int64 * pInArr = A.m_data)
                            fixed ( double * pIndices = indices) {
                                Int64 * tmpOut = pOutArr;
                                double * tmpInd = pIndices;
                                Int64 * lastElementOut = tmpOut + retSystemArr.Length;
                                Int64 * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
                                // start at first element
                                if (createIndices) {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = Int64.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = (*(tmpIn + *leadDimIdx));
                                            if (curval > result) {
                                                result = curval;
                                            
                                                *tmpInd = ( double )(leadDimIdx - leadDimStart);
                                            }
                                            leadDimIdx ++; 
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( Int64 )result;
                                        #endregion HYCALPER POSTLOOP
                                        tmpInd++;
                                    }
                                } else {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = Int64.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = *(tmpIn + *leadDimIdx++);
                                            if (curval > result) {
                                                result = curval;
                                            
                                            }
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( Int64 )result;
                                        #endregion HYCALPER POSTLOOP
                                    }
                                }
							}
						}
					} 
#endregion
				} else if (A.IsVector) {
#region Vector
					////////////////////////////   VECTOR   ///////////////////////
                    unsafe {
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int[] curPosition = new int[2];
                        int secDim = (leadDim + 1) % 2;
                        fixed (int* leadDimStart = idxOffset[leadDim])
                        fixed ( Int64 * pOutArr = retSystemArr)
                        fixed ( Int64 * pInArr = A.m_data) {
                            Int64 * tmpOut = pOutArr;
                            Int64 * tmpIn = pInArr;
                            int* leadDimIdx = leadDimStart;
                            int* leadDimEnd = leadDimStart + leadDimLen;
                            result = Int64.MinValue;
                            // start at first element
                            if (createIndices) {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx);
                                    if (curval > result) {
                                                result = curval;
                                            
                                        indices[0] = leadDimIdx - leadDimStart;
                                    }
                                    leadDimIdx++; 
                                }
                            } else {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx++);
                                    if (curval > result) {
                                                result = curval;
                                            
                                    }
                                }
                                #region HYCALPER POSTLOOP
                                *tmpOut = ( Int64 )result;
                                #endregion HYCALPER POSTLOOP
                            }
                        }
                    }
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim])
						fixed ( Int64 * pOutArr = retSystemArr)
                        fixed ( Int64 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            Int64 * tmpOut = pOutArr;
                            Int64 * lastElementOut = tmpOut + retSystemArr.Length - 1;
                            Int64 * tmpIn = pInArr;
                            double * tmpInd = pIndices; 
							int* leadDimIdx = leadDimStart;
							int* leadDimEnd = leadDimStart + leadDimLen;
                            int inc = inDim.SequentialIndexDistance(leadDim); 
							int dimLen = curPosition.Length;
							int d, curD;
                            int outLength = newLength - 1;
                            int outCount = 0; 
                            // start at first element
							if (createIndices) {
                                while (outCount < retSystemArr.Length) {
								    leadDimIdx = leadDimStart;
                                    result = Int64.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx);
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = (double)(leadDimIdx - leadDimStart);
                                        }
                                        leadDimIdx++;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( Int64 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    outCount++; 
                                    // increment higher dimensions 
								    d = 1;
								    while (d < dimLen) {
									    curD = (d + leadDim) % dimLen;
									    tmpIn -= idxOffset[curD, curPosition[curD]];
									    curPosition[curD]++;
									    if (curPosition[curD] < idxOffset[curD].Length) {
										    tmpIn += idxOffset[curD, curPosition[curD]];
										    break;
									    }
									    curPosition[curD] = 0;
									    tmpIn += idxOffset[curD, curPosition[curD]];
									    d++;
								    }
							    }
                            } else {
                                while (outCount < retSystemArr.Length) {
                                    leadDimIdx = leadDimStart;
                                    result = Int64.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx++);
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( Int64 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= outLength;
                                    outCount++;
                                    // increment higher dimensions 
                                    d = 1;
                                    while (d < dimLen) {
                                        curD = (d + leadDim) % dimLen;
                                        tmpIn -= idxOffset[curD, curPosition[curD]];
                                        curPosition[curD]++;
                                        if (curPosition[curD] < idxOffset[curD].Length) {
                                            tmpIn += idxOffset[curD, curPosition[curD]];
                                            break;
                                        }
                                        curPosition[curD] = 0;
                                        tmpIn += idxOffset[curD, curPosition[curD]];
                                        d++;
                                    }
                                }
                            }
						}
                    }
#endregion
                }
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( Int64 * pOutArr = retSystemArr)
                        fixed ( Int64 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            Int64 * lastElement; 
                            Int64 * tmpOut = pOutArr;
                            Int64 * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = Int64.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(tmpIn - (lastElement - leadDimLen));
                                        }
                                        tmpIn++;
                                    }
                                    *(tmpOut++) = ( Int64 )result;
                                    tmpInd++; 
                                }
                            } else {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = Int64.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn++;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut++) = ( Int64 )result;
                                    #endregion HYCALPER POSTLOOP
                                }
                            }
                        }
                    }
#endregion physical along 1st leading dimension
                } else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( Int64 * pOutArr = retSystemArr)
                        fixed ( Int64 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            Int64 * lastElementOut = newLength + pOutArr - 1;
                            int inLength = inDim.NumberOfElements -1;
                            Int64 * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim);
                            Int64 * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            Int64 * leadEnd;
                            Int64 * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = Int64.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(leadDimLen - (leadEnd - tmpIn) / inc);
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( Int64 ) result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            } else {
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = Int64.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( Int64 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            }
                        }
					}
#endregion
				}
			}
            if (createIndices) {
                I = new  ILArray<double> (indices, newDims);
            }
            return new  ILArray<Int64> (retSystemArr, newDims);  
		}
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="A">input array, N-dimensional</param>
        /// <param name="I">return value. If this is an instance of an ILArray 
        /// (f.e. 'empty'), on return I will hold the indices into leadDim of  
        /// the maximum values. If, on entering the function, I is null, those indices 
        /// will not be computed and I will be ignored.</param>
        /// <param name="leadDim">index of dimension to operate along</param>
        /// <returns>ILArray of type double. If I was empty  having the dimension 'leadDim' 
        /// reduced to 1 and holding maximum values </returns>
        public static  ILArray<Int32> max( ILArray<Int32> A, ref  ILArray<double> I, int leadDim) {
			if (A.IsEmpty) {
                if (!object.Equals (I,null))
                    I =  ILArray<double> .empty(); 
                return  ILArray<Int32> .empty(); 
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            if (leadDim == newDims.Length || inDim[leadDim] == 1)
				// scalar or sum over singleton -> return copy
                return ( ILArray<Int32> )A.Clone();

			int newLength;
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
            Int32 [] retSystemArr;
            retSystemArr = new  Int32 [newLength];
            int leadDimLen = inDim[leadDim];
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            #region HYCALPER GLOBAL_INIT

            Int32 result;
            Int32 curval;
            double [] indices = null;
            bool createIndices = false; 
            if (!Object.Equals(I,null)) {
                indices = new  double [retSystemArr.Length];
                createIndices = true; 
            } 
            #endregion HYCALPER GLOBAL_INIT
            

            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
                            fixed ( Int32 * pOutArr = retSystemArr)
                            fixed ( Int32 * pInArr = A.m_data)
                            fixed ( double * pIndices = indices) {
                                Int32 * tmpOut = pOutArr;
                                double * tmpInd = pIndices;
                                Int32 * lastElementOut = tmpOut + retSystemArr.Length;
                                Int32 * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
                                // start at first element
                                if (createIndices) {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = Int32.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = (*(tmpIn + *leadDimIdx));
                                            if (curval > result) {
                                                result = curval;
                                            
                                                *tmpInd = ( double )(leadDimIdx - leadDimStart);
                                            }
                                            leadDimIdx ++; 
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( Int32 )result;
                                        #endregion HYCALPER POSTLOOP
                                        tmpInd++;
                                    }
                                } else {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = Int32.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = *(tmpIn + *leadDimIdx++);
                                            if (curval > result) {
                                                result = curval;
                                            
                                            }
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( Int32 )result;
                                        #endregion HYCALPER POSTLOOP
                                    }
                                }
							}
						}
					} 
#endregion
				} else if (A.IsVector) {
#region Vector
					////////////////////////////   VECTOR   ///////////////////////
                    unsafe {
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int[] curPosition = new int[2];
                        int secDim = (leadDim + 1) % 2;
                        fixed (int* leadDimStart = idxOffset[leadDim])
                        fixed ( Int32 * pOutArr = retSystemArr)
                        fixed ( Int32 * pInArr = A.m_data) {
                            Int32 * tmpOut = pOutArr;
                            Int32 * tmpIn = pInArr;
                            int* leadDimIdx = leadDimStart;
                            int* leadDimEnd = leadDimStart + leadDimLen;
                            result = Int32.MinValue;
                            // start at first element
                            if (createIndices) {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx);
                                    if (curval > result) {
                                                result = curval;
                                            
                                        indices[0] = leadDimIdx - leadDimStart;
                                    }
                                    leadDimIdx++; 
                                }
                            } else {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx++);
                                    if (curval > result) {
                                                result = curval;
                                            
                                    }
                                }
                                #region HYCALPER POSTLOOP
                                *tmpOut = ( Int32 )result;
                                #endregion HYCALPER POSTLOOP
                            }
                        }
                    }
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim])
						fixed ( Int32 * pOutArr = retSystemArr)
                        fixed ( Int32 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            Int32 * tmpOut = pOutArr;
                            Int32 * lastElementOut = tmpOut + retSystemArr.Length - 1;
                            Int32 * tmpIn = pInArr;
                            double * tmpInd = pIndices; 
							int* leadDimIdx = leadDimStart;
							int* leadDimEnd = leadDimStart + leadDimLen;
                            int inc = inDim.SequentialIndexDistance(leadDim); 
							int dimLen = curPosition.Length;
							int d, curD;
                            int outLength = newLength - 1;
                            int outCount = 0; 
                            // start at first element
							if (createIndices) {
                                while (outCount < retSystemArr.Length) {
								    leadDimIdx = leadDimStart;
                                    result = Int32.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx);
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = (double)(leadDimIdx - leadDimStart);
                                        }
                                        leadDimIdx++;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( Int32 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    outCount++; 
                                    // increment higher dimensions 
								    d = 1;
								    while (d < dimLen) {
									    curD = (d + leadDim) % dimLen;
									    tmpIn -= idxOffset[curD, curPosition[curD]];
									    curPosition[curD]++;
									    if (curPosition[curD] < idxOffset[curD].Length) {
										    tmpIn += idxOffset[curD, curPosition[curD]];
										    break;
									    }
									    curPosition[curD] = 0;
									    tmpIn += idxOffset[curD, curPosition[curD]];
									    d++;
								    }
							    }
                            } else {
                                while (outCount < retSystemArr.Length) {
                                    leadDimIdx = leadDimStart;
                                    result = Int32.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx++);
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( Int32 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= outLength;
                                    outCount++;
                                    // increment higher dimensions 
                                    d = 1;
                                    while (d < dimLen) {
                                        curD = (d + leadDim) % dimLen;
                                        tmpIn -= idxOffset[curD, curPosition[curD]];
                                        curPosition[curD]++;
                                        if (curPosition[curD] < idxOffset[curD].Length) {
                                            tmpIn += idxOffset[curD, curPosition[curD]];
                                            break;
                                        }
                                        curPosition[curD] = 0;
                                        tmpIn += idxOffset[curD, curPosition[curD]];
                                        d++;
                                    }
                                }
                            }
						}
                    }
#endregion
                }
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( Int32 * pOutArr = retSystemArr)
                        fixed ( Int32 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            Int32 * lastElement; 
                            Int32 * tmpOut = pOutArr;
                            Int32 * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = Int32.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(tmpIn - (lastElement - leadDimLen));
                                        }
                                        tmpIn++;
                                    }
                                    *(tmpOut++) = ( Int32 )result;
                                    tmpInd++; 
                                }
                            } else {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = Int32.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn++;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut++) = ( Int32 )result;
                                    #endregion HYCALPER POSTLOOP
                                }
                            }
                        }
                    }
#endregion physical along 1st leading dimension
                } else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( Int32 * pOutArr = retSystemArr)
                        fixed ( Int32 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            Int32 * lastElementOut = newLength + pOutArr - 1;
                            int inLength = inDim.NumberOfElements -1;
                            Int32 * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim);
                            Int32 * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            Int32 * leadEnd;
                            Int32 * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = Int32.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(leadDimLen - (leadEnd - tmpIn) / inc);
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( Int32 ) result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            } else {
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = Int32.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( Int32 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            }
                        }
					}
#endregion
				}
			}
            if (createIndices) {
                I = new  ILArray<double> (indices, newDims);
            }
            return new  ILArray<Int32> (retSystemArr, newDims);  
		}
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="A">input array, N-dimensional</param>
        /// <param name="I">return value. If this is an instance of an ILArray 
        /// (f.e. 'empty'), on return I will hold the indices into leadDim of  
        /// the maximum values. If, on entering the function, I is null, those indices 
        /// will not be computed and I will be ignored.</param>
        /// <param name="leadDim">index of dimension to operate along</param>
        /// <returns>ILArray of type double. If I was empty  having the dimension 'leadDim' 
        /// reduced to 1 and holding maximum values </returns>
        public static  ILArray<Int16> max( ILArray<Int16> A, ref  ILArray<double> I, int leadDim) {
			if (A.IsEmpty) {
                if (!object.Equals (I,null))
                    I =  ILArray<double> .empty(); 
                return  ILArray<Int16> .empty(); 
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            if (leadDim == newDims.Length || inDim[leadDim] == 1)
				// scalar or sum over singleton -> return copy
                return ( ILArray<Int16> )A.Clone();

			int newLength;
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
            Int16 [] retSystemArr;
            retSystemArr = new  Int16 [newLength];
            int leadDimLen = inDim[leadDim];
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            #region HYCALPER GLOBAL_INIT

            Int16 result;
            Int16 curval;
            double [] indices = null;
            bool createIndices = false; 
            if (!Object.Equals(I,null)) {
                indices = new  double [retSystemArr.Length];
                createIndices = true; 
            } 
            #endregion HYCALPER GLOBAL_INIT
            

            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
                            fixed ( Int16 * pOutArr = retSystemArr)
                            fixed ( Int16 * pInArr = A.m_data)
                            fixed ( double * pIndices = indices) {
                                Int16 * tmpOut = pOutArr;
                                double * tmpInd = pIndices;
                                Int16 * lastElementOut = tmpOut + retSystemArr.Length;
                                Int16 * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
                                // start at first element
                                if (createIndices) {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = Int16.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = (*(tmpIn + *leadDimIdx));
                                            if (curval > result) {
                                                result = curval;
                                            
                                                *tmpInd = ( double )(leadDimIdx - leadDimStart);
                                            }
                                            leadDimIdx ++; 
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( Int16 )result;
                                        #endregion HYCALPER POSTLOOP
                                        tmpInd++;
                                    }
                                } else {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = Int16.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = *(tmpIn + *leadDimIdx++);
                                            if (curval > result) {
                                                result = curval;
                                            
                                            }
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( Int16 )result;
                                        #endregion HYCALPER POSTLOOP
                                    }
                                }
							}
						}
					} 
#endregion
				} else if (A.IsVector) {
#region Vector
					////////////////////////////   VECTOR   ///////////////////////
                    unsafe {
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int[] curPosition = new int[2];
                        int secDim = (leadDim + 1) % 2;
                        fixed (int* leadDimStart = idxOffset[leadDim])
                        fixed ( Int16 * pOutArr = retSystemArr)
                        fixed ( Int16 * pInArr = A.m_data) {
                            Int16 * tmpOut = pOutArr;
                            Int16 * tmpIn = pInArr;
                            int* leadDimIdx = leadDimStart;
                            int* leadDimEnd = leadDimStart + leadDimLen;
                            result = Int16.MinValue;
                            // start at first element
                            if (createIndices) {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx);
                                    if (curval > result) {
                                                result = curval;
                                            
                                        indices[0] = leadDimIdx - leadDimStart;
                                    }
                                    leadDimIdx++; 
                                }
                            } else {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx++);
                                    if (curval > result) {
                                                result = curval;
                                            
                                    }
                                }
                                #region HYCALPER POSTLOOP
                                *tmpOut = ( Int16 )result;
                                #endregion HYCALPER POSTLOOP
                            }
                        }
                    }
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim])
						fixed ( Int16 * pOutArr = retSystemArr)
                        fixed ( Int16 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            Int16 * tmpOut = pOutArr;
                            Int16 * lastElementOut = tmpOut + retSystemArr.Length - 1;
                            Int16 * tmpIn = pInArr;
                            double * tmpInd = pIndices; 
							int* leadDimIdx = leadDimStart;
							int* leadDimEnd = leadDimStart + leadDimLen;
                            int inc = inDim.SequentialIndexDistance(leadDim); 
							int dimLen = curPosition.Length;
							int d, curD;
                            int outLength = newLength - 1;
                            int outCount = 0; 
                            // start at first element
							if (createIndices) {
                                while (outCount < retSystemArr.Length) {
								    leadDimIdx = leadDimStart;
                                    result = Int16.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx);
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = (double)(leadDimIdx - leadDimStart);
                                        }
                                        leadDimIdx++;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( Int16 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    outCount++; 
                                    // increment higher dimensions 
								    d = 1;
								    while (d < dimLen) {
									    curD = (d + leadDim) % dimLen;
									    tmpIn -= idxOffset[curD, curPosition[curD]];
									    curPosition[curD]++;
									    if (curPosition[curD] < idxOffset[curD].Length) {
										    tmpIn += idxOffset[curD, curPosition[curD]];
										    break;
									    }
									    curPosition[curD] = 0;
									    tmpIn += idxOffset[curD, curPosition[curD]];
									    d++;
								    }
							    }
                            } else {
                                while (outCount < retSystemArr.Length) {
                                    leadDimIdx = leadDimStart;
                                    result = Int16.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx++);
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( Int16 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= outLength;
                                    outCount++;
                                    // increment higher dimensions 
                                    d = 1;
                                    while (d < dimLen) {
                                        curD = (d + leadDim) % dimLen;
                                        tmpIn -= idxOffset[curD, curPosition[curD]];
                                        curPosition[curD]++;
                                        if (curPosition[curD] < idxOffset[curD].Length) {
                                            tmpIn += idxOffset[curD, curPosition[curD]];
                                            break;
                                        }
                                        curPosition[curD] = 0;
                                        tmpIn += idxOffset[curD, curPosition[curD]];
                                        d++;
                                    }
                                }
                            }
						}
                    }
#endregion
                }
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( Int16 * pOutArr = retSystemArr)
                        fixed ( Int16 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            Int16 * lastElement; 
                            Int16 * tmpOut = pOutArr;
                            Int16 * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = Int16.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(tmpIn - (lastElement - leadDimLen));
                                        }
                                        tmpIn++;
                                    }
                                    *(tmpOut++) = ( Int16 )result;
                                    tmpInd++; 
                                }
                            } else {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = Int16.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn++;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut++) = ( Int16 )result;
                                    #endregion HYCALPER POSTLOOP
                                }
                            }
                        }
                    }
#endregion physical along 1st leading dimension
                } else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( Int16 * pOutArr = retSystemArr)
                        fixed ( Int16 * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            Int16 * lastElementOut = newLength + pOutArr - 1;
                            int inLength = inDim.NumberOfElements -1;
                            Int16 * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim);
                            Int16 * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            Int16 * leadEnd;
                            Int16 * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = Int16.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(leadDimLen - (leadEnd - tmpIn) / inc);
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( Int16 ) result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            } else {
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = Int16.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( Int16 )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            }
                        }
					}
#endregion
				}
			}
            if (createIndices) {
                I = new  ILArray<double> (indices, newDims);
            }
            return new  ILArray<Int16> (retSystemArr, newDims);  
		}
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="A">input array, N-dimensional</param>
        /// <param name="I">return value. If this is an instance of an ILArray 
        /// (f.e. 'empty'), on return I will hold the indices into leadDim of  
        /// the maximum values. If, on entering the function, I is null, those indices 
        /// will not be computed and I will be ignored.</param>
        /// <param name="leadDim">index of dimension to operate along</param>
        /// <returns>ILArray of type double. If I was empty  having the dimension 'leadDim' 
        /// reduced to 1 and holding maximum values </returns>
        public static  ILArray<char> max( ILArray<char> A, ref  ILArray<double> I, int leadDim) {
			if (A.IsEmpty) {
                if (!object.Equals (I,null))
                    I =  ILArray<double> .empty(); 
                return  ILArray<char> .empty(); 
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            if (leadDim == newDims.Length || inDim[leadDim] == 1)
				// scalar or sum over singleton -> return copy
                return ( ILArray<char> )A.Clone();

			int newLength;
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
            char [] retSystemArr;
            retSystemArr = new  char [newLength];
            int leadDimLen = inDim[leadDim];
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            #region HYCALPER GLOBAL_INIT

            char result;
            char curval;
            double [] indices = null;
            bool createIndices = false; 
            if (!Object.Equals(I,null)) {
                indices = new  double [retSystemArr.Length];
                createIndices = true; 
            } 
            #endregion HYCALPER GLOBAL_INIT
            

            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
                            fixed ( char * pOutArr = retSystemArr)
                            fixed ( char * pInArr = A.m_data)
                            fixed ( double * pIndices = indices) {
                                char * tmpOut = pOutArr;
                                double * tmpInd = pIndices;
                                char * lastElementOut = tmpOut + retSystemArr.Length;
                                char * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
                                // start at first element
                                if (createIndices) {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = char.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = (*(tmpIn + *leadDimIdx));
                                            if (curval > result) {
                                                result = curval;
                                            
                                                *tmpInd = ( double )(leadDimIdx - leadDimStart);
                                            }
                                            leadDimIdx ++; 
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( char )result;
                                        #endregion HYCALPER POSTLOOP
                                        tmpInd++;
                                    }
                                } else {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = char.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = *(tmpIn + *leadDimIdx++);
                                            if (curval > result) {
                                                result = curval;
                                            
                                            }
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( char )result;
                                        #endregion HYCALPER POSTLOOP
                                    }
                                }
							}
						}
					} 
#endregion
				} else if (A.IsVector) {
#region Vector
					////////////////////////////   VECTOR   ///////////////////////
                    unsafe {
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int[] curPosition = new int[2];
                        int secDim = (leadDim + 1) % 2;
                        fixed (int* leadDimStart = idxOffset[leadDim])
                        fixed ( char * pOutArr = retSystemArr)
                        fixed ( char * pInArr = A.m_data) {
                            char * tmpOut = pOutArr;
                            char * tmpIn = pInArr;
                            int* leadDimIdx = leadDimStart;
                            int* leadDimEnd = leadDimStart + leadDimLen;
                            result = char.MinValue;
                            // start at first element
                            if (createIndices) {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx);
                                    if (curval > result) {
                                                result = curval;
                                            
                                        indices[0] = leadDimIdx - leadDimStart;
                                    }
                                    leadDimIdx++; 
                                }
                            } else {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx++);
                                    if (curval > result) {
                                                result = curval;
                                            
                                    }
                                }
                                #region HYCALPER POSTLOOP
                                *tmpOut = ( char )result;
                                #endregion HYCALPER POSTLOOP
                            }
                        }
                    }
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim])
						fixed ( char * pOutArr = retSystemArr)
                        fixed ( char * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            char * tmpOut = pOutArr;
                            char * lastElementOut = tmpOut + retSystemArr.Length - 1;
                            char * tmpIn = pInArr;
                            double * tmpInd = pIndices; 
							int* leadDimIdx = leadDimStart;
							int* leadDimEnd = leadDimStart + leadDimLen;
                            int inc = inDim.SequentialIndexDistance(leadDim); 
							int dimLen = curPosition.Length;
							int d, curD;
                            int outLength = newLength - 1;
                            int outCount = 0; 
                            // start at first element
							if (createIndices) {
                                while (outCount < retSystemArr.Length) {
								    leadDimIdx = leadDimStart;
                                    result = char.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx);
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = (double)(leadDimIdx - leadDimStart);
                                        }
                                        leadDimIdx++;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( char )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    outCount++; 
                                    // increment higher dimensions 
								    d = 1;
								    while (d < dimLen) {
									    curD = (d + leadDim) % dimLen;
									    tmpIn -= idxOffset[curD, curPosition[curD]];
									    curPosition[curD]++;
									    if (curPosition[curD] < idxOffset[curD].Length) {
										    tmpIn += idxOffset[curD, curPosition[curD]];
										    break;
									    }
									    curPosition[curD] = 0;
									    tmpIn += idxOffset[curD, curPosition[curD]];
									    d++;
								    }
							    }
                            } else {
                                while (outCount < retSystemArr.Length) {
                                    leadDimIdx = leadDimStart;
                                    result = char.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx++);
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( char )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= outLength;
                                    outCount++;
                                    // increment higher dimensions 
                                    d = 1;
                                    while (d < dimLen) {
                                        curD = (d + leadDim) % dimLen;
                                        tmpIn -= idxOffset[curD, curPosition[curD]];
                                        curPosition[curD]++;
                                        if (curPosition[curD] < idxOffset[curD].Length) {
                                            tmpIn += idxOffset[curD, curPosition[curD]];
                                            break;
                                        }
                                        curPosition[curD] = 0;
                                        tmpIn += idxOffset[curD, curPosition[curD]];
                                        d++;
                                    }
                                }
                            }
						}
                    }
#endregion
                }
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( char * pOutArr = retSystemArr)
                        fixed ( char * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            char * lastElement; 
                            char * tmpOut = pOutArr;
                            char * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = char.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(tmpIn - (lastElement - leadDimLen));
                                        }
                                        tmpIn++;
                                    }
                                    *(tmpOut++) = ( char )result;
                                    tmpInd++; 
                                }
                            } else {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = char.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn++;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut++) = ( char )result;
                                    #endregion HYCALPER POSTLOOP
                                }
                            }
                        }
                    }
#endregion physical along 1st leading dimension
                } else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( char * pOutArr = retSystemArr)
                        fixed ( char * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            char * lastElementOut = newLength + pOutArr - 1;
                            int inLength = inDim.NumberOfElements -1;
                            char * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim);
                            char * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            char * leadEnd;
                            char * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = char.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(leadDimLen - (leadEnd - tmpIn) / inc);
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( char ) result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            } else {
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = char.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( char )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            }
                        }
					}
#endregion
				}
			}
            if (createIndices) {
                I = new  ILArray<double> (indices, newDims);
            }
            return new  ILArray<char> (retSystemArr, newDims);  
		}
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="A">input array, N-dimensional</param>
        /// <param name="I">return value. If this is an instance of an ILArray 
        /// (f.e. 'empty'), on return I will hold the indices into leadDim of  
        /// the maximum values. If, on entering the function, I is null, those indices 
        /// will not be computed and I will be ignored.</param>
        /// <param name="leadDim">index of dimension to operate along</param>
        /// <returns>ILArray of type double. If I was empty  having the dimension 'leadDim' 
        /// reduced to 1 and holding maximum values </returns>
        public static  ILLogicalArray max( ILArray<byte> A, ref  ILArray<double> I, int leadDim) {
			if (A.IsEmpty) {
                if (!object.Equals (I,null))
                    I =  ILArray<double> .empty(); 
                return  ILLogicalArray .empty(); 
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            if (leadDim == newDims.Length || inDim[leadDim] == 1)
				// scalar or sum over singleton -> return copy
                return ( ILLogicalArray )A.Clone();

			int newLength;
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
            byte [] retSystemArr;
            retSystemArr = new  byte [newLength];
            int leadDimLen = inDim[leadDim];
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            #region HYCALPER GLOBAL_INIT

            byte result;
            byte curval;
            double [] indices = null;
            bool createIndices = false; 
            if (!Object.Equals(I,null)) {
                indices = new  double [retSystemArr.Length];
                createIndices = true; 
            } 
            #endregion HYCALPER GLOBAL_INIT
            

            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
                            fixed ( byte * pOutArr = retSystemArr)
                            fixed ( byte * pInArr = A.m_data)
                            fixed ( double * pIndices = indices) {
                                byte * tmpOut = pOutArr;
                                double * tmpInd = pIndices;
                                byte * lastElementOut = tmpOut + retSystemArr.Length;
                                byte * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
                                // start at first element
                                if (createIndices) {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = byte.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = (*(tmpIn + *leadDimIdx));
                                            if (curval > result) {
                                                result = curval;
                                            
                                                *tmpInd = ( double )(leadDimIdx - leadDimStart);
                                            }
                                            leadDimIdx ++; 
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( byte )result;
                                        #endregion HYCALPER POSTLOOP
                                        tmpInd++;
                                    }
                                } else {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = byte.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = *(tmpIn + *leadDimIdx++);
                                            if (curval > result) {
                                                result = curval;
                                            
                                            }
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( byte )result;
                                        #endregion HYCALPER POSTLOOP
                                    }
                                }
							}
						}
					} 
#endregion
				} else if (A.IsVector) {
#region Vector
					////////////////////////////   VECTOR   ///////////////////////
                    unsafe {
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int[] curPosition = new int[2];
                        int secDim = (leadDim + 1) % 2;
                        fixed (int* leadDimStart = idxOffset[leadDim])
                        fixed ( byte * pOutArr = retSystemArr)
                        fixed ( byte * pInArr = A.m_data) {
                            byte * tmpOut = pOutArr;
                            byte * tmpIn = pInArr;
                            int* leadDimIdx = leadDimStart;
                            int* leadDimEnd = leadDimStart + leadDimLen;
                            result = byte.MinValue;
                            // start at first element
                            if (createIndices) {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx);
                                    if (curval > result) {
                                                result = curval;
                                            
                                        indices[0] = leadDimIdx - leadDimStart;
                                    }
                                    leadDimIdx++; 
                                }
                            } else {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx++);
                                    if (curval > result) {
                                                result = curval;
                                            
                                    }
                                }
                                #region HYCALPER POSTLOOP
                                *tmpOut = ( byte )result;
                                #endregion HYCALPER POSTLOOP
                            }
                        }
                    }
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim])
						fixed ( byte * pOutArr = retSystemArr)
                        fixed ( byte * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            byte * tmpOut = pOutArr;
                            byte * lastElementOut = tmpOut + retSystemArr.Length - 1;
                            byte * tmpIn = pInArr;
                            double * tmpInd = pIndices; 
							int* leadDimIdx = leadDimStart;
							int* leadDimEnd = leadDimStart + leadDimLen;
                            int inc = inDim.SequentialIndexDistance(leadDim); 
							int dimLen = curPosition.Length;
							int d, curD;
                            int outLength = newLength - 1;
                            int outCount = 0; 
                            // start at first element
							if (createIndices) {
                                while (outCount < retSystemArr.Length) {
								    leadDimIdx = leadDimStart;
                                    result = byte.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx);
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = (double)(leadDimIdx - leadDimStart);
                                        }
                                        leadDimIdx++;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( byte )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    outCount++; 
                                    // increment higher dimensions 
								    d = 1;
								    while (d < dimLen) {
									    curD = (d + leadDim) % dimLen;
									    tmpIn -= idxOffset[curD, curPosition[curD]];
									    curPosition[curD]++;
									    if (curPosition[curD] < idxOffset[curD].Length) {
										    tmpIn += idxOffset[curD, curPosition[curD]];
										    break;
									    }
									    curPosition[curD] = 0;
									    tmpIn += idxOffset[curD, curPosition[curD]];
									    d++;
								    }
							    }
                            } else {
                                while (outCount < retSystemArr.Length) {
                                    leadDimIdx = leadDimStart;
                                    result = byte.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx++);
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( byte )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= outLength;
                                    outCount++;
                                    // increment higher dimensions 
                                    d = 1;
                                    while (d < dimLen) {
                                        curD = (d + leadDim) % dimLen;
                                        tmpIn -= idxOffset[curD, curPosition[curD]];
                                        curPosition[curD]++;
                                        if (curPosition[curD] < idxOffset[curD].Length) {
                                            tmpIn += idxOffset[curD, curPosition[curD]];
                                            break;
                                        }
                                        curPosition[curD] = 0;
                                        tmpIn += idxOffset[curD, curPosition[curD]];
                                        d++;
                                    }
                                }
                            }
						}
                    }
#endregion
                }
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( byte * pOutArr = retSystemArr)
                        fixed ( byte * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            byte * lastElement; 
                            byte * tmpOut = pOutArr;
                            byte * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = byte.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(tmpIn - (lastElement - leadDimLen));
                                        }
                                        tmpIn++;
                                    }
                                    *(tmpOut++) = ( byte )result;
                                    tmpInd++; 
                                }
                            } else {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = byte.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn++;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut++) = ( byte )result;
                                    #endregion HYCALPER POSTLOOP
                                }
                            }
                        }
                    }
#endregion physical along 1st leading dimension
                } else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( byte * pOutArr = retSystemArr)
                        fixed ( byte * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            byte * lastElementOut = newLength + pOutArr - 1;
                            int inLength = inDim.NumberOfElements -1;
                            byte * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim);
                            byte * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            byte * leadEnd;
                            byte * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = byte.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(leadDimLen - (leadEnd - tmpIn) / inc);
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( byte ) result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            } else {
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = byte.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( byte )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            }
                        }
					}
#endregion
				}
			}
            if (createIndices) {
                I = new  ILArray<double> (indices, newDims);
            }
            return new  ILLogicalArray (retSystemArr, newDims);  
		}
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="A">input array, N-dimensional</param>
        /// <param name="I">return value. If this is an instance of an ILArray 
        /// (f.e. 'empty'), on return I will hold the indices into leadDim of  
        /// the maximum values. If, on entering the function, I is null, those indices 
        /// will not be computed and I will be ignored.</param>
        /// <param name="leadDim">index of dimension to operate along</param>
        /// <returns>ILArray of type double. If I was empty  having the dimension 'leadDim' 
        /// reduced to 1 and holding maximum values </returns>
        public static  ILArray<fcomplex> max( ILArray<fcomplex> A, ref  ILArray<double> I, int leadDim) {
			if (A.IsEmpty) {
                if (!object.Equals (I,null))
                    I =  ILArray<double> .empty(); 
                return  ILArray<fcomplex> .empty(); 
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            if (leadDim == newDims.Length || inDim[leadDim] == 1)
				// scalar or sum over singleton -> return copy
                return ( ILArray<fcomplex> )A.Clone();

			int newLength;
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
            fcomplex [] retSystemArr;
            retSystemArr = new  fcomplex [newLength];
            int leadDimLen = inDim[leadDim];
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            #region HYCALPER GLOBAL_INIT

            fcomplex result;
            fcomplex curval;
            double [] indices = null;
            bool createIndices = false; 
            if (!Object.Equals(I,null)) {
                indices = new  double [retSystemArr.Length];
                createIndices = true; 
            } 
            #endregion HYCALPER GLOBAL_INIT
            float curabsval; float curabsmaxval; 

            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
                            fixed ( fcomplex * pOutArr = retSystemArr)
                            fixed ( fcomplex * pInArr = A.m_data)
                            fixed ( double * pIndices = indices) {
                                fcomplex * tmpOut = pOutArr;
                                double * tmpInd = pIndices;
                                fcomplex * lastElementOut = tmpOut + retSystemArr.Length;
                                fcomplex * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
                                // start at first element
                                if (createIndices) {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        curabsmaxval = float.MinValue; result = new fcomplex();
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = (*(tmpIn + *leadDimIdx));
                                            curabsval = fcomplex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                                *tmpInd = ( double )(leadDimIdx - leadDimStart);
                                            }
                                            leadDimIdx ++; 
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( fcomplex )result;
                                        #endregion HYCALPER POSTLOOP
                                        tmpInd++;
                                    }
                                } else {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        curabsmaxval = float.MinValue; result = new fcomplex();
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = *(tmpIn + *leadDimIdx++);
                                            curabsval = fcomplex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                            }
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( fcomplex )result;
                                        #endregion HYCALPER POSTLOOP
                                    }
                                }
							}
						}
					} 
#endregion
				} else if (A.IsVector) {
#region Vector
					////////////////////////////   VECTOR   ///////////////////////
                    unsafe {
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int[] curPosition = new int[2];
                        int secDim = (leadDim + 1) % 2;
                        fixed (int* leadDimStart = idxOffset[leadDim])
                        fixed ( fcomplex * pOutArr = retSystemArr)
                        fixed ( fcomplex * pInArr = A.m_data) {
                            fcomplex * tmpOut = pOutArr;
                            fcomplex * tmpIn = pInArr;
                            int* leadDimIdx = leadDimStart;
                            int* leadDimEnd = leadDimStart + leadDimLen;
                            curabsmaxval = float.MinValue; result = new fcomplex();
                            // start at first element
                            if (createIndices) {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx);
                                    curabsval = fcomplex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                        indices[0] = leadDimIdx - leadDimStart;
                                    }
                                    leadDimIdx++; 
                                }
                            } else {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx++);
                                    curabsval = fcomplex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                    }
                                }
                                #region HYCALPER POSTLOOP
                                *tmpOut = ( fcomplex )result;
                                #endregion HYCALPER POSTLOOP
                            }
                        }
                    }
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim])
						fixed ( fcomplex * pOutArr = retSystemArr)
                        fixed ( fcomplex * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            fcomplex * tmpOut = pOutArr;
                            fcomplex * lastElementOut = tmpOut + retSystemArr.Length - 1;
                            fcomplex * tmpIn = pInArr;
                            double * tmpInd = pIndices; 
							int* leadDimIdx = leadDimStart;
							int* leadDimEnd = leadDimStart + leadDimLen;
                            int inc = inDim.SequentialIndexDistance(leadDim); 
							int dimLen = curPosition.Length;
							int d, curD;
                            int outLength = newLength - 1;
                            int outCount = 0; 
                            // start at first element
							if (createIndices) {
                                while (outCount < retSystemArr.Length) {
								    leadDimIdx = leadDimStart;
                                    curabsmaxval = float.MinValue; result = new fcomplex();
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx);
                                        curabsval = fcomplex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                            *tmpInd = (double)(leadDimIdx - leadDimStart);
                                        }
                                        leadDimIdx++;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( fcomplex )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    outCount++; 
                                    // increment higher dimensions 
								    d = 1;
								    while (d < dimLen) {
									    curD = (d + leadDim) % dimLen;
									    tmpIn -= idxOffset[curD, curPosition[curD]];
									    curPosition[curD]++;
									    if (curPosition[curD] < idxOffset[curD].Length) {
										    tmpIn += idxOffset[curD, curPosition[curD]];
										    break;
									    }
									    curPosition[curD] = 0;
									    tmpIn += idxOffset[curD, curPosition[curD]];
									    d++;
								    }
							    }
                            } else {
                                while (outCount < retSystemArr.Length) {
                                    leadDimIdx = leadDimStart;
                                    curabsmaxval = float.MinValue; result = new fcomplex();
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx++);
                                        curabsval = fcomplex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( fcomplex )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= outLength;
                                    outCount++;
                                    // increment higher dimensions 
                                    d = 1;
                                    while (d < dimLen) {
                                        curD = (d + leadDim) % dimLen;
                                        tmpIn -= idxOffset[curD, curPosition[curD]];
                                        curPosition[curD]++;
                                        if (curPosition[curD] < idxOffset[curD].Length) {
                                            tmpIn += idxOffset[curD, curPosition[curD]];
                                            break;
                                        }
                                        curPosition[curD] = 0;
                                        tmpIn += idxOffset[curD, curPosition[curD]];
                                        d++;
                                    }
                                }
                            }
						}
                    }
#endregion
                }
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( fcomplex * pOutArr = retSystemArr)
                        fixed ( fcomplex * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            fcomplex * lastElement; 
                            fcomplex * tmpOut = pOutArr;
                            fcomplex * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    curabsmaxval = float.MinValue; result = new fcomplex();
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn;
                                        curabsval = fcomplex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                            *tmpInd = ( double )(tmpIn - (lastElement - leadDimLen));
                                        }
                                        tmpIn++;
                                    }
                                    *(tmpOut++) = ( fcomplex )result;
                                    tmpInd++; 
                                }
                            } else {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    curabsmaxval = float.MinValue; result = new fcomplex();
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn++;
                                        curabsval = fcomplex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut++) = ( fcomplex )result;
                                    #endregion HYCALPER POSTLOOP
                                }
                            }
                        }
                    }
#endregion physical along 1st leading dimension
                } else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( fcomplex * pOutArr = retSystemArr)
                        fixed ( fcomplex * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            fcomplex * lastElementOut = newLength + pOutArr - 1;
                            int inLength = inDim.NumberOfElements -1;
                            fcomplex * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim);
                            fcomplex * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            fcomplex * leadEnd;
                            fcomplex * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    curabsmaxval = float.MinValue; result = new fcomplex();
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        curabsval = fcomplex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                            *tmpInd = ( double )(leadDimLen - (leadEnd - tmpIn) / inc);
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( fcomplex ) result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            } else {
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    curabsmaxval = float.MinValue; result = new fcomplex();
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        curabsval = fcomplex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( fcomplex )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            }
                        }
					}
#endregion
				}
			}
            if (createIndices) {
                I = new  ILArray<double> (indices, newDims);
            }
            return new  ILArray<fcomplex> (retSystemArr, newDims);  
		}
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="A">input array, N-dimensional</param>
        /// <param name="I">return value. If this is an instance of an ILArray 
        /// (f.e. 'empty'), on return I will hold the indices into leadDim of  
        /// the maximum values. If, on entering the function, I is null, those indices 
        /// will not be computed and I will be ignored.</param>
        /// <param name="leadDim">index of dimension to operate along</param>
        /// <returns>ILArray of type double. If I was empty  having the dimension 'leadDim' 
        /// reduced to 1 and holding maximum values </returns>
        public static  ILArray<float> max( ILArray<float> A, ref  ILArray<double> I, int leadDim) {
			if (A.IsEmpty) {
                if (!object.Equals (I,null))
                    I =  ILArray<double> .empty(); 
                return  ILArray<float> .empty(); 
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            if (leadDim == newDims.Length || inDim[leadDim] == 1)
				// scalar or sum over singleton -> return copy
                return ( ILArray<float> )A.Clone();

			int newLength;
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
            float [] retSystemArr;
            retSystemArr = new  float [newLength];
            int leadDimLen = inDim[leadDim];
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            #region HYCALPER GLOBAL_INIT

            float result;
            float curval;
            double [] indices = null;
            bool createIndices = false; 
            if (!Object.Equals(I,null)) {
                indices = new  double [retSystemArr.Length];
                createIndices = true; 
            } 
            #endregion HYCALPER GLOBAL_INIT
            

            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
                            fixed ( float * pOutArr = retSystemArr)
                            fixed ( float * pInArr = A.m_data)
                            fixed ( double * pIndices = indices) {
                                float * tmpOut = pOutArr;
                                double * tmpInd = pIndices;
                                float * lastElementOut = tmpOut + retSystemArr.Length;
                                float * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
                                // start at first element
                                if (createIndices) {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = float.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = (*(tmpIn + *leadDimIdx));
                                            if (curval > result) {
                                                result = curval;
                                            
                                                *tmpInd = ( double )(leadDimIdx - leadDimStart);
                                            }
                                            leadDimIdx ++; 
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( float )result;
                                        #endregion HYCALPER POSTLOOP
                                        tmpInd++;
                                    }
                                } else {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        result = float.MinValue;
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = *(tmpIn + *leadDimIdx++);
                                            if (curval > result) {
                                                result = curval;
                                            
                                            }
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( float )result;
                                        #endregion HYCALPER POSTLOOP
                                    }
                                }
							}
						}
					} 
#endregion
				} else if (A.IsVector) {
#region Vector
					////////////////////////////   VECTOR   ///////////////////////
                    unsafe {
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int[] curPosition = new int[2];
                        int secDim = (leadDim + 1) % 2;
                        fixed (int* leadDimStart = idxOffset[leadDim])
                        fixed ( float * pOutArr = retSystemArr)
                        fixed ( float * pInArr = A.m_data) {
                            float * tmpOut = pOutArr;
                            float * tmpIn = pInArr;
                            int* leadDimIdx = leadDimStart;
                            int* leadDimEnd = leadDimStart + leadDimLen;
                            result = float.MinValue;
                            // start at first element
                            if (createIndices) {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx);
                                    if (curval > result) {
                                                result = curval;
                                            
                                        indices[0] = leadDimIdx - leadDimStart;
                                    }
                                    leadDimIdx++; 
                                }
                            } else {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx++);
                                    if (curval > result) {
                                                result = curval;
                                            
                                    }
                                }
                                #region HYCALPER POSTLOOP
                                *tmpOut = ( float )result;
                                #endregion HYCALPER POSTLOOP
                            }
                        }
                    }
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim])
						fixed ( float * pOutArr = retSystemArr)
                        fixed ( float * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            float * tmpOut = pOutArr;
                            float * lastElementOut = tmpOut + retSystemArr.Length - 1;
                            float * tmpIn = pInArr;
                            double * tmpInd = pIndices; 
							int* leadDimIdx = leadDimStart;
							int* leadDimEnd = leadDimStart + leadDimLen;
                            int inc = inDim.SequentialIndexDistance(leadDim); 
							int dimLen = curPosition.Length;
							int d, curD;
                            int outLength = newLength - 1;
                            int outCount = 0; 
                            // start at first element
							if (createIndices) {
                                while (outCount < retSystemArr.Length) {
								    leadDimIdx = leadDimStart;
                                    result = float.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx);
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = (double)(leadDimIdx - leadDimStart);
                                        }
                                        leadDimIdx++;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( float )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    outCount++; 
                                    // increment higher dimensions 
								    d = 1;
								    while (d < dimLen) {
									    curD = (d + leadDim) % dimLen;
									    tmpIn -= idxOffset[curD, curPosition[curD]];
									    curPosition[curD]++;
									    if (curPosition[curD] < idxOffset[curD].Length) {
										    tmpIn += idxOffset[curD, curPosition[curD]];
										    break;
									    }
									    curPosition[curD] = 0;
									    tmpIn += idxOffset[curD, curPosition[curD]];
									    d++;
								    }
							    }
                            } else {
                                while (outCount < retSystemArr.Length) {
                                    leadDimIdx = leadDimStart;
                                    result = float.MinValue;
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx++);
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( float )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= outLength;
                                    outCount++;
                                    // increment higher dimensions 
                                    d = 1;
                                    while (d < dimLen) {
                                        curD = (d + leadDim) % dimLen;
                                        tmpIn -= idxOffset[curD, curPosition[curD]];
                                        curPosition[curD]++;
                                        if (curPosition[curD] < idxOffset[curD].Length) {
                                            tmpIn += idxOffset[curD, curPosition[curD]];
                                            break;
                                        }
                                        curPosition[curD] = 0;
                                        tmpIn += idxOffset[curD, curPosition[curD]];
                                        d++;
                                    }
                                }
                            }
						}
                    }
#endregion
                }
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( float * pOutArr = retSystemArr)
                        fixed ( float * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            float * lastElement; 
                            float * tmpOut = pOutArr;
                            float * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = float.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(tmpIn - (lastElement - leadDimLen));
                                        }
                                        tmpIn++;
                                    }
                                    *(tmpOut++) = ( float )result;
                                    tmpInd++; 
                                }
                            } else {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    result = float.MinValue;
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn++;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut++) = ( float )result;
                                    #endregion HYCALPER POSTLOOP
                                }
                            }
                        }
                    }
#endregion physical along 1st leading dimension
                } else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( float * pOutArr = retSystemArr)
                        fixed ( float * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            float * lastElementOut = newLength + pOutArr - 1;
                            int inLength = inDim.NumberOfElements -1;
                            float * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim);
                            float * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            float * leadEnd;
                            float * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = float.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                            *tmpInd = ( double )(leadDimLen - (leadEnd - tmpIn) / inc);
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( float ) result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            } else {
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    result = float.MinValue;
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        if (curval > result) {
                                                result = curval;
                                            
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( float )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            }
                        }
					}
#endregion
				}
			}
            if (createIndices) {
                I = new  ILArray<double> (indices, newDims);
            }
            return new  ILArray<float> (retSystemArr, newDims);  
		}
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="A">input array, N-dimensional</param>
        /// <param name="I">return value. If this is an instance of an ILArray 
        /// (f.e. 'empty'), on return I will hold the indices into leadDim of  
        /// the maximum values. If, on entering the function, I is null, those indices 
        /// will not be computed and I will be ignored.</param>
        /// <param name="leadDim">index of dimension to operate along</param>
        /// <returns>ILArray of type double. If I was empty  having the dimension 'leadDim' 
        /// reduced to 1 and holding maximum values </returns>
        public static  ILArray<complex> max( ILArray<complex> A, ref  ILArray<double> I, int leadDim) {
			if (A.IsEmpty) {
                if (!object.Equals (I,null))
                    I =  ILArray<double> .empty(); 
                return  ILArray<complex> .empty(); 
            }
            ILDimension inDim = A.Dimensions; 
			int[] newDims = inDim.ToIntArray();
            if (leadDim == newDims.Length || inDim[leadDim] == 1)
				// scalar or sum over singleton -> return copy
                return ( ILArray<complex> )A.Clone();

			int newLength;
			newLength = inDim.NumberOfElements / newDims[leadDim];
			newDims[leadDim] = 1;
            complex [] retSystemArr;
            retSystemArr = new  complex [newLength];
            int leadDimLen = inDim[leadDim];
			int nrHigherDims = inDim.NumberOfElements / leadDimLen;
            #region HYCALPER GLOBAL_INIT

            complex result;
            complex curval;
            double [] indices = null;
            bool createIndices = false; 
            if (!Object.Equals(I,null)) {
                indices = new  double [retSystemArr.Length];
                createIndices = true; 
            } 
            #endregion HYCALPER GLOBAL_INIT
            double curabsval; double curabsmaxval; 

            if (A.IsReference) {
#region Reference storage
				// ========================  REFERENCE double Storage ===========
				if (A.IsMatrix) {
#region Matrix
					////////////////////////////   MATRIX   ///////////////////////
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int secDim = (leadDim + 1) % 2;
						fixed (int* leadDimStart = idxOffset[leadDim],
								secDimStart = idxOffset[secDim]) {
                            fixed ( complex * pOutArr = retSystemArr)
                            fixed ( complex * pInArr = A.m_data)
                            fixed ( double * pIndices = indices) {
                                complex * tmpOut = pOutArr;
                                double * tmpInd = pIndices;
                                complex * lastElementOut = tmpOut + retSystemArr.Length;
                                complex * tmpIn = pInArr;
								int* secDimEnd = secDimStart + idxOffset[secDim].Length - 1;
								int* secDimIdx = secDimStart; 
								int* leadDimIdx = leadDimStart;
								int* leadDimEnd = leadDimStart + leadDimLen - 1;
                                // start at first element
                                if (createIndices) {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        curabsmaxval = double.MinValue; result = new complex(); 
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = (*(tmpIn + *leadDimIdx));
                                            curabsval = complex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                                *tmpInd = ( double )(leadDimIdx - leadDimStart);
                                            }
                                            leadDimIdx ++; 
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( complex )result;
                                        #endregion HYCALPER POSTLOOP
                                        tmpInd++;
                                    }
                                } else {
                                    while (secDimIdx <= secDimEnd) {
                                        tmpIn = pInArr + *secDimIdx++;
                                        leadDimIdx = leadDimStart;
                                        curabsmaxval = double.MinValue; result = new complex(); 
                                        while (leadDimIdx <= leadDimEnd) {
                                            curval = *(tmpIn + *leadDimIdx++);
                                            curabsval = complex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                            }
                                        }
                                        #region HYCALPER POSTLOOP
                                        *(tmpOut++) = ( complex )result;
                                        #endregion HYCALPER POSTLOOP
                                    }
                                }
							}
						}
					} 
#endregion
				} else if (A.IsVector) {
#region Vector
					////////////////////////////   VECTOR   ///////////////////////
                    unsafe {
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int[] curPosition = new int[2];
                        int secDim = (leadDim + 1) % 2;
                        fixed (int* leadDimStart = idxOffset[leadDim])
                        fixed ( complex * pOutArr = retSystemArr)
                        fixed ( complex * pInArr = A.m_data) {
                            complex * tmpOut = pOutArr;
                            complex * tmpIn = pInArr;
                            int* leadDimIdx = leadDimStart;
                            int* leadDimEnd = leadDimStart + leadDimLen;
                            curabsmaxval = double.MinValue; result = new complex(); 
                            // start at first element
                            if (createIndices) {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx);
                                    curabsval = complex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                        indices[0] = leadDimIdx - leadDimStart;
                                    }
                                    leadDimIdx++; 
                                }
                            } else {
                                while (leadDimIdx < leadDimEnd) {
                                    curval = *(tmpIn + *leadDimIdx++);
                                    curabsval = complex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                    }
                                }
                                #region HYCALPER POSTLOOP
                                *tmpOut = ( complex )result;
                                #endregion HYCALPER POSTLOOP
                            }
                        }
                    }
#endregion
				} else {
					/////////////////////////////   ARBITRARY DIMENSIONS //////////
#region arbitrary size
					unsafe {
						ILIndexOffset idxOffset = A.m_indexOffset;
						int[] curPosition = new int[A.Dimensions.NumberOfDimensions];
						fixed (int* leadDimStart = idxOffset[leadDim])
						fixed ( complex * pOutArr = retSystemArr)
                        fixed ( complex * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            complex * tmpOut = pOutArr;
                            complex * lastElementOut = tmpOut + retSystemArr.Length - 1;
                            complex * tmpIn = pInArr;
                            double * tmpInd = pIndices; 
							int* leadDimIdx = leadDimStart;
							int* leadDimEnd = leadDimStart + leadDimLen;
                            int inc = inDim.SequentialIndexDistance(leadDim); 
							int dimLen = curPosition.Length;
							int d, curD;
                            int outLength = newLength - 1;
                            int outCount = 0; 
                            // start at first element
							if (createIndices) {
                                while (outCount < retSystemArr.Length) {
								    leadDimIdx = leadDimStart;
                                    curabsmaxval = double.MinValue; result = new complex(); 
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx);
                                        curabsval = complex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                            *tmpInd = (double)(leadDimIdx - leadDimStart);
                                        }
                                        leadDimIdx++;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( complex )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    outCount++; 
                                    // increment higher dimensions 
								    d = 1;
								    while (d < dimLen) {
									    curD = (d + leadDim) % dimLen;
									    tmpIn -= idxOffset[curD, curPosition[curD]];
									    curPosition[curD]++;
									    if (curPosition[curD] < idxOffset[curD].Length) {
										    tmpIn += idxOffset[curD, curPosition[curD]];
										    break;
									    }
									    curPosition[curD] = 0;
									    tmpIn += idxOffset[curD, curPosition[curD]];
									    d++;
								    }
							    }
                            } else {
                                while (outCount < retSystemArr.Length) {
                                    leadDimIdx = leadDimStart;
                                    curabsmaxval = double.MinValue; result = new complex(); 
                                    while (leadDimIdx < leadDimEnd) {
                                        curval = *(tmpIn + *leadDimIdx++);
                                        curabsval = complex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *tmpOut = ( complex )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut)
                                        tmpOut -= outLength;
                                    outCount++;
                                    // increment higher dimensions 
                                    d = 1;
                                    while (d < dimLen) {
                                        curD = (d + leadDim) % dimLen;
                                        tmpIn -= idxOffset[curD, curPosition[curD]];
                                        curPosition[curD]++;
                                        if (curPosition[curD] < idxOffset[curD].Length) {
                                            tmpIn += idxOffset[curD, curPosition[curD]];
                                            break;
                                        }
                                        curPosition[curD] = 0;
                                        tmpIn += idxOffset[curD, curPosition[curD]];
                                        d++;
                                    }
                                }
                            }
						}
                    }
#endregion
                }
#endregion
			} else {
				// physical -> pointer arithmetic
                if (leadDim == 0) {
#region physical along 1st leading dimension
                    unsafe {
                        fixed ( complex * pOutArr = retSystemArr)
                        fixed ( complex * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            complex * lastElement; 
                            complex * tmpOut = pOutArr;
                            complex * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    curabsmaxval = double.MinValue; result = new complex(); 
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn;
                                        curabsval = complex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                            *tmpInd = ( double )(tmpIn - (lastElement - leadDimLen));
                                        }
                                        tmpIn++;
                                    }
                                    *(tmpOut++) = ( complex )result;
                                    tmpInd++; 
                                }
                            } else {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    lastElement = tmpIn + leadDimLen;
                                    curabsmaxval = double.MinValue; result = new complex(); 
                                    while (tmpIn < lastElement) {
                                        curval = *tmpIn++;
                                        curabsval = complex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                        }
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut++) = ( complex )result;
                                    #endregion HYCALPER POSTLOOP
                                }
                            }
                        }
                    }
#endregion physical along 1st leading dimension
                } else {
#region physical along abitrary dimension
					// sum along abitrary dimension 
                    unsafe {
                        fixed ( complex * pOutArr = retSystemArr)
                        fixed ( complex * pInArr = A.m_data)
                        fixed ( double * pIndices = indices) {
                            complex * lastElementOut = newLength + pOutArr - 1;
                            int inLength = inDim.NumberOfElements -1;
                            complex * lastElementIn = pInArr + inLength; 
                            int inc = inDim.SequentialIndexDistance(leadDim);
                            complex * tmpOut = pOutArr;
                            int outLength = newLength - 1;
                            complex * leadEnd;
                            complex * tmpIn = pInArr;
                            if (createIndices) {
                                double * tmpInd = pIndices;
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    curabsmaxval = double.MinValue; result = new complex(); 
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        curabsval = complex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                            *tmpInd = ( double )(leadDimLen - (leadEnd - tmpIn) / inc);
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( complex ) result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    tmpInd += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                        tmpInd -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            } else {
                                for (int h = nrHigherDims; h-- > 0; ) {
                                    leadEnd = tmpIn + leadDimLen * inc;
                                    curabsmaxval = double.MinValue; result = new complex(); 
                                    while (tmpIn < leadEnd) {
                                        curval = *tmpIn;
                                        curabsval = complex.Abs(curval);
                                            if (curabsval > curabsmaxval) {
                                                curabsmaxval = curabsval;
                                                result = curval;
                                            
                                        }
                                        tmpIn += inc;
                                    }
                                    #region HYCALPER POSTLOOP
                                    *(tmpOut) = ( complex )result;
                                    #endregion HYCALPER POSTLOOP
                                    tmpOut += inc;
                                    if (tmpOut > lastElementOut) {
                                        tmpOut -= outLength;
                                    }
                                    if (tmpIn > lastElementIn)
                                        tmpIn = pInArr + ((tmpIn - pInArr) - inLength);
                                }
                            }
                        }
					}
#endregion
				}
			}
            if (createIndices) {
                I = new  ILArray<double> (indices, newDims);
            }
            return new  ILArray<complex> (retSystemArr, newDims);  
		}

#endregion HYCALPER AUTO GENERATED CODE

        #region HYCALPER LOOPSTART BINARY_OPERATOR_TEMPLATE@Functions\builtin\Add.cs
/*!HC:TYPELIST:
<hycalper>
    <type>
        <source locate="after">
            inCls1
        </source>
        <destination><![CDATA[ILArray<double>]]></destination>
        <destination><![CDATA[ILArray<byte>]]></destination>
        <destination><![CDATA[ILArray<char>]]></destination>
        <destination><![CDATA[ILArray<complex>]]></destination>
        <destination><![CDATA[ILArray<fcomplex>]]></destination>
        <destination><![CDATA[ILArray<float>]]></destination>
        <destination><![CDATA[ILArray<Int16>]]></destination>
        <destination><![CDATA[ILArray<Int32>]]></destination>
        <destination><![CDATA[ILArray<Int64>]]></destination>
        <destination><![CDATA[ILArray<UInt16>]]></destination>
        <destination><![CDATA[ILArray<UInt32>]]></destination>
        <destination><![CDATA[ILArray<UInt64>]]></destination>
    </type>
    <type>
        <source locate="after">
            inCls2
        </source>
        <destination><![CDATA[ILArray<double>]]></destination>
        <destination><![CDATA[ILArray<byte>]]></destination>
        <destination><![CDATA[ILArray<char>]]></destination>
        <destination><![CDATA[ILArray<complex>]]></destination>
        <destination><![CDATA[ILArray<fcomplex>]]></destination>
        <destination><![CDATA[ILArray<float>]]></destination>
        <destination><![CDATA[ILArray<Int16>]]></destination>
        <destination><![CDATA[ILArray<Int32>]]></destination>
        <destination><![CDATA[ILArray<Int64>]]></destination>
        <destination><![CDATA[ILArray<UInt16>]]></destination>
        <destination><![CDATA[ILArray<UInt32>]]></destination>
        <destination><![CDATA[ILArray<UInt64>]]></destination>
    </type>
    <type>
        <source locate="after">
            inArr1
        </source>
        <destination>double</destination>
        <destination>byte</destination>
        <destination>char</destination>
        <destination>complex</destination>
        <destination>fcomplex</destination>
        <destination>float</destination>
        <destination>Int16</destination>
        <destination>Int32</destination>
        <destination>Int64</destination>
        <destination>UInt16</destination>
        <destination>UInt32</destination>
        <destination>UInt64</destination>
    </type>
    <type>
        <source locate="after">
            inArr2
        </source>
        <destination>double</destination>
        <destination>byte</destination>
        <destination>char</destination>
        <destination>complex</destination>
        <destination>fcomplex</destination>
        <destination>float</destination>
        <destination>Int16</destination>
        <destination>Int32</destination>
        <destination>Int64</destination>
        <destination>UInt16</destination>
        <destination>UInt32</destination>
        <destination>UInt64</destination>
    </type>
    <type>
        <source locate="after">
            outCls
        </source>
        <destination><![CDATA[ILArray<double>]]></destination>
        <destination><![CDATA[ILArray<byte>]]></destination>
        <destination><![CDATA[ILArray<char>]]></destination>
        <destination><![CDATA[ILArray<complex>]]></destination>
        <destination><![CDATA[ILArray<fcomplex>]]></destination>
        <destination><![CDATA[ILArray<float>]]></destination>
        <destination><![CDATA[ILArray<Int16>]]></destination>
        <destination><![CDATA[ILArray<Int32>]]></destination>
        <destination><![CDATA[ILArray<Int64>]]></destination>
        <destination><![CDATA[ILArray<UInt16>]]></destination>
        <destination><![CDATA[ILArray<UInt32>]]></destination>
        <destination><![CDATA[ILArray<UInt64>]]></destination>
    </type>
    <type>
        <source locate="after">
            outArr
        </source>
        <destination>double</destination>
        <destination>byte</destination>
        <destination>char</destination>
        <destination>complex</destination>
        <destination>fcomplex</destination>
        <destination>float</destination>
        <destination>Int16</destination>
        <destination>Int32</destination>
        <destination>Int64</destination>
        <destination>UInt16</destination>
        <destination>UInt32</destination>
        <destination>UInt64</destination>
    </type>
    <type>
        <source locate="after">
            HCFuncName
        </source>
        <destination>max</destination>
        <destination>max</destination>
        <destination>max</destination>
        <destination>max</destination>
        <destination>max</destination>
        <destination>max</destination>
        <destination>max</destination>
        <destination>max</destination>
        <destination>max</destination>
        <destination>max</destination>
        <destination>max</destination>
        <destination>max</destination>
    </type>
    <type>
        <source locate="nextline">
            HCCompute00
        </source>
        <destination><![CDATA[return new ILArray<double> (new double[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});]]></destination>
        <destination><![CDATA[return new ILArray<byte> (new byte[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});]]></destination>
        <destination><![CDATA[return new ILArray<char> (new char[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});]]></destination>
        <destination><![CDATA[return new ILArray<complex> (new complex[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});]]></destination>
        <destination><![CDATA[return new ILArray<fcomplex> (new fcomplex[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});]]></destination>
        <destination><![CDATA[return new ILArray<float> (new float[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});]]></destination>
        <destination><![CDATA[return new ILArray<Int16> (new Int16[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});]]></destination>
        <destination><![CDATA[return new ILArray<Int32> (new Int32[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});]]></destination>
        <destination><![CDATA[return new ILArray<Int64> (new Int64[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});]]></destination>
        <destination><![CDATA[return new ILArray<UInt16> (new UInt16[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});]]></destination>
        <destination><![CDATA[return new ILArray<UInt32> (new UInt32[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});]]></destination>
        <destination><![CDATA[return new ILArray<UInt64> (new UInt64[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});]]></destination>
    </type>
    <type>
        <source locate="nextline">
            HCCompute01
        </source>
        <destination><![CDATA[tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;]]></destination>
    </type>
    <type>
        <source locate="nextline">
            HCCompute02
        </source>
        <destination><![CDATA[tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;]]></destination>
    </type>
    <type>
        <source locate="nextline">
            HCCompute03
        </source>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
    </type>
    <type>
        <source locate="nextline">
            HCCompute04
        </source>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
    </type>
    <type>
        <source locate="nextline">
            HCCompute05
        </source>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
        <destination><![CDATA[tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;]]></destination>
    </type>
    <type>
        <source locate="nextline">
            HCCompute06
        </source>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
        <destination><![CDATA[{ *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }]]></destination>
    </type>
    <type>
        <source locate="nextline">
            HCCompute07
        </source>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; ]]></destination>
    </type>
    <type>
        <source locate="nextline">
            HCCompute08
        </source>
        <destination><![CDATA[tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;]]></destination>
    </type>
    <type>
        <source locate="nextline">
            HCCompute09
        </source>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; ]]></destination>
        <destination><![CDATA[tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; ]]></destination>
    </type>
    <type>
        <source locate="nextline">
            HCCompute10
        </source>
        <destination><![CDATA[tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;]]></destination>
        <destination><![CDATA[tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;]]></destination>
        <destination><![CDATA[tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;]]></destination>
        <destination><![CDATA[tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;]]></destination>
        <destination><![CDATA[tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;]]></destination>
        <destination><![CDATA[tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;]]></destination>
        <destination><![CDATA[tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;]]></destination>
        <destination><![CDATA[tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;]]></destination>
        <destination><![CDATA[tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;]]></destination>
        <destination><![CDATA[tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;]]></destination>
        <destination><![CDATA[tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;]]></destination>
        <destination><![CDATA[tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;]]></destination>
    </type>
    <type>
        <source locate="nextline">
            HCCompute11
        </source>
        <destination><![CDATA[if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}]]></destination>
        <destination><![CDATA[if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}]]></destination>
        <destination><![CDATA[if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}]]></destination>
        <destination><![CDATA[if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}]]></destination>
        <destination><![CDATA[if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}]]></destination>
        <destination><![CDATA[if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}]]></destination>
        <destination><![CDATA[if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}]]></destination>
        <destination><![CDATA[if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}]]></destination>
        <destination><![CDATA[if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}]]></destination>
        <destination><![CDATA[if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}]]></destination>
        <destination><![CDATA[if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}]]></destination>
        <destination><![CDATA[if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}]]></destination>
    </type>
 </hycalper>
 */
        #endregion HYCALPER LOOPEND R=op(A,B)
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
        /// <summary> sum two arrays elementwise</summary>
        /// <param name="A">input 1</param>
        /// <param name="B">input 2</param>
        /// <returns> Array with elementwise sum of A and B </returns>
        /// <remarks><para>On empty input - empty array will be returned.</para>
        /// <para>A and / or B may be scalar. The scalar value will operate on all elements of the other arrays in this case.</para>
        /// <para>If neither of A or B is scalar or empty, the dimensions of both arrays must match.</para></remarks>
        public static  ILArray<UInt64>  max ( ILArray<UInt64> A,  ILArray<UInt64> B) {
            if (A.IsEmpty || B.IsEmpty ) {
                return  ILArray<UInt64> .empty(); 
            }
            if (A.IsScalar) {
                if (B.IsScalar) {
                    return new ILArray<UInt64> (new UInt64[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});
                } else {
                    #region scalar + array  
                    ILDimension inDim = B.Dimensions;
                    //  UInt64 [] retArr = new  UInt64 [inDim.NumberOfElements];
                    UInt64 [] retArr = ILMemoryPool.Pool.New< UInt64 > (inDim.NumberOfElements);
                    UInt64 scalarValue = A.GetValue(0); 
                    UInt64 tmpValue2; 
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (B.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = B.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!B.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (B.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( UInt64 * pOutArr = retArr)
                                fixed ( UInt64 * pInArr = B.m_data) {
                                        UInt64 * tmpOut = pOutArr;
                                        UInt64 * tmpIn = pInArr;
                                        UInt64 * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [B.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( UInt64 * pOutArr = retArr)
                                    fixed ( UInt64 * pInArr = B.m_data) {
                                        UInt64 * tmpOut = pOutArr;
                                        UInt64 * tmpOutEnd = tmpOut + retArr.Length;
                                        // init lesezeiger: add alle Dimensionen mit 0 (auer leadDim)
                                        UInt64 * tmpIn = pInArr + B.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( UInt64 * pOutArr = retArr)
                            fixed ( UInt64 * pInArr = B.m_data) {
                                UInt64 * lastElement = pOutArr + retArr.Length;
                                UInt64 * tmpOut = pOutArr;
                                UInt64 * tmpIn = pInArr;
                                while (tmpOut < lastElement) //HC03
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                            }       
                        }
                        #endregion
                    }
                    return new  ILArray<UInt64> ( retArr, inDim.Clone() );
                    #endregion scalar + array
                }
            } else {
                if (B.IsScalar) {
                    #region array + scalar
                    ILDimension inDim = A.Dimensions;
                    //  UInt64 [] retArr = new  UInt64 [inDim.NumberOfElements];
                    UInt64 [] retArr = ILMemoryPool.Pool.New< UInt64 > (inDim.NumberOfElements);
                    UInt64 scalarValue = B.GetValue(0); 
                    UInt64 tmpValue1;
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (A.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!A.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (A.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( UInt64 * pOutArr = retArr)
                                fixed ( UInt64 * pInArr = A.m_data) {
                                        UInt64 * tmpOut = pOutArr;
                                        UInt64 * tmpIn = pInArr;
                                        UInt64 * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) { //HC04
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [A.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( UInt64 * pOutArr = retArr)
                                    fixed ( UInt64 * pInArr = A.m_data) {
                                        UInt64 * tmpOut = pOutArr;
                                        UInt64 * tmpOutEnd = tmpOut + retArr.Length;
                                        // init readpointer: add all Dimensions with 0 (except leadDim)
                                        UInt64 * tmpIn = pInArr + A.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {   //HC05
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( UInt64 * pOutArr = retArr)
                            fixed ( UInt64 * pInArr = A.m_data) {
                                UInt64 * lastElement = pOutArr + retArr.Length;
                                UInt64 * tmpOut = pOutArr;
                                UInt64 * tmpIn = pInArr;
                                while (tmpOut < lastElement) { //HC06
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                                }
                            }
                        }
                        #endregion
                        //tmpValue1 = 0; 
                    }
                    return new  ILArray<UInt64> ( retArr, inDim.Clone() );
                    #endregion array + scalar
                } else {
                    #region array + array
                    ILDimension inDim = A.Dimensions;
                    if (!inDim.IsSameSize ( B.Dimensions ))
                        throw new ILDimensionMismatchException ();
                    UInt64 [] retSystemArr;
                    UInt64 tmpValue1; 
                    UInt64 tmpValue2; 
                    // retSystemArr = new  UInt64 [inDim.NumberOfElements];
                    retSystemArr = ILMemoryPool.Pool.New< UInt64 > (inDim.NumberOfElements);
                    
                    int leadDim = 0, leadDimLen = inDim [0];
                    // this will most probably be not very fast, but .... :|
                    // walk along the longest dimension (for performance reasons)
                    for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                        if (leadDimLen < inDim [i]) {
                            leadDimLen = inDim [i];
                            leadDim = i;
                        }
                    }
                    unsafe {
                        fixed ( UInt64 * pOutArr = retSystemArr)
                        fixed ( UInt64 * inA1 = A.m_data) 
                        fixed ( UInt64 * inA2 = B.m_data) {
                            UInt64 * pInA1 = inA1; 
                            UInt64 * pInA2 = inA2;
                            int c = 0; 
                            UInt64 * poutarr = pOutArr;
                            UInt64 * outEnd = poutarr + retSystemArr.Length;
                            if (A.IsReference) { 
                                if (!B.IsReference) {
                                    while (poutarr < outEnd) {  //HC07
                                        tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; 
                                    }
                                } else {
                                    // optimization for matrix 
                                    if (inDim.NumberOfDimensions < 3) {
                                        fixed (int * pA1idx0 = A.m_indexOffset[0])
                                        fixed (int * pA1idx1 = A.m_indexOffset[1])
                                        fixed (int * pA2idx0 = B.m_indexOffset[0])
                                        fixed (int * pA2idx1 = B.m_indexOffset[1]) {
                                            int r = 0, rLen = A.m_dimensions[0];
                                            int        cLen = A.m_dimensions[1]; 
                                            while (poutarr < outEnd) {   //HC08
                                                tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;
                                                if (++r == rLen) {
                                                    r = 0; 
                                                    c++; 
                                                }
                                            }
                                        }
                                    } else {
                                         while (poutarr < outEnd) {  //HC09
                                             tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; 
                                        }
                                   }
                                   // tmpValue1 = 0; tmpValue2 = 0; 
                                }
                            } else {
                                if (B.IsReference) {
                                    while (poutarr < outEnd) {  //HC10
                                        tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;
                                    }
                                } else {
                                    while (poutarr < outEnd) {  //HC11
                                        if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}
                                    }
                                }
                            }
                        }
                    }
                    return new  ILArray<UInt64> ( retSystemArr, inDim.ToIntArray () );
                    #endregion array + array
                }
            }
        }
        /// <summary> sum two arrays elementwise</summary>
        /// <param name="A">input 1</param>
        /// <param name="B">input 2</param>
        /// <returns> Array with elementwise sum of A and B </returns>
        /// <remarks><para>On empty input - empty array will be returned.</para>
        /// <para>A and / or B may be scalar. The scalar value will operate on all elements of the other arrays in this case.</para>
        /// <para>If neither of A or B is scalar or empty, the dimensions of both arrays must match.</para></remarks>
        public static  ILArray<UInt32>  max ( ILArray<UInt32> A,  ILArray<UInt32> B) {
            if (A.IsEmpty || B.IsEmpty ) {
                return  ILArray<UInt32> .empty(); 
            }
            if (A.IsScalar) {
                if (B.IsScalar) {
                    return new ILArray<UInt32> (new UInt32[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});
                } else {
                    #region scalar + array  
                    ILDimension inDim = B.Dimensions;
                    //  UInt32 [] retArr = new  UInt32 [inDim.NumberOfElements];
                    UInt32 [] retArr = ILMemoryPool.Pool.New< UInt32 > (inDim.NumberOfElements);
                    UInt32 scalarValue = A.GetValue(0); 
                    UInt32 tmpValue2; 
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (B.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = B.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!B.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (B.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( UInt32 * pOutArr = retArr)
                                fixed ( UInt32 * pInArr = B.m_data) {
                                        UInt32 * tmpOut = pOutArr;
                                        UInt32 * tmpIn = pInArr;
                                        UInt32 * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [B.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( UInt32 * pOutArr = retArr)
                                    fixed ( UInt32 * pInArr = B.m_data) {
                                        UInt32 * tmpOut = pOutArr;
                                        UInt32 * tmpOutEnd = tmpOut + retArr.Length;
                                        // init lesezeiger: add alle Dimensionen mit 0 (auer leadDim)
                                        UInt32 * tmpIn = pInArr + B.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( UInt32 * pOutArr = retArr)
                            fixed ( UInt32 * pInArr = B.m_data) {
                                UInt32 * lastElement = pOutArr + retArr.Length;
                                UInt32 * tmpOut = pOutArr;
                                UInt32 * tmpIn = pInArr;
                                while (tmpOut < lastElement) //HC03
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                            }       
                        }
                        #endregion
                    }
                    return new  ILArray<UInt32> ( retArr, inDim.Clone() );
                    #endregion scalar + array
                }
            } else {
                if (B.IsScalar) {
                    #region array + scalar
                    ILDimension inDim = A.Dimensions;
                    //  UInt32 [] retArr = new  UInt32 [inDim.NumberOfElements];
                    UInt32 [] retArr = ILMemoryPool.Pool.New< UInt32 > (inDim.NumberOfElements);
                    UInt32 scalarValue = B.GetValue(0); 
                    UInt32 tmpValue1;
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (A.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!A.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (A.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( UInt32 * pOutArr = retArr)
                                fixed ( UInt32 * pInArr = A.m_data) {
                                        UInt32 * tmpOut = pOutArr;
                                        UInt32 * tmpIn = pInArr;
                                        UInt32 * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) { //HC04
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [A.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( UInt32 * pOutArr = retArr)
                                    fixed ( UInt32 * pInArr = A.m_data) {
                                        UInt32 * tmpOut = pOutArr;
                                        UInt32 * tmpOutEnd = tmpOut + retArr.Length;
                                        // init readpointer: add all Dimensions with 0 (except leadDim)
                                        UInt32 * tmpIn = pInArr + A.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {   //HC05
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( UInt32 * pOutArr = retArr)
                            fixed ( UInt32 * pInArr = A.m_data) {
                                UInt32 * lastElement = pOutArr + retArr.Length;
                                UInt32 * tmpOut = pOutArr;
                                UInt32 * tmpIn = pInArr;
                                while (tmpOut < lastElement) { //HC06
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                                }
                            }
                        }
                        #endregion
                        //tmpValue1 = 0; 
                    }
                    return new  ILArray<UInt32> ( retArr, inDim.Clone() );
                    #endregion array + scalar
                } else {
                    #region array + array
                    ILDimension inDim = A.Dimensions;
                    if (!inDim.IsSameSize ( B.Dimensions ))
                        throw new ILDimensionMismatchException ();
                    UInt32 [] retSystemArr;
                    UInt32 tmpValue1; 
                    UInt32 tmpValue2; 
                    // retSystemArr = new  UInt32 [inDim.NumberOfElements];
                    retSystemArr = ILMemoryPool.Pool.New< UInt32 > (inDim.NumberOfElements);
                    
                    int leadDim = 0, leadDimLen = inDim [0];
                    // this will most probably be not very fast, but .... :|
                    // walk along the longest dimension (for performance reasons)
                    for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                        if (leadDimLen < inDim [i]) {
                            leadDimLen = inDim [i];
                            leadDim = i;
                        }
                    }
                    unsafe {
                        fixed ( UInt32 * pOutArr = retSystemArr)
                        fixed ( UInt32 * inA1 = A.m_data) 
                        fixed ( UInt32 * inA2 = B.m_data) {
                            UInt32 * pInA1 = inA1; 
                            UInt32 * pInA2 = inA2;
                            int c = 0; 
                            UInt32 * poutarr = pOutArr;
                            UInt32 * outEnd = poutarr + retSystemArr.Length;
                            if (A.IsReference) { 
                                if (!B.IsReference) {
                                    while (poutarr < outEnd) {  //HC07
                                        tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; 
                                    }
                                } else {
                                    // optimization for matrix 
                                    if (inDim.NumberOfDimensions < 3) {
                                        fixed (int * pA1idx0 = A.m_indexOffset[0])
                                        fixed (int * pA1idx1 = A.m_indexOffset[1])
                                        fixed (int * pA2idx0 = B.m_indexOffset[0])
                                        fixed (int * pA2idx1 = B.m_indexOffset[1]) {
                                            int r = 0, rLen = A.m_dimensions[0];
                                            int        cLen = A.m_dimensions[1]; 
                                            while (poutarr < outEnd) {   //HC08
                                                tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;
                                                if (++r == rLen) {
                                                    r = 0; 
                                                    c++; 
                                                }
                                            }
                                        }
                                    } else {
                                         while (poutarr < outEnd) {  //HC09
                                             tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; 
                                        }
                                   }
                                   // tmpValue1 = 0; tmpValue2 = 0; 
                                }
                            } else {
                                if (B.IsReference) {
                                    while (poutarr < outEnd) {  //HC10
                                        tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;
                                    }
                                } else {
                                    while (poutarr < outEnd) {  //HC11
                                        if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}
                                    }
                                }
                            }
                        }
                    }
                    return new  ILArray<UInt32> ( retSystemArr, inDim.ToIntArray () );
                    #endregion array + array
                }
            }
        }
        /// <summary> sum two arrays elementwise</summary>
        /// <param name="A">input 1</param>
        /// <param name="B">input 2</param>
        /// <returns> Array with elementwise sum of A and B </returns>
        /// <remarks><para>On empty input - empty array will be returned.</para>
        /// <para>A and / or B may be scalar. The scalar value will operate on all elements of the other arrays in this case.</para>
        /// <para>If neither of A or B is scalar or empty, the dimensions of both arrays must match.</para></remarks>
        public static  ILArray<UInt16>  max ( ILArray<UInt16> A,  ILArray<UInt16> B) {
            if (A.IsEmpty || B.IsEmpty ) {
                return  ILArray<UInt16> .empty(); 
            }
            if (A.IsScalar) {
                if (B.IsScalar) {
                    return new ILArray<UInt16> (new UInt16[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});
                } else {
                    #region scalar + array  
                    ILDimension inDim = B.Dimensions;
                    //  UInt16 [] retArr = new  UInt16 [inDim.NumberOfElements];
                    UInt16 [] retArr = ILMemoryPool.Pool.New< UInt16 > (inDim.NumberOfElements);
                    UInt16 scalarValue = A.GetValue(0); 
                    UInt16 tmpValue2; 
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (B.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = B.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!B.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (B.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( UInt16 * pOutArr = retArr)
                                fixed ( UInt16 * pInArr = B.m_data) {
                                        UInt16 * tmpOut = pOutArr;
                                        UInt16 * tmpIn = pInArr;
                                        UInt16 * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [B.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( UInt16 * pOutArr = retArr)
                                    fixed ( UInt16 * pInArr = B.m_data) {
                                        UInt16 * tmpOut = pOutArr;
                                        UInt16 * tmpOutEnd = tmpOut + retArr.Length;
                                        // init lesezeiger: add alle Dimensionen mit 0 (auer leadDim)
                                        UInt16 * tmpIn = pInArr + B.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( UInt16 * pOutArr = retArr)
                            fixed ( UInt16 * pInArr = B.m_data) {
                                UInt16 * lastElement = pOutArr + retArr.Length;
                                UInt16 * tmpOut = pOutArr;
                                UInt16 * tmpIn = pInArr;
                                while (tmpOut < lastElement) //HC03
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                            }       
                        }
                        #endregion
                    }
                    return new  ILArray<UInt16> ( retArr, inDim.Clone() );
                    #endregion scalar + array
                }
            } else {
                if (B.IsScalar) {
                    #region array + scalar
                    ILDimension inDim = A.Dimensions;
                    //  UInt16 [] retArr = new  UInt16 [inDim.NumberOfElements];
                    UInt16 [] retArr = ILMemoryPool.Pool.New< UInt16 > (inDim.NumberOfElements);
                    UInt16 scalarValue = B.GetValue(0); 
                    UInt16 tmpValue1;
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (A.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!A.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (A.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( UInt16 * pOutArr = retArr)
                                fixed ( UInt16 * pInArr = A.m_data) {
                                        UInt16 * tmpOut = pOutArr;
                                        UInt16 * tmpIn = pInArr;
                                        UInt16 * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) { //HC04
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [A.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( UInt16 * pOutArr = retArr)
                                    fixed ( UInt16 * pInArr = A.m_data) {
                                        UInt16 * tmpOut = pOutArr;
                                        UInt16 * tmpOutEnd = tmpOut + retArr.Length;
                                        // init readpointer: add all Dimensions with 0 (except leadDim)
                                        UInt16 * tmpIn = pInArr + A.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {   //HC05
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( UInt16 * pOutArr = retArr)
                            fixed ( UInt16 * pInArr = A.m_data) {
                                UInt16 * lastElement = pOutArr + retArr.Length;
                                UInt16 * tmpOut = pOutArr;
                                UInt16 * tmpIn = pInArr;
                                while (tmpOut < lastElement) { //HC06
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                                }
                            }
                        }
                        #endregion
                        //tmpValue1 = 0; 
                    }
                    return new  ILArray<UInt16> ( retArr, inDim.Clone() );
                    #endregion array + scalar
                } else {
                    #region array + array
                    ILDimension inDim = A.Dimensions;
                    if (!inDim.IsSameSize ( B.Dimensions ))
                        throw new ILDimensionMismatchException ();
                    UInt16 [] retSystemArr;
                    UInt16 tmpValue1; 
                    UInt16 tmpValue2; 
                    // retSystemArr = new  UInt16 [inDim.NumberOfElements];
                    retSystemArr = ILMemoryPool.Pool.New< UInt16 > (inDim.NumberOfElements);
                    
                    int leadDim = 0, leadDimLen = inDim [0];
                    // this will most probably be not very fast, but .... :|
                    // walk along the longest dimension (for performance reasons)
                    for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                        if (leadDimLen < inDim [i]) {
                            leadDimLen = inDim [i];
                            leadDim = i;
                        }
                    }
                    unsafe {
                        fixed ( UInt16 * pOutArr = retSystemArr)
                        fixed ( UInt16 * inA1 = A.m_data) 
                        fixed ( UInt16 * inA2 = B.m_data) {
                            UInt16 * pInA1 = inA1; 
                            UInt16 * pInA2 = inA2;
                            int c = 0; 
                            UInt16 * poutarr = pOutArr;
                            UInt16 * outEnd = poutarr + retSystemArr.Length;
                            if (A.IsReference) { 
                                if (!B.IsReference) {
                                    while (poutarr < outEnd) {  //HC07
                                        tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; 
                                    }
                                } else {
                                    // optimization for matrix 
                                    if (inDim.NumberOfDimensions < 3) {
                                        fixed (int * pA1idx0 = A.m_indexOffset[0])
                                        fixed (int * pA1idx1 = A.m_indexOffset[1])
                                        fixed (int * pA2idx0 = B.m_indexOffset[0])
                                        fixed (int * pA2idx1 = B.m_indexOffset[1]) {
                                            int r = 0, rLen = A.m_dimensions[0];
                                            int        cLen = A.m_dimensions[1]; 
                                            while (poutarr < outEnd) {   //HC08
                                                tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;
                                                if (++r == rLen) {
                                                    r = 0; 
                                                    c++; 
                                                }
                                            }
                                        }
                                    } else {
                                         while (poutarr < outEnd) {  //HC09
                                             tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; 
                                        }
                                   }
                                   // tmpValue1 = 0; tmpValue2 = 0; 
                                }
                            } else {
                                if (B.IsReference) {
                                    while (poutarr < outEnd) {  //HC10
                                        tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;
                                    }
                                } else {
                                    while (poutarr < outEnd) {  //HC11
                                        if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}
                                    }
                                }
                            }
                        }
                    }
                    return new  ILArray<UInt16> ( retSystemArr, inDim.ToIntArray () );
                    #endregion array + array
                }
            }
        }
        /// <summary> sum two arrays elementwise</summary>
        /// <param name="A">input 1</param>
        /// <param name="B">input 2</param>
        /// <returns> Array with elementwise sum of A and B </returns>
        /// <remarks><para>On empty input - empty array will be returned.</para>
        /// <para>A and / or B may be scalar. The scalar value will operate on all elements of the other arrays in this case.</para>
        /// <para>If neither of A or B is scalar or empty, the dimensions of both arrays must match.</para></remarks>
        public static  ILArray<Int64>  max ( ILArray<Int64> A,  ILArray<Int64> B) {
            if (A.IsEmpty || B.IsEmpty ) {
                return  ILArray<Int64> .empty(); 
            }
            if (A.IsScalar) {
                if (B.IsScalar) {
                    return new ILArray<Int64> (new Int64[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});
                } else {
                    #region scalar + array  
                    ILDimension inDim = B.Dimensions;
                    //  Int64 [] retArr = new  Int64 [inDim.NumberOfElements];
                    Int64 [] retArr = ILMemoryPool.Pool.New< Int64 > (inDim.NumberOfElements);
                    Int64 scalarValue = A.GetValue(0); 
                    Int64 tmpValue2; 
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (B.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = B.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!B.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (B.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( Int64 * pOutArr = retArr)
                                fixed ( Int64 * pInArr = B.m_data) {
                                        Int64 * tmpOut = pOutArr;
                                        Int64 * tmpIn = pInArr;
                                        Int64 * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [B.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( Int64 * pOutArr = retArr)
                                    fixed ( Int64 * pInArr = B.m_data) {
                                        Int64 * tmpOut = pOutArr;
                                        Int64 * tmpOutEnd = tmpOut + retArr.Length;
                                        // init lesezeiger: add alle Dimensionen mit 0 (auer leadDim)
                                        Int64 * tmpIn = pInArr + B.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( Int64 * pOutArr = retArr)
                            fixed ( Int64 * pInArr = B.m_data) {
                                Int64 * lastElement = pOutArr + retArr.Length;
                                Int64 * tmpOut = pOutArr;
                                Int64 * tmpIn = pInArr;
                                while (tmpOut < lastElement) //HC03
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                            }       
                        }
                        #endregion
                    }
                    return new  ILArray<Int64> ( retArr, inDim.Clone() );
                    #endregion scalar + array
                }
            } else {
                if (B.IsScalar) {
                    #region array + scalar
                    ILDimension inDim = A.Dimensions;
                    //  Int64 [] retArr = new  Int64 [inDim.NumberOfElements];
                    Int64 [] retArr = ILMemoryPool.Pool.New< Int64 > (inDim.NumberOfElements);
                    Int64 scalarValue = B.GetValue(0); 
                    Int64 tmpValue1;
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (A.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!A.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (A.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( Int64 * pOutArr = retArr)
                                fixed ( Int64 * pInArr = A.m_data) {
                                        Int64 * tmpOut = pOutArr;
                                        Int64 * tmpIn = pInArr;
                                        Int64 * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) { //HC04
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [A.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( Int64 * pOutArr = retArr)
                                    fixed ( Int64 * pInArr = A.m_data) {
                                        Int64 * tmpOut = pOutArr;
                                        Int64 * tmpOutEnd = tmpOut + retArr.Length;
                                        // init readpointer: add all Dimensions with 0 (except leadDim)
                                        Int64 * tmpIn = pInArr + A.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {   //HC05
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( Int64 * pOutArr = retArr)
                            fixed ( Int64 * pInArr = A.m_data) {
                                Int64 * lastElement = pOutArr + retArr.Length;
                                Int64 * tmpOut = pOutArr;
                                Int64 * tmpIn = pInArr;
                                while (tmpOut < lastElement) { //HC06
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                                }
                            }
                        }
                        #endregion
                        //tmpValue1 = 0; 
                    }
                    return new  ILArray<Int64> ( retArr, inDim.Clone() );
                    #endregion array + scalar
                } else {
                    #region array + array
                    ILDimension inDim = A.Dimensions;
                    if (!inDim.IsSameSize ( B.Dimensions ))
                        throw new ILDimensionMismatchException ();
                    Int64 [] retSystemArr;
                    Int64 tmpValue1; 
                    Int64 tmpValue2; 
                    // retSystemArr = new  Int64 [inDim.NumberOfElements];
                    retSystemArr = ILMemoryPool.Pool.New< Int64 > (inDim.NumberOfElements);
                    
                    int leadDim = 0, leadDimLen = inDim [0];
                    // this will most probably be not very fast, but .... :|
                    // walk along the longest dimension (for performance reasons)
                    for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                        if (leadDimLen < inDim [i]) {
                            leadDimLen = inDim [i];
                            leadDim = i;
                        }
                    }
                    unsafe {
                        fixed ( Int64 * pOutArr = retSystemArr)
                        fixed ( Int64 * inA1 = A.m_data) 
                        fixed ( Int64 * inA2 = B.m_data) {
                            Int64 * pInA1 = inA1; 
                            Int64 * pInA2 = inA2;
                            int c = 0; 
                            Int64 * poutarr = pOutArr;
                            Int64 * outEnd = poutarr + retSystemArr.Length;
                            if (A.IsReference) { 
                                if (!B.IsReference) {
                                    while (poutarr < outEnd) {  //HC07
                                        tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; 
                                    }
                                } else {
                                    // optimization for matrix 
                                    if (inDim.NumberOfDimensions < 3) {
                                        fixed (int * pA1idx0 = A.m_indexOffset[0])
                                        fixed (int * pA1idx1 = A.m_indexOffset[1])
                                        fixed (int * pA2idx0 = B.m_indexOffset[0])
                                        fixed (int * pA2idx1 = B.m_indexOffset[1]) {
                                            int r = 0, rLen = A.m_dimensions[0];
                                            int        cLen = A.m_dimensions[1]; 
                                            while (poutarr < outEnd) {   //HC08
                                                tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;
                                                if (++r == rLen) {
                                                    r = 0; 
                                                    c++; 
                                                }
                                            }
                                        }
                                    } else {
                                         while (poutarr < outEnd) {  //HC09
                                             tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; 
                                        }
                                   }
                                   // tmpValue1 = 0; tmpValue2 = 0; 
                                }
                            } else {
                                if (B.IsReference) {
                                    while (poutarr < outEnd) {  //HC10
                                        tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;
                                    }
                                } else {
                                    while (poutarr < outEnd) {  //HC11
                                        if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}
                                    }
                                }
                            }
                        }
                    }
                    return new  ILArray<Int64> ( retSystemArr, inDim.ToIntArray () );
                    #endregion array + array
                }
            }
        }
        /// <summary> sum two arrays elementwise</summary>
        /// <param name="A">input 1</param>
        /// <param name="B">input 2</param>
        /// <returns> Array with elementwise sum of A and B </returns>
        /// <remarks><para>On empty input - empty array will be returned.</para>
        /// <para>A and / or B may be scalar. The scalar value will operate on all elements of the other arrays in this case.</para>
        /// <para>If neither of A or B is scalar or empty, the dimensions of both arrays must match.</para></remarks>
        public static  ILArray<Int32>  max ( ILArray<Int32> A,  ILArray<Int32> B) {
            if (A.IsEmpty || B.IsEmpty ) {
                return  ILArray<Int32> .empty(); 
            }
            if (A.IsScalar) {
                if (B.IsScalar) {
                    return new ILArray<Int32> (new Int32[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});
                } else {
                    #region scalar + array  
                    ILDimension inDim = B.Dimensions;
                    //  Int32 [] retArr = new  Int32 [inDim.NumberOfElements];
                    Int32 [] retArr = ILMemoryPool.Pool.New< Int32 > (inDim.NumberOfElements);
                    Int32 scalarValue = A.GetValue(0); 
                    Int32 tmpValue2; 
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (B.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = B.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!B.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (B.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( Int32 * pOutArr = retArr)
                                fixed ( Int32 * pInArr = B.m_data) {
                                        Int32 * tmpOut = pOutArr;
                                        Int32 * tmpIn = pInArr;
                                        Int32 * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [B.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( Int32 * pOutArr = retArr)
                                    fixed ( Int32 * pInArr = B.m_data) {
                                        Int32 * tmpOut = pOutArr;
                                        Int32 * tmpOutEnd = tmpOut + retArr.Length;
                                        // init lesezeiger: add alle Dimensionen mit 0 (auer leadDim)
                                        Int32 * tmpIn = pInArr + B.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( Int32 * pOutArr = retArr)
                            fixed ( Int32 * pInArr = B.m_data) {
                                Int32 * lastElement = pOutArr + retArr.Length;
                                Int32 * tmpOut = pOutArr;
                                Int32 * tmpIn = pInArr;
                                while (tmpOut < lastElement) //HC03
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                            }       
                        }
                        #endregion
                    }
                    return new  ILArray<Int32> ( retArr, inDim.Clone() );
                    #endregion scalar + array
                }
            } else {
                if (B.IsScalar) {
                    #region array + scalar
                    ILDimension inDim = A.Dimensions;
                    //  Int32 [] retArr = new  Int32 [inDim.NumberOfElements];
                    Int32 [] retArr = ILMemoryPool.Pool.New< Int32 > (inDim.NumberOfElements);
                    Int32 scalarValue = B.GetValue(0); 
                    Int32 tmpValue1;
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (A.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!A.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (A.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( Int32 * pOutArr = retArr)
                                fixed ( Int32 * pInArr = A.m_data) {
                                        Int32 * tmpOut = pOutArr;
                                        Int32 * tmpIn = pInArr;
                                        Int32 * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) { //HC04
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [A.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( Int32 * pOutArr = retArr)
                                    fixed ( Int32 * pInArr = A.m_data) {
                                        Int32 * tmpOut = pOutArr;
                                        Int32 * tmpOutEnd = tmpOut + retArr.Length;
                                        // init readpointer: add all Dimensions with 0 (except leadDim)
                                        Int32 * tmpIn = pInArr + A.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {   //HC05
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( Int32 * pOutArr = retArr)
                            fixed ( Int32 * pInArr = A.m_data) {
                                Int32 * lastElement = pOutArr + retArr.Length;
                                Int32 * tmpOut = pOutArr;
                                Int32 * tmpIn = pInArr;
                                while (tmpOut < lastElement) { //HC06
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                                }
                            }
                        }
                        #endregion
                        //tmpValue1 = 0; 
                    }
                    return new  ILArray<Int32> ( retArr, inDim.Clone() );
                    #endregion array + scalar
                } else {
                    #region array + array
                    ILDimension inDim = A.Dimensions;
                    if (!inDim.IsSameSize ( B.Dimensions ))
                        throw new ILDimensionMismatchException ();
                    Int32 [] retSystemArr;
                    Int32 tmpValue1; 
                    Int32 tmpValue2; 
                    // retSystemArr = new  Int32 [inDim.NumberOfElements];
                    retSystemArr = ILMemoryPool.Pool.New< Int32 > (inDim.NumberOfElements);
                    
                    int leadDim = 0, leadDimLen = inDim [0];
                    // this will most probably be not very fast, but .... :|
                    // walk along the longest dimension (for performance reasons)
                    for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                        if (leadDimLen < inDim [i]) {
                            leadDimLen = inDim [i];
                            leadDim = i;
                        }
                    }
                    unsafe {
                        fixed ( Int32 * pOutArr = retSystemArr)
                        fixed ( Int32 * inA1 = A.m_data) 
                        fixed ( Int32 * inA2 = B.m_data) {
                            Int32 * pInA1 = inA1; 
                            Int32 * pInA2 = inA2;
                            int c = 0; 
                            Int32 * poutarr = pOutArr;
                            Int32 * outEnd = poutarr + retSystemArr.Length;
                            if (A.IsReference) { 
                                if (!B.IsReference) {
                                    while (poutarr < outEnd) {  //HC07
                                        tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; 
                                    }
                                } else {
                                    // optimization for matrix 
                                    if (inDim.NumberOfDimensions < 3) {
                                        fixed (int * pA1idx0 = A.m_indexOffset[0])
                                        fixed (int * pA1idx1 = A.m_indexOffset[1])
                                        fixed (int * pA2idx0 = B.m_indexOffset[0])
                                        fixed (int * pA2idx1 = B.m_indexOffset[1]) {
                                            int r = 0, rLen = A.m_dimensions[0];
                                            int        cLen = A.m_dimensions[1]; 
                                            while (poutarr < outEnd) {   //HC08
                                                tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;
                                                if (++r == rLen) {
                                                    r = 0; 
                                                    c++; 
                                                }
                                            }
                                        }
                                    } else {
                                         while (poutarr < outEnd) {  //HC09
                                             tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; 
                                        }
                                   }
                                   // tmpValue1 = 0; tmpValue2 = 0; 
                                }
                            } else {
                                if (B.IsReference) {
                                    while (poutarr < outEnd) {  //HC10
                                        tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;
                                    }
                                } else {
                                    while (poutarr < outEnd) {  //HC11
                                        if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}
                                    }
                                }
                            }
                        }
                    }
                    return new  ILArray<Int32> ( retSystemArr, inDim.ToIntArray () );
                    #endregion array + array
                }
            }
        }
        /// <summary> sum two arrays elementwise</summary>
        /// <param name="A">input 1</param>
        /// <param name="B">input 2</param>
        /// <returns> Array with elementwise sum of A and B </returns>
        /// <remarks><para>On empty input - empty array will be returned.</para>
        /// <para>A and / or B may be scalar. The scalar value will operate on all elements of the other arrays in this case.</para>
        /// <para>If neither of A or B is scalar or empty, the dimensions of both arrays must match.</para></remarks>
        public static  ILArray<Int16>  max ( ILArray<Int16> A,  ILArray<Int16> B) {
            if (A.IsEmpty || B.IsEmpty ) {
                return  ILArray<Int16> .empty(); 
            }
            if (A.IsScalar) {
                if (B.IsScalar) {
                    return new ILArray<Int16> (new Int16[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});
                } else {
                    #region scalar + array  
                    ILDimension inDim = B.Dimensions;
                    //  Int16 [] retArr = new  Int16 [inDim.NumberOfElements];
                    Int16 [] retArr = ILMemoryPool.Pool.New< Int16 > (inDim.NumberOfElements);
                    Int16 scalarValue = A.GetValue(0); 
                    Int16 tmpValue2; 
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (B.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = B.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!B.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (B.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( Int16 * pOutArr = retArr)
                                fixed ( Int16 * pInArr = B.m_data) {
                                        Int16 * tmpOut = pOutArr;
                                        Int16 * tmpIn = pInArr;
                                        Int16 * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [B.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( Int16 * pOutArr = retArr)
                                    fixed ( Int16 * pInArr = B.m_data) {
                                        Int16 * tmpOut = pOutArr;
                                        Int16 * tmpOutEnd = tmpOut + retArr.Length;
                                        // init lesezeiger: add alle Dimensionen mit 0 (auer leadDim)
                                        Int16 * tmpIn = pInArr + B.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( Int16 * pOutArr = retArr)
                            fixed ( Int16 * pInArr = B.m_data) {
                                Int16 * lastElement = pOutArr + retArr.Length;
                                Int16 * tmpOut = pOutArr;
                                Int16 * tmpIn = pInArr;
                                while (tmpOut < lastElement) //HC03
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                            }       
                        }
                        #endregion
                    }
                    return new  ILArray<Int16> ( retArr, inDim.Clone() );
                    #endregion scalar + array
                }
            } else {
                if (B.IsScalar) {
                    #region array + scalar
                    ILDimension inDim = A.Dimensions;
                    //  Int16 [] retArr = new  Int16 [inDim.NumberOfElements];
                    Int16 [] retArr = ILMemoryPool.Pool.New< Int16 > (inDim.NumberOfElements);
                    Int16 scalarValue = B.GetValue(0); 
                    Int16 tmpValue1;
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (A.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!A.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (A.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( Int16 * pOutArr = retArr)
                                fixed ( Int16 * pInArr = A.m_data) {
                                        Int16 * tmpOut = pOutArr;
                                        Int16 * tmpIn = pInArr;
                                        Int16 * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) { //HC04
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [A.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( Int16 * pOutArr = retArr)
                                    fixed ( Int16 * pInArr = A.m_data) {
                                        Int16 * tmpOut = pOutArr;
                                        Int16 * tmpOutEnd = tmpOut + retArr.Length;
                                        // init readpointer: add all Dimensions with 0 (except leadDim)
                                        Int16 * tmpIn = pInArr + A.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {   //HC05
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( Int16 * pOutArr = retArr)
                            fixed ( Int16 * pInArr = A.m_data) {
                                Int16 * lastElement = pOutArr + retArr.Length;
                                Int16 * tmpOut = pOutArr;
                                Int16 * tmpIn = pInArr;
                                while (tmpOut < lastElement) { //HC06
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                                }
                            }
                        }
                        #endregion
                        //tmpValue1 = 0; 
                    }
                    return new  ILArray<Int16> ( retArr, inDim.Clone() );
                    #endregion array + scalar
                } else {
                    #region array + array
                    ILDimension inDim = A.Dimensions;
                    if (!inDim.IsSameSize ( B.Dimensions ))
                        throw new ILDimensionMismatchException ();
                    Int16 [] retSystemArr;
                    Int16 tmpValue1; 
                    Int16 tmpValue2; 
                    // retSystemArr = new  Int16 [inDim.NumberOfElements];
                    retSystemArr = ILMemoryPool.Pool.New< Int16 > (inDim.NumberOfElements);
                    
                    int leadDim = 0, leadDimLen = inDim [0];
                    // this will most probably be not very fast, but .... :|
                    // walk along the longest dimension (for performance reasons)
                    for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                        if (leadDimLen < inDim [i]) {
                            leadDimLen = inDim [i];
                            leadDim = i;
                        }
                    }
                    unsafe {
                        fixed ( Int16 * pOutArr = retSystemArr)
                        fixed ( Int16 * inA1 = A.m_data) 
                        fixed ( Int16 * inA2 = B.m_data) {
                            Int16 * pInA1 = inA1; 
                            Int16 * pInA2 = inA2;
                            int c = 0; 
                            Int16 * poutarr = pOutArr;
                            Int16 * outEnd = poutarr + retSystemArr.Length;
                            if (A.IsReference) { 
                                if (!B.IsReference) {
                                    while (poutarr < outEnd) {  //HC07
                                        tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; 
                                    }
                                } else {
                                    // optimization for matrix 
                                    if (inDim.NumberOfDimensions < 3) {
                                        fixed (int * pA1idx0 = A.m_indexOffset[0])
                                        fixed (int * pA1idx1 = A.m_indexOffset[1])
                                        fixed (int * pA2idx0 = B.m_indexOffset[0])
                                        fixed (int * pA2idx1 = B.m_indexOffset[1]) {
                                            int r = 0, rLen = A.m_dimensions[0];
                                            int        cLen = A.m_dimensions[1]; 
                                            while (poutarr < outEnd) {   //HC08
                                                tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;
                                                if (++r == rLen) {
                                                    r = 0; 
                                                    c++; 
                                                }
                                            }
                                        }
                                    } else {
                                         while (poutarr < outEnd) {  //HC09
                                             tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; 
                                        }
                                   }
                                   // tmpValue1 = 0; tmpValue2 = 0; 
                                }
                            } else {
                                if (B.IsReference) {
                                    while (poutarr < outEnd) {  //HC10
                                        tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;
                                    }
                                } else {
                                    while (poutarr < outEnd) {  //HC11
                                        if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}
                                    }
                                }
                            }
                        }
                    }
                    return new  ILArray<Int16> ( retSystemArr, inDim.ToIntArray () );
                    #endregion array + array
                }
            }
        }
        /// <summary> sum two arrays elementwise</summary>
        /// <param name="A">input 1</param>
        /// <param name="B">input 2</param>
        /// <returns> Array with elementwise sum of A and B </returns>
        /// <remarks><para>On empty input - empty array will be returned.</para>
        /// <para>A and / or B may be scalar. The scalar value will operate on all elements of the other arrays in this case.</para>
        /// <para>If neither of A or B is scalar or empty, the dimensions of both arrays must match.</para></remarks>
        public static  ILArray<float>  max ( ILArray<float> A,  ILArray<float> B) {
            if (A.IsEmpty || B.IsEmpty ) {
                return  ILArray<float> .empty(); 
            }
            if (A.IsScalar) {
                if (B.IsScalar) {
                    return new ILArray<float> (new float[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});
                } else {
                    #region scalar + array  
                    ILDimension inDim = B.Dimensions;
                    //  float [] retArr = new  float [inDim.NumberOfElements];
                    float [] retArr = ILMemoryPool.Pool.New< float > (inDim.NumberOfElements);
                    float scalarValue = A.GetValue(0); 
                    float tmpValue2; 
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (B.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = B.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!B.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (B.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( float * pOutArr = retArr)
                                fixed ( float * pInArr = B.m_data) {
                                        float * tmpOut = pOutArr;
                                        float * tmpIn = pInArr;
                                        float * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [B.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( float * pOutArr = retArr)
                                    fixed ( float * pInArr = B.m_data) {
                                        float * tmpOut = pOutArr;
                                        float * tmpOutEnd = tmpOut + retArr.Length;
                                        // init lesezeiger: add alle Dimensionen mit 0 (auer leadDim)
                                        float * tmpIn = pInArr + B.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( float * pOutArr = retArr)
                            fixed ( float * pInArr = B.m_data) {
                                float * lastElement = pOutArr + retArr.Length;
                                float * tmpOut = pOutArr;
                                float * tmpIn = pInArr;
                                while (tmpOut < lastElement) //HC03
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                            }       
                        }
                        #endregion
                    }
                    return new  ILArray<float> ( retArr, inDim.Clone() );
                    #endregion scalar + array
                }
            } else {
                if (B.IsScalar) {
                    #region array + scalar
                    ILDimension inDim = A.Dimensions;
                    //  float [] retArr = new  float [inDim.NumberOfElements];
                    float [] retArr = ILMemoryPool.Pool.New< float > (inDim.NumberOfElements);
                    float scalarValue = B.GetValue(0); 
                    float tmpValue1;
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (A.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!A.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (A.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( float * pOutArr = retArr)
                                fixed ( float * pInArr = A.m_data) {
                                        float * tmpOut = pOutArr;
                                        float * tmpIn = pInArr;
                                        float * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) { //HC04
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [A.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( float * pOutArr = retArr)
                                    fixed ( float * pInArr = A.m_data) {
                                        float * tmpOut = pOutArr;
                                        float * tmpOutEnd = tmpOut + retArr.Length;
                                        // init readpointer: add all Dimensions with 0 (except leadDim)
                                        float * tmpIn = pInArr + A.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {   //HC05
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( float * pOutArr = retArr)
                            fixed ( float * pInArr = A.m_data) {
                                float * lastElement = pOutArr + retArr.Length;
                                float * tmpOut = pOutArr;
                                float * tmpIn = pInArr;
                                while (tmpOut < lastElement) { //HC06
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                                }
                            }
                        }
                        #endregion
                        //tmpValue1 = 0; 
                    }
                    return new  ILArray<float> ( retArr, inDim.Clone() );
                    #endregion array + scalar
                } else {
                    #region array + array
                    ILDimension inDim = A.Dimensions;
                    if (!inDim.IsSameSize ( B.Dimensions ))
                        throw new ILDimensionMismatchException ();
                    float [] retSystemArr;
                    float tmpValue1; 
                    float tmpValue2; 
                    // retSystemArr = new  float [inDim.NumberOfElements];
                    retSystemArr = ILMemoryPool.Pool.New< float > (inDim.NumberOfElements);
                    
                    int leadDim = 0, leadDimLen = inDim [0];
                    // this will most probably be not very fast, but .... :|
                    // walk along the longest dimension (for performance reasons)
                    for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                        if (leadDimLen < inDim [i]) {
                            leadDimLen = inDim [i];
                            leadDim = i;
                        }
                    }
                    unsafe {
                        fixed ( float * pOutArr = retSystemArr)
                        fixed ( float * inA1 = A.m_data) 
                        fixed ( float * inA2 = B.m_data) {
                            float * pInA1 = inA1; 
                            float * pInA2 = inA2;
                            int c = 0; 
                            float * poutarr = pOutArr;
                            float * outEnd = poutarr + retSystemArr.Length;
                            if (A.IsReference) { 
                                if (!B.IsReference) {
                                    while (poutarr < outEnd) {  //HC07
                                        tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; 
                                    }
                                } else {
                                    // optimization for matrix 
                                    if (inDim.NumberOfDimensions < 3) {
                                        fixed (int * pA1idx0 = A.m_indexOffset[0])
                                        fixed (int * pA1idx1 = A.m_indexOffset[1])
                                        fixed (int * pA2idx0 = B.m_indexOffset[0])
                                        fixed (int * pA2idx1 = B.m_indexOffset[1]) {
                                            int r = 0, rLen = A.m_dimensions[0];
                                            int        cLen = A.m_dimensions[1]; 
                                            while (poutarr < outEnd) {   //HC08
                                                tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;
                                                if (++r == rLen) {
                                                    r = 0; 
                                                    c++; 
                                                }
                                            }
                                        }
                                    } else {
                                         while (poutarr < outEnd) {  //HC09
                                             tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; 
                                        }
                                   }
                                   // tmpValue1 = 0; tmpValue2 = 0; 
                                }
                            } else {
                                if (B.IsReference) {
                                    while (poutarr < outEnd) {  //HC10
                                        tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;
                                    }
                                } else {
                                    while (poutarr < outEnd) {  //HC11
                                        if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}
                                    }
                                }
                            }
                        }
                    }
                    return new  ILArray<float> ( retSystemArr, inDim.ToIntArray () );
                    #endregion array + array
                }
            }
        }
        /// <summary> sum two arrays elementwise</summary>
        /// <param name="A">input 1</param>
        /// <param name="B">input 2</param>
        /// <returns> Array with elementwise sum of A and B </returns>
        /// <remarks><para>On empty input - empty array will be returned.</para>
        /// <para>A and / or B may be scalar. The scalar value will operate on all elements of the other arrays in this case.</para>
        /// <para>If neither of A or B is scalar or empty, the dimensions of both arrays must match.</para></remarks>
        public static  ILArray<fcomplex>  max ( ILArray<fcomplex> A,  ILArray<fcomplex> B) {
            if (A.IsEmpty || B.IsEmpty ) {
                return  ILArray<fcomplex> .empty(); 
            }
            if (A.IsScalar) {
                if (B.IsScalar) {
                    return new ILArray<fcomplex> (new fcomplex[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});
                } else {
                    #region scalar + array  
                    ILDimension inDim = B.Dimensions;
                    //  fcomplex [] retArr = new  fcomplex [inDim.NumberOfElements];
                    fcomplex [] retArr = ILMemoryPool.Pool.New< fcomplex > (inDim.NumberOfElements);
                    fcomplex scalarValue = A.GetValue(0); 
                    fcomplex tmpValue2; 
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (B.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = B.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!B.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (B.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( fcomplex * pOutArr = retArr)
                                fixed ( fcomplex * pInArr = B.m_data) {
                                        fcomplex * tmpOut = pOutArr;
                                        fcomplex * tmpIn = pInArr;
                                        fcomplex * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [B.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( fcomplex * pOutArr = retArr)
                                    fixed ( fcomplex * pInArr = B.m_data) {
                                        fcomplex * tmpOut = pOutArr;
                                        fcomplex * tmpOutEnd = tmpOut + retArr.Length;
                                        // init lesezeiger: add alle Dimensionen mit 0 (auer leadDim)
                                        fcomplex * tmpIn = pInArr + B.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( fcomplex * pOutArr = retArr)
                            fixed ( fcomplex * pInArr = B.m_data) {
                                fcomplex * lastElement = pOutArr + retArr.Length;
                                fcomplex * tmpOut = pOutArr;
                                fcomplex * tmpIn = pInArr;
                                while (tmpOut < lastElement) //HC03
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                            }       
                        }
                        #endregion
                    }
                    return new  ILArray<fcomplex> ( retArr, inDim.Clone() );
                    #endregion scalar + array
                }
            } else {
                if (B.IsScalar) {
                    #region array + scalar
                    ILDimension inDim = A.Dimensions;
                    //  fcomplex [] retArr = new  fcomplex [inDim.NumberOfElements];
                    fcomplex [] retArr = ILMemoryPool.Pool.New< fcomplex > (inDim.NumberOfElements);
                    fcomplex scalarValue = B.GetValue(0); 
                    fcomplex tmpValue1;
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (A.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!A.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (A.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( fcomplex * pOutArr = retArr)
                                fixed ( fcomplex * pInArr = A.m_data) {
                                        fcomplex * tmpOut = pOutArr;
                                        fcomplex * tmpIn = pInArr;
                                        fcomplex * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) { //HC04
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [A.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( fcomplex * pOutArr = retArr)
                                    fixed ( fcomplex * pInArr = A.m_data) {
                                        fcomplex * tmpOut = pOutArr;
                                        fcomplex * tmpOutEnd = tmpOut + retArr.Length;
                                        // init readpointer: add all Dimensions with 0 (except leadDim)
                                        fcomplex * tmpIn = pInArr + A.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {   //HC05
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( fcomplex * pOutArr = retArr)
                            fixed ( fcomplex * pInArr = A.m_data) {
                                fcomplex * lastElement = pOutArr + retArr.Length;
                                fcomplex * tmpOut = pOutArr;
                                fcomplex * tmpIn = pInArr;
                                while (tmpOut < lastElement) { //HC06
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                                }
                            }
                        }
                        #endregion
                        //tmpValue1 = 0; 
                    }
                    return new  ILArray<fcomplex> ( retArr, inDim.Clone() );
                    #endregion array + scalar
                } else {
                    #region array + array
                    ILDimension inDim = A.Dimensions;
                    if (!inDim.IsSameSize ( B.Dimensions ))
                        throw new ILDimensionMismatchException ();
                    fcomplex [] retSystemArr;
                    fcomplex tmpValue1; 
                    fcomplex tmpValue2; 
                    // retSystemArr = new  fcomplex [inDim.NumberOfElements];
                    retSystemArr = ILMemoryPool.Pool.New< fcomplex > (inDim.NumberOfElements);
                    
                    int leadDim = 0, leadDimLen = inDim [0];
                    // this will most probably be not very fast, but .... :|
                    // walk along the longest dimension (for performance reasons)
                    for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                        if (leadDimLen < inDim [i]) {
                            leadDimLen = inDim [i];
                            leadDim = i;
                        }
                    }
                    unsafe {
                        fixed ( fcomplex * pOutArr = retSystemArr)
                        fixed ( fcomplex * inA1 = A.m_data) 
                        fixed ( fcomplex * inA2 = B.m_data) {
                            fcomplex * pInA1 = inA1; 
                            fcomplex * pInA2 = inA2;
                            int c = 0; 
                            fcomplex * poutarr = pOutArr;
                            fcomplex * outEnd = poutarr + retSystemArr.Length;
                            if (A.IsReference) { 
                                if (!B.IsReference) {
                                    while (poutarr < outEnd) {  //HC07
                                        tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; 
                                    }
                                } else {
                                    // optimization for matrix 
                                    if (inDim.NumberOfDimensions < 3) {
                                        fixed (int * pA1idx0 = A.m_indexOffset[0])
                                        fixed (int * pA1idx1 = A.m_indexOffset[1])
                                        fixed (int * pA2idx0 = B.m_indexOffset[0])
                                        fixed (int * pA2idx1 = B.m_indexOffset[1]) {
                                            int r = 0, rLen = A.m_dimensions[0];
                                            int        cLen = A.m_dimensions[1]; 
                                            while (poutarr < outEnd) {   //HC08
                                                tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;
                                                if (++r == rLen) {
                                                    r = 0; 
                                                    c++; 
                                                }
                                            }
                                        }
                                    } else {
                                         while (poutarr < outEnd) {  //HC09
                                             tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; 
                                        }
                                   }
                                   // tmpValue1 = 0; tmpValue2 = 0; 
                                }
                            } else {
                                if (B.IsReference) {
                                    while (poutarr < outEnd) {  //HC10
                                        tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;
                                    }
                                } else {
                                    while (poutarr < outEnd) {  //HC11
                                        if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}
                                    }
                                }
                            }
                        }
                    }
                    return new  ILArray<fcomplex> ( retSystemArr, inDim.ToIntArray () );
                    #endregion array + array
                }
            }
        }
        /// <summary> sum two arrays elementwise</summary>
        /// <param name="A">input 1</param>
        /// <param name="B">input 2</param>
        /// <returns> Array with elementwise sum of A and B </returns>
        /// <remarks><para>On empty input - empty array will be returned.</para>
        /// <para>A and / or B may be scalar. The scalar value will operate on all elements of the other arrays in this case.</para>
        /// <para>If neither of A or B is scalar or empty, the dimensions of both arrays must match.</para></remarks>
        public static  ILArray<complex>  max ( ILArray<complex> A,  ILArray<complex> B) {
            if (A.IsEmpty || B.IsEmpty ) {
                return  ILArray<complex> .empty(); 
            }
            if (A.IsScalar) {
                if (B.IsScalar) {
                    return new ILArray<complex> (new complex[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});
                } else {
                    #region scalar + array  
                    ILDimension inDim = B.Dimensions;
                    //  complex [] retArr = new  complex [inDim.NumberOfElements];
                    complex [] retArr = ILMemoryPool.Pool.New< complex > (inDim.NumberOfElements);
                    complex scalarValue = A.GetValue(0); 
                    complex tmpValue2; 
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (B.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = B.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!B.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (B.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( complex * pOutArr = retArr)
                                fixed ( complex * pInArr = B.m_data) {
                                        complex * tmpOut = pOutArr;
                                        complex * tmpIn = pInArr;
                                        complex * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [B.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( complex * pOutArr = retArr)
                                    fixed ( complex * pInArr = B.m_data) {
                                        complex * tmpOut = pOutArr;
                                        complex * tmpOutEnd = tmpOut + retArr.Length;
                                        // init lesezeiger: add alle Dimensionen mit 0 (auer leadDim)
                                        complex * tmpIn = pInArr + B.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( complex * pOutArr = retArr)
                            fixed ( complex * pInArr = B.m_data) {
                                complex * lastElement = pOutArr + retArr.Length;
                                complex * tmpOut = pOutArr;
                                complex * tmpIn = pInArr;
                                while (tmpOut < lastElement) //HC03
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                            }       
                        }
                        #endregion
                    }
                    return new  ILArray<complex> ( retArr, inDim.Clone() );
                    #endregion scalar + array
                }
            } else {
                if (B.IsScalar) {
                    #region array + scalar
                    ILDimension inDim = A.Dimensions;
                    //  complex [] retArr = new  complex [inDim.NumberOfElements];
                    complex [] retArr = ILMemoryPool.Pool.New< complex > (inDim.NumberOfElements);
                    complex scalarValue = B.GetValue(0); 
                    complex tmpValue1;
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (A.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!A.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (A.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( complex * pOutArr = retArr)
                                fixed ( complex * pInArr = A.m_data) {
                                        complex * tmpOut = pOutArr;
                                        complex * tmpIn = pInArr;
                                        complex * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) { //HC04
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [A.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( complex * pOutArr = retArr)
                                    fixed ( complex * pInArr = A.m_data) {
                                        complex * tmpOut = pOutArr;
                                        complex * tmpOutEnd = tmpOut + retArr.Length;
                                        // init readpointer: add all Dimensions with 0 (except leadDim)
                                        complex * tmpIn = pInArr + A.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {   //HC05
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( complex * pOutArr = retArr)
                            fixed ( complex * pInArr = A.m_data) {
                                complex * lastElement = pOutArr + retArr.Length;
                                complex * tmpOut = pOutArr;
                                complex * tmpIn = pInArr;
                                while (tmpOut < lastElement) { //HC06
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                                }
                            }
                        }
                        #endregion
                        //tmpValue1 = 0; 
                    }
                    return new  ILArray<complex> ( retArr, inDim.Clone() );
                    #endregion array + scalar
                } else {
                    #region array + array
                    ILDimension inDim = A.Dimensions;
                    if (!inDim.IsSameSize ( B.Dimensions ))
                        throw new ILDimensionMismatchException ();
                    complex [] retSystemArr;
                    complex tmpValue1; 
                    complex tmpValue2; 
                    // retSystemArr = new  complex [inDim.NumberOfElements];
                    retSystemArr = ILMemoryPool.Pool.New< complex > (inDim.NumberOfElements);
                    
                    int leadDim = 0, leadDimLen = inDim [0];
                    // this will most probably be not very fast, but .... :|
                    // walk along the longest dimension (for performance reasons)
                    for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                        if (leadDimLen < inDim [i]) {
                            leadDimLen = inDim [i];
                            leadDim = i;
                        }
                    }
                    unsafe {
                        fixed ( complex * pOutArr = retSystemArr)
                        fixed ( complex * inA1 = A.m_data) 
                        fixed ( complex * inA2 = B.m_data) {
                            complex * pInA1 = inA1; 
                            complex * pInA2 = inA2;
                            int c = 0; 
                            complex * poutarr = pOutArr;
                            complex * outEnd = poutarr + retSystemArr.Length;
                            if (A.IsReference) { 
                                if (!B.IsReference) {
                                    while (poutarr < outEnd) {  //HC07
                                        tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; 
                                    }
                                } else {
                                    // optimization for matrix 
                                    if (inDim.NumberOfDimensions < 3) {
                                        fixed (int * pA1idx0 = A.m_indexOffset[0])
                                        fixed (int * pA1idx1 = A.m_indexOffset[1])
                                        fixed (int * pA2idx0 = B.m_indexOffset[0])
                                        fixed (int * pA2idx1 = B.m_indexOffset[1]) {
                                            int r = 0, rLen = A.m_dimensions[0];
                                            int        cLen = A.m_dimensions[1]; 
                                            while (poutarr < outEnd) {   //HC08
                                                tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;
                                                if (++r == rLen) {
                                                    r = 0; 
                                                    c++; 
                                                }
                                            }
                                        }
                                    } else {
                                         while (poutarr < outEnd) {  //HC09
                                             tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; 
                                        }
                                   }
                                   // tmpValue1 = 0; tmpValue2 = 0; 
                                }
                            } else {
                                if (B.IsReference) {
                                    while (poutarr < outEnd) {  //HC10
                                        tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;
                                    }
                                } else {
                                    while (poutarr < outEnd) {  //HC11
                                        if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}
                                    }
                                }
                            }
                        }
                    }
                    return new  ILArray<complex> ( retSystemArr, inDim.ToIntArray () );
                    #endregion array + array
                }
            }
        }
        /// <summary> sum two arrays elementwise</summary>
        /// <param name="A">input 1</param>
        /// <param name="B">input 2</param>
        /// <returns> Array with elementwise sum of A and B </returns>
        /// <remarks><para>On empty input - empty array will be returned.</para>
        /// <para>A and / or B may be scalar. The scalar value will operate on all elements of the other arrays in this case.</para>
        /// <para>If neither of A or B is scalar or empty, the dimensions of both arrays must match.</para></remarks>
        public static  ILArray<char>  max ( ILArray<char> A,  ILArray<char> B) {
            if (A.IsEmpty || B.IsEmpty ) {
                return  ILArray<char> .empty(); 
            }
            if (A.IsScalar) {
                if (B.IsScalar) {
                    return new ILArray<char> (new char[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});
                } else {
                    #region scalar + array  
                    ILDimension inDim = B.Dimensions;
                    //  char [] retArr = new  char [inDim.NumberOfElements];
                    char [] retArr = ILMemoryPool.Pool.New< char > (inDim.NumberOfElements);
                    char scalarValue = A.GetValue(0); 
                    char tmpValue2; 
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (B.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = B.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!B.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (B.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( char * pOutArr = retArr)
                                fixed ( char * pInArr = B.m_data) {
                                        char * tmpOut = pOutArr;
                                        char * tmpIn = pInArr;
                                        char * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [B.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( char * pOutArr = retArr)
                                    fixed ( char * pInArr = B.m_data) {
                                        char * tmpOut = pOutArr;
                                        char * tmpOutEnd = tmpOut + retArr.Length;
                                        // init lesezeiger: add alle Dimensionen mit 0 (auer leadDim)
                                        char * tmpIn = pInArr + B.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( char * pOutArr = retArr)
                            fixed ( char * pInArr = B.m_data) {
                                char * lastElement = pOutArr + retArr.Length;
                                char * tmpOut = pOutArr;
                                char * tmpIn = pInArr;
                                while (tmpOut < lastElement) //HC03
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                            }       
                        }
                        #endregion
                    }
                    return new  ILArray<char> ( retArr, inDim.Clone() );
                    #endregion scalar + array
                }
            } else {
                if (B.IsScalar) {
                    #region array + scalar
                    ILDimension inDim = A.Dimensions;
                    //  char [] retArr = new  char [inDim.NumberOfElements];
                    char [] retArr = ILMemoryPool.Pool.New< char > (inDim.NumberOfElements);
                    char scalarValue = B.GetValue(0); 
                    char tmpValue1;
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (A.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!A.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (A.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( char * pOutArr = retArr)
                                fixed ( char * pInArr = A.m_data) {
                                        char * tmpOut = pOutArr;
                                        char * tmpIn = pInArr;
                                        char * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) { //HC04
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [A.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( char * pOutArr = retArr)
                                    fixed ( char * pInArr = A.m_data) {
                                        char * tmpOut = pOutArr;
                                        char * tmpOutEnd = tmpOut + retArr.Length;
                                        // init readpointer: add all Dimensions with 0 (except leadDim)
                                        char * tmpIn = pInArr + A.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {   //HC05
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( char * pOutArr = retArr)
                            fixed ( char * pInArr = A.m_data) {
                                char * lastElement = pOutArr + retArr.Length;
                                char * tmpOut = pOutArr;
                                char * tmpIn = pInArr;
                                while (tmpOut < lastElement) { //HC06
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                                }
                            }
                        }
                        #endregion
                        //tmpValue1 = 0; 
                    }
                    return new  ILArray<char> ( retArr, inDim.Clone() );
                    #endregion array + scalar
                } else {
                    #region array + array
                    ILDimension inDim = A.Dimensions;
                    if (!inDim.IsSameSize ( B.Dimensions ))
                        throw new ILDimensionMismatchException ();
                    char [] retSystemArr;
                    char tmpValue1; 
                    char tmpValue2; 
                    // retSystemArr = new  char [inDim.NumberOfElements];
                    retSystemArr = ILMemoryPool.Pool.New< char > (inDim.NumberOfElements);
                    
                    int leadDim = 0, leadDimLen = inDim [0];
                    // this will most probably be not very fast, but .... :|
                    // walk along the longest dimension (for performance reasons)
                    for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                        if (leadDimLen < inDim [i]) {
                            leadDimLen = inDim [i];
                            leadDim = i;
                        }
                    }
                    unsafe {
                        fixed ( char * pOutArr = retSystemArr)
                        fixed ( char * inA1 = A.m_data) 
                        fixed ( char * inA2 = B.m_data) {
                            char * pInA1 = inA1; 
                            char * pInA2 = inA2;
                            int c = 0; 
                            char * poutarr = pOutArr;
                            char * outEnd = poutarr + retSystemArr.Length;
                            if (A.IsReference) { 
                                if (!B.IsReference) {
                                    while (poutarr < outEnd) {  //HC07
                                        tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; 
                                    }
                                } else {
                                    // optimization for matrix 
                                    if (inDim.NumberOfDimensions < 3) {
                                        fixed (int * pA1idx0 = A.m_indexOffset[0])
                                        fixed (int * pA1idx1 = A.m_indexOffset[1])
                                        fixed (int * pA2idx0 = B.m_indexOffset[0])
                                        fixed (int * pA2idx1 = B.m_indexOffset[1]) {
                                            int r = 0, rLen = A.m_dimensions[0];
                                            int        cLen = A.m_dimensions[1]; 
                                            while (poutarr < outEnd) {   //HC08
                                                tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;
                                                if (++r == rLen) {
                                                    r = 0; 
                                                    c++; 
                                                }
                                            }
                                        }
                                    } else {
                                         while (poutarr < outEnd) {  //HC09
                                             tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; 
                                        }
                                   }
                                   // tmpValue1 = 0; tmpValue2 = 0; 
                                }
                            } else {
                                if (B.IsReference) {
                                    while (poutarr < outEnd) {  //HC10
                                        tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;
                                    }
                                } else {
                                    while (poutarr < outEnd) {  //HC11
                                        if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}
                                    }
                                }
                            }
                        }
                    }
                    return new  ILArray<char> ( retSystemArr, inDim.ToIntArray () );
                    #endregion array + array
                }
            }
        }
        /// <summary> sum two arrays elementwise</summary>
        /// <param name="A">input 1</param>
        /// <param name="B">input 2</param>
        /// <returns> Array with elementwise sum of A and B </returns>
        /// <remarks><para>On empty input - empty array will be returned.</para>
        /// <para>A and / or B may be scalar. The scalar value will operate on all elements of the other arrays in this case.</para>
        /// <para>If neither of A or B is scalar or empty, the dimensions of both arrays must match.</para></remarks>
        public static  ILArray<byte>  max ( ILArray<byte> A,  ILArray<byte> B) {
            if (A.IsEmpty || B.IsEmpty ) {
                return  ILArray<byte> .empty(); 
            }
            if (A.IsScalar) {
                if (B.IsScalar) {
                    return new ILArray<byte> (new byte[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});
                } else {
                    #region scalar + array  
                    ILDimension inDim = B.Dimensions;
                    //  byte [] retArr = new  byte [inDim.NumberOfElements];
                    byte [] retArr = ILMemoryPool.Pool.New< byte > (inDim.NumberOfElements);
                    byte scalarValue = A.GetValue(0); 
                    byte tmpValue2; 
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (B.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = B.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!B.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (B.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( byte * pOutArr = retArr)
                                fixed ( byte * pInArr = B.m_data) {
                                        byte * tmpOut = pOutArr;
                                        byte * tmpIn = pInArr;
                                        byte * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [B.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( byte * pOutArr = retArr)
                                    fixed ( byte * pInArr = B.m_data) {
                                        byte * tmpOut = pOutArr;
                                        byte * tmpOutEnd = tmpOut + retArr.Length;
                                        // init lesezeiger: add alle Dimensionen mit 0 (auer leadDim)
                                        byte * tmpIn = pInArr + B.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( byte * pOutArr = retArr)
                            fixed ( byte * pInArr = B.m_data) {
                                byte * lastElement = pOutArr + retArr.Length;
                                byte * tmpOut = pOutArr;
                                byte * tmpIn = pInArr;
                                while (tmpOut < lastElement) //HC03
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                            }       
                        }
                        #endregion
                    }
                    return new  ILArray<byte> ( retArr, inDim.Clone() );
                    #endregion scalar + array
                }
            } else {
                if (B.IsScalar) {
                    #region array + scalar
                    ILDimension inDim = A.Dimensions;
                    //  byte [] retArr = new  byte [inDim.NumberOfElements];
                    byte [] retArr = ILMemoryPool.Pool.New< byte > (inDim.NumberOfElements);
                    byte scalarValue = B.GetValue(0); 
                    byte tmpValue1;
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (A.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!A.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (A.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( byte * pOutArr = retArr)
                                fixed ( byte * pInArr = A.m_data) {
                                        byte * tmpOut = pOutArr;
                                        byte * tmpIn = pInArr;
                                        byte * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) { //HC04
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [A.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( byte * pOutArr = retArr)
                                    fixed ( byte * pInArr = A.m_data) {
                                        byte * tmpOut = pOutArr;
                                        byte * tmpOutEnd = tmpOut + retArr.Length;
                                        // init readpointer: add all Dimensions with 0 (except leadDim)
                                        byte * tmpIn = pInArr + A.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {   //HC05
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( byte * pOutArr = retArr)
                            fixed ( byte * pInArr = A.m_data) {
                                byte * lastElement = pOutArr + retArr.Length;
                                byte * tmpOut = pOutArr;
                                byte * tmpIn = pInArr;
                                while (tmpOut < lastElement) { //HC06
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                                }
                            }
                        }
                        #endregion
                        //tmpValue1 = 0; 
                    }
                    return new  ILArray<byte> ( retArr, inDim.Clone() );
                    #endregion array + scalar
                } else {
                    #region array + array
                    ILDimension inDim = A.Dimensions;
                    if (!inDim.IsSameSize ( B.Dimensions ))
                        throw new ILDimensionMismatchException ();
                    byte [] retSystemArr;
                    byte tmpValue1; 
                    byte tmpValue2; 
                    // retSystemArr = new  byte [inDim.NumberOfElements];
                    retSystemArr = ILMemoryPool.Pool.New< byte > (inDim.NumberOfElements);
                    
                    int leadDim = 0, leadDimLen = inDim [0];
                    // this will most probably be not very fast, but .... :|
                    // walk along the longest dimension (for performance reasons)
                    for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                        if (leadDimLen < inDim [i]) {
                            leadDimLen = inDim [i];
                            leadDim = i;
                        }
                    }
                    unsafe {
                        fixed ( byte * pOutArr = retSystemArr)
                        fixed ( byte * inA1 = A.m_data) 
                        fixed ( byte * inA2 = B.m_data) {
                            byte * pInA1 = inA1; 
                            byte * pInA2 = inA2;
                            int c = 0; 
                            byte * poutarr = pOutArr;
                            byte * outEnd = poutarr + retSystemArr.Length;
                            if (A.IsReference) { 
                                if (!B.IsReference) {
                                    while (poutarr < outEnd) {  //HC07
                                        tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; 
                                    }
                                } else {
                                    // optimization for matrix 
                                    if (inDim.NumberOfDimensions < 3) {
                                        fixed (int * pA1idx0 = A.m_indexOffset[0])
                                        fixed (int * pA1idx1 = A.m_indexOffset[1])
                                        fixed (int * pA2idx0 = B.m_indexOffset[0])
                                        fixed (int * pA2idx1 = B.m_indexOffset[1]) {
                                            int r = 0, rLen = A.m_dimensions[0];
                                            int        cLen = A.m_dimensions[1]; 
                                            while (poutarr < outEnd) {   //HC08
                                                tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;
                                                if (++r == rLen) {
                                                    r = 0; 
                                                    c++; 
                                                }
                                            }
                                        }
                                    } else {
                                         while (poutarr < outEnd) {  //HC09
                                             tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; 
                                        }
                                   }
                                   // tmpValue1 = 0; tmpValue2 = 0; 
                                }
                            } else {
                                if (B.IsReference) {
                                    while (poutarr < outEnd) {  //HC10
                                        tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;
                                    }
                                } else {
                                    while (poutarr < outEnd) {  //HC11
                                        if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}
                                    }
                                }
                            }
                        }
                    }
                    return new  ILArray<byte> ( retSystemArr, inDim.ToIntArray () );
                    #endregion array + array
                }
            }
        }
        /// <summary> sum two arrays elementwise</summary>
        /// <param name="A">input 1</param>
        /// <param name="B">input 2</param>
        /// <returns> Array with elementwise sum of A and B </returns>
        /// <remarks><para>On empty input - empty array will be returned.</para>
        /// <para>A and / or B may be scalar. The scalar value will operate on all elements of the other arrays in this case.</para>
        /// <para>If neither of A or B is scalar or empty, the dimensions of both arrays must match.</para></remarks>
        public static  ILArray<double>  max ( ILArray<double> A,  ILArray<double> B) {
            if (A.IsEmpty || B.IsEmpty ) {
                return  ILArray<double> .empty(); 
            }
            if (A.IsScalar) {
                if (B.IsScalar) {
                    return new ILArray<double> (new double[1]{(A.GetValue(0) > B.GetValue(0))?A.GetValue(0):B.GetValue(0)});
                } else {
                    #region scalar + array  
                    ILDimension inDim = B.Dimensions;
                    //  double [] retArr = new  double [inDim.NumberOfElements];
                    double [] retArr = ILMemoryPool.Pool.New< double > (inDim.NumberOfElements);
                    double scalarValue = A.GetValue(0); 
                    double tmpValue2; 
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (B.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = B.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!B.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (B.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( double * pOutArr = retArr)
                                fixed ( double * pInArr = B.m_data) {
                                        double * tmpOut = pOutArr;
                                        double * tmpIn = pInArr;
                                        double * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = B.GetValue(0); *tmpOut = (scalarValue>tmpValue2)?scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [B.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( double * pOutArr = retArr)
                                    fixed ( double * pInArr = B.m_data) {
                                        double * tmpOut = pOutArr;
                                        double * tmpOutEnd = tmpOut + retArr.Length;
                                        // init lesezeiger: add alle Dimensionen mit 0 (auer leadDim)
                                        double * tmpIn = pInArr + B.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {
                                                tmpValue2 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue2)? scalarValue:tmpValue2;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( double * pOutArr = retArr)
                            fixed ( double * pInArr = B.m_data) {
                                double * lastElement = pOutArr + retArr.Length;
                                double * tmpOut = pOutArr;
                                double * tmpIn = pInArr;
                                while (tmpOut < lastElement) //HC03
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                            }       
                        }
                        #endregion
                    }
                    return new  ILArray<double> ( retArr, inDim.Clone() );
                    #endregion scalar + array
                }
            } else {
                if (B.IsScalar) {
                    #region array + scalar
                    ILDimension inDim = A.Dimensions;
                    //  double [] retArr = new  double [inDim.NumberOfElements];
                    double [] retArr = ILMemoryPool.Pool.New< double > (inDim.NumberOfElements);
                    double scalarValue = B.GetValue(0); 
                    double tmpValue1;
                    int leadDim = 0,leadDimLen = inDim [0];
                    if (A.IsReference) {
                        #region Reference storage
                        // walk along the longest dimension (for performance reasons)
                        ILIndexOffset idxOffset = A.m_indexOffset;
                        int incOut = inDim.SequentialIndexDistance ( leadDim );
                        System.Diagnostics.Debug.Assert(!A.IsVector,"Reference arrays of vector size should not exist!"); 
                        for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                            if (leadDimLen < inDim [i]) {
                                leadDimLen = inDim [i];
                                leadDim = i;
                                incOut = inDim.SequentialIndexDistance ( leadDim );
                            }
                        }
                        if (A.IsMatrix) {
                            #region Matrix
                            ////////////////////////////   MATRIX   ////////////////////
                            int secDim = ( leadDim + 1 ) % 2;
                            unsafe {
                                fixed (int* leadDimStart = idxOffset [leadDim],secDimStart = idxOffset [secDim])
                                fixed ( double * pOutArr = retArr)
                                fixed ( double * pInArr = A.m_data) {
                                        double * tmpOut = pOutArr;
                                        double * tmpIn = pInArr;
                                        double * tmpOutEnd = pOutArr + inDim.NumberOfElements - 1;
                                        int* secDimEnd = secDimStart + idxOffset [secDim].Length;
                                        int* secDimIdx = secDimStart;
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        while (secDimIdx < secDimEnd) {
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOut - tmpOutEnd);
                                            tmpIn = pInArr + *secDimIdx++;
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) { //HC04
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                        }
                                }
                            }
                            #endregion
                        } else {
                            #region arbitrary size
                            unsafe {
                                int [] curPosition = new int [A.Dimensions.NumberOfDimensions];
                                fixed (int* leadDimStart = idxOffset [leadDim]) {
                                    fixed ( double * pOutArr = retArr)
                                    fixed ( double * pInArr = A.m_data) {
                                        double * tmpOut = pOutArr;
                                        double * tmpOutEnd = tmpOut + retArr.Length;
                                        // init readpointer: add all Dimensions with 0 (except leadDim)
                                        double * tmpIn = pInArr + A.getBaseIndex (0,0);
                                        tmpIn -= idxOffset [leadDim, 0];
                                        int* leadDimIdx = leadDimStart;
                                        int* leadDimEnd = leadDimStart + leadDimLen;
                                        int dimLen = curPosition.Length;
                                        int d, curD;
                                        // start at first element
                                        while (tmpOut < tmpOutEnd) {
                                            leadDimIdx = leadDimStart;
                                            while (leadDimIdx < leadDimEnd) {   //HC05
                                                tmpValue1 = *(tmpIn + *leadDimIdx++); *tmpOut = (scalarValue > tmpValue1)? scalarValue:tmpValue1;
                                                tmpOut += incOut;
                                            }
                                            if (tmpOut > tmpOutEnd)
                                                tmpOut = pOutArr + ( tmpOutEnd - tmpOut );

                                            // increment higher dimensions 
                                            d = 1;
                                            while (d < dimLen) {
                                                curD = ( d + leadDim ) % dimLen;
                                                tmpIn -= idxOffset [curD, curPosition [curD]];
                                                curPosition [curD]++;
                                                if (curPosition [curD] < idxOffset [curD].Length) {
                                                    tmpIn += idxOffset [curD, curPosition [curD]];
                                                    break;
                                                }
                                                curPosition [curD] = 0;
                                                tmpIn += idxOffset [curD, 0];
                                                d++;
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        #endregion
                    } else {
                        // physical -> pointer arithmetic
                        #region physical storage
                        unsafe {
                            fixed ( double * pOutArr = retArr)
                            fixed ( double * pInArr = A.m_data) {
                                double * lastElement = pOutArr + retArr.Length;
                                double * tmpOut = pOutArr;
                                double * tmpIn = pInArr;
                                while (tmpOut < lastElement) { //HC06
                                    { *tmpOut++ = (scalarValue > *tmpIn)? scalarValue: *tmpIn; tmpIn++; }
                                }
                            }
                        }
                        #endregion
                        //tmpValue1 = 0; 
                    }
                    return new  ILArray<double> ( retArr, inDim.Clone() );
                    #endregion array + scalar
                } else {
                    #region array + array
                    ILDimension inDim = A.Dimensions;
                    if (!inDim.IsSameSize ( B.Dimensions ))
                        throw new ILDimensionMismatchException ();
                    double [] retSystemArr;
                    double tmpValue1; 
                    double tmpValue2; 
                    // retSystemArr = new  double [inDim.NumberOfElements];
                    retSystemArr = ILMemoryPool.Pool.New< double > (inDim.NumberOfElements);
                    
                    int leadDim = 0, leadDimLen = inDim [0];
                    // this will most probably be not very fast, but .... :|
                    // walk along the longest dimension (for performance reasons)
                    for (int i = 1; i < inDim.NumberOfDimensions; i++) {
                        if (leadDimLen < inDim [i]) {
                            leadDimLen = inDim [i];
                            leadDim = i;
                        }
                    }
                    unsafe {
                        fixed ( double * pOutArr = retSystemArr)
                        fixed ( double * inA1 = A.m_data) 
                        fixed ( double * inA2 = B.m_data) {
                            double * pInA1 = inA1; 
                            double * pInA2 = inA2;
                            int c = 0; 
                            double * poutarr = pOutArr;
                            double * outEnd = poutarr + retSystemArr.Length;
                            if (A.IsReference) { 
                                if (!B.IsReference) {
                                    while (poutarr < outEnd) {  //HC07
                                        tmpValue1 = *(pInA1 + A.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > *pInA2)? tmpValue1:*pInA2; pInA2++; 
                                    }
                                } else {
                                    // optimization for matrix 
                                    if (inDim.NumberOfDimensions < 3) {
                                        fixed (int * pA1idx0 = A.m_indexOffset[0])
                                        fixed (int * pA1idx1 = A.m_indexOffset[1])
                                        fixed (int * pA2idx0 = B.m_indexOffset[0])
                                        fixed (int * pA2idx1 = B.m_indexOffset[1]) {
                                            int r = 0, rLen = A.m_dimensions[0];
                                            int        cLen = A.m_dimensions[1]; 
                                            while (poutarr < outEnd) {   //HC08
                                                tmpValue1 = *(pInA1 + *(pA1idx0 + r) + *(pA1idx1 + c)); tmpValue2 = *(pInA2+ *(pA2idx0 + r) + *(pA2idx1 + c)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2;
                                                if (++r == rLen) {
                                                    r = 0; 
                                                    c++; 
                                                }
                                            }
                                        }
                                    } else {
                                         while (poutarr < outEnd) {  //HC09
                                             tmpValue1 = *(pInA1 + A.getBaseIndex(c)); tmpValue2 = *(pInA2+B.getBaseIndex(c++)); *poutarr++ = (tmpValue1 > tmpValue2)?tmpValue1:tmpValue2; 
                                        }
                                   }
                                   // tmpValue1 = 0; tmpValue2 = 0; 
                                }
                            } else {
                                if (B.IsReference) {
                                    while (poutarr < outEnd) {  //HC10
                                        tmpValue2 = *(pInA2 + B.getBaseIndex(c++));*poutarr++ = (*pInA1 > tmpValue2)?*pInA1:tmpValue2; pInA1++;
                                    }
                                } else {
                                    while (poutarr < outEnd) {  //HC11
                                        if (*pInA1> *pInA2) { *poutarr++ = *pInA1++; pInA2++;} else {*poutarr++ = *pInA2++; pInA1++;}
                                    }
                                }
                            }
                        }
                    }
                    return new  ILArray<double> ( retSystemArr, inDim.ToIntArray () );
                    #endregion array + array
                }
            }
        }

#endregion HYCALPER AUTO GENERATED CODE
    }
}
namespace ILNumerics.Untyped {
    /// <summary>
    /// Max - experimental implementation
    /// </summary>
    public sealed partial class ILUntype {
        /// <summary>
        /// maximum
        /// </summary>
        /// <param name="inParameter"> system.Array of ILBaseArray's. The number of elements 
        /// in inParams specifies the mode of max: 
        /// <list type="bullet">
        /// <item> 1:  Single array element. the function will give the maximum of elements 
        /// along the first non singleton dimension. If the length of outParamter is 2, the
        /// indices of the elements with maximum values found is given back as second return 
        /// value. [Matlab: [i,y] = max(A)]</item>
        /// <item> 2: first element: input Array. Second element: second input array. Either 
        /// one may be a scalar. the function gives back the maximum value of corresponding 
        /// elements of both input arrays as single otuput parameter. [Matlab: y = max(A,B)]</item>
        /// <item> 3: first element: input array. second element will be ignored, third element 
        /// will specify the dimension to operate along. If the length of outParameter specified 
        /// is 2, the indices of maximum elements into the operation dimension will be given back 
        /// also. [MAtlab: [y,i] = max(A,[],d)]</item>
        /// </list>  
        /// </param>
        /// <param name="outParameter">[output] return maximum value as requested. If the number of outParameter
        /// equals 2 on entry, the indices of corresponding maximum valued elements are returned also.</param>
        /// <remarks>Following types are supported: /*!HC:ENUM:TinCls:*/ <![CDATA[ ILArray<complex>, ILArray<float>, ILArray<fcomplex>, ILArray<byte>, ILArray<char>, ILArray<Int16>, ILArray<Int32>, ILArray<Int64>, ILArray<UInt16>, ILArray<UInt32>, ILArray<UInt64>]]> /*!HC:/ENUM*/.
        /// The dimension specifier may be any positive (including 0) scalar value inside ILArray 
        /// of type double or int or float. 
        /// The length of outParameter specifies the number of values returned. 
        /// The initial content of outParameter argument will be destroyed on return. </remarks>
        public static void max(ref ILBaseArray[] outParameter, params ILBaseArray[] inParameter) {
            try {
                switch (inParameter.Length) {
                    case 0:
                        throw new ILArgumentTypeException("max: to less arguments supplied!");
                    case 1:
                        switch (outParameter.Length) {
                            case 0:
                            case 1:
                                // y = max(A)
                                if (false) {
                                }
                                #region HYCALPER LOOPSTART
                                else if (inParameter[0] is /*!HC:TinCls*/ ILArray<double> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max((/*!HC:TinCls*/ ILArray<double> )inParameter[0]);
                                    return;
                                }
                                #endregion HYCALPER LOOPEND
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
                                else if (inParameter[0] is  ILArray<UInt64> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt64> )inParameter[0]);
                                    return;
                                }
                                else if (inParameter[0] is  ILArray<UInt32> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt32> )inParameter[0]);
                                    return;
                                }
                                else if (inParameter[0] is  ILArray<UInt16> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt16> )inParameter[0]);
                                    return;
                                }
                                else if (inParameter[0] is  ILArray<Int64> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int64> )inParameter[0]);
                                    return;
                                }
                                else if (inParameter[0] is  ILArray<Int32> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int32> )inParameter[0]);
                                    return;
                                }
                                else if (inParameter[0] is  ILArray<Int16> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int16> )inParameter[0]);
                                    return;
                                }
                                else if (inParameter[0] is  ILArray<char> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<char> )inParameter[0]);
                                    return;
                                }
                                else if (inParameter[0] is  ILArray<byte> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<byte> )inParameter[0]);
                                    return;
                                }
                                else if (inParameter[0] is  ILArray<fcomplex> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<fcomplex> )inParameter[0]);
                                    return;
                                }
                                else if (inParameter[0] is  ILArray<float> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<float> )inParameter[0]);
                                    return;
                                }
                                else if (inParameter[0] is  ILArray<complex> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<complex> )inParameter[0]);
                                    return;
                                }

#endregion HYCALPER AUTO GENERATED CODE
                                else {
                                    throw new ILArgumentTypeException("max is not supported for arguments of type " + inParameter[0].GetType().Name); 
                                }
                            case 2:
                                // [y,i] = max(A)
                                if (false) {
                                #region HYCALPER LOOPSTART
                                } else if (inParameter[0] is /*!HC:TinCls*/ ILArray<double> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    outParameter[0] = BuiltInFunctions.ILMath.max((/*!HC:TinCls*/ ILArray<double> )inParameter[0], ref I, -1);
                                    outParameter[1] = I;
                                #endregion HYCALPER LOOPEND
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
                                } else if (inParameter[0] is  ILArray<UInt64> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt64> )inParameter[0], ref I, -1);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<UInt32> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt32> )inParameter[0], ref I, -1);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<UInt16> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt16> )inParameter[0], ref I, -1);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<Int64> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int64> )inParameter[0], ref I, -1);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<Int32> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int32> )inParameter[0], ref I, -1);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<Int16> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int16> )inParameter[0], ref I, -1);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<char> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<char> )inParameter[0], ref I, -1);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<byte> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<byte> )inParameter[0], ref I, -1);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<fcomplex> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<fcomplex> )inParameter[0], ref I, -1);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<float> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<float> )inParameter[0], ref I, -1);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<complex> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<complex> )inParameter[0], ref I, -1);
                                    outParameter[1] = I;

#endregion HYCALPER AUTO GENERATED CODE
                                } else {
                                    throw new ILArgumentTypeException("max(A) is not supported for A of type " + inParameter[0].GetType().Name); 
                                }
                                break;
                            default:
                                throw new ILArgumentNumberException("max: too many output parameter requested for max(A)!");
                        }
                        break;
                    case 2:
                        switch (outParameter.Length) {
                            case 0:
                            case 1:
                                // y = max(A,B)
                                if (false) {
                                #region HYCALPER LOOPSTART
                                } else if (inParameter[0] is /*!HC:TinCls*/ ILArray<double> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max((/*!HC:TinCls*/ ILArray<double> )inParameter[0], (/*!HC:TinCls*/ ILArray<double> )inParameter[1]);
                                #endregion HYCALPER LOOPEND
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
                                } else if (inParameter[0] is  ILArray<UInt64> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt64> )inParameter[0], ( ILArray<UInt64> )inParameter[1]);
                                } else if (inParameter[0] is  ILArray<UInt32> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt32> )inParameter[0], ( ILArray<UInt32> )inParameter[1]);
                                } else if (inParameter[0] is  ILArray<UInt16> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt16> )inParameter[0], ( ILArray<UInt16> )inParameter[1]);
                                } else if (inParameter[0] is  ILArray<Int64> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int64> )inParameter[0], ( ILArray<Int64> )inParameter[1]);
                                } else if (inParameter[0] is  ILArray<Int32> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int32> )inParameter[0], ( ILArray<Int32> )inParameter[1]);
                                } else if (inParameter[0] is  ILArray<Int16> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int16> )inParameter[0], ( ILArray<Int16> )inParameter[1]);
                                } else if (inParameter[0] is  ILArray<char> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<char> )inParameter[0], ( ILArray<char> )inParameter[1]);
                                } else if (inParameter[0] is  ILArray<byte> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<byte> )inParameter[0], ( ILArray<byte> )inParameter[1]);
                                } else if (inParameter[0] is  ILArray<fcomplex> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<fcomplex> )inParameter[0], ( ILArray<fcomplex> )inParameter[1]);
                                } else if (inParameter[0] is  ILArray<float> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<float> )inParameter[0], ( ILArray<float> )inParameter[1]);
                                } else if (inParameter[0] is  ILArray<complex> ) {
                                    outParameter = new ILBaseArray[1];
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<complex> )inParameter[0], ( ILArray<complex> )inParameter[1]);

#endregion HYCALPER AUTO GENERATED CODE
                                } else {
                                    throw new ILArgumentTypeException("max is not supported for input array of type " + inParameter[0].GetType().Name);
                                }
                                break;
                            default:
                                throw new ILArgumentNumberException("max: too many output parameter requested for max(A,B)!");
                        }
                        break;
                    case 3:
                        switch (outParameter.Length) {
                            case 0:
                            case 1:
                                // y = max(A,[],dim)
                                if (false) {
                                #region HYCALPER LOOPSTART
                                } else if (inParameter[0] is /*!HC:TinCls*/ ILArray<double> ) {
                                    ILArray<double> I = null;
                                    outParameter = new ILBaseArray[1];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double> )inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max((/*!HC:TinCls*/ ILArray<double> )inParameter[0], ref I, dimension);
                                #endregion HYCALPER LOOPEND
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
                                } else if (inParameter[0] is  ILArray<UInt64> ) {
                                    ILArray<double> I = null;
                                    outParameter = new ILBaseArray[1];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double> )inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt64> )inParameter[0], ref I, dimension);
                                } else if (inParameter[0] is  ILArray<UInt32> ) {
                                    ILArray<double> I = null;
                                    outParameter = new ILBaseArray[1];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double> )inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt32> )inParameter[0], ref I, dimension);
                                } else if (inParameter[0] is  ILArray<UInt16> ) {
                                    ILArray<double> I = null;
                                    outParameter = new ILBaseArray[1];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double> )inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt16> )inParameter[0], ref I, dimension);
                                } else if (inParameter[0] is  ILArray<Int64> ) {
                                    ILArray<double> I = null;
                                    outParameter = new ILBaseArray[1];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double> )inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int64> )inParameter[0], ref I, dimension);
                                } else if (inParameter[0] is  ILArray<Int32> ) {
                                    ILArray<double> I = null;
                                    outParameter = new ILBaseArray[1];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double> )inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int32> )inParameter[0], ref I, dimension);
                                } else if (inParameter[0] is  ILArray<Int16> ) {
                                    ILArray<double> I = null;
                                    outParameter = new ILBaseArray[1];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double> )inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int16> )inParameter[0], ref I, dimension);
                                } else if (inParameter[0] is  ILArray<char> ) {
                                    ILArray<double> I = null;
                                    outParameter = new ILBaseArray[1];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double> )inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<char> )inParameter[0], ref I, dimension);
                                } else if (inParameter[0] is  ILArray<byte> ) {
                                    ILArray<double> I = null;
                                    outParameter = new ILBaseArray[1];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double> )inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<byte> )inParameter[0], ref I, dimension);
                                } else if (inParameter[0] is  ILArray<fcomplex> ) {
                                    ILArray<double> I = null;
                                    outParameter = new ILBaseArray[1];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double> )inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<fcomplex> )inParameter[0], ref I, dimension);
                                } else if (inParameter[0] is  ILArray<float> ) {
                                    ILArray<double> I = null;
                                    outParameter = new ILBaseArray[1];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double> )inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<float> )inParameter[0], ref I, dimension);
                                } else if (inParameter[0] is  ILArray<complex> ) {
                                    ILArray<double> I = null;
                                    outParameter = new ILBaseArray[1];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double> )inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<complex> )inParameter[0], ref I, dimension);

#endregion HYCALPER AUTO GENERATED CODE
                                } else {
                                    throw new ILArgumentTypeException("max is not supported for input array of type " + inParameter[0].GetType().Name);
                                }
                                break;
                            case 2:
                                // [y,i] = max(A,[],dim)
                                if (false) {
                                #region HYCALPER LOOPSTART
                                } else if (inParameter[0] is /*!HC:TinCls*/ ILArray<double> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double>)inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max((/*!HC:TinCls*/ ILArray<double> )inParameter[0], ref I, dimension);
                                    outParameter[1] = I;
                                #endregion HYCALPER LOOPEND
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
                                } else if (inParameter[0] is  ILArray<UInt64> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double>)inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt64> )inParameter[0], ref I, dimension);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<UInt32> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double>)inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt32> )inParameter[0], ref I, dimension);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<UInt16> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double>)inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<UInt16> )inParameter[0], ref I, dimension);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<Int64> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double>)inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int64> )inParameter[0], ref I, dimension);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<Int32> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double>)inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int32> )inParameter[0], ref I, dimension);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<Int16> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double>)inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<Int16> )inParameter[0], ref I, dimension);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<char> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double>)inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<char> )inParameter[0], ref I, dimension);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<byte> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double>)inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<byte> )inParameter[0], ref I, dimension);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<fcomplex> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double>)inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<fcomplex> )inParameter[0], ref I, dimension);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<float> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double>)inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<float> )inParameter[0], ref I, dimension);
                                    outParameter[1] = I;
                                } else if (inParameter[0] is  ILArray<complex> ) {
                                    ILArray<double> I = ILArray<double>.empty();
                                    outParameter = new ILBaseArray[2];
                                    if (!inParameter[2].IsScalar)
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    int dimension = 0;
                                    try {
                                        dimension = (int)(((ILArray<double>)inParameter[2])[0, 0]);
                                    } catch (Exception) {
                                        throw new ILArgumentSizeException("max: dimension argument must be positive, scalar double array!");
                                    }
                                    outParameter[0] = BuiltInFunctions.ILMath.max(( ILArray<complex> )inParameter[0], ref I, dimension);
                                    outParameter[1] = I;

#endregion HYCALPER AUTO GENERATED CODE
                                } else {
                                    throw new ILArgumentTypeException("max is not supported for input array of type " + inParameter[0].GetType().Name);
                                }
                                break;
                            default:
                                throw new ILArgumentNumberException("max: wrong number of output parameter requested for max(A,B) !");
                        }
                        break;
                    default:
                        throw new ILArgumentNumberException("max: too many input arguments! ");
                }
            } catch (Exception e) {
                throw new ILException("max: could not complete operation: " + e.Message); 
            }

        }
    }
}

