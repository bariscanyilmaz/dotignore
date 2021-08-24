using Options;
using CommandLine;

namespace dotignore
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<InitOption, ListOption>(args)
            .WithParsed<InitOption>(option=>RunInitOption(option))
            .WithParsed<ListOption>(option=>RunListOption(option))
            .WithNotParsed(errors=>errors.Output());
        }

        static void RunInitOption(InitOption option)
        {

        }
        static void RunListOption(ListOption option)
        {

        }
    }
}
