using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hybrid.Prem.Client.Factory;
using Hybrid.Prem.Client.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hybrid.Prem.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InsuranceController : ControllerBase
    {
        private readonly InsuranceContext _context;
        private readonly IInsuranceFactory _factory;

        public InsuranceController(InsuranceContext context, IInsuranceFactory factory)
        {
            _context = context;
            _factory = factory;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Insurance>>> Get()
        {
            var insurance = _factory.CreateClaims();
            await _context.Insurances.AddAsync(insurance);
            await _context.SaveChangesAsync();

            return Ok(insurance);
        }
        
    }
}
