using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class utilizador
    {
        public string nome;
        public string password;
        public string perfil;
       
        // Construtort vazio
        public utilizador()
        {

        }

        public utilizador(string nome, string password, string perfil)
        {         // construtor com inicialização da instância do objeto
            this.nome = nome;
            this.password = password;
            this.perfil = perfil;
            
        }

        // métodos acessores: Acesso aos atributos / propriedades do objeto
        // get:  retornar dados do atributo
        // set: modificar dados do atributo
        public void setNome(string nome)
        {
            this.nome= nome;
        }

        public string getNome()
        {
            return this.nome;
        }

        public void setPassword(string password)
        {
            this.password = password;
        }

        public string getPassword()
        {
            return this.password;
        }



    }
}
