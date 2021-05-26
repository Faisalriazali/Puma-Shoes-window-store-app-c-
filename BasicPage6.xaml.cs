using PumaShoes.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
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
    public sealed partial class BasicPage6 : Page
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


        public BasicPage6()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        string price = "$160.00";
        string style_num = "Style Number 360037-0";
        string brand_name = "Suede SUPERMAN™ Kids Sneakers";
        string check2 = "";


        private void layout(string check)
        {
            Brand_Name.Text = check;
            if (check == "Row1_Box_1_img")
            {
                MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/1.jpg"));
                Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/2.jpg"));
                Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/3.jpg"));
                Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/4.jpg"));
                Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/5.jpg"));
                highlight1.Visibility = Visibility.Visible;
                Row1_ColorBar();
                Brand_Name.Text = brand_name;
                Brand_Style_Num.Text = style_num + "1";
                Brand_Price.Text = price;
            }
            else if (check == "Row1_Box_2_img")
            {
                Row1_Box_2_Click();
                Row1_ColorBar();
                Brand_Name.Text = brand_name;
                Brand_Price.Text = price;
            }
            else if (check == "Row1_Box_3_img")
            {
                Row1_Box_3_Click();
                Row1_ColorBar();
                Brand_Name.Text = brand_name;
                Brand_Price.Text = price;
            }
            else if (check == "Row1_Box_4_img")
            {
                Row1_Box_4_Click();
            }
            else if (check == "Row2_Box_1_img")
            {
                Row2_Box_1_Click();
                Row2_ColorBar();
                Brand_Name.Text = "Roma Basic JR Sneakers";
                Brand_Style_Name.Text = "black-black";
                Brand_Price.Text = "$117.00";
                style_num = "  Style Number 152633-0";
                Brand_Style_Num.Text = style_num + "2";
            }
            else if (check == "Row2_Box_2_img")
            {
                Row2_Box_2_Click();
                Row2_ColorBar();
                Brand_Name.Text = "Roma Basic JR Sneakers";
                Brand_Price.Text = "$117.00";
                style_num = "  Style Number 152633-0";
                Brand_Style_Num.Text = style_num + "3";
                Brand_Style_Name.Text = "white-light gray";
            }

            else if (check == "Row2_Box_3_img")
            {
                Row2_Box_3_Click();
                Row2_ColorBar();
                Brand_Name.Text = "Roma Basic JR Sneakers";
                Brand_Style_Num.Text = style_num + "4";
                Brand_Price.Text = "$195.00";
                Brand_Style_Name.Text = "white-new navy";
            }

            else if (check == "Row2_Box_4_img")
            {
                Row2_Box_4_Click();
                Row2_ColorBar();
                Brand_Name.Text = "Roma Basic JR Sneakers";
                Brand_Price.Text = "$117.00";
                style_num = "  Style Number 152633-0";
                Brand_Style_Num.Text = style_num + "1";
                Brand_Style_Name.Text = "white-fuchsia purple";
            }
            else if (check == "two_Row1_Box_1_img")
            {
                two_Row1_Box_1_Click();
                two_Row1_ColorBar();
                Brand_Name.Text = "Smash Buck JR Sneakers";
                Brand_Price.Text = "$92.00";
                Brand_Style_Num.Text = "Style Number 189562-01";
                Brand_Style_Name.Text = "black-white";
            }

            else if (check == "two_Row1_Box_2_img")
            {
                two_Row1_Box_2_Click();
                two_Row1_ColorBar();
                Brand_Name.Text = "Smash Buck JR Sneakers";
                Brand_Price.Text = "$92.00";
                Brand_Style_Num.Text = "Style Number 189562-03";
                Brand_Style_Name.Text = "gray-black";
            }

            else if (check == "two_Row1_Box_3_img")
            {
                two_Row1_Box_3_Click();
                two_Row1_ColorBar();
                Brand_Name.Text = "Smash Buck JR Sneakers";
                Brand_Price.Text = "$92.00";
                Brand_Style_Num.Text = "Style Number 189562-02";
                Brand_Style_Name.Text = "drizzle-black";
            }


            else if (check == "two_Row1_Box_4_img")
            {
                two_Row1_Box_4_Click();


            }

            else if (check == "two_Row2_Box_1_img")
            {
                two_Row2_Box_1_Click();
                two_Row2_ColorBar();
                Brand_Name.Text = "Speed Light-Up Kids Sneakers";
                Brand_Price.Text = "$72.00";
                Brand_Style_Num.Text = "Style Number 159263-06";
                Brand_Style_Name.Text = "black-limestone gray-high risk red";
            }
            else if (check == "two_Row2_Box_2_img")
            {
                two_Row2_Box_2_Click();
                two_Row2_ColorBar();
                Brand_Name.Text = "Speed Light-Up Kids Sneakers";
                Brand_Price.Text = "$72.00";
                Brand_Style_Num.Text = "Style Number 159263-09";
                Brand_Style_Name.Text = "puma royal-lime punch";
            }

            else if (check == "two_Row2_Box_3_img")
            {
                two_Row2_Box_3_Click();
                two_Row2_ColorBar();
                Brand_Name.Text = "Speed Light-Up Kids Sneakers";
                Brand_Price.Text = "$72.00";
                Brand_Style_Num.Text = "Style Number 159263-07";
                Brand_Style_Name.Text = "high risk red-limoges";
            }

            else if (check == "two_Row2_Box_4_img")
            {
                two_Row2_Box_4_Click();
                two_Row2_ColorBar();
                Brand_Name.Text = "Speed Light-Up Kids Sneakers";
                Brand_Price.Text = "$72.00";
                Brand_Style_Num.Text = "Style Number 159263-03";
                Brand_Style_Name.Text = "pink dogwood-purple cactus flower";
            }





            else if (check == "three_Row1_Box_1_img")
            {
                three_Row1_Box_1_Click();
                three_Row1_ColorBar();

            }

            else if (check == "three_Row1_Box_2_img")
            {
                three_Row1_Box_2_Click();
                three_Row1_ColorBar();

            }

            else if (check == "three_Row1_Box_3_img")
            {
                three_Row1_Box_3_Click();
                three_Row1_ColorBar();

            }


            else if (check == "three_Row1_Box_4_img")
            {
                three_Row1_Box_4_Click();


            }

            else if (check == "three_Row2_Box_1_img")
            {
                three_Row2_Box_1_Click();
                three_Row2_ColorBar();

            }
            else if (check == "three_Row2_Box_2_img")
            {
                three_Row2_Box_2_Click();
                three_Row2_ColorBar();

            }

            else if (check == "three_Row2_Box_3_img")
            {
                three_Row2_Box_3_Click();
                three_Row2_ColorBar();

            }

            else if (check == "three_Row2_Box_4_img")
            {
                three_Row2_Box_4_Click();
                three_Row2_ColorBar();

            }






        }

        private void Row1_Box_1_Click()
        {
            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue1/5.jpg"));
            Brand_Style_Num.Text = style_num + "1";
            Brand_Style_Name.Text = "peacoat-princess blue";
        }

        private void Row1_Box_2_Click()
        {
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Visible;
            highlight3.Visibility = Visibility.Collapsed;
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/black/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/black/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/black/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/black/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/black/5.jpg"));
            Brand_Style_Num.Text = style_num + "2";
            Brand_Style_Name.Text = "black-limestone gray";
        }
        private void Row1_Box_3_Click()
        {
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Visible;
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/red/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/red/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/red/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/red/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/red/5.jpg"));
            Brand_Style_Num.Text = style_num + "3";
            Brand_Style_Name.Text = "cordovan-high risk red";
        }
        private void Row1_ColorBar()
        {
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/360037_01_SWT_PNA.jpg"));
            Row1_Box_1_color2.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/360037_02_SWT_PNA.jpg"));
            Row1_Box_1_color3.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/360037_03_SWT_PNA.jpg"));
        }

        private void Row2_ColorBar()
        {
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/354259_12_SWT_PNA.jpg"));
            Row1_Box_1_color2.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/354259_14_SWT_PNA.jpg"));
            Row1_Box_1_color3.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/354259_05_SWT_PNA.jpg"));
            Row1_Box_1_color4.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/354259_22_SWT_PNA.jpg"));
        }
        private void two_Row1_ColorBar()
        {
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/359043_01_SWT_PNA.jpg"));
            Row1_Box_1_color2.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/359043_02_SWT_PNA.jpg"));
            Row1_Box_1_color3.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/359043_04_SWT_PNA.jpg"));

        }
        private void two_Row2_ColorBar()
        {
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/357640_07_SWT_PNA.jpg"));
            Row1_Box_1_color2.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/357640_11_SWT_PNA.jpg"));
            Row1_Box_1_color3.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/357640_14_SWT_PNA.jpg"));
            Row1_Box_1_color4.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/357640_15_SWT_PNA.jpg"));
        }
        private void three_Row1_ColorBar()
        {
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Red.jpg"));
            Row1_Box_1_color2.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Black.jpg"));
            Row1_Box_1_color3.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Brown.jpg"));

        }
        private void three_Row2_ColorBar()
        {
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/359043_01_SWT_PNA.jpg"));
            Row1_Box_1_color2.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Green_Silver.jpg"));
            Row1_Box_1_color3.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Red_White.jpg"));
            Row1_Box_1_color4.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Silver_Grash.jpg"));
        }

        private void Row1_Box_4_Click()
        {
            highlight1.Visibility = Visibility.Visible;
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album18/blue/5.jpg"));
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/blue-black-green.jpg"));
            Brand_Style_Num.Text = "Style Number 103524-01";
            Brand_Style_Name.Text = "peacoat-princess blue";
            Brand_Name.Text = "Suede SUPERMAN™ JR Sneakers";
            Brand_Price.Text = "$220.00";


        }

        private void Row2_Box_1_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Black/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Black/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Black/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Black/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Black/5.jpg"));
            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Collapsed;

            Brand_Style_Name.Text = "black-black";

        }
        private void Row2_Box_2_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white1/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white1/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white1/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white1/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white1/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Visible;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Collapsed;
            Brand_Style_Name.Text = "white-light gray";

        }
        private void Row2_Box_3_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/white/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Visible;
            highlight4.Visibility = Visibility.Collapsed;
            Brand_Style_Name.Text = "white-new navy";

        }
        private void Row2_Box_4_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Pink/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Pink/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Pink/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Pink/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album19/Pink/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Visible;
            Brand_Style_Name.Text = "white-fuchsia purple";

        }


        private void two_Row1_Box_1_Click()
        {
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/Black/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/Black/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/Black/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/Black/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/Black/5.jpg"));
            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Smash Buck JR Sneakers";
            Brand_Price.Text = "$92.00";
            Brand_Style_Num.Text = "Style Number 189562-01";
            Brand_Style_Name.Text = "black-white";



        }
        private void two_Row1_Box_2_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/red/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/red/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/red/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/red/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/red/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Visible;
            highlight3.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Smash Buck JR Sneakers";
            Brand_Price.Text = "$92.00";
            Brand_Style_Num.Text = "Style Number 189562-03";
            Brand_Style_Name.Text = "gray-black";

        }
        private void two_Row1_Box_3_Click()
        {
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/gray/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/gray/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/gray/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/gray/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/gray/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Visible;
            Brand_Name.Text = "Smash Buck JR Sneakers";
            Brand_Price.Text = "$92.00";
            Brand_Style_Num.Text = "Style Number 189562-02";
            Brand_Style_Name.Text = "drizzle-black";


        }



        private void two_Row1_Box_4_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/blue/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/blue/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/blue/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/blue/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album21/blue/5.jpg"));
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/358854_02_SWT_PNA.jpg"));
            Brand_Style_Num.Text = "Style Number 188533-01";
            Brand_Style_Name.Text = "bleached denim-cayenne";
            Brand_Name.Text = "Suede Blur JR Sneakers";
            Brand_Price.Text = "$70.00";
            highlight1.Visibility = Visibility.Visible;


        }
        private void two_Row2_Box_1_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/black/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/black/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/black/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/black/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/black/5.jpg"));
            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Speed Light-Up Kids Sneakers";
            Brand_Price.Text = "$72.00";
            Brand_Style_Num.Text = "Style Number 159263-06";
            Brand_Style_Name.Text = "black-limestone gray-high risk red";

        }

        private void two_Row2_Box_2_Click()
        {
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/blue/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/blue/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/blue/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/blue/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/blue/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Visible;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Speed Light-Up Kids Sneakers";
            Brand_Price.Text = "$72.00";
            Brand_Style_Num.Text = "Style Number 159263-09";
            Brand_Style_Name.Text = "puma royal-lime punch";


        }

        private void two_Row2_Box_3_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/red/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/red/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/red/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/red/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/red/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Visible;
            highlight4.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Speed Light-Up Kids Sneakers";
            Brand_Price.Text = "$72.00";
            Brand_Style_Num.Text = "Style Number 159263-07";
            Brand_Style_Name.Text = "high risk red-limoges";


        }

        private void two_Row2_Box_4_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/white/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/white/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/white/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/white/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album20/white/5.jpg"));
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker3/358854_02_SWT_PNA.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Visible;
            Brand_Name.Text = "Speed Light-Up Kids Sneakers";
            Brand_Price.Text = "$72.00";
            Brand_Style_Num.Text = "Style Number 159263-03";
            Brand_Style_Name.Text = "pink dogwood-purple cactus flower";

        }





        /// /////////////////////////////
        private void three_Row1_Box_1_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Red/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Red/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Red/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Red/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Red/5.jpg"));
            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Suede Embossed Iced Men's Sneakers";
            Brand_Price.Text = "$70.00";
            Brand_Style_Num.Text = "Style Number 361664-03";
            Brand_Style_Name.Text = "high risk red";

        }
        private void three_Row1_Box_2_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Black/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Black/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Black/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Black/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Black/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Visible;
            highlight3.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Suede Embossed Iced Men's Sneakers";
            Brand_Price.Text = "$70.00";
            Brand_Style_Num.Text = "Style Number 361664-05";
            Brand_Style_Name.Text = "black";

        }
        private void three_Row1_Box_3_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Brown/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Brown/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Brown/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Brown/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/Brown/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Visible;
            Brand_Name.Text = "Suede Embossed Iced Men's Sneakers";
            Brand_Price.Text = "$70.00";
            Brand_Style_Num.Text = "Style Number 361664-06";
            Brand_Style_Name.Text = "dark shadow";

        }
        private void three_Row1_Box_4_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/MultiColor/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/MultiColor/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/MultiColor/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/MultiColor/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album6/MultiColor/5.jpg"));
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Black_Yelllow.jpg"));
            highlight1.Visibility = Visibility.Visible;
            Brand_Name.Text = "698 IGNITE Metallic Men's Sneakers";
            Brand_Price.Text = "$100.00";
            Brand_Style_Num.Text = "Style Number 361263-01";
            Brand_Style_Name.Text = "black-metallic gold-white";

        }
        private void three_Row2_Box_1_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Black/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Black/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Black/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Black/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Black/5.jpg"));
            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Suede Classic + Men's Sneakers";
            Brand_Price.Text = "$65.00";
            Brand_Style_Num.Text = "Style Number 352634-03";
            Brand_Style_Name.Text = "black-white";

        }
        private void three_Row2_Box_2_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Green/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Green/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Green/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Green/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Green/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Visible;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Suede Classic + Men's Sneakers";
            Brand_Price.Text = "$65.00";
            Brand_Style_Num.Text = "Style Number 352634-64";
            Brand_Style_Name.Text = "olympian blue-white";

        }
        private void three_Row2_Box_3_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Red/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Red/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Red/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Red/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Red/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Visible;
            highlight4.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Suede Classic + Men's Sneakers";
            Brand_Price.Text = "$65.00";
            Brand_Style_Num.Text = "Style Number 352634-65";
            Brand_Style_Name.Text = "high risk red-white";

        }
        private void three_Row2_Box_4_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Silver/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Silver/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Silver/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Silver/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album7/Silver/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Visible;
            Brand_Name.Text = "Suede Classic + Men's Sneakers";
            Brand_Price.Text = "$65.00";
            Brand_Style_Num.Text = "Style Number 352634-66";
            Brand_Style_Name.Text = "steeple gray-white";

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
            string Grid_Name = e.Parameter as string;
            check2 = Grid_Name;
            layout(Grid_Name);
        }


        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void Img2_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var m_source = MainImg.Source;
            var one_source = Img2.Source;
            MainImg.Source = one_source;
            Img2.Source = m_source;
        }

        private void Img2_PointerEntered(object sender, PointerRoutedEventArgs e)
        {

            Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.Hand, 0);
        }

        private void Img2_PointerExited(object sender, PointerRoutedEventArgs e)
        {


            Window.Current.CoreWindow.PointerCursor = new CoreCursor(CoreCursorType.Arrow, 0);
        }

        private void Img3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var m_source = MainImg.Source;
            var one_source = Img3.Source;
            MainImg.Source = one_source;
            Img3.Source = m_source;
        }

        private void Img4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var m_source = MainImg.Source;
            var one_source = Img4.Source;
            MainImg.Source = one_source;
            Img4.Source = m_source;
        }

        private void Img5_Tapped(object sender, TappedRoutedEventArgs e)
        {
            var m_source = MainImg.Source;
            var one_source = Img5.Source;
            MainImg.Source = one_source;
            Img5.Source = m_source;
        }

        private void Row1_Box_1_color2_Tapped(object sender, TappedRoutedEventArgs e)
        {

            if (Brand_Name.Text == "Roma Basic JR Sneakers")
            {
                Row2_Box_2_Click();
            }
            else if (Brand_Name.Text == "EVOSPEED 1.3 FG Men's Firm Ground Soccer Cleats")
            {
                Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Suede SUPERMAN™ Kids Sneakers")
            {
                Row1_Box_2_Click();
            }
            else if (Brand_Name.Text == "Smash Buck JR Sneakers")
            {
                two_Row1_Box_2_Click();
            }
            else if (Brand_Name.Text == "Suede Blur JR Sneakers")
            {
                two_Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Speed Light-Up Kids Sneakers")
            {
                two_Row2_Box_2_Click();
            }
            else if (Brand_Name.Text == "Suede Embossed Iced Men's Sneakers")
            {
                three_Row1_Box_2_Click();
            }
            else if (Brand_Name.Text == "698 IGNITE Metallic Men's Sneakers")
            {
                three_Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Suede Classic + Men's Sneakers")
            {
                three_Row2_Box_2_Click();
            }

        }

        private void Row1_Box_1_color3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (Brand_Name.Text == "Roma Basic JR Sneakers")
            {
                Row2_Box_3_Click();
            }
            else if (Brand_Name.Text == "EVOSPEED 1.3 FG Men's Firm Ground Soccer Cleats")
            {
                Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Suede SUPERMAN™ Kids Sneakers")
            {
                Row1_Box_3_Click();
            }
            else if (Brand_Name.Text == "Smash Buck JR Sneakers")
            {
                two_Row1_Box_3_Click();
            }
            else if (Brand_Name.Text == "Suede Blur JR Sneakers")
            {
                two_Row1_Box_3_Click();
            }
            else if (Brand_Name.Text == "Speed Light-Up Kids Sneakers")
            {
                two_Row2_Box_3_Click();
            }
            else if (Brand_Name.Text == "Suede Embossed Iced Men's Sneakers")
            {
                three_Row1_Box_3_Click();
            }
            else if (Brand_Name.Text == "698 IGNITE Metallic Men's Sneakers")
            {
                three_Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Suede Classic + Men's Sneakers")
            {
                three_Row2_Box_3_Click();
            }

        }

        private void Row1_Box_1_color1_Tapped(object sender, TappedRoutedEventArgs e)
        {

            if (Brand_Name.Text == "Roma Basic JR Sneakers")
            {
                Row2_Box_1_Click();
            }
            else if (Brand_Name.Text == "EVOSPEED 1.3 FG Men's Firm Ground Soccer Cleats")
            {
                Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Suede SUPERMAN™ Kids Sneakers")
            {
                Row1_Box_1_Click();
            }
            else if (Brand_Name.Text == "Smash Buck JR Sneakers")
            {
                two_Row1_Box_1_Click();
            }
            else if (Brand_Name.Text == "Suede Blur JR Sneakers")
            {
                two_Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Speed Light-Up Kids Sneakers")
            {
                two_Row2_Box_1_Click();
            }
            else if (Brand_Name.Text == "Suede Embossed Iced Men's Sneakers")
            {
                three_Row1_Box_1_Click();
            }
            else if (Brand_Name.Text == "698 IGNITE Metallic Men's Sneakers")
            {
                three_Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Suede Classic + Men's Sneakers")
            {
                three_Row2_Box_1_Click();
            }

        }

        private void Row1_Box_1_color4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (Brand_Name.Text == "Roma Basic JR Sneakers")
            {
                Row2_Box_4_Click();
            }
            else if (Brand_Name.Text == "Speed Light-Up Kids Sneakers")
            {
                two_Row2_Box_4_Click();
            }
            else if (Brand_Name.Text == "Suede Classic + Men's Sneakers")
            {
                three_Row2_Box_4_Click();
            }

        }

        private void Brand_Price_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }




    }
}
