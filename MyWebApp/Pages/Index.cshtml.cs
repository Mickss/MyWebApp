//using Microsoft.AspNetCore.Mvc;
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
    }
}

