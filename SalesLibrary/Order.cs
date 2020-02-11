using System;
using System.Collections.Generic;
using System.Text;

namespace TurneryAndAccess {
    public class Order {
        public int Id { get; private set; }
        public double Amount { get; set; }
        public Customer Customer { get; set; }
        private static int LastId = 0;

        public Order() {
            this.Id = LastId += 7;
        }
        

        public void SetCustomer(Customer customer) {

        }
    }
}
