using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TestApp.Pages
{
    public class ProfileModel : PageModel
    {
        public void OnGet()
        {
            ViewData["myName"] = "Amir Ashraf";
            ViewData["username"] = "amirashraf.ahmadizh";
            ViewData["myOccupation"] = "Software Engineer";
            ViewData["myAge"] = 27;
            ViewData["currentDate"] = DateTime.Today.ToString("MM/dd/yyyy");

        }
    }
}