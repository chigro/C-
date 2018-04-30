using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TemplateTestProject
{
    [TestClass]
    public class FirstMSTest
    {
        [ClassInitialize]
        public static void ConnectToDateBase(TestContext textContext)
        {
            Console.WriteLine("Open connection to the Database");
        }
    
           
        [TestInitialize]
        public void LaunchBrowser()
        {
            Console.WriteLine("Launches the Browser");
        }


        //[Ignore]
        [TestMethod, TestCategory("SMOKE TEST")]
        public void ClickButton()
        {
            Console.WriteLine("Click on a button");
        }



        [TestMethod, TestCategory("PENETRATION TEST")]
        public void EnterText()
        {
            Console.WriteLine("Enter text into text field");
        }



        [TestMethod]
        public void NavigateToPage()
        {
            Console.WriteLine("Navigate to a certain page");

        }



        [TestCleanup]
        public void TearDownBrowser()
        {
            Console.WriteLine("Close all open browser");
        }

        [ClassCleanup]
        public static void DisconnectFromDatabase()
        {
            Console.WriteLine("close connection to the database");
        }
        }
    


    }

         
   
    


   



