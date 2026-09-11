using MerceariaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace MerceariaMVC.Data
{
    public class MerceariaMVCContext:DbContext
    {
        public MerceariaMVCContext(DbContextOptions<MerceariaMVCContext>options):base(options) 
        {
            
        }
        public DbSet<Produto> Produtos {  get; set; }

        public DbSet<Cliente> clientes { get; set; }
      
    }
}
