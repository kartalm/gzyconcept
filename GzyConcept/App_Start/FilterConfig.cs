using GzyConcept.Areas.ControPanel.Base;
using System.Web.Mvc;

namespace GzyConcept.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new SessionExpireFilterAttribute());
        }
    }

}