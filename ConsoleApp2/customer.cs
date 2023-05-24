namespace ConsoleApp2
{
    public class customer
    {
        private string customerType = "";
        private string itemName = "";
        private int qty = 0;
        private double price = 0;
        private double cost = 0;

        public customer(string customerName, string itemName, int qty, double price)
        {
            this.customerType = customerName;
            this.itemName = itemName;
            this.qty = qty;
            this.price = price;
        }

        public string CustomerName { get => customerType; set => customerType = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public int Qty { get => qty; set => qty = value; }
        public double Price { get => price; set => price = value; }
        public double Cost { get => cost; set => cost = value; }
        //ccc
        //cmm
        //public double Cost { get => cost; set => cost = value; }
        //câccâcc
        //ditme
        public void getCost()
        {
            double c = price;
            if (customerType.Contains("CN"))
                this.Cost = qty * c * 0.93;
            else if (customerType.Contains("CT"))
                this.Cost = qty * c * 0.96;
            else this.Cost = qty * c;
        }
    }
}