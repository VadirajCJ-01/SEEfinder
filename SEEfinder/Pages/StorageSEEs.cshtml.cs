using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SEEfinder.Models;

namespace SEEfinder.Pages
{
    public class StorageSEEsModel : PageModel
    {
        public string Vertical { get; set; } = "Veritcals";

        public List<SelectListItem> Verticals { get; } = new List<SelectListItem>
   {
      new SelectListItem { Value = "StorageSEEs", Text = "Storage" },
      new SelectListItem { Value = "APIMSEEs", Text = "APIM" },
   };
        public List<SEEDetails> SEEsList = new List<SEEDetails>()
            {
                new SEEDetails {Id=1, FirstName="Amit", LastName="Ramasamy", EmailID="karamasa@microsoft.com", Vertical="APIM",ContactDetails="90909090"},
                new SEEDetails {Id=2, FirstName="Manjunath", LastName="NV", EmailID="mannv@microsoft.com", Vertical="APIM",ContactDetails="90909090"}
            };
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var SelectedVertical = Request.Form["SelectedVertical"];
            return RedirectToPage("/" + SelectedVertical);

        }
    }
}
