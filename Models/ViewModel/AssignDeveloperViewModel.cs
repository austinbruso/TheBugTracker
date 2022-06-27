using Microsoft.AspNetCore.Mvc.Rendering;


namespace TheBugTrackerProject.Models.ViewModel
{
    public class AssignDeveloperViewModel
    {
        public Ticket Ticket { get; set; }

        public SelectList Developers { get; set; }

        public string DeveloperId { get; set; }
    }
}
