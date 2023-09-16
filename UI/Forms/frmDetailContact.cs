using BLL.Services;
using System;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class frmDetailContact : Form
    {
        private readonly ContactService contactService;
        private readonly int ContactId;
        public frmDetailContact(int ContactId)
        {
            InitializeComponent();
            contactService = new ContactService();
            this.ContactId = ContactId;
        }

        private void frmDetailContact_Load(object sender, EventArgs e)
        {
            var contact = contactService.GetContactDetial(ContactId);

            if (!contact.IsSuccess)
            {
                MessageBox.Show(contact.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lblId.Text = contact.Data.Id.ToString();
            lblName.Text = contact.Data.Name;
            lblLastName.Text = contact.Data.LastName;
            lblCompany.Text = contact.Data.Company;
            lblPhoneNumber.Text = contact.Data.PhoneNumber;
            lblCreateAt.Text = contact.Data.CreateAt.ToString();
            lblDescription.Text = contact.Data.Description;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
