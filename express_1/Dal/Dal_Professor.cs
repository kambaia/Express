using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using express_1.Classes;
using express_1.Modelo;

namespace express_1.Dal
{
  public  class Dal_Professor
    {
        public string mensagem;
        public void InserirProfessor(modelo_Professor prof)
        {
            var colecao = Conexao.getColecao("Professores");

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
                colecao.Insert(Prof);
                mensagem = "Cadastro feito com sucesso";
            }
            catch (Exception)
            {
                mensagem = "Erro fazer o cadastro";
                throw;
            }

        }
   }
}
