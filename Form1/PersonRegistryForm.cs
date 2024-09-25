using Form1.Klasser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class PersonRegistryForm : Form
    {
        List<Person> personlist = new List<Person>();
        
        string firstname;
        string lastname;

        public PersonRegistryForm()
        {
            InitializeComponent();
            listBoxOutPut.SelectionMode = SelectionMode.MultiSimple;
        }

        /// <summary>
        /// Metod för att kontrollera att man valt en knapp för male/female och lägger till valda i listan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Addbuttom_Click(object sender, EventArgs e) 
        {
            firstname = firstnametextbox.Text;
            lastname = lastnametextbox.Text;

            if (CheckForWrongInput() == false)

                if (femalebuttom.Checked)
                {
                    Female female = new Female("Mrs", firstname, lastname);
                    personlist.Add(female);
                    string femalereturn = female.ReturnName();
                    listBoxOutPut.Items.Add(femalereturn);
                }
                else if (malebuttom.Checked)
                {
                    Male male = new Male("Mr", firstname, lastname);
                    personlist.Add(male);
                    string malereturn = male.ReturnName();
                    listBoxOutPut.Items.Add(malereturn);
                }
        }

        /// <summary>
        /// Kolla så man inte skriver in nummer eller skickar tomt fält
        /// </summary>
        /// <returns></returns>
        private bool CheckForWrongInput()
        {

            if (firstname == null || firstname == ""  && lastname == null || lastname == "")
            {
                return true;
            }
            else if (!firstname.All(char.IsLetter) || !lastname.All(char.IsLetter))
            {
                return true;
            }
            else
            {
                return false;
            }  
        }

        /// <summary>
        /// Uppdaterar listan med de sorterade namnen
        /// </summary>
        private void UpdateListBoxOutPut()
        {
            listBoxOutPut.Items.Clear();
            foreach (Person person in personlist)
            {
                listBoxOutPut.Items.Add(person.GetPrefix() + " " +  person.GetFirstName() + " " + person.GetLastName());
            }   
        }

        /// <summary>
        /// Knapp för att sortera listan
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SortButtom_Click(object sender, EventArgs e)
        {
            personlist.Sort();
            UpdateListBoxOutPut();

        }

        /// <summary>
        /// Knapp för att ta bort och felhantering om man inte väljer någon person
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemoveButtom_Click(object sender, EventArgs e)
        {
            try
            {
                personlist.RemoveAt(listBoxOutPut.SelectedIndex);
            }
            catch(Exception)
            {
                MessageBox.Show("You must choose a person to delete");
            }
                   
            UpdateListBoxOutPut();
        }

        /// <summary>
        /// Mergeknapp som kontrollerar att man valt två personer och att de är en male och female
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MergeButtom_Click(object sender, EventArgs e)
        { 
            
            if (listBoxOutPut.SelectedIndices.Count != 2)
            {
                MessageBox.Show("Please choose two people to merge");
            }
            
            if (listBoxOutPut.SelectedIndices.Count ==2)
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

