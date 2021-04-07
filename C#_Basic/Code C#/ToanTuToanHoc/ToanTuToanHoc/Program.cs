using System;

namespace ToanTuToanHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Giải thích rõ về ++ và --
            int i = 3, j = 4;
            Console.WriteLine(i++); // Thực hiện in i ra trước rồi mới cộng i lên 1 đơn vị => i lúc này in ra 3
            Console.WriteLine(++j); // Thực hiện cộng trước rồi mới in j

            Console.WriteLine(i); // lúc này i = 4
            // Phụ thuộc vào vị trí của dấu mà ta sẽ thực hiện tăng (giảm) trước hay sao
            // Tương tự với dấu trừ

            i = j--; // thực hiện gán i cho j sau đó mới giảm j
            Console.WriteLine(i);
            Console.WriteLine(j);

            Console.ReadKey();
        }
    }
}
