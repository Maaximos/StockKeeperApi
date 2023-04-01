using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.EntityFrameworkCore;
using StockKeeperApi.Domain.Entities;

namespace StockKeeperApi.Infra.Data.Configurations
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions options) : base(options) { }

        //Aqui falamos ao framwork quais tabelas ele deve gerencial
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<UsuarioSistemaEstoque> UsuarioSistemaEstoque { get; set; }
        public DbSet<SistemaEstoque> SistemaEstoque { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }



    }
}
