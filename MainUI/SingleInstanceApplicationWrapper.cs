using System;

namespace MainUI
{
    class SingleInstanceApplicationWrapper : Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {
        public SingleInstanceApplicationWrapper()
        {
            this.IsSingleInstance = true;   //启用单实例模式
        }

        //创建WPF应用程序类。
        private UkuleleApp app;
        protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e)
        {
            app = new UkuleleApp();
            app.StartupUri = new Uri("MainWindow.xaml", UriKind.Relative);
            app.Run();
            return false;
        }
    }
}
