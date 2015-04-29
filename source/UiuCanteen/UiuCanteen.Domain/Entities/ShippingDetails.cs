using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UiuCanteen.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your mobile number or your Id number")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Please enter any Secret word")]
        public string SecretWord { get; set; }

        

    


       
    }

}
