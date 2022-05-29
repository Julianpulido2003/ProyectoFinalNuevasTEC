using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Clase3CorteBlazor.Data
{
    public class Proveedor
    {
        [Key]

        public int idproveedor { get; set; }
        public string identificacion{ get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }        
    }
}
