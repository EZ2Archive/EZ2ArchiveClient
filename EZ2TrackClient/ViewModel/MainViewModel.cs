using EZ2TrackClient.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace EZ2TrackClient.ViewModel
{
    internal class MainViewModel : INotifyPropertyChanged
    {
        private MainModel mainModel;

        public MainViewModel()
        {
            mainModel = new MainModel();
        }

        //public string? Dollar
        //{
        //    get
        //    {
        //        if (string.IsNullOrEmpty(mainModel.dollar))
        //        {
        //            Won = "0";
        //        }
        //        else
        //        {
        //            int num = -1;
        //            if (int.TryParse(mainModel.dollar, out num))
        //            {
        //                int result = num * 1160;
        //                Won = result.ToString();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Please insert number", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //                Dollar = "";
        //                Won = "0";
        //            }
        //        }
        //        return mainModel.dollar;
        //    }
        //    set
        //    {
        //        if (mainModel.dollar != value)
        //        {
        //            mainModel.dollar = value;
        //            OnPropertyChanged("Dollar");
        //        }
        //    }
        //}

        //public string? Won
        //{
        //    get
        //    {
        //        return mainModel.won;
        //    }
        //    set
        //    {
        //        mainModel.won = value;
        //        OnPropertyChanged("Won");
        //    }
        //}



        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged(string prop)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
