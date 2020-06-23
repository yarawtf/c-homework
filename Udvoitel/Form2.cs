using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Udvoitel
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            var rand = new Random(100);
            lblTask.Text = "Получите данное число как можно меньшим количеством ходов:" + " " + rand.Next(100);
        }

        private void OK_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
