using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication19.Pages
{
    public class ProductAModel : PageModel
    {
        private readonly ILogger<ProductAModel> _logger;

        public ProductAModel(ILogger<ProductAModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
