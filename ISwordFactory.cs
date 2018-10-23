using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolymorphismDemo.Model;

namespace PolymorphismDemo
{
    public interface ISwordFactory
    {
        AbstractSword CreatSword();
    }
}
