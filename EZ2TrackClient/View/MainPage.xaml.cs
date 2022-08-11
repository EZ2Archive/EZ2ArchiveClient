using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media.Imaging;

namespace EZ2TrackClient.View
{
    /// <summary>
    /// MainPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            CapturedImage.Source = new BitmapImage(new Uri(@"\tmp\test.png", UriKind.Relative));
        }

        private void Page_Unloaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("커맨드 입력");
        }
    }
}
