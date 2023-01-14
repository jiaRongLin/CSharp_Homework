using System.Windows.Forms;

namespace HelloPage
{
	partial class HelloPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloPage));
			this.Parallel = new System.Windows.Forms.SplitContainer();
			this.Vertical = new System.Windows.Forms.SplitContainer();
			this.buttonAlarm = new System.Windows.Forms.Button();
			this.buttonGuess = new System.Windows.Forms.Button();
			this.buttonMyCal = new System.Windows.Forms.Button();
			this.buttonNotepad = new System.Windows.Forms.Button();
			this.buttonMethod = new System.Windows.Forms.Button();
			this.buttonPicture = new System.Windows.Forms.Button();
			this.buttonStructForm = new System.Windows.Forms.Button();
			this.buttonScreen = new System.Windows.Forms.Button();
			this.buttonGradeList = new System.Windows.Forms.Button();
			this.buttonDraw = new System.Windows.Forms.Button();
			this.buttonPos = new System.Windows.Forms.Button();
			this.buttonXOGame = new System.Windows.Forms.Button();
			this.buttonGrade = new System.Windows.Forms.Button();
			this.buttonForDoWhile = new System.Windows.Forms.Button();
			this.buttonLoan = new System.Windows.Forms.Button();
			this.buttonHello = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Parallel)).BeginInit();
			this.Parallel.Panel2.SuspendLayout();
			this.Parallel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Vertical)).BeginInit();
			this.Vertical.Panel1.SuspendLayout();
			this.Vertical.SuspendLayout();
			this.SuspendLayout();
			// 
			// Parallel
			// 
			this.Parallel.BackColor = System.Drawing.Color.Transparent;
			this.Parallel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Parallel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Parallel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.Parallel.Location = new System.Drawing.Point(0, 0);
			this.Parallel.Name = "Parallel";
			this.Parallel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Parallel.Panel1
			// 
			this.Parallel.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Parallel.Panel1.BackgroundImage")));
			this.Parallel.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			// 
			// Parallel.Panel2
			// 
			this.Parallel.Panel2.Controls.Add(this.Vertical);
			this.Parallel.Size = new System.Drawing.Size(928, 442);
			this.Parallel.SplitterDistance = 126;
			this.Parallel.TabIndex = 0;
			// 
			// Vertical
			// 
			this.Vertical.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.Vertical.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Vertical.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.Vertical.Location = new System.Drawing.Point(0, 0);
			this.Vertical.Name = "Vertical";
			// 
			// Vertical.Panel1
			// 
			this.Vertical.Panel1.AutoScroll = true;
			this.Vertical.Panel1.BackgroundImage = global::HelloPage.Properties.Resources.The_Secret_Life_of_Pets_Bunny__3_;
			this.Vertical.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Vertical.Panel1.Controls.Add(this.buttonAlarm);
			this.Vertical.Panel1.Controls.Add(this.buttonGuess);
			this.Vertical.Panel1.Controls.Add(this.buttonMyCal);
			this.Vertical.Panel1.Controls.Add(this.buttonNotepad);
			this.Vertical.Panel1.Controls.Add(this.buttonMethod);
			this.Vertical.Panel1.Controls.Add(this.buttonPicture);
			this.Vertical.Panel1.Controls.Add(this.buttonStructForm);
			this.Vertical.Panel1.Controls.Add(this.buttonScreen);
			this.Vertical.Panel1.Controls.Add(this.buttonGradeList);
			this.Vertical.Panel1.Controls.Add(this.buttonDraw);
			this.Vertical.Panel1.Controls.Add(this.buttonPos);
			this.Vertical.Panel1.Controls.Add(this.buttonXOGame);
			this.Vertical.Panel1.Controls.Add(this.buttonGrade);
			this.Vertical.Panel1.Controls.Add(this.buttonForDoWhile);
			this.Vertical.Panel1.Controls.Add(this.buttonLoan);
			this.Vertical.Panel1.Controls.Add(this.buttonHello);
			// 
			// Vertical.Panel2
			// 
			this.Vertical.Panel2.BackgroundImage = global::HelloPage.Properties.Resources.The_Secret_Life_of_Pets_Bunny__2_;
			this.Vertical.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Vertical.Size = new System.Drawing.Size(928, 312);
			this.Vertical.SplitterDistance = 210;
			this.Vertical.TabIndex = 0;
			// 
			// buttonAlarm
			// 
			this.buttonAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAlarm.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAlarm.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonAlarm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonAlarm.Location = new System.Drawing.Point(29, 698);
			this.buttonAlarm.Name = "buttonAlarm";
			this.buttonAlarm.Size = new System.Drawing.Size(54, 40);
			this.buttonAlarm.TabIndex = 0;
			this.buttonAlarm.Text = "Alarm";
			this.buttonAlarm.UseVisualStyleBackColor = false;
			// 
			// buttonGuess
			// 
			this.buttonGuess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGuess.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonGuess.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGuess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGuess.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonGuess.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonGuess.Location = new System.Drawing.Point(29, 652);
			this.buttonGuess.Name = "buttonGuess";
			this.buttonGuess.Size = new System.Drawing.Size(54, 40);
			this.buttonGuess.TabIndex = 0;
			this.buttonGuess.Text = "Guess";
			this.buttonGuess.UseVisualStyleBackColor = false;
			// 
			// buttonMyCal
			// 
			this.buttonMyCal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMyCal.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonMyCal.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonMyCal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMyCal.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonMyCal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonMyCal.Location = new System.Drawing.Point(29, 331);
			this.buttonMyCal.Name = "buttonMyCal";
			this.buttonMyCal.Size = new System.Drawing.Size(54, 40);
			this.buttonMyCal.TabIndex = 0;
			this.buttonMyCal.Text = "MyCal";
			this.buttonMyCal.UseVisualStyleBackColor = false;
			// 
			// buttonNotepad
			// 
			this.buttonNotepad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonNotepad.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonNotepad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonNotepad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonNotepad.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonNotepad.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonNotepad.Location = new System.Drawing.Point(29, 515);
			this.buttonNotepad.Name = "buttonNotepad";
			this.buttonNotepad.Size = new System.Drawing.Size(54, 40);
			this.buttonNotepad.TabIndex = 0;
			this.buttonNotepad.Text = "Notepad";
			this.buttonNotepad.UseVisualStyleBackColor = false;
			// 
			// buttonMethod
			// 
			this.buttonMethod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMethod.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonMethod.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonMethod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonMethod.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonMethod.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonMethod.Location = new System.Drawing.Point(29, 285);
			this.buttonMethod.Name = "buttonMethod";
			this.buttonMethod.Size = new System.Drawing.Size(54, 40);
			this.buttonMethod.TabIndex = 0;
			this.buttonMethod.Text = "Method";
			this.buttonMethod.UseVisualStyleBackColor = false;
			// 
			// buttonPicture
			// 
			this.buttonPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPicture.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonPicture.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPicture.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonPicture.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonPicture.Location = new System.Drawing.Point(29, 606);
			this.buttonPicture.Name = "buttonPicture";
			this.buttonPicture.Size = new System.Drawing.Size(54, 40);
			this.buttonPicture.TabIndex = 0;
			this.buttonPicture.Text = "Picture Viewer";
			this.buttonPicture.UseVisualStyleBackColor = false;
			// 
			// buttonStructForm
			// 
			this.buttonStructForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonStructForm.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonStructForm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonStructForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonStructForm.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonStructForm.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonStructForm.Location = new System.Drawing.Point(29, 148);
			this.buttonStructForm.Name = "buttonStructForm";
			this.buttonStructForm.Size = new System.Drawing.Size(54, 40);
			this.buttonStructForm.TabIndex = 0;
			this.buttonStructForm.Text = "Student_StructForm";
			this.buttonStructForm.UseVisualStyleBackColor = false;
			// 
			// buttonScreen
			// 
			this.buttonScreen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonScreen.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonScreen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonScreen.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonScreen.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonScreen.Location = new System.Drawing.Point(29, 469);
			this.buttonScreen.Name = "buttonScreen";
			this.buttonScreen.Size = new System.Drawing.Size(54, 40);
			this.buttonScreen.TabIndex = 0;
			this.buttonScreen.Text = "Screen Saver";
			this.buttonScreen.UseVisualStyleBackColor = false;
			// 
			// buttonGradeList
			// 
			this.buttonGradeList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGradeList.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonGradeList.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGradeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGradeList.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonGradeList.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonGradeList.Location = new System.Drawing.Point(29, 239);
			this.buttonGradeList.Name = "buttonGradeList";
			this.buttonGradeList.Size = new System.Drawing.Size(54, 40);
			this.buttonGradeList.TabIndex = 0;
			this.buttonGradeList.Text = "StudentsGrade_List";
			this.buttonGradeList.UseVisualStyleBackColor = false;
			// 
			// buttonDraw
			// 
			this.buttonDraw.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonDraw.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonDraw.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonDraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDraw.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonDraw.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonDraw.Location = new System.Drawing.Point(29, 560);
			this.buttonDraw.Name = "buttonDraw";
			this.buttonDraw.Size = new System.Drawing.Size(54, 40);
			this.buttonDraw.TabIndex = 0;
			this.buttonDraw.Text = "小畫家";
			this.buttonDraw.UseVisualStyleBackColor = false;
			// 
			// buttonPos
			// 
			this.buttonPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonPos.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonPos.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPos.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonPos.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonPos.Location = new System.Drawing.Point(29, 102);
			this.buttonPos.Name = "buttonPos";
			this.buttonPos.Size = new System.Drawing.Size(54, 40);
			this.buttonPos.TabIndex = 0;
			this.buttonPos.Text = "Pos";
			this.buttonPos.UseVisualStyleBackColor = false;
			// 
			// buttonXOGame
			// 
			this.buttonXOGame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonXOGame.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonXOGame.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonXOGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonXOGame.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonXOGame.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonXOGame.Location = new System.Drawing.Point(29, 423);
			this.buttonXOGame.Name = "buttonXOGame";
			this.buttonXOGame.Size = new System.Drawing.Size(54, 40);
			this.buttonXOGame.TabIndex = 0;
			this.buttonXOGame.Text = "XOGame";
			this.buttonXOGame.UseVisualStyleBackColor = false;
			// 
			// buttonGrade
			// 
			this.buttonGrade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonGrade.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonGrade.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonGrade.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonGrade.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonGrade.Location = new System.Drawing.Point(29, 193);
			this.buttonGrade.Name = "buttonGrade";
			this.buttonGrade.Size = new System.Drawing.Size(54, 40);
			this.buttonGrade.TabIndex = 0;
			this.buttonGrade.Text = "StudentsGrade";
			this.buttonGrade.UseVisualStyleBackColor = false;
			// 
			// buttonForDoWhile
			// 
			this.buttonForDoWhile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonForDoWhile.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonForDoWhile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonForDoWhile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonForDoWhile.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonForDoWhile.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonForDoWhile.Location = new System.Drawing.Point(29, 377);
			this.buttonForDoWhile.Name = "buttonForDoWhile";
			this.buttonForDoWhile.Size = new System.Drawing.Size(54, 40);
			this.buttonForDoWhile.TabIndex = 0;
			this.buttonForDoWhile.Text = "ForDoWhile";
			this.buttonForDoWhile.UseVisualStyleBackColor = false;
			// 
			// buttonLoan
			// 
			this.buttonLoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonLoan.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonLoan.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonLoan.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonLoan.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonLoan.Location = new System.Drawing.Point(29, 56);
			this.buttonLoan.Name = "buttonLoan";
			this.buttonLoan.Size = new System.Drawing.Size(54, 40);
			this.buttonLoan.TabIndex = 0;
			this.buttonLoan.Text = "Loan";
			this.buttonLoan.UseVisualStyleBackColor = false;
			// 
			// buttonHello
			// 
			this.buttonHello.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonHello.BackColor = System.Drawing.Color.LemonChiffon;
			this.buttonHello.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonHello.Font = new System.Drawing.Font("微軟正黑體", 8.883117F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.buttonHello.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.buttonHello.Location = new System.Drawing.Point(29, 10);
			this.buttonHello.Name = "buttonHello";
			this.buttonHello.Size = new System.Drawing.Size(54, 40);
			this.buttonHello.TabIndex = 0;
			this.buttonHello.Text = "Hello";
			this.buttonHello.UseVisualStyleBackColor = false;
			// 
			// HelloPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(928, 442);
			this.Controls.Add(this.Parallel);
			this.DoubleBuffered = true;
			this.Name = "HelloPage";
			this.Text = "HelloPage";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Parallel.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Parallel)).EndInit();
			this.Parallel.ResumeLayout(false);
			this.Vertical.Panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Vertical)).EndInit();
			this.Vertical.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer Parallel;
		private System.Windows.Forms.SplitContainer Vertical;
		private Button buttonHello;
		private Button buttonMyCal;
		private Button buttonMethod;
		private Button buttonStructForm;
		private Button buttonGradeList;
		private Button buttonPos;
		private Button buttonGrade;
		private Button buttonLoan;
		private Button buttonAlarm;
		private Button buttonGuess;
		private Button buttonNotepad;
		private Button buttonPicture;
		private Button buttonScreen;
		private Button buttonDraw;
		private Button buttonXOGame;
		private Button buttonForDoWhile;
	}
}