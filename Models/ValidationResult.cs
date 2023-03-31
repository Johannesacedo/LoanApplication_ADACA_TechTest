namespace LoanApplication.Models
{
    public class ValidationResult
    {
        public string Rule { get; set; }
        public string Message { get; set; }
        public Decision Decision { get; set; }
        public string Result { get; set; }
    }
}
