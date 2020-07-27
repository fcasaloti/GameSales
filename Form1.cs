using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Assignment2
{
    public partial class GameSales : Form
    {
        public GameSales()
        {
            InitializeComponent();
        }

        //declaration of variables
        string search, game, company, sales;
        double total, salesFixed;
        bool validation;

        private void errorCb_CheckedChanged(object sender, EventArgs e)
        {
            //Clear the content of the Listbox
            resultsLb.Items.Clear();

            //clear total
            outputLb.Text = "";
        }

        private void GameSales_Load(object sender, EventArgs e)
        {

            //disable radio buttons
            microsoftRb.Enabled = false;
            eaRb.Enabled = false;
            blizzardRb.Enabled = false;

            //assign value in Group Button totalGB
            totalGb.Text = "Total Sales";

        }

        private void TotalBt_Click(object sender, EventArgs e)
        {
            //Clear the content of the Listbox
            resultsLb.Items.Clear();
            
            //Open Files
            StreamReader inFileGame;
            inFileGame = File.OpenText("game.dat");

            StreamReader inFileSalesNumbers;
            inFileSalesNumbers = File.OpenText("SalesNumbers.dat");

            StreamReader inFileCompany;
            inFileCompany = File.OpenText("company.dat");

            StreamWriter inFileSearch;
            inFileSearch = File.AppendText("searchLogFile.dat");

            //assign value from searchbox
            search = searchTb.Text.Trim();

            //assign initial value to variables
            total = 0;
            salesFixed = 0;
            validation = false;

            //search in docs.dat
            while (!inFileGame.EndOfStream)
            {
                //read each line of each file and trim empty spaces
                game = inFileGame.ReadLine().Trim();
                sales = inFileSalesNumbers.ReadLine().Trim();
                company = inFileCompany.ReadLine().Trim();

                //search match between game searched and content from game.dat
                if (String.Compare(game, search, true) == 0)
                {
                     totalGb.Text = ("Total Sales for " + game);
                    //convert string to double and cast corrupted entries on sales
                    if (double.TryParse(sales, out double salesFixed))
                    {
                        //input items in listbox and calculate total
                        resultsLb.Items.Add(salesFixed.ToString("c2"));
                        total = total + salesFixed;
                        outputLb.Text = total.ToString("c2");

                        //log
                        inFileSearch.WriteLine(game + " === " + salesFixed.ToString("c2"));
                    }
                    else
                    {
                        //if button Error checked
                        if (!errorCb.Checked)
                        {
                            resultsLb.Items.Add("Sales figure corrupted");

                            //assign 0 to total
                            outputLb.Text = total.ToString("c2");

                            //log
                            inFileSearch.WriteLine(game + " === " + "Sales figure corrupted");
                        }
                        
                        else
                        {
                            resultsLb.Items.Add("Sales figure corrupted - " + sales);
                            
                            //assign 0 to total
                            outputLb.Text = total.ToString("c2");

                            //log
                            inFileSearch.WriteLine(game + " === " + "Sales figure corrupted - " + sales);
                        }
                    }

                    //Check Company buttons
                    if (String.Compare(company, "ms", true) == 0 && !microsoftRb.Checked)
                        microsoftRb.Checked = true;
                    if (String.Compare(company, "ea", true) == 0 && !eaRb.Checked)
                        eaRb.Checked = true;
                    if (String.Compare(company, "blz", true) == 0 && !blizzardRb.Checked)
                        blizzardRb.Checked = true;
                    
                    //validate if the search was succesful on title
                    validation = true;
                }
            }

            //Message if there is nothing filled in search text box
            if (searchTb.Text.Trim() == "")
            {
                MessageBox.Show("Nothing entered" + Environment.NewLine + "Please re-enter game title");
                //clear total
                outputLb.Text = "";

                //uncheck error
                errorCb.Checked = false;

                //assign value in Group Button totalGB
                totalGb.Text = "Total Sales";
            }

            //Message when game title is not found
            if (validation == false && (searchTb.Text.Trim() != ""))
            {
                MessageBox.Show("Game title NOT found");

                //Clear listbox
                resultsLb.Items.Clear();

                //Clear total
                outputLb.Text = "";

                //Clear search box
                searchTb.Text = "";

                //Uncheck error button
                errorCb.Checked = false;

                //Uncheck radio buttons companys
                microsoftRb.Checked = false;
                eaRb.Checked = false;
                blizzardRb.Checked = false;

                //assign value in Group Button totalGB
                totalGb.Text = "Total Sales";
            }
            //Closing files
            inFileGame.Close();
            inFileSalesNumbers.Close();
            inFileCompany.Close();
            inFileSearch.Close();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            //Clear listbox
            resultsLb.Items.Clear();

            //Clear total
            outputLb.Text = "";

            //Clear search box
            searchTb.Text = "";

            //Uncheck error button
            errorCb.Checked = false;

            //Uncheck radio buttons companys
            microsoftRb.Checked = false;
            eaRb.Checked = false;
            blizzardRb.Checked = false;

            //assign value in Group Button totalGB
            totalGb.Text = "Total Sales";
        }

    }
}
