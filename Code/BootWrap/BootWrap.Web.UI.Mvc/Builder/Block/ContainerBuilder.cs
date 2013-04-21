using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootWrap.Web.UI.Mvc.Builder.Base;
using BootWrap.Web.UI.Mvc.Constants;

namespace BootWrap.Web.UI.Mvc.Builder.Block
{
    public class ContainerBuilder<TModel> : ContainerBuilderBase<TModel, ContainerBuilder<TModel>>
    {
        public ContainerBuilder(TModel model)
            : base(HtmlTags.DIV, model)
        {
            this.Class(BootstrapClasses.CONTAINER);
        }
    }
}
