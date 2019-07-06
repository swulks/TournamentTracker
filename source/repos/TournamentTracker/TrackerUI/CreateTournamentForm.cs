using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class CreateTournamentForm : Form, IPrizeRequester, ITeamRequester
    {
        List<TeamModel> availableTeams = GlobalConfig.Connection.GetTeam_All();
        List<TeamModel> selectedTeams = new List<TeamModel>();
        List<PrizeModel> selectedPrizes = GlobalConfig.Connection.GetPrizes_All();


        public CreateTournamentForm()
        {
            InitializeComponent();

            WireUpList();
        }

        public void teamPlayersLabel_Click(object sender, EventArgs e)
        {

        }

        public void CreateTournamentForm_Load(object sender, EventArgs e)
        {

        }

        private void WireUpList()
        {
            selectTeamDropDown.DataSource = null;

            selectTeamDropDown.DataSource = availableTeams;
            selectTeamDropDown.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;

            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            prizesListBox.DataSource = null;

            prizesListBox.DataSource = selectedPrizes;
            prizesListBox.DisplayMember = "PlaceName";
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {         
            TeamModel t = (TeamModel)selectTeamDropDown.SelectedItem;

            if (t != null)
            {
                availableTeams.Remove(t);
                selectedTeams.Add(t);

                WireUpList();
            }
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //Call the create prize form
            CreatePrizeForm frm = new CreatePrizeForm(this);
            frm.Show();
            
        }

        public void PrizeComplete(PrizeModel model)
        {
            selectedPrizes.Add(model);
            WireUpList();
        }

        public void TeamComplete(TeamModel model)
        {
            availableTeams.Add(model);
            WireUpList();
        }

        private void createNewTeamLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateTeamForm frm = new CreateTeamForm(this);
            frm.Show();
        }

        private void removeSelectedPlayersButton_Click(object sender, EventArgs e)
        {
            TeamModel p = (TeamModel)tournamentTeamsListBox.SelectedItem;


            if (p != null)
            {
                selectedTeams.Remove(p);
                availableTeams.Add(p);
                WireUpList();
            }
        }

        private void removeSelectedPrizeButton_Click(object sender, EventArgs e)
        {
            PrizeModel p = (PrizeModel)prizesListBox.SelectedItem;


            if (p != null)
            {
                selectedPrizes.Remove(p);
                WireUpList();
            }
        }

        private void CreateTournamentButton_Click(object sender, EventArgs e)
        {
            //validate data
            //create our Tournament model
            //create tournament entry
            //create all of the Prizes Entryes
            //create team entryes

            //TODO - wire up matchups
            decimal fee = 0;

            bool isDecimal = decimal.TryParse(entryFeeTextBox.Text, out fee);
            if (!isDecimal)
            {
                MessageBox.Show("Number is not a decimal", "Invalid fee!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TournamentModel tm = new TournamentModel();
            tm.TournamentName = tournamentNameTextField.Text;
            tm.EntryFee = fee;

            tm.Prizes = selectedPrizes;
            tm.EnteredTeams = selectedTeams;

            GlobalConfig.Connection.CreateTournament(tm);
            
        }
    }
}
