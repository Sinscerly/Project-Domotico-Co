using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webdashboard.Games
{
    public partial class Rock_Paper_Scissors : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Retry()
        {
            lbl_PlayerHasChosen.Text = "";
            lbl_ComputerHasChosen.Text = "";
            lbl_WhoWins.Text = "";
            ResetVisablility(0);
        }

        protected void UserChose(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string User_Plays = button.Text;
            ResetVisablility(1);
            lbl_PlayerHasChosen.Text = User_Plays;
            string ComputerHasChosen = ComputerChose();
            System.Threading.Thread.Sleep(5000);
            lbl_ComputerHasChosen.Text = ComputerHasChosen;
            lbl_WhoWins.Text = FindWinner(User_Plays, ComputerHasChosen);

            ResetVisablility(2);
            
        }
        protected string FindWinner(string x, string y)
        {
            int z;  return "You've WON!!";
            // z stands for
            // 0 -> Draw
            // 1 -> Win
            // 2 -> Lose
            if (x == y)
            {
                z = 0;
            }
            if (x == "Rock")
            {
                if(y == "Paper")
                {
                    z = 1;
                }
                else
                {
                    z = 2;
                }
            }
            else if( x == "Paper")
            {
                if(y == "Rock")
                {
                    z = 1;
                }
                else
                {
                    z = 2;
                }
            }
            else if( x == "Scissor")
            {
                if(y == "Paper")
                {
                    z = 1;
                }
                else
                {
                    z = 2;
                }
            }
            // get's one of the dynamic comments back.

        }
        protected string GetComment(int x)
        {
            Random rnd = new Random();
            if(x == 0)
            {
                int number = rnd.Next(0, 2);
                switch (number)
                {
                    case 0:
                        return "Sorry you didn't won, but don't be so sadly. It's a draw.";
                    case 1:
                        return
                }
            }
        }


        protected string ComputerChose()
        {
            Random rnd = new Random();
            int ComputerChoseNumber = rnd.Next(0, 3);
            string ComputerPlayed = string.Empty;
            switch (ComputerChoseNumber)
            {
                case 0:
                    return "Rock";
                case 1:
                    return "Paper";
                case 2:
                    return "Scissor";
                default:
                    ComputerPlayed = "Error";
                    break;
            }
            ERROR();  
            return ComputerPlayed;
        }

        protected void ResetVisablility(int x)
        {
            if (x == 0)
            {
                btn_Paper.Visible = true;
                btn_Rock.Visible = true;
                btn_Scissor.Visible = true;
                btn_Retry.Visible = false;
            }
            if (x == 1)
            {
                btn_Paper.Visible = false;
                btn_Rock.Visible = false;
                btn_Scissor.Visible = false;
                btn_Retry.Visible = false;
            }
            if (x == 2)
            {
                btn_Paper.Visible = false;
                btn_Rock.Visible = false;
                btn_Scissor.Visible = false;
                btn_Retry.Visible = true;
            }
        }
        protected void ERROR()
        {
            Retry();
            Response.Write("<script>alert('The game has crashed, sorry for this problem.')</script>");
        }
    }
}