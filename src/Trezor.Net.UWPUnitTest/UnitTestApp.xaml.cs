using System;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Trezor.Net.UWPUnitTest
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    internal sealed partial class App : Application
    {
        #region Events
        public static event EventHandler PinSelected;
        #endregion  

        #region Public Static Properties
        public static string Pin { get; private set; }
        #endregion

        #region Fields
        private TextBlock InstructionsTextBlock = new TextBlock { Margin = new Thickness(2), Text="To run unit tests:\r\n1) Run the test\r\n2) Plug in the device (or have it plugged in already).\r\n3) Wait for the pin display on the device (if it is not unlocked yet).\r\n4) Enter the pin as displayed on the device\r\n5) Click OK." };
        private TextBox PinTextBox = new TextBox { Margin = new Thickness(2), Width = 200, Height = 50, FontSize = 30 };
        private Button PinButton = new Button { Content = "OK" };
        private StackPanel StackPanel = new StackPanel { Orientation = Orientation.Vertical, HorizontalAlignment= HorizontalAlignment.Center, VerticalAlignment= VerticalAlignment.Center };
        #endregion

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            InitializeComponent();
            Suspending += OnSuspending;

            StackPanel.Children.Add(InstructionsTextBlock);
            StackPanel.Children.Add(PinTextBox);
            StackPanel.Children.Add(PinButton);

            PinButton.Click += PinButton_Click;
        }

        private void PinButton_Click(object sender, RoutedEventArgs e)
        {
            Pin = PinTextBox.Text;
            PinSelected?.Invoke(this, new EventArgs());
        }

        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used such as when the application is launched to open a specific file.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {

#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                DebugSettings.EnableFrameRateCounter = true;
            }
#endif

            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                rootFrame.NavigationFailed += OnNavigationFailed;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                rootFrame.Content = StackPanel;

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            Microsoft.VisualStudio.TestPlatform.TestExecutor.UnitTestClient.CreateDefaultUI();

            // Ensure the current window is active
            Window.Current.Activate();

            Microsoft.VisualStudio.TestPlatform.TestExecutor.UnitTestClient.Run(e.Arguments);
        }

        /// <summary>
        /// Invoked when Navigation to a certain page fails
        /// </summary>
        /// <param name="sender">The Frame which failed navigation</param>
        /// <param name="e">Details about the navigation failure</param>
        private void OnNavigationFailed(object sender, NavigationFailedEventArgs e)
        {
            throw new Exception("Failed to load Page " + e.SourcePageType.FullName);
        }

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            //TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}
