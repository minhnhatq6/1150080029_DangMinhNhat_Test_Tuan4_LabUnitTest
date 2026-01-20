using System;
using System.Collections.Generic; 
using System.Linq;

namespace MathSystem
{
    public class Bai3
    {
        private int number;

        public Bai3(int number)
        {
            if (number < 0)
                throw new ArgumentException("Incorrect Value");
            this.number = number;
        }

        public string ConvertDecimalToAnother(int radix = 2)
        {
            int n = this.number;

            // Kiểm tra điều kiện cơ số (2 <= k <= 16)
            if (radix < 2 || radix > 16)
                throw new ArgumentException("Invalid Radix");

            List<string> result = new List<string>();

            // Xử lý trường hợp số 0
            if (n == 0) return "0";

            while (n > 0)
            {
                int value = n % radix;
                if (value < 10)
                    result.Add(value.ToString());
                else
                {
                    switch (value)
                    {
                        case 10: result.Add("A"); break;
                        case 11: result.Add("B"); break;
                        case 12: result.Add("C"); break;
                        case 13: result.Add("D"); break;
                        case 14: result.Add("E"); break;
                        case 15: result.Add("F"); break;
                    }
                }
                n /= radix;
            }

            result.Reverse(); // Đảo ngược danh sách số dư
            return String.Join("", result.ToArray());
        }
    }
}