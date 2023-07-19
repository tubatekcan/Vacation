using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Vacation.Models
{
    public class Slide

    {
        public int ID { get; set; }//ID id Id

        [Column(TypeName = "varchar(50)"), StringLength(50), Display(Name = "Slayt Adı"), Required(ErrorMessage = "Slayt adı girilmesi zorunlu")]
        public string Name { get; set; }//Nvarchar(Max)

        [Column(TypeName = "varchar(100)"), StringLength(100), Display(Name = "Slayt Açıklaması")]
        public string Description { get; set; }

        [Column(TypeName = "varchar(150)"), StringLength(150), Display(Name = "Slayt Linki")]
        public string Link { get; set; }

        [Column(TypeName = "decimal(18,2)"), Display(Name = "Nüfusu")]
        public decimal Population { get; set; }

        [Column(TypeName = "decimal(18,2)"), Display(Name = "Alan")]
        public decimal Territory { get; set; }

        [Column(TypeName = "decimal(18,2)"), Display(Name = "Ortalama Fiyatı")]
        public decimal AVGPrice { get; set; }

        [Column(TypeName = "varchar(150)"), Display(Name = "Resim Linki")]
        public string Pitcure { get; set; }

    }
}
