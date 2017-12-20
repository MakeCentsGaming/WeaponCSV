using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WeaponsCSV
{
   public partial class MainViewModel : clsBaseViewModel
   {
      /// <summary>
      /// 
      /// </summary>
      public MainViewModel()
      {

         Instance = this;

      }

      /// <summary>
      /// 
      /// </summary>
      public void Init()
      {

      }

      /// <summary>
      /// 
      /// </summary>
      public void DeInit()
      {

      }
   }
   /// <summary>
   /// 
   /// </summary>
   public class clsBaseViewModel : INotifyPropertyChanged
   {
      /// <summary>
      /// 
      /// </summary>
      public event PropertyChangedEventHandler PropertyChanged;
      /*******************************************************************************
      Function    : OnPropertyChanged()
      Description : 
      Parameters  : string propertyName - 
      Returns     : void
      --------------------------------------------------------------------------------
      History:
      2014/10/21 TPR Created
      *******************************************************************************/
      /// <summary>
      /// 
      /// </summary>
      /// <param name="propertyName"></param>
      protected void OnPropertyChanged(string propertyName)
      {
         if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
   }/* End Class */
   /*******************************************************************************
   Class        : ItemBase
   Description  : 
   --------------------------------------------------------------------------------
   History:
   2014/10/17 TPR Created
   *******************************************************************************/
   /// <summary>
   /// 
   /// </summary>
   [Serializable]
   public class ItemBase : INotifyPropertyChanged
   {
      /// <summary>
      /// 
      /// </summary>
      [field: NonSerialized]      
      public event PropertyChangedEventHandler PropertyChanged;
      /*******************************************************************************
      Function    : OnPropertyChanged()
      Description : 
      Parameters  : string propertyName - 
      Returns     : void
      --------------------------------------------------------------------------------
      History:
      2014/10/17 TPR Created
      *******************************************************************************/
      /// <summary>
      /// 
      /// </summary>
      /// <param name="propertyName"></param>
      protected void OnPropertyChanged(string propertyName)
      {
         if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
      }
   }/* End Class */

   /*******************************************************************************
   Class        : DelegateCommand
   Description  : 
   --------------------------------------------------------------------------------
   History:
   2014/10/15 TPR Created
   *******************************************************************************/
   [Serializable]
   class DelegateCommand : ICommand
   {
      private readonly Predicate<object> _canExecute;
      private readonly Action<object> _execute;
      private Action<object, RoutedPropertyChangedEventArgs<double>> colorchange;

      [field: NonSerialized]
      public event EventHandler CanExecuteChanged;

      /*******************************************************************************
      Constructor : DelegateCommand()
      Description : 
      Parameters  : Action<object> execute - 
      --------------------------------------------------------------------------------
      History:
      2014/10/15 TPR Created
      *******************************************************************************/
      public DelegateCommand(Action<object> execute) : this(execute, null)
      {
      }
      /*******************************************************************************
      Constructor : DelegateCommand()
      Description : 
      Parameters  : Action<object> execute - 
                  : Predicate<object> canExecute - 
      --------------------------------------------------------------------------------
      History:
      2014/10/15 TPR Created
      *******************************************************************************/
      public DelegateCommand(Action<object> execute, Predicate<object> canExecute)
      {
         _execute = execute;
         _canExecute = canExecute;
      }

      public DelegateCommand(Action<object, RoutedPropertyChangedEventArgs<double>> colorchange)
      {
         this.colorchange = colorchange;
      }

      /*******************************************************************************
Function    : CanExecute()
Description : 
Parameters  : object parameter - 
Returns     : bool
--------------------------------------------------------------------------------
History:
2014/10/15 TPR Created
*******************************************************************************/
      public bool CanExecute(object parameter)
      {
         if (_canExecute == null)
            return true;

         return _canExecute(parameter);
      }
      /*******************************************************************************
      Function    : Execute()
      Description : 
      Parameters  : object parameter - 
      Returns     : void
      --------------------------------------------------------------------------------
      History:
      2014/10/15 TPR Created
      *******************************************************************************/
      public void Execute(object parameter)
      {
         _execute(parameter);
      }
      /*******************************************************************************
      Function    : RaiseCanExecuteChanged()
      Description : 
      Parameters  : None
      Returns     : void
      --------------------------------------------------------------------------------
      History:
      2014/10/15 TPR Created
      *******************************************************************************/
      public void RaiseCanExecuteChanged()
      {
         if (CanExecuteChanged != null)
            CanExecuteChanged(this, EventArgs.Empty);
      }
   }/* End Class */
}
