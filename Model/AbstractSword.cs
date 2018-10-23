using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo.Model
{
   public abstract  class AbstractSword
    {
        private string name;
        //public string Name {
        //    get { return name; }
        //    set { value = name; }
        //}

        public void SetName(string str)
        {
           this.name = str;
        }
        public string GetName()
        {
            return name;
        }
    }
}
