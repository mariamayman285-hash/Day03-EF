using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03_EF.Models
{
    internal class Book
    {
        [Key]   //annotation y3ni (remember we can only use it if we have access to source code)
        [DatabaseGenerated(DatabaseGeneratedOption.None)]  //u can use identity instead of none but u cant be specific about the identity (if u want then use fluent api)
        public int Id { get; set; }     //if u didnt use any annotation ot will still be primary key implicitly as it is an integer named id or EntityId
        [Required]
        [StringLength(150)]
        public string Title { get; set; }
        public decimal price { get; set; }  //it is a numeric value so it will be implicitly required anyway
        public DateTime? PublishedDate { get; set; } //it is already optional as it alow null
    }
}
