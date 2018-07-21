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
        public BusquedaViewModels Busqueda
        {
            get; set;
        }

        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            this.Inicio = new InicioViewModels();
        }
        #endregion

        #region

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
            if (instance == null)
            {
                return new MainViewModel();
            }
            return instance;
        }
        
        #endregion

        #endregion
    }
}
