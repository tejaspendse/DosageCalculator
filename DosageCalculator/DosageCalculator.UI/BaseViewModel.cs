using System.ComponentModel;

namespace DosageCalculator.UI
{
   public class BaseViewModel : INotifyPropertyChanged
   {
      public event PropertyChangedEventHandler PropertyChanged;

      protected void NotifyPropertyChanged(params string[] names)
      {
         var handler = PropertyChanged;
         if (handler != null)
         {
            foreach (var p in names)
            {
               handler(this, new PropertyChangedEventArgs(p));
            }
         }
      }
   }
}
