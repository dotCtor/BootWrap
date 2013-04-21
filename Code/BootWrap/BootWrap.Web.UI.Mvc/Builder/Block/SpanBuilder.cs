using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootWrap.Web.UI.Mvc.Constants;

namespace BootWrap.Web.UI.Mvc.Builder.Block
{
    public class SpanBuilder<TModel> : ContainerBuilderBase<TModel, SpanBuilder<TModel>>
    {
        public SpanBuilder(TModel model, int spanLenght)
            : base(HtmlTags.DIV, model)
        {
            this.Class(string.Format(BootstrapClasses.SPAN,spanLenght));
        }

    }
}
