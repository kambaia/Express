using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace express.Modelo
{
   public class modelo_Aluno { 
        
        private int id_aluno;
        private string nome_aluno;
        private string tipo;
        private string classe_aluno;
        private string turno;
        private string nome_mae;
        private string nome_pai;
        private string telefone_aluno;
        


            public int Id_aluno
            {
                get { return id_aluno; }
                set { id_aluno = value; }
            }
/***********************/
            public string Nome_aluno
            {
                get { return this.nome_aluno; }
                set { this.nome_aluno = value; }
            }
        /***********************/
        public string Nome_mae
            {
                get { return this.nome_mae; }
                set { this.nome_mae = value; }
            }
        /***********************/
        public string Nome_Pai
        {
            get { return this.nome_pai; }
            set { this.nome_pai = value; }
        }
        /***********************/

        public string Classe_aluno
            {
                get { return this.classe_aluno; }
                set { this.classe_aluno = value; }
            }

        /***********************/

        public string Turno
        {
            get { return this.turno; }
            set { this.turno = value; }
        }
        /***********************/
        public string Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }
        /***********************/
        public string Telefone_aluno
        {
            get { return this.telefone_aluno; }
            set { this.telefone_aluno = value; }
        }

    }
    
}
