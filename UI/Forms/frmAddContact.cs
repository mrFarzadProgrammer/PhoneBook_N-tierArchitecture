using BLL.Dto;
using BLL.Services;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class frmAddContact : Form
    {
        private readonly ContactService contactService;
        public frmAddContact()
        {
            InitializeComponent();
            contactService = new ContactService();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            AddNewContactDto newContaxt = new AddNewContactDto()
            {
                Name = txtName.Text,
                LastName = txtLastName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Company = txtCompany.Text,
                Description = rtxtDescription.Text,
            };
            var result = contactService.AddNewContact(newContaxt);
            if (result.IsSuccess)
            {
                MessageBox.Show(result.message, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
