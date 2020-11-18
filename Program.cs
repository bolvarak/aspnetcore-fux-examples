using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Fux.Example
{
    /// <summary>
    /// This class maintains the ingress into our program
    /// </summary>
    class Program
    {
        /// <summary>
        /// This property contains the JSON serializer settings used throughout the examples
        /// </summary>
        public static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
        {
            Formatting = Formatting.Indented,
            NullValueHandling = NullValueHandling.Include,
            ReferenceLoopHandling = ReferenceLoopHandling.Serialize
        };

        /// <summary>
        /// This method maintains the main event loop
        /// </summary>
        /// <param name="arguments"></param>
        static async Task Main(string[] arguments)
        {
            // Execute our Hostname example(s)
            await Dns.Hostname.RunAsync();
            // Execute our Redis example(s)
            await Config.Redis.RunAsync();
        }
    }
}
