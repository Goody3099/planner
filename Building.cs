using System;

namespace Planner
{
    public class Building
    {
        private string _designer = "Matt";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        public int Stories;
        public double Width;
        public double Depth;
        public double Volume
        {
            get
            {
                return (Width * Depth * (3 * Stories));
            }
        }
        public Building(string address)
        {
            _address = address;
        }
        public void dateTime()
        {
            _dateConstructed = DateTime.Now;
        }
        public void Purchase(string purchaser)
        {
            _owner = purchaser;
        }
        public string A()
        {
            return _address;
        }
        public string O()
        {
            return _owner;
        }
        public DateTime T()
        {
            return _dateConstructed;
        }
        public string D()
        {
            return _designer;
        }
    }
}