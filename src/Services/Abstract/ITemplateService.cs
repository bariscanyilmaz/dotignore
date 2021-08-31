using System.Collections.Generic;
using System.Threading.Tasks;
using Models;
using Options;

namespace Services.Abstract
{
    public interface ITemplateService
    {
        Template FindTemplate(InitOption option);
        List<Template> ListTemplates(ListOption option);
    }

}