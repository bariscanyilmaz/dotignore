using System.Collections.Generic;

namespace Models
{
    public class Template
    {
        public Template(string name, string[] aliases, string repoUrl,float rate=0)
        {
            Name = name;
            Aliases = aliases;
            RepoURL = repoUrl;
            Rate=rate;
        }

        public string Name { get; }
        public string[] Aliases { get; }
        public string RepoURL { get; }
        public float Rate { get; set; }


        
    }

    public class Repository
    {
        public static readonly IEnumerable<Template> Templates = new List<Template>()
        {
            new Template(
                name:"csharp",
                aliases:new string [] {"net","dotnet","c#"},
                repoUrl:"VisualStudio"
            ),
            new Template(
                name:"go",
                aliases:new string [] {"golang"},
                repoUrl:"Go"
            ),
            new Template(
                name:"android",
                aliases:new string [0],
                repoUrl:"Android"
            ),
            new Template(
                name:"cpp",
                aliases:new string [] {"c++"},
                repoUrl:"C++"
            ),
            new Template(
                name:"c",
                aliases:new string [0],
                repoUrl:"C"
            ),
            new Template(
                name:"cakephp",
                aliases:new string [0],
                repoUrl:"CakePHP"
            ),
            new Template(
                name:"codeigniter",
                aliases:new string [0] ,
                repoUrl:"CodeIgniter"
            ),
            new Template(
                name:"lisp",
                aliases:new string [] {"commonlisp"},
                repoUrl:"CommonLisp"
            ),
            new Template(
                name:"delphi",
                aliases:new string [0],
                repoUrl:"Delphi"
            ),
            new Template(
                name:"dart",
                aliases:new string [0],
                repoUrl:"Dart"
            ),
            new Template(
                name:"drupal",
                aliases:new string [0],
                repoUrl:"Drupal"
            ),
            new Template(
                name:"eagle",
                aliases:new string [0],
                repoUrl:"Eagle"
            ),
            new Template(
                name:"erlang",
                aliases:new string [0],
                repoUrl:"Erlang"
            ),
            new Template(
                name:"godot",
                aliases:new string [0],
                repoUrl:"Godot"
            ),
            new Template(
                name:"haskell",
                aliases:new string [0],
                repoUrl:"Haskell"
            ),
            new Template(
                name:"java",
                aliases:new string []{"kotlin"},
                repoUrl:"Java"
            ),
            new Template(
                name:"jekyll",
                aliases:new string [0],
                repoUrl:"Jekyll"
            ),
            new Template(
                name:"joomla",
                aliases:new string [0],
                repoUrl:"Joomla"
            ),
            new Template(
                name:"julia",
                aliases:new string [0],
                repoUrl:"Julia"
            ),
            new Template(
                name:"laravel",
                aliases:new string [0],
                repoUrl:"Laravel"
            ),
            new Template(
                name:"lua",
                aliases:new string [0],
                repoUrl:"Lua"
            ),
            new Template(
                name:"magento",
                aliases:new string [0],
                repoUrl:"Magento"
            ),
            new Template(
                name:"maven",
                aliases:new string [0],
                repoUrl:"Maven"
            ),
            new Template(
                name:"objective-c",
                aliases:new string []{"objective-c"},
                repoUrl:"Objective-C"
            ),
            new Template(
                name:"perl",
                aliases:new string [0],
                repoUrl:"Perl"
            ),
            new Template(
                name:"node",
                aliases:new string []{"js","nodejs"},
                repoUrl:"Node"
            ),
            new Template(
                name:"python",
                aliases:new string []{"py","django","flask"},
                repoUrl:"Python"
            ),
            new Template(
                name:"qt",
                aliases:new string [0],
                repoUrl:"Qt"
            ),
            new Template(
                name:"r",
                aliases:new string [0],
                repoUrl:"R"
            ),
            new Template(
                name:"ros",
                aliases:new string [0],
                repoUrl:"ROS"
            ),
            new Template(
                name:"rails",
                aliases:new string [0],
                repoUrl:"Rails"
            ),
            new Template(
                name:"ruby",
                aliases:new string [0],
                repoUrl:"Ruby"
            ),
            new Template(
                name:"rust",
                aliases:new string [0],
                repoUrl:"Rust"
            ),
            new Template(
                name:"rails",
                aliases:new string [0],
                repoUrl:"Rails"
            ),
            new Template(
                name:"smalltalk",
                aliases:new string [0],
                repoUrl:"Smalltalk"
            ),
            new Template(
                name:"swift",
                aliases:new string [0],
                repoUrl:"Swift"
            ),
            new Template(
                name:"symfony",
                aliases:new string [0],
                repoUrl:"Symfony"
            ),
            new Template(
                name:"unity",
                aliases:new string [0],
                repoUrl:"Unity"
            ),
            new Template(
                name:"unreal",
                aliases:new string []{"unrealengine"},
                repoUrl:"UnrealEngine"
            ),
            new Template(
                name:"wordpress",
                aliases:new string [0],
                repoUrl:"WordPress"
            )

        };
    }
}