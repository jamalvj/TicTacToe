using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
   public partial class EnterPlayerNames : Form
   {
      public EnterPlayerNames()
      {
         InitializeComponent();
      }

      private void button_names_entered_Click(object sender, EventArgs e)
      {
         this.Close();
         GameForm from = new GameForm(3, textBox_player1.Text, textBox_player2.Text);
         from.Show();

      }
   }
}
