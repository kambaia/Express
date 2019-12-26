using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace express.Modelo
{
   public class modelo_Pessoa
    {

        public String Mensagem = "";
        private string nome;
        private string numero_bi;
        private DateTime data_nascimento;
        private string foto;
        private int idade;
        private string nacionalidade;
        private string sexo;
        private String provincia;
        private String bairro;
        private String rua;
        private String unitel;
        private String movicel;
        private String email;
        public string Nome
        {

            get { return nome; }
            set
            {
                if (value.Length > 3)
                {
                    nome = value;
                }
                else
                {
                    Mensagem = "O Nome não pode ser menor que 3 caracter";
                }
            }
        }
        public string NumeroBI
        {

            get { return numero_bi; }
            set
            {
                if (value.Length <= 12 && value.Length < 0)
                {
                    numero_bi = value;
                }
                else
                {
                    Mensagem = "Número do BI Inválido";
                }
            }

        }
        public DateTime Data_Nas
        {

            get { return data_nascimento; }
            set
            {
                data_nascimento = value;
            }

        }
        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public string Nacionalidade
        {
            get { return nacionalidade; }
            set { nacionalidade = value; }
        }
        public string Sexo
        {
            get { return sexo; }

            set
            {
                if (value == "Masculino" || value == "Femenino")
                {
                    sexo = value;
                }
                else { Mensagem = "Genero Inválido"; }

            }

        }

        public String Provincia
        {
            get { return this.provincia; }
            set { this.provincia = value; }
        }

        public String Bairro
        {
            get { return this.bairro; }
            set { this.bairro = value; }
        }

        public String Rua
        {
            get { return this.rua; }
            set { this.rua = value; }
        }



        public String Unitel
        {
            get { return this.unitel; }
            set { this.unitel = value; }
        }
        public string Movicel
        {
            get { return this.movicel; }
            set { this.movicel = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

    }
}
