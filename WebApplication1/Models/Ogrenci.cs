using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Ogrenci
    {

        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set; }
        [StringLength(20)]
        public string SurName { get; set; }
        [StringLength(10)]
        public string SchoolNumber { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [StringLength(25)]
        public string EğitimDurumu { get; set; }
    }
}

