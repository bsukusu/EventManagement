using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Xml;

namespace EventManagement.Models.NewFolder
{
    public class Participants
    {
        [Key]
        public int ParticipantsId { get; set; }

        [Column(TypeName ="Varchar")]
        [StringLength(30)]

        public string Name { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string surname { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string mail { get; set; }

        public Boolean status { get; set; }

        public int eventPartId { get; set; }


    }
}
