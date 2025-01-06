using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;
using System.Security.Policy;
using Ligga;

namespace Liga
{
    public class DataAccess
    {
        private List<Player> players { get; set; }
        private List<Team> teams;
        private List<Stadium> stadiums;
        private List<Sponsor> sponsors;
        private List<Employee> employees;
        private List<Contract> contracts;
        private List<TeamPlayer> teamPlayers;
        private string con_str;
        public DataAccess()
        {
            players = new List<Player>();
            teams = new List<Team>();
            stadiums = new List<Stadium>();
            sponsors = new List<Sponsor>();
            employees = new List<Employee>();
            contracts = new List<Contract>();
            teamPlayers = new List<TeamPlayer>();
            con_str = "Server=LAPTOP-OLN485JV\\LIGA; Database=liga_sportowa; Trusted_Connection=True";
        }

        public void SelectPlayers()
        {
            if (players != null)
            {
                players.Clear();
            }
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "SELECT * FROM Zawodnicy";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Player player = new Player();
                            player.PlayerID = reader.GetInt32(0);
                            player.LastName = reader.GetString(1);
                            player.FirstName = reader.GetString(2);
                            player.DateOfBirth = reader.GetDateTime(3).ToString("MM/dd/yyyy");
                            if (!reader.IsDBNull(4))
                            {
                                player.TeamID = reader.GetInt32(4);
                            }
                            player.CountryCode = reader.GetString(5);
                            if (!reader.IsDBNull(6))
                            {
                                player.SponsorID = reader.GetInt32(6);
                            }

                            players.Add(player);
                        }
                    }
                }
            }

        }

        public void SelectTeams()
        {
            if (teams != null)
                {
                       teams.Clear();
                }
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "SELECT * FROM Drużyny";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Team team = new Team();
                            team.TeamID = reader.GetInt32(0);
                            team.TeamName = reader.GetString(1);
                            team.TeamCity = reader.GetString(2);
                            team.BilansMLN = reader.GetFloat(3);
                            team.SponsorID = reader.GetInt32(4); 
                            team.Conference = reader.GetString(5);

                            teams.Add(team);
                        }
                    }
                }
            }
        }

        public void SelectStadiums()
        {
            if (stadiums != null)
            {
                stadiums.Clear();
            }

            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "SELECT * FROM Stadiony";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Stadium stadium = new Stadium();
                            stadium.ArenaName = reader.GetString(0);
                            stadium.Capacity = reader.GetInt32(1);
                            stadium.TeamID = reader.GetInt32(2);
                            if (!reader.IsDBNull(3))
                            {
                                stadium.SponsorID = reader.GetInt32(3);
                            }
                            stadiums.Add(stadium);
                        }
                    }
                }
            }
        }

        public void SelectSponsors()
        {
            if (sponsors != null)
            {
                sponsors.Clear();
            }

            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "SELECT * FROM Sponsorzy";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Sponsor sponsor = new Sponsor();
                            sponsor.SponsorID = reader.GetInt32(0);
                            sponsor.SponsorName = reader.GetString(1);
                            sponsor.SponsorType = reader.GetString(2);
                            sponsors.Add(sponsor);
                        }
                    }
                }
            }
        }

        public void SelectEmployees()
        {
            if (employees != null)
            { employees.Clear(); }

            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "SELECT * FROM Pracownicy";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Employee employee = new Employee();
                            employee.EmployeeID = reader.GetInt32(0);
                            employee.FirstName = reader.GetString(1);
                            employee.LastName = reader.GetString(2);
                            employee.Position = reader.GetString(3);
                            employee.Salary = reader.GetInt32(4);
                            employee.TeamID = reader.GetInt32(5);
                            employee.ExpiryDate = reader.GetDateTime(6).ToString("MM/dd/yyyy");
                            employees.Add(employee);
                        }
                    }
                }
            }
        }

        public void SelectContracts()
        {
            if (contracts != null)
            {
                contracts.Clear();
            }
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "SELECT * FROM Kontrakty";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Contract contract = new Contract();
                            contract.Id = reader.GetInt32(0);
                            contract.PlayerID = reader.GetInt32(1);
                            contract.ExpiryDate = reader.GetDateTime(2).ToString("MM/dd/yyyy");
                            contract.SalaryMLN = reader.GetFloat(3);
                            contracts.Add(contract);
                        }
                    }
                }
            }
        }

        public void SelectView(string TeamName, bool rising)
        {
            if (teamPlayers != null)
            {
                teamPlayers.Clear();
            }
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string orderBy = rising ? "ASC": "DESC";
                string sql = "SELECT * FROM Druzyna_Zawodnik WHERE TeamName = @TeamName " +
                    $"ORDER BY LastName {orderBy};";
                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@TeamName", TeamName);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TeamPlayer teamPlayer = new TeamPlayer();
                            teamPlayer.LastName = reader.GetString(0);
                            teamPlayer.FirstName = reader.GetString(1);
                            teamPlayer.Country = reader.GetString(2);
                            teamPlayer.TeamCity = reader.GetString(3);
                            teamPlayer.TeamName = reader.GetString(4);
                            teamPlayers.Add(teamPlayer);
                        }
                    }
                }
            }
        }

        public List<Player> GetPlayers
        { 
            get { return players; }
        }

        public List<Team> GetTeams
        {
            get { return teams; }
        }

        public List<Stadium> GetStadiums
        {
            get { return stadiums; }
        }

        public List<Sponsor> GetSponsors
        {
            get { return sponsors; }
        }

        public List<Employee> GetEmployees
        {
            get { return employees; } 
        }

        public List<Contract> GetContracts { get { return contracts; } }

        public List<TeamPlayer> GetView { get { return teamPlayers; } }
    }
}
