using PluginBase;
using System;

namespace HelloPlugin
{
    public class HelloCommand : ICommand
    {
        public string Name { get => "hello"; }
        public string Description { get => "Displays hello message."; }

        public int Execute(NLog.Logger logger)
        {
            Console.WriteLine("Hello !!!");
            return 0;
        }
    }
}
