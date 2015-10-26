//#define TRIAL
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson10_Form
{
    public partial class Form1 : Form
    {
        [Obsolete("Новый метод Sum(double, double)" /*, true*/)]
        private static int Sum(int a, int b)
        {
            return a + b;
        }

        private double Sum(double a, double b)
        {
            return a + b;
        }

        [Conditional("DEBUG")]
        private void ShowProgInfo()
        {
            MessageBox.Show("Приложение калькулятор версия 1.1");
        }

        public Form1()
        {
            InitializeComponent();
            ShowProgInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
#if TRIAL
            Random rnd = new Random();
            textBox3.Text = rnd.Next(68584161).ToString();
            MessageBox.Show("Купите полную версию приложения!");
#else
//#error Недописал проверки
//#warning Недописал проверки
            //TODO Недописал проверки
            int x = int.Parse(textBox1.Text);
            int y = int.Parse(textBox2.Text);
            int s = Sum(10, 15);

            string str = "";
            str = comboBox1.SelectedItem.ToString();
            switch (str)
            {
                case "Сложить":
                    textBox3.Text = (x + y).ToString();
                    break;
                case "Вычесть":
                    textBox3.Text = (x - y).ToString();
                    break;
            }

            
#endif
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Сложить");
            comboBox1.Items.Add("Вычесть");
            comboBox1.Items.Add("Умножить");
            comboBox1.Items.Add("Разделить");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*var _tb = (TextBox)sender;
            _tb.Text = "894631264312";*/

        }

        /*
         *  абстрактный базовый класс "Млекопитающее"
         *  от него наследуются 2-3 класса конкретных видов, пр., "Лев", "Собака"...
         *  информация о каждом объекте: поля: имя, вид животного, возраст;
         *  
         * необходимо создать приложение WindowsForms, которео позволит:
         * 1) Создать коллекцию, в которую будут входить несколько разных животных (экземпляров классов);
         * 2) Сериализовать данную коллекцию (XML)
         */

        //запрет ввода букв и прочих символов, не являющихся цифрами
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
