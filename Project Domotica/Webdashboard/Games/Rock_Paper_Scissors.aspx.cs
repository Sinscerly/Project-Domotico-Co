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

        protected void UserChose(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string User_Plays = button.Text;
            ResetVisablility(1);
            lbl_PlayerHasChosen.Text = User_Plays;
            string ComputerHasChosen = ComputerChose();
            System.Threading.Thread.Sleep(3000);
            lbl_ComputerHasChosen.Text = ComputerHasChosen;
            lbl_WhoWins.Text = FindWinner(User_Plays, ComputerHasChosen);
            ResetVisablility(2);
        }
        protected string FindWinner(string x, string y)
        {
            int z = 0;
            // z stands for
            // 0 -> Draw
            // 1 -> Win
            // 2 -> Lose
            if(x == y)
            {
                z = 0;
            }
            else if (x == "Rock")
            {
                if(y == "Paper")
                {
                    z = 2;
                }
                else
                {
                    z = 1;
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
            return GetComment(z);
        }
        protected string GetComment(int x)
        {
            Random rnd = new Random();
            if (x == 0)
            {
                int number = rnd.Next(0, 4);
                switch (number)
                {
                    case 0:
                        return "Sorry you didn't won, but don't be so sadly. It's a draw.";
                    case 1:
                        return "Good job, you made it to a draw.";
                    case 2:
                        return "You played yourself into a draw, no one won this round.";
                    default:
                        return "It's a draw";
                }
            }
            else if (x == 1)
            {
                int number = rnd.Next(0, 7);
                switch (number)
                {
                    case 0:
                        return "Congratulations you won this game.";
                    case 1:
                        return "No way that you have won from me.";
                    case 2:
                        return "I want a revanche, I don't accept that i lose from a person like you.";
                    case 3:
                        return "You're so good, you've won from me.";
                    case 4:
                        return "Well done, you won this round.";
                    case 5:
                        return "You've won, we're you cheating??";
                    default:
                        return "You won";
                }
            }
            else if (x == 2)
            {
                int number = rnd.Next(0, 7);
                switch (number)
                {
                    case 0:
                        return "HAHA, I've won.";
                    case 1:
                        return "You cannot win from me.";
                    case 2:
                        return "Well you lost.";
                    case 3:
                        return "You know you're playing against me, I win everytime.";
                    case 4:
                        return "I did it, again. Ohhhh.";
                    case 5:
                        return "Whaaoooo, I won.";
                    case 6:
                        return "You cannot beat Glados!";
                    default:
                        return "I've won from you.";
                }
            }
            return "I don't know it, do you?";
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
            Restart();
            Response.Write("<script>alert('The game has crashed, sorry for this problem.')</script>");
        }

        protected void Retry(object sender, EventArgs e)
        {
            Restart();
        }

        protected void Restart()
        {
            lbl_PlayerHasChosen.Text = "";
            lbl_ComputerHasChosen.Text = "";
            lbl_WhoWins.Text = "";
            ResetVisablility(0);
        }
    }
}
