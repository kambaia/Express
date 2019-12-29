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

namespace express.views
{
    public partial class frm_ListarProfessor : MetroFramework.Forms.MetroForm
    {
        public frm_ListarProfessor()
        {
            InitializeComponent();
            ListarUsuarios();
        }

        public void ListarUsuarios()
        {
            MongoClient clint = new MongoClient(Conexao.connectionString);
            IMongoCollection<modelo_Professor> professor;

            IMongoDatabase bancodedados = clint.GetDatabase("sistemapro");
            professor = bancodedados.GetCollection<modelo_Professor>("Professor");

            var professores = professor.AsQueryable<modelo_Professor>().ToList();
            dataGridView.DataSource = professores;


        }
    }
}
