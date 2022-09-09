using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AzureIntroWorkshop.Database
{
    public class WorkshopQueryParams
    {

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public string Location { get; set; }

        public DateTimeOffset StartTime { get; set; }

        public DateTimeOffset EndTime { get; set; }

        [DefaultValue(20)]
        public int Capacity { get; set; }

        public int SpeakerId { get; set; }
    }
}
