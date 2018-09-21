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
    public class Reservation
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string NumeroDossier { get; set; }

        public int DestinationID { get; set; }

        [Required]
        [ForeignKey("DestinationID")]
        public Destination Destination { get; set; }

        [Required]
        public DateTime DateDepart { get; set; }

        [Required]
        public DateTime DateRetour { get; set; }

        [Required]
        public decimal Prix { get; set; }

        public bool Statut { get; set; }

        public int? NombreParticipants { get; set; }

        public int ClientID { get; set; }

        [ForeignKey("ClientID")]
        public Client Client { get; set; }

        public bool Assurance { get; set; }
    }
}