//Classe de banco de dados
using Microsoft.EntityFrameworkCore;
using WebMvcMysql.Models;

namespace WebMvcMysql.Data
{
    public class Contexto : DbContext
    {
        //criando construtor

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Usuario> Usuario { get; set; }   
    } 
}
