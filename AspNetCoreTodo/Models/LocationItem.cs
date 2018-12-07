using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreTodo.Models
{
    public class LocationItem
    {
        public Guid Id { get; set; }
        public string Location { get; set; }
        public float Latitud { get; set; }
        public float Longitud { get; set; }
    }
}