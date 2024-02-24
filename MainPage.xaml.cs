using System.Windows.Input;

namespace SignUpPage
{
    public partial class MainPage : ContentPage
    {
        string FirstNameI = "";
        string LastNameI = "";
        string UsernameI = "";
        string PasswordI = "";
        string ConfirmPasswordI = "";

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnFirstNameChange(object sender, EventArgs e)
        {
            FirstNameI = FirstName.Text;
        }

        private void OnLastNameChange(object sender, EventArgs e)
        {
            LastNameI = LastName.Text;
        }

        private void OnUsernameChange(object sender, EventArgs e)
        {
            UsernameI = Username.Text;
        }

        private void OnPasswordChange(object sender, EventArgs e)
        {
            PasswordI = Password.Text;
        }

        private void OnConfirmPasswordChange(object sender, EventArgs e)
        {
            ConfirmPasswordI = ConfirmPassword.Text;
        }

        private void OnCreateAccount(object sender, EventArgs e)
        {
            string message = "Account registered!";
            string title = "Success";

            if (FirstNameI.Length == 0 ||
                LastNameI.Length == 0 ||
                UsernameI.Length == 0 ||
                PasswordI.Length == 0 ||
                ConfirmPasswordI.Length == 0)
            {
                message = "All fields are required.";
                title = "Error";
            } else if (PasswordI != ConfirmPasswordI)
            {
                message = "Passwords don't match.";
                title = "Error";
            }

            DisplayAlertMessage(title, message);
        }

        private async void DisplayAlertMessage(string title, string message)
        {
            await DisplayAlert(title, message, "OK");
        }
    }

}
