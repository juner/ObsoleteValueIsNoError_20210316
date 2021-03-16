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
        [Obsolete("obsolete value")]
        public string ObsoleteValue { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public override string ToString()
        {
            var value = string.Empty;
#pragma warning disable CS0618
            value += ObsoleteValue;
#pragma warning restore CS0618
            value += " ";
            value += Value;
            return value;
        }
    }
}
