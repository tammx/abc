using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class TbNews
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string Title { get; set; }
        public int CatId { get; set; }
        [ForeignKey("CatId")]
        public virtual TbCategories TbCategories { get; set; }
    }
}
