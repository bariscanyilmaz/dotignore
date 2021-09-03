using Options;
using Services;
using CommandLine;
using Microsoft.Extensions.DependencyInjection;
using System;
using Services.Abstract;
using System.IO.Abstractions;

namespace dotignore
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddHttpClient<IWebService, WebService>();
            services.AddTransient<IFileSystem,FileSystem>();
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<ITemplateService, TemplateService>();
            var serviceProvider = services.BuildServiceProvider();

            var templateService = serviceProvider.GetService<ITemplateService>();
            var fileService = serviceProvider.GetService<IFileService>();
            var webService = serviceProvider.GetService<IWebService>();

            Parser.Default.ParseArguments<InitOption, ListOption>(args)
            .WithParsedAsync<InitOption>(async options =>
            {
                var template = templateService.FindTemplate(options);
                if (template != null)
                {
                    var result = await webService.GetTemplateAsync(template.RepoURL) ?? string.Empty;
                    await fileService.CreateIgnoreFileAsync(result);
                }

            }).GetAwaiter().GetResult()
            .WithParsed<ListOption>(options =>
            {
                var results = templateService.ListTemplates(options);
                Console.WriteLine($"Name".PadRight(15) + "Aliases".PadRight(15));
                results.ForEach((template) =>
                {
                    Console.WriteLine($"{template.Name.PadRight(15)  }" + string.Join(',', template.Aliases).PadRight(15));
                });
            })
            .WithNotParsed(errors => errors.Output());
        }

    }
}
