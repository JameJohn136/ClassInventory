using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassInventory
{
    public partial class Form1 : Form
    {
        // Global Variabales go here
        List<Player> players = new List<Player>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name, position, team;
            int age;
            // Get Info
            age = Convert.ToInt32(ageInput.Text);
            name = nameInput.Text;
            position = positionInput.Text;
            team = teamInput.Text;

            // Create Player Using Values
            Player newPlayer = new Player(age, name, team, position);

            // Add to List
            players.Add(newPlayer);

            // Update Text
            ShowText();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Get Input Text Input
            string removeName = removeInput.Text;

           
           Player removePlayer = players.Find(x => x.name == removeName);

            // Check to see if player was found
            if (removePlayer != null)
            {
               removeErrorText.Text = $"Removed {removePlayer.name}";
               players.Remove(removePlayer);
               ShowText();
            } else
            {
                removeErrorText.Text = "Player Not Found";
            }

            
            

        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            // Get Input Text Input
            string searchName = nameSearchInput.Text;
            // Find Player
            Player searchPlayer = players.Find(x => x.name == searchName);

            // Display found player(s)
            outputLabel.Text = "";
            foreach(Player player in players)
            {
                if (player.name == searchName)
                {
                    outputLabel.Text += $"Name: {player.name}, Age: {player.age}, Team: {player.team}, Position: {player.position}\n";
                }
            }

            // See if any player was found (DOESNT WORK PLEASE FIX JAMES)
            if (outputLabel.Text == "") 
            {
                outputLabel.Text = "No Player Found";
            }

        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // Sort by Teams
            List<Player> teamSortList = players.OrderBy(x => x.team).ToList();

            // Print Text
            outputLabel.Text = "";
            foreach(Player player in teamSortList)
            {
                outputLabel.Text += $"Name: {player.name}, Age: {player.age}, Team: {player.team}, Position: {player.position}\n";
            }
        }

        private void ShowText()
        {
            outputLabel.Text = "";
            foreach(Player player in players)
            {
                outputLabel.Text += $"Name: {player.name}, Age: {player.age}, Team: {player.team}, Position: {player.position}\n";
            }
        }
    }
}
