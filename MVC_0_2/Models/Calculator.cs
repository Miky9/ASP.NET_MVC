using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MVC_0_2.Models
{
    public class Calculator
    {
        [Display(Name = "1st number")]
        public double Number1 { get; set; }
        [Display(Name = "2nd number")]
        public double Number2 { get; set; }
        public double Result { get; set; }
        [Display(Name = "Operation")]
        public string Operation { get; set; }
        public List<SelectListItem> PossibleOperations { get; set; }

        public Calculator()
        {
            PossibleOperations = new List<SelectListItem>();
            PossibleOperations.Add(new SelectListItem { Text = "Add", Value = "+", Selected = true });  //Text sees a user as the label, Value is sended to server (without diacritics)
            PossibleOperations.Add(new SelectListItem { Text = "Substract", Value = "-" });
            PossibleOperations.Add(new SelectListItem { Text = "Multiply", Value = "*" });
            PossibleOperations.Add(new SelectListItem { Text = "Divide", Value = "/" });
        }

        public void Calculate()
        {
            switch (Operation)
            {
                case "+":
                    Result = Number1 + Number2;
                    break;
                case "-":
                    Result = Number1 - Number2;
                    break;
                case "*":
                    Result = Number1 * Number2;
                    break;
                case "/":
                    Result = Number1 / Number2;
                    break;
            }
        }
    }
}
