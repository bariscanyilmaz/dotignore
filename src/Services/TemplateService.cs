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
                var content = await _webService.GetTemplateAsync(result.RepoURL);
                await _fileService.CreateIgnoreFileAsync(content);

                return 1;
            }
            return -1;
        }

        public void ListTemplates(ListOption option)
        {
            List<Template> results = Repository.Templates;

            if (!string.IsNullOrEmpty(option.Query))
            {
                results = results.Where(
                    x => x.Name.Contains(option.Query.ToLower()) ||
                    x.Aliases.Contains(option.Query.ToLower()))
                .ToList();
            }

            Console.WriteLine($"Name".PadRight(15) + "Aliases".PadRight(15) + "Description");
            results.ForEach((template) =>
            {
                Console.WriteLine($"{template.Name.PadRight(15)  }" + string.Join(',', template.Aliases).PadRight(15) + $".gitignore template for {template.Description} projects");

            });

        }
    }
}