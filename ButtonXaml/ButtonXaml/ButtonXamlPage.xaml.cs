using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ButtonXaml
{
    public partial class ButtonXamlPage
    {
        int count = 0;

        public ButtonXamlPage()
        {
            InitializeComponent();
			//Toolbar items
			var scanItem = new ToolbarItem();
			scanItem.Text = "Scan";
			scanItem.Order = ToolbarItemOrder.Primary;

			var settingsItem = new ToolbarItem();
			settingsItem.Text = "Settings";
			settingsItem.Command = new Command(()=> DisplayAlert("Titulo", "tocou em settings", "OK"));
			settingsItem.Order = ToolbarItemOrder.Primary;

			ToolbarItems.Add(scanItem);
			ToolbarItems.Add(settingsItem);
        }

        public void OnButtonClicked(object sender, EventArgs args)
        {
            count++;
			label.FontSize = 20;
			label.TextColor = Color.FromHex("#ef4023");
			label.Text = "XAML é melhor pnc!! clica maisss ahhhhh";

			RotateEl(img);
			img.Opacity = 1;

			btn.BackgroundColor = Color.FromRgb(10, 52, 86);

            ((Button)sender).Text = 
                String.Format("{0} click{1}!", count, count == 1 ? "" : "s");
        }

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new SecondPage());
		}


		async Task RotateEl(VisualElement el )
		{
			while (true)
			{
				await img.RotateTo(360, 800, Easing.Linear);
				await img.RotateTo(0, 0, Easing.Linear);
			}
		}
    }
}
