using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace express.views
{
    public partial class frm_main : MetroFramework.Forms.MetroForm
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_addUsuario adduser = new frm_addUsuario();
            adduser.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm_ListarUsuario listar = new frm_ListarUsuario();
            listar.Show();
            this.Hide();
        }

        private void btn_professor_Click(object sender, EventArgs e)
        {
            frm_addProfessor prof = new frm_addProfessor();
            prof.Show();
            this.Hide();
        }
    }
}
