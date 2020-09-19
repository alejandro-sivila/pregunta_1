using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace SivilaAgenda.Models
{
    public enum categorytype
    {
        La_plaza=1,
        El_colegio=2,
        La_universidad=3,
        El_boliche=4,
        Amiga_de_un_amigo=5
    }
    public class Contacto
    {
        [Key]
        public int SivilaId { get; set; }
        [Required]
        [StringLength(30,ErrorMessage ="NOMBRE DEMASIADO LARGO",MinimumLength =2)]
        [Display(Name="Nombre completo")]
        public string FrienOfSivila { get; set; }
        [Required]
        public categorytype place { get; set; }
        [EmailAddress]
        public string email { get; set; }
        [Display(Name ="cumpleaños")]
        public DateTime Birthdate { get; set; }
    }
}