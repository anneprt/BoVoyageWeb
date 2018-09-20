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
    public class Client
    {
        public int ID { get; set; }

        [Required]
        [StringLength(4)]
        public string Civilite { get; set; }

        [Required]
        [StringLength(30)]
        public string Nom { get; set; }

        [Required]
        [StringLength(30)]
        public string Prenom { get; set; }

        [StringLength(50)]
        public string Adresse { get; set; }

        [StringLength(10)]
        public string Telephone { get; set; }

        public DateTime DateNaissance { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

    }
}