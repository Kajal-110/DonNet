using System;
using System.Web;
using System.Web.Mvc;

namespace SchoolManagement_SIT0330
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }


    }

    public class  LoginAction : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if(HttpContext.Current.Session["Email"]== null)
            {
            filterContext.Result = new RedirectResult("/Register/Register");
            }
        }
    }

}
