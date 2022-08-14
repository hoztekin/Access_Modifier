using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Child : Hesapla
	{
		Hesapla H1 = new Hesapla();

		
		public Child()
		{
			H1.Cikar(10,2);
			H1.Topla(10, 2);
			H1.Age = 30;
			Carp(2, 5);
		}
	}
}
