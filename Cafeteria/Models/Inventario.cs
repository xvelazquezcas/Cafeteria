using Microsoft.AspNetCore.Mvc;

namespace Cafeteria.Models
{
    public class Inventario 
    {
       public int id { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }

    }
}
