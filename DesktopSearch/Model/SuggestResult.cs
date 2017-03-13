using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace DesktopSearch.Model
{
    public class SuggestResult : INotifyPropertyChanged
    {
        private string content;
        private Command command;

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
