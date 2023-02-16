namespace ElectricityBill
{
    internal class Client
    {
        private readonly string name;
        private readonly string location;
        private readonly int oldNum;
        private readonly int newNum;
        private readonly int consume;

        public Client(string name, string location, int oldNum, int newNum)
        {
            this.name = name;
            this.location = location;
            this.oldNum = oldNum;
            this.newNum = newNum;
            consume = newNum - oldNum;
        }

        public string GetName() { return name; }
        public string GetLocation() { return location; }
        public int GetOldNum() { return oldNum; }
        public int GetNewNum() { return newNum; }
        public int GetConsume() { return consume; }

        public float GetQuotaFloat()
        {
            float quota;
            if (consume > 0 && consume <= 50) quota = 1.678f;
            else if (consume > 50 && consume <= 100) quota = 1.734f;
            else if (consume > 100 && consume <= 200) quota = 2.014f;
            else if (consume > 200 && consume <= 300) quota = 2.536f;
            else if (consume > 300 && consume <= 400) quota = 2.834f;
            else quota = 2.927f;
            return quota;
        }

        public int GetQuotaInt()
        {

            int quota;
            if (consume > 0 && consume <= 50) quota = 50;
            else if (consume > 50 && consume <= 100) quota = 100;
            else if (consume > 100 && consume <= 200) quota = 200;
            else if (consume > 200 && consume <= 300) quota = 300;
            else if (consume > 300 && consume <= 400) quota = 400;
            else quota = consume;
            return quota;
        }

        public float GetTotal()
        {
            float total = consume * GetQuotaFloat();
            return total;
        }
    }
}
