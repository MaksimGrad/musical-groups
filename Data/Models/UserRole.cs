using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MusicalGroup.Data.Models
{
    [Table("user_roles")]
    public class UserRole
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
