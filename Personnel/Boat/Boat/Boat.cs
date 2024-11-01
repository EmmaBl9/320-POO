using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    public class Boat
    {
        private int _year;
        private int _tonnage;
        private string _country;
        private List<Container> _containers;

        public void load(Container container)
        {
            _containers.Add(container);
        }

        public void unload(int id)
        {
            _containers.RemoveAt(id);
        }

    }
}
