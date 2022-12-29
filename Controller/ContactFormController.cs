using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Common.PublishedModels;
using Umbraco.Cms.Web.Website.Controllers;
using Umbraco.Web.Mvc;

namespace Umbraco.Cms.Web.Common.Controllers
{
    public class ContactFormController : SurfaceController
    {
        // private readonly IConfiguration _config;
        // public ContactFormController(IConfiguration config, IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        // {
        //      _config = config;       
        // }


        [HttpPost]
        public ActionResult SubmitForm(ContactForm model)
        {
            if(ModelState.IsValid)
            {
                MailMessage mailMessage = new MailMessage(model.Email, "anithaaug7@gmail.com");
                mailMessage.Subject = model.FullName;
                mailMessage.Body = model.YourQuestions;

                SmtpClient smtpClient = new SmtpClient("127.0.0.1", 25);
                // SmtpClient smtpClient = new SmtpClient(_config.GetSection("SMTPServer").Value, 587);
                smtpClient.Send(mailMessage);
                TempData["ContactResult"] = "Has been Sent..."; 

            //     return Ok();
            // }
            // return Ok();
            return RedirectToCurrentUmbracoPage();
            }
            return CurrentUmbracoPage();
        }

    }
}