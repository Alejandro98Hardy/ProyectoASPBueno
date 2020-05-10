using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace ProyectoASPBueno.Models
{
    public class Subscrip
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string compania { get; set; }
        public int empleados { get; set; }
    }
}