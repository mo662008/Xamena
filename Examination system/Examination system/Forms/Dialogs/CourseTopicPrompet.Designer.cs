namespace Examination_system.Forms.Dialogs
{
	partial class CourseTopicPrompet
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
			this.Select = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.CoursesCombo = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// Select
			// 
			this.Select.Location = new System.Drawing.Point(65, 69);
			this.Select.Name = "Select";
			this.Select.Size = new System.Drawing.Size(75, 23);
			this.Select.TabIndex = 8;
			this.Select.Text = "Select";
			this.Select.UseVisualStyleBackColor = true;
			this.Select.Click += new System.EventHandler(this.Select_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(46, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(113, 20);
			this.label1.TabIndex = 7;
			this.label1.Text = "Select Course:";
			// 
			// CoursesCombo
			// 
			this.CoursesCombo.FormattingEnabled = true;
			this.CoursesCombo.Location = new System.Drawing.Point(11, 37);
			this.CoursesCombo.Name = "CoursesCombo";
			this.CoursesCombo.Size = new System.Drawing.Size(183, 21);
			this.CoursesCombo.TabIndex = 6;
			// 
			// CourseTopicPrompet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(207, 104);
			this.Controls.Add(this.Select);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CoursesCombo);
			this.Name = "CourseTopicPrompet";
			this.Text = "CourseTopicPrompet";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Select;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox CoursesCombo;
	}
}