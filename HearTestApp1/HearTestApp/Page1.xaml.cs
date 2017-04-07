using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class Page1 : Page
    {
        public string age;
        public int res1, res2, res3, res4, res5, res6;


        public Page1()
        {
            this.InitializeComponent();
        }


        //*************************     Button1_EventHandler        **************************************
        private async void Button1_Click(object sender, RoutedEventArgs e)
        {
            //Play The sound at MediaElement1
            MediaElement1.Play();


            // Messagedialoge Box that pops up after the sound has played! Adapted from http://stackoverflow.com/questions/22909329/universal-apps-messagebox-the-name-messagebox-does-not-exist-in-the-current
            //Cretaing new dialog with message!
            var dialog = new MessageDialog("Did you hear the sound?");

            //Title of Dialog
            dialog.Title = "Hear it?";

            //Option buttons that appear on the MessageDialogue along with unique IDs
            dialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            dialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
            dialog.Commands.Add(new UICommand { Label = "Play Again", Id = 3 });
            var result1 = await dialog.ShowAsync();
            res1 = (int)result1.Id;

            //if "Yes" is clicked
            if ((int)result1.Id == 0)
            {
                //Make Button1/MediaElement1/textBlock1 Collapsed
                Button1.Visibility = Visibility.Collapsed;
                MediaElement1.Visibility = Visibility.Collapsed;
                textBlock1.Visibility = Visibility.Collapsed;

                //Make Button2/MediaElement2/textBlock2 Visible
                Button2.Visibility = Visibility.Visible;
                MediaElement2.Visibility = Visibility.Visible;
                textBlock2.Visibility = Visibility.Visible;
            }
            // if "No" is clicked 
            if ((int)result1.Id == 1)
            {

                //Make Button1/MediaElement1/textBlock1 Collapsed
                Button1.Visibility = Visibility.Collapsed;
                MediaElement1.Visibility = Visibility.Collapsed;
                textBlock1.Visibility = Visibility.Collapsed;

                //Make Button2/MediaElement2/textBlock2 Collapsed
                Button2.Visibility = Visibility.Collapsed;
                MediaElement2.Visibility = Visibility.Collapsed;
                textBlock2.Visibility = Visibility.Collapsed;

                //Make textBlockResult/SaveButton/HomeButton Visible
                textBlock1Result.Visibility = Visibility.Visible;
                SaveButton.Visibility = Visibility.Visible;
                HomeButton.Visibility = Visibility.Visible;
            }

            //If "Play Again" is clicked 
            else if ((int)result1.Id == 3)
            {
                //Sound at MediaElement1 is palayed
                MediaElement1.Play();

                //Another MessageDialog PopsUp
                dialog = new MessageDialog("Did you hear the sound this time?");
                dialog.Title = "This time?";

                dialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
                dialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
                result1 = await dialog.ShowAsync();


                //if "Yes" is clicked 
                if ((int)result1.Id == 0)
                {
                    //Make Button1/MediaElement1/textBlock1 Collapsed
                    Button1.Visibility = Visibility.Collapsed;
                    MediaElement1.Visibility = Visibility.Collapsed;
                    textBlock1.Visibility = Visibility.Collapsed;

                    //Make Button2/MediaElement2/textBlock2 Visible 
                    Button2.Visibility = Visibility.Visible;
                    MediaElement2.Visibility = Visibility.Visible;
                    textBlock2.Visibility = Visibility.Visible;

                }
                // if "No" is clicked  
                if ((int)result1.Id == 1)
                {


                    //Make Button1/MediaElement1/textBlock1 Collapsed
                    Button1.Visibility = Visibility.Collapsed;
                    MediaElement1.Visibility = Visibility.Collapsed;
                    textBlock1.Visibility = Visibility.Collapsed;

                    //Make Button2/MediaElement2/textBlock2 Collapsed
                    Button2.Visibility = Visibility.Collapsed;
                    MediaElement2.Visibility = Visibility.Collapsed;
                    textBlock2.Visibility = Visibility.Collapsed;

                    //Make textBlockResult/SaveButton/HomeButton Visible
                    textBlock1Result.Visibility = Visibility.Visible;
                    SaveButton.Visibility = Visibility.Visible;
                    HomeButton.Visibility = Visibility.Visible;

                }

            }
        }





        // **************************************    Button2_EventHandler        **************************************

        private async void Button2_Click(object sender, RoutedEventArgs e)
        {
            MediaElement2.Play();



            var dialog = new MessageDialog("Did you hear the sound?");
            dialog.Title = "Hear it?";
            dialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            dialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
            dialog.Commands.Add(new UICommand { Label = "Play Again", Id = 3 });
            var result2 = await dialog.ShowAsync();
            res2 = res1 = (int)result2.Id;

            //if "Yes" is clicked
            if ((int)result2.Id == 0)
            {
                Button1.Visibility = Visibility.Collapsed;
                MediaElement1.Visibility = Visibility.Collapsed;
                textBlock1.Visibility = Visibility.Collapsed;

                Button2.Visibility = Visibility.Collapsed;
                MediaElement2.Visibility = Visibility.Collapsed;
                textBlock2.Visibility = Visibility.Collapsed;

                Button3.Visibility = Visibility.Visible;
                MediaElement3.Visibility = Visibility.Visible;
                textBlock3.Visibility = Visibility.Visible;

            }
            // if "No" is clicked 
            if ((int)result2.Id == 1)
            {


                Button1.Visibility = Visibility.Collapsed;
                MediaElement1.Visibility = Visibility.Collapsed;
                textBlock1.Visibility = Visibility.Collapsed;

                Button2.Visibility = Visibility.Collapsed;
                MediaElement2.Visibility = Visibility.Collapsed;
                textBlock2.Visibility = Visibility.Collapsed;

                Button3.Visibility = Visibility.Collapsed;
                MediaElement3.Visibility = Visibility.Collapsed;
                textBlock3.Visibility = Visibility.Collapsed;

                textBlock2Result.Visibility = Visibility.Visible;
                SaveButton.Visibility = Visibility.Visible;
                HomeButton.Visibility = Visibility.Visible;


            }
            //If "Play Again" is clicked then the sound plays again
            else if ((int)result2.Id == 3)
            {
                MediaElement2.Play();

                dialog = new MessageDialog("Did you hear the sound this time?");
                dialog.Title = "This time?";

                dialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
                dialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
                result2 = await dialog.ShowAsync();
                //if "Yes" is clicked
                if ((int)result2.Id == 0)
                {
                    Button1.Visibility = Visibility.Collapsed;
                    MediaElement1.Visibility = Visibility.Collapsed;
                    textBlock1.Visibility = Visibility.Collapsed;

                    Button2.Visibility = Visibility.Collapsed;
                    MediaElement2.Visibility = Visibility.Collapsed;
                    textBlock2.Visibility = Visibility.Collapsed;

                    Button3.Visibility = Visibility.Visible;
                    MediaElement3.Visibility = Visibility.Visible;
                    textBlock3.Visibility = Visibility.Visible;
                }
                // if "No" is clicked 
                if ((int)result2.Id == 1)
                {

                    Button1.Visibility = Visibility.Collapsed;
                    MediaElement1.Visibility = Visibility.Collapsed;
                    textBlock1.Visibility = Visibility.Collapsed;

                    Button2.Visibility = Visibility.Collapsed;
                    MediaElement2.Visibility = Visibility.Collapsed;
                    textBlock2.Visibility = Visibility.Collapsed;

                    Button3.Visibility = Visibility.Collapsed;
                    MediaElement3.Visibility = Visibility.Collapsed;
                    textBlock3.Visibility = Visibility.Collapsed;

                    textBlock2Result.Visibility = Visibility.Visible;
                    SaveButton.Visibility = Visibility.Visible;
                    HomeButton.Visibility = Visibility.Visible;
                }
            }


        }


        // **************************************    Button3_EventHandler        **************************************

        private async void Button3_Click(object sender, RoutedEventArgs e)
        {
            MediaElement3.Play();


            var dialog = new MessageDialog("Did you hear the sound?");
            dialog.Title = "Hear it?";
            dialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            dialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
            dialog.Commands.Add(new UICommand { Label = "Play Again", Id = 3 });
            var result3 = await dialog.ShowAsync();
            res3 = (int)result3.Id;
            //if "Yes" is clicked
            if ((int)result3.Id == 0)
            {
                Button1.Visibility = Visibility.Collapsed;
                MediaElement1.Visibility = Visibility.Collapsed;
                textBlock1.Visibility = Visibility.Collapsed;

                Button2.Visibility = Visibility.Collapsed;
                MediaElement2.Visibility = Visibility.Collapsed;
                textBlock2.Visibility = Visibility.Collapsed;

                Button3.Visibility = Visibility.Collapsed;
                MediaElement3.Visibility = Visibility.Collapsed;
                textBlock3.Visibility = Visibility.Collapsed;

                Button4.Visibility = Visibility.Visible;
                MediaElement4.Visibility = Visibility.Visible;
                textBlock4.Visibility = Visibility.Visible;

            }
            // if "No" is clicked 
            if ((int)result3.Id == 1)
            {

                Button1.Visibility = Visibility.Collapsed;
                MediaElement1.Visibility = Visibility.Collapsed;
                textBlock1.Visibility = Visibility.Collapsed;

                Button2.Visibility = Visibility.Collapsed;
                MediaElement2.Visibility = Visibility.Collapsed;
                textBlock2.Visibility = Visibility.Collapsed;

                Button3.Visibility = Visibility.Collapsed;
                MediaElement3.Visibility = Visibility.Collapsed;
                textBlock3.Visibility = Visibility.Collapsed;

                Button4.Visibility = Visibility.Collapsed;
                MediaElement4.Visibility = Visibility.Collapsed;
                textBlock4.Visibility = Visibility.Collapsed;

                textBlock3Result.Visibility = Visibility;
                SaveButton.Visibility = Visibility.Visible;
                HomeButton.Visibility = Visibility.Visible;
            }
            //If "Play Again" is clicked then the sound plays again
            else if ((int)result3.Id == 3)
            {
                MediaElement3.Play();

                dialog = new MessageDialog("Did you hear the sound this time?");
                dialog.Title = "This time?";

                dialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
                dialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
                result3 = await dialog.ShowAsync();
                res3 = (int)result3.Id;
                //if "Yes" is clicked 
                if ((int)result3.Id == 0)
                {
                    Button1.Visibility = Visibility.Collapsed;
                    MediaElement1.Visibility = Visibility.Collapsed;
                    textBlock1.Visibility = Visibility.Collapsed;

                    Button2.Visibility = Visibility.Collapsed;
                    MediaElement2.Visibility = Visibility.Collapsed;
                    textBlock2.Visibility = Visibility.Collapsed;

                    Button3.Visibility = Visibility.Collapsed;
                    MediaElement3.Visibility = Visibility.Collapsed;
                    textBlock3.Visibility = Visibility.Collapsed;

                    Button4.Visibility = Visibility.Visible;
                    MediaElement4.Visibility = Visibility.Visible;
                    textBlock4.Visibility = Visibility.Visible;
                }
                // if "No" is clicked 
                if ((int)result3.Id == 1)
                {

                    Button1.Visibility = Visibility.Collapsed;
                    MediaElement1.Visibility = Visibility.Collapsed;
                    textBlock1.Visibility = Visibility.Collapsed;

                    Button2.Visibility = Visibility.Collapsed;
                    MediaElement2.Visibility = Visibility.Collapsed;
                    textBlock2.Visibility = Visibility.Collapsed;

                    Button3.Visibility = Visibility.Collapsed;
                    MediaElement3.Visibility = Visibility.Collapsed;
                    textBlock3.Visibility = Visibility.Collapsed;

                    Button4.Visibility = Visibility.Collapsed;
                    MediaElement4.Visibility = Visibility.Collapsed;
                    textBlock4.Visibility = Visibility.Collapsed;

                    textBlock3Result.Visibility = Visibility;
                    SaveButton.Visibility = Visibility.Visible;
                    HomeButton.Visibility = Visibility.Visible;
                }
            }

        }


        // **************************************    Button4_EventHandler        **************************************

        private async void Button4_Click(object sender, RoutedEventArgs e)
        {
            MediaElement4.Play();

            var dialog = new MessageDialog("Did you hear the sound?");
            dialog.Title = "Hear it?";
            dialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            dialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
            dialog.Commands.Add(new UICommand { Label = "Play Again", Id = 3 });
            var result4 = await dialog.ShowAsync();
            res4 = (int)result4.Id;
            //if "Yes" is clicked 
            if ((int)result4.Id == 0)
            {
                Button1.Visibility = Visibility.Collapsed;
                MediaElement1.Visibility = Visibility.Collapsed;
                textBlock1.Visibility = Visibility.Collapsed;

                Button2.Visibility = Visibility.Collapsed;
                MediaElement2.Visibility = Visibility.Collapsed;
                textBlock2.Visibility = Visibility.Collapsed;

                Button3.Visibility = Visibility.Collapsed;
                MediaElement3.Visibility = Visibility.Collapsed;
                textBlock3.Visibility = Visibility.Collapsed;

                Button4.Visibility = Visibility.Collapsed;
                MediaElement4.Visibility = Visibility.Collapsed;
                textBlock4.Visibility = Visibility.Collapsed;

                Button5.Visibility = Visibility.Visible;
                MediaElement5.Visibility = Visibility.Visible;
                textBlock5.Visibility = Visibility.Visible;



            }
            // if "No" is clicked 
            if ((int)result4.Id == 1)
            {
                Button1.Visibility = Visibility.Collapsed;
                MediaElement1.Visibility = Visibility.Collapsed;
                textBlock1.Visibility = Visibility.Collapsed;

                Button2.Visibility = Visibility.Collapsed;
                MediaElement2.Visibility = Visibility.Collapsed;
                textBlock2.Visibility = Visibility.Collapsed;

                Button3.Visibility = Visibility.Collapsed;
                MediaElement3.Visibility = Visibility.Collapsed;
                textBlock3.Visibility = Visibility.Collapsed;

                Button4.Visibility = Visibility.Collapsed;
                MediaElement4.Visibility = Visibility.Collapsed;
                textBlock4.Visibility = Visibility.Collapsed;


                Button5.Visibility = Visibility.Collapsed;
                MediaElement5.Visibility = Visibility.Collapsed;
                textBlock5.Visibility = Visibility.Collapsed;

                textBlock4Result.Visibility = Visibility.Visible;
                SaveButton.Visibility = Visibility.Visible;
                HomeButton.Visibility = Visibility.Visible;


            }
            //If "Play Again" is clicked then the sound plays again
            else if ((int)result4.Id == 3)
            {
                MediaElement4.Play();


                dialog = new MessageDialog("Did you hear the sound this time?");
                dialog.Title = "This time?";

                dialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
                dialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
                result4 = await dialog.ShowAsync();
                //if "Yes" is clicked 
                if ((int)result4.Id == 0)
                {
                    Button1.Visibility = Visibility.Collapsed;
                    MediaElement1.Visibility = Visibility.Collapsed;
                    textBlock1.Visibility = Visibility.Collapsed;

                    Button2.Visibility = Visibility.Collapsed;
                    MediaElement2.Visibility = Visibility.Collapsed;
                    textBlock2.Visibility = Visibility.Collapsed;

                    Button3.Visibility = Visibility.Collapsed;
                    MediaElement3.Visibility = Visibility.Collapsed;
                    textBlock3.Visibility = Visibility.Collapsed;

                    Button4.Visibility = Visibility.Collapsed;
                    MediaElement4.Visibility = Visibility.Collapsed;
                    textBlock4.Visibility = Visibility.Collapsed;

                    Button5.Visibility = Visibility.Visible;
                    MediaElement5.Visibility = Visibility.Visible;
                    textBlock5.Visibility = Visibility.Visible;
                }
                // if "No" is clicked 
                if ((int)result4.Id == 1)
                {
                    Button1.Visibility = Visibility.Collapsed;
                    MediaElement1.Visibility = Visibility.Collapsed;
                    textBlock1.Visibility = Visibility.Collapsed;

                    Button2.Visibility = Visibility.Collapsed;
                    MediaElement2.Visibility = Visibility.Collapsed;
                    textBlock2.Visibility = Visibility.Collapsed;

                    Button3.Visibility = Visibility.Collapsed;
                    MediaElement3.Visibility = Visibility.Collapsed;
                    textBlock3.Visibility = Visibility.Collapsed;

                    Button4.Visibility = Visibility.Collapsed;
                    MediaElement4.Visibility = Visibility.Collapsed;
                    textBlock4.Visibility = Visibility.Collapsed;


                    Button5.Visibility = Visibility.Collapsed;
                    MediaElement5.Visibility = Visibility.Collapsed;
                    textBlock5.Visibility = Visibility.Collapsed;

                    textBlock4Result.Visibility = Visibility.Visible;
                    SaveButton.Visibility = Visibility.Visible;
                    HomeButton.Visibility = Visibility.Visible;
                }
            }
        }


        // **************************************    Button5_EventHandler        **************************************

        private async void Button5_Click(object sender, RoutedEventArgs e)
        {
            MediaElement5.Play();

            var dialog = new MessageDialog("Did you hear the sound?");
            dialog.Title = "Hear it?";
            dialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            dialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
            dialog.Commands.Add(new UICommand { Label = "Play Again", Id = 3 });
            var result5 = await dialog.ShowAsync();
            res5 = (int)result5.Id;
            //if "Yes" is clicked 
            if ((int)result5.Id == 0)
            {
                Button1.Visibility = Visibility.Collapsed;
                MediaElement1.Visibility = Visibility.Collapsed;
                textBlock1.Visibility = Visibility.Collapsed;

                Button2.Visibility = Visibility.Collapsed;
                MediaElement2.Visibility = Visibility.Collapsed;
                textBlock2.Visibility = Visibility.Collapsed;

                Button3.Visibility = Visibility.Collapsed;
                MediaElement3.Visibility = Visibility.Collapsed;
                textBlock3.Visibility = Visibility.Collapsed;

                Button4.Visibility = Visibility.Collapsed;
                MediaElement4.Visibility = Visibility.Collapsed;
                textBlock4.Visibility = Visibility.Collapsed;

                Button5.Visibility = Visibility.Collapsed;
                MediaElement5.Visibility = Visibility.Collapsed;
                textBlock5.Visibility = Visibility.Collapsed;

                Button6.Visibility = Visibility.Visible;
                MediaElement6.Visibility = Visibility.Visible;
                textBlock6.Visibility = Visibility.Visible;



            }
            // if "No" is clicked 
            if ((int)result5.Id == 1)
            {
                Button1.Visibility = Visibility.Collapsed;
                MediaElement1.Visibility = Visibility.Collapsed;
                textBlock1.Visibility = Visibility.Collapsed;

                Button2.Visibility = Visibility.Collapsed;
                MediaElement2.Visibility = Visibility.Collapsed;
                textBlock2.Visibility = Visibility.Collapsed;

                Button3.Visibility = Visibility.Collapsed;
                MediaElement3.Visibility = Visibility.Collapsed;
                textBlock3.Visibility = Visibility.Collapsed;

                Button4.Visibility = Visibility.Collapsed;
                MediaElement4.Visibility = Visibility.Collapsed;
                textBlock4.Visibility = Visibility.Collapsed;

                Button5.Visibility = Visibility.Collapsed;
                MediaElement5.Visibility = Visibility.Collapsed;
                textBlock5.Visibility = Visibility.Collapsed;

                textBlock5Result.Visibility = Visibility.Visible;
                SaveButton.Visibility = Visibility.Visible;
                HomeButton.Visibility = Visibility.Visible;
            }
            //If "Play Again" is clicked then the sound plays again
            else if ((int)result5.Id == 3)
            {
                MediaElement5.Play();

                dialog = new MessageDialog("Did you hear the sound this time?");
                dialog.Title = "This time?";

                dialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
                dialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
                result5 = await dialog.ShowAsync();
                //if "Yes" is clicked 
                if ((int)result5.Id == 0)
                {
                    Button1.Visibility = Visibility.Collapsed;
                    MediaElement1.Visibility = Visibility.Collapsed;
                    textBlock1.Visibility = Visibility.Collapsed;

                    Button2.Visibility = Visibility.Collapsed;
                    MediaElement2.Visibility = Visibility.Collapsed;
                    textBlock2.Visibility = Visibility.Collapsed;

                    Button3.Visibility = Visibility.Collapsed;
                    MediaElement3.Visibility = Visibility.Collapsed;
                    textBlock3.Visibility = Visibility.Collapsed;

                    Button4.Visibility = Visibility.Collapsed;
                    MediaElement4.Visibility = Visibility.Collapsed;
                    textBlock4.Visibility = Visibility.Collapsed;

                    Button5.Visibility = Visibility.Collapsed;
                    MediaElement5.Visibility = Visibility.Collapsed;
                    textBlock5.Visibility = Visibility.Collapsed;

                    Button6.Visibility = Visibility.Visible;
                    MediaElement6.Visibility = Visibility.Visible;
                    textBlock6.Visibility = Visibility.Visible;

                }
                // if "No" is clicked 
                if ((int)result5.Id == 1)
                {
                    Button1.Visibility = Visibility.Collapsed;
                    MediaElement1.Visibility = Visibility.Collapsed;
                    textBlock1.Visibility = Visibility.Collapsed;

                    Button2.Visibility = Visibility.Collapsed;
                    MediaElement2.Visibility = Visibility.Collapsed;
                    textBlock2.Visibility = Visibility.Collapsed;

                    Button3.Visibility = Visibility.Collapsed;
                    MediaElement3.Visibility = Visibility.Collapsed;
                    textBlock3.Visibility = Visibility.Collapsed;

                    Button4.Visibility = Visibility.Collapsed;
                    MediaElement4.Visibility = Visibility.Collapsed;
                    textBlock4.Visibility = Visibility.Collapsed;

                    Button5.Visibility = Visibility.Collapsed;
                    MediaElement5.Visibility = Visibility.Collapsed;
                    textBlock5.Visibility = Visibility.Collapsed;

                    textBlock5Result.Visibility = Visibility.Visible;
                    SaveButton.Visibility = Visibility.Visible;
                    HomeButton.Visibility = Visibility.Visible;
                }
            }


        }


        // **************************************    Button6_EventHandler        **************************************

        private async void Button6_Click(object sender, RoutedEventArgs e)
        {
            MediaElement6.Play();

            var dialog = new MessageDialog("Did you hear the sound?");
            dialog.Title = "Hear it?";
            dialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
            dialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
            dialog.Commands.Add(new UICommand { Label = "Play Again", Id = 3 });
            var result6 = await dialog.ShowAsync();
            res6 = (int)result6.Id;
            //if "Yes" is clicked 
            if ((int)result6.Id == 0)
            {
                Button1.Visibility = Visibility.Collapsed;
                MediaElement1.Visibility = Visibility.Collapsed;
                textBlock1.Visibility = Visibility.Collapsed;

                Button2.Visibility = Visibility.Collapsed;
                MediaElement2.Visibility = Visibility.Collapsed;
                textBlock2.Visibility = Visibility.Collapsed;

                Button3.Visibility = Visibility.Collapsed;
                MediaElement3.Visibility = Visibility.Collapsed;
                textBlock3.Visibility = Visibility.Collapsed;

                Button4.Visibility = Visibility.Collapsed;
                MediaElement4.Visibility = Visibility.Collapsed;
                textBlock4.Visibility = Visibility.Collapsed;

                Button5.Visibility = Visibility.Collapsed;
                MediaElement5.Visibility = Visibility.Collapsed;
                textBlock5.Visibility = Visibility.Collapsed;

                Button6.Visibility = Visibility.Collapsed;
                MediaElement6.Visibility = Visibility.Collapsed;
                textBlock6.Visibility = Visibility.Collapsed;

                textBlock7Result.Visibility = Visibility.Visible;
                SaveButton.Visibility = Visibility.Visible;
                HomeButton.Visibility = Visibility.Visible;


            }
            // if "No" is clicked
            if ((int)result6.Id == 1)
            {
                Button1.Visibility = Visibility.Collapsed;
                MediaElement1.Visibility = Visibility.Collapsed;
                textBlock1.Visibility = Visibility.Collapsed;

                Button2.Visibility = Visibility.Collapsed;
                MediaElement2.Visibility = Visibility.Collapsed;
                textBlock2.Visibility = Visibility.Collapsed;

                Button3.Visibility = Visibility.Collapsed;
                MediaElement3.Visibility = Visibility.Collapsed;
                textBlock3.Visibility = Visibility.Collapsed;

                Button4.Visibility = Visibility.Collapsed;
                MediaElement4.Visibility = Visibility.Collapsed;
                textBlock4.Visibility = Visibility.Collapsed;

                Button5.Visibility = Visibility.Collapsed;
                MediaElement5.Visibility = Visibility.Collapsed;
                textBlock5.Visibility = Visibility.Collapsed;

                Button6.Visibility = Visibility.Collapsed;
                MediaElement6.Visibility = Visibility.Collapsed;
                textBlock6.Visibility = Visibility.Collapsed;

                textBlock6Result.Visibility = Visibility.Visible;
                SaveButton.Visibility = Visibility.Visible;
                HomeButton.Visibility = Visibility.Visible;
            }
            //If "Play Again" is clicked then the sound plays again
            else if ((int)result6.Id == 3)
            {
                MediaElement5.Play();

                dialog = new MessageDialog("Did you hear the sound this time?");
                dialog.Title = "This time?";

                dialog.Commands.Add(new UICommand { Label = "Yes", Id = 0 });
                dialog.Commands.Add(new UICommand { Label = "No", Id = 1 });
                result6 = await dialog.ShowAsync();
                //if "Yes" is clicked navigate to home page (TEST)
                if ((int)result6.Id == 0)
                {
                    Button1.Visibility = Visibility.Collapsed;
                    MediaElement1.Visibility = Visibility.Collapsed;
                    textBlock1.Visibility = Visibility.Collapsed;

                    Button2.Visibility = Visibility.Collapsed;
                    MediaElement2.Visibility = Visibility.Collapsed;
                    textBlock2.Visibility = Visibility.Collapsed;

                    Button3.Visibility = Visibility.Collapsed;
                    MediaElement3.Visibility = Visibility.Collapsed;
                    textBlock3.Visibility = Visibility.Collapsed;

                    Button4.Visibility = Visibility.Collapsed;
                    MediaElement4.Visibility = Visibility.Collapsed;
                    textBlock4.Visibility = Visibility.Collapsed;

                    Button5.Visibility = Visibility.Collapsed;
                    MediaElement5.Visibility = Visibility.Collapsed;
                    textBlock5.Visibility = Visibility.Collapsed;

                    Button6.Visibility = Visibility.Collapsed;
                    MediaElement6.Visibility = Visibility.Collapsed;
                    textBlock6.Visibility = Visibility.Collapsed;

                    textBlock7Result.Visibility = Visibility.Visible;
                    SaveButton.Visibility = Visibility.Visible;
                    HomeButton.Visibility = Visibility.Visible;

                }
                // if "No" is clicked 
                if ((int)result6.Id == 1)
                {
                    Button1.Visibility = Visibility.Collapsed;
                    MediaElement1.Visibility = Visibility.Collapsed;
                    textBlock1.Visibility = Visibility.Collapsed;

                    Button2.Visibility = Visibility.Collapsed;
                    MediaElement2.Visibility = Visibility.Collapsed;
                    textBlock2.Visibility = Visibility.Collapsed;

                    Button3.Visibility = Visibility.Collapsed;
                    MediaElement3.Visibility = Visibility.Collapsed;
                    textBlock3.Visibility = Visibility.Collapsed;

                    Button4.Visibility = Visibility.Collapsed;
                    MediaElement4.Visibility = Visibility.Collapsed;
                    textBlock4.Visibility = Visibility.Collapsed;

                    Button5.Visibility = Visibility.Collapsed;
                    MediaElement5.Visibility = Visibility.Collapsed;
                    textBlock5.Visibility = Visibility.Collapsed;

                    Button6.Visibility = Visibility.Collapsed;
                    MediaElement6.Visibility = Visibility.Collapsed;
                    textBlock6.Visibility = Visibility.Collapsed;

                    textBlock6Result.Visibility = Visibility.Visible;
                    SaveButton.Visibility = Visibility.Visible;
                    HomeButton.Visibility = Visibility.Visible;
                }
            }



        }



        private void SaveButton_Click(object sender, RoutedEventArgs a)

        {
            var result = " ";
            // if statements setting the age of result depending on which sound is not heard
            if (res1 == 1)
            {
                age = "Bad";
                result = "\t    " + age;
            }
            else if (res2 == 1)
            {
                age = "50";
                result = "\t    >" + age;
            }
            else if (res3 == 1)
            {
                age = "40";
                result = "\t    >" + age;
            }
            else if (res4 == 1)
            {
                age = "30";
                result = "\t    >" + age;
            }
            else if (res5 == 1)
            {
                age = "24";
                result = "\t    >" + age;
            }
            else if (res6 == 1)
            {
                age = "20";
                result = "\t    >" + age;
            }
            else if (res6 == 0)
            {
                age = "20";
                result = "\t    <" + age;
            }

            this.Frame.Navigate(typeof(FinalPage), result);

        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage), null);

        }
    }
}

