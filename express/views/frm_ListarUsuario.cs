using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using express.Classes;
using MongoDB.Driver;
using express.Modelo;
using System.Linq.Expressions;

namespace express.views
{
    public partial class frm_ListarUsuario : MetroFramework.Forms.MetroForm
    {
        public frm_ListarUsuario()
        {
            InitializeComponent();
        }

        private void frm_ListarUsuario_Load(object sender, EventArgs e)
        {
            ListarUsuarios();
        }
        public void ListarUsuarios()
        {
            MongoClient clint = new MongoClient(Conexao.connectionString);
            IMongoCollection<modelo_Usuario> usuario;

            IMongoDatabase bancodedados = clint.GetDatabase("sistemapro");
            usuario = bancodedados.GetCollection<modelo_Usuario>("Usuarios");
            var usuarios = usuario.AsQueryable<modelo_Usuario>().ToList();
            dataGridView.DataSource = usuarios;


        }
        public void ListarUsuariosId( string chave)
        {
            
            MongoClient clint = new MongoClient(Conexao.connectionString);
            IMongoCollection<modelo_Usuario> usuario;
            IMongoDatabase bancodedados = clint.GetDatabase("sistemapro");
            usuario = bancodedados.GetCollection<modelo_Usuario>("Usuarios");
            var nome = usuario.AsQueryable<modelo_Usuario>().Where(p => p.Nome.Contains(chave)).ToList();
            dataGridView.DataSource = nome;


        }
        public void ListarUsuariosCodigo(int codigo)
        {

            MongoClient clint = new MongoClient(Conexao.connectionString);
            IMongoCollection<modelo_Usuario> usuario;
            IMongoDatabase bancodedados = clint.GetDatabase("sistemapro");
            usuario = bancodedados.GetCollection<modelo_Usuario>("Usuarios");
            var codigo_ = usuario.AsQueryable<modelo_Usuario>().OrderByDescending(p => p.Codigo).ToList();
            dataGridView.DataSource = codigo_;
        }

        public void ListarUsuariosEmail_senha(string email , string senha)
        {
            MongoClient clint = new MongoClient(Conexao.connectionString);
            IMongoCollection<modelo_Usuario> usuario;
            IMongoDatabase bancodedados = clint.GetDatabase("sistemapro");

            usuario = bancodedados.GetCollection<modelo_Usuario>("Usuarios");

            var builder = Builders<modelo_Usuario>.Filter;
            var filtro = (builder.Eq(p => p.Email, email) & builder.Eq(a => a.Senha, senha));
            var clientes = usuario.Find<modelo_Usuario>(filtro).ToList();
            dataGridView.DataSource = clientes;
        }
        private void btn_Salvar_usuario_Click(object sender, EventArgs e)
        {
            frm_addUsuario adduser = new frm_addUsuario();
            adduser.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            if (txtPesquisa.Text == txtPesquisa.Text)
            {
                ListarUsuariosId(txtPesquisa.Text);
            }
            else
            {
                ListarUsuariosCodigo(Convert.ToInt32(txtPesquisa.Text));
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarUsuariosEmail_senha(txtSenha.Text, txtPesquisa.Text);
        }
        public static string nome;
        private void dataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            modelo_Usuario user = new modelo_Usuario();
            user.Nome = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            user.Email = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            user.Senha = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            user.Tipo = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[1].Value.ToString());
            user.Foto = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            frm_addUsuario editaruser = new frm_addUsuario();
            editaruser.Show();
            this.Show();
            MessageBox.Show(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
          
        }
    }
}
