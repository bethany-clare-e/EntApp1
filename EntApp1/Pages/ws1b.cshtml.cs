using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntApp1.Pages
{
    public class ws1bModel : PageModel
    {
        public string Message { get; set; }
        public string Calculation { get; set; }
        
        public void OnPost(int number1, int number2)
        {
            int result = (number1) + (number2);
            Message =
                string.Format("The sum of {0} and {1} is {2} ", number1, number2, result);
            
            
        }

        
    }
}