using System.ComponentModel.DataAnnotations;

namespace Deneme11.Models.Siniflar
{
    public class İkonlar
    {
       [Key]
        public int id { get; set; }
        public string ikon { get; set; }
        public string link { get; set; }

    }
}