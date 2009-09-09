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
    public static unsafe int dlaqr5(bool wantt, bool wantz, int kacc22, int n, int ktop, int kbot,
        int nshfts, double* sr, double* si, double *h__, int ldh, int iloz, int ihiz, double *z__,
        int ldz, double *v, int ldv, double *u, int ldu, int nv, double *wv, int ldwv, int nh,
        double *wh, int ldwh)
    {
        /* Table of constant values */
        const double c_b7 = 0.0;
        const double c_b8 = 1.0;
        const int c__3 = 3;
        const int c__1 = 1;
        const int c__2 = 2;

        /* System generated locals */
        int h_dim1, h_offset, u_dim1, u_offset, v_dim1, v_offset, wh_dim1, 
	        wh_offset, wv_dim1, wv_offset, z_dim1, z_offset, i__1, i__2, i__3,
	         i__4, i__5, i__6, i__7;
        double d__1, d__2, d__3, d__4;

        /* Local variables */
        int i__, j, k, m, i2, j2, i4, j4, k1;
        double h11, h12, h21, h22;
        int m22, ns, nu;
        double* vt = stackalloc double[3];
        double scl;
        int kdu, kms;
        double ulp;
        int knz, kzs;
        double tst1, tst2, beta;
        bool blk22, bmp22;
        int mend, jcol, jlen, jbot, mbot;
        double swap;
        int jtop, jrow, mtop;
        double alpha;
        bool accum;
        int ndcol, incol, krcol, nbmps;
        double safmin;
        double safmax, refsum;
        int mstart;
        double smlnum;

        /* Parameter adjustments */
        --sr;
        --si;
        h_dim1 = ldh;
        h_offset = 1 + h_dim1;
        h__ -= h_offset;
        z_dim1 = ldz;
        z_offset = 1 + z_dim1;
        z__ -= z_offset;
        v_dim1 = ldv;
        v_offset = 1 + v_dim1;
        v -= v_offset;
        u_dim1 = ldu;
        u_offset = 1 + u_dim1;
        u -= u_offset;
        wv_dim1 = ldwv;
        wv_offset = 1 + wv_dim1;
        wv -= wv_offset;
        wh_dim1 = ldwh;
        wh_offset = 1 + wh_dim1;
        wh -= wh_offset;

        /* Function Body */
        if (nshfts < 2) {
	    return 0;
        }

    /*     ==== If the active block is empty or 1-by-1, then there */
    /*     .    is nothing to do. ==== */

        if (ktop >= kbot) {
	    return 0;
        }

    /*     ==== Shuffle shifts into pairs of real shifts and pairs */
    /*     .    of complex conjugate shifts assuming complex */
    /*     .    conjugate shifts are already adjacent to one */
    /*     .    another. ==== */

        i__1 = nshfts - 2;
        for (i__ = 1; i__ <= i__1; i__ += 2) {
	    if (si[i__] != -si[i__ + 1]) {

	        swap = sr[i__];
	        sr[i__] = sr[i__ + 1];
	        sr[i__ + 1] = sr[i__ + 2];
	        sr[i__ + 2] = swap;

	        swap = si[i__];
	        si[i__] = si[i__ + 1];
	        si[i__ + 1] = si[i__ + 2];
	        si[i__ + 2] = swap;
	    }
    /* L10: */
        }

    /*     ==== NSHFTS is supposed to be even, but if is odd, */
    /*     .    then simply reduce it by one.  The shuffle above */
    /*     .    ensures that the dropped shift is real and that */
    /*     .    the remaining shifts are paired. ==== */

        ns = nshfts - nshfts % 2;

    /*     ==== Machine constants for deflation ==== */

        safmin = dlamch('S');
        safmax = 1.0 / safmin;
        dlabad(ref safmin, ref safmax);
        ulp = dlamch('P');
        smlnum = safmin * ((double) (n) / ulp);

    /*     ==== Use accumulated reflections to update far-from-diagonal */
    /*     .    entries ? ==== */

        accum = kacc22 == 1 || kacc22 == 2;

    /*     ==== If so, exploit the 2-by-2 block structure? ==== */

        blk22 = ns > 2 && kacc22 == 2;

    /*     ==== clear trash ==== */

        if (ktop + 2 <= kbot) {
	    h__[ktop + 2 + ktop * h_dim1] = 0.0;
        }

    /*     ==== NBMPS = number of 2-shift bulges in the chain ==== */

        nbmps = ns / 2;

    /*     ==== KDU = width of slab ==== */

        kdu = nbmps * 6 - 3;

    /*     ==== Create and chase chains of NBMPS bulges ==== */

        i__1 = kbot - 2;
        i__2 = nbmps * 3 - 2;
        for (incol = (1 - nbmps) * 3 + ktop - 1; i__2 < 0 ? incol >= i__1 : 
	        incol <= i__1; incol += i__2) {
	    ndcol = incol + kdu;
	    if (accum) {
	        dlaset('A', kdu, kdu, c_b7, c_b8, &u[u_offset], ldu);
	    }

    /*        ==== Near-the-diagonal bulge chase.  The following loop */
    /*        .    performs the near-the-diagonal part of a small bulge */
    /*        .    multi-shift QR sweep.  Each 6*NBMPS-2 column diagonal */
    /*        .    chunk extends from column INCOL to column NDCOL */
    /*        .    (including both column INCOL and column NDCOL). The */
    /*        .    following loop chases a 3*NBMPS column long chain of */
    /*        .    NBMPS bulges 3*NBMPS-2 columns to the right.  (INCOL */
    /*        .    may be less than KTOP and and NDCOL may be greater than */
    /*        .    KBOT indicating phantom columns from which to chase */
    /*        .    bulges before they are actually introduced or to which */
    /*        .    to chase bulges beyond column KBOT.)  ==== */

    /* Computing MIN */
	    i__4 = incol + nbmps * 3 - 3; i__5 = kbot - 2;
	    i__3 = min(i__4,i__5);
	    for (krcol = incol; krcol <= i__3; ++krcol) {

    /*           ==== Bulges number MTOP to MBOT are active double implicit */
    /*           .    shift bulges.  There may or may not also be small */
    /*           .    2-by-2 bulge, if there is room.  The inactive bulges */
    /*           .    (if any) must wait until the active bulges have moved */
    /*           .    down the diagonal to make room.  The phantom matrix */
    /*           .    paradigm described above helps keep track.  ==== */

    /* Computing MAX */
	        i__4 = 1; i__5 = (ktop - 1 - krcol + 2) / 3 + 1;
	        mtop = max(i__4,i__5);
    /* Computing MIN */
	        i__4 = nbmps; i__5 = (kbot - krcol) / 3;
	        mbot = min(i__4,i__5);
	        m22 = mbot + 1;
	        bmp22 = mbot < nbmps && krcol + (m22 - 1) * 3 == kbot - 2;

    /*           ==== Generate reflections to chase the chain right */
    /*           .    one column.  (The minimum value of K is KTOP-1.0) ==== */

	        i__4 = mbot;
	        for (m = mtop; m <= i__4; ++m) {
		    k = krcol + (m - 1) * 3;
		    if (k == ktop - 1) {
		        dlaqr1(c__3, &h__[ktop + ktop * h_dim1], ldh, sr[(m 
			        << 1) - 1], si[(m << 1) - 1], sr[m * 2], si[m *
			         2], &v[m * v_dim1 + 1]);
		        alpha = v[m * v_dim1 + 1];
		        dlarfg(c__3, ref alpha, &v[m * v_dim1 + 2], c__1, ref v[m * 
			        v_dim1 + 1]);
		    } else {
		        beta = h__[k + 1 + k * h_dim1];
		        v[m * v_dim1 + 2] = h__[k + 2 + k * h_dim1];
		        v[m * v_dim1 + 3] = h__[k + 3 + k * h_dim1];
		        dlarfg(c__3, ref beta, &v[m * v_dim1 + 2], c__1, ref v[m * 
			        v_dim1 + 1]);

    /*                 ==== A Bulge may collapse because of vigilant */
    /*                 .    deflation or destructive underflow.  (The */
    /*                 .    initial bulge is always collapsed.) Use */
    /*                 .    the two-small-subdiagonals trick to try */
    /*                 .    to get it started again. If V(2,M).NE.0 and */
    /*                 .    V(3,M) = H(K+3,K+1) = H(K+3,K+2) = 0, then */
    /*                 .    this bulge is collapsing into a zero */
    /*                 .    subdiagonal.  It will be restarted next */
    /*                 .    trip through the loop.) */

		        if (v[m * v_dim1 + 1] != 0.0 && (v[m * v_dim1 + 3] != 0.0 ||
			         h__[k + 3 + (k + 1) * h_dim1] == 0.0 && h__[k + 3 
			        + (k + 2) * h_dim1] == 0.0)) {

    /*                    ==== Typical case: not collapsed (yet). ==== */

			    h__[k + 1 + k * h_dim1] = beta;
			    h__[k + 2 + k * h_dim1] = 0.0;
			    h__[k + 3 + k * h_dim1] = 0.0;
		        } else {

    /*                    ==== Atypical case: collapsed.  Attempt to */
    /*                    .    reintroduce ignoring H(K+1,K).  If the */
    /*                    .    fill resulting from the new reflector */
    /*                    .    is too large, then abandon it. */
    /*                    .    Otherwise, use the new one. ==== */

			    dlaqr1(c__3, &h__[k + 1 + (k + 1) * h_dim1], ldh, 
				    sr[(m << 1) - 1], si[(m << 1) - 1], sr[m * 
				    2], si[m * 2], vt);
			    scl = abs(vt[0]) + abs(vt[1]) + abs(vt[2]);
			    if (scl != 0.0) {
			        vt[0] /= scl;
			        vt[1] /= scl;
			        vt[2] /= scl;
			    }

    /*                    ==== The following is the traditional and */
    /*                    .    conservative two-small-subdiagonals */
    /*                    .    test.  ==== */
    /*                    . */
			    if ((abs(h__[k + 1 + k * h_dim1])) * (
				    abs(vt[1]) + abs(vt[2])) > ulp * abs(vt[0]) * 
				    ((abs(h__[k + k * h_dim1])) + (
				    abs(h__[k + 1 + (k + 1) * h_dim1])) +
                    (abs(h__[k + 2 + (k + 2) * h_dim1])))) {

    /*                       ==== Starting a new bulge here would */
    /*                       .    create non-negligible fill.   If */
    /*                       .    the old reflector is diagonal (only */
    /*                       .    possible with underflows), then */
    /*                       .    change it to I.  Otherwise, use */
    /*                       .    it with trepidation. ==== */

			        if (v[m * v_dim1 + 2] == 0.0 && v[m * v_dim1 + 3] 
				        == 0.0) {
				    v[m * v_dim1 + 1] = 0.0;
			        } else {
				    h__[k + 1 + k * h_dim1] = beta;
				    h__[k + 2 + k * h_dim1] = 0.0;
				    h__[k + 3 + k * h_dim1] = 0.0;
			        }
			    } else {

    /*                       ==== Stating a new bulge here would */
    /*                       .    create only negligible fill. */
    /*                       .    Replace the old reflector with */
    /*                       .    the new one. ==== */

			        alpha = vt[0];
			        dlarfg(c__3, ref alpha, &vt[1], c__1, ref vt[0]);
			        refsum = h__[k + 1 + k * h_dim1] + h__[k + 2 + k *
				         h_dim1] * vt[1] + h__[k + 3 + k * h_dim1]
				         * vt[2];
			        h__[k + 1 + k * h_dim1] -= vt[0] * refsum;
			        h__[k + 2 + k * h_dim1] = 0.0;
			        h__[k + 3 + k * h_dim1] = 0.0;
			        v[m * v_dim1 + 1] = vt[0];
			        v[m * v_dim1 + 2] = vt[1];
			        v[m * v_dim1 + 3] = vt[2];
			    }
		        }
		    }
    /* L20: */
	        }

    /*           ==== Generate a 2-by-2 reflection, if needed. ==== */

	        k = krcol + (m22 - 1) * 3;
	        if (bmp22) {
		    if (k == ktop - 1) {
		        dlaqr1(c__2, &h__[k + 1 + (k + 1) * h_dim1], ldh, sr[(
			        m22 << 1) - 1], si[(m22 << 1) - 1], sr[m22 * 2], 
			         si[m22 * 2], &v[m22 * v_dim1 + 1]);
		        beta = v[m22 * v_dim1 + 1];
		        dlarfg(c__2, ref beta, &v[m22 * v_dim1 + 2], c__1, ref v[m22 
			        * v_dim1 + 1]);
		    } else {
		        beta = h__[k + 1 + k * h_dim1];
		        v[m22 * v_dim1 + 2] = h__[k + 2 + k * h_dim1];
		        dlarfg(c__2, ref beta, &v[m22 * v_dim1 + 2], c__1, ref v[m22 
			        * v_dim1 + 1]);
		        h__[k + 1 + k * h_dim1] = beta;
		        h__[k + 2 + k * h_dim1] = 0.0;
		    }
	        } else {

    /*              ==== Initialize V(1,M22) here to avoid possible undefined */
    /*              .    variable problems later. ==== */

		    v[m22 * v_dim1 + 1] = 0.0;
	        }

    /*           ==== Multiply H by reflections from the left ==== */

	        if (accum) {
		    jbot = min(ndcol,kbot);
	        } else if (wantt) {
		    jbot = n;
	        } else {
		    jbot = kbot;
	        }
	        i__4 = jbot;
	        for (j = max(ktop,krcol); j <= i__4; ++j) {
    /* Computing MIN */
		    i__5 = mbot; i__6 = (j - krcol + 2) / 3;
		    mend = min(i__5,i__6);
		    i__5 = mend;
		    for (m = mtop; m <= i__5; ++m) {
		        k = krcol + (m - 1) * 3;
		        refsum = v[m * v_dim1 + 1] * (h__[k + 1 + j * h_dim1] + v[
			        m * v_dim1 + 2] * h__[k + 2 + j * h_dim1] + v[m * 
			        v_dim1 + 3] * h__[k + 3 + j * h_dim1]);
		        h__[k + 1 + j * h_dim1] -= refsum;
		        h__[k + 2 + j * h_dim1] -= refsum * v[m * v_dim1 + 2];
		        h__[k + 3 + j * h_dim1] -= refsum * v[m * v_dim1 + 3];
    /* L30: */
		    }
    /* L40: */
	        }
	        if (bmp22) {
		    k = krcol + (m22 - 1) * 3;
    /* Computing MAX */
		    i__4 = k + 1;
		    i__5 = jbot;
		    for (j = max(i__4,ktop); j <= i__5; ++j) {
		        refsum = v[m22 * v_dim1 + 1] * (h__[k + 1 + j * h_dim1] + 
			        v[m22 * v_dim1 + 2] * h__[k + 2 + j * h_dim1]);
		        h__[k + 1 + j * h_dim1] -= refsum;
		        h__[k + 2 + j * h_dim1] -= refsum * v[m22 * v_dim1 + 2];
    /* L50: */
		    }
	        }

    /*           ==== Multiply H by reflections from the right. */
    /*           .    Delay filling in the last row until the */
    /*           .    vigilant deflation check is complete. ==== */

	        if (accum) {
		    jtop = max(ktop,incol);
	        } else if (wantt) {
		    jtop = 1;
	        } else {
		    jtop = ktop;
	        }
	        i__5 = mbot;
	        for (m = mtop; m <= i__5; ++m) {
		    if (v[m * v_dim1 + 1] != 0.0) {
		        k = krcol + (m - 1) * 3;
    /* Computing MIN */
		        i__6 = kbot; i__7 = k + 3;
		        i__4 = min(i__6,i__7);
		        for (j = jtop; j <= i__4; ++j) {
			    refsum = v[m * v_dim1 + 1] * (h__[j + (k + 1) * 
				    h_dim1] + v[m * v_dim1 + 2] * h__[j + (k + 2) 
				    * h_dim1] + v[m * v_dim1 + 3] * h__[j + (k + 
				    3) * h_dim1]);
			    h__[j + (k + 1) * h_dim1] -= refsum;
			    h__[j + (k + 2) * h_dim1] -= refsum * v[m * v_dim1 + 
				    2];
			    h__[j + (k + 3) * h_dim1] -= refsum * v[m * v_dim1 + 
				    3];
    /* L60: */
		        }

		        if (accum) {

    /*                    ==== Accumulate U. (If necessary, update Z later */
    /*                    .    with with an efficient matrix-matrix */
    /*                    .    multiply.) ==== */

			    kms = k - incol;
    /* Computing MAX */
			    i__4 = 1; i__6 = ktop - incol;
			    i__7 = kdu;
			    for (j = max(i__4,i__6); j <= i__7; ++j) {
			        refsum = v[m * v_dim1 + 1] * (u[j + (kms + 1) * 
				        u_dim1] + v[m * v_dim1 + 2] * u[j + (kms 
				        + 2) * u_dim1] + v[m * v_dim1 + 3] * u[j 
				        + (kms + 3) * u_dim1]);
			        u[j + (kms + 1) * u_dim1] -= refsum;
			        u[j + (kms + 2) * u_dim1] -= refsum * v[m * 
				        v_dim1 + 2];
			        u[j + (kms + 3) * u_dim1] -= refsum * v[m * 
				        v_dim1 + 3];
    /* L70: */
			    }
		        } else if (wantz) {

    /*                    ==== U is not accumulated, so update Z */
    /*                    .    now by multiplying by reflections */
    /*                    .    from the right. ==== */

			    i__7 = ihiz;
			    for (j = iloz; j <= i__7; ++j) {
			        refsum = v[m * v_dim1 + 1] * (z__[j + (k + 1) * 
				        z_dim1] + v[m * v_dim1 + 2] * z__[j + (k 
				        + 2) * z_dim1] + v[m * v_dim1 + 3] * z__[
				        j + (k + 3) * z_dim1]);
			        z__[j + (k + 1) * z_dim1] -= refsum;
			        z__[j + (k + 2) * z_dim1] -= refsum * v[m * 
				        v_dim1 + 2];
			        z__[j + (k + 3) * z_dim1] -= refsum * v[m * 
				        v_dim1 + 3];
    /* L80: */
			    }
		        }
		    }
    /* L90: */
	        }

    /*           ==== Special case: 2-by-2 reflection (if needed) ==== */

	        k = krcol + (m22 - 1) * 3;
	        if (bmp22 && v[m22 * v_dim1 + 1] != 0.0) {
    /* Computing MIN */
		    i__7 = kbot; i__4 = k + 3;
		    i__5 = min(i__7,i__4);
		    for (j = jtop; j <= i__5; ++j) {
		        refsum = v[m22 * v_dim1 + 1] * (h__[j + (k + 1) * h_dim1] 
			        + v[m22 * v_dim1 + 2] * h__[j + (k + 2) * h_dim1])
			        ;
		        h__[j + (k + 1) * h_dim1] -= refsum;
		        h__[j + (k + 2) * h_dim1] -= refsum * v[m22 * v_dim1 + 2];
    /* L100: */
		    }

		    if (accum) {
		        kms = k - incol;
    /* Computing MAX */
		        i__5 = 1; i__7 = ktop - incol;
		        i__4 = kdu;
		        for (j = max(i__5,i__7); j <= i__4; ++j) {
			    refsum = v[m22 * v_dim1 + 1] * (u[j + (kms + 1) * 
				    u_dim1] + v[m22 * v_dim1 + 2] * u[j + (kms + 
				    2) * u_dim1]);
			    u[j + (kms + 1) * u_dim1] -= refsum;
			    u[j + (kms + 2) * u_dim1] -= refsum * v[m22 * v_dim1 
				    + 2];
    /* L110: */
		        }
		    } else if (wantz) {
		        i__4 = ihiz;
		        for (j = iloz; j <= i__4; ++j) {
			    refsum = v[m22 * v_dim1 + 1] * (z__[j + (k + 1) * 
				    z_dim1] + v[m22 * v_dim1 + 2] * z__[j + (k + 
				    2) * z_dim1]);
			    z__[j + (k + 1) * z_dim1] -= refsum;
			    z__[j + (k + 2) * z_dim1] -= refsum * v[m22 * v_dim1 
				    + 2];
    /* L120: */
		        }
		    }
	        }

    /*           ==== Vigilant deflation check ==== */

	        mstart = mtop;
	        if (krcol + (mstart - 1) * 3 < ktop) {
		    ++mstart;
	        }
	        mend = mbot;
	        if (bmp22) {
		    ++mend;
	        }
	        if (krcol == kbot - 2) {
		    ++mend;
	        }
	        i__4 = mend;
	        for (m = mstart; m <= i__4; ++m) {
    /* Computing MIN */
		    i__5 = kbot - 1; i__7 = krcol + (m - 1) * 3;
		    k = min(i__5,i__7);

    /*              ==== The following convergence test requires that */
    /*              .    the tradition small-compared-to-nearby-diagonals */
    /*              .    criterion and the Ahues & Tisseur (LAWN 122, 1997) */
    /*              .    criteria both be satisfied.  The latter improves */
    /*              .    accuracy in some examples. Falling back on an */
    /*              .    alternate convergence criterion when TST1 or TST2 */
    /*              .    is zero (as done here) is traditional but probably */
    /*              .    unnecessary. ==== */

		    if (h__[k + 1 + k * h_dim1] != 0.0) {
                d__1 = h__[k + k * h_dim1];
                d__2 = h__[k + 1 + (k + 1) * h_dim1];
		        tst1 = (abs(d__1)) + (abs(d__2));
		        if (tst1 == 0.0) {
			    if (k >= ktop + 1) {
                    d__1 = h__[k + (k - 1) * h_dim1];
			        tst1 += ( abs(d__1));
			    }
			    if (k >= ktop + 2) {
                    d__1 = h__[k + (k - 2) * h_dim1];
			        tst1 += ( abs(d__1));
			    }
			    if (k >= ktop + 3) {
                    d__1 = h__[k + (k - 3) * h_dim1];
			        tst1 += (abs(d__1));
			    }
			    if (k <= kbot - 2) {
                    d__1 = h__[k + 2 + (k + 1) * h_dim1];
			        tst1 += ( abs(d__1));
			    }
			    if (k <= kbot - 3) {
                    d__1 = h__[k + 3 + (k + 1) * h_dim1];
			        tst1 += ( abs(d__1));
			    }
			    if (k <= kbot - 4) {
                    d__1 = h__[k + 4 + (k + 1) * h_dim1];
			        tst1 += ( abs(d__1));
			    }
		        }
    /* Computing MAX */
		        d__2 = smlnum; d__3 = ulp * tst1;
		        if ((abs(h__[k + 1 + k * h_dim1])) <= max(d__2,d__3)) {
    /* Computing MAX */
			    d__3 = (abs(h__[k + 1 + k * h_dim1]));
                d__2 = h__[k + (k + 1) * h_dim1];
				d__4 = ( abs( d__2));
			    h12 = max(d__3,d__4);
    /* Computing MIN */
                d__1 = h__[k + 1 + k * h_dim1];
			    d__3 = (abs(d__1));
                d__2 = h__[k + (k + 1) * h_dim1];
                d__4 = ( abs( d__2));
			    h21 = min(d__3,d__4);
    /* Computing MAX */
                d__1 = h__[k + 1 + (k + 1) * h_dim1];
			    d__3 = ( abs(d__1));
                d__2 = h__[k + k * h_dim1] -  h__[k + 1 + (k + 1) * h_dim1];
                d__4 = ( abs(d__2));
			    h11 = max(d__3,d__4);
    /* Computing MIN */
                d__1 = h__[k + 1 + (k + 1) * h_dim1];
			    d__3 = ( abs(d__1));
                d__2 = h__[k + k * h_dim1] - h__[k + 1 + (k + 1) * h_dim1];
                d__4 = ( abs(d__2));
			    h22 = min(d__3,d__4);
			    scl = h11 + h12;
			    tst2 = h22 * (h11 / scl);

    /* Computing MAX */
			    d__1 = smlnum; d__2 = ulp * tst2;
			    if (tst2 == 0.0 || h21 * (h12 / scl) <= max(d__1,d__2))
				     {
			        h__[k + 1 + k * h_dim1] = 0.0;
			    }
		        }
		    }
    /* L130: */
	        }

    /*           ==== Fill in the last row of each bulge. ==== */

    /* Computing MIN */
	        i__4 = nbmps; i__5 = (kbot - krcol - 1) / 3;
	        mend = min(i__4,i__5);
	        i__4 = mend;
	        for (m = mtop; m <= i__4; ++m) {
		    k = krcol + (m - 1) * 3;
		    refsum = v[m * v_dim1 + 1] * v[m * v_dim1 + 3] * h__[k + 4 + (
			    k + 3) * h_dim1];
		    h__[k + 4 + (k + 1) * h_dim1] = -refsum;
		    h__[k + 4 + (k + 2) * h_dim1] = -refsum * v[m * v_dim1 + 2];
		    h__[k + 4 + (k + 3) * h_dim1] -= refsum * v[m * v_dim1 + 3];
    /* L140: */
	        }

    /*           ==== End of near-the-diagonal bulge chase. ==== */
                /* L150: */
	    }

    /*        ==== Use U (if accumulated) to update far-from-diagonal */
    /*        .    entries in H.  If required, use U to update Z as */
    /*        .    well. ==== */

	    if (accum) {
	        if (wantt) {
		    jtop = 1;
		    jbot = n;
	        } else {
		    jtop = ktop;
		    jbot = kbot;
	        }
	        if (! blk22 || incol < ktop || ndcol > kbot || ns <= 2) {

    /*              ==== Updates not exploiting the 2-by-2 block */
    /*              .    structure of U.  K1 and NU keep track of */
    /*              .    the location and size of U in the special */
    /*              .    cases of introducing bulges and chasing */
    /*              .    bulges off the bottom.  In these special */
    /*              .    cases and in case the number of shifts */
    /*              .    is NS = 2, there is no 2-by-2 block */
    /*              .    structure to exploit.  ==== */

    /* Computing MAX */
		    i__3 = 1; i__4 = ktop - incol;
		    k1 = max(i__3,i__4);
    /* Computing MAX */
		    i__3 = 0; i__4 = ndcol - kbot;
		    nu = kdu - max(i__3,i__4) - k1 + 1;

    /*              ==== Horizontal Multiply ==== */

		    i__3 = jbot;
		    i__4 = nh;
		    for (jcol = min(ndcol,kbot) + 1; i__4 < 0 ? jcol >= i__3 : 
			    jcol <= i__3; jcol += i__4) {
    /* Computing MIN */
		        i__5 = nh; i__7 = jbot - jcol + 1;
		        jlen = min(i__5,i__7);
		        dgemm('C', 'N', nu, jlen, nu, c_b8, &u[k1 + k1 * 
			        u_dim1], ldu, &h__[incol + k1 + jcol * h_dim1], 
			        ldh, c_b7, &wh[wh_offset], ldwh);
		        dlacpy('A', nu, jlen, &wh[wh_offset], ldwh, &h__[
			        incol + k1 + jcol * h_dim1], ldh);
    /* L160: */
		    }

    /*              ==== Vertical multiply ==== */

		    i__4 = max(ktop,incol) - 1;
		    i__3 = nv;
		    for (jrow = jtop; i__3 < 0 ? jrow >= i__4 : jrow <= i__4; 
			    jrow += i__3) {
    /* Computing MIN */
		        i__5 = nv; i__7 = max(ktop,incol) - jrow;
		        jlen = min(i__5,i__7);
		        dgemm('N', 'N', jlen, nu, nu, c_b8, &h__[jrow + (
			        incol + k1) * h_dim1], ldh, &u[k1 + k1 * u_dim1], 
			        ldu, c_b7, &wv[wv_offset], ldwv);
		        dlacpy('A', jlen, nu, &wv[wv_offset], ldwv, &h__[
			        jrow + (incol + k1) * h_dim1], ldh);
    /* L170: */
		    }

    /*              ==== Z multiply (also vertical) ==== */

		    if (wantz) {
		        i__3 = ihiz;
		        i__4 = nv;
		        for (jrow = iloz; i__4 < 0 ? jrow >= i__3 : jrow <= i__3;
			         jrow += i__4) {
    /* Computing MIN */
			    i__5 = nv; i__7 = ihiz - jrow + 1;
			    jlen = min(i__5,i__7);
			    dgemm('N', 'N', jlen, nu, nu, c_b8, &z__[jrow + (
				    incol + k1) * z_dim1], ldz, &u[k1 + k1 * 
				    u_dim1], ldu, c_b7, &wv[wv_offset], ldwv);
			    dlacpy('A', jlen, nu, &wv[wv_offset], ldwv, &z__[
				    jrow + (incol + k1) * z_dim1], ldz)
				    ;
    /* L180: */
		        }
		    }
	        } else {

    /*              ==== Updates exploiting U's 2-by-2 block structure. */
    /*              .    (I2, I4, J2, J4 are the last rows and columns */
    /*              .    of the blocks.) ==== */

		    i2 = (kdu + 1) / 2;
		    i4 = kdu;
		    j2 = i4 - i2;
		    j4 = kdu;

    /*              ==== KZS and KNZ deal with the band of zeros */
    /*              .    along the diagonal of one of the triangular */
    /*              .    blocks. ==== */

		    kzs = j4 - j2 - (ns + 1);
		    knz = ns + 1;

    /*              ==== Horizontal multiply ==== */

		    i__4 = jbot;
		    i__3 = nh;
		    for (jcol = min(ndcol,kbot) + 1; i__3 < 0 ? jcol >= i__4 : 
			    jcol <= i__4; jcol += i__3) {
    /* Computing MIN */
		        i__5 = nh; i__7 = jbot - jcol + 1;
		        jlen = min(i__5,i__7);

    /*                 ==== Copy bottom of H to top+KZS of scratch ==== */
    /*                  (The first KZS rows get multiplied by zero.) ==== */

		        dlacpy('A', knz, jlen, &h__[incol + 1 + j2 + jcol * 
			        h_dim1], ldh, &wh[kzs + 1 + wh_dim1], ldwh);

    /*                 ==== Multiply by U21' ==== */

		        dlaset('A', kzs, jlen, c_b7, c_b7, &wh[wh_offset], 
			        ldwh);
		        dtrmm('L', 'U', 'C', 'N', knz, jlen, c_b8, &u[j2 + 1 
			        + (kzs + 1) * u_dim1], ldu, &wh[kzs + 1 + wh_dim1]
    , ldwh);

    /*                 ==== Multiply top of H by U11' ==== */

		        dgemm('C', 'N', i2, jlen, j2, c_b8, &u[u_offset], 
			        ldu, &h__[incol + 1 + jcol * h_dim1], ldh, c_b8, 
			        &wh[wh_offset], ldwh);

    /*                 ==== Copy top of H bottom of WH ==== */

		        dlacpy('A',j2, jlen, &h__[incol + 1 + jcol * h_dim1]
    , ldh, &wh[i2 + 1 + wh_dim1], ldwh);

    /*                 ==== Multiply by U21' ==== */

		        dtrmm('L', 'L', 'C', 'N', j2, jlen, c_b8, &u[(i2 + 1) 
			        * u_dim1 + 1], ldu, &wh[i2 + 1 + wh_dim1], ldwh);

    /*                 ==== Multiply by U22 ==== */

		        i__5 = i4 - i2;
		        i__7 = j4 - j2;
		        dgemm('C', 'N', i__5, jlen, i__7, c_b8, &u[j2 + 1 + (
			        i2 + 1) * u_dim1], ldu, &h__[incol + 1 + j2 + 
			        jcol * h_dim1], ldh, c_b8, &wh[i2 + 1 + wh_dim1], 
			         ldwh);

    /*                 ==== Copy it back ==== */

		        dlacpy('A', kdu, jlen, &wh[wh_offset], ldwh, &h__[
			        incol + 1 + jcol * h_dim1], ldh);
    /* L190: */
		    }

    /*              ==== Vertical multiply ==== */

		    i__3 = max(incol,ktop) - 1;
		    i__4 = nv;
		    for (jrow = jtop; i__4 < 0 ? jrow >= i__3 : jrow <= i__3; 
			    jrow += i__4) {
    /* Computing MIN */
		        i__5 = nv; i__7 = max(incol,ktop) - jrow;
		        jlen = min(i__5,i__7);

    /*                 ==== Copy right of H to scratch (the first KZS */
    /*                 .    columns get multiplied by zero) ==== */

		        dlacpy('A', jlen, knz, &h__[jrow + (incol + 1 + j2) *
			         h_dim1], ldh, &wv[(kzs + 1) * wv_dim1 + 1], ldwv);

    /*                 ==== Multiply by U21 ==== */

		        dlaset('A', jlen, kzs, c_b7, c_b7, &wv[wv_offset], 
			        ldwv);
		        dtrmm('R', 'U', 'N', 'N', jlen, knz, c_b8, &u[j2 + 1 
			        + (kzs + 1) * u_dim1], ldu, &wv[(kzs + 1) * 
			        wv_dim1 + 1], ldwv);

    /*                 ==== Multiply by U11 ==== */

		        dgemm('N', 'N', jlen, i2, j2, c_b8, &h__[jrow + (
			        incol + 1) * h_dim1], ldh, &u[u_offset], ldu, 
			        c_b8, &wv[wv_offset], ldwv);

    /*                 ==== Copy left of H to right of scratch ==== */

		        dlacpy('A', jlen, j2, &h__[jrow + (incol + 1) * 
			        h_dim1], ldh, &wv[(i2 + 1) * wv_dim1 + 1], ldwv);

    /*                 ==== Multiply by U21 ==== */

		        i__5 = i4 - i2;
		        dtrmm('R', 'L', 'N', 'N', jlen, i__5, c_b8, &u[(i2 + 
			        1) * u_dim1 + 1], ldu, &wv[(i2 + 1) * wv_dim1 + 1]
    , ldwv);

    /*                 ==== Multiply by U22 ==== */

		        i__5 = i4 - i2;
		        i__7 = j4 - j2;
		        dgemm('N', 'N', jlen, i__5, i__7, c_b8, &h__[jrow + (
			        incol + 1 + j2) * h_dim1], ldh, &u[j2 + 1 + (i2 + 
			        1) * u_dim1], ldu,c_b8, &wv[(i2 + 1) * wv_dim1 
			        + 1], ldwv);

    /*                 ==== Copy it back ==== */

		        dlacpy('A', jlen, kdu, &wv[wv_offset], ldwv, &h__[
			        jrow + (incol + 1) * h_dim1], ldh);
    /* L200: */
		    }

    /*              ==== Multiply Z (also vertical) ==== */

		    if (wantz) {
		        i__4 = ihiz;
		        i__3 = nv;
		        for (jrow = iloz; i__3 < 0 ? jrow >= i__4 : jrow <= i__4;
			         jrow += i__3) {
    /* Computing MIN */
			    i__5 = nv; i__7 = ihiz - jrow + 1;
			    jlen = min(i__5,i__7);

    /*                    ==== Copy right of Z to left of scratch (first */
    /*                    .     KZS columns get multiplied by zero) ==== */

			    dlacpy('A', jlen, knz, &z__[jrow + (incol + 1 + 
				    j2) * z_dim1], ldz, &wv[(kzs + 1) * wv_dim1 + 
				    1], ldwv);

    /*                    ==== Multiply by U12 ==== */

			    dlaset('A', jlen, kzs, c_b7, c_b7, &wv[
				    wv_offset], ldwv);
			    dtrmm('R', 'U', 'N', 'N', jlen, knz, c_b8, &u[j2 
				    + 1 + (kzs + 1) * u_dim1], ldu, &wv[(kzs + 1) 
				    * wv_dim1 + 1], ldwv);

    /*                    ==== Multiply by U11 ==== */

			    dgemm('N', 'N', jlen,i2, j2, c_b8, &z__[jrow + (
				    incol + 1) * z_dim1], ldz, &u[u_offset], ldu, 
				    c_b8, &wv[wv_offset], ldwv);

    /*                    ==== Copy left of Z to right of scratch ==== */

			    dlacpy('A', jlen, j2, &z__[jrow + (incol + 1) * 
				    z_dim1], ldz, &wv[(i2 + 1) * wv_dim1 + 1], 
				    ldwv);

    /*                    ==== Multiply by U21 ==== */

			    i__5 = i4 - i2;
			    dtrmm('R', 'L', 'N', 'N', jlen, i__5, c_b8, &u[(
				    i2 + 1) * u_dim1 + 1], ldu, &wv[(i2 + 1) * 
				    wv_dim1 + 1], ldwv);

    /*                    ==== Multiply by U22 ==== */

			    i__5 = i4 - i2;
			    i__7 = j4 - j2;
			    dgemm('N', 'N', jlen, i__5, i__7, c_b8, &z__[
				    jrow + (incol + 1 + j2) * z_dim1], ldz, &u[j2 
				    + 1 + (i2 + 1) * u_dim1], ldu, c_b8, &wv[(i2 
				    + 1) * wv_dim1 + 1], ldwv);

    /*                    ==== Copy the result back to Z ==== */

			    dlacpy('A', jlen, kdu, &wv[wv_offset], ldwv, &
				    z__[jrow + (incol + 1) * z_dim1], ldz);
    /* L210: */
		        }
		    }
	        }
	    }
    /* L220: */
        }

    /*     ==== End of DLAQR5 ==== */

        return 0;
    }
}

