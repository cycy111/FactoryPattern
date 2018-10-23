using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            B b = new  B();
            b.DoWork();
            A a = b;
            a.DoWork();
            C T = new C();
            a = T;
            a.DoWork();
            Console.WriteLine("press any key to exist!");
            Console.ReadLine();
        }
    }
    public class A
    {
        public virtual void DoWork() {
            Console.WriteLine("A.dowork()!");
        }
    }
    public class B : A
    {
        public override void DoWork() {
            Console.WriteLine("B.dowork()!");
        }
    }
    public class C : B
    {
        public sealed override void DoWork() {
            Console.WriteLine("C.dowork()!");
        }
    }
    public class D : C
    {
        public new void DoWork() {
            Console.WriteLine("D.dowork()!");
        }
    }
}
