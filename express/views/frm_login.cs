using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;
using express.Classes;
using express.Modelo;

namespace express.views
{
    public partial class frm_login : MetroFramework.Forms.MetroForm
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void btn_Salvar_usuario_Click(object sender, EventArgs e)
        {
            MongoClient clint = new MongoClient(Conexao.connectionString);
            IMongoCollection<modelo_Usuario> usuario;
            IMongoDatabase bancodedados = clint.GetDatabase("sistemapro");

            usuario = bancodedados.GetCollection<modelo_Usuario>("Usuarios");

            var builder = Builders<modelo_Usuario>.Filter;
            var filtro = (builder.Eq(p => p.Email, txtEmail.Text) & builder.Eq(a => a.Senha, txtSenha.Text));
            var clientes = usuario.Find<modelo_Usuario>(filtro).ToList();

            if (clientes.Count > 0)
            {
                clientes.ForEach(a =>
                {
                    if (txtEmail.Text == a.Email  && a.Tipo == 2)
                    {
                        MessageBox.Show("Oba! Achamos você");
                        frm_main main = new frm_main();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("OPS! Você está cadastrardo mais o seu nivel de acesso não é este!");
                    }

                });
            }
            else
            {
                MessageBox.Show("OPS! Você não está Cadastrado");
            }
            /*
          
            */
        }

        public void ListarUsuariosEmail_senha(string email, string senha)
        {
            
        }
    }
}
