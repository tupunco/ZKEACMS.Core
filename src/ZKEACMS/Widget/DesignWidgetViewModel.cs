/* http://www.zkea.net/ 
 * Copyright 2017 ZKEASOFT 
 * ������ֽ������Ƽ����޹�˾
 * http://www.zkea.net/licenses */


namespace ZKEACMS.Widget
{
    public class DesignWidgetViewModel : WidgetViewModelPart
    {
        public DesignWidgetViewModel(WidgetViewModelPart widgetPart, string pageId)
        {
            PageID = pageId;
            ViewModel = widgetPart.ViewModel;
            Widget = widgetPart.Widget;
        }
        public string PageID { get; set; }
    }
}