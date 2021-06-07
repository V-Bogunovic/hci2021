using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hci2021.Models
{
    [Serializable]
    class Event
    {
        private Guid _GUID;
        private string _label;
        private string _name;
        private string _description;
        private Guid _type_id;
        private string _attendance;
        private string _icon;
        private bool _humanitarian;
        private double _price;
        private string _country;
        private string _city;
        private ObservableCollection<DateTime> _dates;


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

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
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

        public Guid Type_id
        {
            get
            {
                return _type_id;
            }
            set
            {
                _type_id = value;
            }
        }

        public string Attendance
        {
            get
            {
                return _attendance;
            }
            set
            {
                _attendance = value;
            }
        }

        public string Icon
        {
            get
            {
                return _icon;
            }
            set
            {
                _icon = value;
            }
        }

        public bool Humanitarian
        {
            get
            {
                return _humanitarian;
            }
            set
            {
                _humanitarian = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                _country = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        public ObservableCollection<DateTime> Dates
        {
            get
            {
                return _dates;
            }
            set
            {
                _dates = value;
            }
        }

    }

    
}
