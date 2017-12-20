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

      private ICommand copy;
      /// <summary>
      /// 
      /// </summary>
      public ICommand Copy
      {
         get { return copy = new DelegateCommand(cOpy); }

      }

     
      private ICommand delete;
      /// <summary>
      /// 
      /// </summary>
      public ICommand Delete
      {
         get { return delete = new DelegateCommand(dElete); }
      }

      private ICommand comment;
      /// <summary>
      /// 
      /// </summary>
      public ICommand Comment
      {
         get { return comment = new DelegateCommand(cOmment); }
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
