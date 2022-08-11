using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZ2TrackClient.Model
{
    internal class MainModel : INotifyPropertyChanged
    {
        public string? Username;
        public string? Password;

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
