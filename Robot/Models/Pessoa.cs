using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Robot.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public Pessoa()
        {

        }

        public void RegistrarAniversario()
        {
            Idade++;
        }

    }
}