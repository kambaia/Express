using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace express.Modelo
{
  public class modelo_Disciplina
    {
        private int idDisciplina;
        private string disciplina;

        public int IdDisciplina
        {
            get { return idDisciplina; }
            set { this.idDisciplina = value; }
        }
        public string Disciplina
        {
            get { return disciplina; }
            set { this.disciplina = value; }
        }
    }
}
