using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vacation.Model
{
    public class Deals
    {
        public int ID { get; set; }
[Column(TypeName = "varchar(50)"), StringLength(50), Display(Name = "Şehir Adı"), Required(ErrorMessage = "Adı girilmesi zorunlu")]

        public string Name { get; set; }
        


        [Column(TypeName = "varchar(6)"), StringLength(6), Display(Name = "Kaydolan Kişi Sayısı"), Required(ErrorMessage = "Kişi sayısı girilmesi zorunlu")]
        public int Guest { get; set; }


        [Column(TypeName = "decimal(18,2)"), Display(Name = "Tur Ücreti"), Required(ErrorMessage = "Tur ücreti girilmesi zorunlu")]

        public decimal Price { get; set; }

        [Column(TypeName = "varchar(70)"), StringLength(70), Display(Name = "Ulaşım Dahil mi?"), Required(ErrorMessage = "Ulaşım bilgisi girilmesi zorunlu")]

        public string IsTransportationInclude { get; set; }

        [Column(TypeName = "varchar(20)"), StringLength(20), Display(Name = "Hotel Dahil mi?"), Required(ErrorMessage = "Hotel bilgisi girilmesi zorunlu")]
        public string IsHotelInclude { get; set; }   
        [Column(TypeName = "varchar(8)"), StringLength(8), Display(Name = "Hergün ziyaret ediliyor mu?"), Required(ErrorMessage = "Ziyaret bilgisi girilmesi zorunlu")]
        public string Visit { get; set; }

        [Column(TypeName = "varchar(4)"), StringLength(4), Display(Name = "Kaç Gün"), Required(ErrorMessage = "Tur gün sayısı girilmesi zorunlu")]
        public int Days { get; set; }

        [Column(TypeName = "varchar(150)"), StringLength(150), Display(Name = "Resim"), Required(ErrorMessage = "Resim girilmesi zorunlu")]

        public string Pitcure { get; set; }

    }
}
