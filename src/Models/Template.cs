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
                description:".NET",
                repoUrl:"VisualStudio"
            ),
            new Template(
                name:"go",
                aliases:new string [] {"golang"},
                description:"Go",
                repoUrl:"Go"
            ),
            new Template(
                name:"android",
                aliases:new string [0],
                description:"Android",
                repoUrl:"Android"
            ),
            new Template(
                name:"cpp",
                aliases:new string [] {"c++"},
                description:"C++",
                repoUrl:"C++"
            ),
            new Template(
                name:"c",
                aliases:new string [0],
                description:"C",
                repoUrl:"C"
            ),
            new Template(
                name:"cakephp",
                aliases:new string [0],
                description:"cakePHP",
                repoUrl:"CakePHP"
            ),
            new Template(
                name:"codeigniter",
                aliases:new string [0] ,
                description:"CodeIngiter",
                repoUrl:"CodeIgniter"
            ),
            new Template(
                name:"lisp",
                aliases:new string [] {"commonlisp"},
                description:"CommonLisp",
                repoUrl:"CommonLisp"
            ),
            new Template(
                name:"delphi",
                aliases:new string [0],
                description:"Delphi",
                repoUrl:"Delphi"
            ),
            new Template(
                name:"dart",
                aliases:new string [0],
                description:"Dart",
                repoUrl:"Dart"
            ),
            new Template(
                name:"drupal",
                aliases:new string [0],
                description:"Drupal",
                repoUrl:"Drupal"
            ),
            new Template(
                name:"eagle",
                aliases:new string [0],
                description:"Eagle",
                repoUrl:"Eagle"
            ),
            new Template(
                name:"erlang",
                aliases:new string [0],
                description:"Erlang",
                repoUrl:"Erlang"
            ),
            new Template(
                name:"godot",
                aliases:new string [0],
                description:"Godot",
                repoUrl:"Godot"
            ),
            new Template(
                name:"haskell",
                aliases:new string [0],
                description:"Haskell",
                repoUrl:"Haskell"
            ),
            new Template(
                name:"java",
                aliases:new string []{"kotlin"},
                description:"Java",
                repoUrl:"Java"
            ),
            new Template(
                name:"jekyll",
                aliases:new string [0],
                description:"Jekyll",
                repoUrl:"Jekyll"
            ),
            new Template(
                name:"joomla",
                aliases:new string [0],
                description:"Joomla",
                repoUrl:"Joomla"
            ),
            new Template(
                name:"julia",
                aliases:new string [0],
                description:"Julia",
                repoUrl:"Julia"
            ),
            new Template(
                name:"laravel",
                aliases:new string [0],
                description:"Laravel",
                repoUrl:"Laravel"
            ),
            new Template(
                name:"lua",
                aliases:new string [0],
                description:"Lua",
                repoUrl:"Lua"
            ),
            new Template(
                name:"magento",
                aliases:new string [0],
                description:"Magento",
                repoUrl:"Magento"
            ),
            new Template(
                name:"maven",
                aliases:new string [0],
                description:"Maven",
                repoUrl:"Maven"
            ),
            new Template(
                name:"node",
                aliases:new string []{"js","nodejs"},
                description:"NodeJS",
                repoUrl:"Node"
            ),
            new Template(
                name:"objective-c",
                aliases:new string []{"objective-c"},
                description:"Objective-C",
                repoUrl:"Objective-C"
            ),
            new Template(
                name:"perl",
                aliases:new string [0],
                description:"Perl",
                repoUrl:"Perl"
            ),
            new Template(
                name:"node",
                aliases:new string []{"js","nodejs"},
                description:"NodeJS",
                repoUrl:"Node"
            ),
            new Template(
                name:"python",
                aliases:new string []{"py","django","flask"},
                description:"Python",
                repoUrl:"Python"
            ),
            new Template(
                name:"qt",
                aliases:new string [0],
                description:"Qt",
                repoUrl:"Qt"
            ),
            new Template(
                name:"r",
                aliases:new string [0],
                description:"R",
                repoUrl:"R"
            ),
            new Template(
                name:"ros",
                aliases:new string [0],
                description:"ROS",
                repoUrl:"ROS"
            ),
            new Template(
                name:"rails",
                aliases:new string [0],
                description:"Rails",
                repoUrl:"Rails"
            ),
            new Template(
                name:"ruby",
                aliases:new string [0],
                description:"Ruby",
                repoUrl:"Ruby"
            ),
            new Template(
                name:"rust",
                aliases:new string [0],
                description:"Rust",
                repoUrl:"Rust"
            ),
            new Template(
                name:"rails",
                aliases:new string [0],
                description:"Rails",
                repoUrl:"Rails"
            ),
            new Template(
                name:"smalltalk",
                aliases:new string [0],
                description:"Smalltalk",
                repoUrl:"Smalltalk"
            ),
            new Template(
                name:"swift",
                aliases:new string [0],
                description:"Swift",
                repoUrl:"Swift"
            ),
            new Template(
                name:"symfony",
                aliases:new string [0],
                description:"Symfony",
                repoUrl:"Symfony"
            ),
            new Template(
                name:"unity",
                aliases:new string [0],
                description:"Unity",
                repoUrl:"Unity"
            ),
            new Template(
                name:"unreal",
                aliases:new string []{"unrealengine"},
                description:"UnrealEngine",
                repoUrl:"UnrealEngine"
            ),
            new Template(
                name:"wordpress",
                aliases:new string [0],
                description:"WordPress",
                repoUrl:"WordPress"
            )

        };
    }
}