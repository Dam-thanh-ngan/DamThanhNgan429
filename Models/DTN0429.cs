using System.ComponentModel;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace nguyennhuthin189.Models
{
    public class NNT0189
    {
        [Key]
      [StringLength(20)]
      [DisplayName("ID ")]
      public int DTNId { get; set; }
      [StringLength(50)]
      [DisplayName("Tên người dùng")]
      public String DTNName { get; set; }
      [DisplayName("Giới tính")]
      public string DTNGender { get; set; }
    }
}