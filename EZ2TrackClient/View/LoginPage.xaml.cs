using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EZ2TrackClient.View
{
    /// <summary>
    /// LoginPage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class LoginPage : Page
    {
        static readonly HttpClient client = new HttpClient();
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "http://127.0.0.1:3000/users";

            string username = Username.Text;
            string password = Password.Password;

            LoginButton.IsEnabled = false;

            try
            {
                var response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string body = await response.Content.ReadAsStringAsync();
                Result? data = JsonConvert.DeserializeObject<Result>(body);

                if (data != null && data.status == true)
                {
                    NavigationService.Navigate(new Uri("View/MainPage.xaml", UriKind.Relative));
                }
                else
                {
                    MessageBox.Show("계정 정보가 올바르지 않습니다.", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception)
            {
                LoginButton.IsEnabled = true;
                MessageBox.Show("서버 연결 오류가 발생했습니다.", "오류", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        class Result
        {
            public bool status;
        }
    }
}
