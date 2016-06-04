using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaizaTemplate.Tests {

    [TestClass]
    public class UnitOfWorkTests {

        /// <summary>
        /// テストデータ
        /// </summary>
        public static object[][] LoadAndExecuteTestSource = new[] {
            new object[] { @"
".Trim(), @"
".Trim() },
            new object[] { @"
".Trim(), @"
".Trim() },
        };

        #region Framework

        public TestContext TestContext { get; set; }

        [TestMethod]
        [TestCaseSource("LoadAndExecuteTestSource")]
        public void LoadAndExecuteTest() {
            TestContext.Run((string input, string expected) => {
                var reader = new StringReader(input);

                var uow = new UnitOfWork();
                uow.Load(reader);
                var actual = uow.Execute();
                actual.Is(expected);
            });
        }

        public sealed class TestCase {

            public TestCase(string input, string result) {
                Input = input;
                Result = result;
            }

            public string Input { get; }

            public string Result { get; }
        }

        #endregion Framework
    }
}