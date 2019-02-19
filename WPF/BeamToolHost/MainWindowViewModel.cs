using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeamToolHost
{
    public class MainWindowViewModel : ViewModelBase
    {

        private string showToolBarButtonText;
        private bool showToolBar;
        private DelegateCommand showToolBarCommand;

        public MainWindowViewModel()
        {
            ShowToolBarCommand = new DelegateCommand(ShowToolBarCommandCanExectute, ShowToolBarCommandExectute);
            ShowToolBarButtonText = "Show";
        }

        public DelegateCommand ShowToolBarCommand
        {
            get
            {
                return showToolBarCommand;
            }
            set
            {
                showToolBarCommand = value;
                RaisePropertyChanged();
            }
        }

        private bool ShowToolBarCommandCanExectute(object parameter)
        {
            return true;
        }

        private void ShowToolBarCommandExectute(object parameter)
        {
            ShowToolBar = !ShowToolBar;
            ShowToolBarButtonText = ShowToolBar ? "Hide" : "Show";
        }


        public bool ShowToolBar
        {
            get { return showToolBar; }
            set
            {
                showToolBar = value;
                RaisePropertyChanged();
            }
        }


        public string ShowToolBarButtonText
        {
            get { return showToolBarButtonText; }
            set
            {
                showToolBarButtonText = value;
                RaisePropertyChanged();
            }
        }

    }
}
