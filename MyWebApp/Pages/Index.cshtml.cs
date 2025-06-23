//using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//using Microsoft.Extensions.Logging;

namespace MyWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string? Message { get; set; }

        public void OnGet()
        {
            // We don't do anything, we just go to the website.
        }

        public void OnPostHello()
        {
            Message = "App .NET";
        }

        public string? Fact {  get; set; }
        public void OnPostShowFact()
        {
            string[] facts = new[]
            {
                "C# was created by Microsoft in 2000.",
                ".NET Core is multiplatform!",
                "ASP.NET Core can run in Docker.",
                "Visual Studio has a shortcut Ctrl+K, Ctrl+C for commenting.",
                "Razor Pages is a simplified MVC."
            };

            var random = new Random();
            int index = random.Next(facts.Length);
            Fact = facts[index];
        }

        [BindProperty]
        public string? UserName { get; set; }
        public string? Greeting { get; set; }

        public void OnPostSayHello()
        {
            if (!string.IsNullOrWhiteSpace(UserName))
            {
                Greeting = $"Nice to see you, {UserName}!";
            }
            else
            {
                Greeting = "Please enter your name.";
            }
        }
    }
}

