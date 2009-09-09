﻿#region ORIGINS, COPYRIGHTS, AND LICENSE
/*

This C# version of LAPACK is derivied from http://www.netlib.org/clapack/,
and the original copyright and license is as follows:

Copyright (c) 1992-2008 The University of Tennessee.  All rights reserved.
$COPYRIGHT$ Additional copyrights may follow $HEADER$

Redistribution and use in source and binary forms, with or without
modification, are permitted provided that the following conditions are
met:

- Redistributions of source code must retain the above copyright
  notice, this list of conditions and the following disclaimer. 
  
- Redistributions in binary form must reproduce the above copyright
  notice, this list of conditions and the following disclaimer listed
  in this license in the documentation and/or other materials
  provided with the distribution.
  
- Neither the name of the copyright holders nor the names of its
  contributors may be used to endorse or promote products derived from
  this software without specific prior written permission.
  
THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
"AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT  
LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT 
OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL,
SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT  
(INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE
OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */
#endregion

public partial class ManagedLapack
{
    public static unsafe int dlarf(char side, int m, int n, double *v, int incv,
        double tau, double *c__, int ldc, double *work)
    {
        /* Table of constant values */
        const double c_b4 = 1.0;
        const double c_b5 = 0.0;
        const int c__1 = 1;

        /* System generated locals */
        int c_dim1, c_offset;
        double d__1;

        /* Parameter adjustments */
        --v;
        c_dim1 = ldc;
        c_offset = 1 + c_dim1;
        c__ -= c_offset;
        --work;

        /* Function Body */
        if (lsame(side, 'L')) {

    /*        Form  H * C */

	    if (tau != 0.0) {

    /*           w := C' * v */

	        dgemv('T', m, n, c_b4, &c__[c_offset], ldc, &v[1], incv, 
		         c_b5, &work[1], c__1);

    /*           C := C - v * w' */

	        d__1 = -(tau);
	        dger(m, n, d__1, &v[1], incv, &work[1], c__1, &c__[c_offset], 
		        ldc);
	    }
        } else {

    /*        Form  C * H */

	    if (tau != 0.0) {

    /*           w := C * v */

	        dgemv('N', m, n, c_b4, &c__[c_offset], ldc, &v[1], 
		        incv, c_b5, &work[1], c__1);

    /*           C := C - w * v' */

	        d__1 = -(tau);
	        dger(m, n, d__1, &work[1], c__1, &v[1], incv, &c__[c_offset], 
		        ldc);
	    }
        }
        return 0;
    } 
}

