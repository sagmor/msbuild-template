namespace DotNetCoreConsoleApp
{
    using System;

    /// <summary>
    /// Sample .Net Core App.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// App entry point.
        /// </summary>
        /// <param name="args">App arguments.</param>
        public static void Main(string[] args)
        {
            var someObject = new SagMor.Samples.MultiFrameworkLibrary.Class1();

            Console.WriteLine(someObject.ToString());
            Console.WriteLine("Hello From DotNet Core!");
        }
    }
}
