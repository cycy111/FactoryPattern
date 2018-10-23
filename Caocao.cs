using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PolymorphismDemo.Model;
using PolymorphismDemo.Model.Object;

namespace PolymorphismDemo
{
    public class Caocao : ISwordFactory
    {
        public AbstractSword CreatSword() {
            return new QixingSword("七星宝剑");
        }
    }
}
