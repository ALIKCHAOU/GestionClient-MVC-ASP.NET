using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Gestion_des_clients.Models
{
    [Table("Consultant")]
    public class Consultant

    {
        [Key]
        public int id { get; set; }
        public  string Code { get; set; }
        public string nom { get; set; }    
        public string tel { get; set; }
        public ICollection<Client> Clients { get; set;}
        
    }
    
}