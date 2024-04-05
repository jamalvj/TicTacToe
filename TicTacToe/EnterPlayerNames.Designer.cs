namespace TicTacToe
{
   partial class EnterPlayerNames
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         textBox_player1 = new TextBox();
         label1 = new Label();
         label2 = new Label();
         label3 = new Label();
         textBox_player2 = new TextBox();
         button_names_entered = new Button();
         SuspendLayout();
         // 
         // textBox_player1
         // 
         textBox_player1.Location = new Point(196, 91);
         textBox_player1.Name = "textBox_player1";
         textBox_player1.Size = new Size(316, 39);
         textBox_player1.TabIndex = 0;
         // 
         // label1
         // 
         label1.AutoSize = true;
         label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label1.Location = new Point(12, 9);
         label1.Name = "label1";
         label1.Size = new Size(694, 37);
         label1.TabIndex = 2;
         label1.Text = "Bitte geben Sie die Namen von den Spielern!";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label2.Location = new Point(21, 93);
         label2.Name = "label2";
         label2.Size = new Size(169, 37);
         label2.TabIndex = 3;
         label2.Text = "Spieler 1 :";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label3.Location = new Point(21, 202);
         label3.Name = "label3";
         label3.Size = new Size(171, 37);
         label3.TabIndex = 4;
         label3.Text = "Spieler 2 :";
         // 
         // textBox_player2
         // 
         textBox_player2.Location = new Point(196, 200);
         textBox_player2.Name = "textBox_player2";
         textBox_player2.Size = new Size(316, 39);
         textBox_player2.TabIndex = 5;
         // 
         // button_names_entered
         // 
         button_names_entered.BackColor = SystemColors.ButtonHighlight;
         button_names_entered.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
         button_names_entered.ForeColor = SystemColors.ControlText;
         button_names_entered.Location = new Point(529, 254);
         button_names_entered.Name = "button_names_entered";
         button_names_entered.Size = new Size(169, 46);
         button_names_entered.TabIndex = 6;
         button_names_entered.Text = "OK";
         button_names_entered.UseVisualStyleBackColor = false;
         button_names_entered.Click += button_names_entered_Click;
         // 
         // EnterPlayerNames
         // 
         AutoScaleDimensions = new SizeF(13F, 32F);
         AutoScaleMode = AutoScaleMode.Font;
         BackColor = SystemColors.GradientInactiveCaption;
         ClientSize = new Size(710, 312);
         Controls.Add(button_names_entered);
         Controls.Add(textBox_player2);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(label1);
         Controls.Add(textBox_player1);
         ForeColor = SystemColors.ActiveCaptionText;
         Name = "EnterPlayerNames";
         Text = "EnterPlayerNames";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private TextBox textBox_player1;
      private Label label1;
      private Label label2;
      private Label label3;
      private TextBox textBox_player2;
      private Button button_names_entered;
   }
}