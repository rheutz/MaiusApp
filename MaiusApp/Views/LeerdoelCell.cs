using System;
using Xamarin.Forms;

namespace MaiusApp.Views
{
	public class LeerdoelCell : ViewCell
	{
		public LeerdoelCell ()
		{
			var leerdoel = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				TextColor = Color.Gray,
				FontSize = 16
			};
			leerdoel.SetBinding (Label.TextProperty, "Omschrijving");

			var rating = new Label {
				HorizontalOptions = LayoutOptions.FillAndExpand,
				TextColor = Color.Blue,
				FontSize = 14
			};
			rating.SetBinding (Label.TextProperty, "Waardeering");

			var layout = new StackLayout {
				Orientation = StackOrientation.Vertical,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { leerdoel, rating }
			};

		

			View = layout;
		}
	}
}

