using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.UI.Pages
{
    public class ResumeModel : PageModel
    {
        public List<string> Skills { get; set; }

        public void OnGet()
        {
            Skills = new List<string>()
            {
                "C#", "dotNet", "Unity", "Azure", "Git", "SQL", "SOQL", "API", "Microservice", "..."
            };
        }
    }
}
