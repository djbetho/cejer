namespace cejer.ViewModels
{
    using Android.App;
    using System;
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Views;
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

            Device.OpenUri(new Uri("https://www.ventas.cejer.cl"));

        }

        public ICommand PasajesCommand
        {
            get
            {
                return new RelayCommand(Pasajes);
            }

        }
        private async void Pasajes()
        {
            MainViewModel.GetInstance().Busqueda = new BusquedaViewModels();
            await Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(new BusquedaPage());
             
        }
        #endregion
    }


}
