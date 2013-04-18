using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootWrap.Web.UI.Mvc.Builder;

namespace BootWrap.Web.UI.Mvc
{
    public static class Wrapper
    {
        public static TextBoxBuilder TextBox(string name = null)
        {
            return new TextBoxBuilder();
        }
    }
}
