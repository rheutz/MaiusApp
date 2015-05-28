using System;
using MaiusApp.Models;

namespace MaiusApp.Models
{
	public class Leerdoel
	{
		public string Omschrijving { get; set; }
		public int Waardeering { get; set; }


		public Leerdoel (string leerdoel, int waardering)
		{
			this.Omschrijving = leerdoel;
			this.Waardeering = waardering;
		}

		public override string ToString()
		{
			return Omschrijving;
		}

	}
}

