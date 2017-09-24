using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 1;
            short b = 1;
            int c = 1;
            long d = 1;
            byte e = 1;
            ushort f = 1;
            ulong g = 1;
            char k = 'f';
            bool t = false;
            float r = 1.1f;
            double o = 1.2;
            decimal p = 128;
            string l = "Hello world";
            object m = c;

            Int32 i32 = 5;
            Int64 i64 = i32;
            Single s = i32;
            Double dob = i32;
            Decimal dec = i32;
            Char chr = 'r';
            Object obj = chr;

            Byte bt = (Byte)i32;
            Int16 vv = (Int16)s;
            Int32 ii32 = (Int32)chr;
            Decimal nt = (Decimal)i32;
            Double dd = (Double)i32;

            int val = 5;
            object obj1 = val;//упаковка
            int valUnboxed = (int)obj1;//распаковка

            var name = "Alex Erohin";

            // Определяем тип переменных
            Type nameType = name.GetType();      

            // Выводим в консоль результаты
            Console.WriteLine("Тип name: {0}", nameType);
            Console.ReadLine();

            int? x1 = null;
            int? x2 = null;
            Console.WriteLine(x1 == x2);

            //Строки
            String string1 = "123345";
            String string2 = "123454";
            Console.WriteLine(string1 == string2);

            //b
            String string3 = "HEllo";
            Console.WriteLine(string1 + string2 + string3);
            string2 = String.Copy(string1);
            Console.WriteLine(string2);

            String name1 = "JAcker";
            String name2 = name1.Substring(2, 2);
            Console.WriteLine(name2);

            string text = "This is a text. New String";
            char[] delims = ".,;:!?\n\xD\xA\' ".ToCharArray();
            string[] words = text.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
                Console.WriteLine(word);

            //вставка подстроки в заданную позицию
            String original = "aaabbb";
            Console.WriteLine("The original string: '{0}'", original);
            String modified = original.Insert(3, " ");
            Console.WriteLine("The modified string: '{0}'", modified);
            //elfktybt gjlcnhjrb
            String rem = original.Remove(1,3);
            Console.WriteLine("Remove: {0}", rem);

            //c
            string pust = "";
            string null1 = null;
            Console.WriteLine("Dlina str0ki: {0}", pust.Length);
            Console.WriteLine(null1 != string3);

            StringBuilder sb = new StringBuilder("strokaBor", 40);
            sb.Append(new char[] { 'D', 'K' });
            sb.Insert(0, "Kyky.org ");
            sb.Remove(3, 1);
            sb.Remove(5, 2);
            Console.WriteLine(sb);

            //Massiv
            int[][] ms = {new int[3] { 1, 2, 3 }, new int[3] { 4, 5, 6 }, new int[3] {3,5,7 } };
            foreach (int[] x in ms)
            {
                foreach(int ss in x)
                Console.Write("\t" + ss);

                Console.WriteLine();

            }


            string[] masstr = new string[] { "Hello", "My", "Friends\n" };
            foreach (string QA in masstr)
                Console.Write("\t" + QA);
            Console.WriteLine("Длина массива {0}", masstr.Length);


            Console.Write($"Введите позицию, до {masstr.Length}: ");
            System.Int32 position;
            position = Int32.Parse(Console.ReadLine());
            Console.WriteLine(position);
            System.String inf;
            Console.Write("Введите элемент:");
            inf = (Console.ReadLine());
            masstr[position] = inf;
            foreach (String i in masstr)
            {
                Console.WriteLine(i);
            }

            //c,d.....

            //c. Создайте ступечатый (не выровненный) массив вещественных чисел с 3-мя строками, в 
            //каждой из которых 2, 3 и 4 столбцов соответственно. Значения массива введите с консоли. 
            double[][] MyArray = new double[3][];
            MyArray[0] = new double[2];
            MyArray[1] = new double[3];
            MyArray[2] = new double[4];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < 2; i++)
            {
                MyArray[0][i] = Double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 3; i++)
            {
                MyArray[1][i] = Double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 4; i++)
            {
                MyArray[2][i] = Double.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ступенчатый массив:");
            foreach (double[] i in MyArray)
            {
                foreach (double j in i)
                {
                    Console.Write("\t" + j);
                }
                Console.WriteLine();
            }
            //d.Создайте неявно типизированные переменные для хранения массива и строки. 
            Console.WriteLine();
            var stroc = "this is string";
            Console.WriteLine();
            var array1 = new[] { 1, 2, 3, 4 };
            Console.WriteLine(stroc);
            foreach (var i in array1)
            {
                Console.Write("\t" + i);
            }
            Console.WriteLine();
            Console.WriteLine();

            //4 korteji
            

            (Int32 num0, String num1, Char num2, String num3, UInt64 num4) tuple = (32, "Слово", 'С', "буква", 4);
            Console.WriteLine($"Kортеж {tuple}");
            Console.WriteLine(tuple.num0 + " " + tuple.num2 + " " + tuple.num3);
            Console.WriteLine(" ");
            var (o1, t1, th, f1, fi) = (tuple);
            Console.WriteLine("Rasp "+ o1 + " " + t1 + " " + th + " " + f1 + " " + fi);
            Console.WriteLine(" ");
            (Int32, String, Char, String, UInt64 ) person = (32, "Слово", 'С', "буква", 4);
            Console.WriteLine("Sravnenie cortegei " + tuple.Equals(person));
            Int32[] ar = { 2, 3, 8, 6, -1, 0, 6 };
            System.String s1 = "Home";
            Console.WriteLine(fun(ar, s1));
            (Int32, Int32, Int32, String) fun(Int32[] number, String name11)
            {
                Int32 max = 0, min = 0, sum = 0;
                for (Int32 i = 0; i < 7; i++)
                {
                    if (max < number[i])
                    {
                        max = number[i];
                    }
                }
                for (Int32 i = 0; i < 7; i++)
                {
                    if (min > ar[i])
                    {
                        min = ar[i];
                    }
                }
                for (Int32 i = 0; i < 7; i++)
                {
                    sum += ar[i];
                }
                System.String b_1 = name11.Substring(0, 1);
                return (max, min, sum, b_1);
            }


        }
    }
}
