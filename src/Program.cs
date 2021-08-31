using Options;
using Services;
using CommandLine;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace dotignore
{
    class Program
    {
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddHttpClient<WebService>();
            services.AddTransient<FileService>();
            services.AddTransient<TemplateService>();
            var serviceProvider = services.BuildServiceProvider();

            var templateService = serviceProvider.GetService<TemplateService>();

            Parser.Default.ParseArguments<InitOption, ListOption>(args)
            .WithParsedAsync<InitOption>(async options => await templateService.InitializeTemplateAsync(options)).GetAwaiter().GetResult()
            .WithParsed<ListOption>(options =>
            {
                var results= templateService.ListTemplates(options);
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
