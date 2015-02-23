using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Services.Core;
using Sitecore.Services.Infrastructure.Sitecore.Services;
using TemplateFieldResetter.Models;
using TemplateFieldResetter.Repositories;

namespace TemplateFieldResetter.Controllers
{
    [ServicesController]
    public class TemplateController : EntityService<Template>
    {
        public TemplateController(IRepository<Template> repository)
            : base(repository)
        {
        }

        public TemplateController()
            : this(new TemplateRepository())
        {
        }
    }
}