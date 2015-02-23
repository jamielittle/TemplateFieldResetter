using TemplateFieldResetter.Models;
using TemplateFieldResetter.Repositories;
using Sitecore.Services.Core;
using Sitecore.Services.Infrastructure.Sitecore.Services;

namespace TemplateFieldResetter.Controllers
{
    [ServicesController]
    public class EntityController : EntityService<Entity>
    {
        public EntityController(IRepository<Entity> repository)
            : base(repository)
        {
        }

        public EntityController()
            : this(new EntityRespository())
        {
        }
    }
}