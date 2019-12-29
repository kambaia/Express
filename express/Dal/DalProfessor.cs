using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using express.Classes;
using express.Modelo;

namespace express.Dal
{
    class DalProfessor
    {
        public string mesagem = "";

        MongoClient clint = new MongoClient(Conexao.connectionString);
        private IMongoCollection<modelo_Professor> professor;


        public DalProfessor()
        {
            IMongoDatabase bancodedados = clint.GetDatabase("sistemapro");
            professor = bancodedados.GetCollection<modelo_Professor>("Professor");
        }

        public void AdiconarUsuario(modelo_Professor prof)
        {
            try
            {


                modelo_Professor Prof = new modelo_Professor
                {

                    Codigo = prof.Codigo,
                    Nome_Prof = prof.Nome_Prof,
                    Datanasc_Prof = prof.Datanasc_Prof,
                    Genero_Prof = prof.Genero_Prof,
                    Numbi_Prof = prof.Numbi_Prof,
                    Telefone_Prof = prof.Telefone_Prof,
                    Email_Prof = prof.Email_Prof,
                    Endereco_Prof = prof.Endereco_Prof,
                    Discplina_Prof = prof.Discplina_Prof

                    


                };
                professor.InsertOne(Prof);
                mesagem = "Cadastro feito com sucesso";
            }
            catch (Exception)
            {
                mesagem = "Erro fazer o cadastro";
                throw;
            }


        }

        public void ListarProfessor()
        {
            var professores = professor.AsQueryable<modelo_Professor>().ToList();
            foreach (var prof in professores)
            {

            }
        }
    }
}

