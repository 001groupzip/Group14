using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson10_Ser
{
    class Program
    {
        //https://www.liqpay.com/exchanges/exchanges.cgi
        static void Main(string[] args)
        {
            /*Point p1 = new Point(10, 15, "Первая точка");

            XMLSerialization(p1);*/

            /*Point p = XMLDeSerialization();
            p.Print();*/


            Random rnd = new Random();
            List<Point> points = new List<Point>();
            for (int i = 0; i < rnd.Next(5, 20); i++)
            {
                Point p = new Point(rnd.Next(-100, 101), rnd.Next(-100, 100), " Точка_" + i.ToString());
                points.Add(p);
            }
            XMLSerialization(points);


            points = XMLDeSerialization();
            foreach (Point item in points)
            {
                item.Print();
                Console.WriteLine();
            }
        }

        static List<Point> XMLDeSerialization()
        {
            FileStream stream = new FileStream("data.xml", FileMode.Open, FileAccess.Read);

            List<Point> p = new List<Point>();
            XmlSerializer serializer = new XmlSerializer(p.GetType());
            p = (List<Point>)serializer.Deserialize(stream);
            stream.Close();
            return p;
        }

        static void XMLSerialization(List<Point> p)
        {
            FileStream stream = new FileStream("data.xml", FileMode.Create, FileAccess.Write);

            XmlSerializer serializer = new XmlSerializer(p.GetType());
            serializer.Serialize(stream, p);
            stream.Close();
        }

        static void BinarySerialization(Point p)
        {
            FileStream stream = new FileStream("data.bin", FileMode.Create, FileAccess.Write);

            BinaryFormatter format = new BinaryFormatter();
            format.Serialize(stream, p);
            stream.Close();
        }

        static Point BinaryDeSerialization()
        {
            FileStream stream = new FileStream("data.bin", FileMode.Open, FileAccess.Read);

            BinaryFormatter format = new BinaryFormatter();
            Point p = (Point)format.Deserialize(stream);
            stream.Close();
            return p;
        }
    }

    [Serializable]
    public class Point
    {
        public int x;
        public int y;
        public string label;

        public Point(int x, int y, string label)
        {
            this.x = x;
            this.y = y;
            this.label = label;
        }

        public Point()
        {   }

        public void Print()
        {
            Console.WriteLine("label - {0}\nx - {1}\ny - {2}", label, x, y);
        }
    }
}
