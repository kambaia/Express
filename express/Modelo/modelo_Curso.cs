using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace express.Modelo
{
   public class modelo_Curso
    {
        private int idCurso;
        private string curso;

        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }
        public string Curso
        {
            get { return curso; }
            set { curso = value; }
        }
    }
}
