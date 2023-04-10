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



            // Skapa ref f�r MySQLConnection objekt
            KopplingTillDb kopplingTillDb = new KopplingTillDb();
            conn = kopplingTillDb.GetConnection();

            //Skapa en Array Ref f�r input f�lt
            txtBoxesBookNow = new TextBox[] { txtFirstName, txtLastName, txtTelNumber, txtEMail, txtNumOfPersons };
            //Skapa en Array Ref f�r input f�lt
            txtBoxesCancelBooking = new TextBox[] { txtFirstName, txtLastName, txtTelNumber, txtEMail, txtNumOfPersons, txtKundId};

        }
        private void BookNow()
        {
            //Valedering
            bool valid = true;

            foreach (TextBox txtBox in txtBoxesBookNow)
            {
                //trimmar text-inneh�ller
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
                MessageBox.Show("Felaktig validering. Kontrollera r�da f�lt!");
                return;
            }

            //H�mta v�rden fr�n txtf�lt
            string f�rnamn = txtFirstName.Text;
            string efternamn = txtLastName.Text;
            string telefon = txtTelNumber.Text;
            string email = txtEMail.Text;
            int antal_g�ster = int.Parse(txtNumOfPersons.Text);
            DateTime dateTime = DateTime.Now;


            //Bygg upp SQL querry
            string sqlQuerry = $"CALL add_customer_and_book('{f�rnamn}', '{efternamn}', '{telefon}', '{email}', '{dateTime}', '{antal_g�ster}');";


            //Skapar ett MySqlCommand objekt
            MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);

            //Skapa ett TryCatch Block
            try
            {
                //�ppna Connection
                conn.Open();

                //Exekvera kommando
                MySqlDataReader reader = cmd.ExecuteReader();
                int id = 0;
                sqlQuerry = $"CALL kund('{id}');";

                //T�mma statisk lista
                BokningsSystem.bokningsSystems.Clear();

                //Placera data i en DataTable objekt
                DataTable dt = new DataTable();
                dt.Load(reader);

                //Koppla TD objekt som DataSource till Grid
                gridVisaBokningarOutput.DataSource = dt;

                //L�gg till kund_id som en synlig kolumn i gridVisaBokningarOutput
                gridVisaBokningarOutput.Columns.Add("kund_id", "Kund ID");

                //St�nga Connection
                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Bekr�ftelse till anv�ndare
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

            // H�mta data fr�n grid
            DataGridViewSelectedRowCollection row = gridVisaBokningarOutput.SelectedRows;
            int id = Convert.ToInt32(row[0].Cells[0].Value);

            // H�mta referensen till den markerade raden
            DataGridViewRow selectedRow = row[0];

            // Uppdatera de relevanta cellerna med den data vi vill visa
            selectedRow.Cells["kund_id"].Value = id; 

        }



        private void visaTillg�ngligaBokningar()
        {
            //Bygg upp SQL querry
            string sqlQuerry;
            sqlQuerry = $"CALL visa_tillg�ngliga_bookningar();";


            //Skapar ett MySqlCommand objekt
            MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);

            //Skapa ett TryCatch Block
            try
            {
                //�ppna Connection
                conn.Open();

                //Exekvera cmd
                MySqlDataReader reader = cmd.ExecuteReader();

                //Placera data i en DataTable objekt
                DataTable dt = new DataTable();
                dt.Load(reader);

                //Koppla TD objekt som DataSource till Grid
                gridVisaBokningarOutput.DataSource = dt;

                //St�nga Connection
                conn.Close();
            }
            catch (Exception myException)
            {
                MessageBox.Show(myException.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            visaTillg�ngligaBokningar();
        }
        private void cancelBooking()
        {
            //Valedering
            bool valid = true;

            foreach (TextBox txtBox in txtBoxesCancelBooking)
            {
                //trimmar text-inneh�ller
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
                MessageBox.Show("Felaktig validering. Kontrollera r�da f�lt!");
                return;
            }

            //H�mta v�rden fr�n txtf�lt
            string f�rnamn = txtFirstName.Text;
            string efternamn = txtLastName.Text;
            string telefon = txtTelNumber.Text;
            string email = txtEMail.Text;
            int antal_g�ster = int.Parse(txtNumOfPersons.Text);
            int kund_id = Convert.ToInt32(txtKundId.Text);


            //Bygg upp SQL querry
            string sqlQuerry = $"CALL cancel_booking('{kund_id}','{f�rnamn}', '{efternamn}', '{telefon}', '{email}','{antal_g�ster}');";


            //Skapar ett MySqlCommand objekt
            MySqlCommand cmd = new MySqlCommand(sqlQuerry, conn);

            //Skapa ett TryCatch Block
            try
            {
                //�ppna Connection
                conn.Open();

                //Exekvera kommando
                cmd.ExecuteReader();

                //St�nga Connection
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //Bekr�ftelse till anv�ndare
            MessageBox.Show("Canceling Finished Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cancelBooking();
        }

    }

}