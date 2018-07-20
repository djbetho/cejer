 namespace cejer.Infrastructure
{
    using ViewModels;
    class InstaceLocator
    {
        #region Properties
        public  MainViewModel Main
        {
            get;
            set;
        }
        #endregion

        #region Contructors
        public InstaceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
