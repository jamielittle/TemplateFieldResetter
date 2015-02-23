using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sitecore.Data;

namespace TemplateFieldResetter.Models
{
    public class Template : Sitecore.Services.Core.Model.EntityIdentity
    {
        public string TemplateName { get; set; }
        public ID TemplateID  { get; set; }
    }
}