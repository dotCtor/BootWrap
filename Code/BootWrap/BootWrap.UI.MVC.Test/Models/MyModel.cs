using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BootWrap.UI.MVC.Test.Models
{
    public class MyModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public MySubModel SubModel { get; set; }

        public static MyModel DefaultModel
        {
            get { return new MyModel { Name = "Halil Ibrahim", LastName = "Kalyoncu", Age = 25, SubModel = MySubModel.DefaultModel }; }
        }
    }

    public class MySubModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public static MySubModel DefaultModel
        {
            get { return new MySubModel { Name = "Halil Ibrahim", LastName = "Kalyoncu", Age = 25 }; }
        }
    }
}