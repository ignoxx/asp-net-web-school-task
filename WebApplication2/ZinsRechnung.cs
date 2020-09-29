using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
	public class ZinsRechnung
	{
		public static Single ZinsesZins(Single startwert, Single zins, Single laufzeit)
		{
			return (Single)(startwert * Math.Pow(1 + zins / 100, laufzeit));
		}
	}
}