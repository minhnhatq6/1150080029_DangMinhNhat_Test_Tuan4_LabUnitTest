using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathSystem;
using System;
using System.Collections.Generic;

namespace MathSystemTest
{
    [TestClass]
    public class Bai2Test
    {
        // Test Case 1: Kiểm thử tính toán đúng
        // Giả sử đa thức bậc 2 (n=2): 1 + 2x + 3x^2 (Hệ số: 1, 2, 3)
        // Với x = 2 -> Kết quả = 1 + 2*(2) + 3*(2^2) = 1 + 4 + 12 = 17
        [TestMethod]
        public void TestCal_ValidInput()
        {
            int n = 2;
            List<int> heSo = new List<int> { 1, 2, 3 };
            Bai2 poly = new Bai2(n, heSo);

            int result = poly.Cal(2);

            Assert.AreEqual(17, result);
        }

        // Test Case 2: Kiểm thử ngoại lệ (Lỗi dữ liệu)
        // Bậc 2 thì cần 3 hệ số (n+1), nhưng chỉ truyền 2 hệ số -> Mong đợi lỗi ArgumentException
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructor_InvalidData()
        {
            int n = 2;
            List<int> heSoThieu = new List<int> { 1, 2 }; // Thiếu 1 số

            // Dòng này sẽ gây ra lỗi, và ExpectedException sẽ bắt lỗi đó -> Test Pass
            Bai2 poly = new Bai2(n, heSoThieu);
        }
    }
}