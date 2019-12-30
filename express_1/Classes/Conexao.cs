using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace express_1.Classes
{
  public  class Conexao
    {
        public static MongoCollection getColecao(string nomeColecao)
        {
            var con = "mongodb://localhost:27017";
            var mongoClient = new MongoClient(con);
            var server = mongoClient.GetServer();
            var db = server.GetDatabase("sistemapro");
            var colecao = db.GetCollection(nomeColecao);
            return colecao;
        }
    }
}
