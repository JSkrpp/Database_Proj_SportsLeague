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
    public partial class EditorForm : Form
    {
        private string currentTable;
        private int textCount = 0;
        private DataAccess dataAccess;
        private DataEditor editor;
        private List<String> names;
        
        public EditorForm(DataAccess data)
        {
            
            InitializeComponent();
            this.dataAccess = data;
            editor = new DataEditor();
            names = new List<String>();
        }

        public void ConfirmBtn_Click(object sender, EventArgs e)
        {
            string choice = tablesCB.Text;
            tabLabel.Text = choice;
            loadTable(choice);
        }

        public void loadTable(string choice)
        {
            if (TableList != null)
            {
                TableList.Items.Clear();
            }
            clearTextBoxes();
            switch (choice)
            {
                case "Druzyny":
                    dataAccess.SelectTeams();
                    List<Team> teams = dataAccess.GetTeams;
                    foreach (Team t in teams)
                    {
                        TableList.Items.Add(t.TeamName);
                    }
                    break;

                case "Stadiony":
                    dataAccess.SelectStadiums();
                    List<Stadium> stadiums = dataAccess.GetStadiums;
                    foreach(Stadium s in stadiums)
                    {
                        TableList.Items.Add(s.ArenaName);
                    }
                    break;

                case "Pracownicy":
                    dataAccess.SelectEmployees();
                    List<Employee> employees = dataAccess.GetEmployees;
                    foreach(Employee e in employees)
                    {
                        TableList.Items.Add($"{e.EmployeeID},{e.LastName}");
                    }
                    break;

                case "Sponsorzy":
                    dataAccess.SelectSponsors();
                    List<Sponsor> sponsors = dataAccess.GetSponsors;
                    foreach(Sponsor s in sponsors)
                    {
                        TableList.Items.Add($"{s.SponsorID}, {s.SponsorName}");
                    }
                    break;

                case "Kontrakty":
                    dataAccess.SelectContracts();
                    List<Contract> contracts = dataAccess.GetContracts;
                    foreach(Contract contract in contracts)
                    {
                        TableList.Items.Add($"{contract.Id}, {contract.SalaryMLN}");
                    }
                    break;

                case "Zawodnicy":
                    dataAccess.SelectPlayers();
                    List<Player> players = dataAccess.GetPlayers;
                    foreach(Player p in players)
                    {
                        TableList.Items.Add($"{p.PlayerID}, {p.FirstName}, {p.LastName}");
                    }
                    break;


                default: break;
            }
            currentTable = choice;
        }

        public void LoadBtn_Click(Object sender, EventArgs e)
        {
            textBoxLoad(currentTable);
        }

        public void textBoxLoad(string choice)
        {
            clearTextBoxes();
            string selected;
            string[] parts;
            switch (choice)
            {
                case "Druzyny":
                    if (names != null)
                    {
                        names.Clear();
                    }
                    names.Add("TeamID");
                    names.Add("TeamName");
                    names.Add("CityName");
                    names.Add("BilansMLN");
                    names.Add("SponsorID");
                    names.Add("Conference");
                    dataAccess.SelectTeams();
                    List<Team> teams = dataAccess.GetTeams;
                    selected = TableList.SelectedItem.ToString();
                    Team team = teams.FirstOrDefault(t => t.TeamName == selected);
                    textBox1.Text = team.TeamID.ToString();
                    textBox2.Text = team.TeamName;
                    textBox3.Text = team.TeamCity;
                    textBox4.Text = team.BilansMLN.ToString();
                    textBox5.Text = team.SponsorID.ToString();
                    textBox6.Text = team.Conference;
                    break;

                case "Stadiony":
                    if (names != null)
                    {
                        names.Clear();
                    }
                    names.Add("ArenaName");
                    names.Add("Capacity");
                    names.Add("TeamID");
                    names.Add("SponsorID");
                    dataAccess.SelectStadiums();
                    List<Stadium> stadiums = dataAccess.GetStadiums;
                    selected = TableList.SelectedItem.ToString();
                    Stadium stadium = stadiums.FirstOrDefault(s => s.ArenaName == selected);
                    textBox1.Text = stadium.ArenaName;
                    textBox2.Text = stadium.Capacity.ToString();
                    textBox3.Text = stadium.TeamID.ToString();
                    if (stadium.SponsorID != null)
                    {
                        textBox4.Text = stadium.SponsorID.ToString();
                    }
                    break;

                case "Pracownicy":
                    if (names != null)
                    {
                        names.Clear();
                    }
                    names.Add("EmployeeID");
                    names.Add("First Name");
                    names.Add("Last Name");
                    names.Add("Position");
                    names.Add("Salary");
                    names.Add("TeamID");
                    names.Add("ExpiryDate");
                    dataAccess.SelectEmployees();
                    List<Employee> employees = dataAccess.GetEmployees;
                    selected = TableList.SelectedItem.ToString();
                    parts = selected.Split(',');
                    int id = int.Parse(parts[0]);
                    Employee emp = employees.FirstOrDefault(e => e.EmployeeID == id);
                    textBox1.Text = emp.EmployeeID.ToString();
                    textBox2.Text = emp.FirstName;
                    textBox3.Text = emp.LastName;
                    textBox4.Text = emp.Position;
                    textBox5.Text = emp.Salary.ToString();
                    textBox6.Text = emp.TeamID.ToString();
                    textBox7.Text = emp.ExpiryDate.ToString();
                    break;

                case "Sponsorzy":
                    if (names != null)
                    {
                        names.Clear();
                    }
                    names.Add("SponsorID");
                    names.Add("SponsorName");
                    names.Add("SponsorType");
                    updateLabels(names);
                    dataAccess.SelectSponsors();
                    List<Sponsor> sponsors = dataAccess.GetSponsors;
                    selected = TableList.SelectedItem.ToString();
                    parts = selected.Split(',');
                    int spID = int.Parse(parts[0]);
                    Sponsor sp = sponsors.FirstOrDefault(s => s.SponsorID == spID);
                    textBox1.Text += sp.SponsorID.ToString();
                    textBox2.Text += sp.SponsorName;
                    textBox3.Text += sp.SponsorType;
                    break;

                case "Kontrakty":
                    if (names != null)
                    {
                        names.Clear();
                    }
                    names.Add("ID");
                    names.Add("PlayerID");
                    names.Add("ExpiryDate");
                    names.Add("Salary(MLN)");
                    dataAccess.SelectContracts();
                    List<Contract> contracts = dataAccess.GetContracts;
                    selected = TableList.SelectedItem.ToString();
                    parts = selected.Split(',');
                    int cID = int.Parse(parts[0]);
                    Contract contract = contracts.FirstOrDefault(c => c.Id == cID);
                    textBox1.Text += contract.Id;
                    textBox2.Text += contract.PlayerID;
                    textBox3.Text += contract.ExpiryDate.ToString();
                    textBox4.Text += contract.SalaryMLN;
                    break;

                case "Zawodnicy":
                    if (names != null)
                    {
                        names.Clear();
                    }
                    names.Add("PlayerID");
                    names.Add("LastName");
                    names.Add("FirstName");
                    names.Add("DateOfBirth");
                    names.Add("TeamID");
                    names.Add("CountryCode");
                    names.Add("SponsorID");
                    dataAccess.SelectPlayers();
                    List<Player> players = dataAccess.GetPlayers;
                    selected = TableList.SelectedItem.ToString();
                    parts = selected.Split(',');
                    int plID = int.Parse(parts[0]);
                    Player player = players.FirstOrDefault(p => p.PlayerID == plID);
                    textBox1.Text += player.PlayerID;
                    textBox2.Text += player.LastName;
                    textBox3.Text += player.FirstName;
                    textBox4.Text += player.DateOfBirth;
                    textBox5.Text += player.TeamID;
                    textBox6.Text += player.CountryCode;
                    textBox7.Text += player.SponsorID;
                    break;
                default: break;
            }
            updateLabels(names);
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

        public void editBtn_Click(object sender, EventArgs e)
        {

            DataEditor dataEditor = new DataEditor();
            try
            {
                switch (currentTable)
                {
                    case "Druzyny":
                        dataEditor.editTeam(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
                        break;

                    case "Stadiony":
                        dataEditor.editStadium(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                        break;

                    case "Sponsorzy":
                        dataEditor.EditSponsor(textBox1.Text, textBox2.Text, textBox3.Text);
                        break;

                    case "Kontrakty":
                        dataEditor.EditContract(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                        break;
                }
                clearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                var label = this.Controls.Find($"label{i+1}", true).FirstOrDefault() as Label;
                label.Text = names[i];
            }
        }


    }
}
