using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace express.Modelo
{
  public  class modelo_Professor
    {
        private int id_prof;
        private string idCurso;
        private string discplina_prof;

        public int Id_prof
        {
            get { return id_prof; }
            set { id_prof = value; }
        }






        public string IdCurso
        {
            get { return this.idCurso; }
            set { this.idCurso = value; }
        }


        public string Disciplina_prof
        {
            get { return this.discplina_prof; }
            set { this.discplina_prof = value; }
        }
    }
}
