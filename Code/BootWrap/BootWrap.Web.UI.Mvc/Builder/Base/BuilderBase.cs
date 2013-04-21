using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BootWrap.Web.UI.Mvc.Builder.Base
{
    public abstract class BuilderBase<TModel> : IHtmlString
    {
        /*
         * 0:tag
         * 1:id
         * 2:name
         * 3:classes
         * 4:styles
         * 5:attributes
         * 6:close => 
         *      6.1: '/' for self closed elements
         *      6.2: '> [html] </[tag]' for html container elements
         */
        private readonly string _elementFormat = @"<{0} id='{1}' name='{2}' class='{3}' style='{4}' {5} {6}>";

        public string Id { get; set; }
        public string Tag { get; set; }
        public TModel Model { get; set; }
        public string Name { get; private set; }
        public string InnerHtml { get; protected set; }
        public List<string> Classes { get; private set; }
        public Dictionary<string, string> Styles { get; private set; }
        public Dictionary<string, string> Attributes { get; private set; }

        public BuilderBase()
        {
            this.Classes = new List<string>();
            this.Styles = new Dictionary<string, string>();
            this.Attributes = new Dictionary<string, string>();
        }

        public BuilderBase(string name)
            : this()
        {
            this.Name = name;
        }

        public BuilderBase<TModel> Class(string cls)
        {
            this.Classes.Add(cls);
            return this;
        }

        public BuilderBase<TModel> Style(string key, string value)
        {
            this.Styles.Add(key,value);
            return this;
        }

        protected string BuildElement()
        {
            StringBuilder builder = new StringBuilder();

            string tagCloser = string.IsNullOrEmpty(InnerHtml) ? "/" : string.Format("> {0} </",InnerHtml);

            builder.AppendFormat(_elementFormat,
                Tag,
                Id,
                Name,
                string.Join(" ", this.Classes),
                string.Join(";", this.Styles.Select(item => string.Format("{0}:{1}", item.Key, item.Value))),
                string.Join(" ", this.Attributes.Select(attr => string.Format("{0}='{1}'", attr.Key,attr.Value))),
                tagCloser);

            return builder.ToString();
        }

        public string ToHtmlString()
        {
            return BuildElement();
        }
    }
}
