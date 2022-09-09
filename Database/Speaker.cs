using System.ComponentModel.DataAnnotations;

namespace AzureIntroWorkshop.Database
{
    public class Speaker
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
