using PersonRegistryLibrary.Classes;

namespace PersonRegistryUI
{
    public partial class PersonRegistryForm : Form
    {
        List<Person> personlist = new List<Person>();

        string firstName;
        string lastName;

        public PersonRegistryForm()
        {
            InitializeComponent();
            listBoxOutPut.SelectionMode = SelectionMode.MultiSimple;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            firstName = firstname_textbox.Text;
            lastName = lastname_textbox.Text;

            if (CheckForWrongInput() == false)

                if (Female_RadioButton.Checked)
                {
                    Female female = new Female("Mrs", firstName, lastName);
                    personlist.Add(female);
                    string femalereturn = female.ReturnName();
                    listBoxOutPut.Items.Add(femalereturn);
                }
                else if (Male_RadioButton.Checked)
                {
                    Male male = new Male("Mr", firstName, lastName);
                    personlist.Add(male);
                    string malereturn = male.ReturnName();
                    listBoxOutPut.Items.Add(malereturn);
                }
        }

        private bool CheckForWrongInput()
        {

            if (firstName == null || firstName == "" && lastName == null || lastName == "")
            {
                return true;
            }
            else if (!firstName.All(char.IsLetter) || !lastName.All(char.IsLetter))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void UpdateListBoxOutPut()
        {
            listBoxOutPut.Items.Clear();
            foreach (Person person in personlist)
            {
                listBoxOutPut.Items.Add(person.GetPrefix() + " " + person.GetFirstName() + " " + person.GetLastName());
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            personlist.Sort();
            UpdateListBoxOutPut();
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            try
            {
                personlist.RemoveAt(listBoxOutPut.SelectedIndex);
            }
            catch (Exception)
            {
                MessageBox.Show("You must choose a person to delete");
            }

            UpdateListBoxOutPut();
        }

        private void MergeButton_Click(object sender, EventArgs e)
        {
            if (listBoxOutPut.SelectedIndices.Count != 2)
            {
                MessageBox.Show("Please choose two people to merge");
            }

            if (listBoxOutPut.SelectedIndices.Count == 2)
            {
                var indexNr = listBoxOutPut.SelectedIndices;
                if (personlist[indexNr[0]] is Male && personlist[indexNr[1]] is Female)
                {
                    var child = (personlist[indexNr[1]] + personlist[indexNr[0]]);
                    personlist.Add(child);
                    UpdateListBoxOutPut();
                }
                else if (personlist[indexNr[0]] is Female && personlist[indexNr[1]] is Male)
                {
                    var child = (personlist[indexNr[0]] + personlist[indexNr[1]]);
                    personlist.Add(child);
                    UpdateListBoxOutPut();
                }
                else
                {
                    MessageBox.Show("Please choose a female and a male");
                }
            }
        }
    }
}
