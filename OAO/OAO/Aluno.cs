using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OAO
{
    public class Aluno : Usuario
    {
        public int Matricula;
        public decimal Media { get; private set; }
        private List<Materia> Materias;


        public Aluno()
        {
   
        }

        public Aluno(string nome)  // :this() faz referencia a classe que vc está :base() passa metodo contrutor
        {
            Nome = nome;
        }

        public void CalcularMedia(decimal nota1, decimal nota2, decimal nota3) 
        {
            decimal total = nota1 + nota2 + nota3;
            Media = total / 3;
        }

        public string AdicionarMateria(Materia materia)
        {
            foreach (Materia mate in Materias)
            {
                if (mate.Nome == materia.Nome)
                    return "Está matéria já existe!";
            }
            Materias.Add(materia);
            return "Matéria adicionada!";
        }
        public override void Logar()
        {
            Console.WriteLine("O aluno logou");
        }
    }
}
