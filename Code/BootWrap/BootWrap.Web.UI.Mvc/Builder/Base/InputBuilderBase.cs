using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootWrap.Web.UI.Mvc.Constants;

namespace BootWrap.Web.UI.Mvc.Builder.Base
{
    public abstract class InputBuilderBase<TModel> : BuilderBase<TModel>
    {
        public string Type { set { Attributes["type"] = value; } }
        public string Value { set { Attributes["value"] = value; } }

        public InputBuilderBase()
        {
            this.Tag = HtmlTags.INPUT;
            this.Type = "text";
        }
    }
}
