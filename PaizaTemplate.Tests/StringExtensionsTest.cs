using System.Collections.Generic;
// <copyright file="StringExtensionsTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaTemplate;

namespace PaizaTemplate.Tests
{
    [TestClass]
    [PexClass(typeof(StringExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedException(typeof(FormatException))]
    public partial class StringExtensionsTest
    {

        [PexMethod]
        public int ToInt32(string value) {
            int result = StringExtensions.ToInt32(value);
            return result;
            // TODO: アサーションを メソッド StringExtensionsTest.ToInt32(String) に追加します
        }

        [PexMethod(MaxRunsWithoutNewTests = 200)]
        public IReadOnlyCollection<string> SplitBySpace(string value, int count) {
            IReadOnlyCollection<string> result = StringExtensions.SplitBySpace(value, count);
            return result;
            // TODO: アサーションを メソッド StringExtensionsTest.SplitBySpace(String, Int32) に追加します
        }
    }
}
