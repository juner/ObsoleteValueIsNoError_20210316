using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = new Component
            {
                // Expected obsolete error
                ObsoleteValue = "hello",
                Value = "world",
            };
        }
    }
    class Component
    {
        [Obsolete("obsolete value", true)]
        public string ObsoleteValue { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
    }
}
