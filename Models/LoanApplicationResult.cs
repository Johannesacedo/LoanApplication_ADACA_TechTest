namespace LoanApplication.Models
{
    public class LoanApplicationResult
    {
        public Decision Decision { get; set; }
        public List<ValidationResult> ValidationResult { get; set; }
        public List<string> ValidationMessages { get; set; }
    }
}
