using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using BootWrap.Web.UI.Mvc.Constants;
using BootWrap.Web.UI.Mvc.Helper;

namespace BootWrap.Web.UI.Mvc.Builder.Base
{
    public abstract class InputBuilderBase<TModel, TDerivered> : BuilderBase<TModel, TDerivered>
        where TDerivered : InputBuilderBase<TModel,TDerivered>
    {
        protected string _type { set { this.Attribute("type", value); } }
        protected string _value { set { this.Attribute("value", value); } }

        public InputBuilderBase(string type, TModel model)
            : base(HtmlTags.INPUT, model)
        {
            this._type = type;
        }

        public TDerivered Value(object value)
        {
            this._value = value.ToString();
            return this as TDerivered;
        }

        public TDerivered Value<TProperty>(Expression<Func<TModel, TProperty>> property)
        {
            TProperty value = ExpressionHelper.Value(property, Model);
            this.Value(value);

            string name = ExpressionHelper.Name(property);
            this.Name(name);

            return this as TDerivered;
        }

    }
}
