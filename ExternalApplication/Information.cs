using System.IO;
using System.Reflection;

namespace ExternalApplication;

public class Information
{
    public static string ExecutingAssembly =>
        Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase));

    public static string AssemblyName { get; set; }

    public static string ImagesFolder => Path.Combine(ExecutingAssembly, "Assets", "Images");
}