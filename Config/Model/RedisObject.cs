using System;
using Fux.Config.RedisHelper.Attribute;

namespace Fux.Example.Config.Model
{
    /// <summary>
    /// This class maintains the structure of a use
    /// case for the <code>RedisKey</code> attribute
    /// </summary>
    public class RedisObject
    {
        /// <summary>
        /// This property is a <code>bool</code> populated from Redis
        /// </summary>
        /// <value>true</value>
        [RedisKey("fux-example-config-redis-boolean")]
        public bool Boolean { get; set; }

        /// <summary>
        /// This property is a <code>double</code> populated from Redis
        /// </summary>
        /// <value>3.142</value>
        [RedisKey("fux-example-config-redis-double")]
        public double Double { get; set; }

        /// <summary>
        /// This property is an <code>int32</code> populated from Redis
        /// </summary>
        /// <value>42</value>
        [RedisKey("fux-example-config-redis-integer")]
        public int Integer { get; set; }

        /// <summary>
        /// This property is a <code>string</code> populated from Redis
        /// </summary
        /// <value>I think therefore I am</value>
        [RedisKey("fux-example-config-redis-string")]
        public string String { get; set; }
    }
}
