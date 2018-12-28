namespace WindowsFormsExterminator
{
	partial class FormParking
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
			this.pictureBoxParking = new System.Windows.Forms.PictureBox();
			this.buttonGetSimpleplane = new System.Windows.Forms.Button();
			this.buttonGetExterminator = new System.Windows.Forms.Button();
			this.groupBoxParking = new System.Windows.Forms.GroupBox();
			this.pictureBoxLittle = new System.Windows.Forms.PictureBox();
			this.buttonGetOut = new System.Windows.Forms.Button();
			this.maskedTextBoxParknig = new System.Windows.Forms.MaskedTextBox();
			this.labelPlace = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
			this.groupBoxParking.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLittle)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBoxParking
			// 
			this.pictureBoxParking.Location = new System.Drawing.Point(1, 2);
			this.pictureBoxParking.Name = "pictureBoxParking";
			this.pictureBoxParking.Size = new System.Drawing.Size(1011, 445);
			this.pictureBoxParking.TabIndex = 0;
			this.pictureBoxParking.TabStop = false;
			// 
			// buttonGetSimpleplane
			// 
			this.buttonGetSimpleplane.Location = new System.Drawing.Point(1046, 12);
			this.buttonGetSimpleplane.Name = "buttonGetSimpleplane";
			this.buttonGetSimpleplane.Size = new System.Drawing.Size(170, 50);
			this.buttonGetSimpleplane.TabIndex = 1;
			this.buttonGetSimpleplane.Text = "Припарковать обычный самолет";
			this.buttonGetSimpleplane.UseVisualStyleBackColor = true;
			this.buttonGetSimpleplane.Click += new System.EventHandler(this.buttonGetSimpleplane_Click);
			// 
			// buttonGetExterminator
			// 
			this.buttonGetExterminator.Location = new System.Drawing.Point(1046, 68);
			this.buttonGetExterminator.Name = "buttonGetExterminator";
			this.buttonGetExterminator.Size = new System.Drawing.Size(170, 45);
			this.buttonGetExterminator.TabIndex = 2;
			this.buttonGetExterminator.Text = "Припарковать истребитель";
			this.buttonGetExterminator.UseVisualStyleBackColor = true;
			this.buttonGetExterminator.Click += new System.EventHandler(this.buttonGetExterminator_Click);
			// 
			// groupBoxParking
			// 
			this.groupBoxParking.Controls.Add(this.pictureBoxLittle);
			this.groupBoxParking.Controls.Add(this.buttonGetOut);
			this.groupBoxParking.Controls.Add(this.maskedTextBoxParknig);
			this.groupBoxParking.Controls.Add(this.labelPlace);
			this.groupBoxParking.Location = new System.Drawing.Point(1046, 265);
			this.groupBoxParking.Name = "groupBoxParking";
			this.groupBoxParking.Size = new System.Drawing.Size(170, 174);
			this.groupBoxParking.TabIndex = 3;
			this.groupBoxParking.TabStop = false;
			this.groupBoxParking.Text = "Забрать самолет";
			// 
			// pictureBoxLittle
			// 
			this.pictureBoxLittle.Location = new System.Drawing.Point(0, 75);
			this.pictureBoxLittle.Name = "pictureBoxLittle";
			this.pictureBoxLittle.Size = new System.Drawing.Size(164, 93);
			this.pictureBoxLittle.TabIndex = 3;
			this.pictureBoxLittle.TabStop = false;
			// 
			// buttonGetOut
			// 
			this.buttonGetOut.Location = new System.Drawing.Point(0, 46);
			this.buttonGetOut.Name = "buttonGetOut";
			this.buttonGetOut.Size = new System.Drawing.Size(164, 23);
			this.buttonGetOut.TabIndex = 2;
			this.buttonGetOut.Text = "Забрать";
			this.buttonGetOut.UseVisualStyleBackColor = true;
			this.buttonGetOut.Click += new System.EventHandler(this.buttonGetOut_Click);
			// 
			// maskedTextBoxParknig
			// 
			this.maskedTextBoxParknig.Location = new System.Drawing.Point(53, 20);
			this.maskedTextBoxParknig.Name = "maskedTextBoxParknig";
			this.maskedTextBoxParknig.Size = new System.Drawing.Size(111, 20);
			this.maskedTextBoxParknig.TabIndex = 1;
			// 
			// labelPlace
			// 
			this.labelPlace.AutoSize = true;
			this.labelPlace.Location = new System.Drawing.Point(7, 20);
			this.labelPlace.Name = "labelPlace";
			this.labelPlace.Size = new System.Drawing.Size(39, 13);
			this.labelPlace.TabIndex = 0;
			this.labelPlace.Text = "Место";
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1264, 612);
			this.Controls.Add(this.groupBoxParking);
			this.Controls.Add(this.buttonGetExterminator);
			this.Controls.Add(this.buttonGetSimpleplane);
			this.Controls.Add(this.pictureBoxParking);
			this.Name = "FormParking";
			this.Text = "FormParking";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
			this.groupBoxParking.ResumeLayout(false);
			this.groupBoxParking.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLittle)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.Button buttonGetSimpleplane;
		private System.Windows.Forms.Button buttonGetExterminator;
		private System.Windows.Forms.GroupBox groupBoxParking;
		private System.Windows.Forms.Label labelPlace;
		private System.Windows.Forms.PictureBox pictureBoxLittle;
		private System.Windows.Forms.Button buttonGetOut;
		private System.Windows.Forms.MaskedTextBox maskedTextBoxParknig;
	}
}