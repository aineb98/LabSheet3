using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    public class car
    {
        private string make;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }

        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { _model= value; }
        }

    }
}

