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
using express.views;
using MongoDB.Driver;
using express.Dal;

namespace express
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }



        private void btn_Salvar_usuario_Click(object sender, EventArgs e)
        {
            frm_login login = new frm_login();
            login.Show();
            this.Hide();
        }
    }
 }
