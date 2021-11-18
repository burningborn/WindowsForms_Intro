using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Intro
{
    public partial class FirstProgram : Form
    {
        public FirstProgram()
        {
            InitializeComponent();
        }

        private void FirstProgram_Load(object sender, EventArgs e)
        {
            
        }

        private void FirstProgram_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult reasult = MessageBox.Show("Вы действительно хотите выйти?",
                "Выход из приложения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            

        }
     
        private void Surprise_Click(object sender, EventArgs e)
        {
            JackDaniels.Text = "Fanta";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
