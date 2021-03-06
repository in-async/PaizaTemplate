using System.Collections.Generic;
// <copyright file="EnumerableExtensionsTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaTemplate;

namespace PaizaTemplate.Tests
{
    [TestClass]
    [PexClass(typeof(EnumerableExtensions))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedException(typeof(FormatException))]
    public partial class EnumerableExtensionsTest
    {

        [PexMethod]
        public IEnumerable<int> ToInt32Enumerable(IEnumerable<string> source) {
            IEnumerable<int> result = EnumerableExtensions.ToInt32Enumerable(source);
            return result;
            // TODO: アサーションを メソッド EnumerableExtensionsTest.ToInt32Enumerable(IEnumerable`1<String>) に追加します
        }
    }
}
