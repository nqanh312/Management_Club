using ClubManagementObject;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Point
    {
        [Key]
        public int PointId { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public int SumPoint { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(50)] 
        public string Semeter { get; set; }

    }
}
