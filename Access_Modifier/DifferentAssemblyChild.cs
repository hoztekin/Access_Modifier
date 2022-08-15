using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_Modifier
{
	public class DifferentAssemblyChild : Hesapla
	{
		Hesapla H1 = new Hesapla();
		public DifferentAssemblyChild()
		{
			H1.Topla(10, 2);
			Carp(10, 2);
			Age = 25;
			
		}
	}
}
