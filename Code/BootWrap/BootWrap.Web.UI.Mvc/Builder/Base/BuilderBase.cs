using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace BootWrap.Web.UI.Mvc.Builder.Base
{
    public abstract class BuilderBase<TModel,TDrerivered> : IHtmlString
        where TDrerivered : BuilderBase<TModel,TDrerivered>
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

        private string _id { get; set; }
        private string _tag { get; set; }
        private string _name { get; set; }
        private List<string> _classes { get; set; }
        private Dictionary<string, string> _styles { get; set; }
        private Dictionary<string, string> _attributes { get; set; }

        protected TModel Model { get; private set; }
        protected string InnerHtml { get; set; }


        public BuilderBase(string tag , TModel model)
        {
            this.Model = model;
            this._tag = tag;
            this._classes = new List<string>();
            this._styles = new Dictionary<string, string>();
            this._attributes = new Dictionary<string, string>();
        }

        public TDrerivered Name(string name)
        {
            this._name = name;
            return this as TDrerivered;
        }

        public TDrerivered Attribute(string key, string value)
        {
            this._attributes.Add(key,value);
            return this as TDrerivered;
        }

        public TDrerivered Class(string cls)
        {
            this._classes.Add(cls);
            return this as TDrerivered;
        }

        public TDrerivered Style(string key, string value)
        {
            this._styles.Add(key,value);
            return this as TDrerivered;
        }

        protected string BuildElement()
        {
            StringBuilder builder = new StringBuilder();

            string tagCloser = string.IsNullOrEmpty(InnerHtml) ? "/" : string.Format("> {0} </",InnerHtml);

            builder.AppendFormat(_elementFormat,
                _tag,
                _id,
                _name,
                string.Join(" ", this._classes),
                string.Join(";", this._styles.Select(item => string.Format("{0}:{1}", item.Key, item.Value))),
                string.Join(" ", this._attributes.Select(attr => string.Format("{0}='{1}'", attr.Key,attr.Value))),
                tagCloser);

            return builder.ToString();
        }

        public string ToHtmlString()
        {
            return BuildElement();
        }
    }
}
