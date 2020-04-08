namespace SagMor.Samples.MultiFrameworkLibrary
{
    using System;

    /// <summary>
    /// Just a class that throws an exception for example purposes.
    /// </summary>
    public class CrashSample
    {
        /// <summary>
        /// This method is going to throw.
        /// </summary>
        public static void Invoke()
        {
            throw new Exception("I'm just doing what I'm supposed to");
        }
    }
}
