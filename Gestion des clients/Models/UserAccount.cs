using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gestion_des_clients.Models
{
    public class UserAccount
    {
        [Key]        
        public int id { get; set; }

        [Required(ErrorMessage = " Le nom est necessaire.")]
        [MaxLength(20)]
        public string nom { get; set; }

        [Required(ErrorMessage = "le prenom est necessaire .")]
        [MaxLength(20)]
        public string prenom { get; set; }

        [Required(ErrorMessage = "le login est necessaire .")]
        [MaxLength(40)]
        public string login { get; set; }

        [Required(ErrorMessage = "le mot de passe est necessaire .")]
        [DataType(DataType.Password)]
        [MaxLength(20)]
        public string mot_de_passe { get; set; }

        [Required(ErrorMessage = "le type de acces est necessaire .")]
        public bool is_admin  { get; set; }

    

    }


}