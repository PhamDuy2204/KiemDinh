using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyThuVien;

namespace UnitTestLibrary
{
    [TestClass]
    public class UnitTestDoiMK
    {
        [TestMethod]
        public void checkPass()
        {
            DoiMatKhau dmk = new DoiMatKhau();
            var r = dmk.checkPassNew("phamduy123");
            Assert.IsTrue(r);
        }

        [TestMethod]
        public void checkEqual()
        {
            DoiMatKhau dmk = new DoiMatKhau();
            var r = dmk.checkEqual("phamduy12","phamduy12");
            Assert.IsFalse(r);
        }

        [TestMethod]
        public void checkCorrect()
        {
            DoiMatKhau dmk = new DoiMatKhau();
            var r = dmk.checkCorrect("phamduy123", "phamduy123");
            Assert.IsFalse(r);
        }
    }
}
