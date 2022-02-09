using Asp.net_core_email_service.Models;
using Asp.net_core_email_service.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Asp.net_core_email_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MailController : ControllerBase
    {
        private readonly IMailService mailService;
        public MailController(IMailService mailService)
        {
            this.mailService = mailService;
        }

        [HttpPost("send")]
        public async Task<IActionResult> SendMail([FromForm] MailRequest request)
        {
            try
            {
                await mailService.SendMailAsync(request);
                return Ok();
            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}
