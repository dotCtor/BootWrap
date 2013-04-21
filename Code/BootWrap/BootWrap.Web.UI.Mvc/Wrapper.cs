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
        public static BootstrapFactory<TModel> Bootstrap<TModel>(this HtmlHelper<TModel> helper)
        {
            return new BootstrapFactory<TModel>(helper.ViewData.Model);
        }

        public static BootstrapFactory<T> Bootstrap<T>(this HtmlHelper helper, T model)
        {
            return new BootstrapFactory<T>(model);
        }
    }
}
