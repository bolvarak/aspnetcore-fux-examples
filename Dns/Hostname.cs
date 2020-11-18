using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Fux.Example.Dns
{
    /// <summary>
    /// This class is responsible for executing a Fux.Dns.Hostname example
    /// </summary>
    public class Hostname
    {
        /// <summary>
        /// This property contains the custom domain with which to test
        /// </summary>
        /// <value></value>
        public static string TestCustomDomain { get; set; } = "internal.fux";

        /// <summary>
        /// This proeprty contains a custom hostname and TLD with which to test
        /// </summary>
        /// <value></value>
        public static string TestHostnameCustom { get; set; } = $"asgard.{TestCustomDomain}";

        /// <summary>
        /// This property contains an invalid hostname with which to test
        /// </summary>
        public static string TestHostnameInValid { get; set; } = "moo.bleh.fubar";

        /// <summary>
        /// This property contains a valid hostname with which to test
        /// </summary>
        public static string TestHostnameValid { get; set; } = "asgard.fux.app";

        /// <summary>
        /// This method runs the PublicSuffix Hostname example
        /// </summary>
        public static void Run()
        {
            // Execute our custom test model
            Fux.Dns.Model.Hostname customTest = Fux.Dns.Hostname.Parse(TestHostnameCustom);
            // Execute our invalid test model
            Fux.Dns.Model.Hostname invalidTest = Fux.Dns.Hostname.Parse(TestHostnameInValid);
            // Execute our valid test model
            Fux.Dns.Model.Hostname validTest = Fux.Dns.Hostname.Parse(TestHostnameValid);
            // Dump the custom test
            Console.WriteLine($"\n\n{nameof(customTest)}:\n{JsonConvert.SerializeObject(customTest, Program.JsonSerializerSettings)}\n\n\n");
            // Dump the invalid test
            Console.WriteLine($"\n\n{nameof(invalidTest)}:\n{JsonConvert.SerializeObject(invalidTest, Program.JsonSerializerSettings)}\n\n\n");
            // Dump the valid test
            Console.WriteLine($"\n\n{nameof(validTest)}:\n{JsonConvert.SerializeObject(validTest, Program.JsonSerializerSettings)}\n\n\n");
        }

        /// <summary>
        /// This method runs the PublicSuffix Hostname example asynchronously
        /// </summary>
        /// <returns></returns>
        public static async Task RunAsync()
        {
            // Execute our invalid test model
            Fux.Dns.Model.Hostname invalidTest = await Fux.Dns.Hostname.ParseAsync(TestHostnameInValid);
            // Execute our valid test model
            Fux.Dns.Model.Hostname validTest = await Fux.Dns.Hostname.ParseAsync(TestHostnameValid);
            // Add our custom domain
            Fux.Dns.Hostname.WithCustomTopLevelDomain(TestCustomDomain);
            // Execute our custom test model
            Fux.Dns.Model.Hostname customTest = await Fux.Dns.Hostname.ParseAsync(TestHostnameCustom);
            // Dump the custom test
            Console.WriteLine($"\n\n{nameof(customTest)}:\n{JsonConvert.SerializeObject(customTest, Program.JsonSerializerSettings)}\n\n\n");
            // Dump the invalid test
            Console.WriteLine($"\n\n{nameof(invalidTest)}:\n{JsonConvert.SerializeObject(invalidTest, Program.JsonSerializerSettings)}\n\n\n");
            // Dump the valid test
            Console.WriteLine($"\n\n{nameof(validTest)}:\n{JsonConvert.SerializeObject(validTest, Program.JsonSerializerSettings)}\n\n\n");
        }
    }
}
