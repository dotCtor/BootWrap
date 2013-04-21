using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using BootWrap.Web.UI.Mvc.Builder.Base;

namespace BootWrap.Web.UI.Mvc.Builder
{
    public class TextBoxBuilder<TModel> : InputBuilderBase<TModel>
    {
        public TextBoxBuilder()
            :base()
        {
            this.Type = "text";
            this.Classes.Add("input-small");
        }
    }
}
