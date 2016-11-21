using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class Parcial1Db : DbContext
    {
        public Parcial1Db() : base("name=ConStr")
        {

        }

        public virtual DbSet<Clientes> Clientes { get; set; }
        public virtual DbSet<TiposTelefonos> TipoTelefonos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TiposTelefonos>()
                .HasMany<Clientes>(tp => tp.Clientes)
                .WithMany(c => c.TipoTelefono)
                .Map(ct =>
                {
                    ct.MapLeftKey("ClienteId");
                    ct.MapRightKey("TelefonoId");
                    ct.ToTable("ClientesTelefonos");
                });
        }
    }
}
