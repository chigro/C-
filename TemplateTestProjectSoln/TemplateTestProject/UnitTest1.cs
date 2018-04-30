using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemplateTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]
        public static void BeforeAssembly(TestContext textcontext)
        {
            Console.WriteLine("This is from the Assembly method");
        }

        [TestMethod, TestCategory("SMOKE TEST")]
        public void ClickDropDownMenu()
        {
            Console.WriteLine("Click a dropdown menu");
        }

        [TestMethod]
        public void ClickRadioButton()
        {
            Console.WriteLine("Click on a radiobutton");
        }
             

        [AssemblyCleanup]
        public static void AfterAssembly()
        {
            Console.WriteLine("This is to close the Assembly method");
        }
    }
}
