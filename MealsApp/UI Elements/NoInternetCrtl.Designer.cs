namespace MealsApp.UI_Elements
{
	partial class NoInternetCrtl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnRetry = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRetry
			// 
			this.btnRetry.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.btnRetry.BackColor = System.Drawing.Color.Chocolate;
			this.btnRetry.Location = new System.Drawing.Point(33, 283);
			this.btnRetry.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.btnRetry.Name = "btnRetry";
			this.btnRetry.Size = new System.Drawing.Size(261, 43);
			this.btnRetry.TabIndex = 8;
			this.btnRetry.Text = "Retry";
			this.btnRetry.UseVisualStyleBackColor = false;
			this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureBox1.Image = global::MealsApp.Properties.Resources.sad_face_cloud_icon_no_internet_connection_free_vector;
			this.pictureBox1.Location = new System.Drawing.Point(32, 49);
			this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(262, 226);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(71, 16);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(185, 29);
			this.label1.TabIndex = 10;
			this.label1.Text = "No Connection !";
			// 
			// NoInternetCrtl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnRetry);
			this.Controls.Add(this.pictureBox1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "NoInternetCrtl";
			this.Size = new System.Drawing.Size(326, 339);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRetry;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label1;
	}
}
