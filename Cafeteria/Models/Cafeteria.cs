using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace Cafeteria.Models
{
    public class CafeteriaAlumnoModels
    {
      public int nss { get; set; }  
      public string nombre { get; set; }
      public string apellido { get; set; }
      public string correo { get; set; }
      public string carrera { get; set; }
      public int  semestre { get; set; }    
      public int matricula { get; set; }
        
    }
}
