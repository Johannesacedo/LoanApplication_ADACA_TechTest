using LoanApplication.Models;

namespace LoanApplication.Services.Interfaces
{
    public interface IValidationService
    {
        Task<ValidationResult> ValidateAsync(LoanApplications loanApplication);
    }
}
