using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DamThanhNgan429.Modles
{
    public class PersonDTN429
    {
        [Key]
        [Column(TypeName = "nvarchar(20)")]
        public string PresonID {get; set;}
        [Column(TypeName = "nvarchar(50)")]
        public string PersonName { get; set; }
    }
}