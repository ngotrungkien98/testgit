using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WADLab9.Models
{
    [Table("Customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //tự nhập
        public string customerid { get; set; }

        [Required]
        public string customername { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [StringLength(50, MinimumLength =2, ErrorMessage = "Address from 2-50 characters")]
        public string customeraddress { get; set; }
        public string customerphone { get; set; }
    }
}
