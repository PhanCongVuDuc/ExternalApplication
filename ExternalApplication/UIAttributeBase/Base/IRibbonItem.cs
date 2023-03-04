namespace ExternalApplication.UIAttributeBase.Base;

public interface IRibbonItem
{
    string Unique { get; }
    string LinkImage { get; set; }
    string ToolTipImage { get; set; }
    string LongDescription { get; set; }
    string ToolTip { get; set; }
}