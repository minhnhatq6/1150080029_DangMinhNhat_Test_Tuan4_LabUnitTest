using System;

namespace MathSystem
{
    // Class Điểm (Tọa độ x, y)
    public class Diem
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Diem(int x, int y) { X = x; Y = y; }
    }

    // Class Bài 4 (Đại diện cho Hình Chữ Nhật)
    public class Bai4
    {
        public Diem TopLeft { get; set; }     // Điểm góc trên bên trái
        public Diem BottomRight { get; set; } // Điểm góc dưới bên phải

        public Bai4(Diem tl, Diem br)
        {
            TopLeft = tl;
            BottomRight = br;
        }

        // Phương thức tính diện tích
        public int TinhDienTich()
        {
            int width = Math.Abs(BottomRight.X - TopLeft.X);
            int height = Math.Abs(TopLeft.Y - BottomRight.Y);
            return width * height;
        }

        // Phương thức kiểm tra 2 hình có giao nhau không
        public bool IsIntersect(Bai4 other)
        {
            // Ta tìm Min/Max của tọa độ Y để đảm bảo tính toán đúng bất kể hệ tọa độ nào
            int thisMinY = Math.Min(this.TopLeft.Y, this.BottomRight.Y);
            int thisMaxY = Math.Max(this.TopLeft.Y, this.BottomRight.Y);
            int otherMinY = Math.Min(other.TopLeft.Y, other.BottomRight.Y);
            int otherMaxY = Math.Max(other.TopLeft.Y, other.BottomRight.Y);

            // Logic kiểm tra KHÔNG giao nhau:
            // 1. Hình này nằm hoàn toàn bên trái hình kia
            // 2. Hình này nằm hoàn toàn bên phải hình kia
            // 3. Hình này nằm hoàn toàn bên dưới hình kia
            // 4. Hình này nằm hoàn toàn bên trên hình kia
            if (this.BottomRight.X < other.TopLeft.X ||
                this.TopLeft.X > other.BottomRight.X ||
                thisMaxY < otherMinY ||
                thisMinY > otherMaxY)
            {
                return false;
            }

            return true;
        }
    }
}