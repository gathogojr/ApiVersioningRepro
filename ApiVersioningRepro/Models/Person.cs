using System;
using System.ComponentModel.DataAnnotations;

namespace ApiVersioningRepro.Models
{
    public class Person
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
