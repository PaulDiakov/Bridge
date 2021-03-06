﻿using System;

namespace Bridge
{
    [External]
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
    [NonScriptable]
    public sealed class ConstructorAttribute : Attribute
    {
        public ConstructorAttribute(string value)
        {
        }
    }
}