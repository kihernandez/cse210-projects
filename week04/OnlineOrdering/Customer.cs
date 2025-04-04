using System;

namespace OnlineOrdering
{
    public class Customer
    {
        private string _name;
        private Address _address;

        public Customer(string name, Address adress)
        {
            _name = name;
            _address = adress;
        }

        public bool IsInUsa ()
        {
            return _address.UsaOrNot();
        }

        public string ShippingLabel()
        {
            return $"{_name} {_address.AdressInformation()}";
        }
    }
}