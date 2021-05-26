using PumaShoes.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace PumaShoes
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class Kid : Page
    {

        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public Kid()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }
        string grid_name = "";
        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion
        private void color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row1_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/1.jpg"));
        }

        private void color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row1_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/black/1.jpg"));
        }

        private void color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row1_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/red/1.jpg"));
        }

        private void Grid_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Row1_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/1.jpg"));
        }

        private void Row1_Box_2_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row1_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/1.jpg"));
        }

        private void Row1_Box_2_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row1_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/black/1.jpg"));
        }

        private void Row1_Box_2_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row1_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/red/1.jpg"));
        }

        private void Grid2_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Row1_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/black/1.jpg"));
        }

        private void Row1_Box_3_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row1_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/1.jpg"));
        }

        private void Row1_Box_3_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row1_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/black/1.jpg"));
        }

        private void Row1_Box_3_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row1_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/red/1.jpg"));
        }

        private void Grid3_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Row1_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/red/1.jpg"));
        }

        private void Grid4_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Black/1.jpg"));
        }

        private void Grid5_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white1/1.jpg"));
        }

        private void Grid6_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white/1.jpg"));
        }

        private void Grid7_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Pink/1.jpg"));
        }

        private void Row2_Box_1_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Black/1.jpg"));
        }

        private void Row2_Box_1_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white1/1.jpg"));
        }

        private void Row2_Box_1_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white/1.jpg"));
        }

        private void Row2_Box_1_color4_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Pink/1.jpg"));
        }

        private void Row2_Box_2_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Black/1.jpg"));
        }

        private void Row2_Box_2_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white1/1.jpg"));
        }

        private void Row2_Box_2_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white/1.jpg"));
        }

        private void Row2_Box_2_color4_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Pink/1.jpg"));
        }

        private void Row2_Box_3_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Black/1.jpg"));
        }

        private void Row2_Box_3_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white1/1.jpg"));
        }

        private void Row2_Box_3_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white/1.jpg"));
        }

        private void Row2_Box_3_color4_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Pink/1.jpg"));
        }

        private void Row2_Box_4_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Black/1.jpg"));
        }

        private void Row2_Box_4_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white1/1.jpg"));
        }

        private void Row2_Box_4_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white/1.jpg"));
        }

        private void Row2_Box_4_color4_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Pink/1.jpg"));
        }

        //private void Grid8_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    Row3_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album3/Black/1.jpg"));
        //}

        //private void Row3_Box_1_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    Row3_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album3/Black/1.jpg"));
        //}

        //private void Row3_Box_1_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    Row3_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album3/White/1.jpg"));
        //}

        //private void Row3_Box_1_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    Row3_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album3/Orange/1.jpg"));
        //}

        //private void Grid9_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    Row3_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album3/White/1.jpg"));
        //}

        //private void Row3_Box_2_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    Row3_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album3/Black/1.jpg"));
        //}

        //private void Row3_Box_2_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    Row3_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album3/White/1.jpg"));
        //}

        //private void Row3_Box_2_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    Row3_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album3/Orange/1.jpg"));
        //}

        //private void Grid10_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    Row3_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album3/Orange/1.jpg"));
        //}

        //private void Row3_Box_3_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    Row3_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album3/Black/1.jpg"));
        //}

        //private void Row3_Box_3_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    Row3_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album3/White/1.jpg"));
        //}

        //private void Row3_Box_3_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    Row3_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album3/Orange/1.jpg"));
        //}

        private void TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (soccer_data.Visibility == Visibility.Visible)
            {
                soccer_data.Visibility = Visibility.Collapsed;
                Men_Soccer_Toggle.Text = " Boys ";
            }
            else
            {
                soccer_data.Visibility = Visibility.Visible;
                Men_Soccer_Toggle.Text = " Boys ";



                two_soccer_data.Visibility = Visibility.Collapsed;
                Men_Running_Toggle.Text = " Girls ";

                //three_soccer_data.Visibility = Visibility.Collapsed;
                //Men_Sneaker_Toggle.Text = "  Men Sneakers ";
            }
        }



        //////////////



        private void two_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row1_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/Black/1.jpg"));
        }

        private void two_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row1_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/red/1.jpg"));
        }

        private void two_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row1_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/gray/1.jpg"));
        }

        private void two_Grid_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            two_Row1_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/Black/1.jpg"));
        }

        private void two_Row1_Box_2_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row1_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/Black/1.jpg"));
        }

        private void two_Row1_Box_2_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row1_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/red/1.jpg"));
        }

        private void two_Row1_Box_2_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row1_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/gray/1.jpg"));
        }

        private void two_Grid2_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            two_Row1_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/red/1.jpg"));
        }

        private void two_Row1_Box_3_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row1_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/Black/1.jpg"));
        }

        private void two_Row1_Box_3_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row1_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/red/1.jpg"));
        }

        private void two_Row1_Box_3_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row1_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/gray/1.jpg"));
        }

        private void two_Grid3_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            two_Row1_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/gray/1.jpg"));
        }

        private void two_Grid4_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/black/1.jpg"));
        }

        private void two_Grid5_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/blue/1.jpg"));
        }

        private void two_Grid6_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/red/1.jpg"));
        }

        private void two_Grid7_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/white/1.jpg"));
        }

        private void two_Row2_Box_1_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/black/1.jpg"));
        }

        private void two_Row2_Box_1_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/blue/1.jpg"));
        }

        private void two_Row2_Box_1_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/red/1.jpg"));
        }

        private void two_Row2_Box_1_color4_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/white/1.jpg"));
        }

        private void two_Row2_Box_2_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/black/1.jpg"));
        }

        private void two_Row2_Box_2_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/blue/1.jpg"));
        }

        private void two_Row2_Box_2_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/red/1.jpg"));
        }

        private void two_Row2_Box_2_color4_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/white/1.jpg"));
        }

        private void two_Row2_Box_3_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/black/1.jpg"));
        }

        private void two_Row2_Box_3_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/blue/1.jpg"));
        }

        private void two_Row2_Box_3_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/red/1.jpg"));
        }

        private void two_Row2_Box_3_color4_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/white/1.jpg"));
        }

        private void two_Row2_Box_4_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/black/1.jpg"));
        }

        private void two_Row2_Box_4_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/blue/1.jpg"));
        }

        private void two_Row2_Box_4_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/red/1.jpg"));
        }

        private void two_Row2_Box_4_color4_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            two_Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/white/1.jpg"));
        }

        //////

        //private void three_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row1_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Red/1.jpg"));
        //}

        //private void three_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row1_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Black/1.jpg"));
        //}

        //private void three_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row1_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Brown/1.jpg"));
        //}

        //private void three_Grid_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row1_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Red/1.jpg"));
        //}

        //private void three_Row1_Box_2_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row1_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Red/1.jpg"));
        //}

        //private void three_Row1_Box_2_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row1_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Black/1.jpg"));
        //}

        //private void three_Row1_Box_2_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row1_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Brown/1.jpg"));
        //}

        //private void three_Grid2_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row1_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Black/1.jpg"));
        //}

        //private void three_Row1_Box_3_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row1_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Red/1.jpg"));
        //}

        //private void three_Row1_Box_3_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row1_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Black/1.jpg"));
        //}

        //private void three_Row1_Box_3_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row1_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Brown/1.jpg"));
        //}

        //private void three_Grid3_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row1_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Brown/1.jpg"));
        //}

        //private void three_Grid4_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Black/1.jpg"));
        //}

        //private void three_Grid5_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Green/1.jpg"));
        //}

        //private void three_Grid6_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Red/1.jpg"));
        //}

        //private void three_Grid7_PointerExited(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Silver/1.jpg"));
        //}

        //private void three_Row2_Box_1_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Black/1.jpg"));
        //}

        //private void three_Row2_Box_1_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Green/1.jpg"));
        //}

        //private void three_Row2_Box_1_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Red/1.jpg"));
        //}

        //private void three_Row2_Box_1_color4_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_1_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Silver/1.jpg"));
        //}

        //private void three_Row2_Box_2_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Black/1.jpg"));
        //}

        //private void three_Row2_Box_2_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Green/1.jpg"));
        //}

        //private void three_Row2_Box_2_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Red/1.jpg"));
        //}

        //private void three_Row2_Box_2_color4_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_2_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Silver/1.jpg"));
        //}

        //private void three_Row2_Box_3_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Black/1.jpg"));
        //}

        //private void three_Row2_Box_3_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Green/1.jpg"));
        //}

        //private void three_Row2_Box_3_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Red/1.jpg"));
        //}

        //private void three_Row2_Box_3_color4_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_3_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Silver/1.jpg"));
        //}

        //private void three_Row2_Box_4_color1_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Black/1.jpg"));
        //}

        //private void three_Row2_Box_4_color2_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Green/1.jpg"));
        //}

        //private void three_Row2_Box_4_color3_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Red/1.jpg"));
        //}

        //private void three_Row2_Box_4_color4_PointerEntered(object sender, PointerRoutedEventArgs e)
        //{
        //    three_Row2_Box_4_img.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Silver/1.jpg"));
        //}

        private void two_TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (two_soccer_data.Visibility == Visibility.Visible)
            {
                two_soccer_data.Visibility = Visibility.Collapsed;
                Men_Running_Toggle.Text = " Girls ";
            }
            else
            {
                two_soccer_data.Visibility = Visibility.Visible;
                Men_Running_Toggle.Text = " Girls ";



                soccer_data.Visibility = Visibility.Collapsed;
                Men_Soccer_Toggle.Text = " Boys ";


                //three_soccer_data.Visibility = Visibility.Collapsed;
                //Men_Sneaker_Toggle.Text = " Men Sneakers ";
            }
        }

        private void Men_Soccer_Toggle_PointerEntered(object sender, PointerRoutedEventArgs e)
        {
            Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.Hand, 0);
        }

        private void Men_Soccer_Toggle_PointerExited(object sender, PointerRoutedEventArgs e)
        {
            Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.Arrow, 0);
        }

        private void Row1_Box_1_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = Row1_Box_1_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void Row1_Box_2_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = Row1_Box_2_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void Row1_Box_3_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = Row1_Box_3_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void Row1_Box_4_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = Row1_Box_4_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);

        }

        private void Row2_Box_1_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = Row2_Box_1_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void Row2_Box_2_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = Row2_Box_2_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void Row2_Box_3_img_Tapped(object sender, TappedRoutedEventArgs e)
        {

            grid_name = Row2_Box_3_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void Row2_Box_4_img_Tapped(object sender, TappedRoutedEventArgs e)
        {

            grid_name = Row2_Box_4_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void two_Row1_Box_1_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = two_Row1_Box_1_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void two_Row1_Box_2_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = two_Row1_Box_2_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void two_Row1_Box_3_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = two_Row1_Box_3_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void two_Row1_Box_4_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = two_Row1_Box_4_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void two_Row2_Box_1_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = two_Row2_Box_1_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void two_Row2_Box_2_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = two_Row2_Box_2_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void two_Row2_Box_3_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = two_Row2_Box_3_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        private void two_Row2_Box_4_img_Tapped(object sender, TappedRoutedEventArgs e)
        {
            grid_name = two_Row2_Box_4_img.Name.ToString();
            this.Frame.Navigate(typeof(BasicPage6), grid_name);
        }

        //private void three_Row2_Box_4_img_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    grid_name = three_Row2_Box_4_img.Name.ToString();
        //    this.Frame.Navigate(typeof(BasicPage6), grid_name);
        //}

        //private void three_Row2_Box_3_img_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    grid_name = three_Row2_Box_3_img.Name.ToString();
        //    this.Frame.Navigate(typeof(BasicPage6), grid_name);
        //}

        //private void three_Row2_Box_1_img_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    grid_name = three_Row2_Box_1_img.Name.ToString();
        //    this.Frame.Navigate(typeof(BasicPage6), grid_name);
        //}

        //private void three_Row1_Box_1_img_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    grid_name = three_Row1_Box_1_img.Name.ToString();
        //    this.Frame.Navigate(typeof(BasicPage6), grid_name);
        //}

        //private void three_Row1_Box_2_img_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    grid_name = three_Row1_Box_2_img.Name.ToString();
        //    this.Frame.Navigate(typeof(BasicPage6), grid_name);
        //}

        //private void three_Row1_Box_3_img_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    grid_name = three_Row1_Box_3_img.Name.ToString();
        //    this.Frame.Navigate(typeof(BasicPage6), grid_name);
        //}

        //private void three_Row1_Box_4_img_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    grid_name = three_Row1_Box_4_img.Name.ToString();
        //    this.Frame.Navigate(typeof(BasicPage6), grid_name);
        //}

        //private void three_Row2_Box_2_img_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    grid_name = three_Row2_Box_2_img.Name.ToString();
        //    this.Frame.Navigate(typeof(BasicPage6), grid_name);
        //}

        //private void three_TextBlock_Tapped(object sender, TappedRoutedEventArgs e)
        //{
        //    if (three_soccer_data.Visibility == Visibility.Visible)
        //    {
        //        three_soccer_data.Visibility = Visibility.Collapsed;
        //        Men_Sneaker_Toggle.Text = " Men Sneakers ";
        //    }
        //    else
        //    {

        //        three_soccer_data.Visibility = Visibility.Visible;
        //        Men_Sneaker_Toggle.Text = " Men Sneakers ";


        //        two_soccer_data.Visibility = Visibility.Collapsed;
        //        Men_Running_Toggle.Text = " Men Running ";


        //        soccer_data.Visibility = Visibility.Collapsed;
        //        Men_Soccer_Toggle.Text = " Men Soccer ";


        //    }
        //}
     
    }
}
