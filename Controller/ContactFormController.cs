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


namespace Umbraco.Cms.Web.Common.Controllers
{
    public class ContactFormController : SurfaceController
    {
        public ContactFormController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
        }

        [HttpPost]
        public ActionResult SubmitForm(ContactForm model)
        {
            if(ModelState.IsValid)
            {
                MailMessage mailMessage = new MailMessage(model.Email, "anithaaug7@gmail.com");
                mailMessage.Subject = model.FullName;
                mailMessage.Body = model.YourQuestions;

                SmtpClient smtpClient = new SmtpClient("127.0.0.1",25);
                smtpClient.Send(mailMessage);

                return Ok();
            }
            return Ok();
        }

    }
}