using System;
using System.Collections.Generic;

namespace OnlineOrdering
{
    public class Order
    {
        private List<Product> _products = new List<Product>();
        private Customer _customer;

        public Order(Customer customer)
        {
            _customer = customer;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double CalculateTotalCost()
        {
            double totalCost = 0;
            foreach (Product product in _products)
            {
                totalCost += product.GetTotal();
            }
            totalCost += _customer.IsInUsa() ? 5 : 35;
            return totalCost;
        }

        public string GetPackingLabel()
        {
            string packingLabel = "Packing Label - \n ";
            foreach (Product product in _products)
            {
                packingLabel += product.PackingLabel();
            }
            return packingLabel;
        }

        public string GetShippingLabel()
        {
            return $"Shipping Label - \n{_customer.ShippingLabel()}";
        }
    }
}