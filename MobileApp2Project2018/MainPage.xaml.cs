//James Kinsella - G00282261@gmit.ie
//Mobile Applications 2 - Project 2018

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MobileApp2Project2018
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        //Containers for radio values
        private String LocationContainer;
        private String GenderContainer;
        private String drinkUnitContainer;
        private double costContainer;


        public MainPage()

        {
            this.InitializeComponent();
        }

        //Method for radio button, pulling info into container
        private void GenderCheck(object sender, RoutedEventArgs e)
        {
            RadioButton gender = sender as RadioButton;
            GenderContainer = "Your gender is: " + gender.GroupName;
        }

        //Method for radio button, pulling info into container
        private void LocationCheck(object sender, RoutedEventArgs e)
        {
            RadioButton location = sender as RadioButton;
            LocationContainer = "You were drinking at the: " +location.GroupName;
        }

        //Method for button, pushing info to Textblocks at bottom of app
        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            //Pushes to containers
            genderResults.Text = GenderContainer;
            locationResults.Text = LocationContainer;

            //Unimplemented :/
            drinkResults.Text = drinkUnitContainer;
        }
    }
}

