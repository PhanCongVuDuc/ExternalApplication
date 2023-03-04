using Autodesk.Revit.UI;
using ExternalApplication.Library;
using ExternalApplication.UIAttributeBase;
using System.Collections.Generic;
using System;
using System.Linq;

namespace ExternalApplication;

public class CreateUIApp
{
    public static void CreateUI<T>(UIControlledApplication application) where T : class
    {
        var sonnyTab = typeof(T).GetCustomAttributes<TabAttribute>(false).FirstOrDefault();
        if (sonnyTab == null) return;

        application.CreateRibbonTab(sonnyTab.Name);

        var sonnyPanels = typeof(T).GetClassTypes();

        foreach (var sonnyPanel in sonnyPanels)
        {
            var atrSonnyPanel = sonnyPanel.GetCustomAttributes<PanelAttribute>(false).FirstOrDefault();

            atrSonnyPanel.SetData(sonnyTab.Name);
            var ribbonPanel = atrSonnyPanel.CreateRibbonPanel(application);

            List<Type> items = sonnyPanel.GetClassTypes();
            foreach (var item in items)
            {
                object atrItem = item.GetCustomAttributes(false).FirstOrDefault();
                switch (atrItem)
                {
                    case StackedButtonAttribute:
                        var classButtonTypes = item.GetClassTypes();
                        var pushButtonDatas = new List<PushButtonData>();
                        foreach (var classButtonType in classButtonTypes)
                        {
                            var buttonAttribute = classButtonType.GetCustomAttributes<ButtonAttribute>(false)
                                .FirstOrDefault();
                            pushButtonDatas.Add(buttonAttribute.CreatePushButtonData());
                        }

                        ribbonPanel.AddStackedItems(pushButtonDatas);
                        break;
                    case PulldownButtonDataAttribute pulldownButtonDataAttribute:
                        var classButtonTypes1 = item.GetClassTypes();
                        var pulldownButtonData = pulldownButtonDataAttribute.CreatePulldownButtonData();
                        var pulldownButton = (PulldownButton)ribbonPanel.AddItem(pulldownButtonData);
                        foreach (var classButtonType in classButtonTypes1)
                        {
                            var buttonAttribute = classButtonType.GetCustomAttributes<ButtonAttribute>(false)
                                .FirstOrDefault();

                            pulldownButton.AddPushButton(buttonAttribute.CreatePushButtonData());
                        }

                        break;
                    case ButtonAttribute buttonAttribute:
                        var pushButtonData = buttonAttribute.CreatePushButtonData();
                        ribbonPanel.AddItem(pushButtonData);
                        break;
                }
            }
        }
    }
}