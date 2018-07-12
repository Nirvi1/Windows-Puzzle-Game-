using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation; 


// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace game
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage2 : Page
    {
        int d;
        public BlankPage2()
        {
            this.InitializeComponent();
        }
        private DataTransferManager dataTransferManager; 
         
       
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            wonmusic.Stop();
            backmusic.Play();

          
             res1.Visibility = Visibility.Collapsed;
             res2.Visibility = Visibility.Collapsed;
                
         res3.Visibility = Visibility.Collapsed;
                
                
            timer1.Begin();
           
              DispatcherTimer dt2= new DispatcherTimer();
            dt2.Tick += dt_Tick2;
            dt2.Interval = TimeSpan.FromMinutes(5);
          

            dt2.Start();
            this.dataTransferManager = DataTransferManager.GetForCurrentView();
            this.dataTransferManager.DataRequested +=
                new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>
                    (this.OnDataRequested); 
           
        }
        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            // Unregister the current page as a share source. 
            this.dataTransferManager.DataRequested -=
                new TypedEventHandler<DataTransferManager, DataRequestedEventArgs>
                    (this.OnDataRequested);
        }
        protected void OnDataRequested(DataTransferManager sender, DataRequestedEventArgs e)
        {
            // Call the scenario specific function to populate the datapackage with the data to be shared. 
            GetShareContent(e.Request);
        }
        private void GetShareContent(DataRequest request)
        {
            DataPackage requestData = request.Data;
          
            if (rectangle4.Width >= 916.667)
            {
                requestData.Properties.Title = "Gained 3 stars in the game PERPLEXED";
                //requestData.Properties.Description = "gained 3 stars"; // The description is optional. 
                //requestData.SetText("gained 3 stars");
            }
            else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
            {
                requestData.Properties.Title = "Gained 2 stars in the game PERPLEXED";
                //requestData.Properties.Description = "gained 2 stars"; // The description is optional. 
                //requestData.SetText("gained 2 stars");
            }
            else
            {
                requestData.Properties.Title = "Gained 1 star in the game PERPLEXED";
                //requestData.Properties.Description = "gained 1 star"; // The description is optional. 
                //requestData.SetText("gained 1 stars");
            }
            requestData.SetUri(new Uri("https://www.google.co.in/url?sa=t&rct=j&q=&esrc=s&source=web&cd=1&sqi=2&ved=0CCkQFjAA&url=http%3A%2F%2Fwindows.microsoft.com%2Fen-IN%2Fwindows-8%2Fapps&ei=2l82U8OEB8SPrgee8oHQDw&usg=AFQjCNF3nCsK0Gfiuq-4W7elm4REqkiLow&sig2=Y5ilx66GuGLkmAOOZPPnAw&bvm=bv.63808443,d.bmk&cad=rja"));
        } 
        private void dt_Tick2(object sender, object e)
        {
            if (d == 0)
            {
                backimage.Visibility = Visibility.Collapsed;
                backbutton.Visibility = Visibility.Collapsed;
                LEVELFAILED1.Begin();
                backmusic.Stop();
                timeovermusic.Play();
            }
        }
  
    
        

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im57.Source;
            extra2.Source = im1.Source;
            im1.Source = extra1.Source;
            extra3.Source = im9.Source;
            im9.Source = extra2.Source;
            extra4.Source = im17.Source;
            im17.Source = extra3.Source;
            extra1.Source = im25.Source;
            im25.Source = extra4.Source;
            extra2.Source = im33.Source;
            im33.Source = extra1.Source;
            extra3.Source = im41.Source;
            im41.Source = extra2.Source;
            extra4.Source = im49.Source;
            im49.Source = extra3.Source;
            im57.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }


            }
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im58.Source;
            extra2.Source = im2.Source;
            im2.Source = extra1.Source;
            extra3.Source = im10.Source;
            im10.Source = extra2.Source;
            extra4.Source = im18.Source;
            im18.Source = extra3.Source;
            extra1.Source = im26.Source;
            im26.Source = extra4.Source;
            extra2.Source = im34.Source;
            im34.Source = extra1.Source;
            extra3.Source = im42.Source;
            im42.Source = extra2.Source;
            extra4.Source = im50.Source;
            im50.Source = extra3.Source;
            im58.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "awesum";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }


            }
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im59.Source;
            extra2.Source = im3.Source;
            im3.Source = extra1.Source;
            extra3.Source = im11.Source;
            im11.Source = extra2.Source;
            extra4.Source = im19.Source;
            im19.Source = extra3.Source;
            extra1.Source = im27.Source;
            im27.Source = extra4.Source;
            extra2.Source = im35.Source;
            im35.Source = extra1.Source;
            extra3.Source = im43.Source;
            im43.Source = extra2.Source;
            extra4.Source = im51.Source;
            im51.Source = extra3.Source;
            im59.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im60.Source;
            extra2.Source = im4.Source;
            im4.Source = extra1.Source;
            extra3.Source = im12.Source;
            im12.Source = extra2.Source;
            extra4.Source = im20.Source;
            im20.Source = extra3.Source;
            extra1.Source = im28.Source;
            im28.Source = extra4.Source;
            extra2.Source = im36.Source;
            im36.Source = extra1.Source;
            extra3.Source = im44.Source;
            im44.Source = extra2.Source;
            extra4.Source = im52.Source;
            im52.Source = extra3.Source;
            im60.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }


            }
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im61.Source;
            extra2.Source = im5.Source;
            im5.Source = extra1.Source;
            extra3.Source = im13.Source;
            im13.Source = extra2.Source;
            extra4.Source = im21.Source;
            im21.Source = extra3.Source;
            extra1.Source = im29.Source;
            im29.Source = extra4.Source;
            extra2.Source = im37.Source;
            im37.Source = extra1.Source;
            extra3.Source = im45.Source;
            im45.Source = extra2.Source;
            extra4.Source = im53.Source;
            im53.Source = extra3.Source;
            im61.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 625)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width <  916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }


        private void b6_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im62.Source;
            extra2.Source = im6.Source;
            im6.Source = extra1.Source;
            extra3.Source = im14.Source;
            im14.Source = extra2.Source;
            extra4.Source = im22.Source;
            im22.Source = extra3.Source;
            extra1.Source = im30.Source;
            im30.Source = extra4.Source;
            extra2.Source = im38.Source;
            im38.Source = extra1.Source;
            extra3.Source = im46.Source;
            im46.Source = extra2.Source;
            extra4.Source = im54.Source;
            im54.Source = extra3.Source;
            im62.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width  < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }


        private void b7_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im63.Source;
            extra2.Source = im7.Source;
            im7.Source = extra1.Source;
            extra3.Source = im15.Source;
            im15.Source = extra2.Source;
            extra4.Source = im23.Source;
            im23.Source = extra3.Source;
            extra1.Source = im31.Source;
            im31.Source = extra4.Source;
            extra2.Source = im39.Source;
            im39.Source = extra1.Source;
            extra3.Source = im47.Source;
            im47.Source = extra2.Source;
            extra4.Source = im55.Source;
            im55.Source = extra3.Source;
            im63.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;

                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im64.Source;
            extra2.Source = im8.Source;
            im8.Source = extra1.Source;
            extra3.Source = im16.Source;
            im16.Source = extra2.Source;
            extra4.Source = im24.Source;
            im24.Source = extra3.Source;
            extra1.Source = im32.Source;
            im32.Source = extra4.Source;
            extra2.Source = im40.Source;
            im40.Source = extra1.Source;
            extra3.Source = im48.Source;
            im48.Source = extra2.Source;
            extra4.Source = im56.Source;
            im56.Source = extra3.Source;
            im64.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";

                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im64.Source;
            extra2.Source = im57.Source;
            im57.Source = extra1.Source;
            extra3.Source = im58.Source;
            im58.Source = extra2.Source;
            extra4.Source = im59.Source;
            im59.Source = extra3.Source;
            extra1.Source = im60.Source;
            im60.Source = extra4.Source;
            extra2.Source = im61.Source;
            im61.Source = extra1.Source;
            extra3.Source = im62.Source;
            im62.Source = extra2.Source;
            extra4.Source = im63.Source;
            im63.Source = extra3.Source;
            im64.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >=916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b10_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im56.Source;
            extra2.Source = im49.Source;
            im49.Source = extra1.Source;
            extra3.Source = im50.Source;
            im50.Source = extra2.Source;
            extra4.Source = im51.Source;
            im51.Source = extra3.Source;
            extra1.Source = im52.Source;
            im52.Source = extra4.Source;
            extra2.Source = im53.Source;
            im53.Source = extra1.Source;
            extra3.Source = im54.Source;
            im54.Source = extra2.Source;
            extra4.Source = im55.Source;
            im55.Source = extra3.Source;
            im56.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                backmusic.Stop();
                wonmusic.Play();
                timer1.Pause();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b11_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im48.Source;
            extra2.Source = im41.Source;
            im41.Source = extra1.Source;
            extra3.Source = im42.Source;
            im42.Source = extra2.Source;
            extra4.Source = im43.Source;
            im43.Source = extra3.Source;
            extra1.Source = im44.Source;
            im44.Source = extra4.Source;
            extra2.Source = im45.Source;
            im45.Source = extra1.Source;
            extra3.Source = im46.Source;
            im46.Source = extra2.Source;
            extra4.Source = im47.Source;
            im47.Source = extra3.Source;
            im48.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backmusic.Stop();
                wonmusic.Play();
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b12_Click(object sender, RoutedEventArgs e)
        {

            extra1.Source = im40.Source;
            extra2.Source = im33.Source;
            im33.Source = extra1.Source;
            extra3.Source = im34.Source;
            im34.Source = extra2.Source;
            extra4.Source = im35.Source;
            im35.Source = extra3.Source;
            extra1.Source = im36.Source;
            im36.Source = extra4.Source;
            extra2.Source = im37.Source;
            im37.Source = extra1.Source;
            extra3.Source = im38.Source;
            im38.Source = extra2.Source;
            extra4.Source = im39.Source;
            im39.Source = extra3.Source;
            im40.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                d++;
                welldone1.Begin();
                backmusic.Stop();
                wonmusic.Play();
                timer1.Pause();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void b13_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im32.Source;
            extra2.Source = im25.Source;
            im25.Source = extra1.Source;
            extra3.Source = im26.Source;
            im26.Source = extra2.Source;
            extra4.Source = im27.Source;
            im27.Source = extra3.Source;
            extra1.Source = im28.Source;
            im28.Source = extra4.Source;
            extra2.Source = im29.Source;
            im29.Source = extra1.Source;
            extra3.Source = im30.Source;
            im30.Source = extra2.Source;
            extra4.Source = im31.Source;
            im31.Source = extra3.Source;
            im32.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;

                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void b14_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im24.Source;
            extra2.Source = im17.Source;
            im17.Source = extra1.Source;
            extra3.Source = im18.Source;
            im18.Source = extra2.Source;
            extra4.Source = im19.Source;
            im19.Source = extra3.Source;
            extra1.Source = im20.Source;
            im20.Source = extra4.Source;
            extra2.Source = im21.Source;
            im21.Source = extra1.Source;
            extra3.Source = im22.Source;
            im22.Source = extra2.Source;
            extra4.Source = im23.Source;
            im23.Source = extra3.Source;
            im24.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }

        }

        private void b15_Click(object sender, RoutedEventArgs e)
        {

            extra1.Source = im16.Source;
            extra2.Source = im9.Source;
            im9.Source = extra1.Source;
            extra3.Source = im10.Source;
            im10.Source = extra2.Source;
            extra4.Source = im11.Source;
            im11.Source = extra3.Source;
            extra1.Source = im12.Source;
            im12.Source = extra4.Source;
            extra2.Source = im13.Source;
            im13.Source = extra1.Source;
            extra3.Source = im14.Source;
            im14.Source = extra2.Source;
            extra4.Source = im15.Source;
            im15.Source = extra3.Source;
            im16.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void b16_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im8.Source;
            extra2.Source = im1.Source;
            im1.Source = extra1.Source;
            extra3.Source = im2.Source;
            im2.Source = extra2.Source;
            extra4.Source = im3.Source;
            im3.Source = extra3.Source;
            extra1.Source = im4.Source;
            im4.Source = extra4.Source;
            extra2.Source = im5.Source;
            im5.Source = extra1.Source;
            extra3.Source = im6.Source;
            im6.Source = extra2.Source;
            extra4.Source = im7.Source;
            im7.Source = extra3.Source;
            im8.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                backmusic.Stop();
                wonmusic.Play();
                timer1.Pause();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void b17_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im8.Source;
            extra2.Source = im64.Source;
            im64.Source = extra1.Source;
            extra3.Source = im56.Source;
            im56.Source = extra2.Source;
            extra4.Source = im48.Source;
            im48.Source = extra3.Source;
            extra1.Source = im40.Source;
            im40.Source = extra4.Source;
            extra2.Source = im32.Source;
            im32.Source = extra1.Source;
            extra3.Source = im24.Source;
            im24.Source = extra2.Source;
            extra4.Source = im16.Source;
            im16.Source = extra3.Source;
            im8.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b18_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im7.Source;
            extra2.Source = im63.Source;
            im63.Source = extra1.Source;
            extra3.Source = im55.Source;
            im55.Source = extra2.Source;
            extra4.Source = im47.Source;
            im47.Source = extra3.Source;
            extra1.Source = im39.Source;
            im39.Source = extra4.Source;
            extra2.Source = im31.Source;
            im31.Source = extra1.Source;
            extra3.Source = im23.Source;
            im23.Source = extra2.Source;
            extra4.Source = im15.Source;
            im15.Source = extra3.Source;
            im7.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b19_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im6.Source;
            extra2.Source = im62.Source;
            im62.Source = extra1.Source;
            extra3.Source = im54.Source;
            im54.Source = extra2.Source;
            extra4.Source = im46.Source;
            im46.Source = extra3.Source;
            extra1.Source = im38.Source;
            im38.Source = extra4.Source;
            extra2.Source = im30.Source;
            im30.Source = extra1.Source;
            extra3.Source = im22.Source;
            im22.Source = extra2.Source;
            extra4.Source = im14.Source;
            im14.Source = extra3.Source;
            im6.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;

                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!" ;
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b20_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im5.Source;
            extra2.Source = im61.Source;
            im61.Source = extra1.Source;
            extra3.Source = im53.Source;
            im53.Source = extra2.Source;
            extra4.Source = im45.Source;
            im45.Source = extra3.Source;
            extra1.Source = im37.Source;
            im37.Source = extra4.Source;
            extra2.Source = im29.Source;
            im29.Source = extra1.Source;
            extra3.Source = im21.Source;
            im21.Source = extra2.Source;
            extra4.Source = im13.Source;
            im13.Source = extra3.Source;
            im5.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                d++;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b21_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im4.Source;
            extra2.Source = im60.Source;
            im60.Source = extra1.Source;
            extra3.Source = im52.Source;
            im52.Source = extra2.Source;
            extra4.Source = im44.Source;
            im44.Source = extra3.Source;
            extra1.Source = im36.Source;
            im36.Source = extra4.Source;
            extra2.Source = im28.Source;
            im28.Source = extra1.Source;
            extra3.Source = im20.Source;
            im20.Source = extra2.Source;
            extra4.Source = im12.Source;
            im12.Source = extra3.Source;
            im4.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                d++;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b22_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im3.Source;
            extra2.Source = im59.Source;
            im59.Source = extra1.Source;
            extra3.Source = im51.Source;
            im51.Source = extra2.Source;
            extra4.Source = im43.Source;
            im43.Source = extra3.Source;
            extra1.Source = im35.Source;
            im35.Source = extra4.Source;
            extra2.Source = im27.Source;
            im27.Source = extra1.Source;
            extra3.Source = im19.Source;
            im19.Source = extra2.Source;
            extra4.Source = im11.Source;
            im11.Source = extra3.Source;
            im3.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void b23_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im2.Source;
            extra2.Source = im58.Source;
            im58.Source = extra1.Source;
            extra3.Source = im50.Source;
            im50.Source = extra2.Source;
            extra4.Source = im42.Source;
            im42.Source = extra3.Source;
            extra1.Source = im34.Source;
            im34.Source = extra4.Source;
            extra2.Source = im26.Source;
            im26.Source = extra1.Source;
            extra3.Source = im18.Source;
            im18.Source = extra2.Source;
            extra4.Source = im10.Source;
            im10.Source = extra3.Source;
            im2.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b24_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im1.Source;
            extra2.Source = im57.Source;
            im57.Source = extra1.Source;
            extra3.Source = im49.Source;
            im49.Source = extra2.Source;
            extra4.Source = im41.Source;
            im41.Source = extra3.Source;
            extra1.Source = im33.Source;
            im33.Source = extra4.Source;
            extra2.Source = im25.Source;
            im25.Source = extra1.Source;
            extra3.Source = im17.Source;
            im17.Source = extra2.Source;
            extra4.Source = im9.Source;
            im9.Source = extra3.Source;
            im1.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b25_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im1.Source;
            extra2.Source = im8.Source;
            im8.Source = extra1.Source;
            extra3.Source = im7.Source;
            im7.Source = extra2.Source;
            extra4.Source = im6.Source;
            im6.Source = extra3.Source;
            extra1.Source = im5.Source;
            im5.Source = extra4.Source;
            extra2.Source = im4.Source;
            im4.Source = extra1.Source;
            extra3.Source = im3.Source;
            im3.Source = extra2.Source;
            extra4.Source = im2.Source;
            im2.Source = extra3.Source;
            im1.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                d++;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b26_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im9.Source;
            extra2.Source = im16.Source;
            im16.Source = extra1.Source;
            extra3.Source = im15.Source;
            im15.Source = extra2.Source;
            extra4.Source = im14.Source;
            im14.Source = extra3.Source;
            extra1.Source = im13.Source;
            im13.Source = extra4.Source;
            extra2.Source = im12.Source;
            im12.Source = extra1.Source;
            extra3.Source = im11.Source;
            im11.Source = extra2.Source;
            extra4.Source = im10.Source;
            im10.Source = extra3.Source;
            im9.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b27_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im17.Source;
            extra2.Source = im24.Source;
            im24.Source = extra1.Source;
            extra3.Source = im23.Source;
            im23.Source = extra2.Source;
            extra4.Source = im22.Source;
            im22.Source = extra3.Source;
            extra1.Source = im21.Source;
            im21.Source = extra4.Source;
            extra2.Source = im20.Source;
            im20.Source = extra1.Source;
            extra3.Source = im19.Source;
            im19.Source = extra2.Source;
            extra4.Source = im18.Source;
            im18.Source = extra3.Source;
            im17.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                d++;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b28_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im25.Source;
            extra2.Source = im32.Source;
            im32.Source = extra1.Source;
            extra3.Source = im31.Source;
            im31.Source = extra2.Source;
            extra4.Source = im30.Source;
            im30.Source = extra3.Source;
            extra1.Source = im29.Source;
            im29.Source = extra4.Source;
            extra2.Source = im28.Source;
            im28.Source = extra1.Source;
            extra3.Source = im27.Source;
            im27.Source = extra2.Source;
            extra4.Source = im26.Source;
            im26.Source = extra3.Source;
            im25.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }


        private void b29_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im33.Source;
            extra2.Source = im40.Source;
            im40.Source = extra1.Source;
            extra3.Source = im39.Source;
            im39.Source = extra2.Source;
            extra4.Source = im38.Source;
            im38.Source = extra3.Source;
            extra1.Source = im37.Source;
            im37.Source = extra4.Source;
            extra2.Source = im36.Source;
            im36.Source = extra1.Source;
            extra3.Source = im35.Source;
            im35.Source = extra2.Source;
            extra4.Source = im34.Source;
            im34.Source = extra3.Source;
            im33.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b30_Click(object sender, RoutedEventArgs e)
        {


            extra1.Source = im41.Source;
            extra2.Source = im48.Source;
            im48.Source = extra1.Source;
            extra3.Source = im47.Source;
            im47.Source = extra2.Source;
            extra4.Source = im46.Source;
            im46.Source = extra3.Source;
            extra1.Source = im45.Source;
            im45.Source = extra4.Source;
            extra2.Source = im44.Source;
            im44.Source = extra1.Source;
            extra3.Source = im43.Source;
            im43.Source = extra2.Source;
            extra4.Source = im42.Source;
            im42.Source = extra3.Source;
            im41.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                d++; 
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {

                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b31_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im49.Source;
            extra2.Source = im56.Source;
            im56.Source = extra1.Source;
            extra3.Source = im55.Source;
            im55.Source = extra2.Source;
            extra4.Source = im54.Source;
            im54.Source = extra3.Source;
            extra1.Source = im53.Source;
            im53.Source = extra4.Source;
            extra2.Source = im52.Source;
            im52.Source = extra1.Source;
            extra3.Source = im51.Source;
            im51.Source = extra2.Source;
            extra4.Source = im50.Source;
            im50.Source = extra3.Source;
            im49.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void b32_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = im57.Source;
            extra2.Source = im64.Source;
            im64.Source = extra1.Source;
            extra3.Source = im63.Source;
            im63.Source = extra2.Source;
            extra4.Source = im62.Source;
            im62.Source = extra3.Source;
            extra1.Source = im61.Source;
            im61.Source = extra4.Source;
            extra2.Source = im60.Source;
            im60.Source = extra1.Source;
            extra3.Source = im59.Source;
            im59.Source = extra2.Source;
            extra4.Source = im58.Source;
            im58.Source = extra3.Source;
            im57.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b7_Click_1(object sender, RoutedEventArgs e)
        {
            extra1.Source = im63.Source;
            extra2.Source = im7.Source;
            im7.Source = extra1.Source;
            extra3.Source = im15.Source;
            im15.Source = extra2.Source;
            extra4.Source = im23.Source;
            im23.Source = extra3.Source;
            extra1.Source = im31.Source;
            im31.Source = extra4.Source;
            extra2.Source = im39.Source;
            im39.Source = extra1.Source;
            extra3.Source = im47.Source;
            im47.Source = extra2.Source;
            extra4.Source = im55.Source;
            im55.Source = extra3.Source;
            im63.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b8_Click_1(object sender, RoutedEventArgs e)
        {
            extra1.Source = im64.Source;
            extra2.Source = im8.Source;
            im8.Source = extra1.Source;
            extra3.Source = im16.Source;
            im16.Source = extra2.Source;
            extra4.Source = im24.Source;
            im24.Source = extra3.Source;
            extra1.Source = im32.Source;
            im32.Source = extra4.Source;
            extra2.Source = im40.Source;
            im40.Source = extra1.Source;
            extra3.Source = im48.Source;
            im48.Source = extra2.Source;
            extra4.Source = im56.Source;
            im56.Source = extra3.Source;
            im64.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b18_Click_1(object sender, RoutedEventArgs e)
        {
            extra1.Source = im7.Source;
            extra2.Source = im63.Source;
            im63.Source = extra1.Source;
            extra3.Source = im55.Source;
            im55.Source = extra2.Source;
            extra4.Source = im47.Source;
            im47.Source = extra3.Source;
            extra1.Source = im39.Source;
            im39.Source = extra4.Source;
            extra2.Source = im31.Source;
            im31.Source = extra1.Source;
            extra3.Source = im23.Source;
            im23.Source = extra2.Source;
            extra4.Source = im15.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            im15.Source = extra3.Source;
            im7.Source = extra4.Source;

            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b19_Click_1(object sender, RoutedEventArgs e)
        {
            extra1.Source = im6.Source;
            extra2.Source = im62.Source;
            im62.Source = extra1.Source;
            extra3.Source = im54.Source;
            im54.Source = extra2.Source;
            extra4.Source = im46.Source;
            im46.Source = extra3.Source;
            extra1.Source = im38.Source;
            im38.Source = extra4.Source;
            extra2.Source = im30.Source;
            im30.Source = extra1.Source;
            extra3.Source = im22.Source;
            im22.Source = extra2.Source;
            extra4.Source = im14.Source;
            im14.Source = extra3.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            im6.Source = extra4.Source;

            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }

        }

        private void b20_Click_1(object sender, RoutedEventArgs e)
        {
            extra1.Source = im5.Source;
            extra2.Source = im61.Source;
            im61.Source = extra1.Source;
            extra3.Source = im53.Source;
            im53.Source = extra2.Source;
            extra4.Source = im45.Source;
            im45.Source = extra3.Source;
            extra1.Source = im37.Source;
            im37.Source = extra4.Source;
            extra2.Source = im29.Source;
            im29.Source = extra1.Source;
            extra3.Source = im21.Source;
            im21.Source = extra2.Source;
            extra4.Source = im13.Source;
            im13.Source = extra3.Source;

            im5.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b21_Click_1(object sender, RoutedEventArgs e)
        {
            extra1.Source = im4.Source;
            extra2.Source = im60.Source;
            im60.Source = extra1.Source;
            extra3.Source = im52.Source;
            im52.Source = extra2.Source;
            extra4.Source = im44.Source;
            im44.Source = extra3.Source;
            extra1.Source = im36.Source;
            im36.Source = extra4.Source;
            extra2.Source = im28.Source;

            im28.Source = extra1.Source;
            extra3.Source = im20.Source;
            im20.Source = extra2.Source;
            extra4.Source = im12.Source;
            im12.Source = extra3.Source;
            im4.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b22_Click_1(object sender, RoutedEventArgs e)
        {
            extra1.Source = im3.Source;
            extra2.Source = im59.Source;
            im59.Source = extra1.Source;
            extra3.Source = im51.Source;
            im51.Source = extra2.Source;
            extra4.Source = im43.Source;
            im43.Source = extra3.Source;
            extra1.Source = im35.Source;
            im35.Source = extra4.Source;
            extra2.Source = im27.Source;
            im27.Source = extra1.Source;
            extra3.Source = im19.Source;
            im19.Source = extra2.Source;
            extra4.Source = im11.Source;
            im11.Source = extra3.Source;
            im3.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }


            }
        }

        private void b23_Click_1(object sender, RoutedEventArgs e)
        {

            extra1.Source = im2.Source;
            extra2.Source = im58.Source;
            im58.Source = extra1.Source;
            extra3.Source = im50.Source;
            im50.Source = extra2.Source;
            extra4.Source = im42.Source;
            im42.Source = extra3.Source;
            extra1.Source = im34.Source;
            im34.Source = extra4.Source;
            extra2.Source = im26.Source;
            im26.Source = extra1.Source;
            extra3.Source = im18.Source;
            im18.Source = extra2.Source;
            extra4.Source = im10.Source;
            im10.Source = extra3.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            im2.Source = extra4.Source;

            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text ="Awesome!!";
                    stars.Begin();
                    res1.Visibility =Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b24_Click_1(object sender, RoutedEventArgs e)
        {
            extra1.Source = im1.Source;
            extra2.Source = im57.Source;
            im57.Source = extra1.Source;
            extra3.Source = im49.Source;
            im49.Source = extra2.Source;
            extra4.Source = im41.Source;
            im41.Source = extra3.Source;
            extra1.Source = im33.Source;
            im33.Source = extra4.Source;
            extra2.Source = im25.Source;
            im25.Source = extra1.Source;
            extra3.Source = im17.Source;
            im17.Source = extra2.Source;
            extra4.Source = im9.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            im9.Source = extra3.Source;
            im1.Source = extra4.Source;

            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b11_Click_1(object sender, RoutedEventArgs e)
        {
            extra1.Source = im48.Source;
            extra2.Source = im41.Source;
            im41.Source = extra1.Source;
            extra3.Source = im42.Source;
            im42.Source = extra2.Source;
            extra4.Source = im43.Source;
            im43.Source = extra3.Source;
            extra1.Source = im44.Source;
            im44.Source = extra4.Source;
            extra2.Source = im45.Source;
            im45.Source = extra1.Source;
            extra3.Source = im46.Source;
            im46.Source = extra2.Source;
            extra4.Source = im47.Source;

            im47.Source = extra3.Source;
            im48.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >=916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void b12_Click_1(object sender, RoutedEventArgs e)
        {

            extra1.Source = im40.Source;
            extra2.Source = im33.Source;
            im33.Source = extra1.Source;
            extra3.Source = im34.Source;
            im34.Source = extra2.Source;
            extra4.Source = im35.Source;
            im35.Source = extra3.Source;
            extra1.Source = im36.Source;
            im36.Source = extra4.Source;
            extra2.Source = im37.Source;
            im37.Source = extra1.Source;
            extra3.Source = im38.Source;
            im38.Source = extra2.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            extra4.Source = im39.Source;
            im39.Source = extra3.Source;
            im40.Source = extra4.Source;

            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void b13_Click_1(object sender, RoutedEventArgs e)
        {
            extra1.Source = im32.Source;
            extra2.Source = im25.Source;
            im25.Source = extra1.Source;
            extra3.Source = im26.Source;
            im26.Source = extra2.Source;
            extra4.Source = im27.Source;
            im27.Source = extra3.Source;
            extra1.Source = im28.Source;
            im28.Source = extra4.Source;
            extra2.Source = im29.Source;
            im29.Source = extra1.Source;
            extra3.Source = im30.Source;
            im30.Source = extra2.Source;
            extra4.Source = im31.Source;
            im31.Source = extra3.Source;
            im32.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b14_Click_1(object sender, RoutedEventArgs e)
        {
            extra1.Source = im24.Source;
            extra2.Source = im17.Source;
            im17.Source = extra1.Source;
            extra3.Source = im18.Source;
            im18.Source = extra2.Source;
            extra4.Source = im19.Source;
            im19.Source = extra3.Source;
            extra1.Source = im20.Source;
            im20.Source = extra4.Source;
            extra2.Source = im21.Source;
            im21.Source = extra1.Source;
            extra3.Source = im22.Source;
            im22.Source = extra2.Source;
            extra4.Source = im23.Source;
            im23.Source = extra3.Source;
            im24.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void b15_Click_1(object sender, RoutedEventArgs e)
        {

            extra1.Source = im16.Source;
            extra2.Source = im9.Source;
            im9.Source = extra1.Source;
            extra3.Source = im10.Source;
            im10.Source = extra2.Source;
            extra4.Source = im11.Source;
            im11.Source = extra3.Source;
            extra1.Source = im12.Source;
            im12.Source = extra4.Source;
            extra2.Source = im13.Source;
            im13.Source = extra1.Source;
            extra3.Source = im14.Source;
            im14.Source = extra2.Source;
            extra4.Source = im15.Source;
            im15.Source = extra3.Source;
            im16.Source = extra4.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;


            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void b16_Click_1(object sender, RoutedEventArgs e)
        {
            extra1.Source = im8.Source;
            extra2.Source = im1.Source;
            im1.Source = extra1.Source;
            extra3.Source = im2.Source;
            im2.Source = extra2.Source;
            extra4.Source = im3.Source;
            im3.Source = extra3.Source;
            extra1.Source = im4.Source;
            im4.Source = extra4.Source;
            extra2.Source = im5.Source;
            im5.Source = extra1.Source;
            extra3.Source = im6.Source;
            im6.Source = extra2.Source;
            extra4.Source = im7.Source;
            im7.Source = extra3.Source;
            var uri19 = (final3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            im8.Source = extra4.Source;

            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var uri19 = (f3.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri1 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (im20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (im21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (im27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri24 = (im1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri20 = (im8.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (im57.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (im64.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (im30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (im35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (im36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (im10.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri21 = (im15.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri22 = (im50.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri23 = (im55.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (im38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (im44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (im45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri12 == uri19 & uri13 == uri19 & uri8 == uri19 & uri4 == uri19 & uri3 == uri19 & uri14 == uri19 & uri5 == uri19 & uri9 == uri19 & uri11 == uri2 & uri21 == uri2 & uri22 == uri2 & uri23 == uri2 & uri24 == uri1 & uri20 == uri1 & uri6 == uri1 & uri7 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone1.Begin();
                timer1.Pause();
                backmusic.Stop();
                wonmusic.Play();
                b1.Visibility = Visibility.Collapsed;
                b2.Visibility = Visibility.Collapsed;
                b3.Visibility = Visibility.Collapsed;
                b4.Visibility = Visibility.Collapsed;
                b5.Visibility = Visibility.Collapsed;
                b6.Visibility = Visibility.Collapsed;
                b7.Visibility = Visibility.Collapsed;
                b8.Visibility = Visibility.Collapsed;
                b9.Visibility = Visibility.Collapsed;
                b10.Visibility = Visibility.Collapsed;
                b11.Visibility = Visibility.Collapsed;
                b12.Visibility = Visibility.Collapsed;
                b13.Visibility = Visibility.Collapsed;
                b14.Visibility = Visibility.Collapsed;
                b15.Visibility = Visibility.Collapsed;
                b16.Visibility = Visibility.Collapsed;
                b17.Visibility = Visibility.Collapsed;
                b18.Visibility = Visibility.Collapsed;
                b19.Visibility = Visibility.Collapsed;
                b20.Visibility = Visibility.Collapsed;
                b21.Visibility = Visibility.Collapsed;
                b23.Visibility = Visibility.Collapsed;
                b22.Visibility = Visibility.Collapsed;
                b24.Visibility = Visibility.Collapsed;
                b25.Visibility = Visibility.Collapsed;
                b26.Visibility = Visibility.Collapsed;
                b27.Visibility = Visibility.Collapsed;
                b28.Visibility = Visibility.Collapsed;
                b29.Visibility = Visibility.Collapsed;
                b30.Visibility = Visibility.Collapsed;
                b31.Visibility = Visibility.Collapsed;
                b32.Visibility = Visibility.Collapsed;
                
                if (rectangle4.Width >= 916.667)
                {
                    result2.Text = "Awesome!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;
                
                
                }
                else if (rectangle4.Width < 916.667 && rectangle4.Width >= 541.667)
                {
                    result2.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;
               
                 

                }
                else
                {
                    result2.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible; 
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }

        }

        private void button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage2));
        }

        private void refresh_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage2));
        }

       

       

        private void hyperlinkButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            DataTransferManager.ShowShareUI(); 
        }

        private void HyperlinkButton_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage2));
        }

      

        private void Button_Click_3(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

       

        private void Button_Click_2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_41(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click_4(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void HyperlinkButton_Click_2(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }

}
    
