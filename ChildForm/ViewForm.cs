﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Liga.ChildForm
{
    //TODO : Wyswietlanie pozostalych tabel, zlozone SELECT

    public partial class ViewForm : Form
    {
        private DataAccess dataAccess;
        private List<Team> teams;
        private List<Player> players;
        private List<Stadium> stadiums;
        private List<Sponsor> sponsors;
        private List<Employee> employees;
        private List<Contract> contracts;
        private string current;
        public ViewForm(DataAccess dataAccess)
        {
            InitializeComponent();
            this.dataAccess = dataAccess;
            this.teams = dataAccess.GetTeams;
            this.players = dataAccess.GetPlayers;
            this.stadiums = dataAccess.GetStadiums;
            this.employees = dataAccess.GetEmployees;
            this.contracts = dataAccess.GetContracts;
            this.current = "";
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
                    foreach(Team t in teams)
                    {
                        dataList.Items.Add($"{t.TeamID}. {t.TeamCity}, {t.TeamName}");
                    }
                    break;

                case "Sponsorzy":
                    dataAccess.SelectSponsors();
                    sponsors = dataAccess.GetSponsors;
                    foreach(Sponsor s in sponsors)
                    {
                        dataList.Items.Add(s.SponsorName);
                    }
                    break;

                case "Stadiony":
                    dataAccess.SelectStadiums();
                    stadiums = dataAccess.GetStadiums;
                    foreach (Stadium s in stadiums)
                    {
                        dataList.Items.Add($"{s.ArenaName}. {s.Capacity}");
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

                case "Pracownicy":
                    dataAccess.SelectEmployees();
                    employees = dataAccess.GetEmployees;
                    foreach (Employee employee in employees)
                    {
                        dataList.Items.Add($"{employee.EmployeeID}. {employee.FirstName}, {employee.LastName}");
                    }
                    break;

                default:
                    break;
            }
        }


        //TODO
        private void btn2_click(object sender, EventArgs e)
        {
            string[] part = dataList.Text.Split('.');
            switch (current)
            {
                case "Drużyny":
                    Team team = teams.FirstOrDefault(t => t.TeamID.ToString() == part[0]);
                    MessageBox.Show($"ID: {team.TeamID}, City: {team.TeamCity} , Name: {team.TeamName} , Balance: {team.BilansMLN} MLN");
                    break;

                case "Zawodnicy":
                    Player player = players.FirstOrDefault(p => p.PlayerID.ToString() == part[0]);
                    MessageBox.Show($"ID: {player.PlayerID}, {player.FirstName}, {player.LastName}, {player.DateOfBirth}, SponsorID: {player.SponsorID}, {player.CountryCode}");
                    break;

                case "Sponsorzy":
                    Sponsor spon = sponsors.FirstOrDefault(s => s.SponsorName == dataList.Text);
                    MessageBox.Show($"SponorID: {spon.SponsorID}; Name: {spon.SponsorName}, Type: {spon.SponsorType}");
                    break;

                case "Stadiony":
                    Stadium stadium = stadiums.FirstOrDefault(st => st.ArenaName == part[0]);
                    MessageBox.Show($"{stadium.ArenaName}, {stadium.Capacity}, TeamID: {stadium.TeamID}, SponsorID: {stadium.SponsorID}");
                    break;

                case "Pracownicy":
                    Employee employee = employees.FirstOrDefault(em => em.EmployeeID.ToString() == part[0]);
                    MessageBox.Show($"{employee.EmployeeID}, {employee.FirstName}, {employee.LastName}, {employee.Position} , Salary: {employee.Salary}, Contract Expiration: {employee.ExpiryDate}");
                    break;

                case "Kontrakty":
                    Contract contract = contracts.FirstOrDefault(cn => cn.Id.ToString() == part[0]);
                    MessageBox.Show($"{contract.Id}, PlayerID: {contract.PlayerID}, Expiration {contract.ExpiryDate}, Salary: {contract.SalaryMLN}");
                    break;
                default : break;
            }
        }
    }
}
