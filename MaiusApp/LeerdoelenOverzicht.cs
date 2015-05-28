using System;

using Xamarin.Forms;
using System.Collections.Generic;
using MaiusApp.Models;
using MaiusApp.Views;
using System.Linq;
using System.Threading.Tasks;

namespace MaiusApp
{
	public class LeerdoelenOverzicht : ContentPage
	{
		List<Leerdoel> leerDoelen;

		public LeerdoelenOverzicht ()
		{
			//Build schedule
			leerDoelen = new List<Leerdoel> {
				new Leerdoel("Student moet alle onderdelen voldoende afgerond hebben", 0),
				new Leerdoel("De student herkent de component 'weerstand' en kan de voor deze component geldende wetten toepassen.", 0),
				new Leerdoel("De student weet globaal wat een driefasensysteem inhoudt en kent zijn toepassing etc.", 0),
				new Leerdoel("Student moet alle onderdelen voldoende afgerond hebben", 0),
				new Leerdoel("Student moet alle onderdelen voldoende afgerond hebben", 0),
				new Leerdoel("Student moet alle onderdelen voldoende afgerond hebben", 0)

			};


			//Listview
			var listview = new ListView {
				Header = "Start list",
				Footer = "End List",
				ItemsSource = leerDoelen,
				ItemTemplate = new DataTemplate(typeof(LeerdoelCell)),
				HasUnevenRows = true,
				//IsPullToRefreshEnabled = true

			};

			listview.ItemTapped += async (object sender, ItemTappedEventArgs e) => 
			{
				Leerdoel selected = (Leerdoel)listview.SelectedItem;
				var leerdoelpagina = new leerdoelPagina(selected);
				await Navigation.PushAsync(leerdoelpagina);
			};
				


			Content = new StackLayout { 
				Padding = 20,
				Orientation = StackOrientation.Vertical,
				Children = { listview }

			};

		}
	}
}


