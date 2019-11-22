using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DosageCalculator.UI
{
   public class MainViewModel : BaseViewModel
   {
      private string m_label = "Waiting ...";

      public MainViewModel()
      {
         var timer = new Timer(5000)
         {
            Enabled = true,
            AutoReset = false
         };
         timer.Elapsed += (s, e) => throw new NotImplementedException();
         timer.Start();
      }

      public string Label
      {
         get => m_label;
         set
         {
            m_label = value;
            NotifyPropertyChanged(nameof(Label));
         }
      }
   }
}
