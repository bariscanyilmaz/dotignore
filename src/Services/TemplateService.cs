using Models;
using System.Linq;
using System.Threading.Tasks;
using Options;
using System.Collections.Generic;
using System;
using Services.Abstract;
namespace Services
{
    public class TemplateService:ITemplateService
    {
        public Template FindTemplate(InitOption option)
        {

            return Repository.Templates
            .Where(x => x.Name.Contains(option.Template.ToLower()) ||
             x.Aliases.Contains(option.Template.ToLower()))
            .FirstOrDefault();       
        }

        public List<Template> ListTemplates(ListOption option)
        {
            List<Template> results = Repository.Templates;

            if (!string.IsNullOrEmpty(option.Query))
            {
                results = results.Where(
                    x => x.Name.Contains(option.Query.ToLower()) ||
                    x.Aliases.Contains(option.Query.ToLower()))
                .ToList();
            }


            return results;
            

        }
    }
}