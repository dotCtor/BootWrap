﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootWrap.Web.UI.Mvc.Builder.Base;
using BootWrap.Web.UI.Mvc.Constants;

namespace BootWrap.Web.UI.Mvc.Builder
{
    public class ContainerBuilderBase<TModel, TDerivered> : BuilderBase<TModel, TDerivered>
        where TDerivered : ContainerBuilderBase<TModel,TDerivered>
    {
        public ContainerBuilderBase(string tag, TModel model)
            : base(tag, model)
        {}

        //public TDerivered Html(Func<BootstrapFactory<TModel>,BuilderBase> html)
        //{
        //    BootstrapFactory<TModel> factory = new BootstrapFactory<TModel>(this.Model);
        //    this.Html(html(factory).ToHtmlString());
        //    return this as TDerivered;
        //}

        //public TDerivered Html(Func<TModel, object> html)
        //{
        //    this.Html(html(Model).ToString());
        //    return this as TDerivered;
        //}

        //public TDerivered Html(string html)
        //{
        //    this.InnerHtml = html;
        //    return this as TDerivered;
        //}

        public TDerivered Html(Func<TModel, object> html)
        {
            this.Html(html(Model).ToString());
            return this as TDerivered;
        }

        public TDerivered Html(string html)
        {
            this.InnerHtml += html;
            return this as TDerivered;
        }

        public TDerivered Child(Func<BootstrapFactory<TModel>, BuilderBase> html)
        {
            BootstrapFactory<TModel> factory = new BootstrapFactory<TModel>(this.Model);
            this.Html(html(factory).ToHtmlString());
            return this as TDerivered;
        }
    }
}
