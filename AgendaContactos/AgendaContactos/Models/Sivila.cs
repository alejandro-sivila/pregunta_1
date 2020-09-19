using System.ComponentModel.DataAnnotations;
using System;
using System.Security.Permissions;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaContactos.Models
{
    public enum CategoryType
    {
        La_plaza,
        El_colegio,
        La_universidad,
        El_boliche,
        Amiga_de_un_amigo
    }
    public class Sivila
    {
        [Key]
        public int SivilaID { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{amigo de:}", ApplyFormatInEditMode =true)]
        [StringLength(24,ErrorMessage ="NOMBRE MUY CORTO", MinimumLength = 2)]
        public string FriendOf { get; set; }

        [Required(ErrorMessage = "tienes queescoger entre: La plaza,El colegio,La universidad,El boliche,Amiga de un amigo ")]
        public CategoryType place { get; set; }

        [EmailAddress]
        public string ReceiverMail { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}",ApplyFormatInEditMode =true)]
        public DateTime Birthdate { get; set; }

    }
}