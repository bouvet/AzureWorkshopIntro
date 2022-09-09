using AzureIntroWorkshop.Database;
using Microsoft.AspNetCore.Mvc;

namespace AzureIntroWorkshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkshopController : ControllerBase
    {

        private readonly WorkshopDbContext _workshopDbContext;

        public WorkshopController(WorkshopDbContext workshopDbContext)
        {
            _workshopDbContext = workshopDbContext;
        }

        [HttpPost("speaker")]
        public void AddSpeaker(string firstName, string lastName)
        {
            var speaker = new Speaker()
            {
                FirstName = firstName,
                LastName = lastName
            };
            _workshopDbContext.Speakers.Add(speaker);

            _workshopDbContext.SaveChanges();

            return;
        }

        [HttpGet]

        public List<Speaker> GetAllSpeakers()
        {
            return _workshopDbContext.Speakers.ToList();
        }

        [HttpPost("workshop")]

        public ActionResult AddWorkshop([FromQuery] WorkshopQueryParams queryParams)
        {

            var speaker = _workshopDbContext.Speakers.FirstOrDefault(e => e.Id == queryParams.SpeakerId);

            if (speaker == null)
            {
                return new NotFoundObjectResult("speaker id not found");
            }
            var workshop = new Workshop()
            {
                Name = queryParams.Name,
                Description = queryParams.Description,
                StartTime = queryParams.StartTime,
                EndTime = queryParams.EndTime,
                Capacity = queryParams.Capacity,
                Location = queryParams.Location,
                Speaker = speaker
            };

            _workshopDbContext.Workshops.Add(workshop);

            
            _workshopDbContext.SaveChanges();

            return new OkObjectResult(workshop);
        }

        //[HttpPut]
        //public void UpdateSpeaker()
        //{

        //}

        //[HttpDelete]

        //public void DeleteSpeaker()
        //{

        //}
    }
}
