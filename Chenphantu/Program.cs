using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chenphantu
{
    internal class Program
    {
        static void Main(string[] args)
        {// Bước 1: Khai báo và khởi tạo mảng số nguyên gồm N phần tử cho trước
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            List<int> list = new List<int>();

            // Bước 2: Nhập giá trị từng phần tử của danh sách.
            Console.Write("Nhập số lượng phần tử trong danh sách: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập giá trị của phần tử thứ {0 }: ", i+1);
                int value = int.Parse(Console.ReadLine());
                list.Add(value);
            }

            // Bước 3: Nhập X là số cần chèn.
            Console.WriteLine("Nhập giá trị cần chèn (X):");
            int X = int.Parse(Console.ReadLine());

            // Bước 4: Nhập vào vị trí index cần chèn X vào trong mảng.
            Console.WriteLine("Nhập vị trí index:");
            int index = int.Parse(Console.ReadLine());

            // Bước 5: Kiểm tra vị trí index có hợp lệ không.
            if ( index < 1 || index > list.Count)
            {
                Console.WriteLine("Không thể chèn phần tử vào vị trí đã cho.");
            }
            else
            {
                // Bước 6: Thực hiện chèn phần tử X vào danh sách.
                list.Insert(index - 1, X);

                // Bước 7: In ra danh sách sau khi chèn.
                Console.WriteLine("Danh sách sau khi chèn:");
                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine("list[{0}] = {1}", i + 1, list[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
