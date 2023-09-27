//Практическая работа номер четыре                //
//Выполнил Мелехов И.В.                          //
//Тема "Высокоуровневые языки программирования" //
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа номер 4";
            Double m, n, x;
            Double v1, v2, v3, v4, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24;
            Console.WriteLine("Здравтвуйте !");
            Console.Write("Введите m= ");
            m = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите n= ");
            n = Convert.ToDouble(Console.ReadLine());
            v1 = m * n;
            v2 = Math.Pow(v1, 2);
            v3 = Math.Pow(v2, 1.0 / 3);
            v4 = Math.Pow(m, 2);
            v5 = v4 * n;
            v6 = Math.Pow(v5, 1.0 / 3);
            v7 = v6 + v3; //r
            v8 = Math.Pow(v4, 1.0 / 3);
            v9 = Math.Pow(v1, 1.0 / 3);
            v10 = v9 * 2;
            v11 = Math.Pow(n, 2);
            v12 = Math.Pow(v11, 1.0 / 3);
            v13 = v12 + v10 + v8; //r
            v14 = v7 / v13; //r
            v15 = Math.Pow(n, 1.0 / 3);
            v16 = v15 * 2;//r 
            v17 = Math.Abs(m - n);
            v18 = v8 - v12;
            v19 = v17 / v18;//r
            v20 = v14 - v16 + v19; //1
            v21 = Math.Pow(m, 1.0 / 6);
            v22 = Math.Pow(n, 1.0 / 6);
            v23 = v21 + v22;
            v24 = 1 / v23;
            x = v20 * v24;
            Console.WriteLine($"Результат: x= {x}");
            Console.ReadKey();
        }
    }
}
