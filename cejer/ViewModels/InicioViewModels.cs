



namespace cejer.ViewModels
{
    using Android.App;

    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class InicioViewModels
    {
        #region Command

         public ICommand ComprarCommand
        {
            get
            {
                return new RelayCommand(Comprar);
            }
            
        }
        private async void Comprar()
        {
           
            await Xamarin.Forms.Application.Current.MainPage.DisplayAlert("Error",
                "Text",
                "Accept");
            return;
        }

            public ICommand Pasajes
        { 
            get; 
             
        }
        #endregion
    }

  
}
