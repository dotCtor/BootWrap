using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using BootWrap.Web.UI.Mvc.Builder.Base;

namespace BootWrap.Web.UI.Mvc.Builder
{
    public class TextBoxBuilder : InputBuilderBase
    {
        public TextBoxBuilder()
            :base()
        {
            this.Type = "text";
            this.Tag = "input";
            this.Classes.Add("input-small");
            this.Classes.Add("success");
            this.Styles["margin-top"] = "400px";
        }

        //public new MvcHtmlString ToString()
        //{
        //    return new MvcHtmlString("<input class='input-large' type='text' value='adasdadadadasdadad'/>"));
        //}

        public override string ToHtmlString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(@"<{0} name='{1}' id='{2}' class='{3}' style='{4}' type='{5}'/>",
                this.Tag,
                this.Name,
                this.Id,
                string.Join(" ",this.Classes),
                string.Join(";",this.Styles.Select(item => string.Format("{0}:{1}",item.Key,item.Value))),
                this.Type);

            return new MvcHtmlString(sb.ToString()).ToHtmlString();
        }
    }
}
