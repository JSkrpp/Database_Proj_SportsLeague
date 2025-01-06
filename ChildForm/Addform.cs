using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liga.ChildForm
{
    public partial class Addform : Form
    {
        private List<String> names;
        private string current;
        private DataEditor dataEditor;

        public Addform()
        {
            InitializeComponent();
            this.dataEditor = new DataEditor();
            this.current = "";
            this.names = new List<String>();
        }

        public void clearTextBoxes()
        {
            for (int i = 1; i < 8; i++)
            {
                var textBox = this.Controls.Find($"textBox{i}", true).FirstOrDefault() as TextBox;
                if (textBox != null)
                {
                    textBox.Clear();
                }
            }
        }

        public void updateLabels(List<String> names)
        {
            for (int i = 1; i < 8; i++)
            {
                var label = this.Controls.Find($"label{i}", true).FirstOrDefault() as Label;
                label.Text = "";
            }
            for (int i = 0; i < names.Count; i++)
            {
                var label = this.Controls.Find($"label{i + 1}", true).FirstOrDefault() as Label;
                label.Text = names[i];
            }
        }

        public void LoadTableBtn_Click(Object sender, EventArgs e)
        {
                current = tablesCB.Text;
                if (names != null)
                {
                    names.Clear();
                }
                tableLabel.Text = current;

                switch (current)
                {
                    case "Zawodnicy":
                        names.Add("PlayerID");
                        names.Add("LastName");
                        names.Add("FirstName");
                        names.Add("DateOfBirth");
                        names.Add("TeamID");
                        names.Add("CountryCode");
                        names.Add("SponsorID");
                        break;

                    case "Druzyny":
                        names.Add("TeamName");
                        names.Add("TeamCity");
                        names.Add("BilansMLN");
                        names.Add("SponsorID");
                        names.Add("conference");
                        break;

                    case "Sponsorzy":
                        names.Add("SponsorID");
                        names.Add("SponsorName");
                        names.Add("SponsorType");
                        break;

                    case "Stadiony":
                        names.Add("ArenaName");
                        names.Add("Capacity");
                        names.Add("TeamID");
                        names.Add("SponsorID");
                        break;

                    case "Kontrakty":
                        names.Add("Id");
                        names.Add("PlayerID");
                        names.Add("ExpiryDate");
                        names.Add("SalaryMLN");
                        break;

                    case "Pracownicy":
                        names.Add("ID");
                        names.Add("PlayerID");
                        names.Add("ExpiryDate");
                        names.Add("Salary(MLN)");
                        break;
                    

                    default: break;
                }
                updateLabels(names);
            
        }

        public void dataAddBtn_click(Object sender, EventArgs e)
        {
            try
            {
                switch (current)
                {
                    case "Sponsorzy":
                        dataEditor.AddSponsor(textBox1.Text, textBox2.Text, textBox3.Text);
                        break;

                    case "Stadiony":
                        dataEditor.AddStadium(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                        break;

                    case "Druzyny":
                        dataEditor.addTeam(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, textBox4.Text);
                        break;

                    case "Kontrakty":
                        dataEditor.AddContract(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                        break;

                    default: break;
                }
                clearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nie polaczono z baza danych.\n Blad: {ex.Message}");
            }

           }
       
    }
}
