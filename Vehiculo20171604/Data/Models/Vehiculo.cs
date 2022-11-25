namespace Vehiculo20171604.Data.Models;
using System.ComponentModel.DataAnnotations;
public class Vehiculo
{[Key]
   public int Id { get; set; } 
    public VehiculoModelo? Modelo { get; set; }
    public int Año { get; set; }
}

public class VehiculoMarca
{
    public int Id { get; set; } 
    public string Nombre { get; set; } = null!;
}

public class VehiculoModelo
{
    public int Id { get; set; } 
    public int MarcaId { get; set; } 
    public virtual VehiculoMarca? Marca { get; set; }
    public string Nombre { get; set; }= null!;
}

