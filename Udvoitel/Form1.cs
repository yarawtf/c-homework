using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udvoitel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblCommands.Text = "0";
            lblCommandsText.Text = "Количество отданных команд:";
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            btnReset.Text = "Сброс";
            lblNumber.Text = "0";
            this.Text = "Удвоитель";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) + 1).ToString();
            lblCommands.Text = (int.Parse(lblCommands.Text) + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
            lblCommands.Text = (int.Parse(lblCommands.Text) + 1).ToString();
        }
    
        private void btnReset_Click(object sender, EventArgs e)
        {
            lblNumber.Text = "1";
            lblCommands.Text = "0";
        }

    }
}
