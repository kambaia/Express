using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using express_1.Classes;
using express_1.Modelo;
using MongoDB.Bson;
using MongoDB.Driver;

namespace express_1.Dal
{
    public class Dal_Usuarios
    {
        public string mensagem;
        public void InserirUsuario(modelo_Usuarios usuario)
        {
            var colegio = Conexao.getColecao("Usuarios");

            try
            {
                modelo_Usuarios User = new modelo_Usuarios
                {

                    Codigo = usuario.Codigo,
                    Nome = usuario.Nome,
                    Email = usuario.Email,
                    Senha = usuario.Senha,
                    Tipo = usuario.Tipo,
                    Foto = usuario.Foto,
                    Data = usuario.Data
                };
                colegio.Insert(User);
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
