using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using DreamCarsMVC4.Models;

namespace DreamCarsMVC4.Data.Context {

    public class DataContext : DbContext {

        public DataContext() : base("name=DreamCars") { }

        public IDbSet<Manufacturer> Manufacturers { get; set; }
        public IDbSet<Model> Models { get; set; }
        public IDbSet<Engine> Engines { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Model>().Ignore(x => x.EngineLocation);
            modelBuilder.Entity<Model>().HasMany(x => x.AvailableEngines).WithMany(x => x.AvailableOn).Map(x => x.MapLeftKey("ModelId").MapRightKey("EngineId").ToTable("ModelEngine"));
            base.OnModelCreating(modelBuilder);
        }

    }

}