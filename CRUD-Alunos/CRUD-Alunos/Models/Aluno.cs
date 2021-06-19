using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Alunos.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public DateTime DataRegistro { get; set; }
    }
}
