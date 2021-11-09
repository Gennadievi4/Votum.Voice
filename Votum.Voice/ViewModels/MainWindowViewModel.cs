using System.Windows.Input;
using Votum.Voice.Infrastructure.Commands;
using Votum.Voice.ViewModels.Base;

namespace Votum.Voice.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {
        #region Properties
        public string Title => "V-Voice";

        public ICommand CloseApp => new CloseWindowCommand();
        #endregion
    }
}
