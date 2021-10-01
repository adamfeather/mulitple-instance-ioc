using System;
using System.Linq;
using MultipleInstanceExample.Domain;
using System.Windows;
using SimpleInjector;

namespace MultipleInstanceExample
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var container = new Container();

            RegisterDependencies(container);

            StartApplication(container);
        }

        private static void StartApplication(Container container)
        {
            var mainWindow = container.GetInstance<MainWindow>();

            Current.MainWindow = mainWindow;

            mainWindow.Show();
        }

        private static void RegisterDependencies(Container container)
        {
            container.Register<MainWindow>();

            container.Register<MainWindowViewModel>();

            RegisterThings(container);
        }

        private static void RegisterThings(Container container)
        {
            var thingInterface = typeof(IThing);

            var things = thingInterface
                .Assembly
                .ExportedTypes
                .Where(t => thingInterface.IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)
                .Select(Activator.CreateInstance)
                .Cast<IThing>()
                .ToList();

            container.Collection.Register<IThing>(things);
        }
    }
}
