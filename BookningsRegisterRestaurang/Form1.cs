using MySql.Data.MySqlClient;
using System.Data;
using System.Xml.Linq;

namespace BookningsRegisterRestaurang
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;

        TextBox[] txtBoxesBookNow;
        TextBox[] txtBoxesCancelBooking;

        public Form1()
        {
            InitializeComponent();



            // Skapa ref för MySQLConnection objekt
            KopplingTillDb kopplingTillDb = new KopplingTillDb();
            conn = kopplingTillDb.GetConnection();

            //Skapa en Array Ref för input fält
            txtBoxesBookNow = new TextBox[] { txtFirstName, txtLastName, txtTelNumber, txtEMail, txtNumOfPersons };
            //Skapa en Array Ref för input fält
            txtBoxesCancelBooking = new TextBox[] { txtFirstName, txtLastName, txtTelNumber, txtEMail, txtNumOfPersons, txtKundId};

        }
        private void BookNow()
        {
            //Valedering
            bool valid = true;

            foreach (TextBox txtBox in txtBoxesBookNow)
            {
                //trimmar text-innehåller
                txtBox.Text = txtBox.Text.Trim();

                //Kontrollera att txtBox har text
                if (txtBox.Text == "")
                {
                    valid = false;
                    txtBox.BackColor = Color.IndianRed;
                }
                else
                {
                    txtBox.BackColor = TextBox.DefaultBackColor;
                }
            }

            //Kontrollera validering
            if (!valid)
            {
                MessageBox.Show("Felaktig validering. Kontrollera röda fält!");
                return;
            }

            //Hämta värden från txtfält
            string förnamn = txtFirstName.Text;
            string efternamn = txtLastName.Text;
            string telefon = txtTelNumber.Text;
            string email = txtEMail.Text;
            int antal_gäster = int.Parse(txtNumOfPersons.Text);
            DateTime dateTime = DateTime.Now;


            //Bygg upp SQL querry
            string sqlQuerry = $"CALL add_customer_and_book('{förnamn}', '{efternamn}', '{telefon}', '{email}', '{dateTime}', '{antal_gäster}');";


            //Skapar ett MySqlCommand objekt
            MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);

            //Skapa ett TryCatch Block
            try
            {
                //Öppna Connection
                conn.Open();

                //Exekvera kommando
                MySqlDataReader reader = cmd.ExecuteReader();
                int id = 0;
                sqlQuerry = $"CALL kund('{id}');";

                //Tömma statisk lista
                BokningsSystem.bokningsSystems.Clear();

                //Placera data i en DataTable objekt
                DataTable dt = new DataTable();
                dt.Load(reader);

                //Koppla TD objekt som DataSource till Grid
                gridVisaBokningarOutput.DataSource = dt;

                //Lägg till kund_id som en synlig kolumn i gridVisaBokningarOutput
                gridVisaBokningarOutput.Columns.Add("kund_id", "Kund ID");

                //Stänga Connection
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Bekräftelse till användare
            MessageBox.Show("Insert Finished Successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BookNow();
            GetRowData();

        }

        private void GetRowData()
        {
            // Kontrollera att vi har en markerad rad i grid
            if (gridVisaBokningarOutput.SelectedRows.Count != 1) return;

            // Hämta data från grid
            DataGridViewSelectedRowCollection row = gridVisaBokningarOutput.SelectedRows;
            int id = Convert.ToInt32(row[0].Cells[0].Value);

            // Hämta referensen till den markerade raden
            DataGridViewRow selectedRow = row[0];

            // Uppdatera de relevanta cellerna med den data vi vill visa
            selectedRow.Cells["kund_id"].Value = id; 

        }



        private void visaTillgängligaBokningar()
        {
            //Bygg upp SQL querry
            string sqlQuerry;
            sqlQuerry = $"CALL visa_tillgängliga_bookningar();";


            //Skapar ett MySqlCommand objekt
            MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);

            //Skapa ett TryCatch Block
            try
            {
                //Öppna Connection
                conn.Open();

                //Exekvera cmd
                MySqlDataReader reader = cmd.ExecuteReader();

                //Placera data i en DataTable objekt
                DataTable dt = new DataTable();
                dt.Load(reader);

                //Koppla TD objekt som DataSource till Grid
                gridVisaBokningarOutput.DataSource = dt;

                //Stänga Connection
                conn.Close();
            }
            catch (Exception myException)
            {
                MessageBox.Show(myException.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visaTillgängligaBokningar();
        }
        private void cancelBooking()
        {
            //Valedering
            bool valid = true;

            foreach (TextBox txtBox in txtBoxesCancelBooking)
            {
                //trimmar text-innehåller
                txtBox.Text = txtBox.Text.Trim();

                //Kontrollera att txtBox har text
                if (txtBox.Text == "")
                {
                    valid = false;
                    txtBox.BackColor = Color.IndianRed;
                }
                else
                {
                    txtBox.BackColor = TextBox.DefaultBackColor;
                }
            }

            //Kontrollera validering
            if (!valid)
            {
                MessageBox.Show("Felaktig validering. Kontrollera röda fält!");
                return;
            }

            //Hämta värden från txtfält
            string förnamn = txtFirstName.Text;
            string efternamn = txtLastName.Text;
            string telefon = txtTelNumber.Text;
            string email = txtEMail.Text;
            int antal_gäster = int.Parse(txtNumOfPersons.Text);
            int kund_id = Convert.ToInt32(txtKundId.Text);


            //Bygg upp SQL querry
            string sqlQuerry = $"CALL cancel_booking('{kund_id}','{förnamn}', '{efternamn}', '{telefon}', '{email}','{antal_gäster}');";


            //Skapar ett MySqlCommand objekt
            MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);

            //Skapa ett TryCatch Block
            try
            {
                //Öppna Connection
                conn.Open();

                //Exekvera kommando
                cmd.ExecuteReader();

                //Stänga Connection
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Bekräftelse till användare
            MessageBox.Show("Canceling Finished Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cancelBooking();
        }

    }

}