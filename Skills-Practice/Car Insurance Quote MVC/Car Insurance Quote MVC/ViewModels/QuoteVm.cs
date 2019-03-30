using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Car_Insurance_Quote_MVC.ViewModels
{
    public class QuoteVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Nullable<decimal> QuoteAmount { get; set; }
    }
}