using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_Alunos.Models;

    public class AlunosContext : DbContext
    {
        public AlunosContext (DbContextOptions<AlunosContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Aluno { get; set; }
    }
