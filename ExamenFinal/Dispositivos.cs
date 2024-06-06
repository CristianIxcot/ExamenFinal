using System.ComponentModel.DataAnnotations;
namespace ExamenFinal
{
    public class Dispositivos
    {
        [Required(ErrorMessage = "El Numero de serie es un dato requerido")]
        public int NoSerie {  get; set; }
        [Required(ErrorMessage = "La Marca es un dato requerido")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "El Modelo es un dato requerido")]
        public int Modelo { get; set; }

        public Dispositivos() 
        {
            NoSerie  = 0;
            Marca = string.Empty;
            Modelo = 0;
        }
    }
}
