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
    public class Destination
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string Pays { get; set; }

        [Required]
        [StringLength(30)]
        public string Continent { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public int AgenceID { get; set; }

        [ForeignKey("AgenceID")]
        public Agence Agence { get; set; }
    }
}