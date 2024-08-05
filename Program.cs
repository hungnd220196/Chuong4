
using System.Text;
namespace Chuong4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /*
             * Nhập vào 1  mảng số nguyên N
             * tìm max, min trong dãy số đó 
             */

            //Console.WriteLine("nhập số phần tử trong mảng ");
            //int n = int.Parse(Console.ReadLine());
            //int[] array = new int[n];
            //int max,min;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine($"Nhập phần tử thứ {i+1}");
            //    array[i] = int.Parse(Console.ReadLine());
            //}
            //max = array[0];
            //min = array[0];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (array[i]>max)
            //    {
            //        max = array[i];
            //    }
            //    if (array[i]<min)
            //    {
            //        min = array[i];
            //    }
            //}
            //Console.WriteLine($"phần tử  lớn nhất trong mảng là: {max}");
            //Console.WriteLine($"phần tử  nhỏ nhất trong mảng là: {min}");


            //char ch = '8';
            //char check = ' ';
            //Console.WriteLine(Char.IsWhiteSpace(check));

            //string s = @"D:\AI\C#\Slides\Bai10.ppt";
            ////cat lay ten file trong duong dan tren
            //string fileName = s.Substring(s.LastIndexOf('\\') + 1);
            //Console.Write("Ten file:" + fileName);
            //Console.ReadLine();

            //string str = "How to find a substring in a string";
            //Console.WriteLine("srt length" + str.Length);
            //int startIndex = 7;
            //int endIndex = str.Length - 7;
            //string title = str.Substring(startIndex, endIndex);
            //Console.WriteLine(title);



            //b1

            //Console.WriteLine("Nhập số nguyên thập phân: ");
            //int decimalNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine(decimalNumber);
            //string binaryNumber = Convert.ToString(decimalNumber, 2);
            //Console.WriteLine($"Hệ nhị phân: {binaryNumber}");

            //b2
            //Console.WriteLine("Nhập số KW tiêu thụ: ");
            //int consumption = int.Parse(Console.ReadLine());
            //int totalPrice;
            //if (consumption <= 100)
            //{
            //    totalPrice = consumption * 500;
            //}
            //else if (consumption <= 150)
            //{
            //    totalPrice = 100 * 500 + (consumption - 100) * 550;
            //}
            //else if (consumption <= 200)
            //{
            //    totalPrice = 100 * 500 + 50 * 550 + (consumption - 150) * 600;
            //}
            //else
            //{
            //    totalPrice = 100 * 500 + 50 * 550 + 50 * 600 + (consumption - 200) * 650;
            //}
            //Console.WriteLine($"Tổng tiền điện: {totalPrice} đồng");

            // dùng for

            Console.WriteLine("Nhập số KW tiêu thụ: ");
            int consumption = int.Parse(Console.ReadLine());
            int totalPrice = 0;

            int[] thresholds = { 100, 50, 50, int.MaxValue };
            int[] rates = { 500, 550, 600, 650 };

            for (int i = 0; i < thresholds.Length; i++)
            {
                int currentConsumption = Math.Min(consumption, thresholds[i]);
                totalPrice += currentConsumption * rates[i];
                consumption -= currentConsumption;

                if (consumption <= 0)
                    break;
            }

            Console.WriteLine($"Tổng tiền điện: {totalPrice} đồng");


            //    //b3
            //double[] a = { 1.2, 9.6, 5.6 };
            //double[] b = { 7.8, 8.9, 6.9 };

            //double[] c = new double[a.Length + b.Length];
            //Array.Copy(a, c, a.Length);
            //Array.Copy(b, 0, c, a.Length, b.Length);
            //Array.Sort(c);

            //Console.WriteLine("Mảng sau khi hợp nhất và sắp xếp: ");
            //foreach (var num in c)
            //{
            //    Console.Write(num + ", ");
            //}


            //    //b4
            //string str = " Trần Hưng   Đạo ";
            //string noExtraSpaces = System.Text.RegularExpressions.Regex.Replace(str, @"\s+", " ");  
            //Console.WriteLine($"Chuỗi sau khi xử lý: {noExtraSpaces}");

            //    //b5

            //double[,] matrix = {
            //    { 1, 2, 3 },
            //    { 0, 1, 4 },
            //    { 5, 6, 0 }
            //};

            ////-24     18      5
            //// 20   - 15    - 4
            ////- 5      4      1

            //int n = matrix.GetLength(0);
            //double[,] augmentedMatrix = new double[n, n * 2];

            //// Tạo ma trận bổ sung (gồm ma trận gốc và ma trận đơn vị)
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        augmentedMatrix[i, j] = matrix[i, j];
            //    }
            //    augmentedMatrix[i, i + n] = 1;
            //}

            //// Áp dụng phương pháp Gauss-Jordan
            //for (int i = 0; i < n; i++)
            //{
            //    double pivot = augmentedMatrix[i, i];
            //    for (int j = 0; j < n * 2; j++)
            //    {
            //        augmentedMatrix[i, j] /= pivot;
            //    }

            //    for (int k = 0; k < n; k++)
            //    {
            //        if (k != i)
            //        {
            //            double factor = augmentedMatrix[k, i];
            //            for (int j = 0; j < n * 2; j++)
            //            {
            //                augmentedMatrix[k, j] -= factor * augmentedMatrix[i, j];
            //            }
            //        }
            //    }
            //}

            //// Tách ma trận nghịch đảo
            //double[,] inverseMatrix = new double[n, n];
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        inverseMatrix[i, j] = augmentedMatrix[i, j + n];
            //    }
            //}

            //Console.WriteLine("Ma trận nghịch đảo:");
            //for (int i = 0; i < inverseMatrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < inverseMatrix.GetLength(1); j++)
            //    {
            //        Console.Write(inverseMatrix[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Test test = new Test("Hung", 28, "H@gmail.com");
            //string kq = test.name;
            //Console.WriteLine(kq);
        }

    }
}
