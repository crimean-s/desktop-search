using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopSearch.Model
{
    abstract class Command
    {
        private string name;
        public string Name { get; set; }

        public abstract void Execute();
    }

    class Map : Command
    {
        private string locality;
        public string Locality { get; set; }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }


    class Weather : Command
    {
        private string locality;
        public string Locality { get; set; }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }


}
