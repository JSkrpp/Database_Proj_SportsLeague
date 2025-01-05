using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liga.ChildForm
{
    public partial class DeleteForm : Form
    {
        private DataAccess dataAccess;
        private DataEditor dataEditor;
        private string current;
        private List<Team> teams;
        private List<Player> players;
        private List<Stadium> stadiums;
        private List<Sponsor> sponsors;

        public DeleteForm(DataAccess data)
        {
            this.dataAccess = data;
            this.dataEditor = new DataEditor();
            InitializeComponent();
        }

        private void btn1_click(object sender, EventArgs e)
        {
            current = tableCB.Text;
            tableName.Text = current;
            if (dataList != null)
            {
                dataList.Items.Clear();
            }

            switch (current)
            {
                case "Drużyny":
       
                    dataAccess.SelectTeams();
                    teams = dataAccess.GetTeams;
                    foreach (Team t in teams)
                    {
                        dataList.Items.Add($"{t.TeamID}. {t.TeamCity}, {t.TeamName}");
                    }
                    break;

                case "Stadiony":
                    dataAccess.SelectStadiums();
                   
                    stadiums = dataAccess.GetStadiums;
                    foreach (Stadium s in stadiums)
                    {
                        dataList.Items.Add($"{s.ArenaName}");
                    }
                    break;

                case "Sponsorzy":
                    dataAccess.SelectSponsors();
                    sponsors = dataAccess.GetSponsors;
                    foreach (Sponsor s in sponsors)
                    {
                        dataList.Items.Add(s.SponsorName);
                    }
                    break;

                case "Zawodnicy":
                    dataAccess.SelectPlayers();
                    players = dataAccess.GetPlayers;
                    foreach (Player pl in players)
                    {
                        dataList.Items.Add($"{pl.PlayerID}. {pl.LastName}, {pl.FirstName}");
                    }
                    break;

                default:
                    break;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            switch (current)
            {
                case "Sponsorzy":
                    Sponsor toDelete = sponsors.FirstOrDefault(s => s.SponsorName == dataList.GetItemText(dataList.SelectedItem));
                    DialogResult confirmResult = MessageBox.Show($"Czy na pewno chcesz usunac {toDelete.SponsorID}, {toDelete.SponsorName}, " +
                        $"{toDelete.SponsorType} z tabeli {current}", "Usuwanie rekordu" , MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        dataEditor.DeleteSponsor(toDelete.SponsorName);
                    }
                    break;

                case "Stadiony":
                    Stadium stadDelete = stadiums.FirstOrDefault(s => s.ArenaName == dataList.GetItemText(dataList.SelectedItem));
                    confirmResult = MessageBox.Show($"Czy na pewno chcesz usunac {stadDelete.ArenaName}, {stadDelete.Capacity}, " +
                        $"{stadDelete.TeamID}, {stadDelete.SponsorID}, z tabeli {current}", "Usuwanie rekordu", MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        dataEditor.deleteStadium(stadDelete.ArenaName);
                    }
                    break;

                default: break;
            }
        }
    }
}
