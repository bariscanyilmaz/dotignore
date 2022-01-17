using Models;
using System.Linq;
using System.Threading.Tasks;
using Options;
using System.Collections.Generic;
using System;
using Services.Abstract;
namespace Services
{
    public class TemplateService : ITemplateService
    {
        public Template FindTemplate(InitOption option)
        {

            return Repository.Templates.Select(x => new Template(x.Name, x.Aliases, x.RepoURL, CalculateRate(x, option.Template))).Where(x => x.Rate > 0)
            .OrderByDescending(x => x.Rate)
            .FirstOrDefault();
        }

        public IEnumerable<Template> ListTemplates(ListOption option)
        {
            var results = Repository.Templates;

            if (!string.IsNullOrEmpty(option.Query))
            {
                results = results.Select(
                  x => new Template(
                      x.Name,
                      x.Aliases,
                      x.RepoURL,
                      CalculateRate(x, option.Query)
                      )
                ).OrderByDescending(x => x.Rate).Where(x => x.Rate > 0);
            }

            return results;

        }

        float CalculateRate(Template template, string query)
        {
            float rate = 0f;

            if (template.Name.ToLower().Contains(query.ToLower()))
            {
                rate += ((float)query.Count() / (float)template.Name.Count());
            }
            else if (template.Aliases.Select(x => x.ToLower()).Contains(query.ToLower()))
            {
                rate += (float)query.Count() / (float)template.Aliases.Select(x => x.Count()).Sum();
            }

            return rate;
        }
    }
}