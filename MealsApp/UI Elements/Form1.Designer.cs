namespace MealsApp
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.lblTitle = new System.Windows.Forms.Label();
			this.ElementsPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.btnBack = new System.Windows.Forms.Button();
			this.pbTitle = new System.Windows.Forms.PictureBox();
			this.filter = new MealsApp.Filter();
			((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
			this.SuspendLayout();
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(-13, 84);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(507, 108);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Categories";
			this.lblTitle.SizeChanged += new System.EventHandler(this.lblTitle_SizeChanged);
			// 
			// ElementsPanel
			// 
			this.ElementsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ElementsPanel.AutoScroll = true;
			this.ElementsPanel.Location = new System.Drawing.Point(5, 294);
			this.ElementsPanel.Name = "ElementsPanel";
			this.ElementsPanel.Size = new System.Drawing.Size(1333, 365);
			this.ElementsPanel.TabIndex = 5;
			// 
			// btnBack
			// 
			this.btnBack.BackColor = System.Drawing.Color.SandyBrown;
			this.btnBack.BackgroundImage = global::MealsApp.Properties.Resources.arrow;
			this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBack.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBack.Location = new System.Drawing.Point(5, 5);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(83, 41);
			this.btnBack.TabIndex = 4;
			this.btnBack.UseVisualStyleBackColor = false;
			this.btnBack.Visible = false;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// pbTitle
			// 
			this.pbTitle.Image = global::MealsApp.Properties.Resources.main_dish;
			this.pbTitle.Location = new System.Drawing.Point(473, 60);
			this.pbTitle.Name = "pbTitle";
			this.pbTitle.Size = new System.Drawing.Size(175, 149);
			this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTitle.TabIndex = 3;
			this.pbTitle.TabStop = false;
			// 
			// filter
			// 
			this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.filter.Location = new System.Drawing.Point(1, 241);
			this.filter.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.filter.Name = "filter";
			this.filter.Size = new System.Drawing.Size(688, 46);
			this.filter.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Moccasin;
			this.CancelButton = this.btnBack;
			this.ClientSize = new System.Drawing.Size(1335, 656);
			this.Controls.Add(this.ElementsPanel);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.pbTitle);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.filter);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Meals App";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.Form1_LoadAsync);
			((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Filter filter;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.PictureBox pbTitle;
		private System.Windows.Forms.Button btnBack;
		private System.Windows.Forms.FlowLayoutPanel ElementsPanel;
	}
}

