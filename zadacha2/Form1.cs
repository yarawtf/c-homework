using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha2
{
    //Ярослава Раскольникова. 
    //Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток.Компьютер говорит, больше или меньше загаданное число введенного.
    //a) Для ввода данных от человека используется элемент TextBox;

    public partial class Form1 : Form
    {
        Random random = new Random();
        int number;
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            Riddle.Text = "Я загадал число от 1 до 100. Угадывай, кожаный мешок";
            number = random.Next(100);
            lblCounts.Text = "Количество ходов: " + "0";
        }

        
        private void textBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void OK_Click(object sender, EventArgs e) 
        {
            try
            {

                if (int.Parse(textBox.Text) == number)
                    Riddle.Text = "Молодец";
                else if (int.Parse(textBox.Text) > number)
                    Riddle.Text = "Бери ниже";
                else if (int.Parse(textBox.Text) < number)
                    Riddle.Text = "Бери выше";
            }
            catch
            {

            }
            count++;
            lblCounts.Text = "Количество попыток: " + Convert.ToString(count);
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
