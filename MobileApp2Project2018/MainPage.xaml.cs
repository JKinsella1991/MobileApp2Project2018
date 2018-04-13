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
        public MainPage()

        {
            this.InitializeComponent();
        }

        public void GenderCheck(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;

           // GenderBool = RadioChoice;

        }


        private void LocationCheck(object sender, RoutedEventArgs e)
        {
            //placeholder
        }

        private void DrinkCalculate_Click(object sender, RoutedEventArgs e)
        {
        //placeholder
        }

        private void RadioChoice_Tapped(object sender, TappedRoutedEventArgs e)
        {

        }
    }
    }

