namespace SagMor.Samples.PowershellModule
{
    using System.Management.Automation;

    /// <summary>
    /// Sample Powershell Cmdlet.
    /// </summary>
    [Cmdlet(VerbsCommon.Get, "AFDSampleHello")]
    public class GetAFDSampleHello : Cmdlet
    {
        /// <summary>
        /// Gets or sets the name to salute.
        /// </summary>
        [Parameter(
            Position = 0,
            Mandatory = true)]
        public string Name { get; set; }

        /// <summary>
        /// Process all the names.
        /// </summary>
        protected override void ProcessRecord()
        {
            this.WriteObject($"Hello {this.Name}!");
        }
    }
}
