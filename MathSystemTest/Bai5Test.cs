using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathSystem;

namespace MathSystemTest
{
    [TestClass]
    public class Bai5Test
    {
        // Test Case 1: Đủ điều kiện nhận học bổng
        // Điểm: 8, 9, 8.5 -> ĐTB > 8, không môn nào dưới 5 -> TRUE
        [TestMethod]
        public void TestHocBong_Pass()
        {
            Bai5 hv = new Bai5("Nguyen Van A", 8.0, 9.0, 8.5);

            // Mong đợi kết quả là True
            Assert.IsTrue(hv.NhanHocBong());
        }

        // Test Case 2: Trượt do có môn bị điểm liệt (< 5)
        // Điểm: 10, 10, 4 -> ĐTB = 8.0 (Đạt), nhưng có môn 4 (Không đạt) -> FALSE
        [TestMethod]
        public void TestHocBong_Fail_DiemLiet()
        {
            Bai5 hv = new Bai5("Nguyen Van B", 10.0, 10.0, 4.0);

            // Mong đợi kết quả là False
            Assert.IsFalse(hv.NhanHocBong());
        }

        // Test Case 3: Trượt do điểm trung bình thấp (< 8)
        // Điểm: 7, 7, 7 -> Không môn nào dưới 5, nhưng ĐTB = 7 -> FALSE
        [TestMethod]
        public void TestHocBong_Fail_LowAverage()
        {
            Bai5 hv = new Bai5("Nguyen Van C", 7.0, 7.0, 7.0);

            // Mong đợi kết quả là False
            Assert.IsFalse(hv.NhanHocBong());
        }
    }
}