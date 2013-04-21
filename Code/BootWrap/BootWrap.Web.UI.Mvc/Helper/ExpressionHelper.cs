using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace BootWrap.Web.UI.Mvc.Helper
{
    public static class ExpressionHelper
    {
        public static TProperty Value<TModel,TProperty>(Expression<Func<TModel, TProperty>> property, TModel model)
        {
            return property.Compile()(model);
        }

        public static string Name<TModel, TProperty>(Expression<Func<TModel, TProperty>> property)
        {
            List<string> propNames = new List<string>();

            MemberExpression exp = property.Body as MemberExpression;
            while (exp != null)
            {
                propNames.Add(exp.Member.Name);
                exp = exp.Expression as MemberExpression;
            }

            propNames.Reverse();
            return string.Join(".", propNames);
        }
    }
}
