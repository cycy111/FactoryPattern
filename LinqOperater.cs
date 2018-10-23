using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace PolymorphismDemo
{
    [System.Data.Linq.Mapping.DatabaseAttribute(Name = "test")]
    public partial class samDataContext : System.Data.Linq.DataContext
    {
        public System.Data.Linq.Table<test> tests
        {
            get
            {
                return this.GetTable<test>();
            }
        }
    }
}
