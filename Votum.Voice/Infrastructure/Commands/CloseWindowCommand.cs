using System.Linq;
using System.Windows;
using Votum.Voice.Infrastructure.Commands.Base;

namespace Votum.Voice.Infrastructure.Commands
{
    public class CloseWindowCommand : Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object p)
        {
            var window = p as Window;

            if (window is null)
                window = Application.Current.Windows
                    .Cast<Window>()
                    .FirstOrDefault(x => x.IsFocused);

            if (window is null)
                window = Application.Current.Windows
                    .Cast<Window>()
                    .FirstOrDefault(x => x.IsActive);

            window?.Close();
        }
    }
}
