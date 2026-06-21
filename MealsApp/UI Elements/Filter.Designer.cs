namespace MealsApp
{
	partial class Filter
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
			this.cbSearchBy = new System.Windows.Forms.ComboBox();
			this.tbSearch = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// cbSearchBy
			// 
			this.cbSearchBy.BackColor = System.Drawing.Color.SandyBrown;
			this.cbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSearchBy.FormattingEnabled = true;
			this.cbSearchBy.Items.AddRange(new object[] {
            "Name"});
			this.cbSearchBy.Location = new System.Drawing.Point(5, 4);
			this.cbSearchBy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.cbSearchBy.Name = "cbSearchBy";
			this.cbSearchBy.Size = new System.Drawing.Size(277, 37);
			this.cbSearchBy.TabIndex = 1;
			// 
			// tbSearch
			// 
			this.tbSearch.Location = new System.Drawing.Point(292, 6);
			this.tbSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.tbSearch.MaxLength = 20;
			this.tbSearch.Name = "tbSearch";
			this.tbSearch.Size = new System.Drawing.Size(310, 35);
			this.tbSearch.TabIndex = 0;
			this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
			this.tbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbSearch_KeyPress);
			// 
			// Filter
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tbSearch);
			this.Controls.Add(this.cbSearchBy);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
			this.Name = "Filter";
			this.Size = new System.Drawing.Size(607, 46);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbSearchBy;
		private System.Windows.Forms.TextBox tbSearch;
	}
}
