using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BoVoyageWeb.Data;

namespace BoVoyageWeb.Models
{
    public class Agence
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        //[Column("Name")]
        public string NomAgence { get; set; }
    }
}