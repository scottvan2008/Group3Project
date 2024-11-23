using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_final_LibrarySystem.Data
{
	public class NoBookSelectedException : Exception
	{
		public NoBookSelectedException(string message) : base(message)
		{
		}
	}
}
