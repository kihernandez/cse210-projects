using System;


namespace OnlineOrdering
{
    public class Product
    {
        private string _productname;
        private string _productId;
        private double _pricePerUnit;
        private int _quantity;


        public Product(string productName, string productId, double pricePerUnit, int quantity)
        {
            _productname = productName;
            _productId = productId;
            _pricePerUnit = pricePerUnit;
            _quantity = quantity;
        }

        public double GetTotal()
        {
            return _pricePerUnit * _quantity;
        }

        public string PackingLabel()
        {
            return $"Product Name: {_productname} Package ID: {_productId}\n ";
        }
    }
}
