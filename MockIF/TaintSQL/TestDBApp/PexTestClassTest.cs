
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyApplication;
using Microsoft.Pex.Framework.Generated;
using Microsoft.Pex.Framework;
namespace TestDBApp
{
    
    
    /// <summary>
    ///This is a test class for PexTestClassTest and is intended
    ///to contain all PexTestClassTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PexTestClassTest
    {
        [TestMethod]
        public void testExample()
        {
           /* string[] name = new string[1];
            name[0] = "John";
            DBApplication.ExampleProgram(1, name);
            * */
            PexTestClass cl = new PexTestClass();
            cl.TestMain();
        }
        [TestMethod]
        public void testTest()
        {
            /* string[] name = new string[1];
             name[0] = "John";
             DBApplication.ExampleProgram(1, name);
             * */
            PexTestClass cl = new PexTestClass();
           /* IPexChoiceRecorder choices = PexChoose.NewTest();
            ((IPexChoiceSessionBuilder)(choices.OnCall(0, "DBMS.LetPexChooseRecords()")))
                .At(0, "Num Records", (object)1)
                .At(2, "column SignSymText Record 0", "\0");
            ((IPexChoiceSessionBuilder)(choices.OnCall(1, "DBMS.LetPexChooseRecords()")))
                .At(0, "Num Records", (object)3)
                .At(1, "column CCID Record 0", (object)100)
                .At(3, "column CCID Record 1", (object)100)
                .At(5, "column CCID Record 2", (object)100);
            */
             //this.TestMain();
            cl.TestMain();
        }


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for TestMain11
        ///</summary>
        
        

        /// <summary>
        ///A test for TestMain13
        ///</summary>
        ///
        /*
        [TestMethod()]
        public void TestMain13Test()
        {
            PexTestClass target = new PexTestClass(); // TODO: Initialize to an appropriate value
            target.TestMain13();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }*/
    }
}
