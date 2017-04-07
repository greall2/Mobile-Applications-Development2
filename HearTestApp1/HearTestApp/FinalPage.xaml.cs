using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace HearTestApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FinalPage : Page
    {
        Windows.Storage.ApplicationDataContainer localSettings = Windows.Storage.ApplicationData.Current.LocalSettings;


        public FinalPage()
        {
            this.InitializeComponent();

            InitilisedUsernames();



        }

        //Taking in the Result vairbale from Page1 and witing it out to a textBlock ... Adapted from https://docs.microsoft.com/en-us/windows/uwp/layout/navigate-between-two-pages

        protected override void OnNavigatedTo(NavigationEventArgs a)
        {

            if (a.Parameter is string)
            {

                textBlock2.Text = "" + a.Parameter.ToString();

            }

            base.OnNavigatedTo(a);
        }

        private async void ButtonSaveResult_Click(object sender, RoutedEventArgs e)
        {

            string userName = this.textBox.Text.ToString();
            string userData = this.textBlock2.Text.ToString();

            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile users = await storageFolder.CreateFileAsync("HearTestData.txt", CreationCollisionOption.OpenIfExists);

            //Writing usernames and userData to the file
            await FileIO.AppendTextAsync(users, userName + userData + Environment.NewLine);
            //Reading from the file in local storage
            var text = await FileIO.ReadLinesAsync(users);
            var data = await FileIO.ReadLinesAsync(users);

            //writing username and result printing to textblock
            textBlockFinalResult.Text += " \n" + userName + " " + userData;

            textBox.Visibility = Visibility.Collapsed;
            ButtonSaveResult.Visibility = Visibility.Collapsed;
            textBlockFinalResult.Visibility = Visibility.Visible;
            textBlock2.Visibility = Visibility.Collapsed;
            HomeButton2.Visibility = Visibility.Visible;
            textBlock3.Visibility = Visibility.Visible;

        }


        private async void InitilisedUsernames()
        {

            StorageFolder storageFolder = ApplicationData.Current.LocalFolder;
            StorageFile users = await storageFolder.CreateFileAsync("HearTestData.txt", CreationCollisionOption.OpenIfExists);
            var text = await FileIO.ReadLinesAsync(users);

            foreach (var line in text)
            {
                textBlockFinalResult.Text += " \n" + line;
            }

        }

        private void HomeButton2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);
        }
    }
}

