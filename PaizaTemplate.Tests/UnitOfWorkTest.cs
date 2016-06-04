using System.IO;
// <copyright file="UnitOfWorkTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaizaTemplate;

namespace PaizaTemplate.Tests
{
    [TestClass]
    [PexClass(typeof(UnitOfWork))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class UnitOfWorkTest
    {

        [PexMethod]
        public UnitOfWork Load(TextReader reader) {
            UnitOfWork result = UnitOfWork.Load(reader);
            return result;
            // TODO: アサーションを メソッド UnitOfWorkTest.Load(TextReader) に追加します
        }

        [PexMethod]
        public string Execute([PexAssumeUnderTest]UnitOfWork target) {
            string result = target.Execute();
            return result;
            // TODO: アサーションを メソッド UnitOfWorkTest.Execute(UnitOfWork) に追加します
        }
    }
}
