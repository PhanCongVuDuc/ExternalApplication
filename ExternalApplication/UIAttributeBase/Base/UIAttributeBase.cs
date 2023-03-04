using System;

namespace ExternalApplication.UIAttributeBase.Base;

[AttributeUsage(AttributeTargets.Class)]
public class UIAttributeBase : Attribute
{
    public UIAttributeBase(string name)
    {
        Name = name;
    }

    public string Name { get; }
}