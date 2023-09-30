﻿namespace ObjectSerializationAttributes
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class IniConfigAttribute : Attribute
    {
        public string FileName { get; }

        public IniConfigAttribute(string fileName)
        {
            FileName = fileName;
        }
    }
}
