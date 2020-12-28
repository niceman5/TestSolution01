using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;

namespace WebApp01.Models
{
    public class UsersModel
    {
        //[USER_NO], [USER_NM], [ID], [PW], [HDPH_NO], [EMAIL], [IS_DEL], [LAST_CHNG_DT], [LAST_USER_NO]
        [Required]
        [Key]
        public int USER_NO { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required]
        [MaxLength(30)]
        public string USER_NM { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        [MaxLength(20)]
        public string ID { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        [MaxLength(20)]
        public string PW { get; set; }
        [Column(TypeName = "varchar(20)")]
        [Required]
        [MaxLength(20)]
        public string HDPH_NO { get; set; }
        [Column(TypeName = "varchar(50)")]
        [MaxLength(50)]
        [EmailAddress]
        public string EMAIL { get; set; }
        [Required]
        public bool IS_DEL { get; set; }
        [Required]
        public DateTime LAST_CHNG_DT { get; set; }
        [Required]
        public int LAST_USER_NO { get; set; }
        public int? MAX_CNT { get; }
    }
}
