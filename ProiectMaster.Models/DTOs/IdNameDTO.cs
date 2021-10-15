using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectMaster.Models.DTOs
{
    public class IdNameDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IdNameDTO()
        {

        }

        public IdNameDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
