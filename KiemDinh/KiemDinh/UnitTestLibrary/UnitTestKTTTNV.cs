using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuanLyThuVien;

namespace UnitTestLibrary
{
    [TestClass]
    public class UnitTestKTTTNV
    {
        [TestMethod]
        public void checkTenNV()
        {
            KiemTraTTNhanVien kiemtra = new KiemTraTTNhanVien();
            var r = kiemtra.checkTenNV("phamduy");
            Assert.IsFalse(r);
        }

        [TestMethod]
        public void checkPassEmpty()
        {
            KiemTraTTNhanVien kiemtra = new KiemTraTTNhanVien();
            var r = kiemtra.checkPassEmpty("phamduy123");
            Assert.IsFalse(r);
        }

        [TestMethod]
        public void checkQuyen()
        {
            KiemTraTTNhanVien kiemtra = new KiemTraTTNhanVien();
            var r = kiemtra.checkQuyen("admin");
            Assert.IsFalse(r);
        }

        [TestMethod]
        public void checkDiaChi()
        {
            KiemTraTTNhanVien kiemtra = new KiemTraTTNhanVien();
            var r = kiemtra.checkDiaChi("hcm");
            Assert.IsFalse(r);
        }

        [TestMethod]
        public void checkChucVu()
        {
            KiemTraTTNhanVien kiemtra = new KiemTraTTNhanVien();
            var r = kiemtra.checkChucVu("sep");
            Assert.IsFalse(r);
        }

        [TestMethod]
        public void checkTuoi()
        {
            KiemTraTTNhanVien kiemtra = new KiemTraTTNhanVien();
            var r = kiemtra.checkTuoi("22");
            Assert.IsFalse(r);
        }

        [TestMethod]
        public void checkTuoi2()
        {
            KiemTraTTNhanVien kiemtra = new KiemTraTTNhanVien();
            var r = kiemtra.checkTuoi2("22");
            Assert.IsFalse(r);
        }

        [TestMethod]
        public void checkSDT()
        {
            KiemTraTTNhanVien kiemtra = new KiemTraTTNhanVien();
            var r = kiemtra.checkSDT("0986322937");
            Assert.IsFalse(r);
        }
    }
}
