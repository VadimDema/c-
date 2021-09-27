using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void validatePasswordTest()
        {
            string password = "ky";
            bool expected = true;
            bool actual = Program.validatePassword(password);

            Assert.AreEqual(expected,actual);
        }
    }
}
