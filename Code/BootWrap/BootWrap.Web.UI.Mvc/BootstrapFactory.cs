using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootWrap.Web.UI.Mvc.Builder;
using BootWrap.Web.UI.Mvc.Builder.Block;
using BootWrap.Web.UI.Mvc.Builder.Form;

namespace BootWrap.Web.UI.Mvc
{
    public class BootstrapFactory<TModel>
    {
        private TModel _model { get; set; }

        public BootstrapFactory(TModel model)
        {
            this._model = model;
        }

        public TextBoxBuilder<TModel> TextBox()
        {
            return new TextBoxBuilder<TModel>(_model);
        }

        public RowBuilder<TModel> Row()
        {
            return new RowBuilder<TModel>(_model);
        }

        public SpanBuilder<TModel> Span(int spanLenght = 12)
        {
            return new SpanBuilder<TModel>(_model, spanLenght);
        }
    }
}
