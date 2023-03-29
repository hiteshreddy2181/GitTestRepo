using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVCApplication.Models
{
    public class Submit
    {
        [Required]
        [EditorBrowsable]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Phone]
        public int PhoneNumber { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; }
        [Required]
        public string Occupation { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Feedback { get; set; }
       
    }
}