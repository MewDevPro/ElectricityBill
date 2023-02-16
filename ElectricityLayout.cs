using System.Windows.Forms;

namespace ElectricityBill
{
    public partial class ElectricityLayout : Form
    {
        int i = 0;
        Client[] clients = new Client[short.MaxValue];
        public ElectricityLayout() => InitializeComponent();

        private void BtnCalc_Click(object sender, System.EventArgs e)
        {
            if (!InvaildInputs()) return;
            Client client = new Client(CName.Text, CLocation.Text, int.Parse(COldNumber.Text), int.Parse(CNewNumber.Text));
            RQuota.Text = client.GetQuotaInt().ToString();
            RConsume.Text = client.GetConsume().ToString();
            RMoney.Text = client.GetTotal().ToString();
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            if (!InvaildInputs()) return;
            Client client = new Client(CName.Text, CLocation.Text, int.Parse(COldNumber.Text), int.Parse(CNewNumber.Text));
            // add to listview
            ListViewItem item = new ListViewItem((i + 1).ToString());
            item.SubItems.Add(client.GetName());
            item.SubItems.Add(client.GetLocation());
            item.SubItems.Add(client.GetQuotaInt().ToString() + " | " + client.GetQuotaFloat().ToString());
            item.SubItems.Add(client.GetOldNum().ToString());
            item.SubItems.Add(client.GetNewNum().ToString());
            item.SubItems.Add(client.GetConsume().ToString());
            item.SubItems.Add(client.GetTotal().ToString());
            BillList.Items.Add(item);
            clients[i++] = client;
            ClearInput();
        }

        private void Copyright_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => System.Diagnostics.Process.Start("https://fb.com/MeewMeewDev");

        private bool InvaildInputs()
        {
            if (
                CName.Text == string.Empty
                || CLocation.Text == string.Empty
                || COldNumber.Text == string.Empty
                || CNewNumber.Text == string.Empty
                )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (int.Parse(COldNumber.Text) >= int.Parse(CNewNumber.Text))
            {
                MessageBox.Show("Số điện cũ không thể lớn hơn hoặc bằng số điện mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        private void ClearInput()
        {
            CName.Text = string.Empty;
            COldNumber.Text = string.Empty;
            CNewNumber.Text = string.Empty;

            RQuota.Text = string.Empty;
            RConsume.Text = string.Empty;
            RMoney.Text = string.Empty;

            CLocation.SelectedIndex = 0;
        }
    }
}
