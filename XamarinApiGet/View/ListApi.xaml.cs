using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinApiGet
{
	public partial class ListApi : ContentPage
	{
		Connection cnn;
		public ListApi()
		{
                    InitializeComponent();
						cnn = new Connection();
		}

			async void GetData_Clicked(object sender, System.EventArgs e)
			{
				string urls = "http://10.0.2.2:49961/api/values";

				switch (Device.RuntimePlatform)
				{
				case "iOS": urls="http://localhost:49961/"; break;

				}

				var result = await cnn.userAll(urls);

				listfills.ItemsSource = result;
					}
	}
}
