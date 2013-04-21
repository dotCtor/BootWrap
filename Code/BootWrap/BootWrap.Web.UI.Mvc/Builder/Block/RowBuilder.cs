using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootWrap.Web.UI.Mvc.Builder.Base;
using BootWrap.Web.UI.Mvc.Constants;

namespace BootWrap.Web.UI.Mvc.Builder.Block
{
    public class RowBuilder<TModel> : ContainerBuilderBase<TModel, RowBuilder<TModel>>
    {
        private List<SpanBuilder<TModel>> _spans { get; set; }

        public RowBuilder(TModel model)
            : base(HtmlTags.DIV, model)
        {
            this._spans = new List<SpanBuilder<TModel>>();
            this.Class(BootstrapClasses.ROW);
        }

        public RowBuilder<TModel> Span(int spanLenght, Func<SpanBuilder<TModel>, SpanBuilder<TModel>> span)
        {
            SpanBuilder<TModel> spanBuilder = new SpanBuilder<TModel>(this.Model,spanLenght);
            this._spans.Add(span(spanBuilder));
            return this;
        }

        public RowBuilder<TModel> Fluid()
        {
            this.Class(BootstrapClasses.ROW_FLUID);
            return this;
        }

        public override string ToHtmlString()
        {
            this.Html(string.Join(" ",_spans.Select(span => span.ToHtmlString())));
            return base.ToHtmlString();
        }
    }
}
