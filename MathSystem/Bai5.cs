using System;

namespace MathSystem
{
    public class Bai5
    {
        // Thông tin học viên
        public string HoTen { get; set; }
        public double Diem1 { get; set; }
        public double Diem2 { get; set; }
        public double Diem3 { get; set; }

        // Hàm khởi tạo
        public Bai5(string ten, double d1, double d2, double d3)
        {
            this.HoTen = ten;
            this.Diem1 = d1;
            this.Diem2 = d2;
            this.Diem3 = d3;
        }

        // Phương thức kiểm tra điều kiện học bổng
        public bool NhanHocBong()
        {
            // Tính điểm trung bình
            double dtb = (Diem1 + Diem2 + Diem3) / 3;

            // Điều kiện: ĐTB >= 8.0 VÀ không môn nào < 5
            if (dtb >= 8.0 && Diem1 >= 5 && Diem2 >= 5 && Diem3 >= 5)
            {
                return true; // Được học bổng
            }

            return false; // Không được
        }
    }
}