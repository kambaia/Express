using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using express.Dal;
using express.Modelo;

namespace express.views
{
    public partial class frm_addProfessor : MetroFramework.Forms.MetroForm
    {
        public frm_addProfessor()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Prof_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int codigo = r.Next(1000, 9999);

            DalProfessor addprof = new DalProfessor();
            modelo_Professor c = new modelo_Professor();

            c.Codigo = codigo;
            c.Nome_Prof = txt_Nome_Prof.Text;
            c.Datanasc_Prof = txt_Nasc_Prof.Text;
            c.Genero_Prof = txt_Genero_Prof.Text;
            c.Numbi_Prof = txt_numBi.Text;
            c.Telefone_Prof = txt_Tel_Prof.Text;
            c.Email_Prof = txt_email.Text;
            c.Endereco_Prof = txt_Endereco.Text;
            c.Discplina_Prof = txt_Disc_Prof.Text;

            MessageBox.Show(addprof.mesagem);
            Limpar();
        }

        private void Limpar()
        {
            txt_Nome_Prof.Text = "";
            txt_Nasc_Prof.Text = "";
            txt_Genero_Prof.Text = "";
            txt_numBi.Text = "";
            txt_Tel_Prof.Text = "";
            txt_email.Text = "";
            txt_Endereco.Text = "";
            txt_Disc_Prof.Text = "";
        }

        private void frm_addProfessor_Load(object sender, EventArgs e)
        {
            modelo_Professor prof = new modelo_Professor();
            frm_addProfessor a = new frm_addProfessor();
        }
    }
}
