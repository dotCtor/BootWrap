using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using BootWrap.Web.UI.Mvc.Builder;

namespace BootWrap.Web.UI.Mvc
{
    public static class Wrapper
    {
        public static WidgetFactory<TModel> Bootstrap<TModel>(this HtmlHelper<TModel> helper)
        {
            return new WidgetFactory<TModel>(helper.ViewData.Model);
        }
    }
}
