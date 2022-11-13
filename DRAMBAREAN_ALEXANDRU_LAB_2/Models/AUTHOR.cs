using System.ComponentModel.DataAnnotations;

namespace DRAMBAREAN_ALEXANDRU_LAB_2.Models
{
    public class AUTHOR
    {
        public int ID { get; set; }
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
        public ICollection<AUTHOR>? Authors

        {
            get; set;

        }
    }

    }
    



