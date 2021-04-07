// Bao gồm cả cấu trúc cơ bản của C#
using System;

namespace Hoc_nhap_xuat_C_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Lệnh xuất cơ bản

            /*// C# có phân biệt chữ hoa chữ thường => cẩn thận với các lệnh
            Console.WriteLine("1. Cau lenh xuat co ban");
            Console.WriteLine("Day la chuong trinh C# dau tien"); // Sử dụng lệnh in ra màn hình có xuống dòng
            Console.Write("Tui ten la Thanh Truc \n"); // Sử dụng ký tự đặc biệt (\n) để xuống dòng
            Console.Write(20); // In ra giá trị nhưng không xuống dòng
            Console.Write(Environment.NewLine); // Lệnh xuống dòng (ít được xài hơn 2 cái trên)
            Console.WriteLine(19.5f);
            Console.WriteLine();

            //Console.ReadKey(); // Lệnh để dừng chương trình xem kết quả mà không cần có các dòng chữ dư thừa ở phía sau (nhấn tiếp Enter thì nó vẫn hiện nha =))s)
            // Hoặc lệnh Console.ReadLine();*/

            #endregion

            #region Xuất cộng dồn

            /*Console.WriteLine("2. Huong dan xuat cong don");

            int a = 5;

            // Cách 1:
            Console.Write("a = ");
            Console.WriteLine(a);

            // Cách 2:
            Console.WriteLine("a = " + a);

            // Cách 3:
            Console.WriteLine("a = {0}", a);
            // Ví dụ cho hiểu:
            Console.WriteLine("{0} {1} {2} {3}", 1, 2, 3, 4);

            // Console.ReadLine();*/

            #endregion

            #region Console.Read() 

            // Console.WriteLine(Console.Read());
            // In ra số thứ tự trong bảng mã ASCII từ ký tự bạn nhập vào từ bàn phím
            // (không tính phím chức năng như Ctrl, Alt,.. phím Space thì được nhe)

            // Console.ReadLine();

            #endregion

            #region Console.ReadLine()

            // Console.WriteLine(Console.ReadLine());
            // Quy tắc thực hiện lệnh từ trong ra ngoài
            // Đầu tiên thực hiện lệnh Console.ReadLine() cho phép nhập vào một chuỗi
            // Sau đó ra ngoài thực hiện lệnh Console.WriteLine() là cho phép in chuỗi đó ra (chuỗi được in ra sẽ in ở hàng kế tiếp)


            // Console.ReadKey();

            #endregion

            #region Console.ReadKey()

            /* Console.ReadKey(false); // hiển thị phím được ấn lên màn hình 
             Console.ReadKey(true); // không hiển thị phím được ấn lên màn hình
             Console.ReadKey(); // không truyền tham số thì mặc định là false*/
            // Dùng cho từng ký tự thôi

            #endregion

            #region Ví dụ

            Console.Write("Moi ban nhap ten cua minh: "); // In không xuống dòng
            Console.WriteLine("Ten cua ban la: " + Console.ReadLine());
            // Quy tắc chung trong thực hiện lệnh là lệnh bên trong thực hiện trước rồi đến lệnh bên ngoài chứa nó
            // Do đó chạy đến đây chương trình sẽ thực hiện lệnh Console.ReadLine() trước (là cho nhập 1 chuỗi vào cho đến khi nhấn Enter)
            // Sau đó đến thực hiện cộng dồn chuỗi
            // Cuối cùng là thực hiện lệnh Console.WriteLine() ở ngoài cùng là in những gì ở bên trong nó và xuống hàng

            Console.Write("Moi ban nhap MSSV: ");
            Console.WriteLine("MSSV cua ban la: " + Console.ReadLine());

            Console.Write("Moi ban nhap que quan: ");
            Console.WriteLine("Que quan cua ban la: " + Console.ReadLine());

            #endregion
        }
    }
}
