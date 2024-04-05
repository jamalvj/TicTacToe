namespace TicTacToe
{
   partial class SettingsForm
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
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         button1 = new Button();
         button2 = new Button();
         button3 = new Button();
         label1 = new Label();
         label2 = new Label();
         label3 = new Label();
         label4 = new Label();
         label5 = new Label();
         SuspendLayout();
         // 
         // button1
         // 
         button1.BackColor = Color.FromArgb(192, 255, 192);
         button1.Font = new Font("Microsoft Sans Serif", 12F);
         button1.ForeColor = Color.Black;
         button1.Location = new Point(285, 250);
         button1.Margin = new Padding(5, 6, 5, 6);
         button1.Name = "button1";
         button1.Size = new Size(233, 102);
         button1.TabIndex = 0;
         button1.Text = "Normal";
         button1.UseVisualStyleBackColor = false;
         button1.Click += normal;
         // 
         // button2
         // 
         button2.BackColor = Color.FromArgb(255, 255, 128);
         button2.Font = new Font("Microsoft Sans Serif", 12F);
         button2.Location = new Point(285, 440);
         button2.Margin = new Padding(5, 6, 5, 6);
         button2.Name = "button2";
         button2.Size = new Size(233, 102);
         button2.TabIndex = 1;
         button2.Text = "Unmöglich";
         button2.UseVisualStyleBackColor = false;
         button2.Click += unmöglich;
         // 
         // button3
         // 
         button3.BackColor = Color.Red;
         button3.Font = new Font("Microsoft Sans Serif", 12F);
         button3.ForeColor = Color.Black;
         button3.Location = new Point(285, 630);
         button3.Margin = new Padding(5, 6, 5, 6);
         button3.Name = "button3";
         button3.Size = new Size(233, 100);
         button3.TabIndex = 2;
         button3.Text = "Mit Freund";
         button3.UseVisualStyleBackColor = false;
         button3.Click += mit_Freund;
         // 
         // label1
         // 
         label1.Location = new Point(0, 0);
         label1.Margin = new Padding(5, 0, 5, 0);
         label1.Name = "label1";
         label1.Size = new Size(171, 46);
         label1.TabIndex = 0;
         // 
         // label2
         // 
         label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label2.Location = new Point(285, 127);
         label2.Margin = new Padding(5, 0, 5, 0);
         label2.Name = "label2";
         label2.Size = new Size(233, 70);
         label2.TabIndex = 3;
         label2.Text = "Wie möchten Sie spielen?";
         // 
         // label3
         // 
         label3.AutoSize = true;
         label3.Font = new Font("Microsoft Sans Serif", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label3.Location = new Point(215, 276);
         label3.Name = "label3";
         label3.Size = new Size(62, 42);
         label3.TabIndex = 4;
         label3.Text = "😊";
         // 
         // label4
         // 
         label4.AutoSize = true;
         label4.Font = new Font("Microsoft Sans Serif", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label4.Location = new Point(215, 466);
         label4.Name = "label4";
         label4.Size = new Size(62, 42);
         label4.TabIndex = 5;
         label4.Text = "☠";
         // 
         // label5
         // 
         label5.AutoSize = true;
         label5.Font = new Font("Microsoft Sans Serif", 15.8571434F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label5.Location = new Point(215, 655);
         label5.Name = "label5";
         label5.Size = new Size(59, 42);
         label5.TabIndex = 6;
         label5.Text = "👱‍♂️";
         // 
         // SettingsForm
         // 
         AutoScaleDimensions = new SizeF(12F, 30F);
         AutoScaleMode = AutoScaleMode.Font;
         AutoSize = true;
         ClientSize = new Size(790, 900);
         Controls.Add(label5);
         Controls.Add(label4);
         Controls.Add(label3);
         Controls.Add(label2);
         Controls.Add(label1);
         Controls.Add(button3);
         Controls.Add(button2);
         Controls.Add(button1);
         Margin = new Padding(5, 6, 5, 6);
         Name = "SettingsForm";
         Text = "tictactoe";
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private Button button1;
      private Button button2;
      private Button button3;
      private Label label1;
      private Label label2;
      private Label label3;
      private Label label4;
      private Label label5;
   }
}