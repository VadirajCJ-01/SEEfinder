using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SEEfinder.Models;
using System.Collections.Generic;

namespace SEEfinder.Pages
{
    public class APIMSEEsModel : PageModel
    {
        public string Vertical { get; set; } = "Veritcals";

        public List<SelectListItem> Verticals { get; } = new List<SelectListItem>
   {
      new SelectListItem { Value = "APIMSEEs", Text = "APIM" },
      new SelectListItem { Value = "StorageSEEs", Text = "Storage" },
   };
        public List<SEEDetails> SEEsList = new List<SEEDetails>()
            {
                new SEEDetails {Id=1, FirstName="Karthikeyan", LastName="Ramasamy", EmailID="karamasa@microsoft.com", Vertical="APIM",ContactDetails="90909090"},
                new SEEDetails {Id=2, FirstName="Manjunath", LastName="NV", EmailID="mannv@microsoft.com", Vertical="APIM",ContactDetails="90909090"}
            };
        //public List<Verticals> VerticalsList = new List<Verticals>()
        //{
        //    new Verticals {VerticalName="APIM"},
        //    new Verticals {VerticalName="Storage"}
        //};

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

