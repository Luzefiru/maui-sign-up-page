using System.Windows.Input;

namespace SignUpPage
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        string myText = "";
        public ICommand TapCommand = new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        private async void OnEntryTextChanged(object sender, EventArgs e)
        {
            myText = FirstName.Text;
            if (myText.Contains('e'))
            {
                await DisplayAlert("Alert", "This contains an 'e'", "OK");
            }
        }

        private void OnEntryCompleted(object sender, EventArgs e)
        {
            myText = ((Entry)sender).Text;
        }
    }

}
