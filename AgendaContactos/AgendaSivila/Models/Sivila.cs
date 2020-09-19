using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AgendaSivila.Models
{
    public enum Category
    {
        La_plaza = 1,
        El_colegio = 2,
        La_universidad = 3,
        El_boliche = 4,
        Amiga_de_un_amigo = 5
    }
    public class Sivila
    {
        [Key]
        public int SivilaID { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{amigo de:}", ApplyFormatInEditMode = true)]
        [StringLength(24, ErrorMessage = "NOMBRE MUY CORTO", MinimumLength = 2)]
        public string FriendOf { get; set; }

        [Required(ErrorMessage = "tienes queescoger entre: La plaza,El colegio,La universidad,El boliche,Amiga de un amigo ")]
        public Category place { get; set; }

        [EmailAddress]
        public string ReceiverMail { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }

    }
}
