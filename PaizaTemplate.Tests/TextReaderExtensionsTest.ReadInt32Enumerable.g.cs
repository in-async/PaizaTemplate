using PaizaTemplate;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Microsoft.Pex.Framework.Generated;
// <copyright file="TextReaderExtensionsTest.ReadInt32Enumerable.g.cs">Copyright ©  2016</copyright>
// <auto-generated>
// このファイルには自動的に生成されたテストが含まれています。
// このファイルを手動で変更しないでください。
// 
// このファイルの内容が古くなった場合には削除することができます。
// たとえば、コンパイルが不要になった場合などです。
// </auto-generated>
using System;

namespace PaizaTemplate.Tests
{
    public partial class TextReaderExtensionsTest
    {

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void ReadInt32ThrowsInvalidOperationException88301()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      int i;
      stringReader = new StringReader("");
      disposables.Add((IDisposable)stringReader);
      i = this.ReadInt32((TextReader)stringReader);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(FormatException))]
public void ReadInt32ThrowsFormatException45514()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      int i;
      stringReader = new StringReader("");
      disposables.Add((IDisposable)stringReader);
      i = this.ReadInt32((TextReader)stringReader);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
public void ReadInt324604()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      int i;
      stringReader = new StringReader("0");
      disposables.Add((IDisposable)stringReader);
      i = this.ReadInt32((TextReader)stringReader);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(FormatException))]
public void ReadInt32ThrowsFormatException45519()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      int i;
      stringReader = new StringReader("\r\n");
      disposables.Add((IDisposable)stringReader);
      i = this.ReadInt32((TextReader)stringReader);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(FormatException))]
public void ReadInt32ThrowsFormatException45521()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      int i;
      stringReader = new StringReader("-\0");
      disposables.Add((IDisposable)stringReader);
      i = this.ReadInt32((TextReader)stringReader);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
public void ReadInt324606()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      int i;
      stringReader = new StringReader("00");
      disposables.Add((IDisposable)stringReader);
      i = this.ReadInt32((TextReader)stringReader);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void ReadInt32EnumerableThrowsArgumentNullException851()
{
    IEnumerable<int> iEnumerable;
    iEnumerable =
      this.ReadInt32Enumerable((TextReader)null, ReadingDirection.Horizontal, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(InvalidOperationException))]
public void ReadInt32EnumerableThrowsInvalidOperationException609()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ReadInt32EnumerableThrowsArgumentOutOfRangeException728()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("\0");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
public void ReadInt32Enumerable474()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("\n");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
public void ReadInt32Enumerable473()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Vertial, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ReadInt32EnumerableThrowsArgumentOutOfRangeException972()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("");
      disposables.Add((IDisposable)stringReader);
      iEnumerable =
        this.ReadInt32Enumerable((TextReader)stringReader, (ReadingDirection)2, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
public void ReadInt32Enumerable47402()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader(" ");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ReadInt32EnumerableThrowsArgumentOutOfRangeException451()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("\0\0");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ReadInt32EnumerableThrowsArgumentOutOfRangeException195()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("\r\n");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 1);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ReadInt32EnumerableThrowsArgumentOutOfRangeException19501()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("\r\0");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 1);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
public void ReadInt324603()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      int i;
      stringReader = new StringReader("00\0\0\0\0\0\0");
      disposables.Add((IDisposable)stringReader);
      i = this.ReadInt32((TextReader)stringReader);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ReadInt32EnumerableThrowsArgumentOutOfRangeException670()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("\r");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 1);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ReadInt32EnumerableThrowsArgumentOutOfRangeException52001()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("\0\r");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ReadInt32EnumerableThrowsArgumentOutOfRangeException326()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("\0\0\0\0\0\0 \0");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ReadInt32EnumerableThrowsArgumentOutOfRangeException629()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader(" \0\0\0\0\0\0\0");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ReadInt32EnumerableThrowsArgumentOutOfRangeException22()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("  \0\0\0\0\0\0");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ReadInt32EnumerableThrowsArgumentOutOfRangeException703()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader(" \0 \0\0\0\0\0");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 0);
      disposables.Dispose();
    }
}

[TestMethod]
[PexGeneratedBy(typeof(TextReaderExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void ReadInt32EnumerableThrowsArgumentOutOfRangeException412()
{
    using (PexDisposableContext disposables = PexDisposableContext.Create())
    {
      StringReader stringReader;
      IEnumerable<int> iEnumerable;
      stringReader = new StringReader("\0 \0 \0\0\0\0");
      disposables.Add((IDisposable)stringReader);
      iEnumerable = this.ReadInt32Enumerable
                        ((TextReader)stringReader, ReadingDirection.Horizontal, 0);
      disposables.Dispose();
    }
}
    }
}
