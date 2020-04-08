namespace SampleExecutable
{
    using System;

    /// <summary>
    /// Sample .Net Program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// App entry point.
        /// </summary>
        /// <param name="args">runtime args.</param>
        public static void Main(string[] args)
        {
            var someObject = new SagMor.Samples.MultiFrameworkLibrary.Class1();

            Console.WriteLine(someObject.ToString());
            Console.WriteLine("Hello From DotNet Core!");
        }
    }
}
