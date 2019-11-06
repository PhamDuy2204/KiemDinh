using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyThuVien;

namespace UnitTestLibrary
{
    [TestClass]
    public class UnitTestMain
    {
        [TestMethod]
        public void checkEmpty()
        {
            Main main = new Main();
            var r = main.checkEmpty("phamduy");
            Assert.IsTrue(r);
        }
    }
}
