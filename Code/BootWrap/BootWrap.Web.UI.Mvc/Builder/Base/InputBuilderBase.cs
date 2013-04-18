using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootWrap.Web.UI.Mvc.Builder.Base
{
    public abstract class InputBuilderBase : BuilderBase
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }
}
