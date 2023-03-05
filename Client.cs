namespace ElectricityBill
{
    internal class Client
    {

        public string Name { get; set; }
        public int Location { get; set; }
        public int OldNum { get; set; }
        public int NewNum { get; set; }
        public int Consume { get; set; }

        public Client(string name, int location, int oldNum, int newNum)
        {
            Name = name;
            Location = location;
            OldNum = oldNum;
            NewNum = newNum;
            Consume = newNum - oldNum;
        }

        public float GetTotal(int valuation)
        {
            float total = Consume * valuation;
            return total;
        }
    }
}
