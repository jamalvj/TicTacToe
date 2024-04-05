

using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe
{

   public partial class GameForm : Form
   {

      Player currentPlayer; // x oder o
      List<Button> buttons; // array von allen buttons
      Random rand = new Random(); // Der Computer kann ein zufälliger zahl nehmen
      int playerwins = 0;
      int computerWins = 0;
      readonly int gamemodes;

      public System.Windows.Forms.Timer AImoves { get; set; }

      public GameForm(int gamemode)
      {
         InitializeComponent();
         resetGame();
         this.gamemodes = gamemode;
         if (gamemodes == 1)
         {
            AImoves = AImoves_normal;
         }
         else if (gamemodes == 2)
         {
            AImoves = AImoves_hard;
         }
         

      }

      private void playerClick(object sender, EventArgs e)
      {
         var button = (Button)sender; // gecklickter button
         // Spielen 2 echten Personen
         if (gamemodes == 3)
         { 
               if (button.Enabled)
               {
                  button.Enabled = false;
                  if (currentPlayer == Player.X)
                  {
                     button.Text = currentPlayer.ToString();
                     button.BackColor = System.Drawing.Color.Blue;
                  }
                  else if (currentPlayer == Player.O) 
                  {
                     button.Text = currentPlayer.ToString();
                     button.BackColor = System.Drawing.Color.Green;
                  }
                  buttons.Remove(button);
                  CheckWinBetweenFriends();
                  currentPlayer = (currentPlayer == Player.X) ? Player.O : Player.X;
               }
         }
         // Gegen Cpu 2 schwierigkeit level
         if (gamemodes != 3) 
         {
            currentPlayer = Player.X; // x fäangt an
            button.Text = currentPlayer.ToString(); // button wird geändert
            button.Enabled = false;
            button.BackColor = System.Drawing.Color.Blue; // farbe auf Blue änderen
            buttons.Remove(button); //button wird von der liste entfernt
            check(); // prüfen, ob jemand gewonnen hat
            AImoves.Start();
         }
            
      }

      private void AImoveNormal(object sender, EventArgs e)
      {

         if (buttons.Count > 0)
         {
            int index = rand.Next(buttons.Count);
            buttons[index].Enabled = false; // der zufälliger zahl wird zu den button zugeordnet
            currentPlayer = Player.O;
            buttons[index].Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
            buttons[index].BackColor = System.Drawing.Color.Green;
            buttons.RemoveAt(index);
            AImoves.Stop();//Timer stoppen
            check();

         }
      }

      private void restartGame(object sender, EventArgs e)
      {
         resetGame(); //neu anfangen
      }

      private void loadbuttons()
      {
         buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9};
      }
      private void resetGame()
      {
         foreach (Control X in this.Controls)
         {
            if (X is Button && X.Tag == "play")
            {
               ((Button)X).Enabled = true;
               ((Button)X).Text = "?"; //Text wird zurückgesetzt
               ((Button)X).BackColor = default(Color); // rücksetzung von Hintergrundfrabe
            }
         }
         loadbuttons(); //button in array wieder setzen
      }
      //prüft ob jemand gewonnen hat  (Cpu vs person)
      private void check()
      {
         // wird X gewinnen
         if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
             || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
             || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
             || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
             || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
             || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
             || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
             || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
         {
            AImoves.Stop();//Timer stoppen
            MessageBox.Show("Player Wins");
            playerwins++;
            label1.Text = "Player Wins-" + playerwins;
            resetGame();
         }
         // Wir O gewinnen
         else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                 || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                 || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                 || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                 || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                 || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                 || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                 || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
         {
            AImoves.Stop();//Timer stoppen
            MessageBox.Show("Computer Wins");
            computerWins++;
            label2.Text = "Player Wins- " + computerWins;
            resetGame();
         }
         else if (buttons?.Any() == false)
         {
            AImoves.Stop();
            DialogResult dr = MessageBox.Show("unentschieden, möchten Sie weiter das Spiel anschauen? ", "unentschieden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
               AImoves.Start();
            }
            if (dr == DialogResult.No)
            {
               AImoves.Stop();
               resetGame();
            }

         }


      }

      private void AImoveimapassible(object sender, EventArgs e)
      {
         if (buttons.Count > 0)
         {
            //O in der mitte
            if (button5.Enabled == true)
            {
               currentPlayer = Player.O;
               button5.Enabled = false;
               button5.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button5.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button5);
               AImoves.Stop();//Timer stoppen
               check();
               return;

            }
            // wenn x inder mitte ecken speren
            else if (button1.Enabled == true && ((button5.Text == "X" && button9.Text == "X") || (button4.Text == "X" && button2.Text == "X")))
            {
               currentPlayer = Player.O;
               button1.Enabled = false;
               button1.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button1.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button1);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button7.Enabled == true && ((button5.Text == "X" && button3.Text == "X") || (button4.Text == "X" && button8.Text == "X")))
            {
               currentPlayer = Player.O;
               button7.Enabled = false;
               button7.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button7.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button7);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button9.Enabled == true && ((button5.Text == "X" && button1.Text == "X") || (button8.Text == "X" && button6.Text == "X")))
            {
               currentPlayer = Player.O;
               button9.Enabled = false;
               button9.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button9.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button9);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button3.Enabled == true && ((button5.Text == "X" && button7.Text == "X") || (button2.Text == "X" && button6.Text == "X")))
            {
               currentPlayer = Player.O;
               button3.Enabled = false;
               button3.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button3.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button3);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            //Mitte sperren zwischen die Reihen 
            else if (button2.Enabled == true && ((button1.Text == "X" && button3.Text == "X") || (button5.Text == "X" && button8.Text == "X")))
            {
               currentPlayer = Player.O;
               button2.Enabled = false;
               button2.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button2.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button2);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button4.Enabled == true && ((button1.Text == "X" && button7.Text == "X") || (button5.Text == "X" && button6.Text == "X")))
            {
               currentPlayer = Player.O;
               button4.Enabled = false;
               button4.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button4.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button4);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button8.Enabled == true && ((button9.Text == "X" && button7.Text == "X") || (button5.Text == "X" && button2.Text == "X")))
            {
               currentPlayer = Player.O;
               button8.Enabled = false;
               button8.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button8.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button8);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button6.Enabled == true && ((button9.Text == "X" && button3.Text == "X") || (button5.Text == "X" && button4.Text == "X")))
            {
               currentPlayer = Player.O;
               button6.Enabled = false;
               button6.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button6.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button6);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            //Sieg speren auf 3 feld            
            else if (button3.Enabled == true && ((button1.Text == "X" && button2.Text == "X") || (button6.Text == "X" && button9.Text == "X")))
            {
               currentPlayer = Player.O;
               button3.Enabled = false;
               button3.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button3.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button3);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button7.Enabled == true && ((button1.Text == "X" && button4.Text == "X") || (button8.Text == "X" && button9.Text == "X")))
            {
               currentPlayer = Player.O;
               button7.Enabled = false;
               button7.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button7.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button7);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button1.Enabled == true && ((button4.Text == "X" && button7.Text == "X") || (button3.Text == "X" && button2.Text == "X")))
            {
               currentPlayer = Player.O;
               button1.Enabled = false;
               button1.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button1.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button1);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button9.Enabled == true && ((button8.Text == "X" && button7.Text == "X") || (button3.Text == "X" && button2.Text == "X")))
            {
               currentPlayer = Player.O;
               button9.Enabled = false;
               button9.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button9.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button9);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            // siegen wenn O in der mitte ist
            else if (button8.Enabled == true && button5.Text == "O" && button2.Text == "O")
            {
               currentPlayer = Player.O;
               button8.Enabled = false;
               button8.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button8.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button8);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button2.Enabled == true && button5.Text == "O" && button8.Text == "O")
            {
               currentPlayer = Player.O;
               button2.Enabled = false;
               button2.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button2.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button2);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button6.Enabled == true && button5.Text == "O" && button4.Text == "O")
            {
               currentPlayer = Player.O;
               button6.Enabled = false;
               button6.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button6.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button6);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button4.Enabled == true && button5.Text == "O" && button6.Text == "O")
            {
               currentPlayer = Player.O;
               button4.Enabled = false;
               button4.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button4.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button4);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button9.Enabled == true && button5.Text == "O" && button1.Text == "O")
            {
               currentPlayer = Player.O;
               button9.Enabled = false;
               button9.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button9.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button9);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button1.Enabled == true && button5.Text == "O" && button9.Text == "O")
            {
               currentPlayer = Player.O;
               button1.Enabled = false;
               button1.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button1.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button1);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button7.Enabled == true && button5.Text == "O" && button3.Text == "O")
            {
               currentPlayer = Player.O;
               button7.Enabled = false;
               button7.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button7.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button7);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button3.Enabled == true && button5.Text == "O" && button7.Text == "O")
            {
               currentPlayer = Player.O;
               button3.Enabled = false;
               button3.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button3.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button3);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            // siegen wenn O nicht mittig ist
            else if (button3.Enabled == true && ((button1.Text == "O" && button2.Text == "O") || (button6.Text == "O" && button9.Text == "O")))
            {
               currentPlayer = Player.O;
               button3.Enabled = false;
               button3.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button3.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button3);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button7.Enabled == true && ((button1.Text == "O" && button4.Text == "O") || (button8.Text == "O" && button9.Text == "O")))
            {
               currentPlayer = Player.O;
               button7.Enabled = false;
               button7.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button7.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button7);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button1.Enabled == true && ((button4.Text == "O" && button7.Text == "O") || (button3.Text == "O" && button2.Text == "O")))
            {
               currentPlayer = Player.O;
               button1.Enabled = false;
               button1.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button1.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button1);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            else if (button9.Enabled == true && ((button8.Text == "O" && button7.Text == "O") || (button3.Text == "O" && button2.Text == "O")))
            {
               currentPlayer = Player.O;
               button9.Enabled = false;
               button9.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               button9.BackColor = System.Drawing.Color.Green;
               buttons.Remove(button9);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            }
            //ecken vor blockeieren
            else if (button5.Text == "X")
            {
                if (button1.Enabled == true)
               {
                  currentPlayer = Player.O;
                  button1.Enabled = false;
                  button1.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
                  button1.BackColor = System.Drawing.Color.Green;
                  buttons.Remove(button1);
                  AImoves.Stop();//Timer stoppen
                  check();
                  return;
               }
                else if (button7.Enabled == true)
               {
                  currentPlayer = Player.O;
                  button7.Enabled = false;
                  button7.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
                  button7.BackColor = System.Drawing.Color.Green;
                  buttons.Remove(button7);
                  AImoves.Stop();//Timer stoppen
                  check();
                  return;
               }
                else if (button9.Enabled == true)
               {
                  currentPlayer = Player.O;
                  button9.Enabled = false;
                  button9.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
                  button9.BackColor = System.Drawing.Color.Green;
                  buttons.Remove(button9);
                  AImoves.Stop();//Timer stoppen
                  check();
                  return;
               }
                else if (button3.Enabled == true)
               {
                  currentPlayer = Player.O;
                  button3.Enabled = false;
                  button3.Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
                  button3.BackColor = System.Drawing.Color.Green;
                  buttons.Remove(button3);
                  AImoves.Stop();//Timer stoppen
                  check();
                  return;
               }
            }
            else
            {
               int index = rand.Next(buttons.Count);
               buttons[index].Enabled = false; // der zufälliger zahl wird zu den button zugeordnet
               currentPlayer = Player.O;
               buttons[index].Text = currentPlayer.ToString(); // O wird an den buttons an gezeigt ? --> O
               buttons[index].BackColor = System.Drawing.Color.Green;
               buttons.RemoveAt(index);
               AImoves.Stop();//Timer stoppen
               check();
               return;
            } 
         }


      }
      //prüft ob jemand gewonnen hat  (personen)
      private void CheckWinBetweenFriends()
      {
         // wird X gewinnen
         if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
             || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
             || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
             || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
             || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
             || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
             || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
             || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
         {
            MessageBox.Show("Player Wins X");
            playerwins++;
            label1.Text = "Player Wins-" + playerwins;
            resetGame();
         }
         // Wir O gewinnen
         else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                 || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                 || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                 || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                 || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                 || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                 || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                 || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
         {
            MessageBox.Show("Player Wins O");
            computerWins++;
            label2.Text = "Player Wins- " + computerWins;
            resetGame();
         }
         else if (buttons?.Any() == false)
         {
            DialogResult dr = MessageBox.Show("unentschieden, möchten Sie weiter das Spiel anschauen? ", "unentschieden", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {

            }
            if (dr == DialogResult.No)
            {
               resetGame();
            }
         }
      }
   }
}


   



