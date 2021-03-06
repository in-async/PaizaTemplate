using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
// <copyright file="StringExtensionsTest.SplitBySpace.g.cs">Copyright ©  2016</copyright>
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
    public partial class StringExtensionsTest
    {

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionsTest))]
[ExpectedException(typeof(ArgumentNullException))]
public void SplitBySpaceThrowsArgumentNullException735()
{
    IReadOnlyCollection<string> iReadOnlyCollection;
    iReadOnlyCollection = this.SplitBySpace((string)null, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionsTest))]
public void SplitBySpace296()
{
    IReadOnlyCollection<string> iReadOnlyCollection;
    iReadOnlyCollection = this.SplitBySpace("", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void SplitBySpaceThrowsArgumentOutOfRangeException349()
{
    IReadOnlyCollection<string> iReadOnlyCollection;
    iReadOnlyCollection = this.SplitBySpace("\0", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionsTest))]
public void SplitBySpace611()
{
    IReadOnlyCollection<string> iReadOnlyCollection;
    iReadOnlyCollection = this.SplitBySpace(" ", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void SplitBySpaceThrowsArgumentOutOfRangeException26()
{
    IReadOnlyCollection<string> iReadOnlyCollection;
    iReadOnlyCollection = this.SplitBySpace(" \0", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionsTest))]
public void SplitBySpace672()
{
    IReadOnlyCollection<string> iReadOnlyCollection;
    iReadOnlyCollection = this.SplitBySpace(" \0", 1);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionsTest))]
public void SplitBySpace658()
{
    IReadOnlyCollection<string> iReadOnlyCollection;
    iReadOnlyCollection = this.SplitBySpace("  ", 0);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionsTest))]
public void SplitBySpace726()
{
    IReadOnlyCollection<string> iReadOnlyCollection;
    iReadOnlyCollection = this.SplitBySpace("\0 \0", 2);
}

[TestMethod]
[PexGeneratedBy(typeof(StringExtensionsTest))]
[ExpectedException(typeof(ArgumentOutOfRangeException))]
public void SplitBySpaceThrowsArgumentOutOfRangeException846()
{
    IReadOnlyCollection<string> iReadOnlyCollection;
    iReadOnlyCollection = this.SplitBySpace("\0 \0 ", 0);
}
    }
}
