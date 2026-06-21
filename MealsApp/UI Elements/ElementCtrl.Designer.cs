namespace MealsApp.UI
{
	partial class ElementCtrl
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
			this.lblElementName = new System.Windows.Forms.Label();
			this.pbElementPic = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pbElementPic)).BeginInit();
			this.SuspendLayout();
			// 
			// lblElementName
			// 
			this.lblElementName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblElementName.AutoEllipsis = true;
			this.lblElementName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblElementName.Location = new System.Drawing.Point(5, 149);
			this.lblElementName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.lblElementName.Name = "lblElementName";
			this.lblElementName.Size = new System.Drawing.Size(177, 106);
			this.lblElementName.TabIndex = 1;
			this.lblElementName.Text = "Element namejjk";
			this.lblElementName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lblElementName.Click += new System.EventHandler(this.ElementCtrl_Click);
			this.lblElementName.MouseEnter += new System.EventHandler(this.ElementCtrl_MouseEnter);
			this.lblElementName.MouseLeave += new System.EventHandler(this.ElementCtrl_MouseLeave);
			// 
			// pbElementPic
			// 
			this.pbElementPic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbElementPic.Image = global::MealsApp.Properties.Resources.loading;
			this.pbElementPic.Location = new System.Drawing.Point(4, 4);
			this.pbElementPic.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.pbElementPic.Name = "pbElementPic";
			this.pbElementPic.Size = new System.Drawing.Size(178, 141);
			this.pbElementPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbElementPic.TabIndex = 0;
			this.pbElementPic.TabStop = false;
			this.pbElementPic.Click += new System.EventHandler(this.ElementCtrl_Click);
			this.pbElementPic.MouseEnter += new System.EventHandler(this.ElementCtrl_MouseEnter);
			this.pbElementPic.MouseLeave += new System.EventHandler(this.ElementCtrl_MouseLeave);
			// 
			// ElementCtrl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.Controls.Add(this.lblElementName);
			this.Controls.Add(this.pbElementPic);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Margin = new System.Windows.Forms.Padding(13, 4, 5, 4);
			this.Name = "ElementCtrl";
			this.Size = new System.Drawing.Size(187, 255);
			this.Load += new System.EventHandler(this.ElementCtrl_Load);
			this.Click += new System.EventHandler(this.ElementCtrl_Click);
			this.MouseEnter += new System.EventHandler(this.ElementCtrl_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.ElementCtrl_MouseLeave);
			((System.ComponentModel.ISupportInitialize)(this.pbElementPic)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbElementPic;
		private System.Windows.Forms.Label lblElementName;
	}
}
