using ForumSystem.Data.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumSystem.Data.Models
{
    public class Tag:AuditInfo, IDeletableEntity
    {
        public DateTime? DeletedOn { get; set; }      

        [Key]
        public int Id { get; set; }
        
        [Index]
        public bool IsDeleted { get; set; }      

        public string Name { get; set; }
    }
}
