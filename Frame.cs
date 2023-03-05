using System.Collections.Generic;
using System.Windows.Forms;

namespace ElectricityBill
{
    public partial class Frame : Form
    {
        int i = 0;
        List<Client> clients = new List<Client>();
        public Frame() => InitializeComponent();

        private void CLocation_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            RValuation.Text = GetValuation(CLocation.SelectedIndex) + "đ";
        }

        private void BtnCalc_Click(object sender, System.EventArgs e)
        {
            if (!InvaildInputs()) return;
            Client client = new Client(CName.Text, CLocation.SelectedIndex, int.Parse(COldNumber.Text), int.Parse(CNewNumber.Text));
            RConsume.Text = client.Consume.ToString();
            RMoney.Text = client.GetTotal(GetValuation(CLocation.SelectedIndex)).ToString();
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            if (!InvaildInputs()) return;
            Client client = new Client(CName.Text, CLocation.SelectedIndex, int.Parse(COldNumber.Text), int.Parse(CNewNumber.Text));
            // add to listview
            ListViewItem item = new ListViewItem((++i).ToString());
            item.SubItems.Add(client.Name);
            item.SubItems.Add(GetLocation(client.Location));
            item.SubItems.Add(GetValuation(client.Location) + "đ");
            item.SubItems.Add(client.OldNum.ToString());
            item.SubItems.Add(client.NewNum.ToString());
            item.SubItems.Add(client.Consume.ToString());
            item.SubItems.Add(client.GetTotal(GetValuation(client.Location)) + "đ");
            BillList.Items.Add(item);
            clients.Add(client);
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

            RValuation.Text = string.Empty;
            RConsume.Text = string.Empty;
            RMoney.Text = string.Empty;

            CLocation.SelectedIndex = 0;
        }

        private int GetValuation(int location)
        {
            int valuation = 0;
            switch (location)
            {
                case 0:
                    valuation = 1000;
                    break;
                case 1:
                    valuation = 1500;
                    break;
                case 2:
                    valuation = 2000;
                    break;
                case 3:
                    valuation = 2500;
                    break;
                case 4:
                    valuation = 3000;
                    break;
            }
            return valuation;
        }

        private string GetLocation(int location)
        {
            string locationName = string.Empty;
            switch (location)
            {
                case 0:
                    locationName = "Khu vực 1";
                    break;
                case 1:
                    locationName = "Khu vực 2";
                    break;
                case 2:
                    locationName = "Khu vực 3";
                    break;
                case 3:
                    locationName = "Khu vực 4";
                    break;
                case 4:
                    locationName = "Khu vực 5";
                    break;
            }
            return locationName;
        }
    }
}
