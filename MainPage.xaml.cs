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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PumaShoes
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        DispatcherTimer dt = new DispatcherTimer();
        public MainPage()
        {
            this.InitializeComponent();
            dt.Interval = new TimeSpan(3);
            dt.Tick += t1;
            dt.Start();
        }
        public void t1(object sender, Object e)
        {
            prg.Value++;
            if (prg.Value == 100)
            {
                dt.Stop();
                this.Frame.Navigate(typeof(BlankPage1));
            }
        }
        private void prg_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {

        }
    }
}
