using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Data;
using PolymorphismDemo.Model;
using PolymorphismDemo.Model.Object;
namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ISwordFactory caocao = new Caocao();
            AbstractSword qixing = caocao.CreatSword();
            Console.WriteLine(qixing.GetName());
            Console.ReadLine();
        }
  
    }
}
