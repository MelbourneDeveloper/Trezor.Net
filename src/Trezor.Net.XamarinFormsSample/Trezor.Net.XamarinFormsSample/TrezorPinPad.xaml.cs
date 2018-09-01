using System;
using System.Threading.Tasks;
using Xamarin.Forms.Xaml;

namespace Hardfolio.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrezorPinPad
    {
        public event EventHandler OKClicked;

        public string Pin => PinBox.Text;

        public static async Task<string> GetPin()
        {
            var trezorPinPad = new TrezorPinPad();
            await App.MainNavigationPage.Navigation.PushModalAsync(trezorPinPad);
            var taskCompletionSource = new TaskCompletionSource<string>();

            async void CompletedHandler(object s, EventArgs args)
            {
                await App.MainNavigationPage.Navigation.PopAsync();

                App.CurrentApp.NavigateBackToIndex();

                taskCompletionSource.SetResult(trezorPinPad.Pin);
            }

            trezorPinPad.OKClicked += CompletedHandler;

            return await taskCompletionSource.Task;
        }

        public TrezorPinPad()
        {
            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            PinBox.Text += "1";
        }

        private void Button2_Clicked(object sender, EventArgs e)
        {
            PinBox.Text += "2";
        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            PinBox.Text += "3";
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            PinBox.Text += "4";
        }

        private void Button5_Clicked(object sender, EventArgs e)
        {
            PinBox.Text += "5";
        }

        private void Button6_Clicked(object sender, EventArgs e)
        {
            PinBox.Text += "6";
        }

        private void Button7_Clicked(object sender, EventArgs e)
        {
            PinBox.Text += "7";
        }

        private void Button8_Clicked(object sender, EventArgs e)
        {
            PinBox.Text += "8";
        }

        private void Button9_Clicked(object sender, EventArgs e)
        {
            PinBox.Text += "9";
        }

        private void Backspace_Clicked(object sender, EventArgs e)
        {
            if (PinBox.Text?.Length > 0)
            {
                PinBox.Text = PinBox.Text.Substring(0, PinBox.Text.Length - 1);
            }
        }

        private void Enter_Clicked(object sender, EventArgs e)
        {
            if (PinBox.Text == null || PinBox.Text.Length < 1)
            {
                return;
            }

            OKClicked?.Invoke(this, e);
        }
    }
}