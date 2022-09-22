using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_CS
{
	 
	public class student
	{
		public string name;
		public int marks;
	   private int totalmarks=1100;


		public decimal percentage
		{
			get
			{
				return Convert.ToDecimal(marks) / Convert.ToDecimal(totalmarks) * 100;
			}
		}
	

	}

	







}
