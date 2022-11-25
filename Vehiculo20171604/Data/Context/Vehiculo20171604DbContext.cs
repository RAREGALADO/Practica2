using Vehiculo20171604.Data.Models;
using Microsoft.EntityFrameworkCore;
namespace Vehiculo20171604.Data.Context;
public class Vehiculo20171604DbContext:DbContext{
    public Vehiculo20171604DbContext(DbContextOptions options):base(options){
        
    }
    public virtual DbSet<Vehiculo> Productos {get; set;} = null!;
}
public interface Vehiculo20171604{
    public DbSet<Vehiculo> Productos {get; set;}  
}