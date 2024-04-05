using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace TicTacToe
{

   public partial class SettingsForm : Form
   {
      public bool gamemode = false;
      public SettingsForm()
      {
         InitializeComponent();


      }

      private void SettingsForm_Load(object sender, EventArgs e)
      {

      }

      public void normal(object sender, EventArgs e)
      {
         GameForm from = new GameForm(1);
         from.Show();
      }

      public void unmöglich(object sender, EventArgs e)
      {
         GameForm from = new GameForm(2);
         from.Show();
      }

      public void mit_Freund(object sender, EventArgs e)
      {
         EnterPlayerNames from = new EnterPlayerNames();
         from.Show();
      }
   }
}
