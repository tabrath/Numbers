/*
Written in 2013 by Peter O.
Any copyright is dedicated to the Public Domain.
http://creativecommons.org/publicdomain/zero/1.0/
If you like this, you should donate to Peter O.
at: http://upokecenter.dreamhosters.com/articles/donate-now-2/
 */
using System;

namespace PeterO.Numbers {
  public sealed partial class EFloat {
    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Implicit(System.Int64)~PeterO.Numbers.EFloat"]/*'/>
    public static implicit operator EFloat(long bigValue) {
      return FromInt64(bigValue);
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Implicit(System.Single)~PeterO.Numbers.EFloat"]/*'/>
    public static implicit operator EFloat(float flt) {
      return FromSingle(flt);
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Implicit(System.Double)~PeterO.Numbers.EFloat"]/*'/>
    public static implicit operator EFloat(double dbl) {
      return FromDouble(dbl);
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Implicit(System.Int32)~PeterO.Numbers.EFloat"]/*'/>
    public static implicit operator EFloat(int valueSmaller) {
      return FromInt32(valueSmaller);
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Implicit(PeterO.Numbers.EInteger)~PeterO.Numbers.EFloat"]/*'/>
    public static implicit operator EFloat(EInteger eint) {
      return FromEInteger(eint);
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Addition(PeterO.Numbers.EFloat,PeterO.Numbers.EFloat)"]/*'/>
    public static EFloat operator +(EFloat bthis, EFloat augend) {
      if (bthis == null) {
        throw new ArgumentNullException("bthis");
      }
      return bthis.Add(augend);
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Subtraction(PeterO.Numbers.EFloat,PeterO.Numbers.EFloat)"]/*'/>
    public static EFloat operator -(
   EFloat bthis,
   EFloat subtrahend) {
      if (bthis == null) {
        throw new ArgumentNullException("bthis");
      }
      return bthis.Subtract(subtrahend);
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Multiply(PeterO.Numbers.EFloat,PeterO.Numbers.EFloat)"]/*'/>
    public static EFloat operator *(
    EFloat operand1,
    EFloat operand2) {
      if (operand1 == null) {
        throw new ArgumentNullException("operand1");
      }
      return operand1.Multiply(operand2);
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Division(PeterO.Numbers.EFloat,PeterO.Numbers.EFloat)"]/*'/>
    public static EFloat operator /(
   EFloat dividend,
   EFloat divisor) {
      if (dividend == null) {
        throw new ArgumentNullException("dividend");
      }
      return dividend.Divide(divisor);
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Modulus(PeterO.Numbers.EFloat,PeterO.Numbers.EFloat)"]/*'/>
    public static EFloat operator %(
   EFloat dividend,
   EFloat divisor) {
      if (dividend == null) {
        throw new ArgumentNullException("dividend");
      }
      return dividend.Remainder(divisor, null);
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_UnaryNegation(PeterO.Numbers.EFloat)"]/*'/>
    public static EFloat operator -(EFloat bigValue) {
      if (bigValue == null) {
        throw new ArgumentNullException("bigValue");
      }
      return bigValue.Negate();
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Explicit(PeterO.Numbers.EFloat)~System.Int64"]/*'/>
    public static explicit operator long(EFloat bigValue) {
      if (bigValue == null) {
        throw new ArgumentNullException("bigValue");
      }
      return (long)bigValue.ToEInteger();
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Explicit(PeterO.Numbers.EFloat)~PeterO.Numbers.EInteger"]/*'/>
    public static explicit operator EInteger(EFloat bigValue) {
      return bigValue.ToEInteger();
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Explicit(PeterO.Numbers.EFloat)~System.Double"]/*'/>
    public static explicit operator double(EFloat bigValue) {
      return bigValue.ToDouble();
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Explicit(PeterO.Numbers.EFloat)~System.Single"]/*'/>
    public static explicit operator float(EFloat bigValue) {
      return bigValue.ToSingle();
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Explicit(PeterO.Numbers.EFloat)~System.Int32"]/*'/>
    public static explicit operator int(EFloat bigValue) {
      return (int)bigValue.ToEInteger();
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Explicit(PeterO.Numbers.EFloat)~System.Int16"]/*'/>
    public static explicit operator short(EFloat bigValue) {
      return (short)(int)bigValue;
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Explicit(PeterO.Numbers.EFloat)~System.Byte"]/*'/>
    public static explicit operator byte(EFloat bigValue) {
      return (byte)(int)bigValue;
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Implicit(System.UInt64)~PeterO.Numbers.EFloat"]/*'/>
    [CLSCompliant(false)]
    /// <summary>Not documented yet.</summary>
    /// <param name='bigValue'>Not documented yet.</param>
    /// <returns>An EFloat object.</returns>
    public static implicit operator EFloat(ulong bigValue) {
      return FromEInteger((EInteger)bigValue);
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Implicit(System.UInt32)~PeterO.Numbers.EFloat"]/*'/>
    [CLSCompliant(false)]
    /// <summary>Not documented yet.</summary>
    /// <param name='smallValue'>Not documented yet.</param>
    /// <returns>An EFloat object.</returns>
    public static implicit operator EFloat(uint smallValue) {
      return FromEInteger((EInteger)smallValue);
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Explicit(PeterO.Numbers.EFloat)~System.UInt64"]/*'/>
    [CLSCompliant(false)]
    /// <summary>Not documented yet.</summary>
    /// <param name='bigValue'>Not documented yet.</param>
    /// <returns>A 64-bit unsigned integer.</returns>
    public static explicit operator ulong(EFloat bigValue) {
      return (ulong)bigValue.ToEInteger();
    }

    /// <include file='../../docs.xml'
    /// path='docs/doc[@name="M:PeterO.Numbers.EFloat.op_Explicit(PeterO.Numbers.EFloat)~System.UInt32"]/*'/>
    [CLSCompliant(false)]
    /// <summary>Not documented yet.</summary>
    /// <param name='bigValue'>Not documented yet.</param>
    /// <returns>A 32-bit unsigned integer.</returns>
    public static explicit operator uint(EFloat bigValue) {
      return (uint)bigValue.ToEInteger();
    }
  }
}
