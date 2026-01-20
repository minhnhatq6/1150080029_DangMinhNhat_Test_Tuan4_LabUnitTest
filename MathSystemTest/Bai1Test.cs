using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathSystem; // Kết nối với project chính

namespace MathSystemTest
{
    [TestClass]
    public class Bai1Test
    {
        // Test Case 1: Kiểm tra mũ 0 (Biên)
        // Mong đợi: 10^0 = 1
        [TestMethod]
        public void TestPower_ZeroExponent()
        {
            double result = Bai1.Power(10, 0);
            Assert.AreEqual(1.0, result);
        }

        // Test Case 2: Kiểm tra mũ dương
        // Mong đợi: 2^3 = 8
        [TestMethod]
        public void TestPower_PositiveExponent()
        {
            double result = Bai1.Power(2, 3);
            Assert.AreEqual(8.0, result);
        }

        // Test Case 3: Kiểm tra mũ âm
        // Mong đợi: 2^-2 = 0.25 (vì 1/(2^2) = 1/4)
        [TestMethod]
        public void TestPower_NegativeExponent()
        {
            double result = Bai1.Power(2, -2);
            Assert.AreEqual(0.25, result);
        }
    }
}