using Microsoft.AspNetCore.Mvc;

namespace Cafeteria.Models
{
    public class Menu
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal precio { get; set; } 
    }
        
}
