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
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using express_1.Classes;
using express_1.Dal;
using express_1.Modelo;

namespace express_1.views
{
    public partial class frm_AddUsuarios : Form
    {
        public frm_AddUsuarios()
        {
            InitializeComponent();
         
        }
        MongoDatabase db = new MongoClient("mongodb://localhost:27017").GetServer().GetDatabase("sistemapro");
        string ID;
        private void frm_AddUsuarios_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }
        private void btn_Salvar_usuario_Click(object sender, EventArgs e)
        {
            Random r = new Random();

            int codigo = r.Next(108, 999999);
            Dal_Usuarios adduser = new Dal_Usuarios();
            modelo_Usuarios c = new modelo_Usuarios();
            c.Codigo = codigo;
            c.Nome = txtNomeUser.Text;
            c.Email = txtEmail.Text;
            c.Senha = txtSenha.Text;
            c.Tipo = combNivelAcesso.Text;
            c.Foto = txtURL.Text;
            c.Data = DateTime.Now;
            adduser.InserirUsuario(c);
            MessageBox.Show(adduser.mensagem);
            CarregarDados();
            LimparCampos();
        }
        public void LimparCampos()
        {
            txtNomeUser.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            combNivelAcesso.Text = "";
            txtURL.Text = "";
        }

        public void CarregarDados()
        {
            var  colecao = Conexao.getColecao("Usuarios");
            var usurios = colecao.FindAllAs<modelo_Usuarios>().ToList<modelo_Usuarios>();
            dtVisual.DataSource = usurios;
        }
        private string PegarId()
        {
            return Convert.ToString(dtVisual.CurrentRow.Cells[0].Value);
        }
        private void dtVisual_DoubleClick(object sender, EventArgs e)
        {
            string id = PegarId();
            MessageBox.Show(id);
            var filtro = Query.EQ("_id", ObjectId.Parse(id));
            var usurios = db.GetCollection<modelo_Usuarios>("Usuarios").Find(filtro);

            foreach(var user in usurios)
            {
                txtNomeUser.Text = user.Nome;
                txtEmail.Text = user.Email;
                txtSenha.Text = user.Senha;
                combNivelAcesso.Text = user.Tipo;
                txtURL.Text = user.Foto;
            }
            ID = id;

        }

        private void btn_Voltar_Prof_Click(object sender, EventArgs e)
        {
            var colecao = Conexao.getColecao("Usuarios");

            var filtro = new QueryDocument {

                  { "_id", ObjectId.Parse(ID)}
                };
            var update = new UpdateDocument {
                  { "$set", new UpdateDocument {
                      {"nome" ,  txtNomeUser.Text},
                      {"email" , txtEmail.Text},
                      {"senha" , txtSenha.Text},
                      {"Tipo" ,   combNivelAcesso.Text},
                      {"foto" , txtURL.Text}
                  }
                }
           };
            colecao.Update(filtro, update);
            CarregarDados();
          
            MessageBox.Show(ID);
        }

        private void btn_Limpar_Prof_Click(object sender, EventArgs e)
        {
            var colecao = Conexao.getColecao("Usuarios");
            string id = PegarId();
            var filtro = Query.EQ("_id", ObjectId.Parse(id));
            colecao.Remove(filtro);
            CarregarDados();
        }
    }
    
}
