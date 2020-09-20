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
using Assignment3_T1907A.Models;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Assignment3_T1907A
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Frame contentFrame;

        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SV.IsPaneOpen = !SV.IsPaneOpen;
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("E80F", 16)), "Home", "lst"));
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("EA4A", 16)), "Contact", "add"));
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("EE57", 16)), "Customer", "cus"));
            LV.Items.Add(new MenuItem((char)(Convert.ToInt32("E715", 16)), "Mail", "mail"));

        }

        private void ListView_Loaded(object sender, RoutedEventArgs e)
        {
            MenuItem selected = (MenuItem)LV.SelectedItem;
            if (selected.Dest.Equals("lst"))
            {
                FrContent.Navigate(typeof(Pages.Home));
            }
            else if (selected.Dest.Equals("add"))
            {
                FrContent.Navigate(typeof(Pages.Contact));
            }
            else if (selected.Dest.Equals("cus"))
            {
                FrContent.Navigate(typeof(Pages.Customer));
            }
            else if (selected.Dest.Equals("mail")) {
                FrContent.Navigate(typeof(Pages.Mail));
            }
        }

        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            contentFrame = FrContent;
            FrContent.Navigate(typeof(Pages.Home));
        }
    }
}
