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
    public sealed partial class BasicPage4 : Page
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


        public BasicPage4()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }
        string price = "$80.00";
        string style_num = "Style Number 188334-0";
        string brand_name = "FAAS 600 V3 WOMEN'S RUNNING SHOES";
        string check2 = "";
        private void Row1_Box_1_Click()
        {
            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Brown/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Brown/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Brown/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Brown/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Brown/5.jpg"));
            Brand_Style_Name.Text = "clearwater-blue coral-puma silver-sulphur spring";
            Brand_Name.Text = brand_name;
            Brand_Style_Num.Text = style_num + "1";
           
            
        }

        private void Row1_Box_2_Click()
        {
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Visible;
            highlight3.Visibility = Visibility.Collapsed;
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Purple/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Purple/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Purple/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Purple/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Purple/5.jpg"));
            Brand_Style_Num.Text = style_num + "3";
            Brand_Style_Name.Text = "astral aura-bleached denim-cayenne";
        }
        private void Row1_Box_3_Click()
        {
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Visible;
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Pink/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Pink/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Pink/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Pink/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Pink/5.jpg"));
            Brand_Style_Num.Text = style_num + "4";
            Brand_Style_Name.Text = "cayenne-white-periscope";
        }
        private void Row1_ColorBar()
        {
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Harf_Brown.jpg"));
            Row1_Box_1_color2.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Pink_Brown.jpg"));
            Row1_Box_1_color3.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Pink_White.jpg"));
        }

        private void Row2_ColorBar()
        {
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/light_blue_Yellow.jpg"));
            Row1_Box_1_color2.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/light_brown_white.jpg"));
            Row1_Box_1_color3.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Red_black.jpg"));
            Row1_Box_1_color4.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Purple_Red_White.jpg"));
        }
        private void two_Row1_ColorBar()
        {
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Black_Silver.jpg"));
            Row1_Box_1_color2.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/LightBlue.jpg"));
            Row1_Box_1_color3.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Harf_Brown.jpg"));

        }
        private void two_Row2_ColorBar()
        {
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Black.jpg"));
            Row1_Box_1_color2.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Grash_Black.jpg"));
            Row1_Box_1_color3.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Blue_Black.jpg"));
            Row1_Box_1_color4.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Pink_Black.jpg"));
        }
        private void three_Row1_ColorBar()
        {
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Black_Silver.jpg"));
            Row1_Box_1_color2.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Light_Full_Blue.jpg"));
            Row1_Box_1_color3.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Light_Full_Green.jpg"));

        }
        private void three_Row2_ColorBar()
        {
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Black_Silver.jpg"));
            Row1_Box_1_color2.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Green_Silver.jpg"));
            Row1_Box_1_color3.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Red_White.jpg"));
            Row1_Box_1_color4.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Silver_Grash.jpg"));
        }

        private void Row1_Box_4_Click()
        {
            highlight1.Visibility = Visibility.Visible;
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/MultiColor/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/MultiColor/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/MultiColor/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/MultiColor/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/MultiColor/5.jpg"));
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Black_Brown_Pink.jpg"));
            Brand_Style_Num.Text = "Style Number 188962-01";
            Brand_Style_Name.Text = "black-fluo pink";
            Brand_Name.Text = "NRGY WOMEN'S RUNNING SHOES";
            Brand_Price.Text = "$100.00";


        }

        private void Row2_Box_1_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/LightGreen/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/LightGreen/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/LightGreen/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/LightGreen/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/LightGreen/5.jpg"));
            Brand_Name.Text = "Faas 500 v4 Women's Running Shoes";
            Brand_Style_Name.Text = "total eclipse-lava blast-white";
            Brand_Price.Text = "$72.00";
            style_num = "Style Number 187526-0";
            Brand_Style_Num.Text = style_num + "4";
            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Collapsed;


        }
        private void Row2_Box_2_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/LightBlue/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/LightBlue/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/LightBlue/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/LightBlue/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/LightBlue/5.jpg"));
            Brand_Name.Text = "Faas 500 v4 Women's Running Shoes";
            Brand_Price.Text = "$72.00";
            style_num = "  Style Number 103264-0";
            Brand_Style_Num.Text = style_num + "2";
            Brand_Style_Name.Text = "white-ultramarine-clematis blue-hot coral";
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Visible;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Collapsed;

        }
        private void Row2_Box_3_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/Pink/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/Pink/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/Pink/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/Pink/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/Pink/5.jpg"));
            Brand_Name.Text = "Faas 500 v4 Women's Running Shoes";
            Brand_Style_Num.Text = style_num + "6";
            Brand_Price.Text = "$72.00";
            Brand_Style_Name.Text = "fiery coral-black-periscope";
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Visible;
            highlight4.Visibility = Visibility.Collapsed;

        }
        private void Row2_Box_4_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/Purple/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/Purple/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/Purple/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/Purple/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album9/Purple/5.jpg"));
            Brand_Name.Text = "Faas 500 v4 Women's Running Shoes";
            Brand_Price.Text = "$72.00";
            style_num = "Style Number 187526-0";
            Brand_Style_Num.Text = style_num + "5";
            Brand_Style_Name.Text = "bleached denim-astral aura-cayenne";
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Visible;

        }


        private void two_Row1_Box_1_Click()
        {
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Black/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Black/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Black/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Black/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Black/5.jpg"));
            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "SUEDE CLASSIC WOMEN'S SNEAKERS";
            Brand_Price.Text = "$65.00";
            Brand_Style_Num.Text = "Style Number 355462-01";
            Brand_Style_Name.Text = "black";



        }
        private void two_Row1_Box_2_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Green/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Green/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Green/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Green/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Green/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Visible;
            highlight3.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "SUEDE CLASSIC WOMEN'S SNEAKERS";
            Brand_Price.Text = "$65.00";
            Brand_Style_Num.Text = "Style Number 355462-32";
            Brand_Style_Name.Text = "holiday-white";

        }
        private void two_Row1_Box_3_Click()
        {
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Off_Green/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Off_Green/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Off_Green/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Off_Green/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/Off_Green/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Visible;
            Brand_Name.Text = "SUEDE CLASSIC WOMEN'S SNEAKERS";
            Brand_Price.Text = "$65.00";
            Brand_Style_Num.Text = "Style Number 355462-34";
            Brand_Style_Name.Text = "cool blue-white";


        }



        private void two_Row1_Box_4_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/MultiColor/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/MultiColor/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/MultiColor/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/MultiColor/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album10/MultiColor/5.jpg"));
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Black.jpg"));
            Brand_Name.Text = "NRGY Women's Running Shoes";
            Brand_Price.Text = "$100.00";
            Brand_Style_Num.Text = "Style Number 188962-01";
            Brand_Style_Name.Text = "black-fluo pink";
            highlight1.Visibility = Visibility.Visible;

         
        }
        private void two_Row2_Box_1_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Black/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Black/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Black/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Black/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Black/5.jpg"));
            Brand_Name.Text = "R698 MATTE & SHINE WOMEN'S SNEAKERS";
            Brand_Price.Text = "$56.00";
            Brand_Style_Num.Text = "Style Number 360800-02";
            Brand_Style_Name.Text = "black-black-white canvas";
            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Collapsed;
           


        }

        private void two_Row2_Box_2_Click()
        {
            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Silver/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Silver/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Silver/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Silver/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Silver/5.jpg"));
            Brand_Name.Text = "R698 MATTE & SHINE WOMEN'S SNEAKERS";
            Brand_Price.Text = "$56.00";
            Brand_Style_Num.Text = "Style Number 360800-03";
            Brand_Style_Name.Text = "glacier gray-black";
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Visible;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Collapsed;
          



        }

        private void two_Row2_Box_3_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Blue/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Blue/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Blue/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Blue/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Blue/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Visible;
            highlight4.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "R698 MATTE & SHINE WOMEN'S SNEAKERS";
            Brand_Price.Text = "$56.00";
            Brand_Style_Num.Text = "Style Number 360800-04";
            Brand_Style_Name.Text = "marina blue-black-white";


        }

        private void two_Row2_Box_4_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Pink/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Pink/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Pink/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Pink/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album11/Pink/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Visible;
            Brand_Name.Text = "R698 MATTE & SHINE WOMEN'S SNEAKERS";
            Brand_Price.Text = "$56.00";
            Brand_Style_Num.Text = "Style Number 360800-06";
            Brand_Style_Name.Text = "carmine rose-black-white";

        }





        /// /////////////////////////////
        private void three_Row1_Box_1_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Black/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Black/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Black/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Black/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Black/5.jpg"));
            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "AXEL DOTS WOMEN'S BALLET FLATS";
            Brand_Price.Text = "$42.00";
            Brand_Style_Num.Text = "Style Number 187732-01";
            Brand_Style_Name.Text = "black";

        }
        private void three_Row1_Box_2_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Green/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Green/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Green/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Green/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Green/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Visible;
            highlight3.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "AXEL DOTS WOMEN'S BALLET FLATS";
            Brand_Price.Text = "$42.00";
            Brand_Style_Num.Text = "Style Number 187732-04";
            Brand_Style_Name.Text = "patina green";

        }
        private void three_Row1_Box_3_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Gresh/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Gresh/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Gresh/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Gresh/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/Gresh/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Visible;
            Brand_Name.Text = "AXEL DOTS WOMEN'S BALLET FLATS";
            Brand_Price.Text = "$42.00";
            Brand_Style_Num.Text = "Style Number 187732-03";
            Brand_Style_Name.Text = "omphalodes";
        }
        private void three_Row1_Box_4_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/MultiColor/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/MultiColor/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/MultiColor/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/MultiColor/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album12/MultiColor/5.jpg"));
            Row1_Box_1_color1.Source = new BitmapImage(new Uri("ms-appx:///Images/colorPicker/Silver_White.jpg"));
            highlight1.Visibility = Visibility.Visible;
            Brand_Name.Text = "Asha Alt 2 Heather Women's Ballet Flats";
            Brand_Price.Text = "$60.00";
            Brand_Style_Num.Text = "Style Number 361516-02";
            Brand_Style_Name.Text = "white-limestone gray";

        }
        private void three_Row2_Box_1_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Black/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Black/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Black/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Black/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Black/5.jpg"));
            highlight1.Visibility = Visibility.Visible;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Rhythm Basic Sport Women's Ballet Flats";
            Brand_Price.Text = "$48.00";
            Brand_Style_Num.Text = "Style Number 357602-04";
            Brand_Style_Name.Text = "black";

        }
        private void three_Row2_Box_2_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Blue/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Blue/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Blue/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Blue/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Blue/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Visible;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Rhythm Basic Sport Women's Ballet Flats";
            Brand_Price.Text = "$48.00";
            Brand_Style_Num.Text = "Style Number 357602-01";
            Brand_Style_Name.Text = "crown blue";

        }
        private void three_Row2_Box_3_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Pink/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Pink/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Pink/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Pink/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Pink/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Visible;
            highlight4.Visibility = Visibility.Collapsed;
            Brand_Name.Text = "Rhythm Basic Sport Women's Ballet Flats";
            Brand_Price.Text = "$48.00";
            Brand_Style_Num.Text = "Style Number 357602-02";
            Brand_Style_Name.Text = "vivid viola";

        }
        private void three_Row2_Box_4_Click()
        {

            MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Silver/1.jpg"));
            Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Silver/2.jpg"));
            Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Silver/3.jpg"));
            Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Silver/4.jpg"));
            Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album13/Silver/5.jpg"));
            highlight1.Visibility = Visibility.Collapsed;
            highlight2.Visibility = Visibility.Collapsed;
            highlight3.Visibility = Visibility.Collapsed;
            highlight4.Visibility = Visibility.Visible;
            Brand_Name.Text = "Rhythm Basic Sport Women's Ballet Flats";
            Brand_Price.Text = "$48.00";
            Brand_Style_Num.Text = "Style Number 357602-03";
            Brand_Style_Name.Text = "white";

        }



        private void layout(string check)
        {
            Brand_Name.Text = check;
            if (check == "Row1_Box_1_img")
            {
                MainImg.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Brown/1.jpg"));
                Img2.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Brown/2.jpg"));
                Img3.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Brown/3.jpg"));
                Img4.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Brown/4.jpg"));
                Img5.Source = new BitmapImage(new Uri("ms-appx:///Images/album8/Brown/5.jpg"));
                highlight1.Visibility = Visibility.Visible;
                Row1_ColorBar();
                Brand_Style_Name.Text = "clearwater-blue coral-puma silver-sulphur spring";         
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
            
            }
            else if (check == "Row2_Box_2_img")
            {
                Row2_Box_2_Click();
                Row2_ColorBar();
               
            }

            else if (check == "Row2_Box_3_img")
            {
                Row2_Box_3_Click();
                Row2_ColorBar();
    
            }

            else if (check == "Row2_Box_4_img")
            {
                Row2_Box_4_Click();
                Row2_ColorBar();
        
            }
            else if (check == "two_Row1_Box_1_img")
            {
                two_Row1_Box_1_Click();
                two_Row1_ColorBar();
                Brand_Name.Text = "SUEDE CLASSIC WOMEN'S SNEAKERS";
                Brand_Price.Text = "$65.00";
                Brand_Style_Num.Text = "Style Number 355462-01";
                Brand_Style_Name.Text = "black";
               
            }

            else if (check == "two_Row1_Box_2_img")
            {
                two_Row1_Box_2_Click();
                two_Row1_ColorBar();
                Brand_Name.Text = "SUEDE CLASSIC WOMEN'S SNEAKERS";
                Brand_Price.Text = "$65.00";
                Brand_Style_Num.Text = "Style Number 355462-32";
                Brand_Style_Name.Text = "holiday-white";

            }

            else if (check == "two_Row1_Box_3_img")
            {
                two_Row1_Box_3_Click();
                two_Row1_ColorBar();
                Brand_Name.Text = "SUEDE CLASSIC WOMEN'S SNEAKERS";
                Brand_Price.Text = "$65.00";
                Brand_Style_Num.Text = "Style Number 355462-34";
                Brand_Style_Name.Text = "cool blue-white";

            }


            else if (check == "two_Row1_Box_4_img")
            {
                two_Row1_Box_4_Click();


            }

            else if (check == "two_Row2_Box_1_img")
            {
                two_Row2_Box_1_Click();
                two_Row2_ColorBar();
                Brand_Name.Text = "R698 MATTE & SHINE WOMEN'S SNEAKERS";
                Brand_Price.Text = "$56.00";
                Brand_Style_Num.Text = "Style Number 360800-02";
                Brand_Style_Name.Text = "black-black-white canvas";
            }
            else if (check == "two_Row2_Box_2_img")
            {
                two_Row2_Box_2_Click();
                two_Row2_ColorBar();
                Brand_Name.Text = "R698 MATTE & SHINE WOMEN'S SNEAKERS";
                Brand_Price.Text = "$56.00";
                Brand_Style_Num.Text = "Style Number 360800-03";
                Brand_Style_Name.Text = "glacier gray-black";
            }

            else if (check == "two_Row2_Box_3_img")
            {
                two_Row2_Box_3_Click();
                two_Row2_ColorBar();
                Brand_Name.Text = "R698 MATTE & SHINE WOMEN'S SNEAKERS";
                Brand_Price.Text = "$56.00";
                Brand_Style_Num.Text = "Style Number 360800-04";
                Brand_Style_Name.Text = "marina blue-black-white";
            }

            else if (check == "two_Row2_Box_4_img")
            {
                two_Row2_Box_4_Click();
                two_Row2_ColorBar();
                Brand_Name.Text = "R698 MATTE & SHINE WOMEN'S SNEAKERS";
                Brand_Price.Text = "$56.00";
                Brand_Style_Num.Text = "Style Number 360800-06";
                Brand_Style_Name.Text = "carmine rose-black-white";
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

        
        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.


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

            if (Brand_Name.Text == "FAAS 600 V3 WOMEN'S RUNNING SHOES")
            {
                Row1_Box_2_Click();
            }
            else if (Brand_Name.Text == "NRGY WOMEN'S RUNNING SHOES")
            {
                Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Faas 500 v4 Women's Running Shoes")
            {
                Row2_Box_2_Click();
            }
            else if (Brand_Name.Text =="SUEDE CLASSIC WOMEN'S SNEAKERS")
            {
                two_Row1_Box_2_Click();
            }
            else if (Brand_Name.Text == "76 Runner Scratched Women's Running Shoes")
            {
                two_Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "R698 MATTE & SHINE WOMEN'S SNEAKERS")
            {
                two_Row2_Box_2_Click();
            }
            else if (Brand_Name.Text == "AXEL DOTS WOMEN'S BALLET FLATS")
            {
                three_Row1_Box_2_Click();
            }
            else if (Brand_Name.Text == "Asha Alt 2 Heather Women's Ballet Flats")
            {
                three_Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Rhythm Basic Sport Women's Ballet Flats")
            {
                three_Row2_Box_2_Click();
            }

        }

        private void Row1_Box_1_color3_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (Brand_Name.Text == "FAAS 600 V3 WOMEN'S RUNNING SHOES")
            {
                Row1_Box_3_Click();
            }
            else if (Brand_Name.Text == "NRGY WOMEN'S RUNNING SHOES")
            {
                Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Faas 500 v4 Women's Running Shoes")
            {
                Row2_Box_3_Click();
            }
            else if (Brand_Name.Text == "SUEDE CLASSIC WOMEN'S SNEAKERS")
            {
                two_Row1_Box_3_Click();
            }
            else if (Brand_Name.Text == "76 Runner Scratched Women's Running Shoes")
            {
                two_Row1_Box_3_Click();
            }
            else if (Brand_Name.Text == "R698 MATTE & SHINE WOMEN'S SNEAKERS")
            {
                two_Row2_Box_3_Click();

            }
            else if (Brand_Name.Text == "AXEL DOTS WOMEN'S BALLET FLATS")
            {
                three_Row1_Box_3_Click();
            }
            else if (Brand_Name.Text == "Asha Alt 2 Heather Women's Ballet Flats")
            {
                three_Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Rhythm Basic Sport Women's Ballet Flats")
            {
                three_Row2_Box_3_Click();
            }

        }

        private void Row1_Box_1_color1_Tapped(object sender, TappedRoutedEventArgs e)
        {

            if (Brand_Name.Text == "FAAS 600 V3 WOMEN'S RUNNING SHOES")
            {
                Row1_Box_1_Click();
            }
            else if (Brand_Name.Text == "NRGY WOMEN'S RUNNING SHOES")
            {
                Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Faas 500 v4 Women's Running Shoes")
            {
                Row2_Box_1_Click();
            }
            else if (Brand_Name.Text == "SUEDE CLASSIC WOMEN'S SNEAKERS")
            {
                two_Row1_Box_1_Click();
            }
            else if (Brand_Name.Text == "76 Runner Scratched Women's Running Shoes")
            {
                two_Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "R698 MATTE & SHINE WOMEN'S SNEAKERS")
            {
                two_Row2_Box_1_Click();
            }
            else if (Brand_Name.Text == "AXEL DOTS WOMEN'S BALLET FLATS")
            {
                three_Row1_Box_1_Click();
            }
            else if (Brand_Name.Text == "Asha Alt 2 Heather Women's Ballet Flats")
            {
                three_Row1_Box_4_Click();
            }
            else if (Brand_Name.Text == "Rhythm Basic Sport Women's Ballet Flats")
            {
                three_Row2_Box_1_Click();
            }

        }

        private void Row1_Box_1_color4_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (Brand_Name.Text == "Faas 500 v4 Women's Running Shoes")
            {
                Row2_Box_4_Click();
            }
            else if (Brand_Name.Text == "R698 MATTE & SHINE WOMEN'S SNEAKERS")
            {
                two_Row2_Box_4_Click();
            }
            else if (Brand_Name.Text == "Rhythm Basic Sport Women's Ballet Flats")
            {
                three_Row2_Box_4_Click();
            }

        }

      
    }
}
        #endregion