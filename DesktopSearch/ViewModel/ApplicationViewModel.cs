using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopSearch.Model;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.ComponentModel;

namespace DesktopSearch.ViewModel
{
    class ApplicationViewModel
    {
        private SuggestResult suggestItem;

        ObservableCollection<SuggestResult> suggestItems { get; set; }

        public SuggestResult SuggestItem
        {
            get { return suggestItem; }
            set
            {
                suggestItem = value;
                OnPropertyChanged("SelectedPhone");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
