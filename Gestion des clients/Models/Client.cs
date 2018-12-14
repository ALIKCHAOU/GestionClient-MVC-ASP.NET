using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gestion_des_clients.Models
{
       [Table("Client")]
    public class Client
    {
        [Key, Column(Order = 0)]
        public int id { get; set; }
        [Required(ErrorMessage = " Le code client est necessaire.")]
        [Column("code_client", TypeName = "ntext")]
        [MaxLength(20)]
        public string code_client { get; set; }

        [Required(ErrorMessage = "  le nom du client  est necessaire.")]
        [MaxLength(20)]
        public string nom_client { get; set; }

        [Required(ErrorMessage = " Le raison social est necessaire.")]
        [MaxLength(20)]
        public string raison_social { get; set; }

       
        public Consultant consultant { get; set; }
    }
}