using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ButtonXaml
{
	public partial class SecondPage : ContentPage
	{
		Job[] jobList;
		public SecondPage()
		{
			InitializeComponent();


			   jobList = new Job[]{
				new Job {
					Name = "Andrew",
					Work = "Pedreiro"
				},
				new Job {
					Name = "Romerio",
					Work = "DragQueen"
				},
				new Job {
					Name = "Isaac",
					Work = "Oferecedor de cu gratuito"
				},
				new Job {
					Name = "Bruno",
					Work = "Master Xamarin Form Axml builder"
				},
				new Job {
					Name = "Joaozinho",
					Work = "Pedreiro"
				},
				new Job {
					Name = "Joaozinho",
					Work = "Pedreiro"
				},
				new Job {
					Name = "Joaozinho",
					Work = "Pedreiro"
				},
				new Job {
					Name = "Joaozinho",
					Work = "Pedreiro"
				},
				new Job {
					Name = "Joaozinho",
					Work = "Pedreiro"
				},
			 
			};

			list.ItemsSource = jobList;
			list.SeparatorColor = Color.Gray;
			list.IsPullToRefreshEnabled = true;

		}

		void Handle_Tapped(object sender, System.EventArgs e)
		{
			//var cell = sender as ViewCell;
			//cell.View.BackgroundColor = Color.Red;
			//var task = Task.Run(() =>  changeColorCellTabbed(cell));
			//if (task.Wait(TimeSpan.FromSeconds(10)))
			//	task.Start();
			//else
			//	throw new Exception("Timed out");
		}

		//void changeColorCellTabbed(ViewCell cell)
		//{
		//	cell.View.BackgroundColor = Color.White;
		//}

		void Handle_Clicked(object sender, ItemTappedEventArgs e)
		{
			var dataItem = e.Item as Job;
			DisplayAlert(dataItem.Name, dataItem.Work, "OK");
			list.SelectedItem = null;
		}

		void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			FilterContacts(e.NewTextValue);
		}



		void FilterContacts(string filter)
		{
			list.BeginRefresh();

			if (string.IsNullOrWhiteSpace(filter))
			{
				list.ItemsSource = jobList;
			}
			else {
				list.ItemsSource = jobList
					.Where(x => x.Name.ToLower()
				   	.Contains(filter.ToLower()));
			}

			list.EndRefresh();
		}

	}
}
