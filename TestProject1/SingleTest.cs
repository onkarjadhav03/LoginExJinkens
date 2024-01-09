using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestClass]
    public class SingleTest
    {
        [TestMethod]

        public void SuccessMethod()
        {
            string expResult = "valid user";
            Assert.AreEqual(expResult, SignIn.Authenticate("sam", "sam@123"));
        }

        [TestMethod]

        public void FailureMethod()
        {
            string expResult = "invalid user";
            Assert.AreEqual(expResult, SignIn.Authenticate("raj", "raj@123"));
        }
        [TestMethod]
        public void AnonymousMethod()
        {
            string expResult = "you must provide username and password";
            Assert.AreEqual(expResult, SignIn.Authenticate(null, null));
        }
    }
}
