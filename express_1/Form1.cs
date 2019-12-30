using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using express_1.views;

namespace express_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void cadastrarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddUsuarios adduser = new frm_AddUsuarios();
            adduser.Show();
            this.Visible = false;
        }

        private void cadastarProfessorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_AddProfessor addprof = new frm_AddProfessor();
            addprof.Show();
            this.Visible = false;
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
