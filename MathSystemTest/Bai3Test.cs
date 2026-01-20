using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathSystem;
using System;

namespace MathSystemTest
{
    [TestClass]
    public class Bai3Test
    {
        // Test Case 1: Chuyển đổi sang nhị phân (Cơ số 2)
        // Số 10 hệ 10 -> 1010 hệ 2
        [TestMethod]
        public void TestConvert_ToBinary()
        {
            Bai3 r = new Bai3(10);
            string result = r.ConvertDecimalToAnother(2);
            Assert.AreEqual("1010", result);
        }

        // Test Case 2: Chuyển đổi sang Hex (Cơ số 16)
        // Số 255 hệ 10 -> FF hệ 16
        [TestMethod]
        public void TestConvert_ToHex()
        {
            Bai3 r = new Bai3(255);
            string result = r.ConvertDecimalToAnother(16);
            Assert.AreEqual("FF", result);
        }

        // Test Case 3: Kiểm tra lỗi khởi tạo số âm
        // Constructor không cho phép số âm -> Mong đợi lỗi ArgumentException
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructor_NegativeNumber()
        {
            Bai3 r = new Bai3(-5);
        }

        // Test Case 4: Kiểm tra lỗi cơ số không hợp lệ
        // Cơ số 18 vượt quá 16 -> Mong đợi lỗi ArgumentException
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConvert_InvalidRadix()
        {
            Bai3 r = new Bai3(10);
            r.ConvertDecimalToAnother(18);
        }
    }
}