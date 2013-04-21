using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using BootWrap.Web.UI.Mvc.Builder.Base;
using BootWrap.Web.UI.Mvc.Constants;

namespace BootWrap.Web.UI.Mvc.Builder.Form
{
    public class TextBoxBuilder<TModel> : InputBuilderBase<TModel,TextBoxBuilder<TModel>>
    {
        public TextBoxBuilder(TModel model)
            :base(InputTypes.TEXT,model)
        {
        }
    }
}
