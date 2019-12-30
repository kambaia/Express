using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using express_1.Modelo;
using express_1.Dal;

namespace express_1.views
{
    public partial class frm_AddProfessor : Form
    {
        public frm_AddProfessor()
        {
            InitializeComponent();
        }

        private void btn_Salvar_Prof_Click(object sender, EventArgs e)
        {
            
            Random r = new Random();
            int codigo = r.Next(1000, 9999);

            Dal_Professor addprof = new  Dal_Professor();
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
            addprof.InserirProfessor(c);
            MessageBox.Show(addprof.mensagem);
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

        
    }
}
