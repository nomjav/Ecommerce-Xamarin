using Ecommerce.SharedViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ecommerce.ViewModels
{
	public class RatingBarViewModel : INotifyPropertyChanged
	{
        public ICommand clickCommand { get; set; }
        public RatingBarViewModel()
        {
            clickCommand = new Command(onClicked); // this will execute on the click of Click me button.
        }

        void onClicked(object obj)
        {
            RatingBar b = (RatingBar)obj;
            App.Current.MainPage.DisplayAlert("Selected Value is", b.SelectedStarValue.ToString(), "OK");
        }


        private string _selectedStar;
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public string SelectedStar
        {
            get { return _selectedStar; }
            set { _selectedStar = value; NotifyPropertyChanged(); }
        }
    }
}
