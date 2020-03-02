using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    class Pessoa
    {
        private string Nome;
        private int idade;
        private int id;
        public Pessoa(int id,string nome, int idade)
        {
            this.Nome = nome;
            this.idade = idade;
            this.id=id;
        }
        public int getage()
        {
     
             return idade;
        }
        public string getnome()
        {

            return Nome;
        }
        public int getid()
        {

            return id;
        }
        

    }
}
