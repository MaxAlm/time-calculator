using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeCalculator
{
    public partial class Form1 : Form
    {
        ///////////////////
        ///// METODER /////
        ///////////////////


        private void CalculateTime(int hourS, int minS, ref int hourE, ref int minE)
        {
            if (minS < minE)
            {
                hourE -= hourS;
                minE -= minS;
            }
            else
            {
                minE += 60;
                hourE -= 1;
                minE -= minS;
                hourE -= hourS;
            }

            // Kolla så att minuter inte överstiger 59 min
            if (minE >= 60)
            {
                minE -= 60;
                hourE += 1;
            }

            // Kolla så att timmar arbetade inte undergår noll
            if (hourE <= 0)
            {
                hourE += 24;
            }
        }


        ///////////////////
        //// KOD START ////
        ///////////////////

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Stäng av resize och maximize
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // Sätt ComboBox till "Monday" som default
            comboDay.SelectedIndex = 0;

            // Lägg till kategorier i listan
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.Columns.Add("Day", 90);
            listView.Columns.Add("Time", 90);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Skapa variabler
            int hourS;
            int minS;
            int hourE;
            int minE;

            string time;
            string day = String.Empty;


            // Kolla så inga inmatnings fält är tomma
            if (inputHourStart.Text != "" && inputMinStart.Text != "" && inputHourEnd.Text != "" && inputMinEnd.Text != "")
            {
                try
                {
                    // Försök konvertera och lagra text fälten
                    hourS = Convert.ToInt32(inputHourStart.Text);
                    minS = Convert.ToInt32(inputMinStart.Text);
                    hourE = Convert.ToInt32(inputHourEnd.Text);
                    minE = Convert.ToInt32(inputMinEnd.Text);

                    // Felsök variablerna
                    if (hourS <= 23 && minS <= 59 && hourS >= 0 && minS >= 0)
                    {
                        if (hourE <= 23 && minE <= 59 && hourE >= 0 && minE >= 0)
                        {
                            CalculateTime(hourS, minS, ref hourE, ref minE);
                        }
                        else
                        {
                            MessageBox.Show("Invalid end time", "Error");
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid start time", "Error");
                        return;
                    }

                    // Lagra dag
                    switch (comboDay.SelectedIndex)
                    {
                        case 0:
                            day = "Monday";
                            break;

                        case 1:
                            day = "Tuesday";
                            break;

                        case 2:
                            day = "Wednesday";
                            break;

                        case 3:
                            day = "Thursday";
                            break;

                        case 4:
                            day = "Friday";
                            break;

                        case 5:
                            day = "Saturday";
                            break;

                        case 6:
                            day = "Sunday";
                            break;
                    }

                    // Lagra tid
                    if (hourE < 10)
                    {
                        if (minE < 10)
                        {
                            time = "0" + hourE + " hrs 0" + minE + " min";
                        }
                        else
                        {
                            time = "0" + hourE + " hrs " + minE + " min";
                        }
                    }
                    else
                    {
                        if (minE < 10)
                        {
                            time = "" + hourE + " hrs 0" + minE + " min";
                        }
                        else
                        {
                            time = "" + hourE + " hrs " + minE + " min";
                        }
                    }

                    // Lägg till arbetad tid i listan
                    string[] itemInfo = { day, time };
                    ListViewItem item = new ListViewItem(itemInfo);
                    listView.Items.Add(item);

                    // Rensa alla text fält
                    inputHourStart.Text = "";
                    inputMinStart.Text = "";
                    inputHourEnd.Text = "";
                    inputMinEnd.Text = "";
                }
                catch
                {
                    MessageBox.Show("Input can only contain numbers", "Error");
                }
            }
            else
            {
                MessageBox.Show("Invalid input", "Error");
            }
        }
    }
}
