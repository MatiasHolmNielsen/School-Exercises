using PersonServiceClientDesktop.BusinesslogicLayer;
using PersonServiceClients.ModelLayer;
using System.Windows.Forms;

namespace PersonServiceClientDesktop.GuiLayer
{
    public partial class Form1 : Form
    {
        private readonly PersonLogic _personLogic;
        public Form1()
        {
            InitializeComponent();
            _personLogic = new PersonLogic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Optional: Add any code you want here when the form loads
        }

        private async void buttonGetPersons_Click(object sender, EventArgs e)
        {
            string processText;
            List<Person>? fetchedPersons = await _personLogic.GetAllPersons();

            if (fetchedPersons != null)
            {
                if (fetchedPersons.Count >= 1)
                {
                    processText = "Ok";
                }
                else
                {
                    processText = "No persons found";
                }
            }
            else
            {
                processText = "Failure: An error occurred";
            }

            labelProcessText.Text = processText;
            listBoxPersons.DataSource = fetchedPersons;
        }

        private async void buttonSavePerson_Click(object sender, EventArgs e)
        {
            string messageText;

            string inFirstName = textBoxFirstname.Text;
            string inLastName = textBoxLastname.Text;
            string inPhone = textBoxMobilePhone.Text;

            if (InputIsOk(inFirstName, inLastName, inPhone))
            {
                int insertedId = await _personLogic.SavePerson(inFirstName, inLastName, inPhone);
                messageText = (insertedId > 0)
                    ? $"Person saved with ID {insertedId}"
                    : "Failure: An error occurred!";
            }
            else
            {
                messageText = "Please input valid information.";
            }

            labelProcessSave.Text = messageText;
        }

        private bool InputIsOk(string fName, string lName, string phoneNo)
        {
            return !string.IsNullOrWhiteSpace(fName)
                && !string.IsNullOrWhiteSpace(lName)
                && !string.IsNullOrWhiteSpace(phoneNo)
                && fName.Length > 1
                && lName.Length > 1
                && phoneNo.Length > 2;
        }

    }
}
