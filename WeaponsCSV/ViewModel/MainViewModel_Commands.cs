using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WeaponsCSV
{
   public partial class MainViewModel
   {
      private ICommand clearAll;
      /// <summary>
      /// 
      /// </summary>
      public ICommand ClearAll
      {
         get { return clearAll = new DelegateCommand(clearall); }
      }

      private ICommand add;
      /// <summary>
      /// 
      /// </summary>
      public ICommand Add
      {
         get { return add = new DelegateCommand(aDD); }
      }
      /* Exmaple
      private ICommand pClose;
      /// <summary>
      /// 
      /// </summary>
      public ICommand CmdClose
      {
         get { return pClose = new DelegateCommand(fnClose); }
      }
      */
   }
}
