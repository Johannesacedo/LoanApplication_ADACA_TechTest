using LoanApplication.Models;
using LoanApplication.Services;
using Microsoft.AspNetCore.Mvc;

namespace LoanApplication.Controllers
{
    public class LoanApplicationController : Controller
    {
        private readonly ValidationService _validationService;
        public LoanApplicationController(ValidationService validationService)
        {
            _validationService = validationService;
        }

        [HttpPost]
        public async Task<IActionResult> PostLoanApplication([FromBody] LoanApplications request)
        {
            var validationResult = await _validationService.ValidateAsync(request);
            if (validationResult.Decision == Decision.Qualified)
            {
                // Process the approved loan application
                return Ok("Loan application approved");
            }
            else
            {
                // Handle the denied loan application
                return BadRequest(validationResult.Message);
            }
        }
    }
}
