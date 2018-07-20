 namespace cejer.ViewModels
{
   public class MainViewModel
    {
        #region ViewModels
        public InicioViewModels Inicio
        {
            get;
            set;
        }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            this.Inicio = new InicioViewModels();
        }
        #endregion
}
}
