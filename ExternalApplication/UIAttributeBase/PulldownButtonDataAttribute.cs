#nullable enable
using Autodesk.Revit.UI;
using ExternalApplication.Library;
using ExternalApplication.UIAttributeBase.Base;
using System;
using System.IO;
using System.Windows.Media.Imaging;

namespace ExternalApplication.UIAttributeBase;

public class PulldownButtonDataAttribute : Base.UIAttributeBase, IRibbonItem
{
    public PulldownButtonDataAttribute(string name) : base(name)
    {
    }

    public string? LinkImage { get; set; } = null;
    public string? ToolTipImage { get; set; } = null;
    public string? LongDescription { get; set; } = null;
    public string? ToolTip { get; set; } = null;
    public string Unique => Name.RemoveWhitespace();

    public PulldownButtonData CreatePulldownButtonData()
    {
        var pulldownButtonData = new PulldownButtonData(Unique, Name);

        if (!string.IsNullOrEmpty(LinkImage))
        {
            var uri = new Uri(Path.Combine(Information.ImagesFolder, LinkImage), UriKind.Absolute);
            var bitmapImage = new BitmapImage(uri);
            pulldownButtonData.LargeImage = bitmapImage;
            pulldownButtonData.Image = bitmapImage;
        }

        if (!string.IsNullOrEmpty(ToolTipImage))
        {
            var uri = new Uri(Path.Combine(Information.ImagesFolder, ToolTipImage), UriKind.Absolute);
            var bitmapImage = new BitmapImage(uri);
            pulldownButtonData.ToolTipImage = bitmapImage;
        }

        if (!string.IsNullOrEmpty(LongDescription))
        {
            pulldownButtonData.LongDescription = LongDescription;
        }

        if (!string.IsNullOrEmpty(ToolTip))
        {
            pulldownButtonData.ToolTip = ToolTip;
        }

        return pulldownButtonData;
    }
}