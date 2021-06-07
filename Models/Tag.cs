using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hci2021.Models
{
    class Tag
    {
        private Guid _GUID;
        private string _label;
        private string _colour;
        private string _description;

        public Guid GUID
        {
            get
            {
                return _GUID;
            }
        }

        public string Label
        {
            get
            {
                return _label;
            }
            set
            {
                _label = value;
            }
        }

        public string Colour
        {
            get
            {
                return _colour;
            }
            set
            {
                _colour = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
    }
}
