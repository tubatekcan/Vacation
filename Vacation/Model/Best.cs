using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Vacation.model
{
    public class Best
    {
        public int ID { get; set; }

        [Column(TypeName = "varchar(30)"), StringLength(30), Display(Name = "Şehir Adı"), Required(ErrorMessage = "Adı girilmesi zorunlu")]

        public string Name { get; set; }

        [Column(TypeName = "varchar(8)"), StringLength(8), Display(Name = "Nüfus"), Required(ErrorMessage = "Nüfus girilmesi zorunlu")]
        public int Population { get; set; }

        [Column(TypeName = "varchar(150)"), StringLength(150), Display(Name = "Resim"), Required(ErrorMessage = "Resim girilmesi zorunlu")]

        public string Pitcure { get; set; }

    }
}
