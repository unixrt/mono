using System;
using System.Globalization;
using System.Reflection;
using System.Resources;

internal static class WrapperSR
{
    internal const string InvalidAssemblyHeader = "InvalidAssemblyHeader";

    internal const string InvalidArgumentsToMain = "InvalidArgumentsToMain";

    private static ResourceManager resources;

    private static CultureInfo Culture
    {
        get
        {
            return null;
        }
    }

    private static ResourceManager Resources
    {
        get
        {
            if (WrapperSR.resources == null)
            {
                WrapperSR.resources = new ResourceManager("Microsoft.Workflow.Compiler.StringResources", Assembly.GetExecutingAssembly());
            }
            return WrapperSR.resources;
        }
    }

    static WrapperSR()
    {
    }

    internal static string GetString(string name, params object[] args)
    {
        return WrapperSR.GetString(WrapperSR.Culture, name, args);
    }

    internal static string GetString(CultureInfo culture, string name, params object[] args)
    {
        string str = WrapperSR.Resources.GetString(name, culture);
        if (args == null || (int)args.Length <= 0)
        {
            return str;
        }
        return string.Format(CultureInfo.CurrentCulture, str, args);
    }

    internal static string GetString(string name)
    {
        return WrapperSR.GetString(WrapperSR.Culture, name);
    }

    internal static string GetString(CultureInfo culture, string name)
    {
        return WrapperSR.Resources.GetString(name, culture);
    }
}
