#nullable enable
using Autodesk.Revit.UI;
using ExternalApplication.Library;
using ExternalApplication.UIAttributeBase.Base;
using System;
using System.IO;
using System.Windows.Media.Imaging;

namespace ExternalApplication.UIAttributeBase;

public class ButtonAttribute : Base.UIAttributeBase, IRibbonItem
{
    public ButtonAttribute(string name, string className) : base(name)
    {
        ClassName = className;
    }

    private string ClassName { get; }

    public string Unique => Name.RemoveWhitespace();
    public string? LinkImage { get; set; } = null;
    public string? ToolTipImage { get; set; } = null;
    public string? LongDescription { get; set; } = null;
    public string? ToolTip { get; set; } = null;

    public PushButtonData CreatePushButtonData()
    {
        var buttonData = new PushButtonData(Unique, Name, Information.AssemblyName, ClassName);

        if (!string.IsNullOrEmpty(LinkImage))
        {
            var uri = new Uri(Path.Combine(Information.ImagesFolder, LinkImage), UriKind.Absolute);
            var bitmapImage = new BitmapImage(uri);
            buttonData.LargeImage = bitmapImage;
            buttonData.Image = bitmapImage;
        }

        if (!string.IsNullOrEmpty(ToolTipImage))
        {
            var uri = new Uri(Path.Combine(Information.ImagesFolder, ToolTipImage), UriKind.Absolute);
            var bitmapImage = new BitmapImage(uri);
            buttonData.ToolTipImage = bitmapImage;
        }

        if (!string.IsNullOrEmpty(LongDescription))
        {
            buttonData.LongDescription = LongDescription;
        }

        if (!string.IsNullOrEmpty(ToolTip))
        {
            buttonData.ToolTip = ToolTip;
        }

        return buttonData;
    }

    //public void SetData(string assemblyName, string className)
    //{
    //    ClassName = className;
    //}
}