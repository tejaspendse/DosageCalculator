using DosageCalculator.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace DosageCalculator
{
   /// <summary>
   /// Interaction logic for App.xaml
   /// </summary>
   public partial class App : Application
   {
      private void Application_Startup(object sender, StartupEventArgs e)
      {
         AppDomain.CurrentDomain.UnhandledException += OnDispatcherUnhandledExceptionCaught;

         

         DispatcherUnhandledException += OnUnhandledExceptionCaught;

         var mainVm = new MainViewModel();
         var mainWindow = new MainWindow
         {
            DataContext = mainVm
         };
         mainWindow.Show();
      }

      private void OnDispatcherUnhandledExceptionCaught(object sender, UnhandledExceptionEventArgs e)
      {
         var exception = e.ExceptionObject as Exception;
         {
            MessageBox.Show(
               $"{exception.Message}",
               "Error!",
               MessageBoxButton.OK,
               MessageBoxImage.Warning);
         }
      }

      private void OnUnhandledExceptionCaught(object sender, DispatcherUnhandledExceptionEventArgs e)
      {
         if (e.Exception is NotImplementedException notImplemented)
         {
            MessageBox.Show(
               $"{notImplemented.Message}",
               "Error!",
               MessageBoxButton.OK,
               MessageBoxImage.Warning);

            e.Handled = true;
         }
      }

      private void Application_Exit(object sender, ExitEventArgs e)
      {

      }
   }
}
