using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppWeb.Models
{
    public class Clients
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [DisplayName("Nom")]
        public string dnom { get; set; }
        
        [DisplayName("Correu")]
        public string maildnom { get; set; }
        
        [DisplayName("Usuari WD")]
        public string userwd { get; set; }
        
        [DisplayName("Password WD")]
        public string passwd { get; set; }
        
        [DisplayName("Acces WD")]
        public string accewd { get; set; }
        
        [DisplayName("Usuari HT")]
        public string userht { get; set; }
        
        [DisplayName("Password HT")]
        public string passht { get; set; }
        
        [DisplayName("Link HT")]
        public string lnkht { get; set; }
        
        [DisplayName("Observacions")]
        public string dobs { get; set; }
        
        [DisplayName("Estat")]
        public string est { get; set; }
        
        [DisplayName("Observacions estat")]
        public string dobsest { get; set; }
        
        [DisplayName("Presupost")]
        public string presu { get; set; }

        [DisplayName("Presupost")]
        public string ppresu { get; set; }

        [DisplayName("Falta pagar")]
        public string fpag { get; set; }

        [DisplayName("Possible tema")]
        public string phtheme { get; set; }

        [DisplayName("Manteniment")]
        public bool climent { get; set; }

    }
}
