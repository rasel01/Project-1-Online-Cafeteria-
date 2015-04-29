using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UiuCanteen.Domain.Entities;

namespace UiuCanteen.WebUi.Models
{
    public class CartIndexViewModel
    {
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
    }
}