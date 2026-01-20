using System;

namespace MathSystem
{
    public class Bai1
    {
        // Hàm tính x mũ n
        public static double Power(double x, int n)
        {
            // Nếu mũ là 0 thì kết quả luôn là 1
            if (n == 0)
                return 1.0;
            // Nếu mũ dương (ví dụ x^3 = x * x^2)
            else if (n > 0)
                return n * Power(x, n - 1);
            // Nếu mũ âm (ví dụ x^-1 = 1/x)
            else
                return Power(x, n + 1) / x;
        }
    }
}