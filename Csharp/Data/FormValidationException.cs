using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_final_LibrarySystem.Data
{
	public class FormValidationException : Exception
	{
		public FormValidationException(string message) : base(message)
		{
		}
	}

}
