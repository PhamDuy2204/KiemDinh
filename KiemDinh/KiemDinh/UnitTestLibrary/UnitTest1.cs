using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyThuVien;

namespace UnitTestLibrary
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void checkAcc()
        {
            TaoTaiKhoan tk = new TaoTaiKhoan();
            var r = tk.checkAcc("phamduy");
            Assert.IsTrue(r);
        }

        [TestMethod]
        public void checkPass()
        {
            TaoTaiKhoan tk = new TaoTaiKhoan();
            var r = tk.checkPass("phamduy123");
            Assert.IsTrue(r);
        }

        [TestMethod]
        public void checkSpace()
        {
            TaoTaiKhoan tk = new TaoTaiKhoan();
            var r = tk.checkSpace("phamduy");
            Assert.IsFalse(r);
        }
    }
}
