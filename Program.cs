using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace desenvolvimento
{
    class Usuario{
        protected int id;
        protected String nome;
        protected String sobrenome;

        public Usuario(int id, string nome, string sobrenome)
        {
            this.id        = id;
            this.nome      = nome;
            this.sobrenome = sobrenome;    
        }
    }

    class Aluno: Usuario{
        private DateTime anoFormacao;
        public Aluno(int id, string nome, string sobrenome, DateTime anoFormacao): base(id, nome, sobrenome){
            this.anoFormacao = anoFormacao;
        }

        public String InfoAluno(){
            return $"Id: {this.id}\n Nome do aluno: {this.nome} {this.sobrenome}\n Ano de Formação: {this.anoFormacao.Date}";
        }
    }

    class Professor: Usuario{
        private Decimal salario;

        public Professor(int id, String nome, string sobrenome, decimal salario): base(id, nome, sobrenome){
            this.salario = salario;
        }

        public String InfoProfessor(){
            return $"Id: {this.id}\n Nome do professor: {this.nome} {this.sobrenome}\n Salário: {this.salario}";
        }
    }

    class Program{
        static void Main(string[] args){
            Aluno aluno1 = new Aluno(1, "João", "Silva", new DateTime(2021,12,1));
            Professor professor1 = new Professor(2, "Paulo", "Souza", 6000);

            Console.WriteLine(aluno1.InfoAluno());
            Console.WriteLine(professor1.InfoProfessor());
            Console.ReadKey();
        }
    }

}