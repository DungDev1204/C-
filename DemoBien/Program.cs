using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//int a = 5;
//float b = 9.5f;
//float c = a + b;
//Console.WriteLine("a +b =c :{0}+{1}={2}", a, b, c);
//Console.WriteLine("Hello, World!");
//Console.ReadKey();

//static void Main(string[] args)
//{
//    // Kiểu số nguyên
//    byte BienByte = 10;
//    short BienShort = 10;
//    int BienInt = 10;
//    long BienLong = 10;

//    // Kiểu số thực
//    float BienFloat = 10.9f; // Giá trị của biến kiểu float phải có hậu tố f hoặc F. 
//    double BienDouble = 10.9; // Giá trị của biến kiểu double không cần hậu tố.
//    decimal BienDecimal = 10.9m; // Giá trị của biến kiểu decimal phải có hậu tố m.

//    // Kiểu ký tự và kiểu chuỗi
//    char BienChar = 'K'; // Giá trị của biến kiểu ký tự nằm trong cặp dấu '' (nháy đơn).
//    string BienString = "Kteam"; // Giá trị của biến kiểu chuỗi nằm trong cặp dấu "" (nháy kép).

//    Console.ReadKey();
//}
namespace Myapp
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Kiểu số nguyên
            byte BienByte = 3;
            short BienShort = 9;
            int BienInt = 10;
            long BienLong = 0;

            BienLong = BienByte; // BienLong có kiểu dữ liệu lớn hơn BienByte nên giá trị BienByte có thể gán qua cho BienLong
            Console.WriteLine(" BienLong = " + BienLong);

            BienLong = BienInt; // tương tự như trên
            Console.WriteLine(" BienLong = {0}", BienLong);

            BienShort = BienByte; // tương tự như trên
            Console.WriteLine(" BienShort = " + BienShort);

            BienInt = BienShort; // tương tự như trên
            Console.WriteLine(" BienInt = " + BienInt);

            Console.ReadKey();
        }
    }
}