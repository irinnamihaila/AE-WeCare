using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProiectMaster.Models.DTOs.VM
{
    public class ProductTypeVM
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Required]
        [StringLength(5)]
        public string Code { get; set; }
    }
}
