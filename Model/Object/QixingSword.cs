using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo.Model.Object
{
    public class QixingSword:AbstractSword
    {
      public  QixingSword(string name)
        {
            this.SetName ( name);
        }
    }
}
