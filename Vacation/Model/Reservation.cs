using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vacation.Models
{
    public class Reservation
    {
        [Key]
        public int ID { get; set; }


        [Column(TypeName = "varchar(50)"), StringLength(50), Display(Name = "Ad Soyad"), Required(ErrorMessage = "Adı girilmesi zorunlu")]

        public string Name { get; set; }

        [Column(TypeName = "varchar(50)"), StringLength(50), Display(Name = "Telefon"), Required(ErrorMessage = "Telefon girilmesi zorunlu")]

        public string Phone { get; set; }

        [Column(TypeName = "varchar(6)"), StringLength(6), Display(Name = "Ziyaretçi Sayısı"), Required(ErrorMessage = "Ziyaretçi sayısı girilmesi zorunlu")]

        public string Guest { get; set; }

        [Column(TypeName = "datetime"), Display(Name = "Konaklama Tarihi")]
        public DateTime Checkindate { get; set; }


        [Column(TypeName = "varchar(50)"), StringLength(50), Display(Name = "Gidilecek Yer")]

        public string Destination { get; set; }
    }
}

