using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using MongoDB.Bson;

namespace express.Modelo
{
  public  class modelo_Professor
    {
        private int codigo;
        private string nome_prof;
        private string datanasc_prof;
        private string genero_prof;
        private string numbi_prof;
        private string telefone_prof;
        private string email_prof;
        private string endereco_prof;
        private string discplina_prof;

        [BsonId]
        public ObjectId Id
        {
            get;
            set;

        }
        [BsonElement("Codigo")]
        public int Codigo
        {
            get { return this.codigo; }

            set { this.codigo = value; }

        }

        [BsonElement("nome_prof")]
        public string Nome_Prof
        {
            get { return this.nome_prof; }

            set { this.nome_prof = value; }
        }

        [BsonElement("datanasc_prof")]
        public string Datanasc_Prof
        {
            get { return this.datanasc_prof; }

            set { this.datanasc_prof = value; }
        }

        [BsonElement("genero")]
        public string Genero_Prof
        {
            get { return this.genero_prof; }

            set { this.genero_prof = value; }
        }

        [BsonElement("numbi_prof")]
        public string Numbi_Prof
        {
            get { return this.numbi_prof; }

            set { this.numbi_prof = value; }
        }

        [BsonElement("telefone_prof")]
        public string Telefone_Prof
        {
            get { return this.telefone_prof; }

            set { this.telefone_prof = value; }
        }

        [BsonElement("email_prof")]
        public string Email_Prof
        {
            get { return this.email_prof; }

            set { this.email_prof = value; }
        }

        [BsonElement("endereco_prof")]
        public string Endereco_Prof
        {
            get { return this.endereco_prof; }

            set { this.endereco_prof = value; }
        }

        [BsonElement("discplina_prof")]
        public string Discplina_Prof
        {
            get { return this.discplina_prof; }

            set { this.discplina_prof = value; }
        }

        
    }
}
