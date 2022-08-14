using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Hesapla
	{
		public Hesapla()
		{
			Topla(10, 2);
			Cikar(10, 2);
			Carp(10, 2);
			Age = 20;
			Log log = new Log();
			log.Logout();
		}
		public int Topla(int a, int b)
		{
			return a + b;
		}
		internal int Cikar(int a, int b)
		{
			
			return a - b;
		}
		protected int Carp(int a, int b)
		{
			
			return a * b;
		}
		protected internal int Age { get; set; }

		private class Log
		{
			public void Logout() 
			{
				Console.WriteLine("Logout metotu");
			}
		}
	}
	
}
