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
        //// VARIABLER ////
        ///////////////////

        int total = 0;  // Totala antalet minuter arbetade sammanlagt

        ///////////////////
        //// KOD START ////
        ///////////////////

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
            string day = "";


            // Kolla så inga inmatnings fält är tomma
            if (inputHourStart.Text != "" && inputMinStart.Text != "" && inputHourEnd.Text != "" && inputMinEnd.Text != "")
            {
                try
                {
                    // Konvertera och lagra text fälten
                    hourS = Convert.ToInt32(inputHourStart.Text);
                    minS = Convert.ToInt32(inputMinStart.Text);
                    hourE = Convert.ToInt32(inputHourEnd.Text);
                    minE = Convert.ToInt32(inputMinEnd.Text);

                    // Se tilla att inga felaktiga tider har matats in
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
                    time = String.Format("{0} hrs {1} min", hourE, minE);

                    // Lägg till arbetad tid i listan
                    string[] itemInfo = { day, time };
                    ListViewItem item = new ListViewItem(itemInfo);
                    listView.Items.Add(item);

                    // Lagra och skriv ut totala tiden
                    total += (hourE * 60) + minE;
                    label_total.Text = String.Format("{0} hrs {1} min", (total - (total % 60)) / 60, total % 60);
                    label_total.Left = (listView.Left + listView.Width) - label_total.Width;


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
