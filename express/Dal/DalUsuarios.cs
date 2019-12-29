using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB;
using MongoDB.Bson;
using MongoDB.Driver;
using express.Classes;
using express.Modelo;



namespace express.Dal
{
    class DalUsuarios
    {
      public  string mesagem = "";

        MongoClient clint = new MongoClient(Conexao.connectionString);
        private IMongoCollection<modelo_Usuario> usuario;


        public DalUsuarios()
        {
            IMongoDatabase bancodedados = clint.GetDatabase("sistemapro");
            usuario = bancodedados.GetCollection<modelo_Usuario>("Usuarios");
        }

        public void AdiconarUsuario(modelo_Usuario user)
        {
            try
            {
                
             
                modelo_Usuario User = new modelo_Usuario
                {
                 
                    Codigo = user.Codigo,
                    Nome = user.Nome,
                    Email = user.Email,
                    Senha = user.Senha,
                    Tipo = user.Tipo,
                    Foto = user.Foto,
                    Data = user.Data


                };
            usuario.InsertOne(User);
                mesagem = "Cadastro feito com sucesso";
            }
            catch (Exception)
            {
                mesagem = "Erro fazer o cadastro";
                throw;
            }
           
            
        }

        public void ListarUsuarios()
        {
            var usuarios = usuario.AsQueryable<modelo_Usuario>().ToList();
            foreach(var user in usuarios)
            {
              
            }
        }
    }


}
