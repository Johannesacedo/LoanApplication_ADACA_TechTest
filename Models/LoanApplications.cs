using System.Text;
using System.Xml.Linq;

namespace LoanApplication.Models
{
    public class LoanApplications
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string BusinessNumber { get; set; }
        public decimal LoanAmount { get; set; }
        public CitizenshipStatus CitizenshipStatus { get; set; }
        public int TimeTrading { get; set; }
        public string CountryCode { get; set; }
        public string Industry { get; set; }

        public string GetHash()
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.Append(FirstName);
            stringBuilder.Append(LoanAmount);
    

            return Convert.ToBase64String(Encoding.UTF8.GetBytes(stringBuilder.ToString()));
        }
    }
}
