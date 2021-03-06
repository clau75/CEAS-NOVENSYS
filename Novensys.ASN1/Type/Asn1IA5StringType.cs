﻿// Decompiled with JetBrains decompiler
// Type: Novensys.ASN1.Type.Asn1IA5StringType
// Assembly: Novensys.eCard.SDK, Version=1.1.56.0, Culture=neutral, PublicKeyToken=null
// MVID: 59F9E456-D3DA-4066-A4A4-692B516A775E
// Assembly location: C:\Program Files (x86)\CNAS\SIUI-SPITAL\Novensys.eCard.SDK.dll

using System;
using System.ComponentModel;

namespace Novensys.ASN1.Type
{
  [Serializable]
  public class Asn1IA5StringType : Asn1KnownMultiplierStringType
  {
    public override string PrintableValue
    {
      get
      {
        return this.__getCharsDefnPrintableValue(false);
      }
    }

    public override string TypeName
    {
      get
      {
        return "IA5String";
      }
    }

    public Asn1IA5StringType()
    {
    }

    public Asn1IA5StringType(string str)
      : base(str)
    {
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override int __getBaseAlphabetAlignedNbBitPerChar()
    {
      return 8;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override long __getBaseAlphabetLowerBound()
    {
      return 0L;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override int __getBaseAlphabetUnalignedNbBitPerChar()
    {
      return 7;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override long __getBaseAlphabetUpperBound()
    {
      return (long) sbyte.MaxValue;
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    protected internal override int __getUniversalTagNumber()
    {
      return 22;
    }

    protected internal override void __setTypeValue(Asn1Type typeInstance)
    {
      if (typeInstance == null)
      {
        this.ResetType();
      }
      else
      {
        if (!(typeInstance is Asn1IA5StringType))
          return;
        this.SetValue(((Asn1StringType) typeInstance).GetStringValue());
      }
    }

    public override bool Equals(object anObject)
    {
      return this == anObject || anObject is Asn1IA5StringType && this.HasEqualValue((Asn1StringType) anObject);
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }
  }
}
