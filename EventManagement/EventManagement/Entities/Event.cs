using EventManagement.Models.NewFolder;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManagement.Entities
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Caption { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string Description { get; set; }

        public string Location { get; set; }

        public DateTime Date { get; set; }

        public string EventImg { get; set; }

        public ICollection<Participants> Participants { get; set; }
    }
}
