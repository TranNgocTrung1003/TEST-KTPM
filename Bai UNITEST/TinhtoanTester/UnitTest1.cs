using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Bai_UNITEST;

namespace TinhtoanTester
{
    [TestClass]
    public class UnitTest1
    {
        private TinhToan c;
        [TestInitialize]
        public void setup ()
        {
            c = new TinhToan(10, 5);
        }
        [TestMethod]
        public void TestAddopreration()
        {
            int kqmongdoi, kqthucte;
            // c = new TinhToan(10, 5);
            kqmongdoi = 15;
            kqthucte = c.Execute("+");
            Assert.AreEqual(kqmongdoi, kqthucte);
        }
        // kq a=5, b=10, =15
        [TestMethod]
        public void TestSupopreration()
        {
            int kqmongdoi, kqthucte;
           // TinhToan c = new TinhToan(10, 5);
            kqmongdoi = 5;
            kqthucte = c.Execute("-");
            Assert.AreEqual(kqmongdoi, kqthucte);
        }
        [TestMethod]
        public void TestMULopreration()
        {
            int kqmongdoi, kqthucte;
          //  TinhToan c = new TinhToan(10, 5);
            kqmongdoi = 50;
            kqthucte = c.Execute("*");
            Assert.AreEqual(kqmongdoi, kqthucte);
        }
        [TestMethod]
        public void TestDivopreration()
        {
            int kqmongdoi, kqthucte;
           // TinhToan c = new TinhToan(10, 5);
            kqmongdoi = 2;
            kqthucte = c.Execute("/");
            Assert.AreEqual(kqmongdoi, kqthucte);
        }
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivByzezo()
        { 
          c = new TinhToan(10, 0);
          c.Execute("/"); 
        }

        //Liên kết textdata tới project 
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @".\Data\TextData.csv", "TextData#csv",DataAccessMethod.Sequential)]
    }
}   
