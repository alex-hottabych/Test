using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    abstract class Program
	{
		static void Main(string[] args)
		{
			var foo = new Foo();
			foo.DoSomething();
		}

	    public abstract int Foo();

	}
}
