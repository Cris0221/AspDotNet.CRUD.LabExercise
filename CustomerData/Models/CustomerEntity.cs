using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System;

namespace CustomerData.Models
{
    public class CustomerEntity : BaseEntity
    {
        [Required]
        [MinLength(3)]
        [MaxLength(19)]
        [NameValidation]

        public string FirstName { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(19)]
        [NameValidation]

        public string LastName { get; set; }

        public string? Address { get; set; }

        public string? Phone { get; set; }


    }

    public class NameValidation : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            string inputName = value as string;
            if (inputName != null)
            {          
                string validChar = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
                for (int i = 0; i < inputName.Length; i++)
                {
                    if (!validChar.Contains(inputName[i])) return false;
                }

                return true;               
            }
            else
            {
                return false;
            }
        }
        public NameValidation()
        {
            ErrorMessage = "Please Input a valid name!";
        }


    }
}
