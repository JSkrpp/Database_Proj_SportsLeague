using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Liga.ChildForm;
using Ligga;

namespace Liga
{
    public partial class Form1 : Form
    {
        private Color dflt = Color.FromArgb(20,30,50);
        private DataAccess dataAccess = new DataAccess();
        private List<Player> players = new List<Player>();
        private List<Team> teams = new List<Team>();
        private List<Stadium> stadiums = new List<Stadium>();
        private Form currentForm;
        private Session session;

        public Form1()
        {
            InitializeComponent();
            openChildForm(new ChildForm.HomeForm());
        }

        private void Form1_Load(object sender, EventArgs e) => session = new Session();

        private void widokBtn_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(180, 160, 20);
            update_frame(color, "Wyswietlanie danych");
            WidokBtn.BackColor = color;
            openChildForm(new ChildForm.ViewForm(dataAccess));
        }

        private void deletionBtn_Click(Object sender, EventArgs e)
        {
            if (session.getStatus())
            {
                Color color = Color.FromArgb(120, 10, 10);
                update_frame(color, "Usuwanie");
                DeletionBtn.BackColor = color;
                openChildForm(new ChildForm.DeleteForm(dataAccess));
            }
            else
            {
                MessageBox.Show("Nie jestes zalogowany do systemu!", "Brak dostepu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logBtn_Click(sender, e);
            }
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Color color = Color.FromArgb(20, 30, 50);
            update_frame(color, "Ekran Startowy");
            HomeBtn.BackColor = color;
            openChildForm(new ChildForm.HomeForm());
        }

        private void editBtn_Click( object sender, EventArgs e)
        {
            if (session.getStatus())
            {
                Color color = Color.FromArgb(20, 40, 90);
                update_frame(color, "Edycja");
                EditorBtn.BackColor = color;
                openChildForm(new ChildForm.EditorForm(dataAccess));
            }
            else
            {
                MessageBox.Show("Nie jestes zalogowany do systemu!", "Brak dostepu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logBtn_Click(sender, e);
            }
        }

        private void addBtn_Click( Object sender, EventArgs e )
        {
            if (session.getStatus())
            {
                Color color = Color.FromArgb(200, 200, 200);
                update_frame(color, "Dodawanie");
                AddBtn.BackColor = color;
                openChildForm(new ChildForm.Addform());
            }
            else
            {
                MessageBox.Show("Nie jestes zalogowany do systemu!", "Brak dostepu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logBtn_Click(sender, e);
            }
        }

        private void logBtn_Click(Object sender, EventArgs e)
        {
            Color color = Color.FromArgb(10, 150, 10);
            update_frame(color, "Logowanie");
            LogBtn.BackColor = color;
            openChildForm(new ChildForm.LoginForm(session));
        }


        private void openChildForm (Form childForm)
        {
            teams.Clear();
            players.Clear();
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.formPane.Controls.Add(childForm);
            this.formPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
;       }

        private void update_frame(Color color, String text)
        {
            WidokBtn.BackColor = dflt;
            EditorBtn.BackColor = dflt;
            DeletionBtn.BackColor = dflt;
            LogBtn.BackColor = dflt;
            HomeBtn.BackColor = dflt;
            AddBtn.BackColor = dflt;
            ScreenPane.BackColor = color;
            ScreenLabel.Text = text;
        }

      
    }
}
