using CommandLine;

namespace Options
{
    [Verb("init",isDefault:true,HelpText = "Initialize .gitignore file")]
    public class InitOption
    {
        [Value(0,Required=true,HelpText="Create .gitignore file with given template",MetaName="Template Name",MetaValue="csharp")]
        public string Template { get; set; }

        [Option('a',"append",HelpText="Appends .gitignore template to existing file not overwites")]
        public bool IsAppend { get; set; }
    }

    [Verb("ls", isDefault: false, HelpText = "List .gitignore file templates")]
    public class ListOption
    {
        [Option('q', "query", HelpText = "List only queried templates")]
        public string Query { get; set; }
    }


}