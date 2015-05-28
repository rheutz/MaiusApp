using System;

using Xamarin.Forms;
using MaiusApp.Models;

namespace MaiusApp
{
	public class leerdoelPagina : ContentPage
	{
		public leerdoelPagina (Leerdoel leerdoel)
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = leerdoel.Omschrijving + "\n\n" + leerdoel.Waardeering }
				}
			};
		}
	}
}


