using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Models
{

    //ShopContesxt extende da classe DbContext do Entity Framework Core
    public class ShopContext : DbContext
    {
        //os parametros do construtor fornecem informações de configuração para a conexão com o banco de dados.
        public ShopContext(DbContextOptions<ShopContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            //c: Parâmetro do método que representa uma instância da entidade Category.
            //a: Parâmetro do método que representa uma instância da entidade Product.
            modelBuilder.Entity<Category>()
                //uma categoria pode ter varios produtos
                .HasMany(c => c.Products)
                //um produto pode ter apenas uma categoria
                .WithOne(a => a.Category)
                //a chave estrangeira é CategoryId
                .HasForeignKey(a => a.CategoryId);

            modelBuilder.Seed();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

    

}
