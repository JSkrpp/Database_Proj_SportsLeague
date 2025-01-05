using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
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



        public void editTeam(string id, string newName, string newCity, string balance, string sponsorID, string newConference)
        {
            
            int TeamID = int.Parse(id);
            float newBalance = float.Parse(balance, CultureInfo.InvariantCulture);
            int newSponsorID = int.Parse(sponsorID);
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = $"UPDATE Drużyny SET TeamName = '{newName}', TeamCity = '{newCity}', BilansMLN = {newBalance}, SponsorID = {newSponsorID}, " +
                    $"Conference = '{newConference}' WHERE TeamID = {TeamID};";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
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
                string sql = $"UPDATE Stadiony SET Capacity = {newCapacity}, TeamID = {TeamID}, SponsorID = {newSponsorID} " +
                     $"WHERE ArenaName = '{ArenaName}';";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public void deleteStadium(string ArenaName)
        {
            using (SqlConnection con = new SqlConnection(con_str))
            {
                con.Open();
                string sql = $"DELETE FROM Stadiony WHERE ArenaName='{ArenaName}' ;";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
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
                string sql = $"INSERT INTO Sponsorzy VALUES ({SponsorID} , '{SponsorName}', '{SponsorType}');";

                using (SqlCommand command = new SqlCommand(sql, con))
                {
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
                string sql = $"UPDATE Sponsorzy SET SponsorName = '{SponsorName}', SponsorType = '{SponsorType}' WHERE SponsorID = {SponsorID};";

                using (SqlCommand command= new SqlCommand(sql, con))
                {
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


    }
}
