using Microsoft.AspNetCore.Http;
using ProiectMaster.Models.Attributes;
using ProiectMaster.Models.Entites;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models.DTOs.VM
{
    public class ProductVM
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(2000)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string ImagePath { get; set; }
        [Required]
        public int ProductTypeId { get; set; }

        public string ProductTypeName { get; set; }

        public List<IdNameDTO> ProductTypes { get; set; }
        [AllowedExtension(".jpg", ".png", ".jpeg")]
        [MaxFileSize(3 * 1024 * 1024)]
        public IFormFile ProductImage { get; set; }

    }
}
