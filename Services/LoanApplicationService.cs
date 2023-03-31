using LoanApplication.Models;
using LoanApplication.Services.Interfaces;

namespace LoanApplication.Services
{
    public class LoanApplicationService:ILoanApplicationService
    {
        private readonly IValidationService _validationService;

        private static readonly Dictionary<string, LoanApplicationResult> _validatedApplications = new();

        public LoanApplicationService(IValidationService validationService)
        {
            _validationService = validationService;
        }

        public async Task<LoanApplicationResult> ProcessLoanApplicationAsync(LoanApplications loanApplication)
        {
            // Check if the application has already been validated
            var hash = loanApplication.GetHash();
            if (_validatedApplications.ContainsKey(hash))
            {
                return _validatedApplications[hash];
            }

            // Perform the application validation
            var validationResult = await _validationService.ValidateAsync(loanApplication);

            // Create a LoanApplicationResult based on the validation result
            Decision decision;
            if (validationResult.Decision == Decision.Unqualified)
            {
                decision = Decision.Unqualified;
            }
            else if (validationResult.Decision == Decision.Unknown)
            {
                decision = Decision.Unknown;
            }
            else
            {
                decision = Decision.Qualified;
            }

            var result = new LoanApplicationResult
            {
                Decision = decision,
                
            };

            // Cache the validated application
            _validatedApplications.Add(hash, result);

            return result;
        }
    }
}
