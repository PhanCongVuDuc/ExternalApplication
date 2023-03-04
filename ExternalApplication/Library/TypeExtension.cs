﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace ExternalApplication.Library;

public static class TypeExtension
{
    public static List<TTypeAtribute> GetCustomAttributes<TTypeAtribute>(this Type type, bool inherit)
    {
        return type.GetCustomAttributes(false).Cast<TTypeAtribute>().ToList();
    }

    public static List<Type> GetClassTypes(this Type type)
    {
        return type.GetNestedTypes(BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public |
                                   BindingFlags.NonPublic)
            .ToList();
    }

    public static List<string> GetClassNames(this Type type)
    {
        return type.GetClassTypes().Select(x => x.FullName).ToList();
    }
}