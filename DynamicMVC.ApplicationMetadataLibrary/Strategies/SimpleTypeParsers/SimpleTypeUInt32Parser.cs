using System;
using DynamicMVC.ApplicationMetadataLibrary.Interfaces;
using DynamicMVC.Shared.Enums;
using DynamicMVC.Shared.Interfaces;
using ReflectionLibrary.Enums;

namespace DynamicMVC.ApplicationMetadataLibrary.Strategies.SimpleTypeParsers
{
    /// <summary>
    /// Simple Type Parser for UInt32 datatype
    /// </summary>
    public class SimpleTypeUInt32Parser : ISimpleTypeParser
    {
        public Type GetSimpleType()
        {
            return typeof(uint);
        }

        public dynamic Parse(string value)
        {
            return uint.Parse(value);
        }

        public SimpleTypeEnum SimpleTypeEnum()
        {
            return ReflectionLibrary.Enums.SimpleTypeEnum.UInt32;
        }
    }
}
