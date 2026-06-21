using System.Drawing;
using System.Windows.Forms;

namespace MealsApp.UI_Elements
{
	partial class MealDetails
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
			this.flpIngredients = new System.Windows.Forms.FlowLayoutPanel();
			this.lblName = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblInstructions = new System.Windows.Forms.Label();
			this.pbMealThump = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbMealThump)).BeginInit();
			this.SuspendLayout();
			// 
			// flpIngredients
			// 
			this.flpIngredients.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flpIngredients.AutoScroll = true;
			this.flpIngredients.BackColor = System.Drawing.Color.Chocolate;
			this.flpIngredients.Location = new System.Drawing.Point(673, 56);
			this.flpIngredients.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.flpIngredients.Name = "flpIngredients";
			this.flpIngredients.Size = new System.Drawing.Size(675, 197);
			this.flpIngredients.TabIndex = 0;
			// 
			// lblName
			// 
			this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblName.AutoSize = true;
			this.lblName.Location = new System.Drawing.Point(713, 12);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(78, 29);
			this.lblName.TabIndex = 2;
			this.lblName.Text = "Name";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoScroll = true;
			this.panel1.BackColor = System.Drawing.Color.Moccasin;
			this.panel1.Controls.Add(this.lblInstructions);
			this.panel1.Location = new System.Drawing.Point(0, 259);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1337, 398);
			this.panel1.TabIndex = 3;
			// 
			// lblInstructions
			// 
			this.lblInstructions.AutoSize = true;
			this.lblInstructions.Location = new System.Drawing.Point(-2, 0);
			this.lblInstructions.MaximumSize = new System.Drawing.Size(1428, 0);
			this.lblInstructions.Name = "lblInstructions";
			this.lblInstructions.Size = new System.Drawing.Size(0, 29);
			this.lblInstructions.TabIndex = 0;
			// 
			// pbMealThump
			// 
			this.pbMealThump.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pbMealThump.ErrorImage = global::MealsApp.Properties.Resources.no_photos;
			this.pbMealThump.Image = global::MealsApp.Properties.Resources.loading;
			this.pbMealThump.InitialImage = global::MealsApp.Properties.Resources.loading;
			this.pbMealThump.Location = new System.Drawing.Point(0, 56);
			this.pbMealThump.Name = "pbMealThump";
			this.pbMealThump.Size = new System.Drawing.Size(665, 197);
			this.pbMealThump.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pbMealThump.TabIndex = 4;
			this.pbMealThump.TabStop = false;
			// 
			// MealDetails
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Controls.Add(this.pbMealThump);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.flpIngredients);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "MealDetails";
			this.Size = new System.Drawing.Size(1337, 660);
			this.Load += new System.EventHandler(this.MealDetails_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbMealThump)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpIngredients;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lblInstructions;
		private System.Windows.Forms.PictureBox pbMealThump;
	}
}
