using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace BootWrap.Web.UI.Mvc.Builder.Base
{
    public abstract class BuilderBase : IHtmlString
    {
        public string Id { get; set; }
        public string Tag { get; set; }
        public string Name { get; private set; }
        public List<string> Classes { get; private set; }
        public Dictionary<string, string> Styles { get; private set; }

        public BuilderBase()
        {
            this.Classes = new List<string>();
            this.Styles = new Dictionary<string, string>();
        }

        public BuilderBase(string name)
            : this()
        {
            this.Name = name;
        }

        public virtual string ToHtmlString()
        {
            throw new NotImplementedException();
        }
    }
}
