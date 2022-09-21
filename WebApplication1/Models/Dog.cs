using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Models
{
    [Table("Dogs")]
    public class Dog
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }


    }
}
