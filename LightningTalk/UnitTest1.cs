using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;


namespace LightningTalk
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var request = (HttpWebRequest)WebRequest.Create("http://www.reddit.com/r/bbq");
         
        }
    }
}
