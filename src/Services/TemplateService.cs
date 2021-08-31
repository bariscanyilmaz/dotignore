using Models;
using System.Linq;
using System.Threading.Tasks;
using Options;
using System.Collections.Generic;
using System;

namespace Services
{
    public class TemplateService
    {
        private readonly WebService _webService;
        private readonly FileService _fileService;

        public TemplateService(FileService fileService, WebService webService)
        {
            _webService = webService;
            _fileService = fileService;
        }

        public async Task<int> InitializeTemplateAsync(InitOption option)
        {

            var result = Repository.Templates
            .Where(x => x.Name.Contains(option.Template.ToLower()) ||
             x.Aliases.Contains(option.Template.ToLower()))
            .FirstOrDefault();

            if (result != null)
            {
                var response = await _webService.GetTemplateAsync(result.RepoURL);
                var content=await response.Content.ReadAsStringAsync()??string.Empty;
                await _fileService.CreateIgnoreFileAsync(content);

                return 1;
            }
            return -1;
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