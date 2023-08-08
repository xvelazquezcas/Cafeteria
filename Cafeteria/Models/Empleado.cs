using Microsoft.AspNetCore.Mvc;

namespace Cafeteria.Models
{
    public class Empleado 
    {
        public int id { get; set; } 
        public string nombre { get; set; }  
        public string apellido { get; set; }
        public string correo { get; set; }
        public string puesto { get; set; }
        public decimal salario { get; set; }

    }
}
