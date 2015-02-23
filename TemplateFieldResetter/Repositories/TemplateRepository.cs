using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TemplateFieldResetter.Models;

namespace TemplateFieldResetter.Repositories
{
    public class TemplateRepository : Sitecore.Services.Core.IRepository<Template>
    {
        public IQueryable<Template> GetAll()
        {
            throw new NotImplementedException();
        }

        public Template FindById(string id)
        {
            throw new NotImplementedException();
        }

        public void Add(Template entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Template entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Template entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Template entity)
        {
            throw new NotImplementedException();
        }
    }
}