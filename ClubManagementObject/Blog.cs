using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.ComponentModel;
using System.Web.Mvc;

namespace ClubManagementObject
{
    public class Blog
    {   
        

        [Key]
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Ten tac gia bai viet khong duoc rong")]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }

        [DataType(DataType.Date)]
        public DateTime? PublicDays { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(4000)]
        [AllowHtml]
        [Required(ErrorMessage = "Noi dung khong duoc rong")]
        public string Content { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        [Required(ErrorMessage = "Tieu de khong duoc rong")]
        public string Title { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Image { get; set; }
        
        [NotMapped]
        [DisplayName("Upload File")]
        [Required(ErrorMessage = "Anh thumnail khong duoc trong")]
        public IFormFile ImageFile { get; set; }
    }
}
