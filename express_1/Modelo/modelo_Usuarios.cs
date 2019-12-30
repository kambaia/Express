using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace express_1.Modelo
{
  public  class modelo_Usuarios
    {

        private string nome;
        private string senha;
        private string tipo;
        private string email;
        private string foto;
        private int codigo;


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


        [BsonElement("nome")]
        public string Nome
        {
            get { return this.nome; }

            set { this.nome = value; }
        }


        [BsonElement("email")]
        public string Email
        {
            get { return this.email; }

            set { this.email = value; }
        }


        [BsonElement("senha")]
        public string Senha
        {
            get { return this.senha; }

            set { this.senha = value; }
        }


        [BsonElement("Tipo")]
        public string Tipo
        {
            get { return this.tipo; }

            set { this.tipo = value; }
        }


        [BsonElement("foto")]
        public string Foto
        {
            get { return this.foto; }

            set { this.foto = value; }
        }


        [BsonElement("data")]
        public DateTime Data
        {
            get;
            set;
        }
    }
}
