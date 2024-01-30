using OfficeOpenXml.FormulaParsing.Excel.Functions.Math;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq; 

namespace MVC_Music.ViewModels
{
    public class PerformanceReportsVM
    {
        public int ID { get; set; }

        [Display(Name = "Musician")]
        public string MusicianFormalName
        {
            get
            {
                return LastName + ", " + FirstName
                    + (string.IsNullOrEmpty(MiddleName) ? "" :
                        (" " + (char?)MiddleName[0] + ".").ToUpper());
            }
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        [Display(Name = "Total Number of Performances")]
        public int NumberOfPerformances { get; set; }

        [Display(Name = "Average Fee Paid")]
        [DataType(DataType.Currency)]
        public double AverFee { get; set; }


        [Display(Name = "Highest Fee Paid")]
        [DataType(DataType.Currency)]
        public double HighFee { get; set; }


        [Display(Name = "Lowest Fee Paid")]
        [DataType(DataType.Currency)]
        public double LowFee { get; set; }

    }
}
