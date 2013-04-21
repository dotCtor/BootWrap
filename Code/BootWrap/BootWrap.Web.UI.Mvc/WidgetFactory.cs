using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootWrap.Web.UI.Mvc.Builder;

namespace BootWrap.Web.UI.Mvc
{
    public class WidgetFactory<TModel>
    {
        public TModel Model { get; set; }

        public WidgetFactory(TModel model)
        {
            this.Model = model;
        }

        public TextBoxBuilder<TModel> TextBox()
        {
            return new TextBoxBuilder<TModel>();
        }

        public RowBuilder<TModel> Row()
        {
            return new RowBuilder<TModel>(Model);
        }
    }
}
