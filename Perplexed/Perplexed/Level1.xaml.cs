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
    public sealed partial class BlankPage1 : Page
    {
        int d = 0;
        private DataTransferManager dataTransferManager; 
         
        public BlankPage1()
        {
            this.InitializeComponent();
      
        }
        DispatcherTimer dt2 = new DispatcherTimer();
        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

            backmusic.Play();
            timer.Begin();
            DispatcherTimer dt2= new DispatcherTimer();
            dt2.Tick += dt_Tick2;
            dt2.Interval = TimeSpan.FromMinutes(3);
          

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
          
            if (rectangle4.Width >= 763.889)
            {
                requestData.Properties.Title = "Gained 3 stars in the game PERPLEXED";
                //requestData.Properties.Description = "gained 3 stars"; // The description is optional. 
                //requestData.SetText("gained 3 stars");
            }
            else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
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
                timeout1.Begin();
                backmusic.Stop();
                timeovermusic.Play();
                tt.Text += "TIME OVER";
            }
        }

        
       

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            extra1.Source = i8.Source;
            extra2.Source = i1.Source;
            i1.Source = extra1.Source;
            extra3.Source = i2.Source;
            i2.Source = extra2.Source;
            extra4.Source = i3.Source;
            i3.Source = extra3.Source;
            extra1.Source = i4.Source;
            i4.Source = extra4.Source;
            extra2.Source = i5.Source;
            i5.Source = extra1.Source;
            extra3.Source = i6.Source;
            i6.Source = extra2.Source;
            extra4.Source = i7.Source;
            i7.Source = extra3.Source;
            i8.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backmusic.Stop();
                wonmusic.Play();
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }

            
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            extra1.Source = i16.Source;
            extra2.Source = i9.Source;
            i9.Source = extra1.Source;
            extra3.Source = i10.Source;
            i10.Source = extra2.Source;
            extra4.Source = i11.Source;
            i11.Source = extra3.Source;
            extra1.Source = i12.Source;
            i12.Source = extra4.Source;
            extra2.Source = i13.Source;
            i13.Source = extra1.Source;
            extra3.Source = i14.Source;
            i14.Source = extra2.Source;
            extra4.Source = i15.Source;
            i15.Source = extra3.Source;
            i16.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backmusic.Stop();
                wonmusic.Play();
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
          
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            extra1.Source = i24.Source;
            extra2.Source = i17.Source;
            i17.Source = extra1.Source;
            extra3.Source = i18.Source;
            i18.Source = extra2.Source;
            extra4.Source = i19.Source;
            i19.Source = extra3.Source;
            extra1.Source = i20.Source;
            i20.Source = extra4.Source;
            extra2.Source = i21.Source;
            i21.Source = extra1.Source;
            extra3.Source = i22.Source;
            i22.Source = extra2.Source;
            extra4.Source = i23.Source;
            i23.Source = extra3.Source;
            i24.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backmusic.Stop();
                wonmusic.Play();
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
                d++;
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
                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            extra1.Source = i32.Source;
            extra2.Source = i25.Source;
            i25.Source = extra1.Source;
            extra3.Source = i26.Source;
            i26.Source = extra2.Source;
            extra4.Source = i27.Source;
            i27.Source = extra3.Source;
            extra1.Source = i28.Source;
            i28.Source = extra4.Source;
            extra2.Source = i29.Source;
            i29.Source = extra1.Source;
            extra3.Source = i30.Source;
            i30.Source = extra2.Source;
            extra4.Source = i31.Source;
            i31.Source = extra3.Source;
            i32.Source = extra4.Source;

            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backmusic.Stop();
                d++;
                wonmusic.Play();
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            extra1.Source = i40.Source;
            extra2.Source = i33.Source;
            i33.Source = extra1.Source;
            extra3.Source = i34.Source;
            i34.Source = extra2.Source;
            extra4.Source = i35.Source;
            i35.Source = extra3.Source;
            extra1.Source = i36.Source;
            i36.Source = extra4.Source;
            extra2.Source = i37.Source;
            i37.Source = extra1.Source;
            extra3.Source = i38.Source;
            i38.Source = extra2.Source;
            extra4.Source = i39.Source;
            i39.Source = extra3.Source;
            i40.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backmusic.Stop();
                wonmusic.Play();
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
         
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            extra1.Source = i48.Source;
            extra2.Source = i41.Source;
            i41.Source = extra1.Source;
            extra3.Source = i42.Source;
            i42.Source = extra2.Source;
            extra4.Source = i43.Source;
            i43.Source = extra3.Source;
            extra1.Source = i44.Source;
            i44.Source = extra4.Source;
            extra2.Source = i45.Source;
            i45.Source = extra1.Source;
            extra3.Source = i46.Source;
            i46.Source = extra2.Source;
            extra4.Source = i47.Source;
            i47.Source = extra3.Source;
            i48.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backmusic.Stop();
                wonmusic.Play();
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            extra1.Source = i56.Source;
            extra2.Source = i49.Source;
            i49.Source = extra1.Source;
            extra3.Source = i50.Source;
            i50.Source = extra2.Source;
            extra4.Source = i51.Source;
            i51.Source = extra3.Source;
            extra1.Source = i52.Source;
            i52.Source = extra4.Source;
            extra2.Source = i53.Source;
            i53.Source = extra1.Source;
            extra3.Source = i54.Source;
            i54.Source = extra2.Source;
            extra4.Source = i55.Source;
            i55.Source = extra3.Source;
            i56.Source = extra4.Source;

            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backmusic.Stop();
                d++;
                wonmusic.Play();
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            extra1.Source = i64.Source;
            extra2.Source = i57.Source;
            i57.Source = extra1.Source;
            extra3.Source = i58.Source;
            i58.Source = extra2.Source;
            extra4.Source = i59.Source;
            i59.Source = extra3.Source;
            extra1.Source = i60.Source;
            i60.Source = extra4.Source;
            extra2.Source = i61.Source;
            i61.Source = extra1.Source;
            extra3.Source = i62.Source;
            i62.Source = extra2.Source;
            extra4.Source = i63.Source;
            i63.Source = extra3.Source;
            i64.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backmusic.Stop();
                d++;
                wonmusic.Play();
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
            extra1.Source = i16.Source;
            extra2.Source = i9.Source;
            i9.Source = extra1.Source;
            extra3.Source = i10.Source;
            i10.Source = extra2.Source;
            extra4.Source = i11.Source;
            i11.Source = extra3.Source;
            extra1.Source = i12.Source;
            i12.Source = extra4.Source;
            extra2.Source = i13.Source;
            i13.Source = extra1.Source;
            extra3.Source = i14.Source;
            i14.Source = extra2.Source;
            extra4.Source = i15.Source;
            i15.Source = extra3.Source;
            i16.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backmusic.Stop();
                d++;
                wonmusic.Play();
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            extra1.Source = i24.Source;
            extra2.Source = i17.Source;
            i17.Source = extra1.Source;
            extra3.Source = i18.Source;
            i18.Source = extra2.Source;
            extra4.Source = i19.Source;
            i19.Source = extra3.Source;
            extra1.Source = i20.Source;
            i20.Source = extra4.Source;
            extra2.Source = i21.Source;
            i21.Source = extra1.Source;
            extra3.Source = i22.Source;
            i22.Source = extra2.Source;
            extra4.Source = i23.Source;
            i23.Source = extra3.Source;
            i24.Source = extra4.Source;

            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backmusic.Stop();
                wonmusic.Play();
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            extra1.Source = i32.Source;
            extra2.Source = i25.Source;
            i25.Source = extra1.Source;
            extra3.Source = i26.Source;
            i26.Source = extra2.Source;
            extra4.Source = i27.Source;
            i27.Source = extra3.Source;
            extra1.Source = i28.Source;
            i28.Source = extra4.Source;
            extra2.Source = i29.Source;
            i29.Source = extra1.Source;
            extra3.Source = i30.Source;
            i30.Source = extra2.Source;
            extra4.Source = i31.Source;
            i31.Source = extra3.Source;
            i32.Source = extra4.Source;

            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backmusic.Stop();
                wonmusic.Play();
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {

            extra1.Source = i40.Source;
            extra2.Source = i33.Source;
            i33.Source = extra1.Source;
            extra3.Source = i34.Source;
            i34.Source = extra2.Source;
            extra4.Source = i35.Source;
            i35.Source = extra3.Source;
            extra1.Source = i36.Source;
            i36.Source = extra4.Source;
            extra2.Source = i37.Source;
            i37.Source = extra1.Source;
            extra3.Source = i38.Source;
            i38.Source = extra2.Source;
            extra4.Source = i39.Source;
            i39.Source = extra3.Source;
            i40.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backmusic.Stop();
                d++;
                wonmusic.Play();
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            
            extra1.Source = i48.Source;
            extra2.Source = i41.Source;
            i41.Source = extra1.Source;
            extra3.Source = i42.Source;
            i42.Source = extra2.Source;
            extra4.Source = i43.Source;
            i43.Source = extra3.Source;
            extra1.Source = i44.Source;
            i44.Source = extra4.Source;
            extra2.Source = i45.Source;
            i45.Source = extra1.Source;
            extra3.Source = i46.Source;
            i46.Source = extra2.Source;
            extra4.Source = i47.Source;
            i47.Source = extra3.Source;
            i48.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backmusic.Stop();
                wonmusic.Play();
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            extra1.Source = i56.Source;
            extra2.Source = i49.Source;
            i49.Source = extra1.Source;
            extra3.Source = i50.Source;
            i50.Source = extra2.Source;
            extra4.Source = i51.Source;
            i51.Source = extra3.Source;
            extra1.Source = i52.Source;
            i52.Source = extra4.Source;
            extra2.Source = i53.Source;
            i53.Source = extra1.Source;
            extra3.Source = i54.Source;
            i54.Source = extra2.Source;
            extra4.Source = i55.Source;
            i55.Source = extra3.Source;
            i56.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backmusic.Stop();
                d++;
                wonmusic.Play();
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
           
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            extra1.Source = i64.Source;
            extra2.Source = i57.Source;
            i57.Source = extra1.Source;
            extra3.Source = i58.Source;
            i58.Source = extra2.Source;
            extra4.Source = i59.Source;
            i59.Source = extra3.Source;
            extra1.Source = i60.Source;
            i60.Source = extra4.Source;
            extra2.Source = i61.Source;
            i61.Source = extra1.Source;
            extra3.Source = i62.Source;
            i62.Source = extra2.Source;
            extra4.Source = i63.Source;
            i63.Source = extra3.Source;
            i64.Source = extra4.Source;

            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backmusic.Stop();
                wonmusic.Play();
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            extra1.Source = i1.Source;
            extra2.Source = i57.Source;
            i57.Source = extra1.Source;
            extra3.Source = i49.Source;
            i49.Source = extra2.Source;
            extra4.Source = i41.Source;
            i41.Source = extra3.Source;
            extra1.Source = i33.Source;
            i33.Source = extra4.Source;
            extra2.Source = i25.Source;
            i25.Source = extra1.Source;
            extra3.Source = i17.Source;
            i17.Source = extra2.Source;
            extra4.Source = i9.Source;
            i9.Source = extra3.Source;
            i1.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backmusic.Stop();
                wonmusic.Play();
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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





                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            extra1.Source = i2.Source;
            extra2.Source = i58.Source;
            i58.Source = extra1.Source;
            extra3.Source = i50.Source;
            i50.Source = extra2.Source;
            extra4.Source = i42.Source;
            i42.Source = extra3.Source;
            extra1.Source = i34.Source;
            i34.Source = extra4.Source;
            extra2.Source = i26.Source;
            i26.Source = extra1.Source;
            extra3.Source = i18.Source;
            i18.Source = extra2.Source;
            extra4.Source = i10.Source;
            i10.Source = extra3.Source;
            i2.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                backmusic.Stop();
                wonmusic.Play();
                timer.Pause();
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


                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
            
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            extra1.Source = i3.Source;
            extra2.Source = i59.Source;
            i59.Source = extra1.Source;
            extra3.Source = i51.Source;
            i51.Source = extra2.Source;
            extra4.Source = i43.Source;
            i43.Source = extra3.Source;
            extra1.Source = i35.Source;
            i35.Source = extra4.Source;
            extra2.Source = i27.Source;
            i27.Source = extra1.Source;
            extra3.Source = i19.Source;
            i19.Source = extra2.Source;
            extra4.Source = i11.Source;
            i11.Source = extra3.Source;
            i3.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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


                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }

           
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            extra1.Source = i4.Source;
            extra2.Source = i60.Source;
            i60.Source = extra1.Source;
            extra3.Source = i52.Source;
            i52.Source = extra2.Source;
            extra4.Source = i44.Source;
            i44.Source = extra3.Source;
            extra1.Source = i36.Source;
            i36.Source = extra4.Source;
            extra2.Source = i28.Source;
            i28.Source = extra1.Source;
            extra3.Source = i20.Source;
            i20.Source = extra2.Source;
            extra4.Source = i12.Source;
            i12.Source = extra3.Source;
            i4.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
           
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            extra1.Source = i5.Source;
            extra2.Source = i61.Source;
            i61.Source = extra1.Source;
            extra3.Source = i53.Source;
            i53.Source = extra2.Source;
            extra4.Source = i45.Source;
            i45.Source = extra3.Source;
            extra1.Source = i37.Source;
            i37.Source = extra4.Source;
            extra2.Source = i29.Source;
            i29.Source = extra1.Source;
            extra3.Source = i21.Source;
            i21.Source = extra2.Source;
            extra4.Source = i13.Source;
            i13.Source = extra3.Source;
            i5.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                d++;
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }

          
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            extra1.Source = i6.Source;
            extra2.Source = i62.Source;
            i62.Source = extra1.Source;
            extra3.Source = i54.Source;
            i54.Source = extra2.Source;
            extra4.Source = i46.Source;
            i46.Source = extra3.Source;
            extra1.Source = i38.Source;
            i38.Source = extra4.Source;
            extra2.Source = i30.Source;
            i30.Source = extra1.Source;
            extra3.Source = i22.Source;
            i22.Source = extra2.Source;
            extra4.Source = i14.Source;
            i14.Source = extra3.Source;
            i6.Source = extra4.Source;

            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

               if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
            }
        

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            
            extra1.Source = i7.Source;
            extra2.Source = i63.Source;
            i63.Source = extra1.Source;
            extra3.Source = i55.Source;
            i55.Source = extra2.Source;
            extra4.Source = i47.Source;
            i47.Source = extra3.Source;
            extra1.Source = i39.Source;
            i39.Source = extra4.Source;
            extra2.Source = i31.Source;
            i31.Source = extra1.Source;
            extra3.Source = i23.Source;
            i23.Source = extra2.Source;
            extra4.Source = i15.Source;
            i15.Source = extra3.Source;
            i7.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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
                
               if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
                }
            
        
        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            extra1.Source = i8.Source;
            extra2.Source = i64.Source;
            i64.Source = extra1.Source;
            extra3.Source = i56.Source;
            i56.Source = extra2.Source;
            extra4.Source = i48.Source;
            i48.Source = extra3.Source;
            extra1.Source = i40.Source;
            i40.Source = extra4.Source;
            extra2.Source = i32.Source;
            i32.Source = extra1.Source;
            extra3.Source = i24.Source;
            i24.Source = extra2.Source;
            extra4.Source = i16.Source;
            i16.Source = extra3.Source;
            i8.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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
                
                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
                }
            
           
        

        private void go_Click(object sender, RoutedEventArgs e)
        {
           // if (i20.Source == final1.Source & i21.Source == final1.Source & i27.Source == final1.Source & i28.Source == final9.Source & i29.Source == final9.Source & i30.Source == final1.Source & i35.Source == final1.Source & i36.Source == final9.Source & i37.Source == final9.Source & i38.Source == final1.Source & i44.Source == final1.Source & i45.Source == final1.Source)          {
           //     welldone.Begin();
           // }
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11= (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13=(i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1 )
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause(); backmusic.Stop();
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
                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
                    }
                
                
            

           
        

        private void PLAY_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            extra1.Source = i1.Source;
            extra2.Source = i8.Source;
            i8.Source = extra1.Source;
            extra3.Source = i7.Source;
            i7.Source = extra2.Source;
            extra4.Source = i6.Source;
            i6.Source = extra3.Source;
            extra1.Source = i5.Source;
            i5.Source = extra4.Source;
            extra2.Source = i4.Source;
            i4.Source = extra1.Source;
            extra3.Source = i3.Source;
            i3.Source = extra2.Source;
            extra4.Source = i2.Source;
            i2.Source = extra3.Source;
            i1.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }



        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            extra1.Source = i9.Source;
            extra2.Source = i16.Source;
            i16.Source = extra1.Source;
            extra3.Source = i15.Source;
            i15.Source = extra2.Source;
            extra4.Source = i14.Source;
            i14.Source = extra3.Source;
            extra1.Source = i13.Source;
            i13.Source = extra4.Source;
            extra2.Source = i12.Source;
            i12.Source = extra1.Source;
            extra3.Source = i11.Source;
            i11.Source = extra2.Source;
            extra4.Source = i10.Source;
            i10.Source = extra3.Source;
            i9.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            extra1.Source = i17.Source;
            extra2.Source = i24.Source;
            i24.Source = extra1.Source;
            extra3.Source = i23.Source;
            i23.Source = extra2.Source;
            extra4.Source = i22.Source;
            i22.Source = extra3.Source;
            extra1.Source = i21.Source;
            i21.Source = extra4.Source;
            extra2.Source = i20.Source;
            i20.Source = extra1.Source;
            extra3.Source = i19.Source;
            i19.Source = extra2.Source;
            extra4.Source = i18.Source;
            i18.Source = extra3.Source;
            i17.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            extra1.Source = i25.Source;
            extra2.Source = i32.Source;
            i32.Source = extra1.Source;
            extra3.Source = i31.Source;
            i31.Source = extra2.Source;
            extra4.Source = i30.Source;
            i30.Source = extra3.Source;
            extra1.Source = i29.Source;
            i29.Source = extra4.Source;
            extra2.Source = i28.Source;
            i28.Source = extra1.Source;
            extra3.Source = i27.Source;
            i27.Source = extra2.Source;
            extra4.Source = i26.Source;
            i26.Source = extra3.Source;
            i25.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            extra1.Source = i33.Source;
            extra2.Source = i40.Source;
            i40.Source = extra1.Source;
            extra3.Source = i39.Source;
            i39.Source = extra2.Source;
            extra4.Source = i38.Source;
            i38.Source = extra3.Source;
            extra1.Source = i37.Source;
            i37.Source = extra4.Source;
            extra2.Source = i36.Source;
            i36.Source = extra1.Source;
            extra3.Source = i35.Source;
            i35.Source = extra2.Source;
            extra4.Source = i34.Source;
            i34.Source = extra3.Source;
            i33.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {



            extra1.Source = i41.Source;
            extra2.Source = i48.Source;
            i48.Source = extra1.Source;
            extra3.Source = i47.Source;
            i47.Source = extra2.Source;
            extra4.Source = i46.Source;
            i46.Source = extra3.Source;
            extra1.Source = i45.Source;
            i45.Source = extra4.Source;
            extra2.Source = i44.Source;
            i44.Source = extra1.Source;
            extra3.Source = i43.Source;
            i43.Source = extra2.Source;
            extra4.Source = i42.Source;
            i42.Source = extra3.Source;
            i41.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            extra1.Source = i49.Source;
            extra2.Source = i56.Source;
            i56.Source = extra1.Source;
            extra3.Source = i55.Source;
            i55.Source = extra2.Source;
            extra4.Source = i54.Source;
            i54.Source = extra3.Source;
            extra1.Source = i53.Source;
            i53.Source = extra4.Source;
            extra2.Source = i52.Source;
            i52.Source = extra1.Source;
            extra3.Source = i51.Source;
            i51.Source = extra2.Source;
            extra4.Source = i50.Source;
            i50.Source = extra3.Source;
            i49.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            extra1.Source = i57.Source;
            extra2.Source = i64.Source;
            i64.Source = extra1.Source;
            extra3.Source = i63.Source;
            i63.Source = extra2.Source;
            extra4.Source = i62.Source;
            i62.Source = extra3.Source;
            extra1.Source = i61.Source;
            i61.Source = extra4.Source;
            extra2.Source = i60.Source;
            i60.Source = extra1.Source;
            extra3.Source = i59.Source;
            i59.Source = extra2.Source;
            extra4.Source = i58.Source;
            i58.Source = extra3.Source;
            i57.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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
                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_32(object sender, RoutedEventArgs e)
        {
            extra1.Source = i57.Source;
            extra2.Source = i1.Source;
            i1.Source = extra1.Source;
            extra3.Source = i9.Source;
            i9.Source = extra2.Source;
            extra4.Source = i17.Source;
            i17.Source = extra3.Source;
            extra1.Source = i25.Source;
            i25.Source = extra4.Source;
            extra2.Source = i33.Source;
            i33.Source = extra1.Source;
            extra3.Source = i41.Source;
            i41.Source = extra2.Source;
            extra4.Source = i49.Source;
            i49.Source = extra3.Source;
            i57.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                backmusic.Stop();
                wonmusic.Play();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_33(object sender, RoutedEventArgs e)
        {
            extra1.Source = i58.Source;
            extra2.Source = i2.Source;
            i2.Source = extra1.Source;
            extra3.Source = i10.Source;
            i10.Source = extra2.Source;
            extra4.Source = i18.Source;
            i18.Source = extra3.Source;
            extra1.Source = i26.Source;
            i26.Source = extra4.Source;
            extra2.Source = i34.Source;
            i34.Source = extra1.Source;
            extra3.Source = i42.Source;
            i42.Source = extra2.Source;
            extra4.Source = i50.Source;
            i50.Source = extra3.Source;
            i58.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_34(object sender, RoutedEventArgs e)
        {
            extra1.Source = i59.Source;
            extra2.Source = i3.Source;
            i3.Source = extra1.Source;
            extra3.Source = i11.Source;
            i11.Source = extra2.Source;
            extra4.Source = i19.Source;
            i19.Source = extra3.Source;
            extra1.Source = i27.Source;
            i27.Source = extra4.Source;
            extra2.Source = i35.Source;
            i35.Source = extra1.Source;
            extra3.Source = i43.Source;
            i43.Source = extra2.Source;
            extra4.Source = i51.Source;
            i51.Source = extra3.Source;
            i59.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_35(object sender, RoutedEventArgs e)
        {
            extra1.Source = i60.Source;
            extra2.Source = i4.Source;
            i4.Source = extra1.Source;
            extra3.Source = i12.Source;
            i12.Source = extra2.Source;
            extra4.Source = i20.Source;
            i20.Source = extra3.Source;
            extra1.Source = i28.Source;
            i28.Source = extra4.Source;
            extra2.Source = i36.Source;
            i36.Source = extra1.Source;
            extra3.Source = i44.Source;
            i44.Source = extra2.Source;
            extra4.Source = i52.Source;
            i52.Source = extra3.Source;
            i60.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause(); backmusic.Stop();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_36(object sender, RoutedEventArgs e)
        {
            extra1.Source = i61.Source;
            extra2.Source = i5.Source;
            i5.Source = extra1.Source;
            extra3.Source = i13.Source;
            i13.Source = extra2.Source;
            extra4.Source = i21.Source;
            i21.Source = extra3.Source;
            extra1.Source = i29.Source;
            i29.Source = extra4.Source;
            extra2.Source = i37.Source;
            i37.Source = extra1.Source;
            extra3.Source = i45.Source;
            i45.Source = extra2.Source;
            extra4.Source = i53.Source;
            i53.Source = extra3.Source;
            i61.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_37(object sender, RoutedEventArgs e)
        {
            extra1.Source = i62.Source;
            extra2.Source = i6.Source;
            i6.Source = extra1.Source;
            extra3.Source = i14.Source;
            i14.Source = extra2.Source;
            extra4.Source = i22.Source;
            i22.Source = extra3.Source;
            extra1.Source = i30.Source;
            i30.Source = extra4.Source;
            extra2.Source = i38.Source;
            i38.Source = extra1.Source;
            extra3.Source = i46.Source;
            i46.Source = extra2.Source;
            extra4.Source = i54.Source;
            i54.Source = extra3.Source;
            i62.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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
                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void Button_Click_38(object sender, RoutedEventArgs e)
        {
            extra1.Source = i63.Source;
            extra2.Source = i7.Source;
            i7.Source = extra1.Source;
            extra3.Source = i15.Source;
            i15.Source = extra2.Source;
            extra4.Source = i23.Source;
            i23.Source = extra3.Source;
            extra1.Source = i31.Source;
            i31.Source = extra4.Source;
            extra2.Source = i39.Source;
            i39.Source = extra1.Source;
            extra3.Source = i47.Source;
            i47.Source = extra2.Source;
            extra4.Source = i55.Source;
            i55.Source = extra3.Source;
            i63.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
                d++;
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void Button_Click_39(object sender, RoutedEventArgs e)
        {
            extra1.Source = i64.Source;
            extra2.Source = i8.Source;
            i8.Source = extra1.Source;
            extra3.Source = i16.Source;
            i16.Source = extra2.Source;
            extra4.Source = i24.Source;
            i24.Source = extra3.Source;
            extra1.Source = i32.Source;
            i32.Source = extra4.Source;
            extra2.Source = i40.Source;
            i40.Source = extra1.Source;
            extra3.Source = i48.Source;
            i48.Source = extra2.Source;
            extra4.Source = i56.Source;
            i56.Source = extra3.Source;
            i64.Source = extra4.Source;
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }

            }
        }

        private void share_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            DataTransferManager.ShowShareUI(); 
        }

        private void HyperlinkButton_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BlankPage1));
        }

        private void Button_Click_40(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

       
        private void Button_Click_42(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_41(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {

        }

        private void Button_Click_43(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_44(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_45(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var uri1 = (final1.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri2 = (final9.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri3 = (i20.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri4 = (i21.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri5 = (i27.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri6 = (i28.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri7 = (i29.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri8 = (i30.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri9 = (i35.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri10 = (i36.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri11 = (i37.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri12 = (i38.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri13 = (i44.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            var uri14 = (i45.Source as Windows.UI.Xaml.Media.Imaging.BitmapImage).UriSource;
            if (uri6 == uri2 & uri7 == uri2 & uri10 == uri2 & uri11 == uri2 & uri3 == uri1 & uri4 == uri1 & uri5 == uri1 & uri8 == uri1 & uri9 == uri1 & uri12 == uri1 & uri13 == uri1 & uri14 == uri1)
            {
                d++;
                backbutton.Visibility = Visibility.Collapsed;
                backimage.Visibility = Visibility.Collapsed;
                welldone.Begin();
                timer.Pause(); backmusic.Stop();
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

                if (rectangle4.Width >= 763.889)
                {
                    tt.Text = "Awesome!!!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;

                    res3.Visibility = Visibility.Visible;


                }
                else if (rectangle4.Width < 763.889 && rectangle4.Width >= 486.111)
                {
                    tt.Text = "Nice Try!";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Visible;
                    res3.Visibility = Visibility.Collapsed;



                }
                else
                {
                    tt.Text = "Could be better";
                    stars.Begin();
                    res1.Visibility = Visibility.Visible;
                    res2.Visibility = Visibility.Collapsed;
                    res3.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void hyperlinkButton_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
       

    }

}
