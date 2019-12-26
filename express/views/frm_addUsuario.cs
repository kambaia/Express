using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using express.Dal;
using express.Modelo;

namespace express.views
{
    public partial class frm_addUsuario : MetroFramework.Forms.MetroForm
    {
        public frm_addUsuario()
        {
            InitializeComponent();
        }

        private void btn_Salvar_usuario_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int codigo = r.Next(1000, 9999);
            DalUsuarios adduser = new DalUsuarios();
            modelo_Usuario c = new modelo_Usuario();
            c.Codigo = codigo;
            c.Nome = txtNomeUser.Text;
            c.Email = txtEmail.Text;
            c.Senha = txtSenha.Text;
            c.Tipo = Convert.ToInt32(txtNivelAcesso.Text);
            c.Foto = txtURL.Text;
            c.Data = DateTime.Now;
            adduser.AdiconarUsuario(c);
            frm_ListarUsuario listar = new frm_ListarUsuario();
            listar.Show();
            this.Hide();
            
          


            MessageBox.Show(adduser.mesagem);
            LimparCampos();
        }
        public void LimparCampos()
        {
            txtNomeUser.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtNivelAcesso.Text = "";
            txtURL.Text = "";
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialogigm = new OpenFileDialog();
            dialogigm.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|AllFiles(*.*)|*.*";

            if(dialogigm.ShowDialog() == DialogResult.OK)
            {
                string foto = dialogigm.FileName.ToString();
                txtURL.Text = foto;
                pb_FotoUser.ImageLocation = foto;


            }
        }

        private void frm_addUsuario_Load(object sender, EventArgs e)
        {
            modelo_Usuario user = new modelo_Usuario();
            frm_ListarUsuario a = new frm_ListarUsuario();
          
            PriencherOsDados();
        }

        public void PriencherOsDados()
        {
            modelo_Usuario user = new modelo_Usuario();
            txtNomeUser.Text = user.Nome;
            txtEmail.Text = "";
            txtSenha.Text = "";
            txtNivelAcesso.Text = "";
            txtURL.Text = "";
        }


    }
}
