/*************************************************************************
ALGLIB 4.04.0 (source code generated 2024-12-21)
Copyright (c) Sergey Bochkanov (ALGLIB project).

>>> SOURCE LICENSE >>>
This program is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation (www.fsf.org); either version 2 of the 
License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

A copy of the GNU General Public License is available at
http://www.fsf.org/licensing/licenses
>>> END OF LICENSE >>>
*************************************************************************/
#pragma warning disable 1691
#pragma warning disable 162
#pragma warning disable 164
#pragma warning disable 219
#pragma warning disable 8981
using System;

public partial class alglib
{


    /*************************************************************************

    *************************************************************************/
    public class polynomialsolverreport : alglibobject
    {
        //
        // Public declarations
        //
        public double maxerr { get { return _innerobj.maxerr; } set { _innerobj.maxerr = value; } }
    
        public polynomialsolverreport()
        {
            _innerobj = new polynomialsolver.polynomialsolverreport();
        }
        
        public override alglib.alglibobject make_copy()
        {
            return new polynomialsolverreport((polynomialsolver.polynomialsolverreport)_innerobj.make_copy());
        }
    
        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private polynomialsolver.polynomialsolverreport _innerobj;
        public polynomialsolver.polynomialsolverreport innerobj { get { return _innerobj; } }
        public polynomialsolverreport(polynomialsolver.polynomialsolverreport obj)
        {
            _innerobj = obj;
        }
    }
    
    /*************************************************************************
    Polynomial root finding.

    This function returns all roots of the polynomial
        P(x) = a0 + a1*x + a2*x^2 + ... + an*x^n
    Both real and complex roots are returned (see below).

    INPUT PARAMETERS:
        A       -   array[N+1], polynomial coefficients:
                    * A[0] is constant term
                    * A[N] is a coefficient of X^N
        N       -   polynomial degree

    OUTPUT PARAMETERS:
        X       -   array of complex roots:
                    * for isolated real root, X[I] is strictly real: IMAGE(X[I])=0
                    * complex roots are always returned in pairs - roots occupy
                      positions I and I+1, with:
                      * X[I+1]=Conj(X[I])
                      * IMAGE(X[I]) > 0
                      * IMAGE(X[I+1]) = -IMAGE(X[I]) < 0
                    * multiple real roots may have non-zero imaginary part due
                      to roundoff errors. There is no reliable way to distinguish
                      real root of multiplicity 2 from two  complex  roots  in
                      the presence of roundoff errors.
        Rep     -   report, additional information, following fields are set:
                    * Rep.MaxErr - max( |P(xi)| )  for  i=0..N-1.  This  field
                      allows to quickly estimate "quality" of the roots  being
                      returned.

    NOTE:   this function uses companion matrix method to find roots. In  case
            internal EVD  solver  fails  do  find  eigenvalues,  exception  is
            generated.

    NOTE:   roots are not "polished" and  no  matrix  balancing  is  performed
            for them.

      -- ALGLIB --
         Copyright 24.02.2014 by Bochkanov Sergey
    *************************************************************************/
    public static void polynomialsolve(double[] a, int n, out complex[] x, out polynomialsolverreport rep)
    {
        x = new complex[0];
        rep = new polynomialsolverreport();
        polynomialsolver.polynomialsolve(a, n, ref x, rep.innerobj, null);
    }
    
    public static void polynomialsolve(double[] a, int n, out complex[] x, out polynomialsolverreport rep, alglib.xparams _params)
    {
        x = new complex[0];
        rep = new polynomialsolverreport();
        polynomialsolver.polynomialsolve(a, n, ref x, rep.innerobj, _params);
    }

}
public partial class alglib
{


    /*************************************************************************

    *************************************************************************/
    public class densesolverreport : alglibobject
    {
        //
        // Public declarations
        //
        public int terminationtype { get { return _innerobj.terminationtype; } set { _innerobj.terminationtype = value; } }
        public double r1 { get { return _innerobj.r1; } set { _innerobj.r1 = value; } }
        public double rinf { get { return _innerobj.rinf; } set { _innerobj.rinf = value; } }
    
        public densesolverreport()
        {
            _innerobj = new directdensesolvers.densesolverreport();
        }
        
        public override alglib.alglibobject make_copy()
        {
            return new densesolverreport((directdensesolvers.densesolverreport)_innerobj.make_copy());
        }
    
        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private directdensesolvers.densesolverreport _innerobj;
        public directdensesolvers.densesolverreport innerobj { get { return _innerobj; } }
        public densesolverreport(directdensesolvers.densesolverreport obj)
        {
            _innerobj = obj;
        }
    }


    /*************************************************************************

    *************************************************************************/
    public class densesolverlsreport : alglibobject
    {
        //
        // Public declarations
        //
        public int terminationtype { get { return _innerobj.terminationtype; } set { _innerobj.terminationtype = value; } }
        public double r2 { get { return _innerobj.r2; } set { _innerobj.r2 = value; } }
        public double[,] cx { get { return _innerobj.cx; } set { _innerobj.cx = value; } }
        public int n { get { return _innerobj.n; } set { _innerobj.n = value; } }
        public int k { get { return _innerobj.k; } set { _innerobj.k = value; } }
    
        public densesolverlsreport()
        {
            _innerobj = new directdensesolvers.densesolverlsreport();
        }
        
        public override alglib.alglibobject make_copy()
        {
            return new densesolverlsreport((directdensesolvers.densesolverlsreport)_innerobj.make_copy());
        }
    
        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private directdensesolvers.densesolverlsreport _innerobj;
        public directdensesolvers.densesolverlsreport innerobj { get { return _innerobj; } }
        public densesolverlsreport(directdensesolvers.densesolverlsreport obj)
        {
            _innerobj = obj;
        }
    }
    
    /*************************************************************************
    Dense solver for A*x=b with N*N real matrix A and N*1 real vectorx  x  and
    b. This is "slow-but-feature rich" version of the  linear  solver.  Faster
    version is RMatrixSolveFast() function.

    Algorithm features:
    * automatic detection of degenerate cases
    * condition number estimation
    * iterative refinement
    * O(N^3) complexity

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear  system
               ! and  performs  iterative   refinement,   which   results   in
               ! significant performance penalty  when  compared  with  "fast"
               ! version  which  just  performs  LU  decomposition  and  calls
               ! triangular solver.
               !
               ! This  performance  penalty  is  especially  visible  in   the
               ! multithreaded mode, because both condition number  estimation
               ! and   iterative    refinement   are   inherently   sequential
               ! calculations. It is also very significant on small matrices.
               !
               ! Thus, if you need high performance and if you are pretty sure
               ! that your system is well conditioned, we  strongly  recommend
               ! you to use faster solver, RMatrixSolveFast() function.

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        Rep     -   additional report, the following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned matrix
                    * rep.r1                condition number in 1-norm
                    * rep.rinf              condition number in inf-norm
        X       -   array[N], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void rmatrixsolve(double[,] a, int n, double[] b, out double[] x, out densesolverreport rep)
    {
        x = new double[0];
        rep = new densesolverreport();
        directdensesolvers.rmatrixsolve(a, n, b, ref x, rep.innerobj, null);
    }
    
    public static void rmatrixsolve(double[,] a, int n, double[] b, out double[] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new densesolverreport();
        directdensesolvers.rmatrixsolve(a, n, b, ref x, rep.innerobj, _params);
    }
            
    public static void rmatrixsolve(double[,] a, double[] b, out double[] x, out densesolverreport rep)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'rmatrixsolve': looks like one of arguments has wrong size");
        x = new double[0];
        rep = new densesolverreport();
        n = ap.rows(a);
        directdensesolvers.rmatrixsolve(a, n, b, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void rmatrixsolve(double[,] a, double[] b, out double[] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'rmatrixsolve': looks like one of arguments has wrong size");
        x = new double[0];
        rep = new densesolverreport();
        n = ap.rows(a);
        directdensesolvers.rmatrixsolve(a, n, b, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver.

    This  subroutine  solves  a  system  A*x=b,  where A is NxN non-denegerate
    real matrix, x  and  b  are  vectors.  This is a "fast" version of  linear
    solver which does NOT provide  any  additional  functions  like  condition
    number estimation or iterative refinement.

    Algorithm features:
    * efficient algorithm O(N^3) complexity
    * no performance overhead from additional functionality

    If you need condition number estimation or iterative refinement, use  more
    feature-rich version - RMatrixSolve().

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        B       -   array[N]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or exactly singular system

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 16.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static bool rmatrixsolvefast(double[,] a, int n, double[] b)
    {
    
        return directdensesolvers.rmatrixsolvefast(a, n, b, null);
    }
    
    public static bool rmatrixsolvefast(double[,] a, int n, double[] b, alglib.xparams _params)
    {
    
        return directdensesolvers.rmatrixsolvefast(a, n, b, _params);
    }
            
    public static bool rmatrixsolvefast(double[,] a, double[] b)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'rmatrixsolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        bool result = directdensesolvers.rmatrixsolvefast(a, n, b, null);
    
        return result;
    }
            
    public static bool rmatrixsolvefast(double[,] a, double[] b, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'rmatrixsolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        bool result = directdensesolvers.rmatrixsolvefast(a, n, b, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver.

    Similar to RMatrixSolve() but solves task with multiple right parts (where
    b and x are NxM matrices). This is  "slow-but-robust"  version  of  linear
    solver with additional functionality  like  condition  number  estimation.
    There also exists faster version - RMatrixSolveMFast().

    Algorithm features:
    * automatic detection of degenerate cases
    * condition number estimation
    * optional iterative refinement
    * O(N^3+M*N^2) complexity

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear  system
               ! and  performs  iterative   refinement,   which   results   in
               ! significant performance penalty  when  compared  with  "fast"
               ! version  which  just  performs  LU  decomposition  and  calls
               ! triangular solver.
               !
               ! This  performance  penalty  is  especially  visible  in   the
               ! multithreaded mode, because both condition number  estimation
               ! and   iterative    refinement   are   inherently   sequential
               ! calculations. It also very significant on small matrices.
               !
               ! Thus, if you need high performance and if you are pretty sure
               ! that your system is well conditioned, we  strongly  recommend
               ! you to use faster solver, RMatrixSolveMFast() function.

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size
        RFS     -   iterative refinement switch:
                    * True - refinement is used.
                      Less performance, more precision.
                    * False - refinement is not used.
                      More performance, less precision.

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or exactly singular matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void rmatrixsolvem(double[,] a, int n, double[,] b, int m, bool rfs, out double[,] x, out densesolverreport rep)
    {
        x = new double[0,0];
        rep = new densesolverreport();
        directdensesolvers.rmatrixsolvem(a, n, b, m, rfs, ref x, rep.innerobj, null);
    }
    
    public static void rmatrixsolvem(double[,] a, int n, double[,] b, int m, bool rfs, out double[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new double[0,0];
        rep = new densesolverreport();
        directdensesolvers.rmatrixsolvem(a, n, b, m, rfs, ref x, rep.innerobj, _params);
    }
            
    public static void rmatrixsolvem(double[,] a, double[,] b, bool rfs, out double[,] x, out densesolverreport rep)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'rmatrixsolvem': looks like one of arguments has wrong size");
        x = new double[0,0];
        rep = new densesolverreport();
        n = ap.rows(a);
        m = ap.cols(b);
        directdensesolvers.rmatrixsolvem(a, n, b, m, rfs, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void rmatrixsolvem(double[,] a, double[,] b, bool rfs, out double[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'rmatrixsolvem': looks like one of arguments has wrong size");
        x = new double[0,0];
        rep = new densesolverreport();
        n = ap.rows(a);
        m = ap.cols(b);
        directdensesolvers.rmatrixsolvem(a, n, b, m, rfs, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver.

    Similar to RMatrixSolve() but solves task with multiple right parts (where
    b and x are NxM matrices). This is "fast" version of linear  solver  which
    does NOT offer additional functions like condition  number  estimation  or
    iterative refinement.

    Algorithm features:
    * O(N^3+M*N^2) complexity
    * no additional functionality, highest performance

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size
        RFS     -   iterative refinement switch:
                    * True - refinement is used.
                      Less performance, more precision.
                    * False - refinement is not used.
                      More performance, less precision.

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        B       -   array[N]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True for well-conditioned matrix
        False for extremely badly conditioned or exactly singular problem

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static bool rmatrixsolvemfast(double[,] a, int n, double[,] b, int m)
    {
    
        return directdensesolvers.rmatrixsolvemfast(a, n, b, m, null);
    }
    
    public static bool rmatrixsolvemfast(double[,] a, int n, double[,] b, int m, alglib.xparams _params)
    {
    
        return directdensesolvers.rmatrixsolvemfast(a, n, b, m, _params);
    }
            
    public static bool rmatrixsolvemfast(double[,] a, double[,] b)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'rmatrixsolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        m = ap.cols(b);
        bool result = directdensesolvers.rmatrixsolvemfast(a, n, b, m, null);
    
        return result;
    }
            
    public static bool rmatrixsolvemfast(double[,] a, double[,] b, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'rmatrixsolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        m = ap.cols(b);
        bool result = directdensesolvers.rmatrixsolvemfast(a, n, b, m, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver.

    This  subroutine  solves  a  system  A*x=b,  where A is NxN non-denegerate
    real matrix given by its LU decomposition, x and b are real vectors.  This
    is "slow-but-robust" version of the linear LU-based solver. Faster version
    is RMatrixLUSolveFast() function.

    Algorithm features:
    * automatic detection of degenerate cases
    * O(N^2) complexity
    * condition number estimation

    No iterative refinement  is provided because exact form of original matrix
    is not known to subroutine. Use RMatrixSolve or RMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which results in 10-15x  performance  penalty  when  compared
               ! with "fast" version which just calls triangular solver.
               !
               ! This performance penalty is insignificant  when compared with
               ! cost of large LU decomposition.  However,  if you  call  this
               ! function many times for the same  left  side,  this  overhead
               ! BECOMES significant. It  also  becomes significant for small-
               ! scale problems.
               !
               ! In such cases we strongly recommend you to use faster solver,
               ! RMatrixLUSolveFast() function.

    INPUT PARAMETERS
        LUA     -   array[N,N], LU decomposition, RMatrixLU result
        P       -   array[N], pivots array, RMatrixLU result
        N       -   size of A
        B       -   array[N], right part

    OUTPUT PARAMETERS
        Rep     -   additional report, the following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned matrix
                    * rep.r1                condition number in 1-norm
                    * rep.rinf              condition number in inf-norm
        X       -   array[N], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros


      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void rmatrixlusolve(double[,] lua, int[] p, int n, double[] b, out double[] x, out densesolverreport rep)
    {
        x = new double[0];
        rep = new densesolverreport();
        directdensesolvers.rmatrixlusolve(lua, p, n, b, ref x, rep.innerobj, null);
    }
    
    public static void rmatrixlusolve(double[,] lua, int[] p, int n, double[] b, out double[] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new densesolverreport();
        directdensesolvers.rmatrixlusolve(lua, p, n, b, ref x, rep.innerobj, _params);
    }
            
    public static void rmatrixlusolve(double[,] lua, int[] p, double[] b, out double[] x, out densesolverreport rep)
    {
        int n;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)) || (ap.rows(lua)!=ap.len(b)))
            throw new alglibexception("Error while calling 'rmatrixlusolve': looks like one of arguments has wrong size");
        x = new double[0];
        rep = new densesolverreport();
        n = ap.rows(lua);
        directdensesolvers.rmatrixlusolve(lua, p, n, b, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void rmatrixlusolve(double[,] lua, int[] p, double[] b, out double[] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)) || (ap.rows(lua)!=ap.len(b)))
            throw new alglibexception("Error while calling 'rmatrixlusolve': looks like one of arguments has wrong size");
        x = new double[0];
        rep = new densesolverreport();
        n = ap.rows(lua);
        directdensesolvers.rmatrixlusolve(lua, p, n, b, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver.

    This  subroutine  solves  a  system  A*x=b,  where A is NxN non-denegerate
    real matrix given by its LU decomposition, x and b are real vectors.  This
    is "fast-without-any-checks" version of the linear LU-based solver. Slower
    but more robust version is RMatrixLUSolve() function.

    Algorithm features:
    * O(N^2) complexity
    * fast algorithm without ANY additional checks, just triangular solver

    INPUT PARAMETERS
        LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
        P       -   array[0..N-1], pivots array, RMatrixLU result
        N       -   size of A
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        B       -   array[N]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or exactly singular system


      -- ALGLIB --
         Copyright 18.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static bool rmatrixlusolvefast(double[,] lua, int[] p, int n, double[] b)
    {
    
        return directdensesolvers.rmatrixlusolvefast(lua, p, n, b, null);
    }
    
    public static bool rmatrixlusolvefast(double[,] lua, int[] p, int n, double[] b, alglib.xparams _params)
    {
    
        return directdensesolvers.rmatrixlusolvefast(lua, p, n, b, _params);
    }
            
    public static bool rmatrixlusolvefast(double[,] lua, int[] p, double[] b)
    {
        int n;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)))
            throw new alglibexception("Error while calling 'rmatrixlusolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(lua);
        bool result = directdensesolvers.rmatrixlusolvefast(lua, p, n, b, null);
    
        return result;
    }
            
    public static bool rmatrixlusolvefast(double[,] lua, int[] p, double[] b, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)))
            throw new alglibexception("Error while calling 'rmatrixlusolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(lua);
        bool result = directdensesolvers.rmatrixlusolvefast(lua, p, n, b, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver.

    Similar to RMatrixLUSolve() but solves  task  with  multiple  right  parts
    (where b and x are NxM matrices). This  is  "robust-but-slow"  version  of
    LU-based solver which performs additional  checks  for  non-degeneracy  of
    inputs (condition number estimation). If you need  best  performance,  use
    "fast-without-any-checks" version, RMatrixLUSolveMFast().

    Algorithm features:
    * automatic detection of degenerate cases
    * O(M*N^2) complexity
    * condition number estimation

    No iterative refinement  is provided because exact form of original matrix
    is not known to subroutine. Use RMatrixSolve or RMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which  results  in  significant  performance   penalty   when
               ! compared with "fast"  version  which  just  calls  triangular
               ! solver.
               !
               ! This performance penalty is especially apparent when you  use
               ! ALGLIB parallel capabilities (condition number estimation  is
               ! inherently  sequential).  It   also   becomes significant for
               ! small-scale problems.
               !
               ! In such cases we strongly recommend you to use faster solver,
               ! RMatrixLUSolveMFast() function.

    INPUT PARAMETERS
        LUA     -   array[N,N], LU decomposition, RMatrixLU result
        P       -   array[N], pivots array, RMatrixLU result
        N       -   size of A
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned matrix
                    * rep.r1                condition number in 1-norm
                    * rep.rinf              condition number in inf-norm
        X       -   array[N,M], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void rmatrixlusolvem(double[,] lua, int[] p, int n, double[,] b, int m, out double[,] x, out densesolverreport rep)
    {
        x = new double[0,0];
        rep = new densesolverreport();
        directdensesolvers.rmatrixlusolvem(lua, p, n, b, m, ref x, rep.innerobj, null);
    }
    
    public static void rmatrixlusolvem(double[,] lua, int[] p, int n, double[,] b, int m, out double[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new double[0,0];
        rep = new densesolverreport();
        directdensesolvers.rmatrixlusolvem(lua, p, n, b, m, ref x, rep.innerobj, _params);
    }
            
    public static void rmatrixlusolvem(double[,] lua, int[] p, double[,] b, out double[,] x, out densesolverreport rep)
    {
        int n;
        int m;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)) || (ap.rows(lua)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'rmatrixlusolvem': looks like one of arguments has wrong size");
        x = new double[0,0];
        rep = new densesolverreport();
        n = ap.rows(lua);
        m = ap.cols(b);
        directdensesolvers.rmatrixlusolvem(lua, p, n, b, m, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void rmatrixlusolvem(double[,] lua, int[] p, double[,] b, out double[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)) || (ap.rows(lua)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'rmatrixlusolvem': looks like one of arguments has wrong size");
        x = new double[0,0];
        rep = new densesolverreport();
        n = ap.rows(lua);
        m = ap.cols(b);
        directdensesolvers.rmatrixlusolvem(lua, p, n, b, m, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver.

    Similar to RMatrixLUSolve() but solves  task  with  multiple  right parts,
    where b and x are NxM matrices.  This is "fast-without-any-checks" version
    of LU-based solver. It does not estimate  condition number  of  a  system,
    so it is extremely fast. If you need better detection  of  near-degenerate
    cases, use RMatrixLUSolveM() function.

    Algorithm features:
    * O(M*N^2) complexity
    * fast algorithm without ANY additional checks, just triangular solver

    INPUT PARAMETERS:
        LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
        P       -   array[0..N-1], pivots array, RMatrixLU result
        N       -   size of A
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS:
        B       -   array[N,M]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or exactly singular system

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 18.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static bool rmatrixlusolvemfast(double[,] lua, int[] p, int n, double[,] b, int m)
    {
    
        return directdensesolvers.rmatrixlusolvemfast(lua, p, n, b, m, null);
    }
    
    public static bool rmatrixlusolvemfast(double[,] lua, int[] p, int n, double[,] b, int m, alglib.xparams _params)
    {
    
        return directdensesolvers.rmatrixlusolvemfast(lua, p, n, b, m, _params);
    }
            
    public static bool rmatrixlusolvemfast(double[,] lua, int[] p, double[,] b)
    {
        int n;
        int m;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)) || (ap.rows(lua)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'rmatrixlusolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(lua);
        m = ap.cols(b);
        bool result = directdensesolvers.rmatrixlusolvemfast(lua, p, n, b, m, null);
    
        return result;
    }
            
    public static bool rmatrixlusolvemfast(double[,] lua, int[] p, double[,] b, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)) || (ap.rows(lua)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'rmatrixlusolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(lua);
        m = ap.cols(b);
        bool result = directdensesolvers.rmatrixlusolvemfast(lua, p, n, b, m, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver.

    This  subroutine  solves  a  system  A*x=b,  where BOTH ORIGINAL A AND ITS
    LU DECOMPOSITION ARE KNOWN. You can use it if for some  reasons  you  have
    both A and its LU decomposition.

    Algorithm features:
    * automatic detection of degenerate cases
    * condition number estimation
    * iterative refinement
    * O(N^2) complexity

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
        P       -   array[0..N-1], pivots array, RMatrixLU result
        N       -   size of A
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void rmatrixmixedsolve(double[,] a, double[,] lua, int[] p, int n, double[] b, out double[] x, out densesolverreport rep)
    {
        x = new double[0];
        rep = new densesolverreport();
        directdensesolvers.rmatrixmixedsolve(a, lua, p, n, b, ref x, rep.innerobj, null);
    }
    
    public static void rmatrixmixedsolve(double[,] a, double[,] lua, int[] p, int n, double[] b, out double[] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new densesolverreport();
        directdensesolvers.rmatrixmixedsolve(a, lua, p, n, b, ref x, rep.innerobj, _params);
    }
            
    public static void rmatrixmixedsolve(double[,] a, double[,] lua, int[] p, double[] b, out double[] x, out densesolverreport rep)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(lua)) || (ap.rows(a)!=ap.cols(lua)) || (ap.rows(a)!=ap.len(p)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'rmatrixmixedsolve': looks like one of arguments has wrong size");
        x = new double[0];
        rep = new densesolverreport();
        n = ap.rows(a);
        directdensesolvers.rmatrixmixedsolve(a, lua, p, n, b, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void rmatrixmixedsolve(double[,] a, double[,] lua, int[] p, double[] b, out double[] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(lua)) || (ap.rows(a)!=ap.cols(lua)) || (ap.rows(a)!=ap.len(p)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'rmatrixmixedsolve': looks like one of arguments has wrong size");
        x = new double[0];
        rep = new densesolverreport();
        n = ap.rows(a);
        directdensesolvers.rmatrixmixedsolve(a, lua, p, n, b, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver.

    Similar to RMatrixMixedSolve() but  solves task with multiple right  parts
    (where b and x are NxM matrices).

    Algorithm features:
    * automatic detection of degenerate cases
    * condition number estimation
    * iterative refinement
    * O(M*N^2) complexity

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
        P       -   array[0..N-1], pivots array, RMatrixLU result
        N       -   size of A
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N,M], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void rmatrixmixedsolvem(double[,] a, double[,] lua, int[] p, int n, double[,] b, int m, out double[,] x, out densesolverreport rep)
    {
        x = new double[0,0];
        rep = new densesolverreport();
        directdensesolvers.rmatrixmixedsolvem(a, lua, p, n, b, m, ref x, rep.innerobj, null);
    }
    
    public static void rmatrixmixedsolvem(double[,] a, double[,] lua, int[] p, int n, double[,] b, int m, out double[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new double[0,0];
        rep = new densesolverreport();
        directdensesolvers.rmatrixmixedsolvem(a, lua, p, n, b, m, ref x, rep.innerobj, _params);
    }
            
    public static void rmatrixmixedsolvem(double[,] a, double[,] lua, int[] p, double[,] b, out double[,] x, out densesolverreport rep)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(lua)) || (ap.rows(a)!=ap.cols(lua)) || (ap.rows(a)!=ap.len(p)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'rmatrixmixedsolvem': looks like one of arguments has wrong size");
        x = new double[0,0];
        rep = new densesolverreport();
        n = ap.rows(a);
        m = ap.cols(b);
        directdensesolvers.rmatrixmixedsolvem(a, lua, p, n, b, m, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void rmatrixmixedsolvem(double[,] a, double[,] lua, int[] p, double[,] b, out double[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(lua)) || (ap.rows(a)!=ap.cols(lua)) || (ap.rows(a)!=ap.len(p)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'rmatrixmixedsolvem': looks like one of arguments has wrong size");
        x = new double[0,0];
        rep = new densesolverreport();
        n = ap.rows(a);
        m = ap.cols(b);
        directdensesolvers.rmatrixmixedsolvem(a, lua, p, n, b, m, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Complex dense solver for A*X=B with N*N  complex  matrix  A,  N*M  complex
    matrices  X  and  B.  "Slow-but-feature-rich"   version   which   provides
    additional functions, at the cost of slower  performance.  Faster  version
    may be invoked with CMatrixSolveMFast() function.

    Algorithm features:
    * automatic detection of degenerate cases
    * condition number estimation
    * iterative refinement
    * O(N^3+M*N^2) complexity

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear  system
               ! and  performs  iterative   refinement,   which   results   in
               ! significant performance penalty  when  compared  with  "fast"
               ! version  which  just  performs  LU  decomposition  and  calls
               ! triangular solver.
               !
               ! This  performance  penalty  is  especially  visible  in   the
               ! multithreaded mode, because both condition number  estimation
               ! and   iterative    refinement   are   inherently   sequential
               ! calculations.
               !
               ! Thus, if you need high performance and if you are pretty sure
               ! that your system is well conditioned, we  strongly  recommend
               ! you to use faster solver, CMatrixSolveMFast() function.

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size
        RFS     -   iterative refinement switch:
                    * True - refinement is used.
                      Less performance, more precision.
                    * False - refinement is not used.
                      More performance, less precision.

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or exactly singular matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N,M], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void cmatrixsolvem(complex[,] a, int n, complex[,] b, int m, bool rfs, out complex[,] x, out densesolverreport rep)
    {
        x = new complex[0,0];
        rep = new densesolverreport();
        directdensesolvers.cmatrixsolvem(a, n, b, m, rfs, ref x, rep.innerobj, null);
    }
    
    public static void cmatrixsolvem(complex[,] a, int n, complex[,] b, int m, bool rfs, out complex[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new complex[0,0];
        rep = new densesolverreport();
        directdensesolvers.cmatrixsolvem(a, n, b, m, rfs, ref x, rep.innerobj, _params);
    }
            
    public static void cmatrixsolvem(complex[,] a, complex[,] b, bool rfs, out complex[,] x, out densesolverreport rep)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'cmatrixsolvem': looks like one of arguments has wrong size");
        x = new complex[0,0];
        rep = new densesolverreport();
        n = ap.rows(a);
        m = ap.cols(b);
        directdensesolvers.cmatrixsolvem(a, n, b, m, rfs, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void cmatrixsolvem(complex[,] a, complex[,] b, bool rfs, out complex[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'cmatrixsolvem': looks like one of arguments has wrong size");
        x = new complex[0,0];
        rep = new densesolverreport();
        n = ap.rows(a);
        m = ap.cols(b);
        directdensesolvers.cmatrixsolvem(a, n, b, m, rfs, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Complex dense solver for A*X=B with N*N  complex  matrix  A,  N*M  complex
    matrices  X  and  B.  "Fast-but-lightweight" version which  provides  just
    triangular solver - and no additional functions like iterative  refinement
    or condition number estimation.

    Algorithm features:
    * O(N^3+M*N^2) complexity
    * no additional time consuming functions

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS:
        B       -   array[N,M]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or exactly singular system

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 16.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static bool cmatrixsolvemfast(complex[,] a, int n, complex[,] b, int m)
    {
    
        return directdensesolvers.cmatrixsolvemfast(a, n, b, m, null);
    }
    
    public static bool cmatrixsolvemfast(complex[,] a, int n, complex[,] b, int m, alglib.xparams _params)
    {
    
        return directdensesolvers.cmatrixsolvemfast(a, n, b, m, _params);
    }
            
    public static bool cmatrixsolvemfast(complex[,] a, complex[,] b)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'cmatrixsolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        m = ap.cols(b);
        bool result = directdensesolvers.cmatrixsolvemfast(a, n, b, m, null);
    
        return result;
    }
            
    public static bool cmatrixsolvemfast(complex[,] a, complex[,] b, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'cmatrixsolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        m = ap.cols(b);
        bool result = directdensesolvers.cmatrixsolvemfast(a, n, b, m, _params);
    
        return result;
    }
    
    /*************************************************************************
    Complex dense solver for A*x=B with N*N complex matrix A and  N*1  complex
    vectors x and b. "Slow-but-feature-rich" version of the solver.

    Algorithm features:
    * automatic detection of degenerate cases
    * condition number estimation
    * iterative refinement
    * O(N^3) complexity

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear  system
               ! and  performs  iterative   refinement,   which   results   in
               ! significant performance penalty  when  compared  with  "fast"
               ! version  which  just  performs  LU  decomposition  and  calls
               ! triangular solver.
               !
               ! This  performance  penalty  is  especially  visible  in   the
               ! multithreaded mode, because both condition number  estimation
               ! and   iterative    refinement   are   inherently   sequential
               ! calculations.
               !
               ! Thus, if you need high performance and if you are pretty sure
               ! that your system is well conditioned, we  strongly  recommend
               ! you to use faster solver, CMatrixSolveFast() function.

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or exactly singular matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void cmatrixsolve(complex[,] a, int n, complex[] b, out complex[] x, out densesolverreport rep)
    {
        x = new complex[0];
        rep = new densesolverreport();
        directdensesolvers.cmatrixsolve(a, n, b, ref x, rep.innerobj, null);
    }
    
    public static void cmatrixsolve(complex[,] a, int n, complex[] b, out complex[] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new complex[0];
        rep = new densesolverreport();
        directdensesolvers.cmatrixsolve(a, n, b, ref x, rep.innerobj, _params);
    }
            
    public static void cmatrixsolve(complex[,] a, complex[] b, out complex[] x, out densesolverreport rep)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'cmatrixsolve': looks like one of arguments has wrong size");
        x = new complex[0];
        rep = new densesolverreport();
        n = ap.rows(a);
        directdensesolvers.cmatrixsolve(a, n, b, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void cmatrixsolve(complex[,] a, complex[] b, out complex[] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'cmatrixsolve': looks like one of arguments has wrong size");
        x = new complex[0];
        rep = new densesolverreport();
        n = ap.rows(a);
        directdensesolvers.cmatrixsolve(a, n, b, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Complex dense solver for A*x=B with N*N complex matrix A and  N*1  complex
    vectors x and b. "Fast-but-lightweight" version of the solver.

    Algorithm features:
    * O(N^3) complexity
    * no additional time consuming features, just triangular solver

    INPUT PARAMETERS:
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS:
        B       -   array[N]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or exactly singular system

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static bool cmatrixsolvefast(complex[,] a, int n, complex[] b)
    {
    
        return directdensesolvers.cmatrixsolvefast(a, n, b, null);
    }
    
    public static bool cmatrixsolvefast(complex[,] a, int n, complex[] b, alglib.xparams _params)
    {
    
        return directdensesolvers.cmatrixsolvefast(a, n, b, _params);
    }
            
    public static bool cmatrixsolvefast(complex[,] a, complex[] b)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'cmatrixsolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        bool result = directdensesolvers.cmatrixsolvefast(a, n, b, null);
    
        return result;
    }
            
    public static bool cmatrixsolvefast(complex[,] a, complex[] b, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'cmatrixsolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        bool result = directdensesolvers.cmatrixsolvefast(a, n, b, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver for A*X=B with N*N complex A given by its  LU  decomposition,
    and N*M matrices X and B (multiple right sides).   "Slow-but-feature-rich"
    version of the solver.

    Algorithm features:
    * automatic detection of degenerate cases
    * O(M*N^2) complexity
    * condition number estimation

    No iterative refinement  is provided because exact form of original matrix
    is not known to subroutine. Use CMatrixSolve or CMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which  results  in  significant  performance   penalty   when
               ! compared with "fast"  version  which  just  calls  triangular
               ! solver.
               !
               ! This performance penalty is especially apparent when you  use
               ! ALGLIB parallel capabilities (condition number estimation  is
               ! inherently  sequential).  It   also   becomes significant for
               ! small-scale problems.
               !
               ! In such cases we strongly recommend you to use faster solver,
               ! CMatrixLUSolveMFast() function.

    INPUT PARAMETERS
        LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
        P       -   array[0..N-1], pivots array, RMatrixLU result
        N       -   size of A
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or exactly singular matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N,M], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void cmatrixlusolvem(complex[,] lua, int[] p, int n, complex[,] b, int m, out complex[,] x, out densesolverreport rep)
    {
        x = new complex[0,0];
        rep = new densesolverreport();
        directdensesolvers.cmatrixlusolvem(lua, p, n, b, m, ref x, rep.innerobj, null);
    }
    
    public static void cmatrixlusolvem(complex[,] lua, int[] p, int n, complex[,] b, int m, out complex[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new complex[0,0];
        rep = new densesolverreport();
        directdensesolvers.cmatrixlusolvem(lua, p, n, b, m, ref x, rep.innerobj, _params);
    }
            
    public static void cmatrixlusolvem(complex[,] lua, int[] p, complex[,] b, out complex[,] x, out densesolverreport rep)
    {
        int n;
        int m;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)) || (ap.rows(lua)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'cmatrixlusolvem': looks like one of arguments has wrong size");
        x = new complex[0,0];
        rep = new densesolverreport();
        n = ap.rows(lua);
        m = ap.cols(b);
        directdensesolvers.cmatrixlusolvem(lua, p, n, b, m, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void cmatrixlusolvem(complex[,] lua, int[] p, complex[,] b, out complex[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)) || (ap.rows(lua)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'cmatrixlusolvem': looks like one of arguments has wrong size");
        x = new complex[0,0];
        rep = new densesolverreport();
        n = ap.rows(lua);
        m = ap.cols(b);
        directdensesolvers.cmatrixlusolvem(lua, p, n, b, m, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver for A*X=B with N*N complex A given by its  LU  decomposition,
    and N*M matrices X and B (multiple  right  sides).  "Fast-but-lightweight"
    version of the solver.

    Algorithm features:
    * O(M*N^2) complexity
    * no additional time-consuming features

    INPUT PARAMETERS
        LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
        P       -   array[0..N-1], pivots array, RMatrixLU result
        N       -   size of A
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        B       -   array[N,M]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or exactly singular system

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static bool cmatrixlusolvemfast(complex[,] lua, int[] p, int n, complex[,] b, int m)
    {
    
        return directdensesolvers.cmatrixlusolvemfast(lua, p, n, b, m, null);
    }
    
    public static bool cmatrixlusolvemfast(complex[,] lua, int[] p, int n, complex[,] b, int m, alglib.xparams _params)
    {
    
        return directdensesolvers.cmatrixlusolvemfast(lua, p, n, b, m, _params);
    }
            
    public static bool cmatrixlusolvemfast(complex[,] lua, int[] p, complex[,] b)
    {
        int n;
        int m;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)) || (ap.rows(lua)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'cmatrixlusolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(lua);
        m = ap.cols(b);
        bool result = directdensesolvers.cmatrixlusolvemfast(lua, p, n, b, m, null);
    
        return result;
    }
            
    public static bool cmatrixlusolvemfast(complex[,] lua, int[] p, complex[,] b, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)) || (ap.rows(lua)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'cmatrixlusolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(lua);
        m = ap.cols(b);
        bool result = directdensesolvers.cmatrixlusolvemfast(lua, p, n, b, m, _params);
    
        return result;
    }
    
    /*************************************************************************
    Complex dense linear solver for A*x=b with complex N*N A  given  by its LU
    decomposition and N*1 vectors x and b. This is  "slow-but-robust"  version
    of  the  complex  linear  solver  with  additional  features   which   add
    significant performance overhead. Faster version  is  CMatrixLUSolveFast()
    function.

    Algorithm features:
    * automatic detection of degenerate cases
    * O(N^2) complexity
    * condition number estimation

    No iterative refinement is provided because exact form of original matrix
    is not known to subroutine. Use CMatrixSolve or CMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which results in 10-15x  performance  penalty  when  compared
               ! with "fast" version which just calls triangular solver.
               !
               ! This performance penalty is insignificant  when compared with
               ! cost of large LU decomposition.  However,  if you  call  this
               ! function many times for the same  left  side,  this  overhead
               ! BECOMES significant. It  also  becomes significant for small-
               ! scale problems.
               !
               ! In such cases we strongly recommend you to use faster solver,
               ! CMatrixLUSolveFast() function.

    INPUT PARAMETERS
        LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
        P       -   array[0..N-1], pivots array, CMatrixLU result
        N       -   size of A
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or exactly singular matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void cmatrixlusolve(complex[,] lua, int[] p, int n, complex[] b, out complex[] x, out densesolverreport rep)
    {
        x = new complex[0];
        rep = new densesolverreport();
        directdensesolvers.cmatrixlusolve(lua, p, n, b, ref x, rep.innerobj, null);
    }
    
    public static void cmatrixlusolve(complex[,] lua, int[] p, int n, complex[] b, out complex[] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new complex[0];
        rep = new densesolverreport();
        directdensesolvers.cmatrixlusolve(lua, p, n, b, ref x, rep.innerobj, _params);
    }
            
    public static void cmatrixlusolve(complex[,] lua, int[] p, complex[] b, out complex[] x, out densesolverreport rep)
    {
        int n;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)) || (ap.rows(lua)!=ap.len(b)))
            throw new alglibexception("Error while calling 'cmatrixlusolve': looks like one of arguments has wrong size");
        x = new complex[0];
        rep = new densesolverreport();
        n = ap.rows(lua);
        directdensesolvers.cmatrixlusolve(lua, p, n, b, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void cmatrixlusolve(complex[,] lua, int[] p, complex[] b, out complex[] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)) || (ap.rows(lua)!=ap.len(b)))
            throw new alglibexception("Error while calling 'cmatrixlusolve': looks like one of arguments has wrong size");
        x = new complex[0];
        rep = new densesolverreport();
        n = ap.rows(lua);
        directdensesolvers.cmatrixlusolve(lua, p, n, b, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Complex dense linear solver for A*x=b with N*N complex A given by  its  LU
    decomposition and N*1 vectors x and b. This is  fast  lightweight  version
    of solver, which is significantly faster than CMatrixLUSolve(),  but  does
    not provide additional information (like condition numbers).

    Algorithm features:
    * O(N^2) complexity
    * no additional time-consuming features, just triangular solver

    INPUT PARAMETERS
        LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
        P       -   array[0..N-1], pivots array, CMatrixLU result
        N       -   size of A
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        B       -   array[N]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    NOTE: unlike  CMatrixLUSolve(),  this   function   does   NOT   check  for
          near-degeneracy of input matrix. It  checks  for  EXACT  degeneracy,
          because this check is easy to do. However,  very  badly  conditioned
          matrices may went unnoticed.


      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static bool cmatrixlusolvefast(complex[,] lua, int[] p, int n, complex[] b)
    {
    
        return directdensesolvers.cmatrixlusolvefast(lua, p, n, b, null);
    }
    
    public static bool cmatrixlusolvefast(complex[,] lua, int[] p, int n, complex[] b, alglib.xparams _params)
    {
    
        return directdensesolvers.cmatrixlusolvefast(lua, p, n, b, _params);
    }
            
    public static bool cmatrixlusolvefast(complex[,] lua, int[] p, complex[] b)
    {
        int n;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)))
            throw new alglibexception("Error while calling 'cmatrixlusolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(lua);
        bool result = directdensesolvers.cmatrixlusolvefast(lua, p, n, b, null);
    
        return result;
    }
            
    public static bool cmatrixlusolvefast(complex[,] lua, int[] p, complex[] b, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(lua)!=ap.cols(lua)) || (ap.rows(lua)!=ap.len(p)))
            throw new alglibexception("Error while calling 'cmatrixlusolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(lua);
        bool result = directdensesolvers.cmatrixlusolvefast(lua, p, n, b, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver. Same as RMatrixMixedSolveM(), but for complex matrices.

    Algorithm features:
    * automatic detection of degenerate cases
    * condition number estimation
    * iterative refinement
    * O(M*N^2) complexity

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
        P       -   array[0..N-1], pivots array, CMatrixLU result
        N       -   size of A
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or exactly singular matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N,M], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void cmatrixmixedsolvem(complex[,] a, complex[,] lua, int[] p, int n, complex[,] b, int m, out complex[,] x, out densesolverreport rep)
    {
        x = new complex[0,0];
        rep = new densesolverreport();
        directdensesolvers.cmatrixmixedsolvem(a, lua, p, n, b, m, ref x, rep.innerobj, null);
    }
    
    public static void cmatrixmixedsolvem(complex[,] a, complex[,] lua, int[] p, int n, complex[,] b, int m, out complex[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new complex[0,0];
        rep = new densesolverreport();
        directdensesolvers.cmatrixmixedsolvem(a, lua, p, n, b, m, ref x, rep.innerobj, _params);
    }
            
    public static void cmatrixmixedsolvem(complex[,] a, complex[,] lua, int[] p, complex[,] b, out complex[,] x, out densesolverreport rep)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(lua)) || (ap.rows(a)!=ap.cols(lua)) || (ap.rows(a)!=ap.len(p)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'cmatrixmixedsolvem': looks like one of arguments has wrong size");
        x = new complex[0,0];
        rep = new densesolverreport();
        n = ap.rows(a);
        m = ap.cols(b);
        directdensesolvers.cmatrixmixedsolvem(a, lua, p, n, b, m, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void cmatrixmixedsolvem(complex[,] a, complex[,] lua, int[] p, complex[,] b, out complex[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(lua)) || (ap.rows(a)!=ap.cols(lua)) || (ap.rows(a)!=ap.len(p)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'cmatrixmixedsolvem': looks like one of arguments has wrong size");
        x = new complex[0,0];
        rep = new densesolverreport();
        n = ap.rows(a);
        m = ap.cols(b);
        directdensesolvers.cmatrixmixedsolvem(a, lua, p, n, b, m, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver. Same as RMatrixMixedSolve(), but for complex matrices.

    Algorithm features:
    * automatic detection of degenerate cases
    * condition number estimation
    * iterative refinement
    * O(N^2) complexity

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
        P       -   array[0..N-1], pivots array, CMatrixLU result
        N       -   size of A
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or exactly singular matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void cmatrixmixedsolve(complex[,] a, complex[,] lua, int[] p, int n, complex[] b, out complex[] x, out densesolverreport rep)
    {
        x = new complex[0];
        rep = new densesolverreport();
        directdensesolvers.cmatrixmixedsolve(a, lua, p, n, b, ref x, rep.innerobj, null);
    }
    
    public static void cmatrixmixedsolve(complex[,] a, complex[,] lua, int[] p, int n, complex[] b, out complex[] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new complex[0];
        rep = new densesolverreport();
        directdensesolvers.cmatrixmixedsolve(a, lua, p, n, b, ref x, rep.innerobj, _params);
    }
            
    public static void cmatrixmixedsolve(complex[,] a, complex[,] lua, int[] p, complex[] b, out complex[] x, out densesolverreport rep)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(lua)) || (ap.rows(a)!=ap.cols(lua)) || (ap.rows(a)!=ap.len(p)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'cmatrixmixedsolve': looks like one of arguments has wrong size");
        x = new complex[0];
        rep = new densesolverreport();
        n = ap.rows(a);
        directdensesolvers.cmatrixmixedsolve(a, lua, p, n, b, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void cmatrixmixedsolve(complex[,] a, complex[,] lua, int[] p, complex[] b, out complex[] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(lua)) || (ap.rows(a)!=ap.cols(lua)) || (ap.rows(a)!=ap.len(p)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'cmatrixmixedsolve': looks like one of arguments has wrong size");
        x = new complex[0];
        rep = new densesolverreport();
        n = ap.rows(a);
        directdensesolvers.cmatrixmixedsolve(a, lua, p, n, b, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver for A*X=B with N*N symmetric positive definite matrix A,  and
    N*M vectors X and B. It is "slow-but-feature-rich" version of the solver.

    Algorithm features:
    * automatic detection of degenerate cases
    * condition number estimation
    * O(N^3+M*N^2) complexity
    * matrix is represented by its upper or lower triangle

    No iterative refinement is provided because such partial representation of
    matrix does not allow efficient calculation of extra-precise  matrix-vector
    products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which  results  in  significant   performance   penalty  when
               ! compared with "fast" version  which  just  performs  Cholesky
               ! decomposition and calls triangular solver.
               !
               ! This  performance  penalty  is  especially  visible  in   the
               ! multithreaded mode, because both condition number  estimation
               ! and   iterative    refinement   are   inherently   sequential
               ! calculations.
               !
               ! Thus, if you need high performance and if you are pretty sure
               ! that your system is well conditioned, we  strongly  recommend
               ! you to use faster solver, SPDMatrixSolveMFast() function.

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        IsUpper -   what half of A is provided
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or indefinite matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N,M], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void spdmatrixsolvem(double[,] a, int n, bool isupper, double[,] b, int m, out double[,] x, out densesolverreport rep)
    {
        x = new double[0,0];
        rep = new densesolverreport();
        directdensesolvers.spdmatrixsolvem(a, n, isupper, b, m, ref x, rep.innerobj, null);
    }
    
    public static void spdmatrixsolvem(double[,] a, int n, bool isupper, double[,] b, int m, out double[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new double[0,0];
        rep = new densesolverreport();
        directdensesolvers.spdmatrixsolvem(a, n, isupper, b, m, ref x, rep.innerobj, _params);
    }
            
    public static void spdmatrixsolvem(double[,] a, bool isupper, double[,] b, out double[,] x, out densesolverreport rep)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'spdmatrixsolvem': looks like one of arguments has wrong size");
        x = new double[0,0];
        rep = new densesolverreport();
        n = ap.rows(a);
        m = ap.cols(b);
        directdensesolvers.spdmatrixsolvem(a, n, isupper, b, m, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void spdmatrixsolvem(double[,] a, bool isupper, double[,] b, out double[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'spdmatrixsolvem': looks like one of arguments has wrong size");
        x = new double[0,0];
        rep = new densesolverreport();
        n = ap.rows(a);
        m = ap.cols(b);
        directdensesolvers.spdmatrixsolvem(a, n, isupper, b, m, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver for A*X=B with N*N symmetric positive definite matrix A,  and
    N*M vectors X and B. It is "fast-but-lightweight" version of the solver.

    Algorithm features:
    * O(N^3+M*N^2) complexity
    * matrix is represented by its upper or lower triangle
    * no additional time consuming features

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        IsUpper -   what half of A is provided
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        B       -   array[N,M], it contains:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or exactly singular system

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 17.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static bool spdmatrixsolvemfast(double[,] a, int n, bool isupper, double[,] b, int m)
    {
    
        return directdensesolvers.spdmatrixsolvemfast(a, n, isupper, b, m, null);
    }
    
    public static bool spdmatrixsolvemfast(double[,] a, int n, bool isupper, double[,] b, int m, alglib.xparams _params)
    {
    
        return directdensesolvers.spdmatrixsolvemfast(a, n, isupper, b, m, _params);
    }
            
    public static bool spdmatrixsolvemfast(double[,] a, bool isupper, double[,] b)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'spdmatrixsolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        m = ap.cols(b);
        bool result = directdensesolvers.spdmatrixsolvemfast(a, n, isupper, b, m, null);
    
        return result;
    }
            
    public static bool spdmatrixsolvemfast(double[,] a, bool isupper, double[,] b, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'spdmatrixsolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        m = ap.cols(b);
        bool result = directdensesolvers.spdmatrixsolvemfast(a, n, isupper, b, m, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense linear solver for A*x=b with N*N real  symmetric  positive  definite
    matrix A,  N*1 vectors x and b.  "Slow-but-feature-rich"  version  of  the
    solver.

    Algorithm features:
    * automatic detection of degenerate cases
    * condition number estimation
    * O(N^3) complexity
    * matrix is represented by its upper or lower triangle

    No iterative refinement is provided because such partial representation of
    matrix does not allow efficient calculation of extra-precise  matrix-vector
    products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which  results  in  significant   performance   penalty  when
               ! compared with "fast" version  which  just  performs  Cholesky
               ! decomposition and calls triangular solver.
               !
               ! This  performance  penalty  is  especially  visible  in   the
               ! multithreaded mode, because both condition number  estimation
               ! and   iterative    refinement   are   inherently   sequential
               ! calculations.
               !
               ! Thus, if you need high performance and if you are pretty sure
               ! that your system is well conditioned, we  strongly  recommend
               ! you to use faster solver, SPDMatrixSolveFast() function.

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        IsUpper -   what half of A is provided
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or indefinite matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void spdmatrixsolve(double[,] a, int n, bool isupper, double[] b, out double[] x, out densesolverreport rep)
    {
        x = new double[0];
        rep = new densesolverreport();
        directdensesolvers.spdmatrixsolve(a, n, isupper, b, ref x, rep.innerobj, null);
    }
    
    public static void spdmatrixsolve(double[,] a, int n, bool isupper, double[] b, out double[] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new densesolverreport();
        directdensesolvers.spdmatrixsolve(a, n, isupper, b, ref x, rep.innerobj, _params);
    }
            
    public static void spdmatrixsolve(double[,] a, bool isupper, double[] b, out double[] x, out densesolverreport rep)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'spdmatrixsolve': looks like one of arguments has wrong size");
        x = new double[0];
        rep = new densesolverreport();
        n = ap.rows(a);
        directdensesolvers.spdmatrixsolve(a, n, isupper, b, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void spdmatrixsolve(double[,] a, bool isupper, double[] b, out double[] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'spdmatrixsolve': looks like one of arguments has wrong size");
        x = new double[0];
        rep = new densesolverreport();
        n = ap.rows(a);
        directdensesolvers.spdmatrixsolve(a, n, isupper, b, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense linear solver for A*x=b with N*N real  symmetric  positive  definite
    matrix A,  N*1 vectors x and  b.  "Fast-but-lightweight"  version  of  the
    solver.

    Algorithm features:
    * O(N^3) complexity
    * matrix is represented by its upper or lower triangle
    * no additional time consuming features like condition number estimation

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        IsUpper -   what half of A is provided
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        B       -   array[N], it contains:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or exactly singular system

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 17.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static bool spdmatrixsolvefast(double[,] a, int n, bool isupper, double[] b)
    {
    
        return directdensesolvers.spdmatrixsolvefast(a, n, isupper, b, null);
    }
    
    public static bool spdmatrixsolvefast(double[,] a, int n, bool isupper, double[] b, alglib.xparams _params)
    {
    
        return directdensesolvers.spdmatrixsolvefast(a, n, isupper, b, _params);
    }
            
    public static bool spdmatrixsolvefast(double[,] a, bool isupper, double[] b)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'spdmatrixsolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        bool result = directdensesolvers.spdmatrixsolvefast(a, n, isupper, b, null);
    
        return result;
    }
            
    public static bool spdmatrixsolvefast(double[,] a, bool isupper, double[] b, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'spdmatrixsolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        bool result = directdensesolvers.spdmatrixsolvefast(a, n, isupper, b, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver for A*X=B with N*N symmetric positive definite matrix A given
    by its Cholesky decomposition, and N*M vectors X and B. It  is  "slow-but-
    feature-rich" version of the solver which estimates  condition  number  of
    the system.

    Algorithm features:
    * automatic detection of degenerate cases
    * O(M*N^2) complexity
    * condition number estimation
    * matrix is represented by its upper or lower triangle

    No iterative refinement is provided because such partial representation of
    matrix does not allow efficient calculation of extra-precise  matrix-vector
    products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which  results  in  significant  performance   penalty   when
               ! compared with "fast"  version  which  just  calls  triangular
               ! solver. Amount of  overhead  introduced  depends  on  M  (the
               ! larger - the more efficient).
               !
               ! This performance penalty is insignificant  when compared with
               ! cost of large LU decomposition.  However,  if you  call  this
               ! function many times for the same  left  side,  this  overhead
               ! BECOMES significant. It  also  becomes significant for small-
               ! scale problems (N<50).
               !
               ! In such cases we strongly recommend you to use faster solver,
               ! SPDMatrixCholeskySolveMFast() function.

    INPUT PARAMETERS
        CHA     -   array[0..N-1,0..N-1], Cholesky decomposition,
                    SPDMatrixCholesky result
        N       -   size of CHA
        IsUpper -   what half of CHA is provided
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or indefinite matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N]:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void spdmatrixcholeskysolvem(double[,] cha, int n, bool isupper, double[,] b, int m, out double[,] x, out densesolverreport rep)
    {
        x = new double[0,0];
        rep = new densesolverreport();
        directdensesolvers.spdmatrixcholeskysolvem(cha, n, isupper, b, m, ref x, rep.innerobj, null);
    }
    
    public static void spdmatrixcholeskysolvem(double[,] cha, int n, bool isupper, double[,] b, int m, out double[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new double[0,0];
        rep = new densesolverreport();
        directdensesolvers.spdmatrixcholeskysolvem(cha, n, isupper, b, m, ref x, rep.innerobj, _params);
    }
            
    public static void spdmatrixcholeskysolvem(double[,] cha, bool isupper, double[,] b, out double[,] x, out densesolverreport rep)
    {
        int n;
        int m;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'spdmatrixcholeskysolvem': looks like one of arguments has wrong size");
        x = new double[0,0];
        rep = new densesolverreport();
        n = ap.rows(cha);
        m = ap.cols(b);
        directdensesolvers.spdmatrixcholeskysolvem(cha, n, isupper, b, m, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void spdmatrixcholeskysolvem(double[,] cha, bool isupper, double[,] b, out double[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'spdmatrixcholeskysolvem': looks like one of arguments has wrong size");
        x = new double[0,0];
        rep = new densesolverreport();
        n = ap.rows(cha);
        m = ap.cols(b);
        directdensesolvers.spdmatrixcholeskysolvem(cha, n, isupper, b, m, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver for A*X=B with N*N symmetric positive definite matrix A given
    by its Cholesky decomposition, and N*M vectors X and B. It  is  "fast-but-
    lightweight" version of  the  solver  which  just  solves  linear  system,
    without any additional functions.

    Algorithm features:
    * O(M*N^2) complexity
    * matrix is represented by its upper or lower triangle
    * no additional functionality

    INPUT PARAMETERS
        CHA     -   array[N,N], Cholesky decomposition,
                    SPDMatrixCholesky result
        N       -   size of CHA
        IsUpper -   what half of CHA is provided
        B       -   array[N,M], right part
        M       -   right part size

    OUTPUT PARAMETERS
        B       -   array[N]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or exactly singular system

      -- ALGLIB --
         Copyright 18.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static bool spdmatrixcholeskysolvemfast(double[,] cha, int n, bool isupper, double[,] b, int m)
    {
    
        return directdensesolvers.spdmatrixcholeskysolvemfast(cha, n, isupper, b, m, null);
    }
    
    public static bool spdmatrixcholeskysolvemfast(double[,] cha, int n, bool isupper, double[,] b, int m, alglib.xparams _params)
    {
    
        return directdensesolvers.spdmatrixcholeskysolvemfast(cha, n, isupper, b, m, _params);
    }
            
    public static bool spdmatrixcholeskysolvemfast(double[,] cha, bool isupper, double[,] b)
    {
        int n;
        int m;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'spdmatrixcholeskysolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(cha);
        m = ap.cols(b);
        bool result = directdensesolvers.spdmatrixcholeskysolvemfast(cha, n, isupper, b, m, null);
    
        return result;
    }
            
    public static bool spdmatrixcholeskysolvemfast(double[,] cha, bool isupper, double[,] b, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'spdmatrixcholeskysolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(cha);
        m = ap.cols(b);
        bool result = directdensesolvers.spdmatrixcholeskysolvemfast(cha, n, isupper, b, m, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver for A*x=b with N*N symmetric positive definite matrix A given
    by its Cholesky decomposition, and N*1 real vectors x and b. This is "slow-
    but-feature-rich"  version  of  the  solver  which,  in  addition  to  the
    solution, performs condition number estimation.

    Algorithm features:
    * automatic detection of degenerate cases
    * O(N^2) complexity
    * condition number estimation
    * matrix is represented by its upper or lower triangle

    No iterative refinement is provided because such partial representation of
    matrix does not allow efficient calculation of extra-precise  matrix-vector
    products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which results in 10-15x  performance  penalty  when  compared
               ! with "fast" version which just calls triangular solver.
               !
               ! This performance penalty is insignificant  when compared with
               ! cost of large LU decomposition.  However,  if you  call  this
               ! function many times for the same  left  side,  this  overhead
               ! BECOMES significant. It  also  becomes significant for small-
               ! scale problems (N<50).
               !
               ! In such cases we strongly recommend you to use faster solver,
               ! SPDMatrixCholeskySolveFast() function.

    INPUT PARAMETERS
        CHA     -   array[N,N], Cholesky decomposition,
                    SPDMatrixCholesky result
        N       -   size of A
        IsUpper -   what half of CHA is provided
        B       -   array[N], right part

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or indefinite matrix
                    * rep.r1    condition number in 1-norm
                    * rep.rinf  condition number in inf-norm
        X       -   array[N]:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void spdmatrixcholeskysolve(double[,] cha, int n, bool isupper, double[] b, out double[] x, out densesolverreport rep)
    {
        x = new double[0];
        rep = new densesolverreport();
        directdensesolvers.spdmatrixcholeskysolve(cha, n, isupper, b, ref x, rep.innerobj, null);
    }
    
    public static void spdmatrixcholeskysolve(double[,] cha, int n, bool isupper, double[] b, out double[] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new densesolverreport();
        directdensesolvers.spdmatrixcholeskysolve(cha, n, isupper, b, ref x, rep.innerobj, _params);
    }
            
    public static void spdmatrixcholeskysolve(double[,] cha, bool isupper, double[] b, out double[] x, out densesolverreport rep)
    {
        int n;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.len(b)))
            throw new alglibexception("Error while calling 'spdmatrixcholeskysolve': looks like one of arguments has wrong size");
        x = new double[0];
        rep = new densesolverreport();
        n = ap.rows(cha);
        directdensesolvers.spdmatrixcholeskysolve(cha, n, isupper, b, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void spdmatrixcholeskysolve(double[,] cha, bool isupper, double[] b, out double[] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.len(b)))
            throw new alglibexception("Error while calling 'spdmatrixcholeskysolve': looks like one of arguments has wrong size");
        x = new double[0];
        rep = new densesolverreport();
        n = ap.rows(cha);
        directdensesolvers.spdmatrixcholeskysolve(cha, n, isupper, b, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver for A*x=b with N*N symmetric positive definite matrix A given
    by its Cholesky decomposition, and N*1 real vectors x and b. This is "fast-
    but-lightweight" version of the solver.

    Algorithm features:
    * O(N^2) complexity
    * matrix is represented by its upper or lower triangle
    * no additional features

    INPUT PARAMETERS
        CHA     -   array[N,N], Cholesky decomposition,
                    SPDMatrixCholesky result
        N       -   size of A
        IsUpper -   what half of CHA is provided
        B       -   array[N], right part

    OUTPUT PARAMETERS
        B       -   array[N]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or exactly singular system

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static bool spdmatrixcholeskysolvefast(double[,] cha, int n, bool isupper, double[] b)
    {
    
        return directdensesolvers.spdmatrixcholeskysolvefast(cha, n, isupper, b, null);
    }
    
    public static bool spdmatrixcholeskysolvefast(double[,] cha, int n, bool isupper, double[] b, alglib.xparams _params)
    {
    
        return directdensesolvers.spdmatrixcholeskysolvefast(cha, n, isupper, b, _params);
    }
            
    public static bool spdmatrixcholeskysolvefast(double[,] cha, bool isupper, double[] b)
    {
        int n;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.len(b)))
            throw new alglibexception("Error while calling 'spdmatrixcholeskysolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(cha);
        bool result = directdensesolvers.spdmatrixcholeskysolvefast(cha, n, isupper, b, null);
    
        return result;
    }
            
    public static bool spdmatrixcholeskysolvefast(double[,] cha, bool isupper, double[] b, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.len(b)))
            throw new alglibexception("Error while calling 'spdmatrixcholeskysolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(cha);
        bool result = directdensesolvers.spdmatrixcholeskysolvefast(cha, n, isupper, b, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver for A*X=B, with N*N Hermitian positive definite matrix A  and
    N*M  complex  matrices  X  and  B.  "Slow-but-feature-rich" version of the
    solver.

    Algorithm features:
    * automatic detection of degenerate cases
    * condition number estimation
    * O(N^3+M*N^2) complexity
    * matrix is represented by its upper or lower triangle

    No iterative refinement is provided because such partial representation of
    matrix does not allow efficient calculation of extra-precise  matrix-vector
    products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which  results  in  significant  performance   penalty   when
               ! compared with "fast"  version  which  just  calls  triangular
               ! solver.
               !
               ! This performance penalty is especially apparent when you  use
               ! ALGLIB parallel capabilities (condition number estimation  is
               ! inherently  sequential).  It   also   becomes significant for
               ! small-scale problems (N<100).
               !
               ! In such cases we strongly recommend you to use faster solver,
               ! HPDMatrixSolveMFast() function.

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        IsUpper -   what half of A is provided
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        Rep     -   same as in RMatrixSolve
        X       -   same as in RMatrixSolve

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void hpdmatrixsolvem(complex[,] a, int n, bool isupper, complex[,] b, int m, out complex[,] x, out densesolverreport rep)
    {
        x = new complex[0,0];
        rep = new densesolverreport();
        directdensesolvers.hpdmatrixsolvem(a, n, isupper, b, m, ref x, rep.innerobj, null);
    }
    
    public static void hpdmatrixsolvem(complex[,] a, int n, bool isupper, complex[,] b, int m, out complex[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new complex[0,0];
        rep = new densesolverreport();
        directdensesolvers.hpdmatrixsolvem(a, n, isupper, b, m, ref x, rep.innerobj, _params);
    }
            
    public static void hpdmatrixsolvem(complex[,] a, bool isupper, complex[,] b, out complex[,] x, out densesolverreport rep)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'hpdmatrixsolvem': looks like one of arguments has wrong size");
        x = new complex[0,0];
        rep = new densesolverreport();
        n = ap.rows(a);
        m = ap.cols(b);
        directdensesolvers.hpdmatrixsolvem(a, n, isupper, b, m, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void hpdmatrixsolvem(complex[,] a, bool isupper, complex[,] b, out complex[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'hpdmatrixsolvem': looks like one of arguments has wrong size");
        x = new complex[0,0];
        rep = new densesolverreport();
        n = ap.rows(a);
        m = ap.cols(b);
        directdensesolvers.hpdmatrixsolvem(a, n, isupper, b, m, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver for A*X=B, with N*N Hermitian positive definite matrix A  and
    N*M complex matrices X and B. "Fast-but-lightweight" version of the solver.

    Algorithm features:
    * O(N^3+M*N^2) complexity
    * matrix is represented by its upper or lower triangle
    * no additional time consuming features like condition number estimation

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        IsUpper -   what half of A is provided
        B       -   array[0..N-1,0..M-1], right part
        M       -   right part size

    OUTPUT PARAMETERS
        B       -   array[0..N-1]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or indefinite system

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 17.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static bool hpdmatrixsolvemfast(complex[,] a, int n, bool isupper, complex[,] b, int m)
    {
    
        return directdensesolvers.hpdmatrixsolvemfast(a, n, isupper, b, m, null);
    }
    
    public static bool hpdmatrixsolvemfast(complex[,] a, int n, bool isupper, complex[,] b, int m, alglib.xparams _params)
    {
    
        return directdensesolvers.hpdmatrixsolvemfast(a, n, isupper, b, m, _params);
    }
            
    public static bool hpdmatrixsolvemfast(complex[,] a, bool isupper, complex[,] b)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'hpdmatrixsolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        m = ap.cols(b);
        bool result = directdensesolvers.hpdmatrixsolvemfast(a, n, isupper, b, m, null);
    
        return result;
    }
            
    public static bool hpdmatrixsolvemfast(complex[,] a, bool isupper, complex[,] b, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'hpdmatrixsolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        m = ap.cols(b);
        bool result = directdensesolvers.hpdmatrixsolvemfast(a, n, isupper, b, m, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver for A*x=b, with N*N Hermitian positive definite matrix A, and
    N*1 complex vectors  x  and  b.  "Slow-but-feature-rich"  version  of  the
    solver.

    Algorithm features:
    * automatic detection of degenerate cases
    * condition number estimation
    * O(N^3) complexity
    * matrix is represented by its upper or lower triangle

    No iterative refinement is provided because such partial representation of
    matrix does not allow efficient calculation of extra-precise  matrix-vector
    products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which  results  in  significant   performance   penalty  when
               ! compared with "fast" version  which  just  performs  Cholesky
               ! decomposition and calls triangular solver.
               !
               ! This  performance  penalty  is  especially  visible  in   the
               ! multithreaded mode, because both condition number  estimation
               ! and   iterative    refinement   are   inherently   sequential
               ! calculations.
               !
               ! Thus, if you need high performance and if you are pretty sure
               ! that your system is well conditioned, we  strongly  recommend
               ! you to use faster solver, HPDMatrixSolveFast() function.

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        IsUpper -   what half of A is provided
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        Rep     -   same as in RMatrixSolve
        X       -   same as in RMatrixSolve

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void hpdmatrixsolve(complex[,] a, int n, bool isupper, complex[] b, out complex[] x, out densesolverreport rep)
    {
        x = new complex[0];
        rep = new densesolverreport();
        directdensesolvers.hpdmatrixsolve(a, n, isupper, b, ref x, rep.innerobj, null);
    }
    
    public static void hpdmatrixsolve(complex[,] a, int n, bool isupper, complex[] b, out complex[] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new complex[0];
        rep = new densesolverreport();
        directdensesolvers.hpdmatrixsolve(a, n, isupper, b, ref x, rep.innerobj, _params);
    }
            
    public static void hpdmatrixsolve(complex[,] a, bool isupper, complex[] b, out complex[] x, out densesolverreport rep)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'hpdmatrixsolve': looks like one of arguments has wrong size");
        x = new complex[0];
        rep = new densesolverreport();
        n = ap.rows(a);
        directdensesolvers.hpdmatrixsolve(a, n, isupper, b, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void hpdmatrixsolve(complex[,] a, bool isupper, complex[] b, out complex[] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'hpdmatrixsolve': looks like one of arguments has wrong size");
        x = new complex[0];
        rep = new densesolverreport();
        n = ap.rows(a);
        directdensesolvers.hpdmatrixsolve(a, n, isupper, b, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver for A*x=b, with N*N Hermitian positive definite matrix A, and
    N*1 complex vectors  x  and  b.  "Fast-but-lightweight"  version  of   the
    solver without additional functions.

    Algorithm features:
    * O(N^3) complexity
    * matrix is represented by its upper or lower triangle
    * no additional time consuming functions

    INPUT PARAMETERS
        A       -   array[0..N-1,0..N-1], system matrix
        N       -   size of A
        IsUpper -   what half of A is provided
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        B       -   array[0..N-1]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or indefinite system

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 17.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static bool hpdmatrixsolvefast(complex[,] a, int n, bool isupper, complex[] b)
    {
    
        return directdensesolvers.hpdmatrixsolvefast(a, n, isupper, b, null);
    }
    
    public static bool hpdmatrixsolvefast(complex[,] a, int n, bool isupper, complex[] b, alglib.xparams _params)
    {
    
        return directdensesolvers.hpdmatrixsolvefast(a, n, isupper, b, _params);
    }
            
    public static bool hpdmatrixsolvefast(complex[,] a, bool isupper, complex[] b)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'hpdmatrixsolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        bool result = directdensesolvers.hpdmatrixsolvefast(a, n, isupper, b, null);
    
        return result;
    }
            
    public static bool hpdmatrixsolvefast(complex[,] a, bool isupper, complex[] b, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(a)!=ap.cols(a)) || (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'hpdmatrixsolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(a);
        bool result = directdensesolvers.hpdmatrixsolvefast(a, n, isupper, b, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver for A*X=B with N*N Hermitian positive definite matrix A given
    by its Cholesky decomposition and N*M complex matrices X  and  B.  This is
    "slow-but-feature-rich" version of the solver which, in  addition  to  the
    solution, estimates condition number of the system.

    Algorithm features:
    * automatic detection of degenerate cases
    * O(M*N^2) complexity
    * condition number estimation
    * matrix is represented by its upper or lower triangle

    No iterative refinement is provided because such partial representation of
    matrix does not allow efficient calculation of extra-precise  matrix-vector
    products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which  results  in  significant  performance   penalty   when
               ! compared with "fast"  version  which  just  calls  triangular
               ! solver. Amount of  overhead  introduced  depends  on  M  (the
               ! larger - the more efficient).
               !
               ! This performance penalty is insignificant  when compared with
               ! cost of large Cholesky decomposition.  However,  if  you call
               ! this  function  many  times  for  the same  left  side,  this
               ! overhead BECOMES significant. It  also   becomes  significant
               ! for small-scale problems (N<50).
               !
               ! In such cases we strongly recommend you to use faster solver,
               ! HPDMatrixCholeskySolveMFast() function.


    INPUT PARAMETERS
        CHA     -   array[N,N], Cholesky decomposition,
                    HPDMatrixCholesky result
        N       -   size of CHA
        IsUpper -   what half of CHA is provided
        B       -   array[N,M], right part
        M       -   right part size

    OUTPUT PARAMETERS:
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or indefinite matrix
                    * rep.r1                condition number in 1-norm
                    * rep.rinf              condition number in inf-norm
        X       -   array[N], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void hpdmatrixcholeskysolvem(complex[,] cha, int n, bool isupper, complex[,] b, int m, out complex[,] x, out densesolverreport rep)
    {
        x = new complex[0,0];
        rep = new densesolverreport();
        directdensesolvers.hpdmatrixcholeskysolvem(cha, n, isupper, b, m, ref x, rep.innerobj, null);
    }
    
    public static void hpdmatrixcholeskysolvem(complex[,] cha, int n, bool isupper, complex[,] b, int m, out complex[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new complex[0,0];
        rep = new densesolverreport();
        directdensesolvers.hpdmatrixcholeskysolvem(cha, n, isupper, b, m, ref x, rep.innerobj, _params);
    }
            
    public static void hpdmatrixcholeskysolvem(complex[,] cha, bool isupper, complex[,] b, out complex[,] x, out densesolverreport rep)
    {
        int n;
        int m;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'hpdmatrixcholeskysolvem': looks like one of arguments has wrong size");
        x = new complex[0,0];
        rep = new densesolverreport();
        n = ap.rows(cha);
        m = ap.cols(b);
        directdensesolvers.hpdmatrixcholeskysolvem(cha, n, isupper, b, m, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void hpdmatrixcholeskysolvem(complex[,] cha, bool isupper, complex[,] b, out complex[,] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'hpdmatrixcholeskysolvem': looks like one of arguments has wrong size");
        x = new complex[0,0];
        rep = new densesolverreport();
        n = ap.rows(cha);
        m = ap.cols(b);
        directdensesolvers.hpdmatrixcholeskysolvem(cha, n, isupper, b, m, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver for A*X=B with N*N Hermitian positive definite matrix A given
    by its Cholesky decomposition and N*M complex matrices X  and  B.  This is
    "fast-but-lightweight" version of the solver.

    Algorithm features:
    * O(M*N^2) complexity
    * matrix is represented by its upper or lower triangle
    * no additional time-consuming features

    INPUT PARAMETERS
        CHA     -   array[N,N], Cholesky decomposition,
                    HPDMatrixCholesky result
        N       -   size of CHA
        IsUpper -   what half of CHA is provided
        B       -   array[N,M], right part
        M       -   right part size

    OUTPUT PARAMETERS:
        B       -   array[N]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or indefinite system

      -- ALGLIB --
         Copyright 18.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static bool hpdmatrixcholeskysolvemfast(complex[,] cha, int n, bool isupper, complex[,] b, int m)
    {
    
        return directdensesolvers.hpdmatrixcholeskysolvemfast(cha, n, isupper, b, m, null);
    }
    
    public static bool hpdmatrixcholeskysolvemfast(complex[,] cha, int n, bool isupper, complex[,] b, int m, alglib.xparams _params)
    {
    
        return directdensesolvers.hpdmatrixcholeskysolvemfast(cha, n, isupper, b, m, _params);
    }
            
    public static bool hpdmatrixcholeskysolvemfast(complex[,] cha, bool isupper, complex[,] b)
    {
        int n;
        int m;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'hpdmatrixcholeskysolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(cha);
        m = ap.cols(b);
        bool result = directdensesolvers.hpdmatrixcholeskysolvemfast(cha, n, isupper, b, m, null);
    
        return result;
    }
            
    public static bool hpdmatrixcholeskysolvemfast(complex[,] cha, bool isupper, complex[,] b, alglib.xparams _params)
    {
        int n;
        int m;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.rows(b)))
            throw new alglibexception("Error while calling 'hpdmatrixcholeskysolvemfast': looks like one of arguments has wrong size");
    
        n = ap.rows(cha);
        m = ap.cols(b);
        bool result = directdensesolvers.hpdmatrixcholeskysolvemfast(cha, n, isupper, b, m, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver for A*x=b with N*N Hermitian positive definite matrix A given
    by its Cholesky decomposition, and N*1 complex vectors x and  b.  This  is
    "slow-but-feature-rich" version of the solver  which  estimates  condition
    number of the system.

    Algorithm features:
    * automatic detection of degenerate cases
    * O(N^2) complexity
    * condition number estimation
    * matrix is represented by its upper or lower triangle

    No iterative refinement is provided because such partial representation of
    matrix does not allow efficient calculation of extra-precise  matrix-vector
    products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
    need iterative refinement.

    IMPORTANT: ! this function is NOT the most efficient linear solver provided
               ! by ALGLIB. It estimates condition  number  of  linear system,
               ! which results in 10-15x  performance  penalty  when  compared
               ! with "fast" version which just calls triangular solver.
               !
               ! This performance penalty is insignificant  when compared with
               ! cost of large LU decomposition.  However,  if you  call  this
               ! function many times for the same  left  side,  this  overhead
               ! BECOMES significant. It  also  becomes significant for small-
               ! scale problems (N<50).
               !
               ! In such cases we strongly recommend you to use faster solver,
               ! HPDMatrixCholeskySolveFast() function.

    INPUT PARAMETERS
        CHA     -   array[0..N-1,0..N-1], Cholesky decomposition,
                    SPDMatrixCholesky result
        N       -   size of A
        IsUpper -   what half of CHA is provided
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        Rep     -   additional report, following fields are set:
                    * rep.terminationtype   >0 for success
                                            -3 for badly conditioned or indefinite matrix
                    * rep.r1                condition number in 1-norm
                    * rep.rinf              condition number in inf-norm
        X       -   array[N], it contains:
                    * rep.terminationtype>0  => solution
                    * rep.terminationtype=-3 => filled by zeros

      -- ALGLIB --
         Copyright 27.01.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void hpdmatrixcholeskysolve(complex[,] cha, int n, bool isupper, complex[] b, out complex[] x, out densesolverreport rep)
    {
        x = new complex[0];
        rep = new densesolverreport();
        directdensesolvers.hpdmatrixcholeskysolve(cha, n, isupper, b, ref x, rep.innerobj, null);
    }
    
    public static void hpdmatrixcholeskysolve(complex[,] cha, int n, bool isupper, complex[] b, out complex[] x, out densesolverreport rep, alglib.xparams _params)
    {
        x = new complex[0];
        rep = new densesolverreport();
        directdensesolvers.hpdmatrixcholeskysolve(cha, n, isupper, b, ref x, rep.innerobj, _params);
    }
            
    public static void hpdmatrixcholeskysolve(complex[,] cha, bool isupper, complex[] b, out complex[] x, out densesolverreport rep)
    {
        int n;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.len(b)))
            throw new alglibexception("Error while calling 'hpdmatrixcholeskysolve': looks like one of arguments has wrong size");
        x = new complex[0];
        rep = new densesolverreport();
        n = ap.rows(cha);
        directdensesolvers.hpdmatrixcholeskysolve(cha, n, isupper, b, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void hpdmatrixcholeskysolve(complex[,] cha, bool isupper, complex[] b, out complex[] x, out densesolverreport rep, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.len(b)))
            throw new alglibexception("Error while calling 'hpdmatrixcholeskysolve': looks like one of arguments has wrong size");
        x = new complex[0];
        rep = new densesolverreport();
        n = ap.rows(cha);
        directdensesolvers.hpdmatrixcholeskysolve(cha, n, isupper, b, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Dense solver for A*x=b with N*N Hermitian positive definite matrix A given
    by its Cholesky decomposition, and N*1 complex vectors x and  b.  This  is
    "fast-but-lightweight" version of the solver.

    Algorithm features:
    * O(N^2) complexity
    * matrix is represented by its upper or lower triangle
    * no additional time-consuming features

    INPUT PARAMETERS
        CHA     -   array[0..N-1,0..N-1], Cholesky decomposition,
                    SPDMatrixCholesky result
        N       -   size of A
        IsUpper -   what half of CHA is provided
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        B       -   array[N]:
                    * result=true    =>  overwritten by solution
                    * result=false   =>  filled by zeros

    RETURNS:
        True, if the system was solved
        False, for an extremely badly conditioned or indefinite system

      -- ALGLIB --
         Copyright 18.03.2015 by Bochkanov Sergey
    *************************************************************************/
    public static bool hpdmatrixcholeskysolvefast(complex[,] cha, int n, bool isupper, complex[] b)
    {
    
        return directdensesolvers.hpdmatrixcholeskysolvefast(cha, n, isupper, b, null);
    }
    
    public static bool hpdmatrixcholeskysolvefast(complex[,] cha, int n, bool isupper, complex[] b, alglib.xparams _params)
    {
    
        return directdensesolvers.hpdmatrixcholeskysolvefast(cha, n, isupper, b, _params);
    }
            
    public static bool hpdmatrixcholeskysolvefast(complex[,] cha, bool isupper, complex[] b)
    {
        int n;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.len(b)))
            throw new alglibexception("Error while calling 'hpdmatrixcholeskysolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(cha);
        bool result = directdensesolvers.hpdmatrixcholeskysolvefast(cha, n, isupper, b, null);
    
        return result;
    }
            
    public static bool hpdmatrixcholeskysolvefast(complex[,] cha, bool isupper, complex[] b, alglib.xparams _params)
    {
        int n;
        if( (ap.rows(cha)!=ap.cols(cha)) || (ap.rows(cha)!=ap.len(b)))
            throw new alglibexception("Error while calling 'hpdmatrixcholeskysolvefast': looks like one of arguments has wrong size");
    
        n = ap.rows(cha);
        bool result = directdensesolvers.hpdmatrixcholeskysolvefast(cha, n, isupper, b, _params);
    
        return result;
    }
    
    /*************************************************************************
    Dense solver.

    This subroutine finds solution of the linear system A*X=B with non-square,
    possibly degenerate A.  System  is  solved in the least squares sense, and
    general least squares solution  X = X0 + CX*y  which  minimizes |A*X-B| is
    returned. If A is non-degenerate, solution in the usual sense is returned.

    Algorithm features:
    * automatic detection (and correct handling!) of degenerate cases
    * iterative refinement
    * O(N^3) complexity

    INPUT PARAMETERS
        A       -   array[0..NRows-1,0..NCols-1], system matrix
        NRows   -   vertical size of A
        NCols   -   horizontal size of A
        B       -   array[0..NCols-1], right part
        Threshold-  a number in [0,1]. Singular values  beyond  Threshold*Largest are
                    considered  zero.  Set  it to 0.0, if you don't understand
                    what it means, so the solver will choose good value on its
                    own.

    OUTPUT PARAMETERS
        Rep     -   solver report, see below for more info
        X       -   array[0..N-1,0..M-1], it contains:
                    * solution of A*X=B (even for singular A)
                    * zeros, if SVD subroutine failed

    SOLVER REPORT

    Subroutine sets following fields of the Rep structure:
    * TerminationType is set to:
                * -4 for SVD failure
                * >0 for success
    * R2        reciprocal of condition number: 1/cond(A), 2-norm.
    * N         = NCols
    * K         dim(Null(A))
    * CX        array[0..N-1,0..K-1], kernel of A.
                Columns of CX store such vectors that A*CX[i]=0.

      ! FREE EDITION OF ALGLIB:
      !
      ! Free Edition of ALGLIB supports following important features for  this
      ! function:
      ! * C++ version: x64 SIMD support using C++ intrinsics
      ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
      !
      ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
      ! Reference Manual in order  to  find  out  how to activate SIMD support
      ! in ALGLIB.

      ! COMMERCIAL EDITION OF ALGLIB:
      !
      ! Commercial Edition of ALGLIB includes following important improvements
      ! of this function:
      ! * high-performance native backend with same C# interface (C# version)
      ! * multithreading support (C++ and C# versions)
      ! * hardware vendor (Intel) implementations of linear algebra primitives
      !   (C++ and C# versions, x86/x64 platform)
      !
      ! We recommend you to read 'Working with commercial version' section  of
      ! ALGLIB Reference Manual in order to find out how to  use  performance-
      ! related features provided by commercial edition of ALGLIB.

      -- ALGLIB --
         Copyright 24.08.2009 by Bochkanov Sergey
    *************************************************************************/
    public static void rmatrixsolvels(double[,] a, int nrows, int ncols, double[] b, double threshold, out double[] x, out densesolverlsreport rep)
    {
        x = new double[0];
        rep = new densesolverlsreport();
        directdensesolvers.rmatrixsolvels(a, nrows, ncols, b, threshold, ref x, rep.innerobj, null);
    }
    
    public static void rmatrixsolvels(double[,] a, int nrows, int ncols, double[] b, double threshold, out double[] x, out densesolverlsreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new densesolverlsreport();
        directdensesolvers.rmatrixsolvels(a, nrows, ncols, b, threshold, ref x, rep.innerobj, _params);
    }
            
    public static void rmatrixsolvels(double[,] a, double[] b, double threshold, out double[] x, out densesolverlsreport rep)
    {
        int nrows;
        int ncols;
        if( (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'rmatrixsolvels': looks like one of arguments has wrong size");
        x = new double[0];
        rep = new densesolverlsreport();
        nrows = ap.rows(a);
        ncols = ap.cols(a);
        directdensesolvers.rmatrixsolvels(a, nrows, ncols, b, threshold, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void rmatrixsolvels(double[,] a, double[] b, double threshold, out double[] x, out densesolverlsreport rep, alglib.xparams _params)
    {
        int nrows;
        int ncols;
        if( (ap.rows(a)!=ap.len(b)))
            throw new alglibexception("Error while calling 'rmatrixsolvels': looks like one of arguments has wrong size");
        x = new double[0];
        rep = new densesolverlsreport();
        nrows = ap.rows(a);
        ncols = ap.cols(a);
        directdensesolvers.rmatrixsolvels(a, nrows, ncols, b, threshold, ref x, rep.innerobj, _params);
    
        return;
    }

}
public partial class alglib
{


    /*************************************************************************
    This structure is a sparse solver report (both direct and iterative solvers
    use this structure).

    Following fields can be accessed by users:
    * TerminationType (specific error codes depend on the solver  being  used,
      with positive values ALWAYS signaling  that something useful is returned
      in X, and negative values ALWAYS meaning critical failures.
    * NMV - number of matrix-vector products performed (0 for direct solvers)
    * IterationsCount - inner iterations count (0 for direct solvers)
    * R2 - squared residual
    *************************************************************************/
    public class sparsesolverreport : alglibobject
    {
        //
        // Public declarations
        //
        public int terminationtype { get { return _innerobj.terminationtype; } set { _innerobj.terminationtype = value; } }
        public int nmv { get { return _innerobj.nmv; } set { _innerobj.nmv = value; } }
        public int iterationscount { get { return _innerobj.iterationscount; } set { _innerobj.iterationscount = value; } }
        public double r2 { get { return _innerobj.r2; } set { _innerobj.r2 = value; } }
    
        public sparsesolverreport()
        {
            _innerobj = new iterativesparse.sparsesolverreport();
        }
        
        public override alglib.alglibobject make_copy()
        {
            return new sparsesolverreport((iterativesparse.sparsesolverreport)_innerobj.make_copy());
        }
    
        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private iterativesparse.sparsesolverreport _innerobj;
        public iterativesparse.sparsesolverreport innerobj { get { return _innerobj; } }
        public sparsesolverreport(iterativesparse.sparsesolverreport obj)
        {
            _innerobj = obj;
        }
    }


    /*************************************************************************
    This object stores state of the sparse linear solver object.

    You should use ALGLIB functions to work with this object.
    Never try to access its fields directly!
    *************************************************************************/
    public class sparsesolverstate : alglibobject
    {
        //
        // Public declarations
        //
    
        public sparsesolverstate()
        {
            _innerobj = new iterativesparse.sparsesolverstate();
        }
        
        public override alglib.alglibobject make_copy()
        {
            return new sparsesolverstate((iterativesparse.sparsesolverstate)_innerobj.make_copy());
        }
    
        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private iterativesparse.sparsesolverstate _innerobj;
        public iterativesparse.sparsesolverstate innerobj { get { return _innerobj; } }
        public sparsesolverstate(iterativesparse.sparsesolverstate obj)
        {
            _innerobj = obj;
        }
    }
    
    /*************************************************************************
    Solving sparse symmetric linear system A*x=b using GMRES(k) method. Sparse
    symmetric A is given by its lower or upper triangle.

    NOTE: use SparseSolveGMRES() to solve system with nonsymmetric A.

    This function provides convenience API for an 'expert' interface  provided
    by SparseSolverState class. Use SparseSolver  API  if  you  need  advanced
    functions like providing initial point, using out-of-core API and so on.

    INPUT PARAMETERS:
        A       -   sparse symmetric NxN matrix in any sparse storage  format.
                    Using CRS format is recommended because it avoids internal
                    conversion.
                    An exception will be generated if  A  is  not  NxN  matrix
                    (where  N  is  a  size   specified  during  solver  object
                    creation).
        IsUpper -   whether upper or lower triangle of A is used:
                    * IsUpper=True  => only upper triangle is used and lower
                                       triangle is not referenced at all
                    * IsUpper=False => only lower triangle is used and upper
                                       triangle is not referenced at all
        B       -   right part, array[N]
        K       -   k parameter for  GMRES(k), k>=0.  Zero  value  means  that
                    algorithm will choose it automatically.
        EpsF    -   stopping condition, EpsF>=0. The algorithm will stop  when
                    residual will decrease below EpsF*|B|. Having EpsF=0 means
                    that this stopping condition is ignored.
        MaxIts  -   stopping condition, MaxIts>=0.  The  algorithm  will  stop
                    after performing MaxIts iterations. Zero  value  means  no
                    limit.

    NOTE: having both EpsF=0 and MaxIts=0 means that stopping criteria will be
          chosen automatically.

    OUTPUT PARAMETERS:
        X       -   array[N], the solution
        Rep     -   solution report:
                    * Rep.TerminationType completion code:
                        * -5    CG method was used for a matrix which  is  not
                                positive definite
                        * -4    overflow/underflow during solution
                                (ill conditioned problem)
                        *  1    ||residual||<=EpsF*||b||
                        *  5    MaxIts steps was taken
                        *  7    rounding errors prevent further progress,
                                best point found is returned
                        *  8    the  algorithm  was  terminated   early  with
                                SparseSolverRequestTermination() being called
                                from other thread.
                    * Rep.IterationsCount contains iterations count
                    * Rep.NMV contains number of matrix-vector calculations
                    * Rep.R2 contains squared residual

      -- ALGLIB --
         Copyright 25.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolvesymmetricgmres(sparsematrix a, bool isupper, double[] b, int k, double epsf, int maxits, out double[] x, out sparsesolverreport rep)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        iterativesparse.sparsesolvesymmetricgmres(a.innerobj, isupper, b, k, epsf, maxits, ref x, rep.innerobj, null);
    }
    
    public static void sparsesolvesymmetricgmres(sparsematrix a, bool isupper, double[] b, int k, double epsf, int maxits, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        iterativesparse.sparsesolvesymmetricgmres(a.innerobj, isupper, b, k, epsf, maxits, ref x, rep.innerobj, _params);
    }
    
    /*************************************************************************
    Solving sparse linear system A*x=b using GMRES(k) method.

    This function provides convenience API for an 'expert' interface  provided
    by SparseSolverState class. Use SparseSolver  API  if  you  need  advanced
    functions like providing initial point, using out-of-core API and so on.

    INPUT PARAMETERS:
        A       -   sparse NxN matrix in any sparse storage format. Using  CRS
                    format   is   recommended   because   it  avoids  internal
                    conversion.
                    An exception will be generated if  A  is  not  NxN  matrix
                    (where  N  is  a  size   specified  during  solver  object
                    creation).
        B       -   right part, array[N]
        K       -   k parameter for  GMRES(k), k>=0.  Zero  value  means  that
                    algorithm will choose it automatically.
        EpsF    -   stopping condition, EpsF>=0. The algorithm will stop  when
                    residual will decrease below EpsF*|B|. Having EpsF=0 means
                    that this stopping condition is ignored.
        MaxIts  -   stopping condition, MaxIts>=0.  The  algorithm  will  stop
                    after performing MaxIts iterations. Zero  value  means  no
                    limit.

    NOTE: having both EpsF=0 and MaxIts=0 means that stopping criteria will be
          chosen automatically.

    OUTPUT PARAMETERS:
        X       -   array[N], the solution
        Rep     -   solution report:
                    * Rep.TerminationType completion code:
                        * -5    CG method was used for a matrix which  is  not
                                positive definite
                        * -4    overflow/underflow during solution
                                (ill conditioned problem)
                        *  1    ||residual||<=EpsF*||b||
                        *  5    MaxIts steps was taken
                        *  7    rounding errors prevent further progress,
                                best point found is returned
                        *  8    the  algorithm  was  terminated   early  with
                                SparseSolverRequestTermination() being called
                                from other thread.
                    * Rep.IterationsCount contains iterations count
                    * Rep.NMV contains number of matrix-vector calculations
                    * Rep.R2 contains squared residual

      -- ALGLIB --
         Copyright 25.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolvegmres(sparsematrix a, double[] b, int k, double epsf, int maxits, out double[] x, out sparsesolverreport rep)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        iterativesparse.sparsesolvegmres(a.innerobj, b, k, epsf, maxits, ref x, rep.innerobj, null);
    }
    
    public static void sparsesolvegmres(sparsematrix a, double[] b, int k, double epsf, int maxits, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        iterativesparse.sparsesolvegmres(a.innerobj, b, k, epsf, maxits, ref x, rep.innerobj, _params);
    }
    
    /*************************************************************************
    This function initializes sparse linear iterative solver object.

    This solver can be used  to  solve  nonsymmetric  and  symmetric  positive
    definite NxN (square) linear systems.

    The solver provides  'expert'  API  which  allows  advanced  control  over
    algorithms being used, including ability to get progress report, terminate
    long-running solver from other thread, out-of-core solution and so on.

    NOTE: there are also convenience  functions  that  allows  quick  one-line
          access to the solvers:
          * SparseSolveCG() to solve SPD linear systems
          * SparseSolveGMRES() to solve unsymmetric linear systems.

    NOTE: if you want to solve MxN (rectangular) linear problem  you  may  use
          LinLSQR solver provided by ALGLIB.

    USAGE (A is given by the SparseMatrix structure):

        1. User initializes algorithm state with SparseSolverCreate() call
        2. User  selects   algorithm  with one of the SparseSolverSetAlgo???()
           functions. By default, GMRES(k) is used with automatically chosen k
        3. Optionally, user tunes solver parameters, sets starting point, etc.
        4. Depending on whether system is symmetric or not, user calls:
           * SparseSolverSolveSymmetric() for a  symmetric system given by its
             lower or upper triangle
           * SparseSolverSolve() for a nonsymmetric system or a symmetric  one
             given by the full matrix
        5. User calls SparseSolverResults() to get the solution

        It is possible to call SparseSolverSolve???() again to  solve  another
        task with same dimensionality but different matrix and/or  right  part
        without reinitializing SparseSolverState structure.

    USAGE (out-of-core mode):

        1. User initializes algorithm state with SparseSolverCreate() call
        2. User  selects   algorithm  with one of the SparseSolverSetAlgo???()
           functions. By default, GMRES(k) is used with automatically chosen k
        3. Optionally, user tunes solver parameters, sets starting point, etc.
        4. After that user should work with out-of-core interface  in  a  loop
           like one given below:

            > alglib.sparsesolveroocstart(state)
            > while alglib.sparsesolverooccontinue(state) do
            >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
            >     alglib.sparsesolveroocgetrequestdata(state, out X)
            >     if RequestType=0 then
            >         [calculate  Y=A*X, with X=R^N]
            >     alglib.sparsesolveroocsendresult(state, in Y)
            > alglib.sparsesolveroocstop(state, out X, out Report)

    INPUT PARAMETERS:
        N       -   problem dimensionality (fixed at start-up)

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 24.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolvercreate(int n, out sparsesolverstate state)
    {
        state = new sparsesolverstate();
        iterativesparse.sparsesolvercreate(n, state.innerobj, null);
    }
    
    public static void sparsesolvercreate(int n, out sparsesolverstate state, alglib.xparams _params)
    {
        state = new sparsesolverstate();
        iterativesparse.sparsesolvercreate(n, state.innerobj, _params);
    }
    
    /*************************************************************************
    This function sets the solver algorithm to GMRES(k).

    NOTE: if you do not need advanced functionality of the  SparseSolver  API,
          you   may   use   convenience   functions   SparseSolveGMRES()   and
          SparseSolveSymmetricGMRES().

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state
        K       -   GMRES parameter, K>=0:
                    * recommended values are in 10..100 range
                    * larger values up to N are possible but have little sense
                      - the algorithm will be slower than any dense solver.
                    * values above N are truncated down to N
                    * zero value means that  default  value  is  chosen.  This
                      value is 50 in the current version, but  it  may  change
                      in future ALGLIB releases.

      -- ALGLIB --
         Copyright 24.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolversetalgogmres(sparsesolverstate state, int k)
    {
    
        iterativesparse.sparsesolversetalgogmres(state.innerobj, k, null);
    }
    
    public static void sparsesolversetalgogmres(sparsesolverstate state, int k, alglib.xparams _params)
    {
    
        iterativesparse.sparsesolversetalgogmres(state.innerobj, k, _params);
    }
    
    /*************************************************************************
    This function sets starting point.
    By default, zero starting point is used.

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state
        X       -   starting point, array[N]

    OUTPUT PARAMETERS:
        State   -   new starting point was set

      -- ALGLIB --
         Copyright 24.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolversetstartingpoint(sparsesolverstate state, double[] x)
    {
    
        iterativesparse.sparsesolversetstartingpoint(state.innerobj, x, null);
    }
    
    public static void sparsesolversetstartingpoint(sparsesolverstate state, double[] x, alglib.xparams _params)
    {
    
        iterativesparse.sparsesolversetstartingpoint(state.innerobj, x, _params);
    }
    
    /*************************************************************************
    This function sets stopping criteria.

    INPUT PARAMETERS:
        EpsF    -   algorithm will be stopped if norm of residual is less than
                    EpsF*||b||.
        MaxIts  -   algorithm will be stopped if number of iterations is  more
                    than MaxIts.

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

    NOTES:
    If  both  EpsF  and  MaxIts  are  zero then small EpsF will be set to small
    value.

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolversetcond(sparsesolverstate state, double epsf, int maxits)
    {
    
        iterativesparse.sparsesolversetcond(state.innerobj, epsf, maxits, null);
    }
    
    public static void sparsesolversetcond(sparsesolverstate state, double epsf, int maxits, alglib.xparams _params)
    {
    
        iterativesparse.sparsesolversetcond(state.innerobj, epsf, maxits, _params);
    }
    
    /*************************************************************************
    Procedure for  the  solution of A*x=b with sparse symmetric A given by its
    lower or upper triangle.

    This function will work with any solver algorithm  being   used,  SPD  one
    (like CG) or not (like GMRES). Using unsymmetric solvers (like  GMRES)  on
    SPD problems is suboptimal, but still possible.

    NOTE: the  solver  behavior is ill-defined  for  a  situation  when a  SPD
          solver is used on indefinite matrix. It  may solve the problem up to
          desired precision (sometimes, rarely)  or  return  with  error  code
          signalling violation of underlying assumptions.

    INPUT PARAMETERS:
        State   -   algorithm state
        A       -   sparse symmetric NxN matrix in any sparse storage  format.
                    Using CRS format is recommended because it avoids internal
                    conversion.
                    An exception will be generated if  A  is  not  NxN  matrix
                    (where  N  is  a  size   specified  during  solver  object
                    creation).
        IsUpper -   whether upper or lower triangle of A is used:
                    * IsUpper=True  => only upper triangle is used and lower
                                       triangle is not referenced at all
                    * IsUpper=False => only lower triangle is used and upper
                                       triangle is not referenced at all
        B       -   right part, array[N]

    RESULT:
        This function returns no result.
        You can get the solution by calling SparseSolverResults()

      -- ALGLIB --
         Copyright 25.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolversolvesymmetric(sparsesolverstate state, sparsematrix a, bool isupper, double[] b)
    {
    
        iterativesparse.sparsesolversolvesymmetric(state.innerobj, a.innerobj, isupper, b, null);
    }
    
    public static void sparsesolversolvesymmetric(sparsesolverstate state, sparsematrix a, bool isupper, double[] b, alglib.xparams _params)
    {
    
        iterativesparse.sparsesolversolvesymmetric(state.innerobj, a.innerobj, isupper, b, _params);
    }
    
    /*************************************************************************
    Procedure for the solution of A*x=b with sparse nonsymmetric A

    IMPORTANT: this function will work with any solver algorithm  being  used,
               symmetric solver like CG,  or  not.  However,  using  symmetric
               solvers on nonsymmetric problems is  dangerous.  It  may  solve
               the problem up  to  desired  precision  (sometimes,  rarely) or
               terminate with error code signalling  violation  of  underlying
               assumptions.

    INPUT PARAMETERS:
        State   -   algorithm state
        A       -   sparse NxN matrix in any sparse storage  format.
                    Using CRS format is recommended because it avoids internal
                    conversion.
                    An exception will be generated if  A  is  not  NxN  matrix
                    (where  N  is  a  size   specified  during  solver  object
                    creation).
        B       -   right part, array[N]

    RESULT:
        This function returns no result.
        You can get the solution by calling SparseSolverResults()

      -- ALGLIB --
         Copyright 25.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolversolve(sparsesolverstate state, sparsematrix a, double[] b)
    {
    
        iterativesparse.sparsesolversolve(state.innerobj, a.innerobj, b, null);
    }
    
    public static void sparsesolversolve(sparsesolverstate state, sparsematrix a, double[] b, alglib.xparams _params)
    {
    
        iterativesparse.sparsesolversolve(state.innerobj, a.innerobj, b, _params);
    }
    
    /*************************************************************************
    Sparse solver results.

    This function must be called after calling one of the SparseSolverSolve()
    functions.

    INPUT PARAMETERS:
        State   -   algorithm state

    OUTPUT PARAMETERS:
        X       -   array[N], solution
        Rep     -   solution report:
                    * Rep.TerminationType completion code:
                        * -5    CG method was used for a matrix which  is  not
                                positive definite
                        * -4    overflow/underflow during solution
                                (ill conditioned problem)
                        *  1    ||residual||<=EpsF*||b||
                        *  5    MaxIts steps was taken
                        *  7    rounding errors prevent further progress,
                                best point found is returned
                        *  8    the  algorithm  was  terminated   early  with
                                SparseSolverRequestTermination() being called
                                from other thread.
                    * Rep.IterationsCount contains iterations count
                    * Rep.NMV contains number of matrix-vector calculations
                    * Rep.R2 contains squared residual
    s
      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolverresults(sparsesolverstate state, out double[] x, out sparsesolverreport rep)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        iterativesparse.sparsesolverresults(state.innerobj, ref x, rep.innerobj, null);
    }
    
    public static void sparsesolverresults(sparsesolverstate state, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        iterativesparse.sparsesolverresults(state.innerobj, ref x, rep.innerobj, _params);
    }
    
    /*************************************************************************
    This function turns on/off reporting during out-of-core processing.

    When the solver works in the out-of-core mode, it  can  be  configured  to
    report its progress by returning current location. These location  reports
    are implemented as a special kind of the out-of-core request:
    * SparseSolverOOCGetRequestInfo() returns -1
    * SparseSolverOOCGetRequestData() returns current location
    * SparseSolverOOCGetRequestData1() returns squared norm of the residual
    * SparseSolverOOCSendResult() shall NOT be called

    This function has no effect when SparseSolverSolve() is used because  this
    function has no method of reporting its progress.

    NOTE: when used with GMRES(k), this function reports progress  every  k-th
          iteration.

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state
        NeedXRep-   whether iteration reports are needed or not

      -- ALGLIB --
         Copyright 01.10.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolversetxrep(sparsesolverstate state, bool needxrep)
    {
    
        iterativesparse.sparsesolversetxrep(state.innerobj, needxrep, null);
    }
    
    public static void sparsesolversetxrep(sparsesolverstate state, bool needxrep, alglib.xparams _params)
    {
    
        iterativesparse.sparsesolversetxrep(state.innerobj, needxrep, _params);
    }
    
    /*************************************************************************
    This function initiates out-of-core mode of the sparse solver.  It  should
    be used in conjunction with other out-of-core-related  functions  of  this
    subspackage in a loop like one given below:

    > alglib.sparsesolveroocstart(state)
    > while alglib.sparsesolverooccontinue(state) do
    >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
    >     alglib.sparsesolveroocgetrequestdata(state, out X)
    >     if RequestType=0 then
    >         [calculate  Y=A*X, with X=R^N]
    >     alglib.sparsesolveroocsendresult(state, in Y)
    > alglib.sparsesolveroocstop(state, out X, out Report)

    INPUT PARAMETERS:
        State       -   solver object

      -- ALGLIB --
         Copyright 24.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolveroocstart(sparsesolverstate state, double[] b)
    {
    
        iterativesparse.sparsesolveroocstart(state.innerobj, b, null);
    }
    
    public static void sparsesolveroocstart(sparsesolverstate state, double[] b, alglib.xparams _params)
    {
    
        iterativesparse.sparsesolveroocstart(state.innerobj, b, _params);
    }
    
    /*************************************************************************
    This function performs iterative solution of  the  linear  system  in  the
    out-of-core mode. It should be used in conjunction with other out-of-core-
    related functions of this subspackage in a loop like one given below:

    > alglib.sparsesolveroocstart(state)
    > while alglib.sparsesolverooccontinue(state) do
    >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
    >     alglib.sparsesolveroocgetrequestdata(state, out X)
    >     if RequestType=0 then
    >         [calculate  Y=A*X, with X=R^N]
    >     alglib.sparsesolveroocsendresult(state, in Y)
    > alglib.sparsesolveroocstop(state, out X, out Report)

      -- ALGLIB --
         Copyright 24.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static bool sparsesolverooccontinue(sparsesolverstate state)
    {
    
        return iterativesparse.sparsesolverooccontinue(state.innerobj, null);
    }
    
    public static bool sparsesolverooccontinue(sparsesolverstate state, alglib.xparams _params)
    {
    
        return iterativesparse.sparsesolverooccontinue(state.innerobj, _params);
    }
    
    /*************************************************************************
    This function is used to retrieve information  about  out-of-core  request
    sent by the solver:
    * RequestType=0  means that matrix-vector products A*x is requested
    * RequestType=-1 means that solver reports its progress; this  request  is
      returned only when reports are activated wit SparseSolverSetXRep().

    This function returns just request type; in order  to  get contents of the
    trial vector, use sparsesolveroocgetrequestdata().

    It should be used in conjunction with other out-of-core-related  functions
    of this subspackage in a loop like one given below:

    > alglib.sparsesolveroocstart(state)
    > while alglib.sparsesolverooccontinue(state) do
    >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
    >     alglib.sparsesolveroocgetrequestdata(state, out X)
    >     if RequestType=0 then
    >         [calculate  Y=A*X, with X=R^N]
    >     alglib.sparsesolveroocsendresult(state, in Y)
    > alglib.sparsesolveroocstop(state, out X, out Report)

    INPUT PARAMETERS:
        State           -   solver running in out-of-core mode

    OUTPUT PARAMETERS:
        RequestType     -   type of the request to process:
                            * 0   for matrix-vector product A*x, with A  being
                              NxN system matrix  and X being N-dimensional
                              vector
                            *-1   for location and residual report


      -- ALGLIB --
         Copyright 24.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolveroocgetrequestinfo(sparsesolverstate state, out int requesttype)
    {
        requesttype = 0;
        iterativesparse.sparsesolveroocgetrequestinfo(state.innerobj, ref requesttype, null);
    }
    
    public static void sparsesolveroocgetrequestinfo(sparsesolverstate state, out int requesttype, alglib.xparams _params)
    {
        requesttype = 0;
        iterativesparse.sparsesolveroocgetrequestinfo(state.innerobj, ref requesttype, _params);
    }
    
    /*************************************************************************
    This function is used  to  retrieve  vector  associated  with  out-of-core
    request sent by the solver to user code. Depending  on  the  request  type
    (returned by the SparseSolverOOCGetRequestInfo()) this  vector  should  be
    multiplied by A or subjected to another processing.

    It should be used in conjunction with other out-of-core-related  functions
    of this subspackage in a loop like one given below:

    > alglib.sparsesolveroocstart(state)
    > while alglib.sparsesolverooccontinue(state) do
    >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
    >     alglib.sparsesolveroocgetrequestdata(state, out X)
    >     if RequestType=0 then
    >         [calculate  Y=A*X, with X=R^N]
    >     alglib.sparsesolveroocsendresult(state, in Y)
    > alglib.sparsesolveroocstop(state, out X, out Report)

    INPUT PARAMETERS:
        State           -   solver running in out-of-core mode
        X               -   possibly  preallocated   storage;  reallocated  if
                            needed, left unchanged, if large enough  to  store
                            request data.

    OUTPUT PARAMETERS:
        X               -   array[N] or larger, leading N elements are  filled
                            with vector X.


      -- ALGLIB --
         Copyright 24.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolveroocgetrequestdata(sparsesolverstate state, ref double[] x)
    {
    
        iterativesparse.sparsesolveroocgetrequestdata(state.innerobj, ref x, null);
    }
    
    public static void sparsesolveroocgetrequestdata(sparsesolverstate state, ref double[] x, alglib.xparams _params)
    {
    
        iterativesparse.sparsesolveroocgetrequestdata(state.innerobj, ref x, _params);
    }
    
    /*************************************************************************
    This function is used to retrieve scalar value associated with out-of-core
    request sent by the solver to user code. In  the  current  ALGLIB  version
    this function is used to retrieve squared residual  norm  during  progress
    reports.

    INPUT PARAMETERS:
        State           -   solver running in out-of-core mode

    OUTPUT PARAMETERS:
        V               -   scalar value associated with the current request


      -- ALGLIB --
         Copyright 24.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolveroocgetrequestdata1(sparsesolverstate state, out double v)
    {
        v = 0;
        iterativesparse.sparsesolveroocgetrequestdata1(state.innerobj, ref v, null);
    }
    
    public static void sparsesolveroocgetrequestdata1(sparsesolverstate state, out double v, alglib.xparams _params)
    {
        v = 0;
        iterativesparse.sparsesolveroocgetrequestdata1(state.innerobj, ref v, _params);
    }
    
    /*************************************************************************
    This function is used to send user reply to out-of-core  request  sent  by
    the solver. Usually it is product A*x for vector X returned by the solver.

    It should be used in conjunction with other out-of-core-related  functions
    of this subspackage in a loop like one given below:

    > alglib.sparsesolveroocstart(state)
    > while alglib.sparsesolverooccontinue(state) do
    >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
    >     alglib.sparsesolveroocgetrequestdata(state, out X)
    >     if RequestType=0 then
    >         [calculate  Y=A*X, with X=R^N]
    >     alglib.sparsesolveroocsendresult(state, in Y)
    > alglib.sparsesolveroocstop(state, out X, out Report)

    INPUT PARAMETERS:
        State           -   solver running in out-of-core mode
        AX              -   array[N] or larger, leading N elements contain A*x


      -- ALGLIB --
         Copyright 24.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolveroocsendresult(sparsesolverstate state, double[] ax)
    {
    
        iterativesparse.sparsesolveroocsendresult(state.innerobj, ax, null);
    }
    
    public static void sparsesolveroocsendresult(sparsesolverstate state, double[] ax, alglib.xparams _params)
    {
    
        iterativesparse.sparsesolveroocsendresult(state.innerobj, ax, _params);
    }
    
    /*************************************************************************
    This  function  finalizes out-of-core mode of the linear solver. It should
    be used in conjunction with other out-of-core-related  functions  of  this
    subspackage in a loop like one given below:

    > alglib.sparsesolveroocstart(state)
    > while alglib.sparsesolverooccontinue(state) do
    >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
    >     alglib.sparsesolveroocgetrequestdata(state, out X)
    >     if RequestType=0 then
    >         [calculate  Y=A*X, with X=R^N]
    >     alglib.sparsesolveroocsendresult(state, in Y)
    > alglib.sparsesolveroocstop(state, out X, out Report)

    INPUT PARAMETERS:
        State       -   solver state

    OUTPUT PARAMETERS:
        X       -   array[N], the solution.
                    Zero-filled on the failure (Rep.TerminationType<0).
        Rep     -   report with additional info:
                    * Rep.TerminationType completion code:
                        * -5    CG method was used for a matrix which  is  not
                                positive definite
                        * -4    overflow/underflow during solution
                                (ill conditioned problem)
                        *  1    ||residual||<=EpsF*||b||
                        *  5    MaxIts steps was taken
                        *  7    rounding errors prevent further progress,
                                best point found is returned
                        *  8    the  algorithm  was  terminated   early  with
                                SparseSolverRequestTermination() being called
                                from other thread.
                    * Rep.IterationsCount contains iterations count
                    * Rep.NMV contains number of matrix-vector calculations
                    * Rep.R2 contains squared residual

      -- ALGLIB --
         Copyright 24.09.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolveroocstop(sparsesolverstate state, out double[] x, out sparsesolverreport rep)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        iterativesparse.sparsesolveroocstop(state.innerobj, ref x, rep.innerobj, null);
    }
    
    public static void sparsesolveroocstop(sparsesolverstate state, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        iterativesparse.sparsesolveroocstop(state.innerobj, ref x, rep.innerobj, _params);
    }
    
    /*************************************************************************
    This subroutine submits request for termination of the running solver.  It
    can be called from some other thread which wants the   solver to terminate
    or when processing an out-of-core request.

    As result, solver  stops  at  point  which  was  "current  accepted"  when
    the termination request was submitted and returns error code 8 (successful
    termination).  Such   termination   is  a smooth  process  which  properly
    deallocates all temporaries.

    INPUT PARAMETERS:
        State   -   solver structure

    NOTE: calling this function on solver which is NOT running  will  have  no
          effect.

    NOTE: multiple calls to this function are possible. First call is counted,
          subsequent calls are silently ignored.

    NOTE: solver clears termination flag on its start, it means that  if  some
          other thread will request termination too soon, its request will went
          unnoticed.

      -- ALGLIB --
         Copyright 01.10.2021 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolverrequesttermination(sparsesolverstate state)
    {
    
        iterativesparse.sparsesolverrequesttermination(state.innerobj, null);
    }
    
    public static void sparsesolverrequesttermination(sparsesolverstate state, alglib.xparams _params)
    {
    
        iterativesparse.sparsesolverrequesttermination(state.innerobj, _params);
    }

}
public partial class alglib
{


    /*************************************************************************
    This object stores state of the linear CG method.

    You should use ALGLIB functions to work with this object.
    Never try to access its fields directly!
    *************************************************************************/
    public class lincgstate : alglibobject
    {
        //
        // Public declarations
        //
    
        public lincgstate()
        {
            _innerobj = new lincg.lincgstate();
        }
        
        public override alglib.alglibobject make_copy()
        {
            return new lincgstate((lincg.lincgstate)_innerobj.make_copy());
        }
    
        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private lincg.lincgstate _innerobj;
        public lincg.lincgstate innerobj { get { return _innerobj; } }
        public lincgstate(lincg.lincgstate obj)
        {
            _innerobj = obj;
        }
    }


    /*************************************************************************

    *************************************************************************/
    public class lincgreport : alglibobject
    {
        //
        // Public declarations
        //
        public int iterationscount { get { return _innerobj.iterationscount; } set { _innerobj.iterationscount = value; } }
        public int nmv { get { return _innerobj.nmv; } set { _innerobj.nmv = value; } }
        public int terminationtype { get { return _innerobj.terminationtype; } set { _innerobj.terminationtype = value; } }
        public double r2 { get { return _innerobj.r2; } set { _innerobj.r2 = value; } }
    
        public lincgreport()
        {
            _innerobj = new lincg.lincgreport();
        }
        
        public override alglib.alglibobject make_copy()
        {
            return new lincgreport((lincg.lincgreport)_innerobj.make_copy());
        }
    
        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private lincg.lincgreport _innerobj;
        public lincg.lincgreport innerobj { get { return _innerobj; } }
        public lincgreport(lincg.lincgreport obj)
        {
            _innerobj = obj;
        }
    }
    
    /*************************************************************************
    This function initializes linear CG Solver. This solver is used  to  solve
    symmetric positive definite problems. If you want  to  solve  nonsymmetric
    (or non-positive definite) problem you may use LinLSQR solver provided  by
    ALGLIB.

    USAGE:
    1. User initializes algorithm state with LinCGCreate() call
    2. User tunes solver parameters with  LinCGSetCond() and other functions
    3. Optionally, user sets starting point with LinCGSetStartingPoint()
    4. User  calls LinCGSolveSparse() function which takes algorithm state and
       SparseMatrix object.
    5. User calls LinCGResults() to get solution
    6. Optionally, user may call LinCGSolveSparse()  again  to  solve  another
       problem  with different matrix and/or right part without reinitializing
       LinCGState structure.

    INPUT PARAMETERS:
        N       -   problem dimension, N>0

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgcreate(int n, out lincgstate state)
    {
        state = new lincgstate();
        lincg.lincgcreate(n, state.innerobj, null);
    }
    
    public static void lincgcreate(int n, out lincgstate state, alglib.xparams _params)
    {
        state = new lincgstate();
        lincg.lincgcreate(n, state.innerobj, _params);
    }
    
    /*************************************************************************
    This function sets starting point.
    By default, zero starting point is used.

    INPUT PARAMETERS:
        X       -   starting point, array[N]

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetstartingpoint(lincgstate state, double[] x)
    {
    
        lincg.lincgsetstartingpoint(state.innerobj, x, null);
    }
    
    public static void lincgsetstartingpoint(lincgstate state, double[] x, alglib.xparams _params)
    {
    
        lincg.lincgsetstartingpoint(state.innerobj, x, _params);
    }
    
    /*************************************************************************
    This  function  changes  preconditioning  settings  of  LinCGSolveSparse()
    function. By default, SolveSparse() uses diagonal preconditioner,  but  if
    you want to use solver without preconditioning, you can call this function
    which forces solver to use unit matrix for preconditioning.

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 19.11.2012 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetprecunit(lincgstate state)
    {
    
        lincg.lincgsetprecunit(state.innerobj, null);
    }
    
    public static void lincgsetprecunit(lincgstate state, alglib.xparams _params)
    {
    
        lincg.lincgsetprecunit(state.innerobj, _params);
    }
    
    /*************************************************************************
    This  function  changes  preconditioning  settings  of  LinCGSolveSparse()
    function.  LinCGSolveSparse() will use diagonal of the  system  matrix  as
    preconditioner. This preconditioning mode is active by default.

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 19.11.2012 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetprecdiag(lincgstate state)
    {
    
        lincg.lincgsetprecdiag(state.innerobj, null);
    }
    
    public static void lincgsetprecdiag(lincgstate state, alglib.xparams _params)
    {
    
        lincg.lincgsetprecdiag(state.innerobj, _params);
    }
    
    /*************************************************************************
    This function sets stopping criteria.

    INPUT PARAMETERS:
        EpsF    -   algorithm will be stopped if norm of residual is less than
                    EpsF*||b||.
        MaxIts  -   algorithm will be stopped if number of iterations is  more
                    than MaxIts.

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

    NOTES:
    If  both  EpsF  and  MaxIts  are  zero then small EpsF will be set to small
    value.

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetcond(lincgstate state, double epsf, int maxits)
    {
    
        lincg.lincgsetcond(state.innerobj, epsf, maxits, null);
    }
    
    public static void lincgsetcond(lincgstate state, double epsf, int maxits, alglib.xparams _params)
    {
    
        lincg.lincgsetcond(state.innerobj, epsf, maxits, _params);
    }
    
    /*************************************************************************
    Procedure for solution of A*x=b with sparse A.

    INPUT PARAMETERS:
        State   -   algorithm state
        A       -   sparse matrix in the CRS format (you MUST contvert  it  to
                    CRS format by calling SparseConvertToCRS() function).
        IsUpper -   whether upper or lower triangle of A is used:
                    * IsUpper=True  => only upper triangle is used and lower
                                       triangle is not referenced at all
                    * IsUpper=False => only lower triangle is used and upper
                                       triangle is not referenced at all
        B       -   right part, array[N]

    RESULT:
        This function returns no result.
        You can get solution by calling LinCGResults()

    NOTE: this function uses lightweight preconditioning -  multiplication  by
          inverse of diag(A). If you want, you can turn preconditioning off by
          calling LinCGSetPrecUnit(). However, preconditioning cost is low and
          preconditioner  is  very  important  for  solution  of  badly scaled
          problems.

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsolvesparse(lincgstate state, sparsematrix a, bool isupper, double[] b)
    {
    
        lincg.lincgsolvesparse(state.innerobj, a.innerobj, isupper, b, null);
    }
    
    public static void lincgsolvesparse(lincgstate state, sparsematrix a, bool isupper, double[] b, alglib.xparams _params)
    {
    
        lincg.lincgsolvesparse(state.innerobj, a.innerobj, isupper, b, _params);
    }
    
    /*************************************************************************
    CG-solver: results.

    This function must be called after LinCGSolve

    INPUT PARAMETERS:
        State   -   algorithm state

    OUTPUT PARAMETERS:
        X       -   array[N], solution
        Rep     -   optimization report:
                    * Rep.TerminationType completetion code:
                        * -5    input matrix is either not positive definite,
                                too large or too small
                        * -4    overflow/underflow during solution
                                (ill conditioned problem)
                        *  1    ||residual||<=EpsF*||b||
                        *  5    MaxIts steps was taken
                        *  7    rounding errors prevent further progress,
                                best point found is returned
                    * Rep.IterationsCount contains iterations count
                    * NMV countains number of matrix-vector calculations

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgresults(lincgstate state, out double[] x, out lincgreport rep)
    {
        x = new double[0];
        rep = new lincgreport();
        lincg.lincgresults(state.innerobj, ref x, rep.innerobj, null);
    }
    
    public static void lincgresults(lincgstate state, out double[] x, out lincgreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new lincgreport();
        lincg.lincgresults(state.innerobj, ref x, rep.innerobj, _params);
    }
    
    /*************************************************************************
    This function sets restart frequency. By default, algorithm  is  restarted
    after N subsequent iterations.

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetrestartfreq(lincgstate state, int srf)
    {
    
        lincg.lincgsetrestartfreq(state.innerobj, srf, null);
    }
    
    public static void lincgsetrestartfreq(lincgstate state, int srf, alglib.xparams _params)
    {
    
        lincg.lincgsetrestartfreq(state.innerobj, srf, _params);
    }
    
    /*************************************************************************
    This function sets frequency of residual recalculations.

    Algorithm updates residual r_k using iterative formula,  but  recalculates
    it from scratch after each 10 iterations. It is done to avoid accumulation
    of numerical errors and to stop algorithm when r_k starts to grow.

    Such low update frequence (1/10) gives very  little  overhead,  but  makes
    algorithm a bit more robust against numerical errors. However, you may
    change it

    INPUT PARAMETERS:
        Freq    -   desired update frequency, Freq>=0.
                    Zero value means that no updates will be done.

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetrupdatefreq(lincgstate state, int freq)
    {
    
        lincg.lincgsetrupdatefreq(state.innerobj, freq, null);
    }
    
    public static void lincgsetrupdatefreq(lincgstate state, int freq, alglib.xparams _params)
    {
    
        lincg.lincgsetrupdatefreq(state.innerobj, freq, _params);
    }
    
    /*************************************************************************
    This function turns on/off reporting.

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state
        NeedXRep-   whether iteration reports are needed or not

    If NeedXRep is True, algorithm will call rep() callback function if  it is
    provided to MinCGOptimize().

      -- ALGLIB --
         Copyright 14.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void lincgsetxrep(lincgstate state, bool needxrep)
    {
    
        lincg.lincgsetxrep(state.innerobj, needxrep, null);
    }
    
    public static void lincgsetxrep(lincgstate state, bool needxrep, alglib.xparams _params)
    {
    
        lincg.lincgsetxrep(state.innerobj, needxrep, _params);
    }

}
public partial class alglib
{


    /*************************************************************************
    This object stores state of the LinLSQR method.

    You should use ALGLIB functions to work with this object.
    *************************************************************************/
    public class linlsqrstate : alglibobject
    {
        //
        // Public declarations
        //
    
        public linlsqrstate()
        {
            _innerobj = new linlsqr.linlsqrstate();
        }
        
        public override alglib.alglibobject make_copy()
        {
            return new linlsqrstate((linlsqr.linlsqrstate)_innerobj.make_copy());
        }
    
        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private linlsqr.linlsqrstate _innerobj;
        public linlsqr.linlsqrstate innerobj { get { return _innerobj; } }
        public linlsqrstate(linlsqr.linlsqrstate obj)
        {
            _innerobj = obj;
        }
    }


    /*************************************************************************

    *************************************************************************/
    public class linlsqrreport : alglibobject
    {
        //
        // Public declarations
        //
        public int iterationscount { get { return _innerobj.iterationscount; } set { _innerobj.iterationscount = value; } }
        public int nmv { get { return _innerobj.nmv; } set { _innerobj.nmv = value; } }
        public int terminationtype { get { return _innerobj.terminationtype; } set { _innerobj.terminationtype = value; } }
    
        public linlsqrreport()
        {
            _innerobj = new linlsqr.linlsqrreport();
        }
        
        public override alglib.alglibobject make_copy()
        {
            return new linlsqrreport((linlsqr.linlsqrreport)_innerobj.make_copy());
        }
    
        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private linlsqr.linlsqrreport _innerobj;
        public linlsqr.linlsqrreport innerobj { get { return _innerobj; } }
        public linlsqrreport(linlsqr.linlsqrreport obj)
        {
            _innerobj = obj;
        }
    }
    
    /*************************************************************************
    This function initializes linear LSQR Solver. This solver is used to solve
    non-symmetric (and, possibly, non-square) problems. Least squares solution
    is returned for non-compatible systems.

    USAGE:
    1. User initializes algorithm state with LinLSQRCreate() call
    2. User tunes solver parameters with  LinLSQRSetCond() and other functions
    3. User  calls  LinLSQRSolveSparse()  function which takes algorithm state
       and SparseMatrix object.
    4. User calls LinLSQRResults() to get solution
    5. Optionally, user may call LinLSQRSolveSparse() again to  solve  another
       problem  with different matrix and/or right part without reinitializing
       LinLSQRState structure.

    INPUT PARAMETERS:
        M       -   number of rows in A
        N       -   number of variables, N>0

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

    NOTE: see also linlsqrcreatebuf()  for  version  which  reuses  previously
          allocated place as much as possible.

      -- ALGLIB --
         Copyright 30.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void linlsqrcreate(int m, int n, out linlsqrstate state)
    {
        state = new linlsqrstate();
        linlsqr.linlsqrcreate(m, n, state.innerobj, null);
    }
    
    public static void linlsqrcreate(int m, int n, out linlsqrstate state, alglib.xparams _params)
    {
        state = new linlsqrstate();
        linlsqr.linlsqrcreate(m, n, state.innerobj, _params);
    }
    
    /*************************************************************************
    This function initializes linear LSQR Solver.  It  provides  exactly  same
    functionality as linlsqrcreate(), but reuses  previously  allocated  space
    as much as possible.

    INPUT PARAMETERS:
        M       -   number of rows in A
        N       -   number of variables, N>0

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 14.11.2018 by Bochkanov Sergey
    *************************************************************************/
    public static void linlsqrcreatebuf(int m, int n, linlsqrstate state)
    {
    
        linlsqr.linlsqrcreatebuf(m, n, state.innerobj, null);
    }
    
    public static void linlsqrcreatebuf(int m, int n, linlsqrstate state, alglib.xparams _params)
    {
    
        linlsqr.linlsqrcreatebuf(m, n, state.innerobj, _params);
    }
    
    /*************************************************************************
    This  function  changes  preconditioning  settings of LinLSQQSolveSparse()
    function. By default, SolveSparse() uses diagonal preconditioner,  but  if
    you want to use solver without preconditioning, you can call this function
    which forces solver to use unit matrix for preconditioning.

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 19.11.2012 by Bochkanov Sergey
    *************************************************************************/
    public static void linlsqrsetprecunit(linlsqrstate state)
    {
    
        linlsqr.linlsqrsetprecunit(state.innerobj, null);
    }
    
    public static void linlsqrsetprecunit(linlsqrstate state, alglib.xparams _params)
    {
    
        linlsqr.linlsqrsetprecunit(state.innerobj, _params);
    }
    
    /*************************************************************************
    This  function  changes  preconditioning  settings  of  LinCGSolveSparse()
    function.  LinCGSolveSparse() will use diagonal of the  system  matrix  as
    preconditioner. This preconditioning mode is active by default.

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 19.11.2012 by Bochkanov Sergey
    *************************************************************************/
    public static void linlsqrsetprecdiag(linlsqrstate state)
    {
    
        linlsqr.linlsqrsetprecdiag(state.innerobj, null);
    }
    
    public static void linlsqrsetprecdiag(linlsqrstate state, alglib.xparams _params)
    {
    
        linlsqr.linlsqrsetprecdiag(state.innerobj, _params);
    }
    
    /*************************************************************************
    This function sets optional Tikhonov regularization coefficient.
    It is zero by default.

    INPUT PARAMETERS:
        LambdaI -   regularization factor, LambdaI>=0

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

      -- ALGLIB --
         Copyright 30.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void linlsqrsetlambdai(linlsqrstate state, double lambdai)
    {
    
        linlsqr.linlsqrsetlambdai(state.innerobj, lambdai, null);
    }
    
    public static void linlsqrsetlambdai(linlsqrstate state, double lambdai, alglib.xparams _params)
    {
    
        linlsqr.linlsqrsetlambdai(state.innerobj, lambdai, _params);
    }
    
    /*************************************************************************
    Procedure for solution of A*x=b with sparse A.

    INPUT PARAMETERS:
        State   -   algorithm state
        A       -   sparse M*N matrix in the CRS format (you MUST contvert  it
                    to CRS format  by  calling  SparseConvertToCRS()  function
                    BEFORE you pass it to this function).
        B       -   right part, array[M]

    RESULT:
        This function returns no result.
        You can get solution by calling LinCGResults()

    NOTE: this function uses lightweight preconditioning -  multiplication  by
          inverse of diag(A). If you want, you can turn preconditioning off by
          calling LinLSQRSetPrecUnit(). However, preconditioning cost is   low
          and preconditioner is very important for solution  of  badly  scaled
          problems.

      -- ALGLIB --
         Copyright 30.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void linlsqrsolvesparse(linlsqrstate state, sparsematrix a, double[] b)
    {
    
        linlsqr.linlsqrsolvesparse(state.innerobj, a.innerobj, b, null);
    }
    
    public static void linlsqrsolvesparse(linlsqrstate state, sparsematrix a, double[] b, alglib.xparams _params)
    {
    
        linlsqr.linlsqrsolvesparse(state.innerobj, a.innerobj, b, _params);
    }
    
    /*************************************************************************
    This function sets stopping criteria.

    INPUT PARAMETERS:
        EpsA    -   algorithm will be stopped if ||A^T*Rk||/(||A||*||Rk||)<=EpsA.
        EpsB    -   algorithm will be stopped if ||Rk||<=EpsB*||B||
        MaxIts  -   algorithm will be stopped if number of iterations
                    more than MaxIts.

    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state

    NOTE: if EpsA,EpsB,EpsC and MaxIts are zero then these variables will
    be setted as default values.

      -- ALGLIB --
         Copyright 30.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void linlsqrsetcond(linlsqrstate state, double epsa, double epsb, int maxits)
    {
    
        linlsqr.linlsqrsetcond(state.innerobj, epsa, epsb, maxits, null);
    }
    
    public static void linlsqrsetcond(linlsqrstate state, double epsa, double epsb, int maxits, alglib.xparams _params)
    {
    
        linlsqr.linlsqrsetcond(state.innerobj, epsa, epsb, maxits, _params);
    }
    
    /*************************************************************************
    LSQR solver: results.

    This function must be called after LinLSQRSolve

    INPUT PARAMETERS:
        State   -   algorithm state

    OUTPUT PARAMETERS:
        X       -   array[N], solution
        Rep     -   optimization report:
                    * Rep.TerminationType completetion code:
                        *  1    ||Rk||<=EpsB*||B||
                        *  4    ||A^T*Rk||/(||A||*||Rk||)<=EpsA
                        *  5    MaxIts steps was taken
                        *  7    rounding errors prevent further progress,
                                X contains best point found so far.
                                (sometimes returned on singular systems)
                        *  8    user requested termination via calling
                                linlsqrrequesttermination()
                    * Rep.IterationsCount contains iterations count
                    * NMV countains number of matrix-vector calculations

      -- ALGLIB --
         Copyright 30.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void linlsqrresults(linlsqrstate state, out double[] x, out linlsqrreport rep)
    {
        x = new double[0];
        rep = new linlsqrreport();
        linlsqr.linlsqrresults(state.innerobj, ref x, rep.innerobj, null);
    }
    
    public static void linlsqrresults(linlsqrstate state, out double[] x, out linlsqrreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new linlsqrreport();
        linlsqr.linlsqrresults(state.innerobj, ref x, rep.innerobj, _params);
    }
    
    /*************************************************************************
    This function turns on/off reporting.

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state
        NeedXRep-   whether iteration reports are needed or not

    If NeedXRep is True, algorithm will call rep() callback function if  it is
    provided to MinCGOptimize().

      -- ALGLIB --
         Copyright 30.11.2011 by Bochkanov Sergey
    *************************************************************************/
    public static void linlsqrsetxrep(linlsqrstate state, bool needxrep)
    {
    
        linlsqr.linlsqrsetxrep(state.innerobj, needxrep, null);
    }
    
    public static void linlsqrsetxrep(linlsqrstate state, bool needxrep, alglib.xparams _params)
    {
    
        linlsqr.linlsqrsetxrep(state.innerobj, needxrep, _params);
    }
    
    /*************************************************************************
    This function is used to peek into LSQR solver and get  current  iteration
    counter. You can safely "peek" into the solver from another thread.

    INPUT PARAMETERS:
        S           -   solver object

    RESULT:
        iteration counter, in [0,INF)

      -- ALGLIB --
         Copyright 21.05.2018 by Bochkanov Sergey
    *************************************************************************/
    public static int linlsqrpeekiterationscount(linlsqrstate s)
    {
    
        return linlsqr.linlsqrpeekiterationscount(s.innerobj, null);
    }
    
    public static int linlsqrpeekiterationscount(linlsqrstate s, alglib.xparams _params)
    {
    
        return linlsqr.linlsqrpeekiterationscount(s.innerobj, _params);
    }
    
    /*************************************************************************
    This subroutine submits request for termination of the running solver.  It
    can be called from some other thread which wants LSQR solver to  terminate
    (obviously, the  thread  running  LSQR  solver can not request termination
    because it is already busy working on LSQR).

    As result, solver  stops  at  point  which  was  "current  accepted"  when
    termination  request  was  submitted  and returns error code 8 (successful
    termination).  Such   termination   is  a smooth  process  which  properly
    deallocates all temporaries.

    INPUT PARAMETERS:
        State   -   solver structure

    NOTE: calling this function on solver which is NOT running  will  have  no
          effect.

    NOTE: multiple calls to this function are possible. First call is counted,
          subsequent calls are silently ignored.

    NOTE: solver clears termination flag on its start, it means that  if  some
          other thread will request termination too soon, its request will went
          unnoticed.

      -- ALGLIB --
         Copyright 08.10.2014 by Bochkanov Sergey
    *************************************************************************/
    public static void linlsqrrequesttermination(linlsqrstate state)
    {
    
        linlsqr.linlsqrrequesttermination(state.innerobj, null);
    }
    
    public static void linlsqrrequesttermination(linlsqrstate state, alglib.xparams _params)
    {
    
        linlsqr.linlsqrrequesttermination(state.innerobj, _params);
    }

}
public partial class alglib
{

    
    /*************************************************************************
    Sparse linear solver for A*x=b with N*N  sparse  real  symmetric  positive
    definite matrix A, N*1 vectors x and b.

    This solver  converts  input  matrix  to  SKS  format,  performs  Cholesky
    factorization using  SKS  Cholesky  subroutine  (works  well  for  limited
    bandwidth matrices) and uses sparse triangular solvers to get solution  of
    the original system.

    IMPORTANT: this  function  is  intended  for  low  profile (variable band)
               linear systems with dense or nearly-dense bands. Only  in  such
               cases  it  provides  some  performance  improvement  over  more
               general sparsrspdsolve(). If your  system  has  high  bandwidth
               or sparse band, the general sparsrspdsolve() is  likely  to  be
               more efficient.

    INPUT PARAMETERS
        A       -   sparse matrix, must be NxN exactly
        IsUpper -   which half of A is provided (another half is ignored)
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        X       -   array[N], it contains:
                    * rep.terminationtype>0    =>  solution
                    * rep.terminationtype=-3   =>  filled by zeros
        Rep     -   solver report, following fields are set:
                    * rep.terminationtype - solver status; >0 for success,
                      set to -3 on failure (degenerate or non-SPD system).

      -- ALGLIB --
         Copyright 26.12.2017 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsespdsolvesks(sparsematrix a, bool isupper, double[] b, out double[] x, out sparsesolverreport rep)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        directsparsesolvers.sparsespdsolvesks(a.innerobj, isupper, b, ref x, rep.innerobj, null);
    }
    
    public static void sparsespdsolvesks(sparsematrix a, bool isupper, double[] b, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        directsparsesolvers.sparsespdsolvesks(a.innerobj, isupper, b, ref x, rep.innerobj, _params);
    }
    
    /*************************************************************************
    Sparse linear solver for A*x=b with N*N  sparse  real  symmetric  positive
    definite matrix A, N*1 vectors x and b.

    This solver  converts  input  matrix  to  CRS  format,  performs  Cholesky
    factorization using supernodal Cholesky  decomposition  with  permutation-
    reducing ordering and uses sparse triangular solver to get solution of the
    original system.

    INPUT PARAMETERS
        A       -   sparse matrix, must be NxN exactly.
                    Can be stored in any sparse storage format, CRS is preferred.
        IsUpper -   which half of A is provided (another half is ignored).
                    It is better to store the lower triangle because it allows
                    us to avoid one transposition during internal conversion.
        B       -   array[N], right part

    OUTPUT PARAMETERS
        X       -   array[N], it contains:
                    * rep.terminationtype>0    =>  solution
                    * rep.terminationtype=-3   =>  filled by zeros
        Rep     -   solver report, following fields are set:
                    * rep.terminationtype - solver status; >0 for success,
                      set to -3 on failure (degenerate or non-SPD system).

      -- ALGLIB --
         Copyright 26.12.2017 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsespdsolve(sparsematrix a, bool isupper, double[] b, out double[] x, out sparsesolverreport rep)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        directsparsesolvers.sparsespdsolve(a.innerobj, isupper, b, ref x, rep.innerobj, null);
    }
    
    public static void sparsespdsolve(sparsematrix a, bool isupper, double[] b, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        directsparsesolvers.sparsespdsolve(a.innerobj, isupper, b, ref x, rep.innerobj, _params);
    }
    
    /*************************************************************************
    Sparse linear solver for A*x=b with N*N real  symmetric  positive definite
    matrix A given by its Cholesky decomposition, and N*1 vectors x and b.

    IMPORTANT: this solver requires input matrix to be in  the  SKS  (Skyline)
               or CRS (compressed row storage) format. An  exception  will  be
               generated if you pass matrix in some other format.

    INPUT PARAMETERS
        A       -   sparse NxN matrix stored in CRs or SKS format, must be NxN
                    exactly
        IsUpper -   which half of A is provided (another half is ignored)
        B       -   array[N], right part

    OUTPUT PARAMETERS
        X       -   array[N], it contains:
                    * rep.terminationtype>0    =>  solution
                    * rep.terminationtype=-3   =>  filled by zeros
        Rep     -   solver report, following fields are set:
                    * rep.terminationtype - solver status; >0 for success,
                      set to -3 on failure (degenerate or non-SPD system).

      -- ALGLIB --
         Copyright 26.12.2017 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsespdcholeskysolve(sparsematrix a, bool isupper, double[] b, out double[] x, out sparsesolverreport rep)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        directsparsesolvers.sparsespdcholeskysolve(a.innerobj, isupper, b, ref x, rep.innerobj, null);
    }
    
    public static void sparsespdcholeskysolve(sparsematrix a, bool isupper, double[] b, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        directsparsesolvers.sparsespdcholeskysolve(a.innerobj, isupper, b, ref x, rep.innerobj, _params);
    }
    
    /*************************************************************************
    Sparse linear solver for A*x=b with general (nonsymmetric) N*N sparse real
    matrix A, N*1 vectors x and b.

    This function internally uses several solvers:
    * supernodal solver with static pivoting applied to  a  2N*2N  regularized
      augmented  system, followed by iterative refinement. This solver  is   a
      recommended option because it provides the best speed and has the lowest
      memory requirements.
    * sparse LU with dynamic pivoting for stability. Provides better  accuracy
      at the cost of a significantly lower performance. Recommended  only  for
      extremely unstable problems.

    INPUT PARAMETERS
        A       -   sparse matrix, must be NxN exactly, any storage format
        B       -   array[N], right part
        SolverType- solver type to use:
                    * 0     use the best solver. It is augmented system in the
                            current version, but may change in future releases
                    * 10    use 'default profile' of the supernodal solver with
                            static   pivoting.   The  'default'   profile   is
                            intended for systems with plenty of memory; it  is
                            optimized for the best convergence at the cost  of
                            increased RAM usage. Recommended option.
                    * 11    use 'limited memory'  profile  of  the  supernodal
                            solver with static  pivoting.  The  limited-memory
                            profile is intended for problems with millions  of
                            variables.  On  most  systems  it  has  the   same
                            convergence as the default profile, having somewhat
                            worse results only for ill-conditioned systems.
                    * 20    use sparse LU with dynamic pivoting for stability.
                            Not intended for large-scale problems.

    OUTPUT PARAMETERS
        X       -   array[N], it contains:
                    * rep.terminationtype>0    =>  solution
                    * rep.terminationtype=-3   =>  filled by zeros
        Rep     -   solver report, following fields are set:
                    * rep.terminationtype - solver status; >0 for success,
                      set to -3 on failure (degenerate system).

      -- ALGLIB --
         Copyright 18.11.2023 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolve(sparsematrix a, double[] b, int solvertype, out double[] x, out sparsesolverreport rep)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        directsparsesolvers.sparsesolve(a.innerobj, b, solvertype, ref x, rep.innerobj, null);
    }
    
    public static void sparsesolve(sparsematrix a, double[] b, int solvertype, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        directsparsesolvers.sparsesolve(a.innerobj, b, solvertype, ref x, rep.innerobj, _params);
    }
            
    public static void sparsesolve(sparsematrix a, double[] b, out double[] x, out sparsesolverreport rep)
    {
        int solvertype;
    
        x = new double[0];
        rep = new sparsesolverreport();
        solvertype = 0;
        directsparsesolvers.sparsesolve(a.innerobj, b, solvertype, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void sparsesolve(sparsematrix a, double[] b, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
    {
        int solvertype;
    
        x = new double[0];
        rep = new sparsesolverreport();
        solvertype = 0;
        directsparsesolvers.sparsesolve(a.innerobj, b, solvertype, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Sparse linear least squares solver for A*x=b with  general  (nonsymmetric)
    N*N sparse real matrix A, N*1 vectors x and b.

    This function solves a regularized linear least squares problem of the form

            (                      )
        min ( |Ax-b|^2 + reg*|x|^2 ), with reg>=sqrt(MachineAccuracy)
            (                      )

    The function internally uses supernodal  solver  to  solve  an  augmented-
    regularized sparse system. The solver, which was initially used  to  solve
    sparse square system, can also  be  used  to  solve  rectangular  systems,
    provided that the system is regularized with regularizing  coefficient  at
    least sqrt(MachineAccuracy), which is ~10^8 (double precision).

    It can be used to solve both full rank and rank deficient systems.

    INPUT PARAMETERS
        A       -   sparse MxN matrix, any storage format
        B       -   array[M], right part
        Reg     -   regularization coefficient, Reg>=sqrt(MachineAccuracy),
                    lower values will be silently increased.
        SolverType- solver type to use:
                    * 0     use the best solver. It is augmented system in the
                            current version, but may change in future releases
                    * 10    use 'default profile' of the supernodal solver with
                            static   pivoting.   The  'default'   profile   is
                            intended for systems with plenty of memory; it  is
                            optimized for the best convergence at the cost  of
                            increased RAM usage. Recommended option.
                    * 11    use 'limited memory'  profile  of  the  supernodal
                            solver with static  pivoting.  The  limited-memory
                            profile is intended for problems with millions  of
                            variables.  On  most  systems  it  has  the   same
                            convergence as the default profile, having somewhat
                            worse results only for ill-conditioned systems.

    OUTPUT PARAMETERS
        X       -   array[N], least squares solution
        Rep     -   solver report, following fields are set:
                    * rep.terminationtype - solver status; >0 for success.

                      Present version of the solver does NOT returns negative
                      completion codes because  it  does  not  fail.  However,
                      future ALGLIB versions may include solvers which  return
                      negative completion codes.

      -- ALGLIB --
         Copyright 18.11.2023 by Bochkanov Sergey
    *************************************************************************/
    public static void sparsesolvelsreg(sparsematrix a, double[] b, double reg, int solvertype, out double[] x, out sparsesolverreport rep)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        directsparsesolvers.sparsesolvelsreg(a.innerobj, b, reg, solvertype, ref x, rep.innerobj, null);
    }
    
    public static void sparsesolvelsreg(sparsematrix a, double[] b, double reg, int solvertype, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        directsparsesolvers.sparsesolvelsreg(a.innerobj, b, reg, solvertype, ref x, rep.innerobj, _params);
    }
            
    public static void sparsesolvelsreg(sparsematrix a, double[] b, double reg, out double[] x, out sparsesolverreport rep)
    {
        int solvertype;
    
        x = new double[0];
        rep = new sparsesolverreport();
        solvertype = 0;
        directsparsesolvers.sparsesolvelsreg(a.innerobj, b, reg, solvertype, ref x, rep.innerobj, null);
    
        return;
    }
            
    public static void sparsesolvelsreg(sparsematrix a, double[] b, double reg, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
    {
        int solvertype;
    
        x = new double[0];
        rep = new sparsesolverreport();
        solvertype = 0;
        directsparsesolvers.sparsesolvelsreg(a.innerobj, b, reg, solvertype, ref x, rep.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    Sparse linear solver for A*x=b with general (nonsymmetric) N*N sparse real
    matrix A given by its LU factorization, N*1 vectors x and b.

    IMPORTANT: this solver requires input matrix  to  be  in  the  CRS  sparse
               storage format. An exception will  be  generated  if  you  pass
               matrix in some other format (HASH or SKS).

    INPUT PARAMETERS
        A       -   LU factorization of the sparse matrix, must be NxN exactly
                    in CRS storage format
        P, Q    -   pivot indexes from LU factorization
        N       -   size of A, N>0
        B       -   array[0..N-1], right part

    OUTPUT PARAMETERS
        X       -   array[N], it contains:
                    * rep.terminationtype>0    =>  solution
                    * rep.terminationtype=-3   =>  filled by zeros
        Rep     -   solver report, following fields are set:
                    * rep.terminationtype - solver status; >0 for success,
                      set to -3 on failure (degenerate system).

      -- ALGLIB --
         Copyright 26.12.2017 by Bochkanov Sergey
    *************************************************************************/
    public static void sparselusolve(sparsematrix a, int[] p, int[] q, double[] b, out double[] x, out sparsesolverreport rep)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        directsparsesolvers.sparselusolve(a.innerobj, p, q, b, ref x, rep.innerobj, null);
    }
    
    public static void sparselusolve(sparsematrix a, int[] p, int[] q, double[] b, out double[] x, out sparsesolverreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new sparsesolverreport();
        directsparsesolvers.sparselusolve(a.innerobj, p, q, b, ref x, rep.innerobj, _params);
    }

}
public partial class alglib
{


    /*************************************************************************

    *************************************************************************/
    public class nleqstate : alglibobject
    {
        //
        // Public declarations
        //
        public bool needf { get { return _innerobj.needf; } set { _innerobj.needf = value; } }
        public bool needfij { get { return _innerobj.needfij; } set { _innerobj.needfij = value; } }
        public bool xupdated { get { return _innerobj.xupdated; } set { _innerobj.xupdated = value; } }
        public double f { get { return _innerobj.f; } set { _innerobj.f = value; } }
        public double[] fi { get { return _innerobj.fi; } }
        public double[,] j { get { return _innerobj.j; } }
        public double[] x { get { return _innerobj.x; } }
    
        public nleqstate()
        {
            _innerobj = new nleq.nleqstate();
        }
        
        public override alglib.alglibobject make_copy()
        {
            return new nleqstate((nleq.nleqstate)_innerobj.make_copy());
        }
    
        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private nleq.nleqstate _innerobj;
        public nleq.nleqstate innerobj { get { return _innerobj; } }
        public nleqstate(nleq.nleqstate obj)
        {
            _innerobj = obj;
        }
    }


    /*************************************************************************

    *************************************************************************/
    public class nleqreport : alglibobject
    {
        //
        // Public declarations
        //
        public int iterationscount { get { return _innerobj.iterationscount; } set { _innerobj.iterationscount = value; } }
        public int nfunc { get { return _innerobj.nfunc; } set { _innerobj.nfunc = value; } }
        public int njac { get { return _innerobj.njac; } set { _innerobj.njac = value; } }
        public int terminationtype { get { return _innerobj.terminationtype; } set { _innerobj.terminationtype = value; } }
    
        public nleqreport()
        {
            _innerobj = new nleq.nleqreport();
        }
        
        public override alglib.alglibobject make_copy()
        {
            return new nleqreport((nleq.nleqreport)_innerobj.make_copy());
        }
    
        //
        // Although some of declarations below are public, you should not use them
        // They are intended for internal use only
        //
        private nleq.nleqreport _innerobj;
        public nleq.nleqreport innerobj { get { return _innerobj; } }
        public nleqreport(nleq.nleqreport obj)
        {
            _innerobj = obj;
        }
    }
    
    /*************************************************************************
                    LEVENBERG-MARQUARDT-LIKE NONLINEAR SOLVER

    DESCRIPTION:
    This algorithm solves system of nonlinear equations
        F[0](x[0], ..., x[n-1])   = 0
        F[1](x[0], ..., x[n-1])   = 0
        ...
        F[M-1](x[0], ..., x[n-1]) = 0
    with M/N do not necessarily coincide.  Algorithm  converges  quadratically
    under following conditions:
        * the solution set XS is nonempty
        * for some xs in XS there exist such neighbourhood N(xs) that:
          * vector function F(x) and its Jacobian J(x) are continuously
            differentiable on N
          * ||F(x)|| provides local error bound on N, i.e. there  exists  such
            c1, that ||F(x)||>c1*distance(x,XS)
    Note that these conditions are much more weaker than usual non-singularity
    conditions. For example, algorithm will converge for any  affine  function
    F (whether its Jacobian singular or not).


    REQUIREMENTS:
    Algorithm will request following information during its operation:
    * function vector F[] and Jacobian matrix at given point X
    * value of merit function f(x)=F[0]^2(x)+...+F[M-1]^2(x) at given point X


    USAGE:
    1. User initializes algorithm state with NLEQCreateLM() call
    2. User tunes solver parameters with  NLEQSetCond(),  NLEQSetStpMax()  and
       other functions
    3. User  calls  NLEQSolve()  function  which  takes  algorithm  state  and
       pointers (delegates, etc.) to callback functions which calculate  merit
       function value and Jacobian.
    4. User calls NLEQResults() to get solution
    5. Optionally, user may call NLEQRestartFrom() to  solve  another  problem
       with same parameters (N/M) but another starting  point  and/or  another
       function vector. NLEQRestartFrom() allows to reuse already  initialized
       structure.


    INPUT PARAMETERS:
        N       -   space dimension, N>1:
                    * if provided, only leading N elements of X are used
                    * if not provided, determined automatically from size of X
        M       -   system size
        X       -   starting point


    OUTPUT PARAMETERS:
        State   -   structure which stores algorithm state


    NOTES:
    1. you may tune stopping conditions with NLEQSetCond() function
    2. if target function contains exp() or other fast growing functions,  and
       optimization algorithm makes too large steps which leads  to  overflow,
       use NLEQSetStpMax() function to bound algorithm's steps.
    3. this  algorithm  is  a  slightly  modified implementation of the method
       described  in  'Levenberg-Marquardt  method  for constrained  nonlinear
       equations with strong local convergence properties' by Christian Kanzow
       Nobuo Yamashita and Masao Fukushima and further  developed  in  'On the
       convergence of a New Levenberg-Marquardt Method'  by  Jin-yan  Fan  and
       Ya-Xiang Yuan.


      -- ALGLIB --
         Copyright 20.08.2009 by Bochkanov Sergey
    *************************************************************************/
    public static void nleqcreatelm(int n, int m, double[] x, out nleqstate state)
    {
        state = new nleqstate();
        nleq.nleqcreatelm(n, m, x, state.innerobj, null);
    }
    
    public static void nleqcreatelm(int n, int m, double[] x, out nleqstate state, alglib.xparams _params)
    {
        state = new nleqstate();
        nleq.nleqcreatelm(n, m, x, state.innerobj, _params);
    }
            
    public static void nleqcreatelm(int m, double[] x, out nleqstate state)
    {
        int n;
    
        state = new nleqstate();
        n = ap.len(x);
        nleq.nleqcreatelm(n, m, x, state.innerobj, null);
    
        return;
    }
            
    public static void nleqcreatelm(int m, double[] x, out nleqstate state, alglib.xparams _params)
    {
        int n;
    
        state = new nleqstate();
        n = ap.len(x);
        nleq.nleqcreatelm(n, m, x, state.innerobj, _params);
    
        return;
    }
    
    /*************************************************************************
    This function sets stopping conditions for the nonlinear solver

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state
        EpsF    -   >=0
                    The subroutine finishes  its work if on k+1-th iteration
                    the condition ||F||<=EpsF is satisfied
        MaxIts  -   maximum number of iterations. If MaxIts=0, the  number  of
                    iterations is unlimited.

    Passing EpsF=0 and MaxIts=0 simultaneously will lead to  automatic
    stopping criterion selection (small EpsF).

    NOTES:

      -- ALGLIB --
         Copyright 20.08.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void nleqsetcond(nleqstate state, double epsf, int maxits)
    {
    
        nleq.nleqsetcond(state.innerobj, epsf, maxits, null);
    }
    
    public static void nleqsetcond(nleqstate state, double epsf, int maxits, alglib.xparams _params)
    {
    
        nleq.nleqsetcond(state.innerobj, epsf, maxits, _params);
    }
    
    /*************************************************************************
    This function turns on/off reporting.

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state
        NeedXRep-   whether iteration reports are needed or not

    If NeedXRep is True, algorithm will call rep() callback function if  it is
    provided to NLEQSolve().

      -- ALGLIB --
         Copyright 20.08.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void nleqsetxrep(nleqstate state, bool needxrep)
    {
    
        nleq.nleqsetxrep(state.innerobj, needxrep, null);
    }
    
    public static void nleqsetxrep(nleqstate state, bool needxrep, alglib.xparams _params)
    {
    
        nleq.nleqsetxrep(state.innerobj, needxrep, _params);
    }
    
    /*************************************************************************
    This function sets maximum step length

    INPUT PARAMETERS:
        State   -   structure which stores algorithm state
        StpMax  -   maximum step length, >=0. Set StpMax to 0.0,  if you don't
                    want to limit step length.

    Use this subroutine when target function  contains  exp()  or  other  fast
    growing functions, and algorithm makes  too  large  steps  which  lead  to
    overflow. This function allows us to reject steps that are too large  (and
    therefore expose us to the possible overflow) without actually calculating
    function value at the x+stp*d.

      -- ALGLIB --
         Copyright 20.08.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void nleqsetstpmax(nleqstate state, double stpmax)
    {
    
        nleq.nleqsetstpmax(state.innerobj, stpmax, null);
    }
    
    public static void nleqsetstpmax(nleqstate state, double stpmax, alglib.xparams _params)
    {
    
        nleq.nleqsetstpmax(state.innerobj, stpmax, _params);
    }
    
    /*************************************************************************
    This function provides reverse communication interface
    Reverse communication interface is not documented or recommended to use.
    See below for functions which provide better documented API
    *************************************************************************/
    public static bool nleqiteration(nleqstate state)
    {
    
        return nleq.nleqiteration(state.innerobj, null);
    }
    
    public static bool nleqiteration(nleqstate state, alglib.xparams _params)
    {
    
        return nleq.nleqiteration(state.innerobj, _params);
    }
    /*************************************************************************
    This family of functions is used to launcn iterations of nonlinear solver

    These functions accept following parameters:
        func    -   callback which calculates function (or merit function)
                    value func at given point x
        jac     -   callback which calculates function vector fi[]
                    and Jacobian jac at given point x
        rep     -   optional callback which is called after each iteration
                    can be null
        obj     -   optional object which is passed to func/grad/hess/jac/rep
                    can be null


      -- ALGLIB --
         Copyright 20.03.2009 by Bochkanov Sergey

    *************************************************************************/
    public static void nleqsolve(nleqstate state, ndimensional_func func, ndimensional_jac  jac, ndimensional_rep rep, object obj)
    {
        nleqsolve(state, func, jac, rep, obj, null);
    }
    public static void nleqsolve(nleqstate state, ndimensional_func func, ndimensional_jac  jac, ndimensional_rep rep, object obj, alglib.xparams _params)
    {
        if( func==null )
            throw new alglibexception("ALGLIB: error in 'nleqsolve()' (func is null)");
        if( jac==null )
            throw new alglibexception("ALGLIB: error in 'nleqsolve()' (jac is null)");
        alglib.nleq.nleqsetprotocolv1(state.innerobj, _params);
        while( alglib.nleqiteration(state, _params) )
        {
            if( state.needf )
            {
                func(state.x, ref state.innerobj.f, obj);
                continue;
            }
            if( state.needfij )
            {
                jac(state.x, state.innerobj.fi, state.innerobj.j, obj);
                continue;
            }
            if( state.innerobj.xupdated )
            {
                if( rep!=null )
                    rep(state.innerobj.x, state.innerobj.f, obj);
                continue;
            }
            throw new alglibexception("ALGLIB: error in 'nleqsolve' (some derivatives were not provided?)");
        }
    }


    
    /*************************************************************************
    NLEQ solver results

    INPUT PARAMETERS:
        State   -   algorithm state.

    OUTPUT PARAMETERS:
        X       -   array[0..N-1], solution
        Rep     -   optimization report:
                    * Rep.TerminationType completetion code:
                        * -4    ERROR:  algorithm   has   converged   to   the
                                stationary point Xf which is local minimum  of
                                f=F[0]^2+...+F[m-1]^2, but is not solution  of
                                nonlinear system.
                        *  1    sqrt(f)<=EpsF.
                        *  5    MaxIts steps was taken
                        *  7    stopping conditions are too stringent,
                                further improvement is impossible
                    * Rep.IterationsCount contains iterations count
                    * NFEV countains number of function calculations
                    * ActiveConstraints contains number of active constraints

      -- ALGLIB --
         Copyright 20.08.2009 by Bochkanov Sergey
    *************************************************************************/
    public static void nleqresults(nleqstate state, out double[] x, out nleqreport rep)
    {
        x = new double[0];
        rep = new nleqreport();
        nleq.nleqresults(state.innerobj, ref x, rep.innerobj, null);
    }
    
    public static void nleqresults(nleqstate state, out double[] x, out nleqreport rep, alglib.xparams _params)
    {
        x = new double[0];
        rep = new nleqreport();
        nleq.nleqresults(state.innerobj, ref x, rep.innerobj, _params);
    }
    
    /*************************************************************************
    NLEQ solver results

    Buffered implementation of NLEQResults(), which uses pre-allocated  buffer
    to store X[]. If buffer size is  too  small,  it  resizes  buffer.  It  is
    intended to be used in the inner cycles of performance critical algorithms
    where array reallocation penalty is too large to be ignored.

      -- ALGLIB --
         Copyright 20.08.2009 by Bochkanov Sergey
    *************************************************************************/
    public static void nleqresultsbuf(nleqstate state, ref double[] x, nleqreport rep)
    {
    
        nleq.nleqresultsbuf(state.innerobj, ref x, rep.innerobj, null);
    }
    
    public static void nleqresultsbuf(nleqstate state, ref double[] x, nleqreport rep, alglib.xparams _params)
    {
    
        nleq.nleqresultsbuf(state.innerobj, ref x, rep.innerobj, _params);
    }
    
    /*************************************************************************
    This  subroutine  restarts  CG  algorithm from new point. All optimization
    parameters are left unchanged.

    This  function  allows  to  solve multiple  optimization  problems  (which
    must have same number of dimensions) without object reallocation penalty.

    INPUT PARAMETERS:
        State   -   structure used for reverse communication previously
                    allocated with MinCGCreate call.
        X       -   new starting point.
        BndL    -   new lower bounds
        BndU    -   new upper bounds

      -- ALGLIB --
         Copyright 30.07.2010 by Bochkanov Sergey
    *************************************************************************/
    public static void nleqrestartfrom(nleqstate state, double[] x)
    {
    
        nleq.nleqrestartfrom(state.innerobj, x, null);
    }
    
    public static void nleqrestartfrom(nleqstate state, double[] x, alglib.xparams _params)
    {
    
        nleq.nleqrestartfrom(state.innerobj, x, _params);
    }

}
public partial class alglib
{
    public class polynomialsolver
    {
        public class polynomialsolverreport : apobject
        {
            public double maxerr;
            public polynomialsolverreport()
            {
                init();
            }
            public override void init()
            {
            }
            public override alglib.apobject make_copy()
            {
                polynomialsolverreport _result = new polynomialsolverreport();
                _result.maxerr = maxerr;
                return _result;
            }
        };




        /*************************************************************************
        Polynomial root finding.

        This function returns all roots of the polynomial
            P(x) = a0 + a1*x + a2*x^2 + ... + an*x^n
        Both real and complex roots are returned (see below).

        INPUT PARAMETERS:
            A       -   array[N+1], polynomial coefficients:
                        * A[0] is constant term
                        * A[N] is a coefficient of X^N
            N       -   polynomial degree

        OUTPUT PARAMETERS:
            X       -   array of complex roots:
                        * for isolated real root, X[I] is strictly real: IMAGE(X[I])=0
                        * complex roots are always returned in pairs - roots occupy
                          positions I and I+1, with:
                          * X[I+1]=Conj(X[I])
                          * IMAGE(X[I]) > 0
                          * IMAGE(X[I+1]) = -IMAGE(X[I]) < 0
                        * multiple real roots may have non-zero imaginary part due
                          to roundoff errors. There is no reliable way to distinguish
                          real root of multiplicity 2 from two  complex  roots  in
                          the presence of roundoff errors.
            Rep     -   report, additional information, following fields are set:
                        * Rep.MaxErr - max( |P(xi)| )  for  i=0..N-1.  This  field
                          allows to quickly estimate "quality" of the roots  being
                          returned.

        NOTE:   this function uses companion matrix method to find roots. In  case
                internal EVD  solver  fails  do  find  eigenvalues,  exception  is
                generated.

        NOTE:   roots are not "polished" and  no  matrix  balancing  is  performed
                for them.

          -- ALGLIB --
             Copyright 24.02.2014 by Bochkanov Sergey
        *************************************************************************/
        public static void polynomialsolve(double[] a,
            int n,
            ref complex[] x,
            polynomialsolverreport rep,
            alglib.xparams _params)
        {
            double[,] c = new double[0,0];
            double[,] vl = new double[0,0];
            double[,] vr = new double[0,0];
            double[] wr = new double[0];
            double[] wi = new double[0];
            int i = 0;
            int j = 0;
            bool status = new bool();
            int nz = 0;
            int ne = 0;
            complex v = 0;
            complex vv = 0;

            a = (double[])a.Clone();
            x = new complex[0];

            alglib.ap.assert(n>0, "PolynomialSolve: N<=0");
            alglib.ap.assert(alglib.ap.len(a)>=n+1, "PolynomialSolve: Length(A)<N+1");
            alglib.ap.assert(apserv.isfinitevector(a, n+1, _params), "PolynomialSolve: A contains infitite numbers");
            alglib.ap.assert((double)(a[n])!=(double)(0), "PolynomialSolve: A[N]=0");
            
            //
            // Prepare
            //
            x = new complex[n];
            
            //
            // Normalize A:
            // * analytically determine NZ zero roots
            // * quick exit for NZ=N
            // * make residual NE-th degree polynomial monic
            //   (here NE=N-NZ)
            //
            nz = 0;
            while( nz<n && (double)(a[nz])==(double)(0) )
            {
                nz = nz+1;
            }
            ne = n-nz;
            for(i=nz; i<=n; i++)
            {
                a[i-nz] = a[i]/a[n];
            }
            
            //
            // For NZ<N, build companion matrix and find NE non-zero roots
            //
            if( ne>0 )
            {
                c = new double[ne, ne];
                for(i=0; i<=ne-1; i++)
                {
                    for(j=0; j<=ne-1; j++)
                    {
                        c[i,j] = 0;
                    }
                }
                c[0,ne-1] = -a[0];
                for(i=1; i<=ne-1; i++)
                {
                    c[i,i-1] = 1;
                    c[i,ne-1] = -a[i];
                }
                status = evd.rmatrixevd(c, ne, 0, ref wr, ref wi, ref vl, ref vr, _params);
                alglib.ap.assert(status, "PolynomialSolve: inernal error - EVD solver failed");
                for(i=0; i<=ne-1; i++)
                {
                    x[i].x = wr[i];
                    x[i].y = wi[i];
                }
            }
            
            //
            // Remaining NZ zero roots
            //
            for(i=ne; i<=n-1; i++)
            {
                x[i] = 0;
            }
            
            //
            // Rep
            //
            rep.maxerr = 0;
            for(i=0; i<=ne-1; i++)
            {
                v = 0;
                vv = 1;
                for(j=0; j<=ne; j++)
                {
                    v = v+a[j]*vv;
                    vv = vv*x[i];
                }
                rep.maxerr = Math.Max(rep.maxerr, math.abscomplex(v));
            }
        }


    }
    public class directdensesolvers
    {
        public class densesolverreport : apobject
        {
            public int terminationtype;
            public double r1;
            public double rinf;
            public densesolverreport()
            {
                init();
            }
            public override void init()
            {
            }
            public override alglib.apobject make_copy()
            {
                densesolverreport _result = new densesolverreport();
                _result.terminationtype = terminationtype;
                _result.r1 = r1;
                _result.rinf = rinf;
                return _result;
            }
        };


        public class densesolverlsreport : apobject
        {
            public int terminationtype;
            public double r2;
            public double[,] cx;
            public int n;
            public int k;
            public densesolverlsreport()
            {
                init();
            }
            public override void init()
            {
                cx = new double[0,0];
            }
            public override alglib.apobject make_copy()
            {
                densesolverlsreport _result = new densesolverlsreport();
                _result.terminationtype = terminationtype;
                _result.r2 = r2;
                _result.cx = (double[,])cx.Clone();
                _result.n = n;
                _result.k = k;
                return _result;
            }
        };




        /*************************************************************************
        Dense solver for A*x=b with N*N real matrix A and N*1 real vectorx  x  and
        b. This is "slow-but-feature rich" version of the  linear  solver.  Faster
        version is RMatrixSolveFast() function.

        Algorithm features:
        * automatic detection of degenerate cases
        * condition number estimation
        * iterative refinement
        * O(N^3) complexity

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear  system
                   ! and  performs  iterative   refinement,   which   results   in
                   ! significant performance penalty  when  compared  with  "fast"
                   ! version  which  just  performs  LU  decomposition  and  calls
                   ! triangular solver.
                   !
                   ! This  performance  penalty  is  especially  visible  in   the
                   ! multithreaded mode, because both condition number  estimation
                   ! and   iterative    refinement   are   inherently   sequential
                   ! calculations. It is also very significant on small matrices.
                   !
                   ! Thus, if you need high performance and if you are pretty sure
                   ! that your system is well conditioned, we  strongly  recommend
                   ! you to use faster solver, RMatrixSolveFast() function.

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            Rep     -   additional report, the following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned matrix
                        * rep.r1                condition number in 1-norm
                        * rep.rinf              condition number in inf-norm
            X       -   array[N], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void rmatrixsolve(double[,] a,
            int n,
            double[] b,
            ref double[] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            double[,] bm = new double[0,0];
            double[,] xm = new double[0,0];

            x = new double[0];

            alglib.ap.assert(n>0, "RMatrixSolve: N<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "RMatrixSolve: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "RMatrixSolve: cols(A)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "RMatrixSolve: length(B)<N");
            alglib.ap.assert(apserv.apservisfinitematrix(a, n, n, _params), "RMatrixSolve: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "RMatrixSolve: B contains infinite or NaN values!");
            bm = new double[n, 1];
            ablasf.rcopyvc(n, b, bm, 0, _params);
            rmatrixsolvem(a, n, bm, 1, true, ref xm, rep, _params);
            x = new double[n];
            ablasf.rcopycv(n, xm, 0, x, _params);
        }


        /*************************************************************************
        Dense solver.

        This  subroutine  solves  a  system  A*x=b,  where A is NxN non-denegerate
        real matrix, x  and  b  are  vectors.  This is a "fast" version of  linear
        solver which does NOT provide  any  additional  functions  like  condition
        number estimation or iterative refinement.

        Algorithm features:
        * efficient algorithm O(N^3) complexity
        * no performance overhead from additional functionality

        If you need condition number estimation or iterative refinement, use  more
        feature-rich version - RMatrixSolve().

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            B       -   array[N]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros
                        
        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or exactly singular system

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 16.03.2015 by Bochkanov Sergey
        *************************************************************************/
        public static bool rmatrixsolvefast(double[,] a,
            int n,
            double[] b,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;
            int j = 0;
            int[] p = new int[0];

            a = (double[,])a.Clone();

            alglib.ap.assert(n>0, "RMatrixSolveFast: N<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "RMatrixSolveFast: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "RMatrixSolveFast: cols(A)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "RMatrixSolveFast: length(B)<N");
            alglib.ap.assert(apserv.apservisfinitematrix(a, n, n, _params), "RMatrixSolveFast: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "RMatrixSolveFast: B contains infinite or NaN values!");
            result = true;
            trfac.rmatrixlu(a, n, n, ref p, _params);
            for(i=0; i<=n-1; i++)
            {
                if( (double)(a[i,i])==(double)(0) )
                {
                    for(j=0; j<=n-1; j++)
                    {
                        b[j] = 0.0;
                    }
                    result = false;
                    return result;
                }
            }
            rbasiclusolve(a, p, n, b, _params);
            return result;
        }


        /*************************************************************************
        Dense solver.

        Similar to RMatrixSolve() but solves task with multiple right parts (where
        b and x are NxM matrices). This is  "slow-but-robust"  version  of  linear
        solver with additional functionality  like  condition  number  estimation.
        There also exists faster version - RMatrixSolveMFast().

        Algorithm features:
        * automatic detection of degenerate cases
        * condition number estimation
        * optional iterative refinement
        * O(N^3+M*N^2) complexity

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear  system
                   ! and  performs  iterative   refinement,   which   results   in
                   ! significant performance penalty  when  compared  with  "fast"
                   ! version  which  just  performs  LU  decomposition  and  calls
                   ! triangular solver.
                   !
                   ! This  performance  penalty  is  especially  visible  in   the
                   ! multithreaded mode, because both condition number  estimation
                   ! and   iterative    refinement   are   inherently   sequential
                   ! calculations. It also very significant on small matrices.
                   !
                   ! Thus, if you need high performance and if you are pretty sure
                   ! that your system is well conditioned, we  strongly  recommend
                   ! you to use faster solver, RMatrixSolveMFast() function.

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size
            RFS     -   iterative refinement switch:
                        * True - refinement is used.
                          Less performance, more precision.
                        * False - refinement is not used.
                          More performance, less precision.

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or exactly singular matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void rmatrixsolvem(double[,] a,
            int n,
            double[,] b,
            int m,
            bool rfs,
            ref double[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            double[,] da = new double[0,0];
            double[,] emptya = new double[0,0];
            int[] p = new int[0];
            int i = 0;
            int i_ = 0;

            x = new double[0,0];

            alglib.ap.assert(n>0, "RMatrixSolveM: N<=0");
            alglib.ap.assert(m>0, "RMatrixSolveM: M<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "RMatrixSolveM: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "RMatrixSolveM: cols(A)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "RMatrixSolveM: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "RMatrixSolveM: cols(B)<M");
            alglib.ap.assert(apserv.apservisfinitematrix(a, n, n, _params), "RMatrixSolveM: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.apservisfinitematrix(b, n, m, _params), "RMatrixSolveM: B contains infinite or NaN values!");
            da = new double[n, n];
            
            //
            // 1. factorize matrix
            // 3. solve
            //
            for(i=0; i<=n-1; i++)
            {
                for(i_=0; i_<=n-1;i_++)
                {
                    da[i,i_] = a[i,i_];
                }
            }
            trfac.rmatrixlu(da, n, n, ref p, _params);
            if( rfs )
            {
                rmatrixlusolveinternal(da, p, n, a, true, b, m, ref x, rep, _params);
            }
            else
            {
                rmatrixlusolveinternal(da, p, n, emptya, false, b, m, ref x, rep, _params);
            }
        }


        /*************************************************************************
        Dense solver.

        Similar to RMatrixSolve() but solves task with multiple right parts (where
        b and x are NxM matrices). This is "fast" version of linear  solver  which
        does NOT offer additional functions like condition  number  estimation  or
        iterative refinement.

        Algorithm features:
        * O(N^3+M*N^2) complexity
        * no additional functionality, highest performance

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size
            RFS     -   iterative refinement switch:
                        * True - refinement is used.
                          Less performance, more precision.
                        * False - refinement is not used.
                          More performance, less precision.

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            B       -   array[N]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros
                        
        RETURNS:
            True for well-conditioned matrix
            False for extremely badly conditioned or exactly singular problem

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static bool rmatrixsolvemfast(double[,] a,
            int n,
            double[,] b,
            int m,
            alglib.xparams _params)
        {
            bool result = new bool();
            double v = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            int[] p = new int[0];

            a = (double[,])a.Clone();

            alglib.ap.assert(n>0, "RMatrixSolveMFast: N<=0");
            alglib.ap.assert(m>0, "RMatrixSolveMFast: M<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "RMatrixSolveMFast: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "RMatrixSolveMFast: cols(A)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "RMatrixSolveMFast: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "RMatrixSolveMFast: cols(B)<M");
            alglib.ap.assert(apserv.apservisfinitematrix(a, n, n, _params), "RMatrixSolveMFast: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.apservisfinitematrix(b, n, m, _params), "RMatrixSolveMFast: B contains infinite or NaN values!");
            result = true;
            trfac.rmatrixlu(a, n, n, ref p, _params);
            for(i=0; i<=n-1; i++)
            {
                if( (double)(a[i,i])==(double)(0) )
                {
                    for(j=0; j<=n-1; j++)
                    {
                        for(k=0; k<=m-1; k++)
                        {
                            b[j,k] = 0.0;
                        }
                    }
                    result = false;
                    return result;
                }
            }
            
            //
            // Solve with TRSM()
            //
            for(i=0; i<=n-1; i++)
            {
                if( p[i]!=i )
                {
                    for(j=0; j<=m-1; j++)
                    {
                        v = b[i,j];
                        b[i,j] = b[p[i],j];
                        b[p[i],j] = v;
                    }
                }
            }
            ablas.rmatrixlefttrsm(n, m, a, 0, 0, false, true, 0, b, 0, 0, _params);
            ablas.rmatrixlefttrsm(n, m, a, 0, 0, true, false, 0, b, 0, 0, _params);
            return result;
        }


        /*************************************************************************
        Dense solver.

        This  subroutine  solves  a  system  A*x=b,  where A is NxN non-denegerate
        real matrix given by its LU decomposition, x and b are real vectors.  This
        is "slow-but-robust" version of the linear LU-based solver. Faster version
        is RMatrixLUSolveFast() function.

        Algorithm features:
        * automatic detection of degenerate cases
        * O(N^2) complexity
        * condition number estimation

        No iterative refinement  is provided because exact form of original matrix
        is not known to subroutine. Use RMatrixSolve or RMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which results in 10-15x  performance  penalty  when  compared
                   ! with "fast" version which just calls triangular solver.
                   !
                   ! This performance penalty is insignificant  when compared with
                   ! cost of large LU decomposition.  However,  if you  call  this
                   ! function many times for the same  left  side,  this  overhead
                   ! BECOMES significant. It  also  becomes significant for small-
                   ! scale problems.
                   !
                   ! In such cases we strongly recommend you to use faster solver,
                   ! RMatrixLUSolveFast() function.

        INPUT PARAMETERS
            LUA     -   array[N,N], LU decomposition, RMatrixLU result
            P       -   array[N], pivots array, RMatrixLU result
            N       -   size of A
            B       -   array[N], right part

        OUTPUT PARAMETERS
            Rep     -   additional report, the following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned matrix
                        * rep.r1                condition number in 1-norm
                        * rep.rinf              condition number in inf-norm
            X       -   array[N], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

            
          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void rmatrixlusolve(double[,] lua,
            int[] p,
            int n,
            double[] b,
            ref double[] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            double[,] bm = new double[0,0];
            double[,] xm = new double[0,0];
            int i = 0;

            x = new double[0];

            alglib.ap.assert(n>0, "RMatrixLUSolve: N<=0");
            alglib.ap.assert(alglib.ap.rows(lua)>=n, "RMatrixLUSolve: rows(LUA)<N");
            alglib.ap.assert(alglib.ap.cols(lua)>=n, "RMatrixLUSolve: cols(LUA)<N");
            alglib.ap.assert(alglib.ap.len(p)>=n, "RMatrixLUSolve: length(P)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "RMatrixLUSolve: length(B)<N");
            alglib.ap.assert(apserv.apservisfinitematrix(lua, n, n, _params), "RMatrixLUSolve: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "RMatrixLUSolve: B contains infinite or NaN values!");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=0 && p[i]<n, "RMatrixLUSolve: P contains values outside of [0,N)");
            }
            bm = new double[n, 1];
            ablasf.rcopyvc(n, b, bm, 0, _params);
            rmatrixlusolvem(lua, p, n, bm, 1, ref xm, rep, _params);
            x = new double[n];
            ablasf.rcopycv(n, xm, 0, x, _params);
        }


        /*************************************************************************
        Dense solver.

        This  subroutine  solves  a  system  A*x=b,  where A is NxN non-denegerate
        real matrix given by its LU decomposition, x and b are real vectors.  This
        is "fast-without-any-checks" version of the linear LU-based solver. Slower
        but more robust version is RMatrixLUSolve() function.

        Algorithm features:
        * O(N^2) complexity
        * fast algorithm without ANY additional checks, just triangular solver

        INPUT PARAMETERS
            LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
            P       -   array[0..N-1], pivots array, RMatrixLU result
            N       -   size of A
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            B       -   array[N]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or exactly singular system


          -- ALGLIB --
             Copyright 18.03.2015 by Bochkanov Sergey
        *************************************************************************/
        public static bool rmatrixlusolvefast(double[,] lua,
            int[] p,
            int n,
            double[] b,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;
            int j = 0;

            alglib.ap.assert(n>0, "RMatrixLUSolveFast: N<=0");
            alglib.ap.assert(alglib.ap.rows(lua)>=n, "RMatrixLUSolveFast: rows(LUA)<N");
            alglib.ap.assert(alglib.ap.cols(lua)>=n, "RMatrixLUSolveFast: cols(LUA)<N");
            alglib.ap.assert(alglib.ap.len(p)>=n, "RMatrixLUSolveFast: length(P)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "RMatrixLUSolveFast: length(B)<N");
            alglib.ap.assert(apserv.apservisfinitematrix(lua, n, n, _params), "RMatrixLUSolveFast: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "RMatrixLUSolveFast: B contains infinite or NaN values!");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=0 && p[i]<n, "RMatrixLUSolve: P contains values outside of [0,N)");
            }
            for(i=0; i<=n-1; i++)
            {
                if( (double)(lua[i,i])==(double)(0) )
                {
                    for(j=0; j<=n-1; j++)
                    {
                        b[j] = 0.0;
                    }
                    result = false;
                    return result;
                }
            }
            result = true;
            rbasiclusolve(lua, p, n, b, _params);
            return result;
        }


        /*************************************************************************
        Dense solver.

        Similar to RMatrixLUSolve() but solves  task  with  multiple  right  parts
        (where b and x are NxM matrices). This  is  "robust-but-slow"  version  of
        LU-based solver which performs additional  checks  for  non-degeneracy  of
        inputs (condition number estimation). If you need  best  performance,  use
        "fast-without-any-checks" version, RMatrixLUSolveMFast().

        Algorithm features:
        * automatic detection of degenerate cases
        * O(M*N^2) complexity
        * condition number estimation

        No iterative refinement  is provided because exact form of original matrix
        is not known to subroutine. Use RMatrixSolve or RMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which  results  in  significant  performance   penalty   when
                   ! compared with "fast"  version  which  just  calls  triangular
                   ! solver.
                   !
                   ! This performance penalty is especially apparent when you  use
                   ! ALGLIB parallel capabilities (condition number estimation  is
                   ! inherently  sequential).  It   also   becomes significant for
                   ! small-scale problems.
                   !
                   ! In such cases we strongly recommend you to use faster solver,
                   ! RMatrixLUSolveMFast() function.
          
        INPUT PARAMETERS
            LUA     -   array[N,N], LU decomposition, RMatrixLU result
            P       -   array[N], pivots array, RMatrixLU result
            N       -   size of A
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned matrix
                        * rep.r1                condition number in 1-norm
                        * rep.rinf              condition number in inf-norm
            X       -   array[N,M], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void rmatrixlusolvem(double[,] lua,
            int[] p,
            int n,
            double[,] b,
            int m,
            ref double[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            double[,] emptya = new double[0,0];
            int i = 0;

            x = new double[0,0];

            alglib.ap.assert(n>0, "RMatrixLUSolveM: N<=0");
            alglib.ap.assert(m>0, "RMatrixLUSolveM: M<=0");
            alglib.ap.assert(alglib.ap.rows(lua)>=n, "RMatrixLUSolveM: rows(LUA)<N");
            alglib.ap.assert(alglib.ap.cols(lua)>=n, "RMatrixLUSolveM: cols(LUA)<N");
            alglib.ap.assert(alglib.ap.len(p)>=n, "RMatrixLUSolveM: length(P)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "RMatrixLUSolveM: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "RMatrixLUSolveM: cols(B)<M");
            alglib.ap.assert(apserv.apservisfinitematrix(lua, n, n, _params), "RMatrixLUSolveM: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.apservisfinitematrix(b, n, m, _params), "RMatrixLUSolveM: LUA contains infinite or NaN values!");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=0 && p[i]<n, "RMatrixLUSolve: P contains values outside of [0,N)");
            }
            rmatrixlusolveinternal(lua, p, n, emptya, false, b, m, ref x, rep, _params);
        }


        /*************************************************************************
        Dense solver.

        Similar to RMatrixLUSolve() but solves  task  with  multiple  right parts,
        where b and x are NxM matrices.  This is "fast-without-any-checks" version
        of LU-based solver. It does not estimate  condition number  of  a  system,
        so it is extremely fast. If you need better detection  of  near-degenerate
        cases, use RMatrixLUSolveM() function.

        Algorithm features:
        * O(M*N^2) complexity
        * fast algorithm without ANY additional checks, just triangular solver

        INPUT PARAMETERS:
            LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
            P       -   array[0..N-1], pivots array, RMatrixLU result
            N       -   size of A
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS:
            B       -   array[N,M]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or exactly singular system

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 18.03.2015 by Bochkanov Sergey
        *************************************************************************/
        public static bool rmatrixlusolvemfast(double[,] lua,
            int[] p,
            int n,
            double[,] b,
            int m,
            alglib.xparams _params)
        {
            bool result = new bool();
            double v = 0;
            int i = 0;
            int j = 0;
            int k = 0;

            
            //
            // Check for exact degeneracy
            //
            alglib.ap.assert(n>0, "RMatrixLUSolveMFast: N<=0");
            alglib.ap.assert(m>0, "RMatrixLUSolveMFast: M<=0");
            alglib.ap.assert(alglib.ap.rows(lua)>=n, "RMatrixLUSolveMFast: rows(LUA)<N");
            alglib.ap.assert(alglib.ap.cols(lua)>=n, "RMatrixLUSolveMFast: cols(LUA)<N");
            alglib.ap.assert(alglib.ap.len(p)>=n, "RMatrixLUSolveMFast: length(P)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "RMatrixLUSolveMFast: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "RMatrixLUSolveMFast: cols(B)<M");
            alglib.ap.assert(apserv.apservisfinitematrix(lua, n, n, _params), "RMatrixLUSolveMFast: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.apservisfinitematrix(b, n, m, _params), "RMatrixLUSolveMFast: LUA contains infinite or NaN values!");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=0 && p[i]<n, "RMatrixLUSolve: P contains values outside of [0,N)");
            }
            for(i=0; i<=n-1; i++)
            {
                if( (double)(lua[i,i])==(double)(0) )
                {
                    for(j=0; j<=n-1; j++)
                    {
                        for(k=0; k<=m-1; k++)
                        {
                            b[j,k] = 0.0;
                        }
                    }
                    result = false;
                    return result;
                }
            }
            result = true;
            
            //
            // Solve with TRSM()
            //
            for(i=0; i<=n-1; i++)
            {
                if( p[i]!=i )
                {
                    for(j=0; j<=m-1; j++)
                    {
                        v = b[i,j];
                        b[i,j] = b[p[i],j];
                        b[p[i],j] = v;
                    }
                }
            }
            ablas.rmatrixlefttrsm(n, m, lua, 0, 0, false, true, 0, b, 0, 0, _params);
            ablas.rmatrixlefttrsm(n, m, lua, 0, 0, true, false, 0, b, 0, 0, _params);
            return result;
        }


        /*************************************************************************
        Dense solver.

        This  subroutine  solves  a  system  A*x=b,  where BOTH ORIGINAL A AND ITS
        LU DECOMPOSITION ARE KNOWN. You can use it if for some  reasons  you  have
        both A and its LU decomposition.

        Algorithm features:
        * automatic detection of degenerate cases
        * condition number estimation
        * iterative refinement
        * O(N^2) complexity

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
            P       -   array[0..N-1], pivots array, RMatrixLU result
            N       -   size of A
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void rmatrixmixedsolve(double[,] a,
            double[,] lua,
            int[] p,
            int n,
            double[] b,
            ref double[] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            double[,] bm = new double[0,0];
            double[,] xm = new double[0,0];
            int i = 0;

            x = new double[0];

            alglib.ap.assert(n>0, "RMatrixMixedSolve: N<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "RMatrixMixedSolve: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "RMatrixMixedSolve: cols(A)<N");
            alglib.ap.assert(alglib.ap.rows(lua)>=n, "RMatrixMixedSolve: rows(LUA)<N");
            alglib.ap.assert(alglib.ap.cols(lua)>=n, "RMatrixMixedSolve: cols(LUA)<N");
            alglib.ap.assert(alglib.ap.len(p)>=n, "RMatrixMixedSolve: length(P)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "RMatrixMixedSolve: length(B)<N");
            alglib.ap.assert(apserv.apservisfinitematrix(a, n, n, _params), "RMatrixMixedSolve: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.apservisfinitematrix(lua, n, n, _params), "RMatrixMixedSolve: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "RMatrixMixedSolve: B contains infinite or NaN values!");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=0 && p[i]<n, "RMatrixLUSolve: P contains values outside of [0,N)");
            }
            bm = new double[n, 1];
            ablasf.rcopyvc(n, b, bm, 0, _params);
            rmatrixmixedsolvem(a, lua, p, n, bm, 1, ref xm, rep, _params);
            x = new double[n];
            ablasf.rcopycv(n, xm, 0, x, _params);
        }


        /*************************************************************************
        Dense solver.

        Similar to RMatrixMixedSolve() but  solves task with multiple right  parts
        (where b and x are NxM matrices).

        Algorithm features:
        * automatic detection of degenerate cases
        * condition number estimation
        * iterative refinement
        * O(M*N^2) complexity

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
            P       -   array[0..N-1], pivots array, RMatrixLU result
            N       -   size of A
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N,M], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void rmatrixmixedsolvem(double[,] a,
            double[,] lua,
            int[] p,
            int n,
            double[,] b,
            int m,
            ref double[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            int i = 0;

            x = new double[0,0];

            alglib.ap.assert(n>0, "RMatrixMixedSolveM: N<=0");
            alglib.ap.assert(m>0, "RMatrixMixedSolveM: M<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "RMatrixMixedSolve: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "RMatrixMixedSolve: cols(A)<N");
            alglib.ap.assert(alglib.ap.rows(lua)>=n, "RMatrixMixedSolve: rows(LUA)<N");
            alglib.ap.assert(alglib.ap.cols(lua)>=n, "RMatrixMixedSolve: cols(LUA)<N");
            alglib.ap.assert(alglib.ap.len(p)>=n, "RMatrixMixedSolve: length(P)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "RMatrixMixedSolve: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "RMatrixMixedSolve: cols(B)<M");
            alglib.ap.assert(apserv.apservisfinitematrix(a, n, n, _params), "RMatrixMixedSolve: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.apservisfinitematrix(lua, n, n, _params), "RMatrixMixedSolve: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.apservisfinitematrix(b, n, m, _params), "RMatrixMixedSolve: B contains infinite or NaN values!");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=0 && p[i]<n, "RMatrixLUSolve: P contains values outside of [0,N)");
            }
            rmatrixlusolveinternal(lua, p, n, a, true, b, m, ref x, rep, _params);
        }


        /*************************************************************************
        Complex dense solver for A*X=B with N*N  complex  matrix  A,  N*M  complex
        matrices  X  and  B.  "Slow-but-feature-rich"   version   which   provides
        additional functions, at the cost of slower  performance.  Faster  version
        may be invoked with CMatrixSolveMFast() function.

        Algorithm features:
        * automatic detection of degenerate cases
        * condition number estimation
        * iterative refinement
        * O(N^3+M*N^2) complexity

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear  system
                   ! and  performs  iterative   refinement,   which   results   in
                   ! significant performance penalty  when  compared  with  "fast"
                   ! version  which  just  performs  LU  decomposition  and  calls
                   ! triangular solver.
                   !
                   ! This  performance  penalty  is  especially  visible  in   the
                   ! multithreaded mode, because both condition number  estimation
                   ! and   iterative    refinement   are   inherently   sequential
                   ! calculations.
                   !
                   ! Thus, if you need high performance and if you are pretty sure
                   ! that your system is well conditioned, we  strongly  recommend
                   ! you to use faster solver, CMatrixSolveMFast() function.

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size
            RFS     -   iterative refinement switch:
                        * True - refinement is used.
                          Less performance, more precision.
                        * False - refinement is not used.
                          More performance, less precision.

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or exactly singular matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N,M], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void cmatrixsolvem(complex[,] a,
            int n,
            complex[,] b,
            int m,
            bool rfs,
            ref complex[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            complex[,] da = new complex[0,0];
            complex[,] emptya = new complex[0,0];
            int[] p = new int[0];
            int i = 0;
            int i_ = 0;

            x = new complex[0,0];

            alglib.ap.assert(n>0, "CMatrixSolveM: N<=0");
            alglib.ap.assert(m>0, "CMatrixSolveM: M<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "CMatrixSolveM: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "CMatrixSolveM: cols(A)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "CMatrixSolveM: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "CMatrixSolveM: cols(B)<M");
            alglib.ap.assert(apserv.isfinitecmatrix(a, n, n, _params), "CMatrixSolveM: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecmatrix(b, n, m, _params), "CMatrixSolveM: B contains infinite or NaN values!");
            da = new complex[n, n];
            
            //
            // factorize, solve
            //
            for(i=0; i<=n-1; i++)
            {
                for(i_=0; i_<=n-1;i_++)
                {
                    da[i,i_] = a[i,i_];
                }
            }
            trfac.cmatrixlu(da, n, n, ref p, _params);
            if( rfs )
            {
                cmatrixlusolveinternal(da, p, n, a, true, b, m, ref x, rep, _params);
            }
            else
            {
                cmatrixlusolveinternal(da, p, n, emptya, false, b, m, ref x, rep, _params);
            }
        }


        /*************************************************************************
        Complex dense solver for A*X=B with N*N  complex  matrix  A,  N*M  complex
        matrices  X  and  B.  "Fast-but-lightweight" version which  provides  just
        triangular solver - and no additional functions like iterative  refinement
        or condition number estimation.

        Algorithm features:
        * O(N^3+M*N^2) complexity
        * no additional time consuming functions

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS:
            B       -   array[N,M]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or exactly singular system

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 16.03.2015 by Bochkanov Sergey
        *************************************************************************/
        public static bool cmatrixsolvemfast(complex[,] a,
            int n,
            complex[,] b,
            int m,
            alglib.xparams _params)
        {
            bool result = new bool();
            complex v = 0;
            int i = 0;
            int j = 0;
            int k = 0;
            int[] p = new int[0];

            a = (complex[,])a.Clone();

            alglib.ap.assert(n>0, "CMatrixSolveMFast: N<=0");
            alglib.ap.assert(m>0, "CMatrixSolveMFast: M<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "CMatrixSolveMFast: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "CMatrixSolveMFast: cols(A)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "CMatrixSolveMFast: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "CMatrixSolveMFast: cols(B)<M");
            alglib.ap.assert(apserv.isfinitecmatrix(a, n, n, _params), "CMatrixSolveMFast: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecmatrix(b, n, m, _params), "CMatrixSolveMFast: B contains infinite or NaN values!");
            
            //
            // Check for exact degeneracy
            //
            trfac.cmatrixlu(a, n, n, ref p, _params);
            for(i=0; i<=n-1; i++)
            {
                if( a[i,i]==0 )
                {
                    for(j=0; j<=n-1; j++)
                    {
                        for(k=0; k<=m-1; k++)
                        {
                            b[j,k] = 0.0;
                        }
                    }
                    result = false;
                    return result;
                }
            }
            result = true;
            
            //
            // Solve with TRSM()
            //
            for(i=0; i<=n-1; i++)
            {
                if( p[i]!=i )
                {
                    for(j=0; j<=m-1; j++)
                    {
                        v = b[i,j];
                        b[i,j] = b[p[i],j];
                        b[p[i],j] = v;
                    }
                }
            }
            ablas.cmatrixlefttrsm(n, m, a, 0, 0, false, true, 0, b, 0, 0, _params);
            ablas.cmatrixlefttrsm(n, m, a, 0, 0, true, false, 0, b, 0, 0, _params);
            return result;
        }


        /*************************************************************************
        Complex dense solver for A*x=B with N*N complex matrix A and  N*1  complex
        vectors x and b. "Slow-but-feature-rich" version of the solver.

        Algorithm features:
        * automatic detection of degenerate cases
        * condition number estimation
        * iterative refinement
        * O(N^3) complexity

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear  system
                   ! and  performs  iterative   refinement,   which   results   in
                   ! significant performance penalty  when  compared  with  "fast"
                   ! version  which  just  performs  LU  decomposition  and  calls
                   ! triangular solver.
                   !
                   ! This  performance  penalty  is  especially  visible  in   the
                   ! multithreaded mode, because both condition number  estimation
                   ! and   iterative    refinement   are   inherently   sequential
                   ! calculations.
                   !
                   ! Thus, if you need high performance and if you are pretty sure
                   ! that your system is well conditioned, we  strongly  recommend
                   ! you to use faster solver, CMatrixSolveFast() function.

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or exactly singular matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void cmatrixsolve(complex[,] a,
            int n,
            complex[] b,
            ref complex[] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            complex[,] bm = new complex[0,0];
            complex[,] xm = new complex[0,0];
            int i_ = 0;

            x = new complex[0];

            alglib.ap.assert(n>0, "CMatrixSolve: N<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "CMatrixSolve: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "CMatrixSolve: cols(A)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "CMatrixSolve: length(B)<N");
            alglib.ap.assert(apserv.isfinitecmatrix(a, n, n, _params), "CMatrixSolve: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecvector(b, n, _params), "CMatrixSolve: B contains infinite or NaN values!");
            bm = new complex[n, 1];
            for(i_=0; i_<=n-1;i_++)
            {
                bm[i_,0] = b[i_];
            }
            cmatrixsolvem(a, n, bm, 1, true, ref xm, rep, _params);
            x = new complex[n];
            for(i_=0; i_<=n-1;i_++)
            {
                x[i_] = xm[i_,0];
            }
        }


        /*************************************************************************
        Complex dense solver for A*x=B with N*N complex matrix A and  N*1  complex
        vectors x and b. "Fast-but-lightweight" version of the solver.

        Algorithm features:
        * O(N^3) complexity
        * no additional time consuming features, just triangular solver

        INPUT PARAMETERS:
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS:
            B       -   array[N]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or exactly singular system

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static bool cmatrixsolvefast(complex[,] a,
            int n,
            complex[] b,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;
            int j = 0;
            int[] p = new int[0];

            a = (complex[,])a.Clone();

            alglib.ap.assert(n>0, "CMatrixSolveFast: N<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "CMatrixSolveFast: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "CMatrixSolveFast: cols(A)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "CMatrixSolveFast: length(B)<N");
            alglib.ap.assert(apserv.isfinitecmatrix(a, n, n, _params), "CMatrixSolveFast: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecvector(b, n, _params), "CMatrixSolveFast: B contains infinite or NaN values!");
            trfac.cmatrixlu(a, n, n, ref p, _params);
            for(i=0; i<=n-1; i++)
            {
                if( a[i,i]==0 )
                {
                    for(j=0; j<=n-1; j++)
                    {
                        b[j] = 0.0;
                    }
                    result = false;
                    return result;
                }
            }
            cbasiclusolve(a, p, n, b, _params);
            result = true;
            return result;
        }


        /*************************************************************************
        Dense solver for A*X=B with N*N complex A given by its  LU  decomposition,
        and N*M matrices X and B (multiple right sides).   "Slow-but-feature-rich"
        version of the solver.

        Algorithm features:
        * automatic detection of degenerate cases
        * O(M*N^2) complexity
        * condition number estimation

        No iterative refinement  is provided because exact form of original matrix
        is not known to subroutine. Use CMatrixSolve or CMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which  results  in  significant  performance   penalty   when
                   ! compared with "fast"  version  which  just  calls  triangular
                   ! solver.
                   !
                   ! This performance penalty is especially apparent when you  use
                   ! ALGLIB parallel capabilities (condition number estimation  is
                   ! inherently  sequential).  It   also   becomes significant for
                   ! small-scale problems.
                   !
                   ! In such cases we strongly recommend you to use faster solver,
                   ! CMatrixLUSolveMFast() function.

        INPUT PARAMETERS
            LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
            P       -   array[0..N-1], pivots array, RMatrixLU result
            N       -   size of A
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or exactly singular matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N,M], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void cmatrixlusolvem(complex[,] lua,
            int[] p,
            int n,
            complex[,] b,
            int m,
            ref complex[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            complex[,] emptya = new complex[0,0];
            int i = 0;

            x = new complex[0,0];

            alglib.ap.assert(n>0, "CMatrixLUSolveM: N<=0");
            alglib.ap.assert(m>0, "CMatrixLUSolveM: M<=0");
            alglib.ap.assert(alglib.ap.rows(lua)>=n, "CMatrixLUSolveM: rows(LUA)<N");
            alglib.ap.assert(alglib.ap.cols(lua)>=n, "CMatrixLUSolveM: cols(LUA)<N");
            alglib.ap.assert(alglib.ap.len(p)>=n, "CMatrixLUSolveM: length(P)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "CMatrixLUSolveM: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "CMatrixLUSolveM: cols(B)<M");
            alglib.ap.assert(apserv.isfinitecmatrix(lua, n, n, _params), "CMatrixLUSolveM: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecmatrix(b, n, m, _params), "CMatrixLUSolveM: LUA contains infinite or NaN values!");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=0 && p[i]<n, "CMatrixLUSolveM: P contains values outside of [0,N)");
            }
            cmatrixlusolveinternal(lua, p, n, emptya, false, b, m, ref x, rep, _params);
        }


        /*************************************************************************
        Dense solver for A*X=B with N*N complex A given by its  LU  decomposition,
        and N*M matrices X and B (multiple  right  sides).  "Fast-but-lightweight"
        version of the solver.

        Algorithm features:
        * O(M*N^2) complexity
        * no additional time-consuming features

        INPUT PARAMETERS
            LUA     -   array[0..N-1,0..N-1], LU decomposition, RMatrixLU result
            P       -   array[0..N-1], pivots array, RMatrixLU result
            N       -   size of A
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS
            B       -   array[N,M]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or exactly singular system

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static bool cmatrixlusolvemfast(complex[,] lua,
            int[] p,
            int n,
            complex[,] b,
            int m,
            alglib.xparams _params)
        {
            bool result = new bool();
            complex v = 0;
            int i = 0;
            int j = 0;
            int k = 0;

            alglib.ap.assert(n>0, "CMatrixLUSolveMFast: N<=0");
            alglib.ap.assert(m>0, "CMatrixLUSolveMFast: M<=0");
            alglib.ap.assert(alglib.ap.rows(lua)>=n, "CMatrixLUSolveMFast: rows(LUA)<N");
            alglib.ap.assert(alglib.ap.cols(lua)>=n, "CMatrixLUSolveMFast: cols(LUA)<N");
            alglib.ap.assert(alglib.ap.len(p)>=n, "CMatrixLUSolveMFast: length(P)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "CMatrixLUSolveMFast: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "CMatrixLUSolveMFast: cols(B)<M");
            alglib.ap.assert(apserv.isfinitecmatrix(lua, n, n, _params), "CMatrixLUSolveMFast: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecmatrix(b, n, m, _params), "CMatrixLUSolveMFast: LUA contains infinite or NaN values!");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=0 && p[i]<n, "RMatrixLUSolve: P contains values outside of [0,N)");
            }
            
            //
            // Check for exact degeneracy
            //
            for(i=0; i<=n-1; i++)
            {
                if( lua[i,i]==0 )
                {
                    for(j=0; j<=n-1; j++)
                    {
                        for(k=0; k<=m-1; k++)
                        {
                            b[j,k] = 0.0;
                        }
                    }
                    result = false;
                    return result;
                }
            }
            result = true;
            
            //
            // Solve with TRSM()
            //
            for(i=0; i<=n-1; i++)
            {
                if( p[i]!=i )
                {
                    for(j=0; j<=m-1; j++)
                    {
                        v = b[i,j];
                        b[i,j] = b[p[i],j];
                        b[p[i],j] = v;
                    }
                }
            }
            ablas.cmatrixlefttrsm(n, m, lua, 0, 0, false, true, 0, b, 0, 0, _params);
            ablas.cmatrixlefttrsm(n, m, lua, 0, 0, true, false, 0, b, 0, 0, _params);
            return result;
        }


        /*************************************************************************
        Complex dense linear solver for A*x=b with complex N*N A  given  by its LU
        decomposition and N*1 vectors x and b. This is  "slow-but-robust"  version
        of  the  complex  linear  solver  with  additional  features   which   add
        significant performance overhead. Faster version  is  CMatrixLUSolveFast()
        function.

        Algorithm features:
        * automatic detection of degenerate cases
        * O(N^2) complexity
        * condition number estimation

        No iterative refinement is provided because exact form of original matrix
        is not known to subroutine. Use CMatrixSolve or CMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which results in 10-15x  performance  penalty  when  compared
                   ! with "fast" version which just calls triangular solver.
                   !
                   ! This performance penalty is insignificant  when compared with
                   ! cost of large LU decomposition.  However,  if you  call  this
                   ! function many times for the same  left  side,  this  overhead
                   ! BECOMES significant. It  also  becomes significant for small-
                   ! scale problems.
                   !
                   ! In such cases we strongly recommend you to use faster solver,
                   ! CMatrixLUSolveFast() function.

        INPUT PARAMETERS
            LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
            P       -   array[0..N-1], pivots array, CMatrixLU result
            N       -   size of A
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or exactly singular matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void cmatrixlusolve(complex[,] lua,
            int[] p,
            int n,
            complex[] b,
            ref complex[] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            complex[,] bm = new complex[0,0];
            complex[,] xm = new complex[0,0];
            int i = 0;
            int i_ = 0;

            x = new complex[0];

            alglib.ap.assert(n>0, "CMatrixLUSolve: N<=0");
            alglib.ap.assert(alglib.ap.rows(lua)>=n, "CMatrixLUSolve: rows(LUA)<N");
            alglib.ap.assert(alglib.ap.cols(lua)>=n, "CMatrixLUSolve: cols(LUA)<N");
            alglib.ap.assert(alglib.ap.len(p)>=n, "CMatrixLUSolve: length(P)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "CMatrixLUSolve: length(B)<N");
            alglib.ap.assert(apserv.isfinitecmatrix(lua, n, n, _params), "CMatrixLUSolve: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecvector(b, n, _params), "CMatrixLUSolve: B contains infinite or NaN values!");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=0 && p[i]<n, "CMatrixLUSolve: P contains values outside of [0,N)");
            }
            bm = new complex[n, 1];
            for(i_=0; i_<=n-1;i_++)
            {
                bm[i_,0] = b[i_];
            }
            cmatrixlusolvem(lua, p, n, bm, 1, ref xm, rep, _params);
            x = new complex[n];
            for(i_=0; i_<=n-1;i_++)
            {
                x[i_] = xm[i_,0];
            }
        }


        /*************************************************************************
        Complex dense linear solver for A*x=b with N*N complex A given by  its  LU
        decomposition and N*1 vectors x and b. This is  fast  lightweight  version
        of solver, which is significantly faster than CMatrixLUSolve(),  but  does
        not provide additional information (like condition numbers).

        Algorithm features:
        * O(N^2) complexity
        * no additional time-consuming features, just triangular solver

        INPUT PARAMETERS
            LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
            P       -   array[0..N-1], pivots array, CMatrixLU result
            N       -   size of A
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            B       -   array[N]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros
            
        NOTE: unlike  CMatrixLUSolve(),  this   function   does   NOT   check  for
              near-degeneracy of input matrix. It  checks  for  EXACT  degeneracy,
              because this check is easy to do. However,  very  badly  conditioned
              matrices may went unnoticed.


          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static bool cmatrixlusolvefast(complex[,] lua,
            int[] p,
            int n,
            complex[] b,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;
            int j = 0;

            alglib.ap.assert(n>0, "CMatrixLUSolveFast: N<=0");
            alglib.ap.assert(alglib.ap.rows(lua)>=n, "CMatrixLUSolveFast: rows(LUA)<N");
            alglib.ap.assert(alglib.ap.cols(lua)>=n, "CMatrixLUSolveFast: cols(LUA)<N");
            alglib.ap.assert(alglib.ap.len(p)>=n, "CMatrixLUSolveFast: length(P)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "CMatrixLUSolveFast: length(B)<N");
            alglib.ap.assert(apserv.isfinitecmatrix(lua, n, n, _params), "CMatrixLUSolveFast: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecvector(b, n, _params), "CMatrixLUSolveFast: B contains infinite or NaN values!");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=0 && p[i]<n, "CMatrixLUSolveFast: P contains values outside of [0,N)");
            }
            for(i=0; i<=n-1; i++)
            {
                if( lua[i,i]==0 )
                {
                    for(j=0; j<=n-1; j++)
                    {
                        b[j] = 0.0;
                    }
                    result = false;
                    return result;
                }
            }
            cbasiclusolve(lua, p, n, b, _params);
            result = true;
            return result;
        }


        /*************************************************************************
        Dense solver. Same as RMatrixMixedSolveM(), but for complex matrices.

        Algorithm features:
        * automatic detection of degenerate cases
        * condition number estimation
        * iterative refinement
        * O(M*N^2) complexity

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
            P       -   array[0..N-1], pivots array, CMatrixLU result
            N       -   size of A
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or exactly singular matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N,M], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void cmatrixmixedsolvem(complex[,] a,
            complex[,] lua,
            int[] p,
            int n,
            complex[,] b,
            int m,
            ref complex[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            int i = 0;

            x = new complex[0,0];

            alglib.ap.assert(n>0, "CMatrixMixedSolveM: N<=0");
            alglib.ap.assert(m>0, "CMatrixMixedSolveM: M<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "CMatrixMixedSolveM: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "CMatrixMixedSolveM: cols(A)<N");
            alglib.ap.assert(alglib.ap.rows(lua)>=n, "CMatrixMixedSolveM: rows(LUA)<N");
            alglib.ap.assert(alglib.ap.cols(lua)>=n, "CMatrixMixedSolveM: cols(LUA)<N");
            alglib.ap.assert(alglib.ap.len(p)>=n, "CMatrixMixedSolveM: length(P)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "CMatrixMixedSolveM: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "CMatrixMixedSolveM: cols(B)<M");
            alglib.ap.assert(apserv.isfinitecmatrix(a, n, n, _params), "CMatrixMixedSolveM: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecmatrix(lua, n, n, _params), "CMatrixMixedSolveM: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecmatrix(b, n, m, _params), "CMatrixMixedSolveM: B contains infinite or NaN values!");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=0 && p[i]<n, "CMatrixMixedSolveM: P contains values outside of [0,N)");
            }
            cmatrixlusolveinternal(lua, p, n, a, true, b, m, ref x, rep, _params);
        }


        /*************************************************************************
        Dense solver. Same as RMatrixMixedSolve(), but for complex matrices.

        Algorithm features:
        * automatic detection of degenerate cases
        * condition number estimation
        * iterative refinement
        * O(N^2) complexity

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            LUA     -   array[0..N-1,0..N-1], LU decomposition, CMatrixLU result
            P       -   array[0..N-1], pivots array, CMatrixLU result
            N       -   size of A
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or exactly singular matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void cmatrixmixedsolve(complex[,] a,
            complex[,] lua,
            int[] p,
            int n,
            complex[] b,
            ref complex[] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            complex[,] bm = new complex[0,0];
            complex[,] xm = new complex[0,0];
            int i = 0;
            int i_ = 0;

            x = new complex[0];

            alglib.ap.assert(n>0, "CMatrixMixedSolve: N<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "CMatrixMixedSolve: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "CMatrixMixedSolve: cols(A)<N");
            alglib.ap.assert(alglib.ap.rows(lua)>=n, "CMatrixMixedSolve: rows(LUA)<N");
            alglib.ap.assert(alglib.ap.cols(lua)>=n, "CMatrixMixedSolve: cols(LUA)<N");
            alglib.ap.assert(alglib.ap.len(p)>=n, "CMatrixMixedSolve: length(P)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "CMatrixMixedSolve: length(B)<N");
            alglib.ap.assert(apserv.isfinitecmatrix(a, n, n, _params), "CMatrixMixedSolve: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecmatrix(lua, n, n, _params), "CMatrixMixedSolve: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecvector(b, n, _params), "CMatrixMixedSolve: B contains infinite or NaN values!");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=0 && p[i]<n, "CMatrixMixedSolve: P contains values outside of [0,N)");
            }
            bm = new complex[n, 1];
            for(i_=0; i_<=n-1;i_++)
            {
                bm[i_,0] = b[i_];
            }
            cmatrixmixedsolvem(a, lua, p, n, bm, 1, ref xm, rep, _params);
            x = new complex[n];
            for(i_=0; i_<=n-1;i_++)
            {
                x[i_] = xm[i_,0];
            }
        }


        /*************************************************************************
        Dense solver for A*X=B with N*N symmetric positive definite matrix A,  and
        N*M vectors X and B. It is "slow-but-feature-rich" version of the solver.

        Algorithm features:
        * automatic detection of degenerate cases
        * condition number estimation
        * O(N^3+M*N^2) complexity
        * matrix is represented by its upper or lower triangle

        No iterative refinement is provided because such partial representation of
        matrix does not allow efficient calculation of extra-precise  matrix-vector
        products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which  results  in  significant   performance   penalty  when
                   ! compared with "fast" version  which  just  performs  Cholesky
                   ! decomposition and calls triangular solver.
                   !
                   ! This  performance  penalty  is  especially  visible  in   the
                   ! multithreaded mode, because both condition number  estimation
                   ! and   iterative    refinement   are   inherently   sequential
                   ! calculations.
                   !
                   ! Thus, if you need high performance and if you are pretty sure
                   ! that your system is well conditioned, we  strongly  recommend
                   ! you to use faster solver, SPDMatrixSolveMFast() function.

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            IsUpper -   what half of A is provided
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or indefinite matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N,M], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void spdmatrixsolvem(double[,] a,
            int n,
            bool isupper,
            double[,] b,
            int m,
            ref double[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            double[,] da = new double[0,0];
            int i = 0;
            int j = 0;
            int j1 = 0;
            int j2 = 0;
            int i_ = 0;

            x = new double[0,0];

            alglib.ap.assert(n>0, "SPDMatrixSolveM: N<=0");
            alglib.ap.assert(m>0, "SPDMatrixSolveM: M<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "SPDMatrixSolveM: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "SPDMatrixSolveM: cols(A)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "SPDMatrixSolveM: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "SPDMatrixSolveM: cols(B)<M");
            alglib.ap.assert(apserv.isfinitertrmatrix(a, n, isupper, _params), "SPDMatrixSolveM: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.apservisfinitematrix(b, n, m, _params), "SPDMatrixSolveM: B contains infinite or NaN values!");
            da = new double[n, n];
            
            //
            // factorize
            // solve
            //
            for(i=0; i<=n-1; i++)
            {
                if( isupper )
                {
                    j1 = i;
                    j2 = n-1;
                }
                else
                {
                    j1 = 0;
                    j2 = i;
                }
                for(i_=j1; i_<=j2;i_++)
                {
                    da[i,i_] = a[i,i_];
                }
            }
            if( !trfac.spdmatrixcholesky(da, n, isupper, _params) )
            {
                x = new double[n, m];
                for(i=0; i<=n-1; i++)
                {
                    for(j=0; j<=m-1; j++)
                    {
                        x[i,j] = 0;
                    }
                }
                rep.r1 = 0;
                rep.rinf = 0;
                rep.terminationtype = -3;
                return;
            }
            rep.terminationtype = 1;
            spdmatrixcholeskysolveinternal(da, n, isupper, a, true, b, m, ref x, rep, _params);
        }


        /*************************************************************************
        Dense solver for A*X=B with N*N symmetric positive definite matrix A,  and
        N*M vectors X and B. It is "fast-but-lightweight" version of the solver.

        Algorithm features:
        * O(N^3+M*N^2) complexity
        * matrix is represented by its upper or lower triangle
        * no additional time consuming features

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            IsUpper -   what half of A is provided
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS
            B       -   array[N,M], it contains:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or exactly singular system

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 17.03.2015 by Bochkanov Sergey
        *************************************************************************/
        public static bool spdmatrixsolvemfast(double[,] a,
            int n,
            bool isupper,
            double[,] b,
            int m,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;
            int j = 0;

            a = (double[,])a.Clone();

            alglib.ap.assert(n>0, "SPDMatrixSolveMFast: N<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "SPDMatrixSolveMFast: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "SPDMatrixSolveMFast: cols(A)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "SPDMatrixSolveMFast: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "SPDMatrixSolveMFast: cols(B)<M");
            alglib.ap.assert(apserv.isfinitertrmatrix(a, n, isupper, _params), "SPDMatrixSolveMFast: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.apservisfinitematrix(b, n, m, _params), "SPDMatrixSolveMFast: B contains infinite or NaN values!");
            result = true;
            if( !trfac.spdmatrixcholesky(a, n, isupper, _params) )
            {
                for(i=0; i<=n-1; i++)
                {
                    for(j=0; j<=m-1; j++)
                    {
                        b[i,j] = 0.0;
                    }
                }
                result = false;
                return result;
            }
            if( isupper )
            {
                ablas.rmatrixlefttrsm(n, m, a, 0, 0, true, false, 1, b, 0, 0, _params);
                ablas.rmatrixlefttrsm(n, m, a, 0, 0, true, false, 0, b, 0, 0, _params);
            }
            else
            {
                ablas.rmatrixlefttrsm(n, m, a, 0, 0, false, false, 0, b, 0, 0, _params);
                ablas.rmatrixlefttrsm(n, m, a, 0, 0, false, false, 1, b, 0, 0, _params);
            }
            return result;
        }


        /*************************************************************************
        Dense linear solver for A*x=b with N*N real  symmetric  positive  definite
        matrix A,  N*1 vectors x and b.  "Slow-but-feature-rich"  version  of  the
        solver.

        Algorithm features:
        * automatic detection of degenerate cases
        * condition number estimation
        * O(N^3) complexity
        * matrix is represented by its upper or lower triangle

        No iterative refinement is provided because such partial representation of
        matrix does not allow efficient calculation of extra-precise  matrix-vector
        products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which  results  in  significant   performance   penalty  when
                   ! compared with "fast" version  which  just  performs  Cholesky
                   ! decomposition and calls triangular solver.
                   !
                   ! This  performance  penalty  is  especially  visible  in   the
                   ! multithreaded mode, because both condition number  estimation
                   ! and   iterative    refinement   are   inherently   sequential
                   ! calculations.
                   !
                   ! Thus, if you need high performance and if you are pretty sure
                   ! that your system is well conditioned, we  strongly  recommend
                   ! you to use faster solver, SPDMatrixSolveFast() function.

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            IsUpper -   what half of A is provided
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or indefinite matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void spdmatrixsolve(double[,] a,
            int n,
            bool isupper,
            double[] b,
            ref double[] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            double[,] bm = new double[0,0];
            double[,] xm = new double[0,0];
            int i_ = 0;

            x = new double[0];

            alglib.ap.assert(n>0, "SPDMatrixSolve: N<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "SPDMatrixSolve: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "SPDMatrixSolve: cols(A)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SPDMatrixSolve: length(B)<N");
            alglib.ap.assert(apserv.isfinitertrmatrix(a, n, isupper, _params), "SPDMatrixSolve: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SPDMatrixSolve: B contains infinite or NaN values!");
            bm = new double[n, 1];
            for(i_=0; i_<=n-1;i_++)
            {
                bm[i_,0] = b[i_];
            }
            spdmatrixsolvem(a, n, isupper, bm, 1, ref xm, rep, _params);
            x = new double[n];
            for(i_=0; i_<=n-1;i_++)
            {
                x[i_] = xm[i_,0];
            }
        }


        /*************************************************************************
        Dense linear solver for A*x=b with N*N real  symmetric  positive  definite
        matrix A,  N*1 vectors x and  b.  "Fast-but-lightweight"  version  of  the
        solver.

        Algorithm features:
        * O(N^3) complexity
        * matrix is represented by its upper or lower triangle
        * no additional time consuming features like condition number estimation

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            IsUpper -   what half of A is provided
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            B       -   array[N], it contains:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or exactly singular system

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 17.03.2015 by Bochkanov Sergey
        *************************************************************************/
        public static bool spdmatrixsolvefast(double[,] a,
            int n,
            bool isupper,
            double[] b,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;

            a = (double[,])a.Clone();

            alglib.ap.assert(n>0, "SPDMatrixSolveFast: N<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "SPDMatrixSolveFast: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "SPDMatrixSolveFast: cols(A)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SPDMatrixSolveFast: length(B)<N");
            alglib.ap.assert(apserv.isfinitertrmatrix(a, n, isupper, _params), "SPDMatrixSolveFast: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SPDMatrixSolveFast: B contains infinite or NaN values!");
            result = true;
            if( !trfac.spdmatrixcholesky(a, n, isupper, _params) )
            {
                for(i=0; i<=n-1; i++)
                {
                    b[i] = 0.0;
                }
                result = false;
                return result;
            }
            spdbasiccholeskysolve(a, n, isupper, b, _params);
            return result;
        }


        /*************************************************************************
        Dense solver for A*X=B with N*N symmetric positive definite matrix A given
        by its Cholesky decomposition, and N*M vectors X and B. It  is  "slow-but-
        feature-rich" version of the solver which estimates  condition  number  of
        the system.

        Algorithm features:
        * automatic detection of degenerate cases
        * O(M*N^2) complexity
        * condition number estimation
        * matrix is represented by its upper or lower triangle

        No iterative refinement is provided because such partial representation of
        matrix does not allow efficient calculation of extra-precise  matrix-vector
        products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which  results  in  significant  performance   penalty   when
                   ! compared with "fast"  version  which  just  calls  triangular
                   ! solver. Amount of  overhead  introduced  depends  on  M  (the
                   ! larger - the more efficient).
                   !
                   ! This performance penalty is insignificant  when compared with
                   ! cost of large LU decomposition.  However,  if you  call  this
                   ! function many times for the same  left  side,  this  overhead
                   ! BECOMES significant. It  also  becomes significant for small-
                   ! scale problems (N<50).
                   !
                   ! In such cases we strongly recommend you to use faster solver,
                   ! SPDMatrixCholeskySolveMFast() function.

        INPUT PARAMETERS
            CHA     -   array[0..N-1,0..N-1], Cholesky decomposition,
                        SPDMatrixCholesky result
            N       -   size of CHA
            IsUpper -   what half of CHA is provided
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or indefinite matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N]:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void spdmatrixcholeskysolvem(double[,] cha,
            int n,
            bool isupper,
            double[,] b,
            int m,
            ref double[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            double[,] emptya = new double[0,0];

            x = new double[0,0];

            alglib.ap.assert(n>0, "SPDMatrixCholeskySolveM: N<=0");
            alglib.ap.assert(m>0, "SPDMatrixCholeskySolveM: M<=0");
            alglib.ap.assert(alglib.ap.rows(cha)>=n, "SPDMatrixCholeskySolveM: rows(CHA)<N");
            alglib.ap.assert(alglib.ap.cols(cha)>=n, "SPDMatrixCholeskySolveM: cols(CHA)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "SPDMatrixCholeskySolveM: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "SPDMatrixCholeskySolveM: cols(B)<M");
            alglib.ap.assert(apserv.isfinitertrmatrix(cha, n, isupper, _params), "SPDMatrixCholeskySolveM: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.apservisfinitematrix(b, n, m, _params), "SPDMatrixCholeskySolveM: LUA contains infinite or NaN values!");
            spdmatrixcholeskysolveinternal(cha, n, isupper, emptya, false, b, m, ref x, rep, _params);
        }


        /*************************************************************************
        Dense solver for A*X=B with N*N symmetric positive definite matrix A given
        by its Cholesky decomposition, and N*M vectors X and B. It  is  "fast-but-
        lightweight" version of  the  solver  which  just  solves  linear  system,
        without any additional functions.

        Algorithm features:
        * O(M*N^2) complexity
        * matrix is represented by its upper or lower triangle
        * no additional functionality

        INPUT PARAMETERS
            CHA     -   array[N,N], Cholesky decomposition,
                        SPDMatrixCholesky result
            N       -   size of CHA
            IsUpper -   what half of CHA is provided
            B       -   array[N,M], right part
            M       -   right part size

        OUTPUT PARAMETERS
            B       -   array[N]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or exactly singular system
            
          -- ALGLIB --
             Copyright 18.03.2015 by Bochkanov Sergey
        *************************************************************************/
        public static bool spdmatrixcholeskysolvemfast(double[,] cha,
            int n,
            bool isupper,
            double[,] b,
            int m,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;
            int j = 0;
            int k = 0;

            alglib.ap.assert(n>0, "SPDMatrixCholeskySolveMFast: N<=0");
            alglib.ap.assert(m>0, "SPDMatrixCholeskySolveMFast: M<=0");
            alglib.ap.assert(alglib.ap.rows(cha)>=n, "SPDMatrixCholeskySolveMFast: rows(CHA)<N");
            alglib.ap.assert(alglib.ap.cols(cha)>=n, "SPDMatrixCholeskySolveMFast: cols(CHA)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "SPDMatrixCholeskySolveMFast: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "SPDMatrixCholeskySolveMFast: cols(B)<M");
            alglib.ap.assert(apserv.isfinitertrmatrix(cha, n, isupper, _params), "SPDMatrixCholeskySolveMFast: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.apservisfinitematrix(b, n, m, _params), "SPDMatrixCholeskySolveMFast: LUA contains infinite or NaN values!");
            result = true;
            for(k=0; k<=n-1; k++)
            {
                if( (double)(cha[k,k])==(double)(0.0) )
                {
                    for(i=0; i<=n-1; i++)
                    {
                        for(j=0; j<=m-1; j++)
                        {
                            b[i,j] = 0.0;
                        }
                    }
                    result = false;
                    return result;
                }
            }
            if( isupper )
            {
                ablas.rmatrixlefttrsm(n, m, cha, 0, 0, true, false, 1, b, 0, 0, _params);
                ablas.rmatrixlefttrsm(n, m, cha, 0, 0, true, false, 0, b, 0, 0, _params);
            }
            else
            {
                ablas.rmatrixlefttrsm(n, m, cha, 0, 0, false, false, 0, b, 0, 0, _params);
                ablas.rmatrixlefttrsm(n, m, cha, 0, 0, false, false, 1, b, 0, 0, _params);
            }
            return result;
        }


        /*************************************************************************
        Dense solver for A*x=b with N*N symmetric positive definite matrix A given
        by its Cholesky decomposition, and N*1 real vectors x and b. This is "slow-
        but-feature-rich"  version  of  the  solver  which,  in  addition  to  the
        solution, performs condition number estimation.

        Algorithm features:
        * automatic detection of degenerate cases
        * O(N^2) complexity
        * condition number estimation
        * matrix is represented by its upper or lower triangle

        No iterative refinement is provided because such partial representation of
        matrix does not allow efficient calculation of extra-precise  matrix-vector
        products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which results in 10-15x  performance  penalty  when  compared
                   ! with "fast" version which just calls triangular solver.
                   !
                   ! This performance penalty is insignificant  when compared with
                   ! cost of large LU decomposition.  However,  if you  call  this
                   ! function many times for the same  left  side,  this  overhead
                   ! BECOMES significant. It  also  becomes significant for small-
                   ! scale problems (N<50).
                   !
                   ! In such cases we strongly recommend you to use faster solver,
                   ! SPDMatrixCholeskySolveFast() function.

        INPUT PARAMETERS
            CHA     -   array[N,N], Cholesky decomposition,
                        SPDMatrixCholesky result
            N       -   size of A
            IsUpper -   what half of CHA is provided
            B       -   array[N], right part

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or indefinite matrix
                        * rep.r1    condition number in 1-norm
                        * rep.rinf  condition number in inf-norm
            X       -   array[N]:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void spdmatrixcholeskysolve(double[,] cha,
            int n,
            bool isupper,
            double[] b,
            ref double[] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            double[,] bm = new double[0,0];
            double[,] xm = new double[0,0];
            int i_ = 0;

            x = new double[0];

            alglib.ap.assert(n>0, "SPDMatrixCholeskySolve: N<=0");
            alglib.ap.assert(alglib.ap.rows(cha)>=n, "SPDMatrixCholeskySolve: rows(CHA)<N");
            alglib.ap.assert(alglib.ap.cols(cha)>=n, "SPDMatrixCholeskySolve: cols(CHA)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SPDMatrixCholeskySolve: length(B)<N");
            alglib.ap.assert(apserv.isfinitertrmatrix(cha, n, isupper, _params), "SPDMatrixCholeskySolve: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SPDMatrixCholeskySolve: B contains infinite or NaN values!");
            bm = new double[n, 1];
            for(i_=0; i_<=n-1;i_++)
            {
                bm[i_,0] = b[i_];
            }
            spdmatrixcholeskysolvem(cha, n, isupper, bm, 1, ref xm, rep, _params);
            x = new double[n];
            for(i_=0; i_<=n-1;i_++)
            {
                x[i_] = xm[i_,0];
            }
        }


        /*************************************************************************
        Dense solver for A*x=b with N*N symmetric positive definite matrix A given
        by its Cholesky decomposition, and N*1 real vectors x and b. This is "fast-
        but-lightweight" version of the solver.

        Algorithm features:
        * O(N^2) complexity
        * matrix is represented by its upper or lower triangle
        * no additional features

        INPUT PARAMETERS
            CHA     -   array[N,N], Cholesky decomposition,
                        SPDMatrixCholesky result
            N       -   size of A
            IsUpper -   what half of CHA is provided
            B       -   array[N], right part

        OUTPUT PARAMETERS
            B       -   array[N]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or exactly singular system
            
          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static bool spdmatrixcholeskysolvefast(double[,] cha,
            int n,
            bool isupper,
            double[] b,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;
            int k = 0;

            alglib.ap.assert(n>0, "SPDMatrixCholeskySolveFast: N<=0");
            alglib.ap.assert(alglib.ap.rows(cha)>=n, "SPDMatrixCholeskySolveFast: rows(CHA)<N");
            alglib.ap.assert(alglib.ap.cols(cha)>=n, "SPDMatrixCholeskySolveFast: cols(CHA)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SPDMatrixCholeskySolveFast: length(B)<N");
            alglib.ap.assert(apserv.isfinitertrmatrix(cha, n, isupper, _params), "SPDMatrixCholeskySolveFast: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SPDMatrixCholeskySolveFast: B contains infinite or NaN values!");
            result = true;
            for(k=0; k<=n-1; k++)
            {
                if( (double)(cha[k,k])==(double)(0.0) )
                {
                    for(i=0; i<=n-1; i++)
                    {
                        b[i] = 0.0;
                    }
                    result = false;
                    return result;
                }
            }
            spdbasiccholeskysolve(cha, n, isupper, b, _params);
            return result;
        }


        /*************************************************************************
        Dense solver for A*X=B, with N*N Hermitian positive definite matrix A  and
        N*M  complex  matrices  X  and  B.  "Slow-but-feature-rich" version of the
        solver.

        Algorithm features:
        * automatic detection of degenerate cases
        * condition number estimation
        * O(N^3+M*N^2) complexity
        * matrix is represented by its upper or lower triangle

        No iterative refinement is provided because such partial representation of
        matrix does not allow efficient calculation of extra-precise  matrix-vector
        products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which  results  in  significant  performance   penalty   when
                   ! compared with "fast"  version  which  just  calls  triangular
                   ! solver.
                   !
                   ! This performance penalty is especially apparent when you  use
                   ! ALGLIB parallel capabilities (condition number estimation  is
                   ! inherently  sequential).  It   also   becomes significant for
                   ! small-scale problems (N<100).
                   !
                   ! In such cases we strongly recommend you to use faster solver,
                   ! HPDMatrixSolveMFast() function.

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            IsUpper -   what half of A is provided
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS
            Rep     -   same as in RMatrixSolve
            X       -   same as in RMatrixSolve

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void hpdmatrixsolvem(complex[,] a,
            int n,
            bool isupper,
            complex[,] b,
            int m,
            ref complex[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            complex[,] da = new complex[0,0];
            int i = 0;
            int j = 0;
            int j1 = 0;
            int j2 = 0;
            int i_ = 0;

            x = new complex[0,0];

            alglib.ap.assert(n>0, "HPDMatrixSolveM: N<=0");
            alglib.ap.assert(m>0, "HPDMatrixSolveM: M<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "HPDMatrixSolveM: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "HPDMatrixSolveM: cols(A)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "HPDMatrixSolveM: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "HPDMatrixSolveM: cols(B)<M");
            alglib.ap.assert(apserv.isfinitectrmatrix(a, n, isupper, _params), "HPDMatrixSolveM: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecmatrix(b, n, m, _params), "HPDMatrixSolveM: B contains infinite or NaN values!");
            da = new complex[n, n];
            
            //
            // factorize matrix, solve
            //
            for(i=0; i<=n-1; i++)
            {
                if( isupper )
                {
                    j1 = i;
                    j2 = n-1;
                }
                else
                {
                    j1 = 0;
                    j2 = i;
                }
                for(i_=j1; i_<=j2;i_++)
                {
                    da[i,i_] = a[i,i_];
                }
            }
            if( !trfac.hpdmatrixcholesky(da, n, isupper, _params) )
            {
                x = new complex[n, m];
                for(i=0; i<=n-1; i++)
                {
                    for(j=0; j<=m-1; j++)
                    {
                        x[i,j] = 0;
                    }
                }
                rep.r1 = 0;
                rep.rinf = 0;
                rep.terminationtype = -3;
                return;
            }
            rep.terminationtype = 1;
            hpdmatrixcholeskysolveinternal(da, n, isupper, a, true, b, m, ref x, rep, _params);
        }


        /*************************************************************************
        Dense solver for A*X=B, with N*N Hermitian positive definite matrix A  and
        N*M complex matrices X and B. "Fast-but-lightweight" version of the solver.

        Algorithm features:
        * O(N^3+M*N^2) complexity
        * matrix is represented by its upper or lower triangle
        * no additional time consuming features like condition number estimation

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            IsUpper -   what half of A is provided
            B       -   array[0..N-1,0..M-1], right part
            M       -   right part size

        OUTPUT PARAMETERS
            B       -   array[0..N-1]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or indefinite system
            
          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 17.03.2015 by Bochkanov Sergey
        *************************************************************************/
        public static bool hpdmatrixsolvemfast(complex[,] a,
            int n,
            bool isupper,
            complex[,] b,
            int m,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;
            int j = 0;

            a = (complex[,])a.Clone();

            alglib.ap.assert(n>0, "HPDMatrixSolveMFast: N<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "HPDMatrixSolveMFast: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "HPDMatrixSolveMFast: cols(A)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "HPDMatrixSolveMFast: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "HPDMatrixSolveMFast: cols(B)<M");
            alglib.ap.assert(apserv.isfinitectrmatrix(a, n, isupper, _params), "HPDMatrixSolveMFast: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecmatrix(b, n, m, _params), "HPDMatrixSolveMFast: B contains infinite or NaN values!");
            result = true;
            if( !trfac.hpdmatrixcholesky(a, n, isupper, _params) )
            {
                for(i=0; i<=n-1; i++)
                {
                    for(j=0; j<=m-1; j++)
                    {
                        b[i,j] = 0.0;
                    }
                }
                result = false;
                return result;
            }
            if( isupper )
            {
                ablas.cmatrixlefttrsm(n, m, a, 0, 0, true, false, 2, b, 0, 0, _params);
                ablas.cmatrixlefttrsm(n, m, a, 0, 0, true, false, 0, b, 0, 0, _params);
            }
            else
            {
                ablas.cmatrixlefttrsm(n, m, a, 0, 0, false, false, 0, b, 0, 0, _params);
                ablas.cmatrixlefttrsm(n, m, a, 0, 0, false, false, 2, b, 0, 0, _params);
            }
            return result;
        }


        /*************************************************************************
        Dense solver for A*x=b, with N*N Hermitian positive definite matrix A, and
        N*1 complex vectors  x  and  b.  "Slow-but-feature-rich"  version  of  the
        solver.

        Algorithm features:
        * automatic detection of degenerate cases
        * condition number estimation
        * O(N^3) complexity
        * matrix is represented by its upper or lower triangle

        No iterative refinement is provided because such partial representation of
        matrix does not allow efficient calculation of extra-precise  matrix-vector
        products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which  results  in  significant   performance   penalty  when
                   ! compared with "fast" version  which  just  performs  Cholesky
                   ! decomposition and calls triangular solver.
                   !
                   ! This  performance  penalty  is  especially  visible  in   the
                   ! multithreaded mode, because both condition number  estimation
                   ! and   iterative    refinement   are   inherently   sequential
                   ! calculations.
                   !
                   ! Thus, if you need high performance and if you are pretty sure
                   ! that your system is well conditioned, we  strongly  recommend
                   ! you to use faster solver, HPDMatrixSolveFast() function.

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            IsUpper -   what half of A is provided
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            Rep     -   same as in RMatrixSolve
            X       -   same as in RMatrixSolve

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void hpdmatrixsolve(complex[,] a,
            int n,
            bool isupper,
            complex[] b,
            ref complex[] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            complex[,] bm = new complex[0,0];
            complex[,] xm = new complex[0,0];
            int i_ = 0;

            x = new complex[0];

            alglib.ap.assert(n>0, "HPDMatrixSolve: N<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "HPDMatrixSolve: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "HPDMatrixSolve: cols(A)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "HPDMatrixSolve: length(B)<N");
            alglib.ap.assert(apserv.isfinitectrmatrix(a, n, isupper, _params), "HPDMatrixSolve: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecvector(b, n, _params), "HPDMatrixSolve: B contains infinite or NaN values!");
            bm = new complex[n, 1];
            for(i_=0; i_<=n-1;i_++)
            {
                bm[i_,0] = b[i_];
            }
            hpdmatrixsolvem(a, n, isupper, bm, 1, ref xm, rep, _params);
            x = new complex[n];
            for(i_=0; i_<=n-1;i_++)
            {
                x[i_] = xm[i_,0];
            }
        }


        /*************************************************************************
        Dense solver for A*x=b, with N*N Hermitian positive definite matrix A, and
        N*1 complex vectors  x  and  b.  "Fast-but-lightweight"  version  of   the
        solver without additional functions.

        Algorithm features:
        * O(N^3) complexity
        * matrix is represented by its upper or lower triangle
        * no additional time consuming functions

        INPUT PARAMETERS
            A       -   array[0..N-1,0..N-1], system matrix
            N       -   size of A
            IsUpper -   what half of A is provided
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            B       -   array[0..N-1]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or indefinite system

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 17.03.2015 by Bochkanov Sergey
        *************************************************************************/
        public static bool hpdmatrixsolvefast(complex[,] a,
            int n,
            bool isupper,
            complex[] b,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;

            a = (complex[,])a.Clone();

            alglib.ap.assert(n>0, "HPDMatrixSolveFast: N<=0");
            alglib.ap.assert(alglib.ap.rows(a)>=n, "HPDMatrixSolveFast: rows(A)<N");
            alglib.ap.assert(alglib.ap.cols(a)>=n, "HPDMatrixSolveFast: cols(A)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "HPDMatrixSolveFast: length(B)<N");
            alglib.ap.assert(apserv.isfinitectrmatrix(a, n, isupper, _params), "HPDMatrixSolveFast: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecvector(b, n, _params), "HPDMatrixSolveFast: B contains infinite or NaN values!");
            result = true;
            if( !trfac.hpdmatrixcholesky(a, n, isupper, _params) )
            {
                for(i=0; i<=n-1; i++)
                {
                    b[i] = 0.0;
                }
                result = false;
                return result;
            }
            hpdbasiccholeskysolve(a, n, isupper, b, _params);
            return result;
        }


        /*************************************************************************
        Dense solver for A*X=B with N*N Hermitian positive definite matrix A given
        by its Cholesky decomposition and N*M complex matrices X  and  B.  This is
        "slow-but-feature-rich" version of the solver which, in  addition  to  the
        solution, estimates condition number of the system.

        Algorithm features:
        * automatic detection of degenerate cases
        * O(M*N^2) complexity
        * condition number estimation
        * matrix is represented by its upper or lower triangle

        No iterative refinement is provided because such partial representation of
        matrix does not allow efficient calculation of extra-precise  matrix-vector
        products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which  results  in  significant  performance   penalty   when
                   ! compared with "fast"  version  which  just  calls  triangular
                   ! solver. Amount of  overhead  introduced  depends  on  M  (the
                   ! larger - the more efficient).
                   !
                   ! This performance penalty is insignificant  when compared with
                   ! cost of large Cholesky decomposition.  However,  if  you call
                   ! this  function  many  times  for  the same  left  side,  this
                   ! overhead BECOMES significant. It  also   becomes  significant
                   ! for small-scale problems (N<50).
                   !
                   ! In such cases we strongly recommend you to use faster solver,
                   ! HPDMatrixCholeskySolveMFast() function.


        INPUT PARAMETERS
            CHA     -   array[N,N], Cholesky decomposition,
                        HPDMatrixCholesky result
            N       -   size of CHA
            IsUpper -   what half of CHA is provided
            B       -   array[N,M], right part
            M       -   right part size

        OUTPUT PARAMETERS:
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or indefinite matrix
                        * rep.r1                condition number in 1-norm
                        * rep.rinf              condition number in inf-norm
            X       -   array[N], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void hpdmatrixcholeskysolvem(complex[,] cha,
            int n,
            bool isupper,
            complex[,] b,
            int m,
            ref complex[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            complex[,] emptya = new complex[0,0];

            x = new complex[0,0];

            alglib.ap.assert(n>0, "HPDMatrixCholeskySolveM: N<=0");
            alglib.ap.assert(m>0, "HPDMatrixCholeskySolveM: M<=0");
            alglib.ap.assert(alglib.ap.rows(cha)>=n, "HPDMatrixCholeskySolveM: rows(CHA)<N");
            alglib.ap.assert(alglib.ap.cols(cha)>=n, "HPDMatrixCholeskySolveM: cols(CHA)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "HPDMatrixCholeskySolveM: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "HPDMatrixCholeskySolveM: cols(B)<M");
            alglib.ap.assert(apserv.isfinitectrmatrix(cha, n, isupper, _params), "HPDMatrixCholeskySolveM: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecmatrix(b, n, m, _params), "HPDMatrixCholeskySolveM: LUA contains infinite or NaN values!");
            hpdmatrixcholeskysolveinternal(cha, n, isupper, emptya, false, b, m, ref x, rep, _params);
        }


        /*************************************************************************
        Dense solver for A*X=B with N*N Hermitian positive definite matrix A given
        by its Cholesky decomposition and N*M complex matrices X  and  B.  This is
        "fast-but-lightweight" version of the solver.

        Algorithm features:
        * O(M*N^2) complexity
        * matrix is represented by its upper or lower triangle
        * no additional time-consuming features

        INPUT PARAMETERS
            CHA     -   array[N,N], Cholesky decomposition,
                        HPDMatrixCholesky result
            N       -   size of CHA
            IsUpper -   what half of CHA is provided
            B       -   array[N,M], right part
            M       -   right part size

        OUTPUT PARAMETERS:
            B       -   array[N]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or indefinite system

          -- ALGLIB --
             Copyright 18.03.2015 by Bochkanov Sergey
        *************************************************************************/
        public static bool hpdmatrixcholeskysolvemfast(complex[,] cha,
            int n,
            bool isupper,
            complex[,] b,
            int m,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;
            int j = 0;
            int k = 0;

            alglib.ap.assert(n>0, "HPDMatrixCholeskySolveMFast: N<=0");
            alglib.ap.assert(m>0, "HPDMatrixCholeskySolveMFast: M<=0");
            alglib.ap.assert(alglib.ap.rows(cha)>=n, "HPDMatrixCholeskySolveMFast: rows(CHA)<N");
            alglib.ap.assert(alglib.ap.cols(cha)>=n, "HPDMatrixCholeskySolveMFast: cols(CHA)<N");
            alglib.ap.assert(alglib.ap.rows(b)>=n, "HPDMatrixCholeskySolveMFast: rows(B)<N");
            alglib.ap.assert(alglib.ap.cols(b)>=m, "HPDMatrixCholeskySolveMFast: cols(B)<M");
            alglib.ap.assert(apserv.isfinitectrmatrix(cha, n, isupper, _params), "HPDMatrixCholeskySolveMFast: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecmatrix(b, n, m, _params), "HPDMatrixCholeskySolveMFast: LUA contains infinite or NaN values!");
            result = true;
            for(k=0; k<=n-1; k++)
            {
                if( (double)(cha[k,k].x)==(double)(0.0) && (double)(cha[k,k].y)==(double)(0.0) )
                {
                    for(i=0; i<=n-1; i++)
                    {
                        for(j=0; j<=m-1; j++)
                        {
                            b[i,j] = 0.0;
                        }
                    }
                    result = false;
                    return result;
                }
            }
            if( isupper )
            {
                ablas.cmatrixlefttrsm(n, m, cha, 0, 0, true, false, 2, b, 0, 0, _params);
                ablas.cmatrixlefttrsm(n, m, cha, 0, 0, true, false, 0, b, 0, 0, _params);
            }
            else
            {
                ablas.cmatrixlefttrsm(n, m, cha, 0, 0, false, false, 0, b, 0, 0, _params);
                ablas.cmatrixlefttrsm(n, m, cha, 0, 0, false, false, 2, b, 0, 0, _params);
            }
            return result;
        }


        /*************************************************************************
        Dense solver for A*x=b with N*N Hermitian positive definite matrix A given
        by its Cholesky decomposition, and N*1 complex vectors x and  b.  This  is
        "slow-but-feature-rich" version of the solver  which  estimates  condition
        number of the system.

        Algorithm features:
        * automatic detection of degenerate cases
        * O(N^2) complexity
        * condition number estimation
        * matrix is represented by its upper or lower triangle

        No iterative refinement is provided because such partial representation of
        matrix does not allow efficient calculation of extra-precise  matrix-vector
        products for large matrices. Use RMatrixSolve or RMatrixMixedSolve  if  you
        need iterative refinement.

        IMPORTANT: ! this function is NOT the most efficient linear solver provided
                   ! by ALGLIB. It estimates condition  number  of  linear system,
                   ! which results in 10-15x  performance  penalty  when  compared
                   ! with "fast" version which just calls triangular solver.
                   !
                   ! This performance penalty is insignificant  when compared with
                   ! cost of large LU decomposition.  However,  if you  call  this
                   ! function many times for the same  left  side,  this  overhead
                   ! BECOMES significant. It  also  becomes significant for small-
                   ! scale problems (N<50).
                   !
                   ! In such cases we strongly recommend you to use faster solver,
                   ! HPDMatrixCholeskySolveFast() function.

        INPUT PARAMETERS
            CHA     -   array[0..N-1,0..N-1], Cholesky decomposition,
                        SPDMatrixCholesky result
            N       -   size of A
            IsUpper -   what half of CHA is provided
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            Rep     -   additional report, following fields are set:
                        * rep.terminationtype   >0 for success
                                                -3 for badly conditioned or indefinite matrix
                        * rep.r1                condition number in 1-norm
                        * rep.rinf              condition number in inf-norm
            X       -   array[N], it contains:
                        * rep.terminationtype>0  => solution
                        * rep.terminationtype=-3 => filled by zeros

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void hpdmatrixcholeskysolve(complex[,] cha,
            int n,
            bool isupper,
            complex[] b,
            ref complex[] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            complex[,] bm = new complex[0,0];
            complex[,] xm = new complex[0,0];
            int i_ = 0;

            x = new complex[0];

            alglib.ap.assert(n>0, "HPDMatrixCholeskySolve: N<=0");
            alglib.ap.assert(alglib.ap.rows(cha)>=n, "HPDMatrixCholeskySolve: rows(CHA)<N");
            alglib.ap.assert(alglib.ap.cols(cha)>=n, "HPDMatrixCholeskySolve: cols(CHA)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "HPDMatrixCholeskySolve: length(B)<N");
            alglib.ap.assert(apserv.isfinitectrmatrix(cha, n, isupper, _params), "HPDMatrixCholeskySolve: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecvector(b, n, _params), "HPDMatrixCholeskySolve: B contains infinite or NaN values!");
            bm = new complex[n, 1];
            for(i_=0; i_<=n-1;i_++)
            {
                bm[i_,0] = b[i_];
            }
            hpdmatrixcholeskysolvem(cha, n, isupper, bm, 1, ref xm, rep, _params);
            x = new complex[n];
            for(i_=0; i_<=n-1;i_++)
            {
                x[i_] = xm[i_,0];
            }
        }


        /*************************************************************************
        Dense solver for A*x=b with N*N Hermitian positive definite matrix A given
        by its Cholesky decomposition, and N*1 complex vectors x and  b.  This  is
        "fast-but-lightweight" version of the solver.

        Algorithm features:
        * O(N^2) complexity
        * matrix is represented by its upper or lower triangle
        * no additional time-consuming features

        INPUT PARAMETERS
            CHA     -   array[0..N-1,0..N-1], Cholesky decomposition,
                        SPDMatrixCholesky result
            N       -   size of A
            IsUpper -   what half of CHA is provided
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            B       -   array[N]:
                        * result=true    =>  overwritten by solution
                        * result=false   =>  filled by zeros

        RETURNS:
            True, if the system was solved
            False, for an extremely badly conditioned or indefinite system

          -- ALGLIB --
             Copyright 18.03.2015 by Bochkanov Sergey
        *************************************************************************/
        public static bool hpdmatrixcholeskysolvefast(complex[,] cha,
            int n,
            bool isupper,
            complex[] b,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;
            int k = 0;

            alglib.ap.assert(n>0, "HPDMatrixCholeskySolveFast: N<=0");
            alglib.ap.assert(alglib.ap.rows(cha)>=n, "HPDMatrixCholeskySolveFast: rows(CHA)<N");
            alglib.ap.assert(alglib.ap.cols(cha)>=n, "HPDMatrixCholeskySolveFast: cols(CHA)<N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "HPDMatrixCholeskySolveFast: length(B)<N");
            alglib.ap.assert(apserv.isfinitectrmatrix(cha, n, isupper, _params), "HPDMatrixCholeskySolveFast: LUA contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitecvector(b, n, _params), "HPDMatrixCholeskySolveFast: B contains infinite or NaN values!");
            result = true;
            for(k=0; k<=n-1; k++)
            {
                if( (double)(cha[k,k].x)==(double)(0.0) && (double)(cha[k,k].y)==(double)(0.0) )
                {
                    for(i=0; i<=n-1; i++)
                    {
                        b[i] = 0.0;
                    }
                    result = false;
                    return result;
                }
            }
            hpdbasiccholeskysolve(cha, n, isupper, b, _params);
            return result;
        }


        /*************************************************************************
        Dense solver.

        This subroutine finds solution of the linear system A*X=B with non-square,
        possibly degenerate A.  System  is  solved in the least squares sense, and
        general least squares solution  X = X0 + CX*y  which  minimizes |A*X-B| is
        returned. If A is non-degenerate, solution in the usual sense is returned.

        Algorithm features:
        * automatic detection (and correct handling!) of degenerate cases
        * iterative refinement
        * O(N^3) complexity

        INPUT PARAMETERS
            A       -   array[0..NRows-1,0..NCols-1], system matrix
            NRows   -   vertical size of A
            NCols   -   horizontal size of A
            B       -   array[0..NCols-1], right part
            Threshold-  a number in [0,1]. Singular values  beyond  Threshold*Largest are
                        considered  zero.  Set  it to 0.0, if you don't understand
                        what it means, so the solver will choose good value on its
                        own.
                        
        OUTPUT PARAMETERS
            Rep     -   solver report, see below for more info
            X       -   array[0..N-1,0..M-1], it contains:
                        * solution of A*X=B (even for singular A)
                        * zeros, if SVD subroutine failed

        SOLVER REPORT

        Subroutine sets following fields of the Rep structure:
        * TerminationType is set to:
                    * -4 for SVD failure
                    * >0 for success
        * R2        reciprocal of condition number: 1/cond(A), 2-norm.
        * N         = NCols
        * K         dim(Null(A))
        * CX        array[0..N-1,0..K-1], kernel of A.
                    Columns of CX store such vectors that A*CX[i]=0.

          ! FREE EDITION OF ALGLIB:
          ! 
          ! Free Edition of ALGLIB supports following important features for  this
          ! function:
          ! * C++ version: x64 SIMD support using C++ intrinsics
          ! * C#  version: x64 SIMD support using NET5/NetCore hardware intrinsics
          !
          ! We  recommend  you  to  read  'Compiling ALGLIB' section of the ALGLIB
          ! Reference Manual in order  to  find  out  how to activate SIMD support
          ! in ALGLIB.

          ! COMMERCIAL EDITION OF ALGLIB:
          ! 
          ! Commercial Edition of ALGLIB includes following important improvements
          ! of this function:
          ! * high-performance native backend with same C# interface (C# version)
          ! * multithreading support (C++ and C# versions)
          ! * hardware vendor (Intel) implementations of linear algebra primitives
          !   (C++ and C# versions, x86/x64 platform)
          ! 
          ! We recommend you to read 'Working with commercial version' section  of
          ! ALGLIB Reference Manual in order to find out how to  use  performance-
          ! related features provided by commercial edition of ALGLIB.

          -- ALGLIB --
             Copyright 24.08.2009 by Bochkanov Sergey
        *************************************************************************/
        public static void rmatrixsolvels(double[,] a,
            int nrows,
            int ncols,
            double[] b,
            double threshold,
            ref double[] x,
            densesolverlsreport rep,
            alglib.xparams _params)
        {
            double[] sv = new double[0];
            double[,] u = new double[0,0];
            double[,] vt = new double[0,0];
            double[] rp = new double[0];
            double[] utb = new double[0];
            double[] sutb = new double[0];
            double[] tmp = new double[0];
            double[] ta = new double[0];
            double[] tx = new double[0];
            double[] buf = new double[0];
            double[] w = new double[0];
            int i = 0;
            int j = 0;
            int nsv = 0;
            int kernelidx = 0;
            double v = 0;
            double verr = 0;
            bool svdfailed = new bool();
            bool zeroa = new bool();
            int rfs = 0;
            int nrfs = 0;
            bool terminatenexttime = new bool();
            bool smallerr = new bool();
            int i_ = 0;

            x = new double[0];

            alglib.ap.assert(nrows>0, "RMatrixSolveLS: NRows<=0");
            alglib.ap.assert(ncols>0, "RMatrixSolveLS: NCols<=0");
            alglib.ap.assert(math.isfinite(threshold) && (double)(threshold)>=(double)(0), "RMatrixSolveLS: Threshold<0 or is infinite");
            alglib.ap.assert(alglib.ap.rows(a)>=nrows, "RMatrixSolveLS: rows(A)<NRows");
            alglib.ap.assert(alglib.ap.cols(a)>=ncols, "RMatrixSolveLS: cols(A)<NCols");
            alglib.ap.assert(alglib.ap.len(b)>=nrows, "RMatrixSolveLS: length(B)<NRows");
            alglib.ap.assert(apserv.apservisfinitematrix(a, nrows, ncols, _params), "RMatrixSolveLS: A contains infinite or NaN values!");
            alglib.ap.assert(apserv.isfinitevector(b, nrows, _params), "RMatrixSolveLS: B contains infinite or NaN values!");
            if( (double)(threshold)==(double)(0) )
            {
                threshold = 1000*math.machineepsilon;
            }
            
            //
            // Factorize A first
            //
            svdfailed = !svd.rmatrixsvd(a, nrows, ncols, 1, 2, 2, ref sv, ref u, ref vt, _params);
            zeroa = (double)(sv[0])==(double)(0);
            if( svdfailed || zeroa )
            {
                if( svdfailed )
                {
                    rep.terminationtype = -4;
                }
                else
                {
                    rep.terminationtype = 1;
                }
                x = new double[ncols];
                for(i=0; i<=ncols-1; i++)
                {
                    x[i] = 0;
                }
                rep.n = ncols;
                rep.k = ncols;
                rep.cx = new double[ncols, ncols];
                for(i=0; i<=ncols-1; i++)
                {
                    for(j=0; j<=ncols-1; j++)
                    {
                        if( i==j )
                        {
                            rep.cx[i,j] = 1;
                        }
                        else
                        {
                            rep.cx[i,j] = 0;
                        }
                    }
                }
                rep.r2 = 0;
                return;
            }
            nsv = Math.Min(ncols, nrows);
            if( nsv==ncols )
            {
                rep.r2 = sv[nsv-1]/sv[0];
            }
            else
            {
                rep.r2 = 0;
            }
            rep.n = ncols;
            rep.terminationtype = 1;
            
            //
            // Iterative refinement of xc combined with solution:
            // 1. xc = 0
            // 2. calculate r = bc-A*xc using extra-precise dot product
            // 3. solve A*y = r
            // 4. update x:=x+r
            // 5. goto 2
            //
            // This cycle is executed until one of two things happens:
            // 1. maximum number of iterations reached
            // 2. last iteration decreased error to the lower limit
            //
            utb = new double[nsv];
            sutb = new double[nsv];
            x = new double[ncols];
            tmp = new double[ncols];
            ta = new double[ncols+1];
            tx = new double[ncols+1];
            buf = new double[ncols+1];
            for(i=0; i<=ncols-1; i++)
            {
                x[i] = 0;
            }
            kernelidx = nsv;
            for(i=0; i<=nsv-1; i++)
            {
                if( (double)(sv[i])<=(double)(threshold*sv[0]) )
                {
                    kernelidx = i;
                    break;
                }
            }
            rep.k = ncols-kernelidx;
            nrfs = densesolverrfsmaxv2(ncols, rep.r2, _params);
            terminatenexttime = false;
            rp = new double[nrows];
            for(rfs=0; rfs<=nrfs; rfs++)
            {
                if( terminatenexttime )
                {
                    break;
                }
                
                //
                // calculate right part
                //
                if( rfs==0 )
                {
                    for(i_=0; i_<=nrows-1;i_++)
                    {
                        rp[i_] = b[i_];
                    }
                }
                else
                {
                    smallerr = true;
                    for(i=0; i<=nrows-1; i++)
                    {
                        for(i_=0; i_<=ncols-1;i_++)
                        {
                            ta[i_] = a[i,i_];
                        }
                        ta[ncols] = -1;
                        for(i_=0; i_<=ncols-1;i_++)
                        {
                            tx[i_] = x[i_];
                        }
                        tx[ncols] = b[i];
                        xblas.xdot(ta, tx, ncols+1, ref buf, ref v, ref verr, _params);
                        rp[i] = -v;
                        smallerr = smallerr && (double)(Math.Abs(v))<(double)(4*verr);
                    }
                    if( smallerr )
                    {
                        terminatenexttime = true;
                    }
                }
                
                //
                // solve A*dx = rp
                //
                for(i=0; i<=ncols-1; i++)
                {
                    tmp[i] = 0;
                }
                for(i=0; i<=nsv-1; i++)
                {
                    utb[i] = 0;
                }
                for(i=0; i<=nrows-1; i++)
                {
                    v = rp[i];
                    for(i_=0; i_<=nsv-1;i_++)
                    {
                        utb[i_] = utb[i_] + v*u[i,i_];
                    }
                }
                for(i=0; i<=nsv-1; i++)
                {
                    if( i<kernelidx )
                    {
                        sutb[i] = utb[i]/sv[i];
                    }
                    else
                    {
                        sutb[i] = 0;
                    }
                }
                for(i=0; i<=nsv-1; i++)
                {
                    v = sutb[i];
                    for(i_=0; i_<=ncols-1;i_++)
                    {
                        tmp[i_] = tmp[i_] + v*vt[i,i_];
                    }
                }
                
                //
                // update x:  x:=x+dx
                //
                for(i_=0; i_<=ncols-1;i_++)
                {
                    x[i_] = x[i_] + tmp[i_];
                }
            }
            
            //
            // fill CX
            //
            if( rep.k>0 )
            {
                rep.cx = new double[ncols, rep.k];
                for(i=0; i<=rep.k-1; i++)
                {
                    for(i_=0; i_<=ncols-1;i_++)
                    {
                        rep.cx[i_,i] = vt[kernelidx+i,i_];
                    }
                }
            }
        }


        /*************************************************************************
        Internal LU solver

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        private static void rmatrixlusolveinternal(double[,] lua,
            int[] p,
            int n,
            double[,] a,
            bool havea,
            double[,] b,
            int m,
            ref double[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int rfs = 0;
            int nrfs = 0;
            double[] xc = new double[0];
            double[] y = new double[0];
            double[] bc = new double[0];
            double[] xa = new double[0];
            double[] xb = new double[0];
            double[] tx = new double[0];
            double v = 0;
            double verr = 0;
            double mxb = 0;
            bool smallerr = new bool();
            bool terminatenexttime = new bool();
            int i_ = 0;

            x = new double[0,0];

            
            //
            // prepare: check inputs, allocate space...
            //
            alglib.ap.assert(n>0 && m>0, "RMatrixLUSolveInternal: integrity check 7656 failed");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]<=n-1 && p[i]>=i, "RMatrixLUSolveInternal: incorrect pivot, P[i]<i or P[i]>=N");
            }
            x = new double[n, m];
            y = new double[n];
            xc = new double[n];
            bc = new double[n];
            tx = new double[n+1];
            xa = new double[n+1];
            xb = new double[n+1];
            
            //
            // estimate condition number, test for near singularity
            //
            rep.r1 = rcond.rmatrixlurcond1(lua, n, _params);
            rep.rinf = rcond.rmatrixlurcondinf(lua, n, _params);
            rep.terminationtype = 1;
            if( (double)(rep.r1)<(double)(rcond.rcondthreshold(_params)) || (double)(rep.rinf)<(double)(rcond.rcondthreshold(_params)) )
            {
                for(i=0; i<=n-1; i++)
                {
                    for(j=0; j<=m-1; j++)
                    {
                        x[i,j] = 0;
                    }
                }
                rep.r1 = 0;
                rep.rinf = 0;
                rep.terminationtype = -3;
                return;
            }
            
            //
            // First stage of solution: rough solution with TRSM()
            //
            mxb = 0.0;
            for(i=0; i<=n-1; i++)
            {
                for(j=0; j<=m-1; j++)
                {
                    v = b[i,j];
                    mxb = Math.Max(mxb, Math.Abs(v));
                    x[i,j] = v;
                }
            }
            for(i=0; i<=n-1; i++)
            {
                if( p[i]!=i )
                {
                    for(j=0; j<=m-1; j++)
                    {
                        v = x[i,j];
                        x[i,j] = x[p[i],j];
                        x[p[i],j] = v;
                    }
                }
            }
            ablas.rmatrixlefttrsm(n, m, lua, 0, 0, false, true, 0, x, 0, 0, _params);
            ablas.rmatrixlefttrsm(n, m, lua, 0, 0, true, false, 0, x, 0, 0, _params);
            
            //
            // Second stage: iterative refinement
            //
            if( havea )
            {
                for(k=0; k<=m-1; k++)
                {
                    nrfs = densesolverrfsmax(n, rep.r1, rep.rinf, _params);
                    terminatenexttime = false;
                    for(rfs=0; rfs<=nrfs-1; rfs++)
                    {
                        if( terminatenexttime )
                        {
                            break;
                        }
                        
                        //
                        // generate right part
                        //
                        smallerr = true;
                        for(i_=0; i_<=n-1;i_++)
                        {
                            xb[i_] = x[i_,k];
                        }
                        for(i=0; i<=n-1; i++)
                        {
                            for(i_=0; i_<=n-1;i_++)
                            {
                                xa[i_] = a[i,i_];
                            }
                            xa[n] = -1;
                            xb[n] = b[i,k];
                            xblas.xdot(xa, xb, n+1, ref tx, ref v, ref verr, _params);
                            y[i] = -v;
                            smallerr = smallerr && (double)(Math.Abs(v))<(double)(4*verr);
                        }
                        if( smallerr )
                        {
                            terminatenexttime = true;
                        }
                        
                        //
                        // solve and update
                        //
                        rbasiclusolve(lua, p, n, y, _params);
                        for(i_=0; i_<=n-1;i_++)
                        {
                            x[i_,k] = x[i_,k] + y[i_];
                        }
                    }
                }
            }
        }


        /*************************************************************************
        Internal Cholesky solver

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        private static void spdmatrixcholeskysolveinternal(double[,] cha,
            int n,
            bool isupper,
            double[,] a,
            bool havea,
            double[,] b,
            int m,
            ref double[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            int i = 0;
            int j = 0;

            x = new double[0,0];

            
            //
            // prepare: check inputs, allocate space...
            //
            alglib.ap.assert(n>0 && m>0, "SPDMatrixCholeskySolveInternal: integrity check 9858 failed");
            x = new double[n, m];
            
            //
            // estimate condition number, test for near singularity
            //
            rep.r1 = rcond.spdmatrixcholeskyrcond(cha, n, isupper, _params);
            rep.rinf = rep.r1;
            rep.terminationtype = 1;
            if( (double)(rep.r1)<(double)(rcond.rcondthreshold(_params)) )
            {
                for(i=0; i<=n-1; i++)
                {
                    for(j=0; j<=m-1; j++)
                    {
                        x[i,j] = 0;
                    }
                }
                rep.r1 = 0;
                rep.rinf = 0;
                rep.terminationtype = -3;
                return;
            }
            
            //
            // Solve with TRSM()
            //
            for(i=0; i<=n-1; i++)
            {
                for(j=0; j<=m-1; j++)
                {
                    x[i,j] = b[i,j];
                }
            }
            if( isupper )
            {
                ablas.rmatrixlefttrsm(n, m, cha, 0, 0, true, false, 1, x, 0, 0, _params);
                ablas.rmatrixlefttrsm(n, m, cha, 0, 0, true, false, 0, x, 0, 0, _params);
            }
            else
            {
                ablas.rmatrixlefttrsm(n, m, cha, 0, 0, false, false, 0, x, 0, 0, _params);
                ablas.rmatrixlefttrsm(n, m, cha, 0, 0, false, false, 1, x, 0, 0, _params);
            }
        }


        /*************************************************************************
        Internal LU solver

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        private static void cmatrixlusolveinternal(complex[,] lua,
            int[] p,
            int n,
            complex[,] a,
            bool havea,
            complex[,] b,
            int m,
            ref complex[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            int rfs = 0;
            int nrfs = 0;
            complex[] xc = new complex[0];
            complex[] y = new complex[0];
            complex[] bc = new complex[0];
            complex[] xa = new complex[0];
            complex[] xb = new complex[0];
            complex[] tx = new complex[0];
            double[] tmpbuf = new double[0];
            complex v = 0;
            double verr = 0;
            bool smallerr = new bool();
            bool terminatenexttime = new bool();
            int i_ = 0;

            x = new complex[0,0];

            
            //
            // prepare: check inputs, allocate space...
            //
            alglib.ap.assert(n>0 && m>0, "CMatrixLUSolveInternal: integrity check 9302 failed");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]<=n-1 && p[i]>=i, "CMatrixLUSolveInternal: incorrect pivot P[i]<i or P[I]>=N");
            }
            x = new complex[n, m];
            y = new complex[n];
            xc = new complex[n];
            bc = new complex[n];
            tx = new complex[n];
            xa = new complex[n+1];
            xb = new complex[n+1];
            tmpbuf = new double[2*n+2];
            
            //
            // estimate condition number, test for near singularity
            //
            rep.r1 = rcond.cmatrixlurcond1(lua, n, _params);
            rep.rinf = rcond.cmatrixlurcondinf(lua, n, _params);
            rep.terminationtype = 1;
            if( (double)(rep.r1)<(double)(rcond.rcondthreshold(_params)) || (double)(rep.rinf)<(double)(rcond.rcondthreshold(_params)) )
            {
                for(i=0; i<=n-1; i++)
                {
                    for(j=0; j<=m-1; j++)
                    {
                        x[i,j] = 0;
                    }
                }
                rep.r1 = 0;
                rep.rinf = 0;
                rep.terminationtype = -3;
                return;
            }
            
            //
            // First phase: solve with TRSM()
            //
            for(i=0; i<=n-1; i++)
            {
                for(j=0; j<=m-1; j++)
                {
                    x[i,j] = b[i,j];
                }
            }
            for(i=0; i<=n-1; i++)
            {
                if( p[i]!=i )
                {
                    for(j=0; j<=m-1; j++)
                    {
                        v = x[i,j];
                        x[i,j] = x[p[i],j];
                        x[p[i],j] = v;
                    }
                }
            }
            ablas.cmatrixlefttrsm(n, m, lua, 0, 0, false, true, 0, x, 0, 0, _params);
            ablas.cmatrixlefttrsm(n, m, lua, 0, 0, true, false, 0, x, 0, 0, _params);
            
            //
            // solve
            //
            for(k=0; k<=m-1; k++)
            {
                for(i_=0; i_<=n-1;i_++)
                {
                    bc[i_] = b[i_,k];
                }
                for(i_=0; i_<=n-1;i_++)
                {
                    xc[i_] = x[i_,k];
                }
                
                //
                // Iterative refinement of xc:
                // * calculate r = bc-A*xc using extra-precise dot product
                // * solve A*y = r
                // * update x:=x+r
                //
                // This cycle is executed until one of two things happens:
                // 1. maximum number of iterations reached
                // 2. last iteration decreased error to the lower limit
                //
                if( havea )
                {
                    nrfs = densesolverrfsmax(n, rep.r1, rep.rinf, _params);
                    terminatenexttime = false;
                    for(rfs=0; rfs<=nrfs-1; rfs++)
                    {
                        if( terminatenexttime )
                        {
                            break;
                        }
                        
                        //
                        // generate right part
                        //
                        smallerr = true;
                        for(i_=0; i_<=n-1;i_++)
                        {
                            xb[i_] = xc[i_];
                        }
                        for(i=0; i<=n-1; i++)
                        {
                            for(i_=0; i_<=n-1;i_++)
                            {
                                xa[i_] = a[i,i_];
                            }
                            xa[n] = -1;
                            xb[n] = bc[i];
                            xblas.xcdot(xa, xb, n+1, ref tmpbuf, ref v, ref verr, _params);
                            y[i] = -v;
                            smallerr = smallerr && (double)(math.abscomplex(v))<(double)(4*verr);
                        }
                        if( smallerr )
                        {
                            terminatenexttime = true;
                        }
                        
                        //
                        // solve and update
                        //
                        cbasiclusolve(lua, p, n, y, _params);
                        for(i_=0; i_<=n-1;i_++)
                        {
                            xc[i_] = xc[i_] + y[i_];
                        }
                    }
                }
                
                //
                // Store xc.
                // Post-scale result.
                //
                for(i_=0; i_<=n-1;i_++)
                {
                    x[i_,k] = xc[i_];
                }
            }
        }


        /*************************************************************************
        Internal Cholesky solver

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        private static void hpdmatrixcholeskysolveinternal(complex[,] cha,
            int n,
            bool isupper,
            complex[,] a,
            bool havea,
            complex[,] b,
            int m,
            ref complex[,] x,
            densesolverreport rep,
            alglib.xparams _params)
        {
            int i = 0;
            int j = 0;
            complex[] xc = new complex[0];
            complex[] y = new complex[0];
            complex[] bc = new complex[0];
            complex[] xa = new complex[0];
            complex[] xb = new complex[0];
            complex[] tx = new complex[0];

            x = new complex[0,0];

            
            //
            // prepare: check inputs, allocate space...
            //
            x = new complex[n, m];
            y = new complex[n];
            xc = new complex[n];
            bc = new complex[n];
            tx = new complex[n+1];
            xa = new complex[n+1];
            xb = new complex[n+1];
            
            //
            // estimate condition number, test for near singularity
            //
            rep.r1 = rcond.hpdmatrixcholeskyrcond(cha, n, isupper, _params);
            rep.rinf = rep.r1;
            rep.terminationtype = 1;
            if( (double)(rep.r1)<(double)(rcond.rcondthreshold(_params)) )
            {
                for(i=0; i<=n-1; i++)
                {
                    for(j=0; j<=m-1; j++)
                    {
                        x[i,j] = 0;
                    }
                }
                rep.r1 = 0;
                rep.rinf = 0;
                rep.terminationtype = -3;
                return;
            }
            
            //
            // solve
            //
            for(i=0; i<=n-1; i++)
            {
                for(j=0; j<=m-1; j++)
                {
                    x[i,j] = b[i,j];
                }
            }
            if( isupper )
            {
                ablas.cmatrixlefttrsm(n, m, cha, 0, 0, true, false, 2, x, 0, 0, _params);
                ablas.cmatrixlefttrsm(n, m, cha, 0, 0, true, false, 0, x, 0, 0, _params);
            }
            else
            {
                ablas.cmatrixlefttrsm(n, m, cha, 0, 0, false, false, 0, x, 0, 0, _params);
                ablas.cmatrixlefttrsm(n, m, cha, 0, 0, false, false, 2, x, 0, 0, _params);
            }
        }


        /*************************************************************************
        Internal subroutine.
        Returns maximum count of RFS iterations as function of:
        1. machine epsilon
        2. task size.
        3. condition number

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        private static int densesolverrfsmax(int n,
            double r1,
            double rinf,
            alglib.xparams _params)
        {
            int result = 0;

            result = 5;
            return result;
        }


        /*************************************************************************
        Internal subroutine.
        Returns maximum count of RFS iterations as function of:
        1. machine epsilon
        2. task size.
        3. norm-2 condition number

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        private static int densesolverrfsmaxv2(int n,
            double r2,
            alglib.xparams _params)
        {
            int result = 0;

            result = densesolverrfsmax(n, 0, 0, _params);
            return result;
        }


        /*************************************************************************
        Basic LU solver for PLU*x = y.

        This subroutine assumes that:
        * A=PLU is well-conditioned, so no zero divisions or overflow may occur

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        private static void rbasiclusolve(double[,] lua,
            int[] p,
            int n,
            double[] xb,
            alglib.xparams _params)
        {
            int i = 0;
            double v = 0;
            int i_ = 0;

            for(i=0; i<=n-1; i++)
            {
                if( p[i]!=i )
                {
                    v = xb[i];
                    xb[i] = xb[p[i]];
                    xb[p[i]] = v;
                }
            }
            for(i=1; i<=n-1; i++)
            {
                v = 0.0;
                for(i_=0; i_<=i-1;i_++)
                {
                    v += lua[i,i_]*xb[i_];
                }
                xb[i] = xb[i]-v;
            }
            xb[n-1] = xb[n-1]/lua[n-1,n-1];
            for(i=n-2; i>=0; i--)
            {
                v = 0.0;
                for(i_=i+1; i_<=n-1;i_++)
                {
                    v += lua[i,i_]*xb[i_];
                }
                xb[i] = (xb[i]-v)/lua[i,i];
            }
        }


        /*************************************************************************
        Basic Cholesky solver for ScaleA*Cholesky(A)'*x = y.

        This subroutine assumes that:
        * A*ScaleA is well scaled
        * A is well-conditioned, so no zero divisions or overflow may occur

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        private static void spdbasiccholeskysolve(double[,] cha,
            int n,
            bool isupper,
            double[] xb,
            alglib.xparams _params)
        {
            int i = 0;
            double v = 0;
            int i_ = 0;

            
            //
            // A = L*L' or A=U'*U
            //
            if( isupper )
            {
                
                //
                // Solve U'*y=b first.
                //
                for(i=0; i<=n-1; i++)
                {
                    xb[i] = xb[i]/cha[i,i];
                    if( i<n-1 )
                    {
                        v = xb[i];
                        for(i_=i+1; i_<=n-1;i_++)
                        {
                            xb[i_] = xb[i_] - v*cha[i,i_];
                        }
                    }
                }
                
                //
                // Solve U*x=y then.
                //
                for(i=n-1; i>=0; i--)
                {
                    if( i<n-1 )
                    {
                        v = 0.0;
                        for(i_=i+1; i_<=n-1;i_++)
                        {
                            v += cha[i,i_]*xb[i_];
                        }
                        xb[i] = xb[i]-v;
                    }
                    xb[i] = xb[i]/cha[i,i];
                }
            }
            else
            {
                
                //
                // Solve L*y=b first
                //
                for(i=0; i<=n-1; i++)
                {
                    if( i>0 )
                    {
                        v = 0.0;
                        for(i_=0; i_<=i-1;i_++)
                        {
                            v += cha[i,i_]*xb[i_];
                        }
                        xb[i] = xb[i]-v;
                    }
                    xb[i] = xb[i]/cha[i,i];
                }
                
                //
                // Solve L'*x=y then.
                //
                for(i=n-1; i>=0; i--)
                {
                    xb[i] = xb[i]/cha[i,i];
                    if( i>0 )
                    {
                        v = xb[i];
                        for(i_=0; i_<=i-1;i_++)
                        {
                            xb[i_] = xb[i_] - v*cha[i,i_];
                        }
                    }
                }
            }
        }


        /*************************************************************************
        Basic LU solver for ScaleA*PLU*x = y.

        This subroutine assumes that:
        * L is well-scaled, and it is U which needs scaling by ScaleA.
        * A=PLU is well-conditioned, so no zero divisions or overflow may occur

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        private static void cbasiclusolve(complex[,] lua,
            int[] p,
            int n,
            complex[] xb,
            alglib.xparams _params)
        {
            int i = 0;
            complex v = 0;
            int i_ = 0;

            for(i=0; i<=n-1; i++)
            {
                if( p[i]!=i )
                {
                    v = xb[i];
                    xb[i] = xb[p[i]];
                    xb[p[i]] = v;
                }
            }
            for(i=1; i<=n-1; i++)
            {
                v = 0.0;
                for(i_=0; i_<=i-1;i_++)
                {
                    v += lua[i,i_]*xb[i_];
                }
                xb[i] = xb[i]-v;
            }
            xb[n-1] = xb[n-1]/lua[n-1,n-1];
            for(i=n-2; i>=0; i--)
            {
                v = 0.0;
                for(i_=i+1; i_<=n-1;i_++)
                {
                    v += lua[i,i_]*xb[i_];
                }
                xb[i] = (xb[i]-v)/lua[i,i];
            }
        }


        /*************************************************************************
        Basic Cholesky solver for ScaleA*Cholesky(A)'*x = y.

        This subroutine assumes that:
        * A*ScaleA is well scaled
        * A is well-conditioned, so no zero divisions or overflow may occur

          -- ALGLIB --
             Copyright 27.01.2010 by Bochkanov Sergey
        *************************************************************************/
        private static void hpdbasiccholeskysolve(complex[,] cha,
            int n,
            bool isupper,
            complex[] xb,
            alglib.xparams _params)
        {
            int i = 0;
            complex v = 0;
            int i_ = 0;

            
            //
            // A = L*L' or A=U'*U
            //
            if( isupper )
            {
                
                //
                // Solve U'*y=b first.
                //
                for(i=0; i<=n-1; i++)
                {
                    xb[i] = xb[i]/math.conj(cha[i,i]);
                    if( i<n-1 )
                    {
                        v = xb[i];
                        for(i_=i+1; i_<=n-1;i_++)
                        {
                            xb[i_] = xb[i_] - v*math.conj(cha[i,i_]);
                        }
                    }
                }
                
                //
                // Solve U*x=y then.
                //
                for(i=n-1; i>=0; i--)
                {
                    if( i<n-1 )
                    {
                        v = 0.0;
                        for(i_=i+1; i_<=n-1;i_++)
                        {
                            v += cha[i,i_]*xb[i_];
                        }
                        xb[i] = xb[i]-v;
                    }
                    xb[i] = xb[i]/cha[i,i];
                }
            }
            else
            {
                
                //
                // Solve L*y=b first
                //
                for(i=0; i<=n-1; i++)
                {
                    if( i>0 )
                    {
                        v = 0.0;
                        for(i_=0; i_<=i-1;i_++)
                        {
                            v += cha[i,i_]*xb[i_];
                        }
                        xb[i] = xb[i]-v;
                    }
                    xb[i] = xb[i]/cha[i,i];
                }
                
                //
                // Solve L'*x=y then.
                //
                for(i=n-1; i>=0; i--)
                {
                    xb[i] = xb[i]/math.conj(cha[i,i]);
                    if( i>0 )
                    {
                        v = xb[i];
                        for(i_=0; i_<=i-1;i_++)
                        {
                            xb[i_] = xb[i_] - v*math.conj(cha[i,i_]);
                        }
                    }
                }
            }
        }


    }
    public class iterativesparse
    {
        /*************************************************************************
        This structure is a sparse solver report (both direct and iterative solvers
        use this structure).

        Following fields can be accessed by users:
        * TerminationType (specific error codes depend on the solver  being  used,
          with positive values ALWAYS signaling  that something useful is returned
          in X, and negative values ALWAYS meaning critical failures.
        * NMV - number of matrix-vector products performed (0 for direct solvers)
        * IterationsCount - inner iterations count (0 for direct solvers)
        * R2 - squared residual
        *************************************************************************/
        public class sparsesolverreport : apobject
        {
            public int terminationtype;
            public int nmv;
            public int iterationscount;
            public double r2;
            public sparsesolverreport()
            {
                init();
            }
            public override void init()
            {
            }
            public override alglib.apobject make_copy()
            {
                sparsesolverreport _result = new sparsesolverreport();
                _result.terminationtype = terminationtype;
                _result.nmv = nmv;
                _result.iterationscount = iterationscount;
                _result.r2 = r2;
                return _result;
            }
        };


        /*************************************************************************
        This object stores state of the sparse linear solver object.

        You should use ALGLIB functions to work with this object.
        Never try to access its fields directly!
        *************************************************************************/
        public class sparsesolverstate : apobject
        {
            public int n;
            public double[] x0;
            public double epsf;
            public int maxits;
            public int algotype;
            public int gmresk;
            public bool xrep;
            public bool running;
            public bool userterminationneeded;
            public double[] b;
            public double[] xf;
            public int repiterationscount;
            public int repnmv;
            public int repterminationtype;
            public double repr2;
            public int requesttype;
            public double[] x;
            public double[] ax;
            public double reply1;
            public double[] wrkb;
            public sparse.sparsematrix convbuf;
            public fbls.fblsgmresstate gmressolver;
            public rcommstate rstate;
            public sparsesolverstate()
            {
                init();
            }
            public override void init()
            {
                x0 = new double[0];
                b = new double[0];
                xf = new double[0];
                x = new double[0];
                ax = new double[0];
                wrkb = new double[0];
                convbuf = new sparse.sparsematrix();
                gmressolver = new fbls.fblsgmresstate();
                rstate = new rcommstate();
            }
            public override alglib.apobject make_copy()
            {
                sparsesolverstate _result = new sparsesolverstate();
                _result.n = n;
                _result.x0 = (double[])x0.Clone();
                _result.epsf = epsf;
                _result.maxits = maxits;
                _result.algotype = algotype;
                _result.gmresk = gmresk;
                _result.xrep = xrep;
                _result.running = running;
                _result.userterminationneeded = userterminationneeded;
                _result.b = (double[])b.Clone();
                _result.xf = (double[])xf.Clone();
                _result.repiterationscount = repiterationscount;
                _result.repnmv = repnmv;
                _result.repterminationtype = repterminationtype;
                _result.repr2 = repr2;
                _result.requesttype = requesttype;
                _result.x = (double[])x.Clone();
                _result.ax = (double[])ax.Clone();
                _result.reply1 = reply1;
                _result.wrkb = (double[])wrkb.Clone();
                _result.convbuf = (sparse.sparsematrix)convbuf.make_copy();
                _result.gmressolver = (fbls.fblsgmresstate)gmressolver.make_copy();
                _result.rstate = (rcommstate)rstate.make_copy();
                return _result;
            }
        };




        /*************************************************************************
        Solving sparse symmetric linear system A*x=b using GMRES(k) method. Sparse
        symmetric A is given by its lower or upper triangle.

        NOTE: use SparseSolveGMRES() to solve system with nonsymmetric A.

        This function provides convenience API for an 'expert' interface  provided
        by SparseSolverState class. Use SparseSolver  API  if  you  need  advanced
        functions like providing initial point, using out-of-core API and so on.

        INPUT PARAMETERS:
            A       -   sparse symmetric NxN matrix in any sparse storage  format.
                        Using CRS format is recommended because it avoids internal
                        conversion.
                        An exception will be generated if  A  is  not  NxN  matrix
                        (where  N  is  a  size   specified  during  solver  object
                        creation).
            IsUpper -   whether upper or lower triangle of A is used:
                        * IsUpper=True  => only upper triangle is used and lower
                                           triangle is not referenced at all 
                        * IsUpper=False => only lower triangle is used and upper
                                           triangle is not referenced at all
            B       -   right part, array[N]
            K       -   k parameter for  GMRES(k), k>=0.  Zero  value  means  that
                        algorithm will choose it automatically.
            EpsF    -   stopping condition, EpsF>=0. The algorithm will stop  when
                        residual will decrease below EpsF*|B|. Having EpsF=0 means
                        that this stopping condition is ignored.
            MaxIts  -   stopping condition, MaxIts>=0.  The  algorithm  will  stop
                        after performing MaxIts iterations. Zero  value  means  no
                        limit.

        NOTE: having both EpsF=0 and MaxIts=0 means that stopping criteria will be
              chosen automatically.
                        
        OUTPUT PARAMETERS:
            X       -   array[N], the solution
            Rep     -   solution report:
                        * Rep.TerminationType completion code:
                            * -5    CG method was used for a matrix which  is  not
                                    positive definite
                            * -4    overflow/underflow during solution
                                    (ill conditioned problem)
                            *  1    ||residual||<=EpsF*||b||
                            *  5    MaxIts steps was taken
                            *  7    rounding errors prevent further progress,
                                    best point found is returned
                            *  8    the  algorithm  was  terminated   early  with
                                    SparseSolverRequestTermination() being called
                                    from other thread.
                        * Rep.IterationsCount contains iterations count
                        * Rep.NMV contains number of matrix-vector calculations
                        * Rep.R2 contains squared residual

          -- ALGLIB --
             Copyright 25.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolvesymmetricgmres(sparse.sparsematrix a,
            bool isupper,
            double[] b,
            int k,
            double epsf,
            int maxits,
            ref double[] x,
            sparsesolverreport rep,
            alglib.xparams _params)
        {
            int n = 0;
            sparse.sparsematrix convbuf = new sparse.sparsematrix();
            sparsesolverstate solver = new sparsesolverstate();

            x = new double[0];

            n = sparse.sparsegetnrows(a, _params);
            
            //
            // Test inputs
            //
            alglib.ap.assert(n>=1, "SparseSolveSymmetricGMRES: tried to automatically detect N from sizeof(A), got nonpositive size");
            alglib.ap.assert(sparse.sparsegetnrows(a, _params)==n, "SparseSolveSymmetricGMRES: rows(A)!=N");
            alglib.ap.assert(sparse.sparsegetncols(a, _params)==n, "SparseSolveSymmetricGMRES: cols(A)!=N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SparseSolveSymmetricGMRES: length(B)<N");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SparseSolveSymmetricGMRES: B contains NAN/INF");
            alglib.ap.assert(math.isfinite(epsf) && (double)(epsf)>=(double)(0), "SparseSolveSymmetricGMRES: EpsF<0 or infinite");
            alglib.ap.assert(maxits>=0, "SparseSolveSymmetricGMRES: MaxIts<0");
            if( (double)(epsf)==(double)(0) && maxits==0 )
            {
                epsf = 1.0E-6;
            }
            
            //
            // If A is non-CRS, perform conversion
            //
            if( !sparse.sparseiscrs(a, _params) )
            {
                sparse.sparsecopytocrsbuf(a, convbuf, _params);
                sparsesolvesymmetricgmres(convbuf, isupper, b, k, epsf, maxits, ref x, rep, _params);
                return;
            }
            
            //
            // Solve using temporary solver object
            //
            sparsesolvercreate(n, solver, _params);
            sparsesolversetalgogmres(solver, k, _params);
            sparsesolversetcond(solver, epsf, maxits, _params);
            sparsesolversolvesymmetric(solver, a, isupper, b, _params);
            sparsesolverresults(solver, ref x, rep, _params);
        }


        /*************************************************************************
        Solving sparse linear system A*x=b using GMRES(k) method.

        This function provides convenience API for an 'expert' interface  provided
        by SparseSolverState class. Use SparseSolver  API  if  you  need  advanced
        functions like providing initial point, using out-of-core API and so on.

        INPUT PARAMETERS:
            A       -   sparse NxN matrix in any sparse storage format. Using  CRS
                        format   is   recommended   because   it  avoids  internal
                        conversion.
                        An exception will be generated if  A  is  not  NxN  matrix
                        (where  N  is  a  size   specified  during  solver  object
                        creation).
            B       -   right part, array[N]
            K       -   k parameter for  GMRES(k), k>=0.  Zero  value  means  that
                        algorithm will choose it automatically.
            EpsF    -   stopping condition, EpsF>=0. The algorithm will stop  when
                        residual will decrease below EpsF*|B|. Having EpsF=0 means
                        that this stopping condition is ignored.
            MaxIts  -   stopping condition, MaxIts>=0.  The  algorithm  will  stop
                        after performing MaxIts iterations. Zero  value  means  no
                        limit.

        NOTE: having both EpsF=0 and MaxIts=0 means that stopping criteria will be
              chosen automatically.
                        
        OUTPUT PARAMETERS:
            X       -   array[N], the solution
            Rep     -   solution report:
                        * Rep.TerminationType completion code:
                            * -5    CG method was used for a matrix which  is  not
                                    positive definite
                            * -4    overflow/underflow during solution
                                    (ill conditioned problem)
                            *  1    ||residual||<=EpsF*||b||
                            *  5    MaxIts steps was taken
                            *  7    rounding errors prevent further progress,
                                    best point found is returned
                            *  8    the  algorithm  was  terminated   early  with
                                    SparseSolverRequestTermination() being called
                                    from other thread.
                        * Rep.IterationsCount contains iterations count
                        * Rep.NMV contains number of matrix-vector calculations
                        * Rep.R2 contains squared residual

          -- ALGLIB --
             Copyright 25.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolvegmres(sparse.sparsematrix a,
            double[] b,
            int k,
            double epsf,
            int maxits,
            ref double[] x,
            sparsesolverreport rep,
            alglib.xparams _params)
        {
            int n = 0;
            sparse.sparsematrix convbuf = new sparse.sparsematrix();
            sparsesolverstate solver = new sparsesolverstate();

            x = new double[0];

            n = sparse.sparsegetnrows(a, _params);
            
            //
            // Test inputs
            //
            alglib.ap.assert(n>=1, "SparseSolveGMRES: tried to automatically detect N from sizeof(A), got nonpositive size");
            alglib.ap.assert(sparse.sparsegetnrows(a, _params)==n, "SparseSolveGMRES: rows(A)!=N");
            alglib.ap.assert(sparse.sparsegetncols(a, _params)==n, "SparseSolveGMRES: cols(A)!=N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SparseSolveGMRES: length(B)<N");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SparseSolveGMRES: B contains NAN/INF");
            alglib.ap.assert(math.isfinite(epsf) && (double)(epsf)>=(double)(0), "SparseSolveGMRES: EpsF<0 or infinite");
            alglib.ap.assert(maxits>=0, "SparseSolveGMRES: MaxIts<0");
            if( (double)(epsf)==(double)(0) && maxits==0 )
            {
                epsf = 1.0E-6;
            }
            
            //
            // If A is non-CRS, perform conversion
            //
            if( !sparse.sparseiscrs(a, _params) )
            {
                sparse.sparsecopytocrsbuf(a, convbuf, _params);
                sparsesolvegmres(convbuf, b, k, epsf, maxits, ref x, rep, _params);
                return;
            }
            
            //
            // Solve using temporary solver object
            //
            sparsesolvercreate(n, solver, _params);
            sparsesolversetalgogmres(solver, k, _params);
            sparsesolversetcond(solver, epsf, maxits, _params);
            sparsesolversolve(solver, a, b, _params);
            sparsesolverresults(solver, ref x, rep, _params);
        }


        /*************************************************************************
        This function initializes sparse linear iterative solver object.

        This solver can be used  to  solve  nonsymmetric  and  symmetric  positive
        definite NxN (square) linear systems.

        The solver provides  'expert'  API  which  allows  advanced  control  over
        algorithms being used, including ability to get progress report, terminate
        long-running solver from other thread, out-of-core solution and so on.

        NOTE: there are also convenience  functions  that  allows  quick  one-line
              access to the solvers:
              * SparseSolveCG() to solve SPD linear systems
              * SparseSolveGMRES() to solve unsymmetric linear systems.

        NOTE: if you want to solve MxN (rectangular) linear problem  you  may  use
              LinLSQR solver provided by ALGLIB.

        USAGE (A is given by the SparseMatrix structure):

            1. User initializes algorithm state with SparseSolverCreate() call
            2. User  selects   algorithm  with one of the SparseSolverSetAlgo???()
               functions. By default, GMRES(k) is used with automatically chosen k
            3. Optionally, user tunes solver parameters, sets starting point, etc.
            4. Depending on whether system is symmetric or not, user calls:
               * SparseSolverSolveSymmetric() for a  symmetric system given by its
                 lower or upper triangle
               * SparseSolverSolve() for a nonsymmetric system or a symmetric  one
                 given by the full matrix
            5. User calls SparseSolverResults() to get the solution

            It is possible to call SparseSolverSolve???() again to  solve  another
            task with same dimensionality but different matrix and/or  right  part
            without reinitializing SparseSolverState structure.
          
        USAGE (out-of-core mode):

            1. User initializes algorithm state with SparseSolverCreate() call
            2. User  selects   algorithm  with one of the SparseSolverSetAlgo???()
               functions. By default, GMRES(k) is used with automatically chosen k
            3. Optionally, user tunes solver parameters, sets starting point, etc.
            4. After that user should work with out-of-core interface  in  a  loop
               like one given below:
               
                > alglib.sparsesolveroocstart(state)
                > while alglib.sparsesolverooccontinue(state) do
                >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
                >     alglib.sparsesolveroocgetrequestdata(state, out X)
                >     if RequestType=0 then
                >         [calculate  Y=A*X, with X=R^N]
                >     alglib.sparsesolveroocsendresult(state, in Y)
                > alglib.sparsesolveroocstop(state, out X, out Report)

        INPUT PARAMETERS:
            N       -   problem dimensionality (fixed at start-up)

        OUTPUT PARAMETERS:
            State   -   structure which stores algorithm state

          -- ALGLIB --
             Copyright 24.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolvercreate(int n,
            sparsesolverstate state,
            alglib.xparams _params)
        {
            alglib.ap.assert(n>=1, "SparseSolverCreate: N<=0");
            state.n = n;
            state.running = false;
            state.userterminationneeded = false;
            ablasf.rsetallocv(state.n, 0.0, ref state.x0, _params);
            ablasf.rsetallocv(state.n, 0.0, ref state.x, _params);
            ablasf.rsetallocv(state.n, 0.0, ref state.ax, _params);
            ablasf.rsetallocv(state.n, 0.0, ref state.xf, _params);
            ablasf.rsetallocv(state.n, 0.0, ref state.b, _params);
            ablasf.rsetallocv(state.n, 0.0, ref state.wrkb, _params);
            state.reply1 = 0.0;
            sparsesolversetxrep(state, false, _params);
            sparsesolversetcond(state, 0.0, 0, _params);
            sparsesolversetalgogmres(state, 0, _params);
            clearrequestfields(state, _params);
            clearreportfields(state, _params);
        }


        /*************************************************************************
        This function sets the solver algorithm to GMRES(k).

        NOTE: if you do not need advanced functionality of the  SparseSolver  API,
              you   may   use   convenience   functions   SparseSolveGMRES()   and
              SparseSolveSymmetricGMRES().

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state
            K       -   GMRES parameter, K>=0:
                        * recommended values are in 10..100 range
                        * larger values up to N are possible but have little sense
                          - the algorithm will be slower than any dense solver.
                        * values above N are truncated down to N
                        * zero value means that  default  value  is  chosen.  This
                          value is 50 in the current version, but  it  may  change
                          in future ALGLIB releases.

          -- ALGLIB --
             Copyright 24.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolversetalgogmres(sparsesolverstate state,
            int k,
            alglib.xparams _params)
        {
            alglib.ap.assert(k>=0, "SparseSolverSetAlgoGMRESK: K<0");
            state.algotype = 0;
            if( k==0 )
            {
                k = 50;
            }
            state.gmresk = Math.Min(k, state.n);
        }


        /*************************************************************************
        This function sets starting point.
        By default, zero starting point is used.

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state
            X       -   starting point, array[N]

        OUTPUT PARAMETERS:
            State   -   new starting point was set

          -- ALGLIB --
             Copyright 24.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolversetstartingpoint(sparsesolverstate state,
            double[] x,
            alglib.xparams _params)
        {
            alglib.ap.assert(state.n<=alglib.ap.len(x), "SparseSolverSetStartingPoint: Length(X)<N");
            alglib.ap.assert(apserv.isfinitevector(x, state.n, _params), "SparseSolverSetStartingPoint: X contains infinite or NaN values!");
            ablasf.rcopyv(state.n, x, state.x0, _params);
        }


        /*************************************************************************
        This function sets stopping criteria.

        INPUT PARAMETERS:
            EpsF    -   algorithm will be stopped if norm of residual is less than 
                        EpsF*||b||.
            MaxIts  -   algorithm will be stopped if number of iterations is  more 
                        than MaxIts.

        OUTPUT PARAMETERS:
            State   -   structure which stores algorithm state

        NOTES:
        If  both  EpsF  and  MaxIts  are  zero then small EpsF will be set to small 
        value.

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolversetcond(sparsesolverstate state,
            double epsf,
            int maxits,
            alglib.xparams _params)
        {
            alglib.ap.assert(math.isfinite(epsf) && (double)(epsf)>=(double)(0), "SparseSolverSetCond: EpsF is negative or contains infinite or NaN values");
            alglib.ap.assert(maxits>=0, "SparseSolverSetCond: MaxIts is negative");
            if( (double)(epsf)==(double)(0) && maxits==0 )
            {
                state.epsf = 1.0E-6;
                state.maxits = 0;
            }
            else
            {
                state.epsf = epsf;
                state.maxits = maxits;
            }
        }


        /*************************************************************************
        Procedure for  the  solution of A*x=b with sparse symmetric A given by its
        lower or upper triangle.

        This function will work with any solver algorithm  being   used,  SPD  one
        (like CG) or not (like GMRES). Using unsymmetric solvers (like  GMRES)  on
        SPD problems is suboptimal, but still possible.

        NOTE: the  solver  behavior is ill-defined  for  a  situation  when a  SPD
              solver is used on indefinite matrix. It  may solve the problem up to
              desired precision (sometimes, rarely)  or  return  with  error  code
              signalling violation of underlying assumptions.

        INPUT PARAMETERS:
            State   -   algorithm state
            A       -   sparse symmetric NxN matrix in any sparse storage  format.
                        Using CRS format is recommended because it avoids internal
                        conversion.
                        An exception will be generated if  A  is  not  NxN  matrix
                        (where  N  is  a  size   specified  during  solver  object
                        creation).
            IsUpper -   whether upper or lower triangle of A is used:
                        * IsUpper=True  => only upper triangle is used and lower
                                           triangle is not referenced at all 
                        * IsUpper=False => only lower triangle is used and upper
                                           triangle is not referenced at all
            B       -   right part, array[N]

        RESULT:
            This function returns no result.
            You can get the solution by calling SparseSolverResults()

          -- ALGLIB --
             Copyright 25.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolversolvesymmetric(sparsesolverstate state,
            sparse.sparsematrix a,
            bool isupper,
            double[] b,
            alglib.xparams _params)
        {
            int n = 0;

            n = state.n;
            
            //
            // Test inputs
            //
            alglib.ap.assert(sparse.sparsegetnrows(a, _params)==n, "SparseSolverSolveSymmetric: rows(A)!=N");
            alglib.ap.assert(sparse.sparsegetncols(a, _params)==n, "SparseSolverSolveSymmetric: cols(A)!=N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SparseSolverSolveSymmetric: length(B)<N");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SparseSolverSolveSymmetric: B contains NAN/INF");
            
            //
            // If A is non-CRS, perform conversion
            //
            if( !sparse.sparseiscrs(a, _params) )
            {
                sparse.sparsecopytocrsbuf(a, state.convbuf, _params);
                sparsesolversolvesymmetric(state, state.convbuf, isupper, b, _params);
                return;
            }
            
            //
            // Solve using out-of-core API
            //
            sparsesolveroocstart(state, b, _params);
            while( sparsesolverooccontinue(state, _params) )
            {
                if( state.requesttype==-1 )
                {
                    
                    //
                    // Skip location reports
                    //
                    continue;
                }
                alglib.ap.assert(state.requesttype==0, "SparseSolverSolveSymmetric: integrity check 7372 failed");
                sparse.sparsesmv(a, isupper, state.x, ref state.ax, _params);
            }
        }


        /*************************************************************************
        Procedure for the solution of A*x=b with sparse nonsymmetric A

        IMPORTANT: this function will work with any solver algorithm  being  used,
                   symmetric solver like CG,  or  not.  However,  using  symmetric
                   solvers on nonsymmetric problems is  dangerous.  It  may  solve
                   the problem up  to  desired  precision  (sometimes,  rarely) or
                   terminate with error code signalling  violation  of  underlying
                   assumptions.

        INPUT PARAMETERS:
            State   -   algorithm state
            A       -   sparse NxN matrix in any sparse storage  format.
                        Using CRS format is recommended because it avoids internal
                        conversion.
                        An exception will be generated if  A  is  not  NxN  matrix
                        (where  N  is  a  size   specified  during  solver  object
                        creation).
            B       -   right part, array[N]

        RESULT:
            This function returns no result.
            You can get the solution by calling SparseSolverResults()

          -- ALGLIB --
             Copyright 25.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolversolve(sparsesolverstate state,
            sparse.sparsematrix a,
            double[] b,
            alglib.xparams _params)
        {
            int n = 0;

            n = state.n;
            
            //
            // Test inputs
            //
            alglib.ap.assert(sparse.sparsegetnrows(a, _params)==n, "SparseSolverSolve: rows(A)!=N");
            alglib.ap.assert(sparse.sparsegetncols(a, _params)==n, "SparseSolverSolve: cols(A)!=N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SparseSolverSolve: length(B)<N");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SparseSolverSolve: B contains NAN/INF");
            
            //
            // If A is non-CRS, perform conversion
            //
            if( !sparse.sparseiscrs(a, _params) )
            {
                sparse.sparsecopytocrsbuf(a, state.convbuf, _params);
                sparsesolversolve(state, state.convbuf, b, _params);
                return;
            }
            
            //
            // Solve using out-of-core API
            //
            sparsesolveroocstart(state, b, _params);
            while( sparsesolverooccontinue(state, _params) )
            {
                if( state.requesttype==-1 )
                {
                    
                    //
                    // Skip location reports
                    //
                    continue;
                }
                alglib.ap.assert(state.requesttype==0, "SparseSolverSolve: integrity check 7372 failed");
                sparse.sparsemv(a, state.x, ref state.ax, _params);
            }
        }


        /*************************************************************************
        Sparse solver results.

        This function must be called after calling one of the SparseSolverSolve()
        functions.

        INPUT PARAMETERS:
            State   -   algorithm state

        OUTPUT PARAMETERS:
            X       -   array[N], solution
            Rep     -   solution report:
                        * Rep.TerminationType completion code:
                            * -5    CG method was used for a matrix which  is  not
                                    positive definite
                            * -4    overflow/underflow during solution
                                    (ill conditioned problem)
                            *  1    ||residual||<=EpsF*||b||
                            *  5    MaxIts steps was taken
                            *  7    rounding errors prevent further progress,
                                    best point found is returned
                            *  8    the  algorithm  was  terminated   early  with
                                    SparseSolverRequestTermination() being called
                                    from other thread.
                        * Rep.IterationsCount contains iterations count
                        * Rep.NMV contains number of matrix-vector calculations
                        * Rep.R2 contains squared residual
        s
          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolverresults(sparsesolverstate state,
            ref double[] x,
            sparsesolverreport rep,
            alglib.xparams _params)
        {
            x = new double[0];

            sparsesolveroocstop(state, ref x, rep, _params);
        }


        /*************************************************************************
        This function turns on/off reporting during out-of-core processing.

        When the solver works in the out-of-core mode, it  can  be  configured  to
        report its progress by returning current location. These location  reports
        are implemented as a special kind of the out-of-core request:
        * SparseSolverOOCGetRequestInfo() returns -1
        * SparseSolverOOCGetRequestData() returns current location
        * SparseSolverOOCGetRequestData1() returns squared norm of the residual
        * SparseSolverOOCSendResult() shall NOT be called

        This function has no effect when SparseSolverSolve() is used because  this
        function has no method of reporting its progress.

        NOTE: when used with GMRES(k), this function reports progress  every  k-th
              iteration.

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state
            NeedXRep-   whether iteration reports are needed or not

          -- ALGLIB --
             Copyright 01.10.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolversetxrep(sparsesolverstate state,
            bool needxrep,
            alglib.xparams _params)
        {
            state.xrep = needxrep;
        }


        /*************************************************************************
        This function initiates out-of-core mode of the sparse solver.  It  should
        be used in conjunction with other out-of-core-related  functions  of  this
        subspackage in a loop like one given below:

        > alglib.sparsesolveroocstart(state)
        > while alglib.sparsesolverooccontinue(state) do
        >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
        >     alglib.sparsesolveroocgetrequestdata(state, out X)
        >     if RequestType=0 then
        >         [calculate  Y=A*X, with X=R^N]
        >     alglib.sparsesolveroocsendresult(state, in Y)
        > alglib.sparsesolveroocstop(state, out X, out Report)

        INPUT PARAMETERS:
            State       -   solver object

          -- ALGLIB --
             Copyright 24.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolveroocstart(sparsesolverstate state,
            double[] b,
            alglib.xparams _params)
        {
            state.rstate.ia = new int[0+1];
            state.rstate.ra = new double[2+1];
            state.rstate.stage = -1;
            clearrequestfields(state, _params);
            clearreportfields(state, _params);
            state.running = true;
            state.userterminationneeded = false;
            ablasf.rcopyv(state.n, b, state.b, _params);
        }


        /*************************************************************************
        This function performs iterative solution of  the  linear  system  in  the
        out-of-core mode. It should be used in conjunction with other out-of-core-
        related functions of this subspackage in a loop like one given below:

        > alglib.sparsesolveroocstart(state)
        > while alglib.sparsesolverooccontinue(state) do
        >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
        >     alglib.sparsesolveroocgetrequestdata(state, out X)
        >     if RequestType=0 then
        >         [calculate  Y=A*X, with X=R^N]
        >     alglib.sparsesolveroocsendresult(state, in Y)
        > alglib.sparsesolveroocstop(state, out X, out Report)

          -- ALGLIB --
             Copyright 24.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static bool sparsesolverooccontinue(sparsesolverstate state,
            alglib.xparams _params)
        {
            bool result = new bool();

            alglib.ap.assert(state.running, "SparseSolverContinue: the solver is not running");
            result = sparsesolveriteration(state, _params);
            state.running = result;
            return result;
        }


        /*************************************************************************
        This function is used to retrieve information  about  out-of-core  request
        sent by the solver:
        * RequestType=0  means that matrix-vector products A*x is requested
        * RequestType=-1 means that solver reports its progress; this  request  is
          returned only when reports are activated wit SparseSolverSetXRep().

        This function returns just request type; in order  to  get contents of the
        trial vector, use sparsesolveroocgetrequestdata().

        It should be used in conjunction with other out-of-core-related  functions
        of this subspackage in a loop like one given below:

        > alglib.sparsesolveroocstart(state)
        > while alglib.sparsesolverooccontinue(state) do
        >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
        >     alglib.sparsesolveroocgetrequestdata(state, out X)
        >     if RequestType=0 then
        >         [calculate  Y=A*X, with X=R^N]
        >     alglib.sparsesolveroocsendresult(state, in Y)
        > alglib.sparsesolveroocstop(state, out X, out Report)

        INPUT PARAMETERS:
            State           -   solver running in out-of-core mode
            
        OUTPUT PARAMETERS:
            RequestType     -   type of the request to process:
                                * 0   for matrix-vector product A*x, with A  being
                                  NxN system matrix  and X being N-dimensional
                                  vector
                                *-1   for location and residual report


          -- ALGLIB --
             Copyright 24.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolveroocgetrequestinfo(sparsesolverstate state,
            ref int requesttype,
            alglib.xparams _params)
        {
            requesttype = 0;

            alglib.ap.assert(state.running, "SparseSolverOOCGetRequestInfo: the solver is not running");
            requesttype = state.requesttype;
        }


        /*************************************************************************
        This function is used  to  retrieve  vector  associated  with  out-of-core
        request sent by the solver to user code. Depending  on  the  request  type
        (returned by the SparseSolverOOCGetRequestInfo()) this  vector  should  be
        multiplied by A or subjected to another processing.

        It should be used in conjunction with other out-of-core-related  functions
        of this subspackage in a loop like one given below:

        > alglib.sparsesolveroocstart(state)
        > while alglib.sparsesolverooccontinue(state) do
        >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
        >     alglib.sparsesolveroocgetrequestdata(state, out X)
        >     if RequestType=0 then
        >         [calculate  Y=A*X, with X=R^N]
        >     alglib.sparsesolveroocsendresult(state, in Y)
        > alglib.sparsesolveroocstop(state, out X, out Report)

        INPUT PARAMETERS:
            State           -   solver running in out-of-core mode
            X               -   possibly  preallocated   storage;  reallocated  if
                                needed, left unchanged, if large enough  to  store
                                request data.
            
        OUTPUT PARAMETERS:
            X               -   array[N] or larger, leading N elements are  filled
                                with vector X.


          -- ALGLIB --
             Copyright 24.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolveroocgetrequestdata(sparsesolverstate state,
            ref double[] x,
            alglib.xparams _params)
        {
            alglib.ap.assert(state.running, "SparseSolverOOCGetRequestInfo: the solver is not running");
            ablasf.rcopyallocv(state.n, state.x, ref x, _params);
        }


        /*************************************************************************
        This function is used to retrieve scalar value associated with out-of-core
        request sent by the solver to user code. In  the  current  ALGLIB  version
        this function is used to retrieve squared residual  norm  during  progress
        reports.

        INPUT PARAMETERS:
            State           -   solver running in out-of-core mode
            
        OUTPUT PARAMETERS:
            V               -   scalar value associated with the current request


          -- ALGLIB --
             Copyright 24.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolveroocgetrequestdata1(sparsesolverstate state,
            ref double v,
            alglib.xparams _params)
        {
            v = 0;

            alglib.ap.assert(state.running, "SparseSolverOOCGetRequestInfo: the solver is not running");
            v = state.reply1;
        }


        /*************************************************************************
        This function is used to send user reply to out-of-core  request  sent  by
        the solver. Usually it is product A*x for vector X returned by the solver.

        It should be used in conjunction with other out-of-core-related  functions
        of this subspackage in a loop like one given below:

        > alglib.sparsesolveroocstart(state)
        > while alglib.sparsesolverooccontinue(state) do
        >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
        >     alglib.sparsesolveroocgetrequestdata(state, out X)
        >     if RequestType=0 then
        >         [calculate  Y=A*X, with X=R^N]
        >     alglib.sparsesolveroocsendresult(state, in Y)
        > alglib.sparsesolveroocstop(state, out X, out Report)

        INPUT PARAMETERS:
            State           -   solver running in out-of-core mode
            AX              -   array[N] or larger, leading N elements contain A*x


          -- ALGLIB --
             Copyright 24.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolveroocsendresult(sparsesolverstate state,
            double[] ax,
            alglib.xparams _params)
        {
            alglib.ap.assert(state.running, "SparseSolverOOCSendResult: the solver is not running");
            alglib.ap.assert(state.requesttype==0, "SparseSolverOOCSendResult: this request type does not accept replies");
            ablasf.rcopyv(state.n, ax, state.ax, _params);
        }


        /*************************************************************************
        This  function  finalizes out-of-core mode of the linear solver. It should
        be used in conjunction with other out-of-core-related  functions  of  this
        subspackage in a loop like one given below:

        > alglib.sparsesolveroocstart(state)
        > while alglib.sparsesolverooccontinue(state) do
        >     alglib.sparsesolveroocgetrequestinfo(state, out RequestType)
        >     alglib.sparsesolveroocgetrequestdata(state, out X)
        >     if RequestType=0 then
        >         [calculate  Y=A*X, with X=R^N]
        >     alglib.sparsesolveroocsendresult(state, in Y)
        > alglib.sparsesolveroocstop(state, out X, out Report)

        INPUT PARAMETERS:
            State       -   solver state
            
        OUTPUT PARAMETERS:
            X       -   array[N], the solution.
                        Zero-filled on the failure (Rep.TerminationType<0).
            Rep     -   report with additional info:
                        * Rep.TerminationType completion code:
                            * -5    CG method was used for a matrix which  is  not
                                    positive definite
                            * -4    overflow/underflow during solution
                                    (ill conditioned problem)
                            *  1    ||residual||<=EpsF*||b||
                            *  5    MaxIts steps was taken
                            *  7    rounding errors prevent further progress,
                                    best point found is returned
                            *  8    the  algorithm  was  terminated   early  with
                                    SparseSolverRequestTermination() being called
                                    from other thread.
                        * Rep.IterationsCount contains iterations count
                        * Rep.NMV contains number of matrix-vector calculations
                        * Rep.R2 contains squared residual

          -- ALGLIB --
             Copyright 24.09.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolveroocstop(sparsesolverstate state,
            ref double[] x,
            sparsesolverreport rep,
            alglib.xparams _params)
        {
            x = new double[0];

            alglib.ap.assert(!state.running, "SparseSolverOOCStop: the solver is still running");
            x = new double[state.n];
            ablasf.rcopyv(state.n, state.xf, x, _params);
            initsparsesolverreport(rep, _params);
            rep.iterationscount = state.repiterationscount;
            rep.nmv = state.repnmv;
            rep.terminationtype = state.repterminationtype;
            rep.r2 = state.repr2;
        }


        /*************************************************************************
        This subroutine submits request for termination of the running solver.  It
        can be called from some other thread which wants the   solver to terminate
        or when processing an out-of-core request.

        As result, solver  stops  at  point  which  was  "current  accepted"  when
        the termination request was submitted and returns error code 8 (successful
        termination).  Such   termination   is  a smooth  process  which  properly
        deallocates all temporaries.

        INPUT PARAMETERS:
            State   -   solver structure

        NOTE: calling this function on solver which is NOT running  will  have  no
              effect.
              
        NOTE: multiple calls to this function are possible. First call is counted,
              subsequent calls are silently ignored.

        NOTE: solver clears termination flag on its start, it means that  if  some
              other thread will request termination too soon, its request will went
              unnoticed.

          -- ALGLIB --
             Copyright 01.10.2021 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolverrequesttermination(sparsesolverstate state,
            alglib.xparams _params)
        {
            state.userterminationneeded = true;
        }


        /*************************************************************************
        Reset report fields

          -- ALGLIB --
             Copyright 26.12.2017 by Bochkanov Sergey
        *************************************************************************/
        public static void initsparsesolverreport(sparsesolverreport rep,
            alglib.xparams _params)
        {
            rep.terminationtype = 0;
            rep.nmv = 0;
            rep.iterationscount = 0;
            rep.r2 = 0;
        }


        /*************************************************************************
        Reverse communication sparse iteration subroutine

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        private static bool sparsesolveriteration(sparsesolverstate state,
            alglib.xparams _params)
        {
            bool result = new bool();
            int outeridx = 0;
            double res = 0;
            double prevres = 0;
            double res0 = 0;

            
            //
            // Reverse communication preparations
            // I know it looks ugly, but it works the same way
            // anywhere from C++ to Python.
            //
            // This code initializes locals by:
            // * random values determined during code
            //   generation - on first subroutine call
            // * values from previous call - on subsequent calls
            //
            if( state.rstate.stage>=0 )
            {
                outeridx = state.rstate.ia[0];
                res = state.rstate.ra[0];
                prevres = state.rstate.ra[1];
                res0 = state.rstate.ra[2];
            }
            else
            {
                outeridx = 359;
                res = -58.0;
                prevres = -919.0;
                res0 = -909.0;
            }
            if( state.rstate.stage==0 )
            {
                goto lbl_0;
            }
            if( state.rstate.stage==1 )
            {
                goto lbl_1;
            }
            if( state.rstate.stage==2 )
            {
                goto lbl_2;
            }
            if( state.rstate.stage==3 )
            {
                goto lbl_3;
            }
            if( state.rstate.stage==4 )
            {
                goto lbl_4;
            }
            
            //
            // Routine body
            //
            state.running = true;
            clearrequestfields(state, _params);
            clearreportfields(state, _params);
            
            //
            // GMRES?
            //
            if( state.algotype!=0 )
            {
                goto lbl_5;
            }
            if( (double)(ablasf.rdotv2(state.n, state.x0, _params))!=(double)(0) )
            {
                goto lbl_7;
            }
            
            //
            // Starting point is default one (zero), quick initialization
            //
            ablasf.rsetv(state.n, 0.0, state.xf, _params);
            ablasf.rcopyv(state.n, state.b, state.wrkb, _params);
            goto lbl_8;
        lbl_7:
            
            //
            // Non-zero starting point is provided, 
            //
            ablasf.rcopyv(state.n, state.x0, state.xf, _params);
            state.requesttype = 0;
            ablasf.rcopyv(state.n, state.x0, state.x, _params);
            state.rstate.stage = 0;
            goto lbl_rcomm;
        lbl_0:
            state.requesttype = -999;
            state.repnmv = state.repnmv+1;
            ablasf.rcopyv(state.n, state.b, state.wrkb, _params);
            ablasf.raddv(state.n, -1.0, state.ax, state.wrkb, _params);
        lbl_8:
            outeridx = 0;
            state.repterminationtype = 5;
            state.repr2 = ablasf.rdotv2(state.n, state.wrkb, _params);
            res0 = Math.Sqrt(ablasf.rdotv2(state.n, state.b, _params));
            res = Math.Sqrt(state.repr2);
            if( !state.xrep )
            {
                goto lbl_9;
            }
            
            //
            // Report initial point
            //
            state.requesttype = -1;
            state.reply1 = res*res;
            ablasf.rcopyv(state.n, state.xf, state.x, _params);
            state.rstate.stage = 1;
            goto lbl_rcomm;
        lbl_1:
            state.requesttype = -999;
        lbl_9:
        lbl_11:
            if( !((double)(res)>(double)(0) && (state.maxits==0 || state.repiterationscount<state.maxits)) )
            {
                goto lbl_12;
            }
            
            //
            // Solve with GMRES(k) for current residual.
            //
            // We set EpsF-based stopping condition for GMRES(k). It allows us
            // to quickly detect sufficient decrease in the residual. We still
            // have to recompute residual after the GMRES round because residuals
            // computed by GMRES are different from the true one (due to restarts).
            //
            // However, checking residual decrease within GMRES still gives us
            // an opportunity to stop early without waiting for GMRES round to
            // complete.
            //
            fbls.fblsgmrescreate(state.wrkb, state.n, state.gmresk, state.gmressolver, _params);
            state.gmressolver.epsres = state.epsf*res0/res;
        lbl_13:
            if( !fbls.fblsgmresiteration(state.gmressolver, _params) )
            {
                goto lbl_14;
            }
            state.requesttype = 0;
            ablasf.rcopyv(state.n, state.gmressolver.x, state.x, _params);
            state.rstate.stage = 2;
            goto lbl_rcomm;
        lbl_2:
            state.requesttype = -999;
            ablasf.rcopyv(state.n, state.ax, state.gmressolver.ax, _params);
            state.repnmv = state.repnmv+1;
            if( state.userterminationneeded )
            {
                
                //
                // User requested termination
                //
                state.repterminationtype = 8;
                result = false;
                return result;
            }
            goto lbl_13;
        lbl_14:
            state.repiterationscount = state.repiterationscount+state.gmressolver.itsperformed;
            ablasf.raddv(state.n, 1.0, state.gmressolver.xs, state.xf, _params);
            
            //
            // Update residual, evaluate residual decrease, terminate if needed
            //
            state.requesttype = 0;
            ablasf.rcopyv(state.n, state.xf, state.x, _params);
            state.rstate.stage = 3;
            goto lbl_rcomm;
        lbl_3:
            state.requesttype = -999;
            state.repnmv = state.repnmv+1;
            ablasf.rcopyv(state.n, state.b, state.wrkb, _params);
            ablasf.raddv(state.n, -1.0, state.ax, state.wrkb, _params);
            state.repr2 = ablasf.rdotv2(state.n, state.wrkb, _params);
            prevres = res;
            res = Math.Sqrt(state.repr2);
            if( !state.xrep )
            {
                goto lbl_15;
            }
            
            //
            // Report initial point
            //
            state.requesttype = -1;
            state.reply1 = res*res;
            ablasf.rcopyv(state.n, state.xf, state.x, _params);
            state.rstate.stage = 4;
            goto lbl_rcomm;
        lbl_4:
            state.requesttype = -999;
        lbl_15:
            if( (double)(res)<=(double)(state.epsf*res0) )
            {
                
                //
                // Residual decrease condition met, stopping
                //
                state.repterminationtype = 1;
                goto lbl_12;
            }
            if( (double)(res)>=(double)(prevres*(1-Math.Sqrt(math.machineepsilon))) )
            {
                
                //
                // The algorithm stagnated
                //
                state.repterminationtype = 7;
                goto lbl_12;
            }
            if( state.userterminationneeded )
            {
                
                //
                // User requested termination
                //
                state.repterminationtype = 8;
                result = false;
                return result;
            }
            outeridx = outeridx+1;
            goto lbl_11;
        lbl_12:
            result = false;
            return result;
        lbl_5:
            alglib.ap.assert(false, "SparseSolverIteration: integrity check failed (unexpected algo)");
            result = false;
            return result;
            
            //
            // Saving state
            //
        lbl_rcomm:
            result = true;
            state.rstate.ia[0] = outeridx;
            state.rstate.ra[0] = res;
            state.rstate.ra[1] = prevres;
            state.rstate.ra[2] = res0;
            return result;
        }


        /*************************************************************************
        Clears request fileds (to be sure that we don't forgot to clear something)
        *************************************************************************/
        private static void clearrequestfields(sparsesolverstate state,
            alglib.xparams _params)
        {
            state.requesttype = -999;
        }


        /*************************************************************************
        Clears report fileds (to be sure that we don't forgot to clear something)
        *************************************************************************/
        private static void clearreportfields(sparsesolverstate state,
            alglib.xparams _params)
        {
            state.repiterationscount = 0;
            state.repnmv = 0;
            state.repterminationtype = 0;
            state.repr2 = 0;
        }


    }
    public class lincg
    {
        /*************************************************************************
        This object stores state of the linear CG method.

        You should use ALGLIB functions to work with this object.
        Never try to access its fields directly!
        *************************************************************************/
        public class lincgstate : apobject
        {
            public double[] rx;
            public double[] b;
            public int n;
            public int prectype;
            public double[] cx;
            public double[] cr;
            public double[] cz;
            public double[] p;
            public double[] r;
            public double[] z;
            public double alpha;
            public double beta;
            public double r2;
            public double meritfunction;
            public double[] x;
            public double[] mv;
            public double[] pv;
            public double vmv;
            public double[] startx;
            public double epsf;
            public int maxits;
            public int itsbeforerestart;
            public int itsbeforerupdate;
            public bool xrep;
            public bool xupdated;
            public bool needmv;
            public bool needmtv;
            public bool needmv2;
            public bool needvmv;
            public bool needprec;
            public int repiterationscount;
            public int repnmv;
            public int repterminationtype;
            public bool running;
            public double[] tmpd;
            public rcommstate rstate;
            public lincgstate()
            {
                init();
            }
            public override void init()
            {
                rx = new double[0];
                b = new double[0];
                cx = new double[0];
                cr = new double[0];
                cz = new double[0];
                p = new double[0];
                r = new double[0];
                z = new double[0];
                x = new double[0];
                mv = new double[0];
                pv = new double[0];
                startx = new double[0];
                tmpd = new double[0];
                rstate = new rcommstate();
            }
            public override alglib.apobject make_copy()
            {
                lincgstate _result = new lincgstate();
                _result.rx = (double[])rx.Clone();
                _result.b = (double[])b.Clone();
                _result.n = n;
                _result.prectype = prectype;
                _result.cx = (double[])cx.Clone();
                _result.cr = (double[])cr.Clone();
                _result.cz = (double[])cz.Clone();
                _result.p = (double[])p.Clone();
                _result.r = (double[])r.Clone();
                _result.z = (double[])z.Clone();
                _result.alpha = alpha;
                _result.beta = beta;
                _result.r2 = r2;
                _result.meritfunction = meritfunction;
                _result.x = (double[])x.Clone();
                _result.mv = (double[])mv.Clone();
                _result.pv = (double[])pv.Clone();
                _result.vmv = vmv;
                _result.startx = (double[])startx.Clone();
                _result.epsf = epsf;
                _result.maxits = maxits;
                _result.itsbeforerestart = itsbeforerestart;
                _result.itsbeforerupdate = itsbeforerupdate;
                _result.xrep = xrep;
                _result.xupdated = xupdated;
                _result.needmv = needmv;
                _result.needmtv = needmtv;
                _result.needmv2 = needmv2;
                _result.needvmv = needvmv;
                _result.needprec = needprec;
                _result.repiterationscount = repiterationscount;
                _result.repnmv = repnmv;
                _result.repterminationtype = repterminationtype;
                _result.running = running;
                _result.tmpd = (double[])tmpd.Clone();
                _result.rstate = (rcommstate)rstate.make_copy();
                return _result;
            }
        };


        public class lincgreport : apobject
        {
            public int iterationscount;
            public int nmv;
            public int terminationtype;
            public double r2;
            public lincgreport()
            {
                init();
            }
            public override void init()
            {
            }
            public override alglib.apobject make_copy()
            {
                lincgreport _result = new lincgreport();
                _result.iterationscount = iterationscount;
                _result.nmv = nmv;
                _result.terminationtype = terminationtype;
                _result.r2 = r2;
                return _result;
            }
        };




        public const double defaultprecision = 1.0E-6;


        /*************************************************************************
        This function initializes linear CG Solver. This solver is used  to  solve
        symmetric positive definite problems. If you want  to  solve  nonsymmetric
        (or non-positive definite) problem you may use LinLSQR solver provided  by
        ALGLIB.

        USAGE:
        1. User initializes algorithm state with LinCGCreate() call
        2. User tunes solver parameters with  LinCGSetCond() and other functions
        3. Optionally, user sets starting point with LinCGSetStartingPoint()
        4. User  calls LinCGSolveSparse() function which takes algorithm state and
           SparseMatrix object.
        5. User calls LinCGResults() to get solution
        6. Optionally, user may call LinCGSolveSparse()  again  to  solve  another
           problem  with different matrix and/or right part without reinitializing
           LinCGState structure.
          
        INPUT PARAMETERS:
            N       -   problem dimension, N>0

        OUTPUT PARAMETERS:
            State   -   structure which stores algorithm state

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void lincgcreate(int n,
            lincgstate state,
            alglib.xparams _params)
        {
            int i = 0;

            alglib.ap.assert(n>0, "LinCGCreate: N<=0");
            state.n = n;
            state.prectype = 0;
            state.itsbeforerestart = n;
            state.itsbeforerupdate = 10;
            state.epsf = defaultprecision;
            state.maxits = 0;
            state.xrep = false;
            state.running = false;
            
            //
            // * allocate arrays
            // * set RX to NAN (just for the case user calls Results() without 
            //   calling SolveSparse()
            // * set starting point to zero
            // * we do NOT initialize B here because we assume that user should
            //   initializate it using LinCGSetB() function. In case he forgets
            //   to do so, exception will be thrown in the LinCGIteration().
            //
            state.rx = new double[state.n];
            state.startx = new double[state.n];
            state.b = new double[state.n];
            for(i=0; i<=state.n-1; i++)
            {
                state.rx[i] = Double.NaN;
                state.startx[i] = 0.0;
                state.b[i] = 0;
            }
            state.cx = new double[state.n];
            state.p = new double[state.n];
            state.r = new double[state.n];
            state.cr = new double[state.n];
            state.z = new double[state.n];
            state.cz = new double[state.n];
            state.x = new double[state.n];
            state.mv = new double[state.n];
            state.pv = new double[state.n];
            updateitersdata(state, _params);
            state.rstate.ia = new int[0+1];
            state.rstate.ra = new double[2+1];
            state.rstate.stage = -1;
        }


        /*************************************************************************
        This function sets starting point.
        By default, zero starting point is used.

        INPUT PARAMETERS:
            X       -   starting point, array[N]

        OUTPUT PARAMETERS:
            State   -   structure which stores algorithm state

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void lincgsetstartingpoint(lincgstate state,
            double[] x,
            alglib.xparams _params)
        {
            int i_ = 0;

            alglib.ap.assert(!state.running, "LinCGSetStartingPoint: you can not change starting point because LinCGIteration() function is running");
            alglib.ap.assert(state.n<=alglib.ap.len(x), "LinCGSetStartingPoint: Length(X)<N");
            alglib.ap.assert(apserv.isfinitevector(x, state.n, _params), "LinCGSetStartingPoint: X contains infinite or NaN values!");
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.startx[i_] = x[i_];
            }
        }


        /*************************************************************************
        This function sets right part. By default, right part is zero.

        INPUT PARAMETERS:
            B       -   right part, array[N].

        OUTPUT PARAMETERS:
            State   -   structure which stores algorithm state

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void lincgsetb(lincgstate state,
            double[] b,
            alglib.xparams _params)
        {
            int i_ = 0;

            alglib.ap.assert(!state.running, "LinCGSetB: you can not set B, because function LinCGIteration is running!");
            alglib.ap.assert(alglib.ap.len(b)>=state.n, "LinCGSetB: Length(B)<N");
            alglib.ap.assert(apserv.isfinitevector(b, state.n, _params), "LinCGSetB: B contains infinite or NaN values!");
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.b[i_] = b[i_];
            }
        }


        /*************************************************************************
        This  function  changes  preconditioning  settings  of  LinCGSolveSparse()
        function. By default, SolveSparse() uses diagonal preconditioner,  but  if
        you want to use solver without preconditioning, you can call this function
        which forces solver to use unit matrix for preconditioning.

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state

          -- ALGLIB --
             Copyright 19.11.2012 by Bochkanov Sergey
        *************************************************************************/
        public static void lincgsetprecunit(lincgstate state,
            alglib.xparams _params)
        {
            alglib.ap.assert(!state.running, "LinCGSetPrecUnit: you can not change preconditioner, because function LinCGIteration is running!");
            state.prectype = -1;
        }


        /*************************************************************************
        This  function  changes  preconditioning  settings  of  LinCGSolveSparse()
        function.  LinCGSolveSparse() will use diagonal of the  system  matrix  as
        preconditioner. This preconditioning mode is active by default.

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state

          -- ALGLIB --
             Copyright 19.11.2012 by Bochkanov Sergey
        *************************************************************************/
        public static void lincgsetprecdiag(lincgstate state,
            alglib.xparams _params)
        {
            alglib.ap.assert(!state.running, "LinCGSetPrecDiag: you can not change preconditioner, because function LinCGIteration is running!");
            state.prectype = 0;
        }


        /*************************************************************************
        This function sets stopping criteria.

        INPUT PARAMETERS:
            EpsF    -   algorithm will be stopped if norm of residual is less than 
                        EpsF*||b||.
            MaxIts  -   algorithm will be stopped if number of iterations is  more 
                        than MaxIts.

        OUTPUT PARAMETERS:
            State   -   structure which stores algorithm state

        NOTES:
        If  both  EpsF  and  MaxIts  are  zero then small EpsF will be set to small 
        value.

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void lincgsetcond(lincgstate state,
            double epsf,
            int maxits,
            alglib.xparams _params)
        {
            alglib.ap.assert(!state.running, "LinCGSetCond: you can not change stopping criteria when LinCGIteration() is running");
            alglib.ap.assert(math.isfinite(epsf) && (double)(epsf)>=(double)(0), "LinCGSetCond: EpsF is negative or contains infinite or NaN values");
            alglib.ap.assert(maxits>=0, "LinCGSetCond: MaxIts is negative");
            if( (double)(epsf)==(double)(0) && maxits==0 )
            {
                state.epsf = defaultprecision;
                state.maxits = maxits;
            }
            else
            {
                state.epsf = epsf;
                state.maxits = maxits;
            }
        }


        /*************************************************************************
        Reverse communication version of linear CG.

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static bool lincgiteration(lincgstate state,
            alglib.xparams _params)
        {
            bool result = new bool();
            int i = 0;
            double uvar = 0;
            double bnorm = 0;
            double v = 0;
            int i_ = 0;

            
            //
            // Reverse communication preparations
            // I know it looks ugly, but it works the same way
            // anywhere from C++ to Python.
            //
            // This code initializes locals by:
            // * random values determined during code
            //   generation - on first subroutine call
            // * values from previous call - on subsequent calls
            //
            if( state.rstate.stage>=0 )
            {
                i = state.rstate.ia[0];
                uvar = state.rstate.ra[0];
                bnorm = state.rstate.ra[1];
                v = state.rstate.ra[2];
            }
            else
            {
                i = 359;
                uvar = -58.0;
                bnorm = -919.0;
                v = -909.0;
            }
            if( state.rstate.stage==0 )
            {
                goto lbl_0;
            }
            if( state.rstate.stage==1 )
            {
                goto lbl_1;
            }
            if( state.rstate.stage==2 )
            {
                goto lbl_2;
            }
            if( state.rstate.stage==3 )
            {
                goto lbl_3;
            }
            if( state.rstate.stage==4 )
            {
                goto lbl_4;
            }
            if( state.rstate.stage==5 )
            {
                goto lbl_5;
            }
            if( state.rstate.stage==6 )
            {
                goto lbl_6;
            }
            if( state.rstate.stage==7 )
            {
                goto lbl_7;
            }
            
            //
            // Routine body
            //
            alglib.ap.assert(alglib.ap.len(state.b)>0, "LinCGIteration: B is not initialized (you must initialize B by LinCGSetB() call");
            state.running = true;
            state.repnmv = 0;
            clearrfields(state, _params);
            updateitersdata(state, _params);
            
            //
            // Start 0-th iteration
            //
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.rx[i_] = state.startx[i_];
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = state.rx[i_];
            }
            state.repnmv = state.repnmv+1;
            clearrfields(state, _params);
            state.needvmv = true;
            state.rstate.stage = 0;
            goto lbl_rcomm;
        lbl_0:
            state.needvmv = false;
            bnorm = 0;
            state.r2 = 0;
            state.meritfunction = 0;
            for(i=0; i<=state.n-1; i++)
            {
                state.r[i] = state.b[i]-state.mv[i];
                state.r2 = state.r2+state.r[i]*state.r[i];
                state.meritfunction = state.meritfunction+state.mv[i]*state.rx[i]-2*state.b[i]*state.rx[i];
                bnorm = bnorm+state.b[i]*state.b[i];
            }
            bnorm = Math.Sqrt(bnorm);
            
            //
            // Output first report
            //
            if( !state.xrep )
            {
                goto lbl_8;
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = state.rx[i_];
            }
            clearrfields(state, _params);
            state.xupdated = true;
            state.rstate.stage = 1;
            goto lbl_rcomm;
        lbl_1:
            state.xupdated = false;
        lbl_8:
            
            //
            // Is x0 a solution?
            //
            if( !math.isfinite(state.r2) || (double)(Math.Sqrt(state.r2))<=(double)(state.epsf*bnorm) )
            {
                state.running = false;
                if( math.isfinite(state.r2) )
                {
                    state.repterminationtype = 1;
                }
                else
                {
                    state.repterminationtype = -4;
                }
                result = false;
                return result;
            }
            
            //
            // Calculate Z and P
            //
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = state.r[i_];
            }
            state.repnmv = state.repnmv+1;
            clearrfields(state, _params);
            state.needprec = true;
            state.rstate.stage = 2;
            goto lbl_rcomm;
        lbl_2:
            state.needprec = false;
            for(i=0; i<=state.n-1; i++)
            {
                state.z[i] = state.pv[i];
                state.p[i] = state.z[i];
            }
            
            //
            // Other iterations(1..N)
            //
            state.repiterationscount = 0;
        lbl_10:
            if( false )
            {
                goto lbl_11;
            }
            state.repiterationscount = state.repiterationscount+1;
            
            //
            // Calculate Alpha
            //
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = state.p[i_];
            }
            state.repnmv = state.repnmv+1;
            clearrfields(state, _params);
            state.needvmv = true;
            state.rstate.stage = 3;
            goto lbl_rcomm;
        lbl_3:
            state.needvmv = false;
            if( !math.isfinite(state.vmv) || (double)(state.vmv)<=(double)(0) )
            {
                
                //
                // a) Overflow when calculating VMV
                // b) non-positive VMV (non-SPD matrix)
                //
                state.running = false;
                if( math.isfinite(state.vmv) )
                {
                    state.repterminationtype = -5;
                }
                else
                {
                    state.repterminationtype = -4;
                }
                result = false;
                return result;
            }
            state.alpha = 0;
            for(i=0; i<=state.n-1; i++)
            {
                state.alpha = state.alpha+state.r[i]*state.z[i];
            }
            state.alpha = state.alpha/state.vmv;
            if( !math.isfinite(state.alpha) )
            {
                
                //
                // Overflow when calculating Alpha
                //
                state.running = false;
                state.repterminationtype = -4;
                result = false;
                return result;
            }
            
            //
            // Next step toward solution
            //
            for(i=0; i<=state.n-1; i++)
            {
                state.cx[i] = state.rx[i]+state.alpha*state.p[i];
            }
            
            //
            // Calculate R:
            // * use recurrent relation to update R
            // * at every ItsBeforeRUpdate-th iteration recalculate it from scratch, using matrix-vector product
            //   in case R grows instead of decreasing, algorithm is terminated with positive completion code
            //
            if( !(state.itsbeforerupdate==0 || state.repiterationscount%state.itsbeforerupdate!=0) )
            {
                goto lbl_12;
            }
            
            //
            // Calculate R using recurrent formula
            //
            for(i=0; i<=state.n-1; i++)
            {
                state.cr[i] = state.r[i]-state.alpha*state.mv[i];
                state.x[i] = state.cr[i];
            }
            goto lbl_13;
        lbl_12:
            
            //
            // Calculate R using matrix-vector multiplication
            //
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = state.cx[i_];
            }
            state.repnmv = state.repnmv+1;
            clearrfields(state, _params);
            state.needmv = true;
            state.rstate.stage = 4;
            goto lbl_rcomm;
        lbl_4:
            state.needmv = false;
            for(i=0; i<=state.n-1; i++)
            {
                state.cr[i] = state.b[i]-state.mv[i];
                state.x[i] = state.cr[i];
            }
            
            //
            // Calculating merit function
            // Check emergency stopping criterion
            //
            v = 0;
            for(i=0; i<=state.n-1; i++)
            {
                v = v+state.mv[i]*state.cx[i]-2*state.b[i]*state.cx[i];
            }
            if( (double)(v)<(double)(state.meritfunction) )
            {
                goto lbl_14;
            }
            for(i=0; i<=state.n-1; i++)
            {
                if( !math.isfinite(state.rx[i]) )
                {
                    state.running = false;
                    state.repterminationtype = -4;
                    result = false;
                    return result;
                }
            }
            
            //
            //output last report
            //
            if( !state.xrep )
            {
                goto lbl_16;
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = state.rx[i_];
            }
            clearrfields(state, _params);
            state.xupdated = true;
            state.rstate.stage = 5;
            goto lbl_rcomm;
        lbl_5:
            state.xupdated = false;
        lbl_16:
            state.running = false;
            state.repterminationtype = 7;
            result = false;
            return result;
        lbl_14:
            state.meritfunction = v;
        lbl_13:
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.rx[i_] = state.cx[i_];
            }
            
            //
            // calculating RNorm
            //
            // NOTE: monotonic decrease of R2 is not guaranteed by algorithm.
            //
            state.r2 = 0;
            for(i=0; i<=state.n-1; i++)
            {
                state.r2 = state.r2+state.cr[i]*state.cr[i];
            }
            
            //
            //output report
            //
            if( !state.xrep )
            {
                goto lbl_18;
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = state.rx[i_];
            }
            clearrfields(state, _params);
            state.xupdated = true;
            state.rstate.stage = 6;
            goto lbl_rcomm;
        lbl_6:
            state.xupdated = false;
        lbl_18:
            
            //
            //stopping criterion
            //achieved the required precision
            //
            if( !math.isfinite(state.r2) || (double)(Math.Sqrt(state.r2))<=(double)(state.epsf*bnorm) )
            {
                state.running = false;
                if( math.isfinite(state.r2) )
                {
                    state.repterminationtype = 1;
                }
                else
                {
                    state.repterminationtype = -4;
                }
                result = false;
                return result;
            }
            if( state.repiterationscount>=state.maxits && state.maxits>0 )
            {
                for(i=0; i<=state.n-1; i++)
                {
                    if( !math.isfinite(state.rx[i]) )
                    {
                        state.running = false;
                        state.repterminationtype = -4;
                        result = false;
                        return result;
                    }
                }
                
                //
                //if X is finite number
                //
                state.running = false;
                state.repterminationtype = 5;
                result = false;
                return result;
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = state.cr[i_];
            }
            
            //
            //prepere of parameters for next iteration
            //
            state.repnmv = state.repnmv+1;
            clearrfields(state, _params);
            state.needprec = true;
            state.rstate.stage = 7;
            goto lbl_rcomm;
        lbl_7:
            state.needprec = false;
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.cz[i_] = state.pv[i_];
            }
            if( state.repiterationscount%state.itsbeforerestart!=0 )
            {
                state.beta = 0;
                uvar = 0;
                for(i=0; i<=state.n-1; i++)
                {
                    state.beta = state.beta+state.cz[i]*state.cr[i];
                    uvar = uvar+state.z[i]*state.r[i];
                }
                
                //
                //check that UVar is't INF or is't zero
                //
                if( !math.isfinite(uvar) || (double)(uvar)==(double)(0) )
                {
                    state.running = false;
                    state.repterminationtype = -4;
                    result = false;
                    return result;
                }
                
                //
                //calculate .BETA
                //
                state.beta = state.beta/uvar;
                
                //
                //check that .BETA neither INF nor NaN
                //
                if( !math.isfinite(state.beta) )
                {
                    state.running = false;
                    state.repterminationtype = -1;
                    result = false;
                    return result;
                }
                for(i=0; i<=state.n-1; i++)
                {
                    state.p[i] = state.cz[i]+state.beta*state.p[i];
                }
            }
            else
            {
                for(i_=0; i_<=state.n-1;i_++)
                {
                    state.p[i_] = state.cz[i_];
                }
            }
            
            //
            //prepere data for next iteration
            //
            for(i=0; i<=state.n-1; i++)
            {
                
                //
                //write (k+1)th iteration to (k )th iteration
                //
                state.r[i] = state.cr[i];
                state.z[i] = state.cz[i];
            }
            goto lbl_10;
        lbl_11:
            result = false;
            return result;
            
            //
            // Saving state
            //
        lbl_rcomm:
            result = true;
            state.rstate.ia[0] = i;
            state.rstate.ra[0] = uvar;
            state.rstate.ra[1] = bnorm;
            state.rstate.ra[2] = v;
            return result;
        }


        /*************************************************************************
        Procedure for solution of A*x=b with sparse A.

        INPUT PARAMETERS:
            State   -   algorithm state
            A       -   sparse matrix in the CRS format (you MUST contvert  it  to 
                        CRS format by calling SparseConvertToCRS() function).
            IsUpper -   whether upper or lower triangle of A is used:
                        * IsUpper=True  => only upper triangle is used and lower
                                           triangle is not referenced at all 
                        * IsUpper=False => only lower triangle is used and upper
                                           triangle is not referenced at all
            B       -   right part, array[N]

        RESULT:
            This function returns no result.
            You can get solution by calling LinCGResults()
            
        NOTE: this function uses lightweight preconditioning -  multiplication  by
              inverse of diag(A). If you want, you can turn preconditioning off by
              calling LinCGSetPrecUnit(). However, preconditioning cost is low and
              preconditioner  is  very  important  for  solution  of  badly scaled
              problems.

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void lincgsolvesparse(lincgstate state,
            sparse.sparsematrix a,
            bool isupper,
            double[] b,
            alglib.xparams _params)
        {
            int n = 0;
            int i = 0;
            double v = 0;
            double vmv = 0;
            int i_ = 0;

            n = state.n;
            alglib.ap.assert(alglib.ap.len(b)>=state.n, "LinCGSetB: Length(B)<N");
            alglib.ap.assert(apserv.isfinitevector(b, state.n, _params), "LinCGSetB: B contains infinite or NaN values!");
            
            //
            // Allocate temporaries
            //
            apserv.rvectorsetlengthatleast(ref state.tmpd, n, _params);
            
            //
            // Compute diagonal scaling matrix D
            //
            if( state.prectype==0 )
            {
                
                //
                // Default preconditioner - inverse of matrix diagonal
                //
                for(i=0; i<=n-1; i++)
                {
                    v = sparse.sparsegetdiagonal(a, i, _params);
                    if( (double)(v)>(double)(0) )
                    {
                        state.tmpd[i] = 1/Math.Sqrt(v);
                    }
                    else
                    {
                        state.tmpd[i] = 1;
                    }
                }
            }
            else
            {
                
                //
                // No diagonal scaling
                //
                for(i=0; i<=n-1; i++)
                {
                    state.tmpd[i] = 1;
                }
            }
            
            //
            // Solve
            //
            lincgrestart(state, _params);
            lincgsetb(state, b, _params);
            while( lincgiteration(state, _params) )
            {
                
                //
                // Process different requests from optimizer
                //
                if( state.needmv )
                {
                    sparse.sparsesmv(a, isupper, state.x, ref state.mv, _params);
                }
                if( state.needvmv )
                {
                    sparse.sparsesmv(a, isupper, state.x, ref state.mv, _params);
                    vmv = 0.0;
                    for(i_=0; i_<=state.n-1;i_++)
                    {
                        vmv += state.x[i_]*state.mv[i_];
                    }
                    state.vmv = vmv;
                }
                if( state.needprec )
                {
                    for(i=0; i<=n-1; i++)
                    {
                        state.pv[i] = state.x[i]*math.sqr(state.tmpd[i]);
                    }
                }
            }
        }


        /*************************************************************************
        CG-solver: results.

        This function must be called after LinCGSolve

        INPUT PARAMETERS:
            State   -   algorithm state

        OUTPUT PARAMETERS:
            X       -   array[N], solution
            Rep     -   optimization report:
                        * Rep.TerminationType completetion code:
                            * -5    input matrix is either not positive definite,
                                    too large or too small                            
                            * -4    overflow/underflow during solution
                                    (ill conditioned problem)
                            *  1    ||residual||<=EpsF*||b||
                            *  5    MaxIts steps was taken
                            *  7    rounding errors prevent further progress,
                                    best point found is returned
                        * Rep.IterationsCount contains iterations count
                        * NMV countains number of matrix-vector calculations

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void lincgresults(lincgstate state,
            ref double[] x,
            lincgreport rep,
            alglib.xparams _params)
        {
            int i_ = 0;

            x = new double[0];

            alglib.ap.assert(!state.running, "LinCGResult: you can not get result, because function LinCGIteration has been launched!");
            if( alglib.ap.len(x)<state.n )
            {
                x = new double[state.n];
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                x[i_] = state.rx[i_];
            }
            rep.iterationscount = state.repiterationscount;
            rep.nmv = state.repnmv;
            rep.terminationtype = state.repterminationtype;
            rep.r2 = state.r2;
        }


        /*************************************************************************
        This function sets restart frequency. By default, algorithm  is  restarted
        after N subsequent iterations.

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void lincgsetrestartfreq(lincgstate state,
            int srf,
            alglib.xparams _params)
        {
            alglib.ap.assert(!state.running, "LinCGSetRestartFreq: you can not change restart frequency when LinCGIteration() is running");
            alglib.ap.assert(srf>0, "LinCGSetRestartFreq: non-positive SRF");
            state.itsbeforerestart = srf;
        }


        /*************************************************************************
        This function sets frequency of residual recalculations.

        Algorithm updates residual r_k using iterative formula,  but  recalculates
        it from scratch after each 10 iterations. It is done to avoid accumulation
        of numerical errors and to stop algorithm when r_k starts to grow.

        Such low update frequence (1/10) gives very  little  overhead,  but  makes
        algorithm a bit more robust against numerical errors. However, you may
        change it 

        INPUT PARAMETERS:
            Freq    -   desired update frequency, Freq>=0.
                        Zero value means that no updates will be done.

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void lincgsetrupdatefreq(lincgstate state,
            int freq,
            alglib.xparams _params)
        {
            alglib.ap.assert(!state.running, "LinCGSetRUpdateFreq: you can not change update frequency when LinCGIteration() is running");
            alglib.ap.assert(freq>=0, "LinCGSetRUpdateFreq: non-positive Freq");
            state.itsbeforerupdate = freq;
        }


        /*************************************************************************
        This function turns on/off reporting.

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state
            NeedXRep-   whether iteration reports are needed or not

        If NeedXRep is True, algorithm will call rep() callback function if  it is
        provided to MinCGOptimize().

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void lincgsetxrep(lincgstate state,
            bool needxrep,
            alglib.xparams _params)
        {
            state.xrep = needxrep;
        }


        /*************************************************************************
        Procedure for restart function LinCGIteration

          -- ALGLIB --
             Copyright 14.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void lincgrestart(lincgstate state,
            alglib.xparams _params)
        {
            state.rstate.ia = new int[0+1];
            state.rstate.ra = new double[2+1];
            state.rstate.stage = -1;
            clearrfields(state, _params);
        }


        /*************************************************************************
        Clears request fileds (to be sure that we don't forgot to clear something)
        *************************************************************************/
        private static void clearrfields(lincgstate state,
            alglib.xparams _params)
        {
            state.xupdated = false;
            state.needmv = false;
            state.needmtv = false;
            state.needmv2 = false;
            state.needvmv = false;
            state.needprec = false;
        }


        /*************************************************************************
        Clears request fileds (to be sure that we don't forgot to clear something)
        *************************************************************************/
        private static void updateitersdata(lincgstate state,
            alglib.xparams _params)
        {
            state.repiterationscount = 0;
            state.repnmv = 0;
            state.repterminationtype = 0;
        }


    }
    public class linlsqr
    {
        /*************************************************************************
        This object stores state of the LinLSQR method.

        You should use ALGLIB functions to work with this object.
        *************************************************************************/
        public class linlsqrstate : apobject
        {
            public normestimator.normestimatorstate nes;
            public double[] rx;
            public double[] b;
            public int n;
            public int m;
            public int prectype;
            public double[] ui;
            public double[] uip1;
            public double[] vi;
            public double[] vip1;
            public double[] omegai;
            public double[] omegaip1;
            public double alphai;
            public double alphaip1;
            public double betai;
            public double betaip1;
            public double phibari;
            public double phibarip1;
            public double phii;
            public double rhobari;
            public double rhobarip1;
            public double rhoi;
            public double ci;
            public double si;
            public double theta;
            public double lambdai;
            public double[] d;
            public double anorm;
            public double bnorm2;
            public double dnorm;
            public double r2;
            public double[] x;
            public double[] mv;
            public double[] mtv;
            public double epsa;
            public double epsb;
            public double epsc;
            public int maxits;
            public bool xrep;
            public bool xupdated;
            public bool needmv;
            public bool needmtv;
            public bool needmv2;
            public bool needvmv;
            public bool needprec;
            public int repiterationscount;
            public int repnmv;
            public int repterminationtype;
            public bool running;
            public bool userterminationneeded;
            public double[] tmpd;
            public double[] tmpx;
            public rcommstate rstate;
            public linlsqrstate()
            {
                init();
            }
            public override void init()
            {
                nes = new normestimator.normestimatorstate();
                rx = new double[0];
                b = new double[0];
                ui = new double[0];
                uip1 = new double[0];
                vi = new double[0];
                vip1 = new double[0];
                omegai = new double[0];
                omegaip1 = new double[0];
                d = new double[0];
                x = new double[0];
                mv = new double[0];
                mtv = new double[0];
                tmpd = new double[0];
                tmpx = new double[0];
                rstate = new rcommstate();
            }
            public override alglib.apobject make_copy()
            {
                linlsqrstate _result = new linlsqrstate();
                _result.nes = (normestimator.normestimatorstate)nes.make_copy();
                _result.rx = (double[])rx.Clone();
                _result.b = (double[])b.Clone();
                _result.n = n;
                _result.m = m;
                _result.prectype = prectype;
                _result.ui = (double[])ui.Clone();
                _result.uip1 = (double[])uip1.Clone();
                _result.vi = (double[])vi.Clone();
                _result.vip1 = (double[])vip1.Clone();
                _result.omegai = (double[])omegai.Clone();
                _result.omegaip1 = (double[])omegaip1.Clone();
                _result.alphai = alphai;
                _result.alphaip1 = alphaip1;
                _result.betai = betai;
                _result.betaip1 = betaip1;
                _result.phibari = phibari;
                _result.phibarip1 = phibarip1;
                _result.phii = phii;
                _result.rhobari = rhobari;
                _result.rhobarip1 = rhobarip1;
                _result.rhoi = rhoi;
                _result.ci = ci;
                _result.si = si;
                _result.theta = theta;
                _result.lambdai = lambdai;
                _result.d = (double[])d.Clone();
                _result.anorm = anorm;
                _result.bnorm2 = bnorm2;
                _result.dnorm = dnorm;
                _result.r2 = r2;
                _result.x = (double[])x.Clone();
                _result.mv = (double[])mv.Clone();
                _result.mtv = (double[])mtv.Clone();
                _result.epsa = epsa;
                _result.epsb = epsb;
                _result.epsc = epsc;
                _result.maxits = maxits;
                _result.xrep = xrep;
                _result.xupdated = xupdated;
                _result.needmv = needmv;
                _result.needmtv = needmtv;
                _result.needmv2 = needmv2;
                _result.needvmv = needvmv;
                _result.needprec = needprec;
                _result.repiterationscount = repiterationscount;
                _result.repnmv = repnmv;
                _result.repterminationtype = repterminationtype;
                _result.running = running;
                _result.userterminationneeded = userterminationneeded;
                _result.tmpd = (double[])tmpd.Clone();
                _result.tmpx = (double[])tmpx.Clone();
                _result.rstate = (rcommstate)rstate.make_copy();
                return _result;
            }
        };


        public class linlsqrreport : apobject
        {
            public int iterationscount;
            public int nmv;
            public int terminationtype;
            public linlsqrreport()
            {
                init();
            }
            public override void init()
            {
            }
            public override alglib.apobject make_copy()
            {
                linlsqrreport _result = new linlsqrreport();
                _result.iterationscount = iterationscount;
                _result.nmv = nmv;
                _result.terminationtype = terminationtype;
                return _result;
            }
        };




        public const double atol = 1.0E-6;
        public const double btol = 1.0E-6;


        /*************************************************************************
        This function initializes linear LSQR Solver. This solver is used to solve
        non-symmetric (and, possibly, non-square) problems. Least squares solution
        is returned for non-compatible systems.

        USAGE:
        1. User initializes algorithm state with LinLSQRCreate() call
        2. User tunes solver parameters with  LinLSQRSetCond() and other functions
        3. User  calls  LinLSQRSolveSparse()  function which takes algorithm state 
           and SparseMatrix object.
        4. User calls LinLSQRResults() to get solution
        5. Optionally, user may call LinLSQRSolveSparse() again to  solve  another  
           problem  with different matrix and/or right part without reinitializing 
           LinLSQRState structure.
          
        INPUT PARAMETERS:
            M       -   number of rows in A
            N       -   number of variables, N>0

        OUTPUT PARAMETERS:
            State   -   structure which stores algorithm state
            
        NOTE: see also linlsqrcreatebuf()  for  version  which  reuses  previously
              allocated place as much as possible.

          -- ALGLIB --
             Copyright 30.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void linlsqrcreate(int m,
            int n,
            linlsqrstate state,
            alglib.xparams _params)
        {
            alglib.ap.assert(m>0, "LinLSQRCreate: M<=0");
            alglib.ap.assert(n>0, "LinLSQRCreate: N<=0");
            linlsqrcreatebuf(m, n, state, _params);
        }


        /*************************************************************************
        This function initializes linear LSQR Solver.  It  provides  exactly  same
        functionality as linlsqrcreate(), but reuses  previously  allocated  space
        as much as possible.
          
        INPUT PARAMETERS:
            M       -   number of rows in A
            N       -   number of variables, N>0

        OUTPUT PARAMETERS:
            State   -   structure which stores algorithm state

          -- ALGLIB --
             Copyright 14.11.2018 by Bochkanov Sergey
        *************************************************************************/
        public static void linlsqrcreatebuf(int m,
            int n,
            linlsqrstate state,
            alglib.xparams _params)
        {
            int i = 0;

            alglib.ap.assert(m>0, "LinLSQRCreateBuf: M<=0");
            alglib.ap.assert(n>0, "LinLSQRCreateBuf: N<=0");
            state.m = m;
            state.n = n;
            state.prectype = 0;
            state.epsa = atol;
            state.epsb = btol;
            state.epsc = 1/Math.Sqrt(math.machineepsilon);
            state.maxits = 0;
            state.lambdai = 0;
            state.xrep = false;
            state.running = false;
            state.repiterationscount = 0;
            
            //
            // * allocate arrays
            // * set RX to NAN (just for the case user calls Results() without 
            //   calling SolveSparse()
            // * set B to zero
            //
            normestimator.normestimatorcreate(m, n, 2, 2, state.nes, _params);
            state.rx = new double[state.n];
            state.ui = new double[state.m+state.n];
            state.uip1 = new double[state.m+state.n];
            state.vip1 = new double[state.n];
            state.vi = new double[state.n];
            state.omegai = new double[state.n];
            state.omegaip1 = new double[state.n];
            state.d = new double[state.n];
            state.x = new double[state.m+state.n];
            state.mv = new double[state.m+state.n];
            state.mtv = new double[state.n];
            state.b = new double[state.m];
            for(i=0; i<=n-1; i++)
            {
                state.rx[i] = Double.NaN;
            }
            for(i=0; i<=m-1; i++)
            {
                state.b[i] = 0;
            }
            state.rstate.ia = new int[1+1];
            state.rstate.ra = new double[0+1];
            state.rstate.stage = -1;
        }


        /*************************************************************************
        This function sets right part. By default, right part is zero.

        INPUT PARAMETERS:
            B       -   right part, array[N].

        OUTPUT PARAMETERS:
            State   -   structure which stores algorithm state

          -- ALGLIB --
             Copyright 30.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void linlsqrsetb(linlsqrstate state,
            double[] b,
            alglib.xparams _params)
        {
            int i = 0;

            alglib.ap.assert(!state.running, "LinLSQRSetB: you can not change B when LinLSQRIteration is running");
            alglib.ap.assert(state.m<=alglib.ap.len(b), "LinLSQRSetB: Length(B)<M");
            alglib.ap.assert(apserv.isfinitevector(b, state.m, _params), "LinLSQRSetB: B contains infinite or NaN values");
            state.bnorm2 = 0;
            for(i=0; i<=state.m-1; i++)
            {
                state.b[i] = b[i];
                state.bnorm2 = state.bnorm2+b[i]*b[i];
            }
        }


        /*************************************************************************
        This  function  changes  preconditioning  settings of LinLSQQSolveSparse()
        function. By default, SolveSparse() uses diagonal preconditioner,  but  if
        you want to use solver without preconditioning, you can call this function
        which forces solver to use unit matrix for preconditioning.

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state

          -- ALGLIB --
             Copyright 19.11.2012 by Bochkanov Sergey
        *************************************************************************/
        public static void linlsqrsetprecunit(linlsqrstate state,
            alglib.xparams _params)
        {
            alglib.ap.assert(!state.running, "LinLSQRSetPrecUnit: you can not change preconditioner, because function LinLSQRIteration is running!");
            state.prectype = -1;
        }


        /*************************************************************************
        This  function  changes  preconditioning  settings  of  LinCGSolveSparse()
        function.  LinCGSolveSparse() will use diagonal of the  system  matrix  as
        preconditioner. This preconditioning mode is active by default.

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state

          -- ALGLIB --
             Copyright 19.11.2012 by Bochkanov Sergey
        *************************************************************************/
        public static void linlsqrsetprecdiag(linlsqrstate state,
            alglib.xparams _params)
        {
            alglib.ap.assert(!state.running, "LinLSQRSetPrecDiag: you can not change preconditioner, because function LinCGIteration is running!");
            state.prectype = 0;
        }


        /*************************************************************************
        This function sets optional Tikhonov regularization coefficient.
        It is zero by default.

        INPUT PARAMETERS:
            LambdaI -   regularization factor, LambdaI>=0

        OUTPUT PARAMETERS:
            State   -   structure which stores algorithm state
            
          -- ALGLIB --
             Copyright 30.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void linlsqrsetlambdai(linlsqrstate state,
            double lambdai,
            alglib.xparams _params)
        {
            alglib.ap.assert(!state.running, "LinLSQRSetLambdaI: you can not set LambdaI, because function LinLSQRIteration is running");
            alglib.ap.assert(math.isfinite(lambdai) && (double)(lambdai)>=(double)(0), "LinLSQRSetLambdaI: LambdaI is infinite or NaN");
            state.lambdai = lambdai;
        }


        /*************************************************************************

          -- ALGLIB --
             Copyright 30.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static bool linlsqriteration(linlsqrstate state,
            alglib.xparams _params)
        {
            bool result = new bool();
            int summn = 0;
            double bnorm = 0;
            int i = 0;
            int i_ = 0;

            
            //
            // Reverse communication preparations
            // I know it looks ugly, but it works the same way
            // anywhere from C++ to Python.
            //
            // This code initializes locals by:
            // * random values determined during code
            //   generation - on first subroutine call
            // * values from previous call - on subsequent calls
            //
            if( state.rstate.stage>=0 )
            {
                summn = state.rstate.ia[0];
                i = state.rstate.ia[1];
                bnorm = state.rstate.ra[0];
            }
            else
            {
                summn = 359;
                i = -58;
                bnorm = -919.0;
            }
            if( state.rstate.stage==0 )
            {
                goto lbl_0;
            }
            if( state.rstate.stage==1 )
            {
                goto lbl_1;
            }
            if( state.rstate.stage==2 )
            {
                goto lbl_2;
            }
            if( state.rstate.stage==3 )
            {
                goto lbl_3;
            }
            if( state.rstate.stage==4 )
            {
                goto lbl_4;
            }
            if( state.rstate.stage==5 )
            {
                goto lbl_5;
            }
            if( state.rstate.stage==6 )
            {
                goto lbl_6;
            }
            
            //
            // Routine body
            //
            alglib.ap.assert(alglib.ap.len(state.b)>0, "LinLSQRIteration: using non-allocated array B");
            summn = state.m+state.n;
            bnorm = Math.Sqrt(state.bnorm2);
            state.userterminationneeded = false;
            state.running = true;
            state.repnmv = 0;
            state.repiterationscount = 0;
            state.r2 = state.bnorm2;
            clearrfields(state, _params);
            
            //
            //estimate for ANorm
            //
            normestimator.normestimatorrestart(state.nes, _params);
        lbl_7:
            if( !normestimator.normestimatoriteration(state.nes, _params) )
            {
                goto lbl_8;
            }
            if( !state.nes.needmv )
            {
                goto lbl_9;
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = state.nes.x[i_];
            }
            state.repnmv = state.repnmv+1;
            clearrfields(state, _params);
            state.needmv = true;
            state.rstate.stage = 0;
            goto lbl_rcomm;
        lbl_0:
            state.needmv = false;
            for(i_=0; i_<=state.m-1;i_++)
            {
                state.nes.mv[i_] = state.mv[i_];
            }
            goto lbl_7;
        lbl_9:
            if( !state.nes.needmtv )
            {
                goto lbl_11;
            }
            for(i_=0; i_<=state.m-1;i_++)
            {
                state.x[i_] = state.nes.x[i_];
            }
            
            //
            //matrix-vector multiplication
            //
            state.repnmv = state.repnmv+1;
            clearrfields(state, _params);
            state.needmtv = true;
            state.rstate.stage = 1;
            goto lbl_rcomm;
        lbl_1:
            state.needmtv = false;
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.nes.mtv[i_] = state.mtv[i_];
            }
            goto lbl_7;
        lbl_11:
            goto lbl_7;
        lbl_8:
            normestimator.normestimatorresults(state.nes, ref state.anorm, _params);
            
            //
            //initialize .RX by zeros
            //
            for(i=0; i<=state.n-1; i++)
            {
                state.rx[i] = 0;
            }
            
            //
            //output first report
            //
            if( !state.xrep )
            {
                goto lbl_13;
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = state.rx[i_];
            }
            clearrfields(state, _params);
            state.xupdated = true;
            state.rstate.stage = 2;
            goto lbl_rcomm;
        lbl_2:
            state.xupdated = false;
        lbl_13:
            
            //
            // LSQR, Step 0.
            //
            // Algorithm outline corresponds to one which was described at p.50 of
            // "LSQR - an algorithm for sparse linear equations and sparse least 
            // squares" by C.Paige and M.Saunders with one small addition - we
            // explicitly extend system matrix by additional N lines in order 
            // to handle non-zero lambda, i.e. original A is replaced by
            //         [ A        ]
            // A_mod = [          ]
            //         [ lambda*I ].
            //
            // Step 0:
            //     x[0]          = 0
            //     beta[1]*u[1]  = b
            //     alpha[1]*v[1] = A_mod'*u[1]
            //     w[1]          = v[1]
            //     phiBar[1]     = beta[1]
            //     rhoBar[1]     = alpha[1]
            //     d[0]          = 0
            //
            // NOTE:
            // There are three criteria for stopping:
            // (S0) maximum number of iterations
            // (S1) ||Rk||<=EpsB*||B||;
            // (S2) ||A^T*Rk||/(||A||*||Rk||)<=EpsA.
            // It is very important that S2 always checked AFTER S1. It is necessary
            // to avoid division by zero when Rk=0.
            //
            state.betai = bnorm;
            if( (double)(state.betai)==(double)(0) )
            {
                
                //
                // Zero right part
                //
                state.running = false;
                state.repterminationtype = 1;
                result = false;
                return result;
            }
            for(i=0; i<=summn-1; i++)
            {
                if( i<state.m )
                {
                    state.ui[i] = state.b[i]/state.betai;
                }
                else
                {
                    state.ui[i] = 0;
                }
                state.x[i] = state.ui[i];
            }
            state.repnmv = state.repnmv+1;
            clearrfields(state, _params);
            state.needmtv = true;
            state.rstate.stage = 3;
            goto lbl_rcomm;
        lbl_3:
            state.needmtv = false;
            for(i=0; i<=state.n-1; i++)
            {
                state.mtv[i] = state.mtv[i]+state.lambdai*state.ui[state.m+i];
            }
            state.alphai = 0;
            for(i=0; i<=state.n-1; i++)
            {
                state.alphai = state.alphai+state.mtv[i]*state.mtv[i];
            }
            state.alphai = Math.Sqrt(state.alphai);
            if( (double)(state.alphai)==(double)(0) )
            {
                
                //
                // Orthogonality stopping criterion is met
                //
                state.running = false;
                state.repterminationtype = 4;
                result = false;
                return result;
            }
            for(i=0; i<=state.n-1; i++)
            {
                state.vi[i] = state.mtv[i]/state.alphai;
                state.omegai[i] = state.vi[i];
            }
            state.phibari = state.betai;
            state.rhobari = state.alphai;
            for(i=0; i<=state.n-1; i++)
            {
                state.d[i] = 0;
            }
            state.dnorm = 0;
            
            //
            // Steps I=1, 2, ...
            //
        lbl_15:
            if( false )
            {
                goto lbl_16;
            }
            
            //
            // At I-th step State.RepIterationsCount=I.
            //
            state.repiterationscount = state.repiterationscount+1;
            
            //
            // Bidiagonalization part:
            //     beta[i+1]*u[i+1]  = A_mod*v[i]-alpha[i]*u[i]
            //     alpha[i+1]*v[i+1] = A_mod'*u[i+1] - beta[i+1]*v[i]
            //     
            // NOTE:  beta[i+1]=0 or alpha[i+1]=0 will lead to successful termination
            //        in the end of the current iteration. In this case u/v are zero.
            // NOTE2: algorithm won't fail on zero alpha or beta (there will be no
            //        division by zero because it will be stopped BEFORE division
            //        occurs). However, near-zero alpha and beta won't stop algorithm
            //        and, although no division by zero will happen, orthogonality 
            //        in U and V will be lost.
            //
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = state.vi[i_];
            }
            state.repnmv = state.repnmv+1;
            clearrfields(state, _params);
            state.needmv = true;
            state.rstate.stage = 4;
            goto lbl_rcomm;
        lbl_4:
            state.needmv = false;
            for(i=0; i<=state.n-1; i++)
            {
                state.mv[state.m+i] = state.lambdai*state.vi[i];
            }
            state.betaip1 = 0;
            for(i=0; i<=summn-1; i++)
            {
                state.uip1[i] = state.mv[i]-state.alphai*state.ui[i];
                state.betaip1 = state.betaip1+state.uip1[i]*state.uip1[i];
            }
            if( (double)(state.betaip1)!=(double)(0) )
            {
                state.betaip1 = Math.Sqrt(state.betaip1);
                for(i=0; i<=summn-1; i++)
                {
                    state.uip1[i] = state.uip1[i]/state.betaip1;
                }
            }
            for(i_=0; i_<=state.m-1;i_++)
            {
                state.x[i_] = state.uip1[i_];
            }
            state.repnmv = state.repnmv+1;
            clearrfields(state, _params);
            state.needmtv = true;
            state.rstate.stage = 5;
            goto lbl_rcomm;
        lbl_5:
            state.needmtv = false;
            for(i=0; i<=state.n-1; i++)
            {
                state.mtv[i] = state.mtv[i]+state.lambdai*state.uip1[state.m+i];
            }
            state.alphaip1 = 0;
            for(i=0; i<=state.n-1; i++)
            {
                state.vip1[i] = state.mtv[i]-state.betaip1*state.vi[i];
                state.alphaip1 = state.alphaip1+state.vip1[i]*state.vip1[i];
            }
            if( (double)(state.alphaip1)!=(double)(0) )
            {
                state.alphaip1 = Math.Sqrt(state.alphaip1);
                for(i=0; i<=state.n-1; i++)
                {
                    state.vip1[i] = state.vip1[i]/state.alphaip1;
                }
            }
            
            //
            // Build next orthogonal transformation
            //
            state.rhoi = apserv.safepythag2(state.rhobari, state.betaip1, _params);
            state.ci = state.rhobari/state.rhoi;
            state.si = state.betaip1/state.rhoi;
            state.theta = state.si*state.alphaip1;
            state.rhobarip1 = -(state.ci*state.alphaip1);
            state.phii = state.ci*state.phibari;
            state.phibarip1 = state.si*state.phibari;
            
            //
            // Update .RNorm
            //
            // This tricky  formula  is  necessary  because  simply  writing
            // State.R2:=State.PhiBarIP1*State.PhiBarIP1 does NOT guarantees
            // monotonic decrease of R2. Roundoff error combined with 80-bit
            // precision used internally by Intel chips allows R2 to increase
            // slightly in some rare, but possible cases. This property is
            // undesirable, so we prefer to guard against R increase.
            //
            state.r2 = Math.Min(state.r2, state.phibarip1*state.phibarip1);
            
            //
            // Update d and DNorm, check condition-related stopping criteria
            //
            for(i=0; i<=state.n-1; i++)
            {
                state.d[i] = 1/state.rhoi*(state.vi[i]-state.theta*state.d[i]);
                state.dnorm = state.dnorm+state.d[i]*state.d[i];
            }
            if( (double)(Math.Sqrt(state.dnorm)*state.anorm)>=(double)(state.epsc) )
            {
                state.running = false;
                state.repterminationtype = 7;
                result = false;
                return result;
            }
            
            //
            // Update x, output report
            //
            for(i=0; i<=state.n-1; i++)
            {
                state.rx[i] = state.rx[i]+state.phii/state.rhoi*state.omegai[i];
            }
            if( !state.xrep )
            {
                goto lbl_17;
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = state.rx[i_];
            }
            clearrfields(state, _params);
            state.xupdated = true;
            state.rstate.stage = 6;
            goto lbl_rcomm;
        lbl_6:
            state.xupdated = false;
        lbl_17:
            
            //
            // Check stopping criteria
            // 1. achieved required number of iterations;
            // 2. ||Rk||<=EpsB*||B||;
            // 3. ||A^T*Rk||/(||A||*||Rk||)<=EpsA;
            //
            if( state.maxits>0 && state.repiterationscount>=state.maxits )
            {
                
                //
                // Achieved required number of iterations
                //
                state.running = false;
                state.repterminationtype = 5;
                result = false;
                return result;
            }
            if( (double)(state.phibarip1)<=(double)(state.epsb*bnorm) )
            {
                
                //
                // ||Rk||<=EpsB*||B||, here ||Rk||=PhiBar
                //
                state.running = false;
                state.repterminationtype = 1;
                result = false;
                return result;
            }
            if( (double)(state.alphaip1*Math.Abs(state.ci)/state.anorm)<=(double)(state.epsa) )
            {
                
                //
                // ||A^T*Rk||/(||A||*||Rk||)<=EpsA, here ||A^T*Rk||=PhiBar*Alpha[i+1]*|.C|
                //
                state.running = false;
                state.repterminationtype = 4;
                result = false;
                return result;
            }
            if( state.userterminationneeded )
            {
                
                //
                // User requested termination
                //
                state.running = false;
                state.repterminationtype = 8;
                result = false;
                return result;
            }
            
            //
            // Update omega
            //
            for(i=0; i<=state.n-1; i++)
            {
                state.omegaip1[i] = state.vip1[i]-state.theta/state.rhoi*state.omegai[i];
            }
            
            //
            // Prepare for the next iteration - rename variables:
            // u[i]   := u[i+1]
            // v[i]   := v[i+1]
            // rho[i] := rho[i+1]
            // ...
            //
            for(i_=0; i_<=summn-1;i_++)
            {
                state.ui[i_] = state.uip1[i_];
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.vi[i_] = state.vip1[i_];
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.omegai[i_] = state.omegaip1[i_];
            }
            state.alphai = state.alphaip1;
            state.betai = state.betaip1;
            state.phibari = state.phibarip1;
            state.rhobari = state.rhobarip1;
            goto lbl_15;
        lbl_16:
            result = false;
            return result;
            
            //
            // Saving state
            //
        lbl_rcomm:
            result = true;
            state.rstate.ia[0] = summn;
            state.rstate.ia[1] = i;
            state.rstate.ra[0] = bnorm;
            return result;
        }


        /*************************************************************************
        Procedure for solution of A*x=b with sparse A.

        INPUT PARAMETERS:
            State   -   algorithm state
            A       -   sparse M*N matrix in the CRS format (you MUST contvert  it 
                        to CRS format  by  calling  SparseConvertToCRS()  function
                        BEFORE you pass it to this function).
            B       -   right part, array[M]

        RESULT:
            This function returns no result.
            You can get solution by calling LinCGResults()
            
        NOTE: this function uses lightweight preconditioning -  multiplication  by
              inverse of diag(A). If you want, you can turn preconditioning off by
              calling LinLSQRSetPrecUnit(). However, preconditioning cost is   low
              and preconditioner is very important for solution  of  badly  scaled
              problems.

          -- ALGLIB --
             Copyright 30.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void linlsqrsolvesparse(linlsqrstate state,
            sparse.sparsematrix a,
            double[] b,
            alglib.xparams _params)
        {
            int n = 0;
            int i = 0;
            int j = 0;
            int t0 = 0;
            int t1 = 0;
            double v = 0;

            n = state.n;
            alglib.ap.assert(!state.running, "LinLSQRSolveSparse: you can not call this function when LinLSQRIteration is running");
            alglib.ap.assert(alglib.ap.len(b)>=state.m, "LinLSQRSolveSparse: Length(B)<M");
            alglib.ap.assert(apserv.isfinitevector(b, state.m, _params), "LinLSQRSolveSparse: B contains infinite or NaN values");
            
            //
            // Allocate temporaries
            //
            apserv.rvectorsetlengthatleast(ref state.tmpd, n, _params);
            apserv.rvectorsetlengthatleast(ref state.tmpx, n, _params);
            
            //
            // Compute diagonal scaling matrix D
            //
            if( state.prectype==0 )
            {
                
                //
                // Default preconditioner - inverse of column norms
                //
                for(i=0; i<=n-1; i++)
                {
                    state.tmpd[i] = 0;
                }
                t0 = 0;
                t1 = 0;
                while( sparse.sparseenumerate(a, ref t0, ref t1, ref i, ref j, ref v, _params) )
                {
                    state.tmpd[j] = state.tmpd[j]+math.sqr(v);
                }
                for(i=0; i<=n-1; i++)
                {
                    if( (double)(state.tmpd[i])>(double)(0) )
                    {
                        state.tmpd[i] = 1/Math.Sqrt(state.tmpd[i]);
                    }
                    else
                    {
                        state.tmpd[i] = 1;
                    }
                }
            }
            else
            {
                
                //
                // No diagonal scaling
                //
                for(i=0; i<=n-1; i++)
                {
                    state.tmpd[i] = 1;
                }
            }
            
            //
            // Solve.
            //
            // Instead of solving A*x=b we solve preconditioned system (A*D)*(inv(D)*x)=b.
            // Transformed A is not calculated explicitly, we just modify multiplication
            // by A or A'. After solution we modify State.RX so it will store untransformed
            // variables
            //
            linlsqrsetb(state, b, _params);
            linlsqrrestart(state, _params);
            while( linlsqriteration(state, _params) )
            {
                if( state.needmv )
                {
                    for(i=0; i<=n-1; i++)
                    {
                        state.tmpx[i] = state.tmpd[i]*state.x[i];
                    }
                    sparse.sparsemv(a, state.tmpx, ref state.mv, _params);
                }
                if( state.needmtv )
                {
                    sparse.sparsemtv(a, state.x, ref state.mtv, _params);
                    for(i=0; i<=n-1; i++)
                    {
                        state.mtv[i] = state.tmpd[i]*state.mtv[i];
                    }
                }
            }
            for(i=0; i<=n-1; i++)
            {
                state.rx[i] = state.tmpd[i]*state.rx[i];
            }
        }


        /*************************************************************************
        This function sets stopping criteria.

        INPUT PARAMETERS:
            EpsA    -   algorithm will be stopped if ||A^T*Rk||/(||A||*||Rk||)<=EpsA.
            EpsB    -   algorithm will be stopped if ||Rk||<=EpsB*||B||
            MaxIts  -   algorithm will be stopped if number of iterations
                        more than MaxIts.

        OUTPUT PARAMETERS:
            State   -   structure which stores algorithm state

        NOTE: if EpsA,EpsB,EpsC and MaxIts are zero then these variables will
        be setted as default values.
            
          -- ALGLIB --
             Copyright 30.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void linlsqrsetcond(linlsqrstate state,
            double epsa,
            double epsb,
            int maxits,
            alglib.xparams _params)
        {
            alglib.ap.assert(!state.running, "LinLSQRSetCond: you can not call this function when LinLSQRIteration is running");
            alglib.ap.assert(math.isfinite(epsa) && (double)(epsa)>=(double)(0), "LinLSQRSetCond: EpsA is negative, INF or NAN");
            alglib.ap.assert(math.isfinite(epsb) && (double)(epsb)>=(double)(0), "LinLSQRSetCond: EpsB is negative, INF or NAN");
            alglib.ap.assert(maxits>=0, "LinLSQRSetCond: MaxIts is negative");
            if( ((double)(epsa)==(double)(0) && (double)(epsb)==(double)(0)) && maxits==0 )
            {
                state.epsa = atol;
                state.epsb = btol;
                state.maxits = state.n;
            }
            else
            {
                state.epsa = epsa;
                state.epsb = epsb;
                state.maxits = maxits;
            }
        }


        /*************************************************************************
        LSQR solver: results.

        This function must be called after LinLSQRSolve

        INPUT PARAMETERS:
            State   -   algorithm state

        OUTPUT PARAMETERS:
            X       -   array[N], solution
            Rep     -   optimization report:
                        * Rep.TerminationType completetion code:
                            *  1    ||Rk||<=EpsB*||B||
                            *  4    ||A^T*Rk||/(||A||*||Rk||)<=EpsA
                            *  5    MaxIts steps was taken
                            *  7    rounding errors prevent further progress,
                                    X contains best point found so far.
                                    (sometimes returned on singular systems)
                            *  8    user requested termination via calling
                                    linlsqrrequesttermination()
                        * Rep.IterationsCount contains iterations count
                        * NMV countains number of matrix-vector calculations
                        
          -- ALGLIB --
             Copyright 30.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void linlsqrresults(linlsqrstate state,
            ref double[] x,
            linlsqrreport rep,
            alglib.xparams _params)
        {
            int i_ = 0;

            x = new double[0];

            alglib.ap.assert(!state.running, "LinLSQRResult: you can not call this function when LinLSQRIteration is running");
            if( alglib.ap.len(x)<state.n )
            {
                x = new double[state.n];
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                x[i_] = state.rx[i_];
            }
            rep.iterationscount = state.repiterationscount;
            rep.nmv = state.repnmv;
            rep.terminationtype = state.repterminationtype;
        }


        /*************************************************************************
        This function turns on/off reporting.

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state
            NeedXRep-   whether iteration reports are needed or not

        If NeedXRep is True, algorithm will call rep() callback function if  it is
        provided to MinCGOptimize().

          -- ALGLIB --
             Copyright 30.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void linlsqrsetxrep(linlsqrstate state,
            bool needxrep,
            alglib.xparams _params)
        {
            state.xrep = needxrep;
        }


        /*************************************************************************
        This function restarts LinLSQRIteration

          -- ALGLIB --
             Copyright 30.11.2011 by Bochkanov Sergey
        *************************************************************************/
        public static void linlsqrrestart(linlsqrstate state,
            alglib.xparams _params)
        {
            state.rstate.ia = new int[1+1];
            state.rstate.ra = new double[0+1];
            state.rstate.stage = -1;
            clearrfields(state, _params);
            state.repiterationscount = 0;
        }


        /*************************************************************************
        This function is used to peek into LSQR solver and get  current  iteration
        counter. You can safely "peek" into the solver from another thread.

        INPUT PARAMETERS:
            S           -   solver object

        RESULT:
            iteration counter, in [0,INF)

          -- ALGLIB --
             Copyright 21.05.2018 by Bochkanov Sergey
        *************************************************************************/
        public static int linlsqrpeekiterationscount(linlsqrstate s,
            alglib.xparams _params)
        {
            int result = 0;

            result = s.repiterationscount;
            return result;
        }


        /*************************************************************************
        This subroutine submits request for termination of the running solver.  It
        can be called from some other thread which wants LSQR solver to  terminate
        (obviously, the  thread  running  LSQR  solver can not request termination
        because it is already busy working on LSQR).

        As result, solver  stops  at  point  which  was  "current  accepted"  when
        termination  request  was  submitted  and returns error code 8 (successful
        termination).  Such   termination   is  a smooth  process  which  properly
        deallocates all temporaries.

        INPUT PARAMETERS:
            State   -   solver structure

        NOTE: calling this function on solver which is NOT running  will  have  no
              effect.
              
        NOTE: multiple calls to this function are possible. First call is counted,
              subsequent calls are silently ignored.

        NOTE: solver clears termination flag on its start, it means that  if  some
              other thread will request termination too soon, its request will went
              unnoticed.

          -- ALGLIB --
             Copyright 08.10.2014 by Bochkanov Sergey
        *************************************************************************/
        public static void linlsqrrequesttermination(linlsqrstate state,
            alglib.xparams _params)
        {
            state.userterminationneeded = true;
        }


        /*************************************************************************
        Clears request fileds (to be sure that we don't forgot to clear something)
        *************************************************************************/
        private static void clearrfields(linlsqrstate state,
            alglib.xparams _params)
        {
            state.xupdated = false;
            state.needmv = false;
            state.needmtv = false;
            state.needmv2 = false;
            state.needvmv = false;
            state.needprec = false;
        }


    }
    public class directsparsesolvers
    {
        /*************************************************************************
        Sparse linear solver for A*x=b with N*N  sparse  real  symmetric  positive
        definite matrix A, N*1 vectors x and b.

        This solver  converts  input  matrix  to  SKS  format,  performs  Cholesky
        factorization using  SKS  Cholesky  subroutine  (works  well  for  limited
        bandwidth matrices) and uses sparse triangular solvers to get solution  of
        the original system.

        IMPORTANT: this  function  is  intended  for  low  profile (variable band)
                   linear systems with dense or nearly-dense bands. Only  in  such
                   cases  it  provides  some  performance  improvement  over  more
                   general sparsrspdsolve(). If your  system  has  high  bandwidth
                   or sparse band, the general sparsrspdsolve() is  likely  to  be
                   more efficient.

        INPUT PARAMETERS
            A       -   sparse matrix, must be NxN exactly
            IsUpper -   which half of A is provided (another half is ignored)
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            X       -   array[N], it contains:
                        * rep.terminationtype>0    =>  solution
                        * rep.terminationtype=-3   =>  filled by zeros
            Rep     -   solver report, following fields are set:
                        * rep.terminationtype - solver status; >0 for success,
                          set to -3 on failure (degenerate or non-SPD system).

          -- ALGLIB --
             Copyright 26.12.2017 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsespdsolvesks(sparse.sparsematrix a,
            bool isupper,
            double[] b,
            ref double[] x,
            iterativesparse.sparsesolverreport rep,
            alglib.xparams _params)
        {
            int i = 0;
            sparse.sparsematrix a2 = new sparse.sparsematrix();
            int n = 0;

            x = new double[0];

            n = sparse.sparsegetnrows(a, _params);
            alglib.ap.assert(n>0, "SparseSPDSolveSKS: N<=0");
            alglib.ap.assert(sparse.sparsegetnrows(a, _params)==n, "SparseSPDSolveSKS: rows(A)!=N");
            alglib.ap.assert(sparse.sparsegetncols(a, _params)==n, "SparseSPDSolveSKS: cols(A)!=N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SparseSPDSolveSKS: length(B)<N");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SparseSPDSolveSKS: B contains infinities or NANs");
            iterativesparse.initsparsesolverreport(rep, _params);
            x = new double[n];
            sparse.sparsecopytosks(a, a2, _params);
            if( !trfac.sparsecholeskyskyline(a2, n, isupper, _params) )
            {
                rep.terminationtype = -3;
                for(i=0; i<=n-1; i++)
                {
                    x[i] = 0;
                }
                return;
            }
            for(i=0; i<=n-1; i++)
            {
                x[i] = b[i];
            }
            if( isupper )
            {
                sparse.sparsetrsv(a2, isupper, false, 1, x, _params);
                sparse.sparsetrsv(a2, isupper, false, 0, x, _params);
            }
            else
            {
                sparse.sparsetrsv(a2, isupper, false, 0, x, _params);
                sparse.sparsetrsv(a2, isupper, false, 1, x, _params);
            }
            rep.terminationtype = 1;
        }


        /*************************************************************************
        Sparse linear solver for A*x=b with N*N  sparse  real  symmetric  positive
        definite matrix A, N*1 vectors x and b.

        This solver  converts  input  matrix  to  CRS  format,  performs  Cholesky
        factorization using supernodal Cholesky  decomposition  with  permutation-
        reducing ordering and uses sparse triangular solver to get solution of the
        original system.

        INPUT PARAMETERS
            A       -   sparse matrix, must be NxN exactly.
                        Can be stored in any sparse storage format, CRS is preferred.
            IsUpper -   which half of A is provided (another half is ignored).
                        It is better to store the lower triangle because it allows
                        us to avoid one transposition during internal conversion.
            B       -   array[N], right part

        OUTPUT PARAMETERS
            X       -   array[N], it contains:
                        * rep.terminationtype>0    =>  solution
                        * rep.terminationtype=-3   =>  filled by zeros
            Rep     -   solver report, following fields are set:
                        * rep.terminationtype - solver status; >0 for success,
                          set to -3 on failure (degenerate or non-SPD system).

          -- ALGLIB --
             Copyright 26.12.2017 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsespdsolve(sparse.sparsematrix a,
            bool isupper,
            double[] b,
            ref double[] x,
            iterativesparse.sparsesolverreport rep,
            alglib.xparams _params)
        {
            sparse.sparsematrix a2 = new sparse.sparsematrix();
            sparse.sparsematrix a3 = new sparse.sparsematrix();
            int n = 0;
            int[] p = new int[0];
            int[] idummy = new int[0];
            int donotreusemem = 0;
            spchol.spcholanalysis analysis = new spchol.spcholanalysis();
            bool flg = new bool();

            x = new double[0];

            n = sparse.sparsegetnrows(a, _params);
            alglib.ap.assert(n>0, "SparseSPDSolve: N<=0");
            alglib.ap.assert(sparse.sparsegetnrows(a, _params)==n, "SparseSPDSolve: rows(A)!=N");
            alglib.ap.assert(sparse.sparsegetncols(a, _params)==n, "SparseSPDSolve: cols(A)!=N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SparseSPDSolve: length(B)<N");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SparseSPDSolve: B contains infinities or NANs");
            iterativesparse.initsparsesolverreport(rep, _params);
            
            //
            // Perform factorization, depending on the sparse storage format and triangle being specified
            //
            donotreusemem = -1;
            if( !sparse.sparseiscrs(a, _params) )
            {
                
                //
                // Non-CRS matrix, first has to be converted to CRS, then a transposition may be needed
                //
                sparse.sparsecopytocrs(a, a2, _params);
                if( isupper )
                {
                    sparse.sparsecopytransposecrs(a2, a3, _params);
                    flg = spchol.spsymmanalyze(a3, idummy, 0.0, 0, 0, 0, donotreusemem, analysis, _params);
                }
                else
                {
                    flg = spchol.spsymmanalyze(a2, idummy, 0.0, 0, 0, 0, donotreusemem, analysis, _params);
                }
            }
            else
            {
                
                //
                // A CRS matrix
                //
                if( isupper )
                {
                    sparse.sparsecopytransposecrs(a, a2, _params);
                    flg = spchol.spsymmanalyze(a2, idummy, 0.0, 0, 0, 0, donotreusemem, analysis, _params);
                }
                else
                {
                    flg = spchol.spsymmanalyze(a, idummy, 0.0, 0, 0, 0, donotreusemem, analysis, _params);
                }
            }
            if( !flg )
            {
                rep.terminationtype = -3;
                ablasf.rsetallocv(n, 0.0, ref x, _params);
                return;
            }
            
            //
            // Factorize
            //
            if( !spchol.spsymmfactorize(analysis, _params) )
            {
                rep.terminationtype = -3;
                ablasf.rsetallocv(n, 0.0, ref x, _params);
                return;
            }
            
            //
            // Solve
            //
            ablasf.rcopyallocv(n, b, ref x, _params);
            spchol.spsymmsolve(analysis, x, _params);
            rep.terminationtype = 1;
        }


        /*************************************************************************
        Sparse linear solver for A*x=b with N*N real  symmetric  positive definite
        matrix A given by its Cholesky decomposition, and N*1 vectors x and b.

        IMPORTANT: this solver requires input matrix to be in  the  SKS  (Skyline)
                   or CRS (compressed row storage) format. An  exception  will  be
                   generated if you pass matrix in some other format.

        INPUT PARAMETERS
            A       -   sparse NxN matrix stored in CRs or SKS format, must be NxN
                        exactly
            IsUpper -   which half of A is provided (another half is ignored)
            B       -   array[N], right part

        OUTPUT PARAMETERS
            X       -   array[N], it contains:
                        * rep.terminationtype>0    =>  solution
                        * rep.terminationtype=-3   =>  filled by zeros
            Rep     -   solver report, following fields are set:
                        * rep.terminationtype - solver status; >0 for success,
                          set to -3 on failure (degenerate or non-SPD system).

          -- ALGLIB --
             Copyright 26.12.2017 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsespdcholeskysolve(sparse.sparsematrix a,
            bool isupper,
            double[] b,
            ref double[] x,
            iterativesparse.sparsesolverreport rep,
            alglib.xparams _params)
        {
            int i = 0;
            int n = 0;

            x = new double[0];

            n = sparse.sparsegetnrows(a, _params);
            alglib.ap.assert(n>0, "SparseSPDCholeskySolve: N<=0");
            alglib.ap.assert(sparse.sparsegetnrows(a, _params)==n, "SparseSPDCholeskySolve: rows(A)!=N");
            alglib.ap.assert(sparse.sparsegetncols(a, _params)==n, "SparseSPDCholeskySolve: cols(A)!=N");
            alglib.ap.assert(sparse.sparseissks(a, _params) || sparse.sparseiscrs(a, _params), "SparseSPDCholeskySolve: A is not an SKS/CRS matrix");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SparseSPDCholeskySolve: length(B)<N");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SparseSPDCholeskySolve: B contains infinities or NANs");
            iterativesparse.initsparsesolverreport(rep, _params);
            x = new double[n];
            for(i=0; i<=n-1; i++)
            {
                if( (double)(sparse.sparseget(a, i, i, _params))==(double)(0.0) )
                {
                    rep.terminationtype = -3;
                    for(i=0; i<=n-1; i++)
                    {
                        x[i] = 0;
                    }
                    return;
                }
            }
            for(i=0; i<=n-1; i++)
            {
                x[i] = b[i];
            }
            if( isupper )
            {
                sparse.sparsetrsv(a, isupper, false, 1, x, _params);
                sparse.sparsetrsv(a, isupper, false, 0, x, _params);
            }
            else
            {
                sparse.sparsetrsv(a, isupper, false, 0, x, _params);
                sparse.sparsetrsv(a, isupper, false, 1, x, _params);
            }
            rep.terminationtype = 1;
        }


        /*************************************************************************
        Sparse linear solver for A*x=b with general (nonsymmetric) N*N sparse real
        matrix A, N*1 vectors x and b.

        This function internally uses several solvers:
        * supernodal solver with static pivoting applied to  a  2N*2N  regularized
          augmented  system, followed by iterative refinement. This solver  is   a
          recommended option because it provides the best speed and has the lowest
          memory requirements.
        * sparse LU with dynamic pivoting for stability. Provides better  accuracy
          at the cost of a significantly lower performance. Recommended  only  for
          extremely unstable problems.

        INPUT PARAMETERS
            A       -   sparse matrix, must be NxN exactly, any storage format
            B       -   array[N], right part
            SolverType- solver type to use:
                        * 0     use the best solver. It is augmented system in the
                                current version, but may change in future releases
                        * 10    use 'default profile' of the supernodal solver with
                                static   pivoting.   The  'default'   profile   is
                                intended for systems with plenty of memory; it  is
                                optimized for the best convergence at the cost  of
                                increased RAM usage. Recommended option.
                        * 11    use 'limited memory'  profile  of  the  supernodal
                                solver with static  pivoting.  The  limited-memory
                                profile is intended for problems with millions  of
                                variables.  On  most  systems  it  has  the   same
                                convergence as the default profile, having somewhat
                                worse results only for ill-conditioned systems.
                        * 20    use sparse LU with dynamic pivoting for stability.
                                Not intended for large-scale problems.

        OUTPUT PARAMETERS
            X       -   array[N], it contains:
                        * rep.terminationtype>0    =>  solution
                        * rep.terminationtype=-3   =>  filled by zeros
            Rep     -   solver report, following fields are set:
                        * rep.terminationtype - solver status; >0 for success,
                          set to -3 on failure (degenerate system).

          -- ALGLIB --
             Copyright 18.11.2023 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolve(sparse.sparsematrix a,
            double[] b,
            int solvertype,
            ref double[] x,
            iterativesparse.sparsesolverreport rep,
            alglib.xparams _params)
        {
            int i = 0;
            int j = 0;
            int n = 0;
            double v = 0;
            sparse.sparsematrix a2 = new sparse.sparsematrix();
            int[] pivp = new int[0];
            int[] pivq = new int[0];
            double[] b2 = new double[0];
            double[] sr = new double[0];
            double[] sc = new double[0];
            double reg = 0;
            normestimator.normestimatorstate e = new normestimator.normestimatorstate();
            int gmresk = 0;
            int maxits = 0;

            x = new double[0];

            n = sparse.sparsegetnrows(a, _params);
            alglib.ap.assert(n>0, "SparseSolve: N<=0");
            alglib.ap.assert((((solvertype==0 || solvertype==-19) || solvertype==10) || solvertype==11) || solvertype==20, "SparseSolve: unexpected SolverType");
            alglib.ap.assert(sparse.sparsegetnrows(a, _params)==n, "SparseSolve: rows(A)!=N");
            alglib.ap.assert(sparse.sparsegetncols(a, _params)==n, "SparseSolve: cols(A)!=N");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SparseSolve: length(B)<N");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SparseSolve: B contains infinities or NANs");
            
            //
            // Default solver
            //
            if( solvertype==0 )
            {
                solvertype = 10;
            }
            
            //
            // Initialization
            //
            iterativesparse.initsparsesolverreport(rep, _params);
            ablasf.rsetallocv(n, 0.0, ref x, _params);
            sparse.sparsecopytocrs(a, a2, _params);
            
            //
            // Augmented system-based solver
            //
            if( (solvertype==-19 || solvertype==10) || solvertype==11 )
            {
                gmresk = 200;
                maxits = 200;
                if( solvertype==11 )
                {
                    
                    //
                    // Limited memory profile - decreased amount of GMRES memory
                    //
                    gmresk = 25;
                    maxits = 200;
                }
                if( solvertype==-19 )
                {
                    
                    //
                    // Debug profile - deliberately limited GMRES
                    //
                    gmresk = 5;
                    maxits = 200;
                }
                sparse.sparsescale(a2, 0, true, true, true, ref sr, ref sc, _params);
                ablasf.rcopyallocv(n, b, ref b2, _params);
                ablasf.rmergedivv(n, sr, b2, _params);
                normestimator.normestimatorcreate(n, n, 5, 5, e, _params);
                normestimator.normestimatorsetseed(e, 117, _params);
                normestimator.normestimatorestimatesparse(e, a2, _params);
                normestimator.normestimatorresults(e, ref v, _params);
                reg = Math.Sqrt(math.machineepsilon)*apserv.coalesce(v, 1, _params);
                sparsesolveaug(a2, b2, reg, reg, 0.0, 0.0, gmresk, maxits, x, rep, _params);
                ablasf.rmergedivv(n, sc, x, _params);
                return;
            }
            
            //
            // LU-based solver
            //
            if( solvertype==20 )
            {
                if( !trfac.sparselu(a2, 0, ref pivp, ref pivq, _params) )
                {
                    rep.terminationtype = -3;
                    for(i=0; i<=n-1; i++)
                    {
                        x[i] = 0;
                    }
                    return;
                }
                for(i=0; i<=n-1; i++)
                {
                    x[i] = b[i];
                }
                for(i=0; i<=n-1; i++)
                {
                    j = pivp[i];
                    v = x[i];
                    x[i] = x[j];
                    x[j] = v;
                }
                sparse.sparsetrsv(a2, false, true, 0, x, _params);
                sparse.sparsetrsv(a2, true, false, 0, x, _params);
                for(i=n-1; i>=0; i--)
                {
                    j = pivq[i];
                    v = x[i];
                    x[i] = x[j];
                    x[j] = v;
                }
                rep.terminationtype = 1;
                return;
            }
            
            //
            // unexpected solver type
            //
            alglib.ap.assert(false, "DIRECTSPARSESOLVERS: integrity check 1038 failed");
        }


        /*************************************************************************
        Sparse linear least squares solver for A*x=b with  general  (nonsymmetric)
        N*N sparse real matrix A, N*1 vectors x and b.

        This function solves a regularized linear least squares problem of the form

                (                      )
            min ( |Ax-b|^2 + reg*|x|^2 ), with reg>=sqrt(MachineAccuracy)
                (                      )

        The function internally uses supernodal  solver  to  solve  an  augmented-
        regularized sparse system. The solver, which was initially used  to  solve
        sparse square system, can also  be  used  to  solve  rectangular  systems,
        provided that the system is regularized with regularizing  coefficient  at
        least sqrt(MachineAccuracy), which is ~10^8 (double precision).

        It can be used to solve both full rank and rank deficient systems.

        INPUT PARAMETERS
            A       -   sparse MxN matrix, any storage format
            B       -   array[M], right part
            Reg     -   regularization coefficient, Reg>=sqrt(MachineAccuracy),
                        lower values will be silently increased.
            SolverType- solver type to use:
                        * 0     use the best solver. It is augmented system in the
                                current version, but may change in future releases
                        * 10    use 'default profile' of the supernodal solver with
                                static   pivoting.   The  'default'   profile   is
                                intended for systems with plenty of memory; it  is
                                optimized for the best convergence at the cost  of
                                increased RAM usage. Recommended option.
                        * 11    use 'limited memory'  profile  of  the  supernodal
                                solver with static  pivoting.  The  limited-memory
                                profile is intended for problems with millions  of
                                variables.  On  most  systems  it  has  the   same
                                convergence as the default profile, having somewhat
                                worse results only for ill-conditioned systems.

        OUTPUT PARAMETERS
            X       -   array[N], least squares solution
            Rep     -   solver report, following fields are set:
                        * rep.terminationtype - solver status; >0 for success.
                          
                          Present version of the solver does NOT returns negative
                          completion codes because  it  does  not  fail.  However,
                          future ALGLIB versions may include solvers which  return
                          negative completion codes.

          -- ALGLIB --
             Copyright 18.11.2023 by Bochkanov Sergey
        *************************************************************************/
        public static void sparsesolvelsreg(sparse.sparsematrix a,
            double[] b,
            double reg,
            int solvertype,
            ref double[] x,
            iterativesparse.sparsesolverreport rep,
            alglib.xparams _params)
        {
            int n = 0;
            int m = 0;
            double v = 0;
            sparse.sparsematrix a2 = new sparse.sparsematrix();
            int[] pivp = new int[0];
            int[] pivq = new int[0];
            double[] b2 = new double[0];
            double[] sr = new double[0];
            double[] sc = new double[0];
            double augreg = 0;
            normestimator.normestimatorstate e = new normestimator.normestimatorstate();
            int gmresk = 0;
            int maxits = 0;

            x = new double[0];

            m = sparse.sparsegetnrows(a, _params);
            n = sparse.sparsegetncols(a, _params);
            alglib.ap.assert(m>0, "SparseSolveLS: M<=0");
            alglib.ap.assert(n>0, "SparseSolveLS: N<=0");
            alglib.ap.assert(math.isfinite(reg) && (double)(reg)>(double)(0), "SparseSolveLS: Reg is not finite or non-positive");
            alglib.ap.assert(((solvertype==0 || solvertype==-19) || solvertype==10) || solvertype==11, "SparseSolveLS: unexpected SolverType");
            alglib.ap.assert(alglib.ap.len(b)>=m, "SparseSolveLS: length(B)<M");
            alglib.ap.assert(apserv.isfinitevector(b, m, _params), "SparseSolveLS: B contains infinities or NANs");
            
            //
            // Default solver
            //
            if( solvertype==0 )
            {
                solvertype = 10;
            }
            
            //
            // Initialization
            //
            iterativesparse.initsparsesolverreport(rep, _params);
            ablasf.rsetallocv(n, 0.0, ref x, _params);
            sparse.sparsecopytocrs(a, a2, _params);
            rep.terminationtype = 1;
            
            //
            // Augmented system-based solver
            //
            if( (solvertype==-19 || solvertype==10) || solvertype==11 )
            {
                reg = Math.Max(reg, Math.Sqrt(math.machineepsilon));
                gmresk = 200;
                maxits = 200;
                if( solvertype==11 )
                {
                    
                    //
                    // Limited memory profile
                    //
                    gmresk = 25;
                    maxits = 200;
                }
                if( solvertype==-19 )
                {
                    
                    //
                    // Debug profile - deliberately limited GMRES
                    //
                    gmresk = 5;
                    maxits = 200;
                }
                sparse.sparsescale(a2, 0, false, true, true, ref sr, ref sc, _params);
                ablasf.rcopyallocv(m, b, ref b2, _params);
                ablasf.rmergedivv(m, sr, b2, _params);
                normestimator.normestimatorcreate(m, n, 5, 5, e, _params);
                normestimator.normestimatorsetseed(e, 117, _params);
                normestimator.normestimatorestimatesparse(e, a2, _params);
                normestimator.normestimatorresults(e, ref v, _params);
                augreg = 10*Math.Sqrt(math.machineepsilon)*apserv.coalesce(v, 1, _params);
                sparsesolveaug(a2, b2, 1, Math.Max(math.sqr(augreg), math.sqr(reg)), 1, math.sqr(reg), gmresk, maxits, x, rep, _params);
                ablasf.rmergedivv(n, sc, x, _params);
                return;
            }
            
            //
            // unexpected solver type
            //
            alglib.ap.assert(false, "DIRECTSPARSESOLVERS: integrity check 1622 failed");
        }


        /*************************************************************************
        Sparse linear solver for A*x=b with general (nonsymmetric) N*N sparse real
        matrix A given by its LU factorization, N*1 vectors x and b.

        IMPORTANT: this solver requires input matrix  to  be  in  the  CRS  sparse
                   storage format. An exception will  be  generated  if  you  pass
                   matrix in some other format (HASH or SKS).

        INPUT PARAMETERS
            A       -   LU factorization of the sparse matrix, must be NxN exactly
                        in CRS storage format
            P, Q    -   pivot indexes from LU factorization
            N       -   size of A, N>0
            B       -   array[0..N-1], right part

        OUTPUT PARAMETERS
            X       -   array[N], it contains:
                        * rep.terminationtype>0    =>  solution
                        * rep.terminationtype=-3   =>  filled by zeros
            Rep     -   solver report, following fields are set:
                        * rep.terminationtype - solver status; >0 for success,
                          set to -3 on failure (degenerate system).

          -- ALGLIB --
             Copyright 26.12.2017 by Bochkanov Sergey
        *************************************************************************/
        public static void sparselusolve(sparse.sparsematrix a,
            int[] p,
            int[] q,
            double[] b,
            ref double[] x,
            iterativesparse.sparsesolverreport rep,
            alglib.xparams _params)
        {
            int i = 0;
            int j = 0;
            double v = 0;
            int n = 0;

            x = new double[0];

            n = sparse.sparsegetnrows(a, _params);
            alglib.ap.assert(n>0, "SparseLUSolve: N<=0");
            alglib.ap.assert(sparse.sparsegetnrows(a, _params)==n, "SparseLUSolve: rows(A)!=N");
            alglib.ap.assert(sparse.sparsegetncols(a, _params)==n, "SparseLUSolve: cols(A)!=N");
            alglib.ap.assert(sparse.sparseiscrs(a, _params), "SparseLUSolve: A is not an SKS matrix");
            alglib.ap.assert(alglib.ap.len(b)>=n, "SparseLUSolve: length(B)<N");
            alglib.ap.assert(apserv.isfinitevector(b, n, _params), "SparseLUSolve: B contains infinities or NANs");
            alglib.ap.assert(alglib.ap.len(p)>=n, "SparseLUSolve: length(P)<N");
            alglib.ap.assert(alglib.ap.len(q)>=n, "SparseLUSolve: length(Q)<N");
            for(i=0; i<=n-1; i++)
            {
                alglib.ap.assert(p[i]>=i && p[i]<n, "SparseLUSolve: P is corrupted");
                alglib.ap.assert(q[i]>=i && q[i]<n, "SparseLUSolve: Q is corrupted");
            }
            iterativesparse.initsparsesolverreport(rep, _params);
            x = new double[n];
            for(i=0; i<=n-1; i++)
            {
                if( a.didx[i]==a.uidx[i] || a.vals[a.didx[i]]==0.0 )
                {
                    rep.terminationtype = -3;
                    for(i=0; i<=n-1; i++)
                    {
                        x[i] = 0;
                    }
                    return;
                }
            }
            for(i=0; i<=n-1; i++)
            {
                x[i] = b[i];
            }
            for(i=0; i<=n-1; i++)
            {
                j = p[i];
                v = x[i];
                x[i] = x[j];
                x[j] = v;
            }
            sparse.sparsetrsv(a, false, true, 0, x, _params);
            sparse.sparsetrsv(a, true, false, 0, x, _params);
            for(i=n-1; i>=0; i--)
            {
                j = q[i];
                v = x[i];
                x[i] = x[j];
                x[j] = v;
            }
            rep.terminationtype = 1;
        }


        /*************************************************************************
        Internal function which creates and solves a sparse augmented system

            (        |        )
            ( REG1*I |   A    )
            (        |        )
            (-----------------)
            (        |        )
            (    A'  | -REG2*I)
            (        |        )

        This function uses supernodal LDLT to factorize the system,  then  applies
        iterative refinement (actually, a preconditioned GMRES which  acts  as  an
        improved version of the iterative refinement).

        It can be   used  to  solve  square  nonsymmetric  systems,  or  to  solve
        rectangular systems in a least squares  sense.  Its  performance  somewhat
        deteriorates for rank-deficient systems.

        INPUT PARAMETERS
            A       -   sparse matrix, M*N, CRS format
            B       -   array[N], right part
            Reg1F,Reg2F-regularizing factors used during the factorization of  the
                        system, Reg1F>0, Reg2F>0
            Reg1R,Reg2R-regularizing factors used during the refinement stage,
                        Reg1R>=0, Reg2R>=0
            X       -   preallocated buffer

        OUTPUT PARAMETERS
            X       -   array[N], it contains:
                        * rep.terminationtype>0    =>  solution
                        * rep.terminationtype=-3   =>  filled by zeros
            Rep     -   solver report, following fields are set:
                        * rep.terminationtype - solver status; >0 for success,
                          set to -3 on failure (degenerate system).
                        * rep.iterationscount - set ot an amount of GMRES
                          iterations performed

          -- ALGLIB --
             Copyright 26.12.2017 by Bochkanov Sergey
        *************************************************************************/
        private static void sparsesolveaug(sparse.sparsematrix a,
            double[] b,
            double reg1f,
            double reg2f,
            double reg1r,
            double reg2r,
            int gmresk,
            int maxits,
            double[] x,
            iterativesparse.sparsesolverreport rep,
            alglib.xparams _params)
        {
            int i = 0;
            int k = 0;
            int jj = 0;
            int j0 = 0;
            int j1 = 0;
            int m = 0;
            int n = 0;
            int nzaug = 0;
            sparse.sparsematrix aug = new sparse.sparsematrix();
            int[] priorities = new int[0];
            double[] bx = new double[0];
            spchol.spcholanalysis analysis = new spchol.spcholanalysis();
            iterativesparse.sparsesolverstate solver = new iterativesparse.sparsesolverstate();
            iterativesparse.sparsesolverreport innerrep = new iterativesparse.sparsesolverreport();
            int requesttype = 0;
            double[] rr = new double[0];
            double[] q = new double[0];
            double[] y = new double[0];
            int priorityordering = 0;
            int donotreusememory = 0;

            alglib.ap.assert(sparse.sparseiscrs(a, _params), "SparseSolveAug: A is not stored in the CRS format");
            m = sparse.sparsegetnrows(a, _params);
            n = sparse.sparsegetncols(a, _params);
            alglib.ap.assert(math.isfinite(reg1f) && (double)(reg1f)>(double)(0), "SparseSolveAug: Reg1F is non-positive");
            alglib.ap.assert(math.isfinite(reg2f) && (double)(reg2f)>(double)(0), "SparseSolveAug: Reg2F is non-positive");
            alglib.ap.assert(math.isfinite(reg1r) && (double)(reg1r)>=(double)(0), "SparseSolveAug: Reg1R is non-positive");
            alglib.ap.assert(math.isfinite(reg2r) && (double)(reg2r)>=(double)(0), "SparseSolveAug: Reg2R is non-positive");
            alglib.ap.assert(alglib.ap.len(b)>=m, "SparseSolveAug: length(B)<N");
            alglib.ap.assert(apserv.isfinitevector(b, m, _params), "SparseSolveAug: B contains infinities or NANs");
            alglib.ap.assert(alglib.ap.len(x)>=n, "SparseSolveAug: length(X)<N");
            
            //
            // Generate augmented matrix
            //
            ablasf.rallocv(n+m, ref rr, _params);
            nzaug = a.ridx[a.m]+n+m;
            aug.matrixtype = 1;
            aug.m = m+n;
            aug.n = m+n;
            ablasf.iallocv(aug.m+1, ref aug.ridx, _params);
            ablasf.iallocv(nzaug, ref aug.idx, _params);
            ablasf.rallocv(nzaug, ref aug.vals, _params);
            aug.ridx[0] = 0;
            for(i=0; i<=n-1; i++)
            {
                rr[i] = -reg2f;
                aug.idx[i] = i;
                aug.vals[i] = rr[i];
                aug.ridx[i+1] = i+1;
            }
            for(i=0; i<=m-1; i++)
            {
                rr[n+i] = reg1f;
                k = aug.ridx[n+i];
                j0 = a.ridx[i];
                j1 = a.ridx[i+1]-1;
                for(jj=j0; jj<=j1; jj++)
                {
                    aug.idx[k] = a.idx[jj];
                    aug.vals[k] = a.vals[jj];
                    k = k+1;
                }
                aug.idx[k] = n+i;
                aug.vals[k] = rr[n+i];
                k = k+1;
                aug.ridx[n+i+1] = k;
            }
            alglib.ap.assert(aug.ridx[n+m]==nzaug, "SparseSolveAug: integrity check 2141 failed");
            sparse.sparsecreatecrsinplace(aug, _params);
            
            //
            // Factorize augmented system
            //
            priorityordering = 3;
            donotreusememory = -1;
            ablasf.isetallocv(n+m, 1, ref priorities, _params);
            ablasf.isetv(n, 0, priorities, _params);
            if( !spchol.spsymmanalyze(aug, priorities, 0.0, 0, 1, priorityordering, donotreusememory, analysis, _params) )
            {
                alglib.ap.assert(false, "SparseSolveAug: integrity check 4141 failed");
            }
            while( !spchol.spsymmfactorize(analysis, _params) )
            {
                
                //
                // Factorization failure. Extremely rare, almost unable to reproduce.
                //
                ablasf.rmulv(n+m, 10.0, rr, _params);
                spchol.spsymmreloaddiagonal(analysis, rr, _params);
            }
            
            //
            // Solve using GMRES as an improved iterative refinement
            //
            ablasf.rsetallocv(n+m, reg1r, ref rr, _params);
            ablasf.rsetv(n, -reg2r, rr, _params);
            ablasf.rallocv(m+n, ref q, _params);
            ablasf.rallocv(m+n, ref y, _params);
            ablasf.rsetallocv(m+n, 0.0, ref bx, _params);
            ablasf.rcopyvx(m, b, 0, bx, n, _params);
            iterativesparse.sparsesolvercreate(m+n, solver, _params);
            iterativesparse.sparsesolversetalgogmres(solver, gmresk, _params);
            iterativesparse.sparsesolversetcond(solver, 10*math.machineepsilon, maxits, _params);
            iterativesparse.sparsesolveroocstart(solver, bx, _params);
            while( iterativesparse.sparsesolverooccontinue(solver, _params) )
            {
                iterativesparse.sparsesolveroocgetrequestinfo(solver, ref requesttype, _params);
                alglib.ap.assert(requesttype==0, "SPARSESOLVE: integrity check 8618 failed");
                iterativesparse.sparsesolveroocgetrequestdata(solver, ref q, _params);
                spchol.spsymmsolve(analysis, q, _params);
                sparse.sparsegemv(a, 1.0, 0, q, 0, 0.0, y, n, _params);
                sparse.sparsegemv(a, 1.0, 1, q, n, 0.0, y, 0, _params);
                ablasf.rmuladdv(m+n, q, rr, y, _params);
                iterativesparse.sparsesolveroocsendresult(solver, y, _params);
            }
            iterativesparse.sparsesolveroocstop(solver, ref bx, innerrep, _params);
            if( innerrep.terminationtype<=0 )
            {
                rep.terminationtype = innerrep.terminationtype;
                return;
            }
            spchol.spsymmsolve(analysis, bx, _params);
            ablasf.rcopyvx(n, bx, 0, x, 0, _params);
            rep.terminationtype = 1;
            rep.iterationscount = innerrep.iterationscount;
        }


    }
    public class nleq
    {
        public class nleqstate : apobject
        {
            public int n;
            public int m;
            public double epsf;
            public int maxits;
            public bool xrep;
            public double stpmax;
            public double[] x;
            public double f;
            public double[] fi;
            public double[,] j;
            public bool needf;
            public bool needfij;
            public bool xupdated;
            public rcommstate rstate;
            public int repiterationscount;
            public int repnfunc;
            public int repnjac;
            public int repterminationtype;
            public double[] xbase;
            public double fbase;
            public double fprev;
            public double[] candstep;
            public double[] rightpart;
            public double[] cgbuf;
            public nleqstate()
            {
                init();
            }
            public override void init()
            {
                x = new double[0];
                fi = new double[0];
                j = new double[0,0];
                rstate = new rcommstate();
                xbase = new double[0];
                candstep = new double[0];
                rightpart = new double[0];
                cgbuf = new double[0];
            }
            public override alglib.apobject make_copy()
            {
                nleqstate _result = new nleqstate();
                _result.n = n;
                _result.m = m;
                _result.epsf = epsf;
                _result.maxits = maxits;
                _result.xrep = xrep;
                _result.stpmax = stpmax;
                _result.x = (double[])x.Clone();
                _result.f = f;
                _result.fi = (double[])fi.Clone();
                _result.j = (double[,])j.Clone();
                _result.needf = needf;
                _result.needfij = needfij;
                _result.xupdated = xupdated;
                _result.rstate = (rcommstate)rstate.make_copy();
                _result.repiterationscount = repiterationscount;
                _result.repnfunc = repnfunc;
                _result.repnjac = repnjac;
                _result.repterminationtype = repterminationtype;
                _result.xbase = (double[])xbase.Clone();
                _result.fbase = fbase;
                _result.fprev = fprev;
                _result.candstep = (double[])candstep.Clone();
                _result.rightpart = (double[])rightpart.Clone();
                _result.cgbuf = (double[])cgbuf.Clone();
                return _result;
            }
        };


        public class nleqreport : apobject
        {
            public int iterationscount;
            public int nfunc;
            public int njac;
            public int terminationtype;
            public nleqreport()
            {
                init();
            }
            public override void init()
            {
            }
            public override alglib.apobject make_copy()
            {
                nleqreport _result = new nleqreport();
                _result.iterationscount = iterationscount;
                _result.nfunc = nfunc;
                _result.njac = njac;
                _result.terminationtype = terminationtype;
                return _result;
            }
        };




        /*************************************************************************
                        LEVENBERG-MARQUARDT-LIKE NONLINEAR SOLVER

        DESCRIPTION:
        This algorithm solves system of nonlinear equations
            F[0](x[0], ..., x[n-1])   = 0
            F[1](x[0], ..., x[n-1])   = 0
            ...
            F[M-1](x[0], ..., x[n-1]) = 0
        with M/N do not necessarily coincide.  Algorithm  converges  quadratically
        under following conditions:
            * the solution set XS is nonempty
            * for some xs in XS there exist such neighbourhood N(xs) that:
              * vector function F(x) and its Jacobian J(x) are continuously
                differentiable on N
              * ||F(x)|| provides local error bound on N, i.e. there  exists  such
                c1, that ||F(x)||>c1*distance(x,XS)
        Note that these conditions are much more weaker than usual non-singularity
        conditions. For example, algorithm will converge for any  affine  function
        F (whether its Jacobian singular or not).


        REQUIREMENTS:
        Algorithm will request following information during its operation:
        * function vector F[] and Jacobian matrix at given point X
        * value of merit function f(x)=F[0]^2(x)+...+F[M-1]^2(x) at given point X


        USAGE:
        1. User initializes algorithm state with NLEQCreateLM() call
        2. User tunes solver parameters with  NLEQSetCond(),  NLEQSetStpMax()  and
           other functions
        3. User  calls  NLEQSolve()  function  which  takes  algorithm  state  and
           pointers (delegates, etc.) to callback functions which calculate  merit
           function value and Jacobian.
        4. User calls NLEQResults() to get solution
        5. Optionally, user may call NLEQRestartFrom() to  solve  another  problem
           with same parameters (N/M) but another starting  point  and/or  another
           function vector. NLEQRestartFrom() allows to reuse already  initialized
           structure.


        INPUT PARAMETERS:
            N       -   space dimension, N>1:
                        * if provided, only leading N elements of X are used
                        * if not provided, determined automatically from size of X
            M       -   system size
            X       -   starting point


        OUTPUT PARAMETERS:
            State   -   structure which stores algorithm state


        NOTES:
        1. you may tune stopping conditions with NLEQSetCond() function
        2. if target function contains exp() or other fast growing functions,  and
           optimization algorithm makes too large steps which leads  to  overflow,
           use NLEQSetStpMax() function to bound algorithm's steps.
        3. this  algorithm  is  a  slightly  modified implementation of the method
           described  in  'Levenberg-Marquardt  method  for constrained  nonlinear
           equations with strong local convergence properties' by Christian Kanzow
           Nobuo Yamashita and Masao Fukushima and further  developed  in  'On the
           convergence of a New Levenberg-Marquardt Method'  by  Jin-yan  Fan  and
           Ya-Xiang Yuan.


          -- ALGLIB --
             Copyright 20.08.2009 by Bochkanov Sergey
        *************************************************************************/
        public static void nleqcreatelm(int n,
            int m,
            double[] x,
            nleqstate state,
            alglib.xparams _params)
        {
            alglib.ap.assert(n>=1, "NLEQCreateLM: N<1!");
            alglib.ap.assert(m>=1, "NLEQCreateLM: M<1!");
            alglib.ap.assert(alglib.ap.len(x)>=n, "NLEQCreateLM: Length(X)<N!");
            alglib.ap.assert(apserv.isfinitevector(x, n, _params), "NLEQCreateLM: X contains infinite or NaN values!");
            
            //
            // Initialize
            //
            state.n = n;
            state.m = m;
            nleqsetcond(state, 0, 0, _params);
            nleqsetxrep(state, false, _params);
            nleqsetstpmax(state, 0, _params);
            state.x = new double[n];
            state.xbase = new double[n];
            state.j = new double[m, n];
            state.fi = new double[m];
            state.rightpart = new double[n];
            state.candstep = new double[n];
            nleqrestartfrom(state, x, _params);
        }


        /*************************************************************************
        This function sets stopping conditions for the nonlinear solver

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state
            EpsF    -   >=0
                        The subroutine finishes  its work if on k+1-th iteration
                        the condition ||F||<=EpsF is satisfied
            MaxIts  -   maximum number of iterations. If MaxIts=0, the  number  of
                        iterations is unlimited.

        Passing EpsF=0 and MaxIts=0 simultaneously will lead to  automatic
        stopping criterion selection (small EpsF).

        NOTES:

          -- ALGLIB --
             Copyright 20.08.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void nleqsetcond(nleqstate state,
            double epsf,
            int maxits,
            alglib.xparams _params)
        {
            alglib.ap.assert(math.isfinite(epsf), "NLEQSetCond: EpsF is not finite number!");
            alglib.ap.assert((double)(epsf)>=(double)(0), "NLEQSetCond: negative EpsF!");
            alglib.ap.assert(maxits>=0, "NLEQSetCond: negative MaxIts!");
            if( (double)(epsf)==(double)(0) && maxits==0 )
            {
                epsf = 1.0E-6;
            }
            state.epsf = epsf;
            state.maxits = maxits;
        }


        /*************************************************************************
        This function turns on/off reporting.

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state
            NeedXRep-   whether iteration reports are needed or not

        If NeedXRep is True, algorithm will call rep() callback function if  it is
        provided to NLEQSolve().

          -- ALGLIB --
             Copyright 20.08.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void nleqsetxrep(nleqstate state,
            bool needxrep,
            alglib.xparams _params)
        {
            state.xrep = needxrep;
        }


        /*************************************************************************
        This function sets maximum step length

        INPUT PARAMETERS:
            State   -   structure which stores algorithm state
            StpMax  -   maximum step length, >=0. Set StpMax to 0.0,  if you don't
                        want to limit step length.

        Use this subroutine when target function  contains  exp()  or  other  fast
        growing functions, and algorithm makes  too  large  steps  which  lead  to
        overflow. This function allows us to reject steps that are too large  (and
        therefore expose us to the possible overflow) without actually calculating
        function value at the x+stp*d.

          -- ALGLIB --
             Copyright 20.08.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void nleqsetstpmax(nleqstate state,
            double stpmax,
            alglib.xparams _params)
        {
            alglib.ap.assert(math.isfinite(stpmax), "NLEQSetStpMax: StpMax is not finite!");
            alglib.ap.assert((double)(stpmax)>=(double)(0), "NLEQSetStpMax: StpMax<0!");
            state.stpmax = stpmax;
        }


        /*************************************************************************

          -- ALGLIB --
             Copyright 20.03.2009 by Bochkanov Sergey
        *************************************************************************/
        public static bool nleqiteration(nleqstate state,
            alglib.xparams _params)
        {
            bool result = new bool();
            int n = 0;
            int m = 0;
            int i = 0;
            double lambdaup = 0;
            double lambdadown = 0;
            double lambdav = 0;
            double rho = 0;
            double mu = 0;
            double stepnorm = 0;
            bool b = new bool();
            int i_ = 0;

            
            //
            // Reverse communication preparations
            // I know it looks ugly, but it works the same way
            // anywhere from C++ to Python.
            //
            // This code initializes locals by:
            // * random values determined during code
            //   generation - on first subroutine call
            // * values from previous call - on subsequent calls
            //
            if( state.rstate.stage>=0 )
            {
                n = state.rstate.ia[0];
                m = state.rstate.ia[1];
                i = state.rstate.ia[2];
                b = state.rstate.ba[0];
                lambdaup = state.rstate.ra[0];
                lambdadown = state.rstate.ra[1];
                lambdav = state.rstate.ra[2];
                rho = state.rstate.ra[3];
                mu = state.rstate.ra[4];
                stepnorm = state.rstate.ra[5];
            }
            else
            {
                n = 359;
                m = -58;
                i = -919;
                b = true;
                lambdaup = 81.0;
                lambdadown = 255.0;
                lambdav = 74.0;
                rho = -788.0;
                mu = 809.0;
                stepnorm = 205.0;
            }
            if( state.rstate.stage==0 )
            {
                goto lbl_0;
            }
            if( state.rstate.stage==1 )
            {
                goto lbl_1;
            }
            if( state.rstate.stage==2 )
            {
                goto lbl_2;
            }
            if( state.rstate.stage==3 )
            {
                goto lbl_3;
            }
            if( state.rstate.stage==4 )
            {
                goto lbl_4;
            }
            
            //
            // Routine body
            //
            
            //
            // Prepare
            //
            n = state.n;
            m = state.m;
            state.repterminationtype = 0;
            state.repiterationscount = 0;
            state.repnfunc = 0;
            state.repnjac = 0;
            
            //
            // Calculate F/G, initialize algorithm
            //
            clearrequestfields(state, _params);
            state.needf = true;
            state.rstate.stage = 0;
            goto lbl_rcomm;
        lbl_0:
            state.needf = false;
            state.repnfunc = state.repnfunc+1;
            for(i_=0; i_<=n-1;i_++)
            {
                state.xbase[i_] = state.x[i_];
            }
            state.fbase = state.f;
            state.fprev = math.maxrealnumber;
            if( !state.xrep )
            {
                goto lbl_5;
            }
            
            //
            // progress report
            //
            clearrequestfields(state, _params);
            state.xupdated = true;
            state.rstate.stage = 1;
            goto lbl_rcomm;
        lbl_1:
            state.xupdated = false;
        lbl_5:
            if( (double)(state.f)<=(double)(math.sqr(state.epsf)) )
            {
                state.repterminationtype = 1;
                result = false;
                return result;
            }
            
            //
            // Main cycle
            //
            lambdaup = 10;
            lambdadown = 0.3;
            lambdav = 0.001;
            rho = 1;
        lbl_7:
            if( false )
            {
                goto lbl_8;
            }
            
            //
            // Get Jacobian;
            // before we get to this point we already have State.XBase filled
            // with current point and State.FBase filled with function value
            // at XBase
            //
            clearrequestfields(state, _params);
            state.needfij = true;
            for(i_=0; i_<=n-1;i_++)
            {
                state.x[i_] = state.xbase[i_];
            }
            state.rstate.stage = 2;
            goto lbl_rcomm;
        lbl_2:
            state.needfij = false;
            state.repnfunc = state.repnfunc+1;
            state.repnjac = state.repnjac+1;
            ablas.rmatrixmv(n, m, state.j, 0, 0, 1, state.fi, 0, state.rightpart, 0, _params);
            for(i_=0; i_<=n-1;i_++)
            {
                state.rightpart[i_] = -1*state.rightpart[i_];
            }
            
            //
            // Inner cycle: find good lambda
            //
        lbl_9:
            if( false )
            {
                goto lbl_10;
            }
            
            //
            // Solve (J^T*J + (Lambda+Mu)*I)*y = J^T*F
            // to get step d=-y where:
            // * Mu=||F|| - is damping parameter for nonlinear system
            // * Lambda   - is additional Levenberg-Marquardt parameter
            //              for better convergence when far away from minimum
            //
            for(i=0; i<=n-1; i++)
            {
                state.candstep[i] = 0;
            }
            fbls.fblssolvecgx(state.j, m, n, lambdav, state.rightpart, ref state.candstep, ref state.cgbuf, _params);
            
            //
            // Normalize step (it must be no more than StpMax)
            //
            stepnorm = 0;
            for(i=0; i<=n-1; i++)
            {
                if( (double)(state.candstep[i])!=(double)(0) )
                {
                    stepnorm = 1;
                    break;
                }
            }
            linmin.linminnormalized(ref state.candstep, ref stepnorm, n, _params);
            if( (double)(state.stpmax)!=(double)(0) )
            {
                stepnorm = Math.Min(stepnorm, state.stpmax);
            }
            
            //
            // Test new step - is it good enough?
            // * if not, Lambda is increased and we try again.
            // * if step is good, we decrease Lambda and move on.
            //
            // We can break this cycle on two occasions:
            // * step is so small that x+step==x (in floating point arithmetics)
            // * lambda is so large
            //
            for(i_=0; i_<=n-1;i_++)
            {
                state.x[i_] = state.xbase[i_];
            }
            for(i_=0; i_<=n-1;i_++)
            {
                state.x[i_] = state.x[i_] + stepnorm*state.candstep[i_];
            }
            b = true;
            for(i=0; i<=n-1; i++)
            {
                if( (double)(state.x[i])!=(double)(state.xbase[i]) )
                {
                    b = false;
                    break;
                }
            }
            if( b )
            {
                
                //
                // Step is too small, force zero step and break
                //
                stepnorm = 0;
                for(i_=0; i_<=n-1;i_++)
                {
                    state.x[i_] = state.xbase[i_];
                }
                state.f = state.fbase;
                goto lbl_10;
            }
            clearrequestfields(state, _params);
            state.needf = true;
            state.rstate.stage = 3;
            goto lbl_rcomm;
        lbl_3:
            state.needf = false;
            state.repnfunc = state.repnfunc+1;
            if( (double)(state.f)<(double)(state.fbase) )
            {
                
                //
                // function value decreased, move on
                //
                decreaselambda(ref lambdav, ref rho, lambdadown, _params);
                goto lbl_10;
            }
            if( !increaselambda(ref lambdav, ref rho, lambdaup, _params) )
            {
                
                //
                // Lambda is too large (near overflow), force zero step and break
                //
                stepnorm = 0;
                for(i_=0; i_<=n-1;i_++)
                {
                    state.x[i_] = state.xbase[i_];
                }
                state.f = state.fbase;
                goto lbl_10;
            }
            goto lbl_9;
        lbl_10:
            
            //
            // Accept step:
            // * new position
            // * new function value
            //
            state.fbase = state.f;
            for(i_=0; i_<=n-1;i_++)
            {
                state.xbase[i_] = state.xbase[i_] + stepnorm*state.candstep[i_];
            }
            state.repiterationscount = state.repiterationscount+1;
            
            //
            // Report new iteration
            //
            if( !state.xrep )
            {
                goto lbl_11;
            }
            clearrequestfields(state, _params);
            state.xupdated = true;
            state.f = state.fbase;
            for(i_=0; i_<=n-1;i_++)
            {
                state.x[i_] = state.xbase[i_];
            }
            state.rstate.stage = 4;
            goto lbl_rcomm;
        lbl_4:
            state.xupdated = false;
        lbl_11:
            
            //
            // Test stopping conditions on F, step (zero/non-zero) and MaxIts;
            // If one of the conditions is met, RepTerminationType is changed.
            //
            if( (double)(Math.Sqrt(state.f))<=(double)(state.epsf) )
            {
                state.repterminationtype = 1;
            }
            if( (double)(stepnorm)==(double)(0) && state.repterminationtype==0 )
            {
                state.repterminationtype = -4;
            }
            if( state.repiterationscount>=state.maxits && state.maxits>0 )
            {
                state.repterminationtype = 5;
            }
            if( state.repterminationtype!=0 )
            {
                goto lbl_8;
            }
            
            //
            // Now, iteration is finally over
            //
            goto lbl_7;
        lbl_8:
            result = false;
            return result;
            
            //
            // Saving state
            //
        lbl_rcomm:
            result = true;
            state.rstate.ia[0] = n;
            state.rstate.ia[1] = m;
            state.rstate.ia[2] = i;
            state.rstate.ba[0] = b;
            state.rstate.ra[0] = lambdaup;
            state.rstate.ra[1] = lambdadown;
            state.rstate.ra[2] = lambdav;
            state.rstate.ra[3] = rho;
            state.rstate.ra[4] = mu;
            state.rstate.ra[5] = stepnorm;
            return result;
        }


        /*************************************************************************
        NLEQ solver results

        INPUT PARAMETERS:
            State   -   algorithm state.

        OUTPUT PARAMETERS:
            X       -   array[0..N-1], solution
            Rep     -   optimization report:
                        * Rep.TerminationType completetion code:
                            * -4    ERROR:  algorithm   has   converged   to   the
                                    stationary point Xf which is local minimum  of
                                    f=F[0]^2+...+F[m-1]^2, but is not solution  of
                                    nonlinear system.
                            *  1    sqrt(f)<=EpsF.
                            *  5    MaxIts steps was taken
                            *  7    stopping conditions are too stringent,
                                    further improvement is impossible
                        * Rep.IterationsCount contains iterations count
                        * NFEV countains number of function calculations
                        * ActiveConstraints contains number of active constraints

          -- ALGLIB --
             Copyright 20.08.2009 by Bochkanov Sergey
        *************************************************************************/
        public static void nleqresults(nleqstate state,
            ref double[] x,
            nleqreport rep,
            alglib.xparams _params)
        {
            x = new double[0];

            nleqresultsbuf(state, ref x, rep, _params);
        }


        /*************************************************************************
        NLEQ solver results

        Buffered implementation of NLEQResults(), which uses pre-allocated  buffer
        to store X[]. If buffer size is  too  small,  it  resizes  buffer.  It  is
        intended to be used in the inner cycles of performance critical algorithms
        where array reallocation penalty is too large to be ignored.

          -- ALGLIB --
             Copyright 20.08.2009 by Bochkanov Sergey
        *************************************************************************/
        public static void nleqresultsbuf(nleqstate state,
            ref double[] x,
            nleqreport rep,
            alglib.xparams _params)
        {
            int i_ = 0;

            if( alglib.ap.len(x)<state.n )
            {
                x = new double[state.n];
            }
            for(i_=0; i_<=state.n-1;i_++)
            {
                x[i_] = state.xbase[i_];
            }
            rep.iterationscount = state.repiterationscount;
            rep.nfunc = state.repnfunc;
            rep.njac = state.repnjac;
            rep.terminationtype = state.repterminationtype;
        }


        /*************************************************************************
        This  subroutine  restarts  CG  algorithm from new point. All optimization
        parameters are left unchanged.

        This  function  allows  to  solve multiple  optimization  problems  (which
        must have same number of dimensions) without object reallocation penalty.

        INPUT PARAMETERS:
            State   -   structure used for reverse communication previously
                        allocated with MinCGCreate call.
            X       -   new starting point.
            BndL    -   new lower bounds
            BndU    -   new upper bounds

          -- ALGLIB --
             Copyright 30.07.2010 by Bochkanov Sergey
        *************************************************************************/
        public static void nleqrestartfrom(nleqstate state,
            double[] x,
            alglib.xparams _params)
        {
            int i_ = 0;

            alglib.ap.assert(alglib.ap.len(x)>=state.n, "NLEQRestartFrom: Length(X)<N!");
            alglib.ap.assert(apserv.isfinitevector(x, state.n, _params), "NLEQRestartFrom: X contains infinite or NaN values!");
            for(i_=0; i_<=state.n-1;i_++)
            {
                state.x[i_] = x[i_];
            }
            state.rstate.ia = new int[2+1];
            state.rstate.ba = new bool[0+1];
            state.rstate.ra = new double[5+1];
            state.rstate.stage = -1;
            clearrequestfields(state, _params);
        }


        /*************************************************************************
        Sets V1 reverse communication protocol
        *************************************************************************/
        public static void nleqsetprotocolv1(nleqstate state,
            alglib.xparams _params)
        {
        }


        /*************************************************************************
        Clears request fileds (to be sure that we don't forgot to clear something)
        *************************************************************************/
        private static void clearrequestfields(nleqstate state,
            alglib.xparams _params)
        {
            state.needf = false;
            state.needfij = false;
            state.xupdated = false;
        }


        /*************************************************************************
        Increases lambda, returns False when there is a danger of overflow
        *************************************************************************/
        private static bool increaselambda(ref double lambdav,
            ref double nu,
            double lambdaup,
            alglib.xparams _params)
        {
            bool result = new bool();
            double lnlambda = 0;
            double lnnu = 0;
            double lnlambdaup = 0;
            double lnmax = 0;

            result = false;
            lnlambda = Math.Log(lambdav);
            lnlambdaup = Math.Log(lambdaup);
            lnnu = Math.Log(nu);
            lnmax = 0.5*Math.Log(math.maxrealnumber);
            if( (double)(lnlambda+lnlambdaup+lnnu)>(double)(lnmax) )
            {
                return result;
            }
            if( (double)(lnnu+Math.Log(2))>(double)(lnmax) )
            {
                return result;
            }
            lambdav = lambdav*lambdaup*nu;
            nu = nu*2;
            result = true;
            return result;
        }


        /*************************************************************************
        Decreases lambda, but leaves it unchanged when there is danger of underflow.
        *************************************************************************/
        private static void decreaselambda(ref double lambdav,
            ref double nu,
            double lambdadown,
            alglib.xparams _params)
        {
            nu = 1;
            if( (double)(Math.Log(lambdav)+Math.Log(lambdadown))<(double)(Math.Log(math.minrealnumber)) )
            {
                lambdav = math.minrealnumber;
            }
            else
            {
                lambdav = lambdav*lambdadown;
            }
        }


    }
}

