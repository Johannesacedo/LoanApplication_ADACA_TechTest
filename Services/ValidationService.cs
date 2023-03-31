using LoanApplication.Models;
using LoanApplication.Services.Interfaces;
using Microsoft.AspNetCore.Rewrite;
using static System.Net.Mime.MediaTypeNames;

namespace LoanApplication.Services
{
    public class ValidationService : IValidationService
    {
        private readonly IEnumerable<IRule> _rules;

        public ValidationService(IEnumerable<IRule> rules)
        {
            _rules = rules;
        }

        public Task<ValidationResult> ValidateAsync(LoanApplications loanApplication)
        {
            throw new NotImplementedException();
        }
    }
}
