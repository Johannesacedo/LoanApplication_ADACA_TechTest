using LoanApplication.Models;

namespace LoanApplication.Services.Interfaces
{
    public interface ILoanApplicationService
    {
        Task<LoanApplicationResult> ProcessLoanApplicationAsync(LoanApplications loanApplication);
    }
}
