using CommandLine;

namespace Options
{
    [Verb("init",isDefault:true,HelpText = "Initialize .gitignore file")]
    public class InitOption
    {
        [Value(0,Required=true,HelpText="Create .gitignore file with given template")]
        public string Template { get; set; }
    }

    [Verb("ls", isDefault: false, HelpText = "List .gitignore file templates")]
    public class ListOption
    {
        [Option('q', "query", HelpText = "List only queried templates")]
        public string Query { get; set; }
    }


}