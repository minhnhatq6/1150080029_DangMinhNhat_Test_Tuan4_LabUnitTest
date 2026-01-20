using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathSystem;

namespace MathSystemTest
{
    [TestClass]
    public class Bai4Test
    {
        // Test Case 1: Kiểm tra tính diện tích
        // HCN từ (0,10) đến (10,0) -> Rộng 10, Cao 10 -> Diện tích 100
        [TestMethod]
        public void TestDienTich()
        {
            Bai4 hcn = new Bai4(new Diem(0, 10), new Diem(10, 0));
            Assert.AreEqual(100, hcn.TinhDienTich());
        }

        // Test Case 2: Kiểm tra 2 hình có giao nhau (Overlap)
        [TestMethod]
        public void TestGiaoNhau_CoGiao()
        {
            // Hình 1: (0, 5) -> (5, 0)
            // Hình 2: (3, 5) -> (8, 0) 
            // -> Giao nhau ở khoảng x từ 3 đến 5
            Bai4 h1 = new Bai4(new Diem(0, 5), new Diem(5, 0));
            Bai4 h2 = new Bai4(new Diem(3, 5), new Diem(8, 0));

            Assert.IsTrue(h1.IsIntersect(h2));
        }

        // Test Case 3: Kiểm tra 2 hình rời nhau (Không giao)
        [TestMethod]
        public void TestGiaoNhau_KhongGiao()
        {
            // Hình 1 ở bên trái (0->5), Hình 2 ở tít bên phải (10->15)
            Bai4 h1 = new Bai4(new Diem(0, 5), new Diem(5, 0));
            Bai4 h2 = new Bai4(new Diem(10, 5), new Diem(15, 0));

            Assert.IsFalse(h1.IsIntersect(h2));
        }
    }
}