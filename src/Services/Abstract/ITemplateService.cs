using System.Collections.Generic;
using Models;
using Options;

namespace Services.Abstract
{
    public interface ITemplateService
    {
        Template FindTemplate(InitOption option);
        IEnumerable<Template> ListTemplates(ListOption option);
    }

}