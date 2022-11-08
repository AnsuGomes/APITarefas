using Microsoft.EntityFrameworkCore;
using APITarefas.Models;


namespace APITarefas.Context
{
    public class OrganizadorContext : DbContext
    {
        public OrganizadorContext (DbContextOptions<OrganizadorContext> options) : base (options)
        {

        }

        public DbSet<Tarefa> Tarefas { get; set; }
    }
}