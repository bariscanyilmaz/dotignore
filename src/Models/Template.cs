using System.Collections.Generic;

namespace Models
{
    public class Template
    {
        public Template(string name, string[] aliases, string description, string repoUrl)
        {
            Name = name;
            Aliases = aliases;
            Description = description;
            RepoURL = repoUrl;

        }

        public string Name { get; }
        public string[] Aliases { get; }
        public string Description { get; }
        public string RepoURL { get; }
    }

    public class Repository
    {
        public static readonly List<Template> Templates = new List<Template>()
        {
            new Template(
                name:"csharp",
                aliases:new string [] {"net","dotnet","c#"},
                description:".gitginore tempalte for .NET projects",
                repoUrl:"VisualStudio"
            ),
            new Template(
                name:"go",
                aliases:new string [] {"golang"},
                description:".gitginore tempalte for Go projects",
                repoUrl:"Go"
            ),
        };
    }
}