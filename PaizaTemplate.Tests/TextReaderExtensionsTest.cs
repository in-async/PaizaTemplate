using System.Collections.Generic;
using System.IO;
// <copyright file="TextReaderExtensionsTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaTemplate;

namespace PaizaTemplate.Tests
{
    [TestClass]
    [PexClass(typeof(TextReaderExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class TextReaderExtensionsTest
    {

        [PexMethod]
        [PexAllowedException(typeof(FormatException))]
        public int ReadInt32(TextReader reader) {
            int result = TextReaderExtensions.ReadInt32(reader);
            return result;
            // TODO: アサーションを メソッド TextReaderExtensionsTest.ReadInt32(TextReader) に追加します
        }

        [PexMethod]
        public IEnumerable<string> ReadLines(TextReader reader, int count) {
            IEnumerable<string> result = TextReaderExtensions.ReadLines(reader, count);
            return result;
            // TODO: アサーションを メソッド TextReaderExtensionsTest.ReadLines(TextReader, Int32) に追加します
        }

        [PexMethod]
        [PexAllowedException(typeof(FormatException))]
        [PexAllowedException(typeof(ArgumentOutOfRangeException))]
        public IEnumerable<int> ReadInt32Enumerable(
            TextReader reader,
            ReadingDirection direction,
            int count
        ) {
            IEnumerable<int> result = TextReaderExtensions.ReadInt32Enumerable(reader, direction, count);
            return result;
            // TODO: アサーションを メソッド TextReaderExtensionsTest.ReadInt32Enumerable(TextReader, ReadingDirection, Int32) に追加します
        }

        [PexMethod]
        [PexAllowedException(typeof(FormatException))]
        [PexAllowedException(typeof(ArgumentOutOfRangeException))]
        public IEnumerable<IEnumerable<int>> ReadInt32Matrix(
            TextReader reader,
            int horizontalCount,
            int verticalCount
        ) {
            IEnumerable<IEnumerable<int>> result
               = TextReaderExtensions.ReadInt32Matrix(reader, horizontalCount, verticalCount);
            return result;
            // TODO: アサーションを メソッド TextReaderExtensionsTest.ReadInt32Matrix(TextReader, Int32, Int32) に追加します
        }
    }
}
