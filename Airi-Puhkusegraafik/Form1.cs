using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Airi_Puhkusegraafik
{
    public partial class Form1 : Form
    {
        List<Name> names = new List<Name>();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Database database = new Database();
            names = database.RetriveNames();
            
            foreach(var user in names)
            {
                Person_Exit.Items.Add(user.name);
                Person_Enter.Items.Add(user.name);
            }

            

        }
        private void AddVacation_Click(object sender, EventArgs e)
        {
           
            Name name = new Name();

            name.name = Person_Enter.Text;

            Vacations vacation = new Vacations();
            vacation._vacEnd = dateEnd.Value;
            vacation._vacStart = dateStart.Value;
            vacation._UserID = names[Person_Enter.SelectedIndex].id;
            
            Database database = new Database();
            
            database.InsertVacation(vacation);
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            Database database = new Database();
            var names = database.RetriveNames();
            Person_Enter.Items.Clear();
            Person_Exit.Items.Clear();

            foreach (var user in names)
            {
                Person_Exit.Items.Add(user.name);
                Person_Enter.Items.Add(user.name);
            }
        }

        private void Puhkused_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database database = new Database();
            var vacations = database.RetriveVacation(names[Puhkused.SelectedIndex+1]);
            Puhkused.Items.Clear();
            foreach(var vacation in vacations)
            {
                Puhkused.Items.Add(String.Format("{0} - {1}", vacation._vacStart.ToString(),vacation._vacEnd.ToString()));

            }

            
        }
    }
}
