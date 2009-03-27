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
using ILNumerics;
using ILNumerics.Exceptions;
using ILNumerics.Storage;
using ILNumerics.Misc;
/*!HC:TYPELIST:
<hycalper>
    <type>
        <source locate="after">
            inCls1
        </source>
        <destination><![CDATA[ILArray<double>]]></destination>
        <destination><![CDATA[ILArray<complex>]]></destination>
        <destination><![CDATA[ILArray<double>]]></destination>
    </type>
    <type>
        <source locate="after">
            inArr1
        </source>
        <destination>double</destination>
        <destination>complex</destination>
        <destination>double</destination>
    </type>
    <type>
        <source locate="after">
            outCls
        </source>
        <destination><![CDATA[ILArray<double>]]></destination>
        <destination><![CDATA[ILArray<complex>]]></destination>
        <destination><![CDATA[ILArray<complex>]]></destination>
    </type>
    <type>
        <source locate="after">
            outArr
        </source>
        <destination>double</destination>
        <destination>complex</destination>
        <destination>complex</destination>
    </type>
    <type>
        <source locate="after">
            HCoperation
        </source>
        <destination>Math.Sqrt</destination>
        <destination>complex.Sqrt</destination>
        <destination>complex.Sqrt</destination>
    </type>
    <type>
        <source locate="after">
            HCfuncname
        </source>
        <destination>sqrt</destination>
        <destination>sqrt</destination>
        <destination>sqrtc</destination>
    <type>
        <source locate="comment">
            summary
        </source>
        <destination>Square root of array elements - real output</destination>
        <destination>Square root of array elements</destination>
        <destination>Square root of array elements - complex output</destination>
    </type>
    <type>
        <source locate="comment">
            <![CDATA[param name="inArray"]]>        
        </source>
        <destination>input array - only positive values are allowed.</destination>
        <destination>input array</destination>
        <destination>input array - positive and negative values allowed</destination>
    </type>
    <type>
        <source locate="comment">
            returns
        </source>
        <destination>Cosine of array elements - real output</destination>
        <destination>Cosine of array elements</destination>
        <destination>Cosine of array elements - complex output</destination>
    </type>
    </type>
 </hycalper>
 */

namespace ILNumerics.BuiltInFunctions {
    public partial class ILMath {
        #region HYCALPER LOOPSTART UNARY_OPERATOR_TEMPLATE@Functions\builtin\sin.cs

        #endregion HYCALPER LOOPEND UNARY_OPERATOR_TEMPLATE@Functions\builtin\sin.cs
#region HYCALPER AUTO GENERATED CODE
// DO NOT EDIT INSIDE THIS REGION !! CHANGES WILL BE LOST !! 
        /// <summary>
        /// Sinus of array elements 
        /// </summary>
        /// <param name="A">input array</param>
        /// <returns>Sinus of elements from input array</returns>
        /// <remarks><para>If the input array is empty, an empty array will be returned.</para>
        /// <para>The array returned will be a dense array.</para></remarks>
        public static  ILArray<complex>  sqrtc ( ILArray<double> A) {
            if (A.IsEmpty)
                return  ILArray<complex> .empty(A.Dimensions); 
            ILDimension inDim = A.Dimensions;
            complex [] retDblArr;
            // build ILDimension    
            int newLength = inDim.NumberOfElements;
            //retDblArr = new  complex [newLength];
            retDblArr = ILMemoryPool.Pool.New< complex > (newLength); 
            int leadDimLen = inDim [0];

            // physical -> pointer arithmetic
            unsafe
            {
                fixed ( complex * pOutArr = retDblArr)
                fixed ( double * pInArr = A.m_data) {
                    complex * lastElement = pOutArr + retDblArr.Length;
                    complex * tmpOut = pOutArr;
                    double * tmpIn = pInArr;
                    while (tmpOut < lastElement) { // HC02
                       
                        *tmpOut++ =  complex.Sqrt ( *tmpIn++ )  ;
                    }
                }
            }

            return new  ILArray<complex> ( retDblArr, inDim );
        }
        /// <summary>
        /// Sinus of array elements 
        /// </summary>
        /// <param name="A">input array</param>
        /// <returns>Sinus of elements from input array</returns>
        /// <remarks><para>If the input array is empty, an empty array will be returned.</para>
        /// <para>The array returned will be a dense array.</para></remarks>
        public static  ILArray<complex>  sqrt ( ILArray<complex> A) {
            if (A.IsEmpty)
                return  ILArray<complex> .empty(A.Dimensions); 
            ILDimension inDim = A.Dimensions;
            complex [] retDblArr;
            // build ILDimension    
            int newLength = inDim.NumberOfElements;
            //retDblArr = new  complex [newLength];
            retDblArr = ILMemoryPool.Pool.New< complex > (newLength); 
            int leadDimLen = inDim [0];

            // physical -> pointer arithmetic
            unsafe
            {
                fixed ( complex * pOutArr = retDblArr)
                fixed ( complex * pInArr = A.m_data) {
                    complex * lastElement = pOutArr + retDblArr.Length;
                    complex * tmpOut = pOutArr;
                    complex * tmpIn = pInArr;
                    while (tmpOut < lastElement) { // HC02
                       
                        *tmpOut++ =  complex.Sqrt ( *tmpIn++ )  ;
                    }
                }
            }

            return new  ILArray<complex> ( retDblArr, inDim );
        }
        /// <summary>
        /// Sinus of array elements 
        /// </summary>
        /// <param name="A">input array</param>
        /// <returns>Sinus of elements from input array</returns>
        /// <remarks><para>If the input array is empty, an empty array will be returned.</para>
        /// <para>The array returned will be a dense array.</para></remarks>
        public static  ILArray<double>  sqrt ( ILArray<double> A) {
            if (A.IsEmpty)
                return  ILArray<double> .empty(A.Dimensions); 
            ILDimension inDim = A.Dimensions;
            double [] retDblArr;
            // build ILDimension    
            int newLength = inDim.NumberOfElements;
            //retDblArr = new  double [newLength];
            retDblArr = ILMemoryPool.Pool.New< double > (newLength); 
            int leadDimLen = inDim [0];

            // physical -> pointer arithmetic
            unsafe
            {
                fixed ( double * pOutArr = retDblArr)
                fixed ( double * pInArr = A.m_data) {
                    double * lastElement = pOutArr + retDblArr.Length;
                    double * tmpOut = pOutArr;
                    double * tmpIn = pInArr;
                    while (tmpOut < lastElement) { // HC02
                       
                        *tmpOut++ =  Math.Sqrt ( *tmpIn++ )  ;
                    }
                }
            }

            return new  ILArray<double> ( retDblArr, inDim );
        }

#endregion HYCALPER AUTO GENERATED CODE
    }
}
