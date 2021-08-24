using Options;
using Services;
using CommandLine;
using Microsoft.Extensions.DependencyInjection;

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
            .WithParsed<ListOption>(options => templateService.ListTemplates(options))
            .WithNotParsed(errors => errors.Output());
        }

    }
}
