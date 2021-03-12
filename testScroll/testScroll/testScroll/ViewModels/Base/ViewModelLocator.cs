using Autofac;
using testScroll.Services.Navigation;
using System;

namespace testScroll.ViewModels.Base
{
    public class ViewModelLocator
    {
        private static IContainer _container;

        public ViewModelLocator()
        {
            //var _toastService = DependencyService.Get<IToastService>();
            var builder = new ContainerBuilder();

            // ViewModels
            builder.RegisterType<CuestionarioViewModel>();

            // Services    
            // Navigation
            builder.RegisterType<NavigationService>().As<INavigationService>().SingleInstance();

            if (_container != null)
            {
                _container.Dispose();
            }

            _container = builder.Build();
        }
        public CuestionarioViewModel CuestionarioViewModel
        {
            get {return _container.Resolve<CuestionarioViewModel>();}
        }
    }
}