
namespace TicTacToe
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         components = new System.ComponentModel.Container();
         label1 = new Label();
         label2 = new Label();
         button1 = new Button();
         button2 = new Button();
         button3 = new Button();
         button4 = new Button();
         button5 = new Button();
         button6 = new Button();
         button7 = new Button();
         button8 = new Button();
         button9 = new Button();
         button10 = new Button();
         AImoves_hard = new System.Windows.Forms.Timer(components);
         AImoves_normal = new System.Windows.Forms.Timer(components);
         label3 = new Label();
         label4 = new Label();
         SuspendLayout();
         // 
         // label1
         // 
         label1.AccessibleDescription = "";
         label1.AccessibleName = "";
         label1.AutoSize = true;
         label1.ForeColor = Color.Blue;
         label1.Location = new Point(69, 75);
         label1.Margin = new Padding(4, 0, 4, 0);
         label1.Name = "label1";
         label1.Size = new Size(68, 20);
         label1.TabIndex = 9;
         label1.Text = "Player1\r\n";
         // 
         // label2
         // 
         label2.AutoSize = true;
         label2.ForeColor = Color.Green;
         label2.Location = new Point(381, 75);
         label2.Margin = new Padding(4, 0, 4, 0);
         label2.Name = "label2";
         label2.Size = new Size(68, 20);
         label2.TabIndex = 10;
         label2.Text = "Player2";
         // 
         // button1
         // 
         button1.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
         button1.Location = new Point(41, 141);
         button1.Name = "button1";
         button1.Size = new Size(150, 140);
         button1.TabIndex = 11;
         button1.Tag = "play";
         button1.Text = "?";
         button1.UseVisualStyleBackColor = true;
         button1.Click += playerClick;
         // 
         // button2
         // 
         button2.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
         button2.Location = new Point(41, 286);
         button2.Name = "button2";
         button2.Size = new Size(150, 140);
         button2.TabIndex = 12;
         button2.Tag = "play";
         button2.Text = "?";
         button2.UseVisualStyleBackColor = true;
         button2.Click += playerClick;
         // 
         // button3
         // 
         button3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
         button3.Location = new Point(41, 432);
         button3.Name = "button3";
         button3.Size = new Size(150, 140);
         button3.TabIndex = 13;
         button3.Tag = "play";
         button3.Text = "?";
         button3.UseVisualStyleBackColor = true;
         button3.Click += playerClick;
         // 
         // button4
         // 
         button4.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
         button4.Location = new Point(197, 141);
         button4.Name = "button4";
         button4.Size = new Size(150, 140);
         button4.TabIndex = 14;
         button4.Tag = "play";
         button4.Text = "?";
         button4.UseVisualStyleBackColor = true;
         button4.Click += playerClick;
         // 
         // button5
         // 
         button5.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
         button5.Location = new Point(197, 286);
         button5.Name = "button5";
         button5.Size = new Size(150, 140);
         button5.TabIndex = 15;
         button5.Tag = "play";
         button5.Text = "?";
         button5.UseVisualStyleBackColor = true;
         button5.Click += playerClick;
         // 
         // button6
         // 
         button6.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
         button6.Location = new Point(197, 432);
         button6.Name = "button6";
         button6.Size = new Size(150, 140);
         button6.TabIndex = 16;
         button6.Tag = "play";
         button6.Text = "?";
         button6.UseVisualStyleBackColor = true;
         button6.Click += playerClick;
         // 
         // button7
         // 
         button7.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
         button7.Location = new Point(353, 141);
         button7.Name = "button7";
         button7.Size = new Size(150, 140);
         button7.TabIndex = 17;
         button7.Tag = "play";
         button7.Text = "?";
         button7.UseVisualStyleBackColor = true;
         button7.Click += playerClick;
         // 
         // button8
         // 
         button8.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
         button8.Location = new Point(353, 286);
         button8.Name = "button8";
         button8.Size = new Size(150, 140);
         button8.TabIndex = 18;
         button8.Tag = "play";
         button8.Text = "?";
         button8.UseVisualStyleBackColor = true;
         button8.Click += playerClick;
         // 
         // button9
         // 
         button9.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold);
         button9.Location = new Point(353, 432);
         button9.Name = "button9";
         button9.Size = new Size(150, 140);
         button9.TabIndex = 19;
         button9.Tag = "play";
         button9.Text = "?";
         button9.UseVisualStyleBackColor = true;
         button9.Click += playerClick;
         // 
         // button10
         // 
         button10.Location = new Point(213, 578);
         button10.Name = "button10";
         button10.Size = new Size(112, 50);
         button10.TabIndex = 20;
         button10.Text = "Restart";
         button10.UseVisualStyleBackColor = true;
         button10.Click += restartGame;
         // 
         // AImoves_hard
         // 
         AImoves_hard.Interval = 1;
         AImoves_hard.Tick += AImoveimapassible;
         // 
         // AImoves_normal
         // 
         AImoves_normal.Interval = 1;
         AImoves_normal.Tick += AImoveNormal;
         // 
         // label3
         // 
         label3.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label3.ForeColor = Color.Blue;
         label3.Location = new Point(69, 22);
         label3.Name = "label3";
         label3.Size = new Size(34, 40);
         label3.TabIndex = 21;
         label3.Text = "X";
         // 
         // label4
         // 
         label4.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
         label4.ForeColor = Color.Green;
         label4.Location = new Point(381, 22);
         label4.Name = "label4";
         label4.Size = new Size(41, 40);
         label4.TabIndex = 22;
         label4.Text = "O";
         // 
         // GameForm
         // 
         AutoScaleDimensions = new SizeF(10F, 20F);
         AutoScaleMode = AutoScaleMode.Font;
         ClientSize = new Size(543, 674);
         Controls.Add(label4);
         Controls.Add(label3);
         Controls.Add(button10);
         Controls.Add(button9);
         Controls.Add(button8);
         Controls.Add(button7);
         Controls.Add(button6);
         Controls.Add(button5);
         Controls.Add(button4);
         Controls.Add(button3);
         Controls.Add(button2);
         Controls.Add(button1);
         Controls.Add(label2);
         Controls.Add(label1);
         Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
         Margin = new Padding(4);
         Name = "GameForm";
         Tag = "Play";
         Text = "TicTactoe";
         Load += Form1_Load;
         ResumeLayout(false);
         PerformLayout();
      }

      private void Form1_Load(object sender, EventArgs e)
        {
            
        }



        #endregion
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private System.Windows.Forms.Timer AImoves_hard;
      private System.Windows.Forms.Timer AImoves_normal;
      private Label label3;
      private Label label4;
   }
}
