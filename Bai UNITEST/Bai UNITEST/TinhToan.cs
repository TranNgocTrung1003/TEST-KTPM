using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_UNITEST
{
        public class TinhToan
    {
        private int a, b; //xây dựng 2 thuộc tính a và b
        public TinhToan(int a, int b) // phương thức khởi tạo dán cho 2 thuộc tính 
        {
            this.a = a;
            this.b = b;
        }
        public int Execute(string operation)
        {
            int Result = 0;
            switch(operation)
            {
                case "+":
                    Result = a + b;
                    break;
                case "-":
                    Result = a - b;
                    break;
                case "*":
                    Result = a * b;
                    break;
                case "/":
                    Result = a / b;
                    break;
            }
            return Result;
        }

    }
}
