﻿// Decompiled with JetBrains decompiler
// Type: Novensys.ASN1.IO.IAsn1BitOutputStream
// Assembly: Novensys.eCard.SDK, Version=1.1.56.0, Culture=neutral, PublicKeyToken=null
// MVID: 59F9E456-D3DA-4066-A4A4-692B516A775E
// Assembly location: C:\Program Files (x86)\CNAS\SIUI-SPITAL\Novensys.eCard.SDK.dll

namespace Novensys.ASN1.IO
{
  public interface IAsn1BitOutputStream
  {
    void flush();

    void printEmpty();

    void printLineSeparator();

    void restoreAlignment();

    void write(byte theBits, int length);

    void write(byte theBits, int start, int length);

    void writeOneBitNoAlign(bool aBit);
  }
}
