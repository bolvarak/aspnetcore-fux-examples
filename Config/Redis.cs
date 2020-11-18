using System;
using System.Threading.Tasks;
using Fux.Config.RedisHelper;
using Newtonsoft.Json;
using Fux.Example.Config.Model;

namespace Fux.Example.Config
{
    /// <summary>
    /// This class is responsible for executing a Fux.Config.Redis example
    /// </summary>
    public class Redis
    {
        /// <summary>
        /// This method runs the Redis example
        /// </summary>
        public static void Run()
        {
            // Localize our redis connection
            EnvironmentConnection<RedisConfiguration> redis =
                Fux.Config.Redis.ConnectFromEnvironment<RedisConfiguration>();
            // Localize our redis string
            string redisString =
                redis.Get("fux-example-config-redis-key");
            // Localize the Redis key object
            RedisKeyObject redisKeyObject =
                redis.Get<RedisKeyObject>();
            // Localize the object from Redis keys
            RedisObject redisObject = redis
                .WithDatabaseAtIndex(0)
                .GetObject<RedisObject>();
            // Log the redis string
            Console.WriteLine($"\n\nRedis String:\t{redisString}\n\n\n");
            // Log the redis key object
            Console.WriteLine($"\n\nRedis Key Object:\n{JsonConvert.SerializeObject(redisKeyObject, Program.JsonSerializerSettings)}\n\n\n");
            // Log the redis object
            Console.WriteLine($"\n\nRedis Object:\n{JsonConvert.SerializeObject(redisObject, Program.JsonSerializerSettings)}\n\n\n");
        }

        /// <summary>
        /// This method runs the Redis example asynchronously
        /// </summary>
        /// <returns></returns>
        public static async Task RunAsync()
        {
            // Localize our redis connection
            EnvironmentConnection<RedisConfiguration> redis =
                Fux.Config.Redis.ConnectFromEnvironment<RedisConfiguration>();
            // Localize our redis string
            string redisString =
                await redis.GetAsync("fux-example-config-redis-key");
            // Localize the Redis key object
            RedisKeyObject redisKeyObject =
                await redis.GetAsync<RedisKeyObject>();
            // Localize the object from Redis keys
            RedisObject redisObject =
                await redis.WithDatabaseAtIndex(0).GetObjectAsync<RedisObject>();
            // Log the redis string
            Console.WriteLine($"\n\nRedis String:\t{redisString}\n\n\n");
            // Log the redis key object
            Console.WriteLine($"\n\nRedis Key Object:\n{JsonConvert.SerializeObject(redisKeyObject, Program.JsonSerializerSettings)}\n\n\n");
            // Log the redis object
            Console.WriteLine($"\n\nRedis Object:\n{JsonConvert.SerializeObject(redisObject, Program.JsonSerializerSettings)}\n\n\n");
        }
    }
}
