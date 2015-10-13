using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int num1 = 100;
            int num2 = 200;

            num1 = num2;
            num2 = 300;
            Console.WriteLine(num1);
            Console.WriteLine(num2);*/

            /*Point p1 = new Point(100);
            Point p2 = new Point(200);

            p1 = p2;
            p2.x = 300;
            Console.WriteLine(p1.x);
            Console.WriteLine(p2.x);*/

            /*int x = 100;
            int y = 200;
            Switch(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);*/

            /*int number; 
            bool flag = int.TryParse(Console.ReadLine(), out number);
            if (flag == false)
            {
                Console.WriteLine("Число введено неверно");
                Console.WriteLine(number * number);
            }
            else
            {
                Console.WriteLine(number*number);
            }*/
            /*string[] filePaths = Directory.GetFiles(@"C:\Ruby22-x64", "*.dll", SearchOption.AllDirectories);
            for (int i = 0; i < filePaths.Length; i++)
            {
                Console.WriteLine(filePaths[i]);
                Console.WriteLine(File.GetCreationTime(filePaths[i]));

            }*/
            /*DirectoryInfo dir = new DirectoryInfo(@"C:\Ruby22-x64");
            if (dir.Exists)
            {
                FileInfo[] files = dir.GetFiles("*.dll", SearchOption.AllDirectories);
                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(files[i].FullName);
                    Console.WriteLine(files[i].CreationTime);
                    //Console.WriteLine(files[i].Length);
                    Console.WriteLine();
                }
            }*/

            /*FileInfo file1 = new FileInfo(@"C:\Ruby22-x64\1.txt");
            FileInfo file2 = new FileInfo(@"C:\Ruby22-x64\doc\2.txt");
            file1.Create();
            file2.Create();

            FileInfo file3 = new FileInfo(@"C:\Ruby22-x64\Test\1\2\3\4\5\3.txt");
            if (!file3.Directory.Exists)
            {
                file3.Directory.Create();
            }
            file3.Create();

            Directory.CreateDirectory(@"C:\Ruby22-x64\fdbab\sbgbb\sdgbsdgb\dsbsdgb\sdgbsgfb\sfbsfgb");

            string path = @"C:\Ruby22-x64\Test\1\2\3\4\5\3.txt";
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));
            Console.WriteLine(Path.GetExtension(path));*/

            string directory = @"C:\Ruby22-x64\Test\1\2"; //абсолютная адресация
            string temp = "Временная папака";
            string filename = "data.txt";

            string path = directory + "\\" + temp + "\\" + filename;
            //Console.WriteLine(path);

            path = Path.Combine(directory, temp, filename);
            Console.WriteLine(path);

            Directory.CreateDirectory(@"Lesson6\temp\temp1\2\3");

            int[] numbers = new int[5] { 1, 2, 3, 4, 5 };
            //{1, 2, 3, 4, 5, 1, 2, 3, 4, 5}
        }
        static void Switch(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

    }
    class Point
    {
        public int x;
        public Point(int x)
        {
            this.x = x;
        }
    }
}
