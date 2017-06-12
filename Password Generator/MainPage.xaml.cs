using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Password_Generator.Resources;

namespace Password_Generator
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        static string ReplaceAtIndex(int i, char value, string word)
        {
            char[] letters = word.ToCharArray();
            letters[i] = value;
            return string.Join("", letters);
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            double numChars = NumCharsUpDown.Value;
            bool upper = uppercaseToggle.IsChecked;
            bool punct = PunctToggle.IsChecked;
            bool nums = NumbersToggle.IsChecked;

            Random rnd = new Random();

            string PasswordStr =  @"";

            for (int i = 0; i < numChars; i++)
            {
                int curr = rnd.Next(97,122);

                char Temp = (char)curr;
                PasswordStr += Temp;
            }
            if( upper )
            {
                int pos = rnd.Next(0, (int)numChars - 1);
                int val = rnd.Next(65,90);

                PasswordStr = ReplaceAtIndex(pos, (char)val, PasswordStr);
            }
            if( nums )
            {
                int pos = rnd.Next(0, (int)numChars - 1);
                int val = rnd.Next(48,57);
                PasswordStr = ReplaceAtIndex(pos, (char)val, PasswordStr);
            }
            if (punct)
            {
                int pos = rnd.Next(0, (int)numChars - 1);
                int val = rnd.Next(33, 47);

                PasswordStr = ReplaceAtIndex(pos, (char)val, PasswordStr);
            }


            // Debug
            /**
            MessageBox.Show("Password " + numChars  
                + ( (upper) ? " upper " : " no upper " ) 
                + ( (punct) ? " punct " : " no punct " )
                + ( (nums)  ? " nums "  : " no nums " )
                );
             **/

            MessageBox.Show( PasswordStr );

        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}