using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PetShop.Model;

namespace PetShop.Data
{
    public class PetShopContext : DbContext
    {
        public PetShopContext (DbContextOptions<PetShopContext> options)
            : base(options)
        {
        }

        public DbSet<PetShop.Model.Cliente> Clientes { get; set; }
        public DbSet<PetShop.Model.Raca> Racas { get; set; }
        public DbSet<PetShop.Model.Animal> Animal { get; set; }
        public DbSet<PetShop.Model.Agendamento> Agendamento { get; set; }
        public DbSet<PetShop.Model.Servico> Servico { get; set; }
        public DbSet<PetShop.Model.Pagamento> Pagamento { get; set; }
        public DbSet<PetShop.Model.Agendamento_servico> Agendamento_servico { get; set; }
    }
}
