using Microsoft.Testing.Platform.Extensions.Messages;
using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Liga
{
    public class DataEditor
    {
        private string con_str;
        public DataEditor() 
        {

        this.con_str = "Server=LAPTOP-OLN485JV\\LIGA; Database=liga_sportowa; Trusted_Connection=True";

        }

        public void addTeam(string name, string city, string balance, string conference, string sponsor ="")
        {
            float Bal = float.Parse(balance, System.Globalization.CultureInfo.InvariantCulture);
            if (sponsor != "")
            {
                int SponsorID = int.Parse(sponsor);
            }
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "INSERT INTO Drużyny VALUES (@name, @city, @balance, @sponsor, @Conference);";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@city", city);
                    cmd.Parameters.AddWithValue("@balance", Bal);
                    cmd.Parameters.AddWithValue("@sponsor", sponsor);
                    cmd.Parameters.AddWithValue("@Conference", conference);
                    cmd.ExecuteNonQuery();
                }
            }

        }
        public void editTeam(string id, string newName, string newCity, string balance, string sponsorID, string newConference)
        {
            
            int TeamID = int.Parse(id);
            float newBalance = float.Parse(balance, System.Globalization.CultureInfo.InvariantCulture);
            int newSponsorID = int.Parse(sponsorID);
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "UPDATE Drużyny SET TeamName = @newName, TeamCity = @newCity, BilansMLN = @newBalance, " +
                     "SponsorID = @newSponsorID, Conference = @newConference WHERE TeamID = @TeamID; ";


                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@newName", newName);
                    command.Parameters.AddWithValue("@newCity", newCity);
                    command.Parameters.AddWithValue("@newBalance", newBalance); 
                    command.Parameters.AddWithValue("@newSponsorID", newSponsorID);
                    command.Parameters.AddWithValue("@newConference", newConference);
                    command.Parameters.AddWithValue("@TeamID", TeamID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddStadium(string ArenaName, string capacity, string team, string sponsor)
        {
            if (sponsor == null) sponsor = "";
            int TeamID = int.Parse(team);
            int newCapacity = int.Parse(capacity);
            int SponsorID =int.Parse(sponsor);

            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = $"INSERT INTO Stadiony VALUES ('{ArenaName}',{newCapacity} ,{TeamID} ,{SponsorID});";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            
        }

        public void editStadium(string ArenaName, string capacity, string team, string sponsor)
        {
            if (sponsor == null) sponsor = "";
            int TeamID = int.Parse(team);
            int newCapacity = int.Parse(capacity);
            int newSponsorID = int.Parse(sponsor);

            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = $"UPDATE Stadiony SET Capacity = @NewCapacity, TeamID = @TeamID, SponsorID = @newSponsorID " +
                     $"WHERE ArenaName = @ArenaName;";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@NewCapacity", newCapacity);
                    command.Parameters.AddWithValue("@TeamID", TeamID);
                    command.Parameters.AddWithValue("@newSponsorID", newSponsorID);
                    command.Parameters.AddWithValue("@ArenaName", ArenaName);
                    command.ExecuteNonQuery();
                }
            }
        }

        public void deleteStadium(string ArenaName)
        {
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = $"DELETE FROM Stadiony WHERE ArenaName= @ArenaName ;";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@ArenaName", ArenaName);
                    command.ExecuteNonQuery();
                }
            }
        }


        public void AddSponsor(string sponsorID, string SponsorName, string SponsorType)
        {
            int SponsorID = int.Parse(sponsorID);

            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "INSERT INTO Sponsorzy (SponsorID, SponsorName, SponsorType) VALUES (@SponsorID, @SponsorName, @SponsorType);";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@SponsorID", SponsorID);
                    command.Parameters.AddWithValue("@SponsorName", SponsorName);
                    command.Parameters.AddWithValue("@SponsorType", SponsorType);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EditSponsor(string sponsorID, string SponsorName, string SponsorType)
        {
            int SponsorID = int.Parse(sponsorID);

            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = $"UPDATE Sponsorzy SET SponsorName = @SponsorName, SponsorType = @SponsorType WHERE SponsorID = @SponsorID;";

                using (SqlCommand command= new SqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@SponsorID", SponsorID);
                    command.Parameters.AddWithValue("@SponsorName", SponsorName);
                    command.Parameters.AddWithValue("@SponsorType", SponsorType);
                        
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteSponsor(string SponsorName)
        {

            using(SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = $"DELETE FROM Sponsorzy WHERE SponsorName='{SponsorName}' ;";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void AddContract(string id, string playerID, string expiryDate, string salary)
        {
            int Id = int.Parse(id);
            int PlayerID = int.Parse(playerID);
            float Salary = float.Parse(salary);
            var expDate = DateTime.ParseExact(expiryDate, "MM.dd.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = $"INSERT INTO Kontrakty VALUES ({Id},{PlayerID} ,@Date ,{Salary});";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Date", expDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditContract(string id, string playerID, string expiryDate, string salary)
        {

            int Id = int.Parse(id);
            int PlayerID = int.Parse(playerID);
            float Salary = float.Parse(salary, System.Globalization.CultureInfo.InvariantCulture);
            var expDate = DateTime.ParseExact(expiryDate, "MM.dd.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = $"UPDATE Kontrakty SET PlayerID = @playerID, ExpiryDate = @expDate, [Salary(MLN)] = @Salary WHERE ID = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@playerID", PlayerID);
                    cmd.Parameters.AddWithValue("@expDate", expDate);
                    cmd.Parameters.AddWithValue("@Salary", Salary);
                    cmd.Parameters.AddWithValue("@Id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void deleteContract(string id)
        {
            int Id = int.Parse (id);
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "DELETE FROM Kontrakty WHERE Id = @id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", Id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void AddPlayer(string LastName, string FirstName, string birth, string tID, string countryCode, string spID)
        {
            int team = int.Parse(tID);
            var date = DateTime.ParseExact(birth, "MM.dd.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            int spon = int.Parse(spID);

            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "INSERT INTO Zawodnicy VALUES (@lastName, @firstName, @birth, @team, @country, @spon); ";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@lastname", LastName);
                    cmd.Parameters.AddWithValue("@firstName", FirstName);
                    cmd.Parameters.AddWithValue("@birth", date);
                    cmd.Parameters.AddWithValue("@team", team);
                    cmd.Parameters.AddWithValue("@country", countryCode);
                    cmd.Parameters.AddWithValue("@spon", spon);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditPlayer(string id, string LastName, string FirstName, string birth, string tID, string countryCode, string spID)
        {
            int playerID = int.Parse(id);
            var date = DateTime.ParseExact(birth, "MM.dd.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            int team = int.Parse(tID);
            int spon = int.Parse(spID);
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "UPDATE Zawodnicy SET LastName = @LastName, FirstName = @FirstName, DateOfBirth = @Date, TeamID = @Team, CountryCode = @code, " +
                    "SponsorId = @spon WHERE PlayerID = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@LastName", LastName);
                    cmd.Parameters.AddWithValue("@FirstName", FirstName);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@Team", team);
                    cmd.Parameters.AddWithValue("@code", countryCode);
                    cmd.Parameters.AddWithValue("@spon", spon);
                    cmd.Parameters.AddWithValue("@Id", playerID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeletePlayer(string id)
        {
            int playerID = int.Parse(id);
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "DELETE FROM Zawodnicy WHERE PlayerID = @Id";

                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id", playerID);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void AddEmployee(string FirstName, string LastName, string Position, string Salary, string TId, string ExpiryDate)
        {
            int salary = int.Parse(Salary);
            int tId = int.Parse(TId);
            var date = DateTime.ParseExact(ExpiryDate, "MM.dd.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "INSERT INTO Pracownicy Values (@first, @last, @pos, @salary, @team, @date);";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@first", FirstName);
                    cmd.Parameters.AddWithValue("@last", LastName);
                    cmd.Parameters.AddWithValue("@pos", Position);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@team", tId);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void EditEmployee(string id, string FirstName, string LastName, string Position, string Salary, string TId, string ExpiryDate)
        {
            int ID = int.Parse(id);
            int salary = int.Parse(Salary);
            int tId = int.Parse(TId);
            var date = DateTime.ParseExact(ExpiryDate, "MM.dd.yyyy", System.Globalization.CultureInfo.InvariantCulture);

            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = "UPDATE Pracownicy SET FirstName = @first,LastName = @last,Position = @pos,Salary = @salary,TeamID = @team, " +
                "ExpiryDate = @date WHERE TeamID = @Id";
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@first", FirstName);
                    cmd.Parameters.AddWithValue("@last", LastName);
                    cmd.Parameters.AddWithValue("@pos", Position);
                    cmd.Parameters.AddWithValue("@salary", salary);
                    cmd.Parameters.AddWithValue("@team", tId);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@Id", ID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
