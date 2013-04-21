using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootWrap.Web.UI.Mvc.Builder.Base;
using BootWrap.Web.UI.Mvc.Constants;

namespace BootWrap.Web.UI.Mvc.Builder
{
    public class RowBuilder<TModel> : BuilderBase<TModel>
    {
        public RowBuilder(TModel model)
        {
            this.Model = model;
            this.Tag = HtmlTags.DIV;
            this.Classes.Add("row");
        }

        public RowBuilder<TModel> Html(Func<TModel, object> html)
        {
            this.InnerHtml = html(Model).ToString();
            return this;
        }
    }
}
