using System;
using System.Windows.Forms;

namespace TaxOffice
{
    public partial class Form1
    {
	private void registrationButton_Click(object sender, EventArgs e)
        {
            var fullName = startInput_name.Text;
            var password = startInput_password.Text;
            if (fullName == "���" || password == "������")
            {
                MessageBox.Show("���� ��� � ������ ������ ���� ���������");
                return;
            }
        }

	private void authorizationButton_Click(object sender, EventArgs e)
        {
		var fullName = startInput_name.Text;
		var password = startInput_password.Text;
        if (fullName == "���" || password == "������")
        {
            MessageBox.Show("���� ��� � ������ ������ ���� ���������");
            return;
        }
	}
    }
}