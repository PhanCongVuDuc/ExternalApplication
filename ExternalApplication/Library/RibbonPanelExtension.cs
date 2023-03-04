using Autodesk.Revit.UI;
using System.Collections.Generic;

namespace ExternalApplication.Library;

public static class RibbonPanelExtension
{
    public static IList<RibbonItem> AddStackedItems(this RibbonPanel ribbonPanel, List<PushButtonData> pushButtonDatas)
    {
        const int amount2PushButtonData = 2;
        const int amount3PushButtonData = 3;
        IList<RibbonItem> result = null;
        switch (pushButtonDatas.Count)
        {
            case amount2PushButtonData:
                result = ribbonPanel.AddStackedItems(pushButtonDatas[0], pushButtonDatas[1]);
                break;
            case amount3PushButtonData:
                result = ribbonPanel.AddStackedItems(pushButtonDatas[0], pushButtonDatas[1], pushButtonDatas[2]);
                break;
        }

        return result;
    }
}