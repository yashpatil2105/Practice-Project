using Microsoft.EntityFrameworkCore;

using BOL;
namespace DAL;

public class CollectionContext:DbContext{
    public DbSet<Vehicle>? Vehicles {get;set;}
    
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
        string conString="server=localhost;port=3306;user=root;password=yash;database=test";
        optionsBuilder.UseMySQL(conString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder){

        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Vehicle>(entity => {
            entity.HasKey(e => e.Vid);
            entity.Property(e => e.Vname);
            entity.Property(e => e.Price);
            entity.Property(e => e.Descript);
        });
        modelBuilder.Entity<Vehicle>().ToTable("vehicle");

    }

}



