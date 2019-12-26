using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace express.Modelo
{
   public class modelo_NivelAcesso
    {
        private int idNivelAcesso;
        private string nivel_user;
        public string mesangem;

        public int IdNivelAcesso
        {

            get { return this.idNivelAcesso; }
            set { this.idNivelAcesso = value; }
        }
        public string Nivel_user
        {

            get { return this.nivel_user; }
            set { this.nivel_user = value; }
        }

    }
}
