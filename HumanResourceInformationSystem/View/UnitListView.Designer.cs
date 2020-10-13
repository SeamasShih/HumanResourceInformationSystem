namespace HumanResourceInformationSystem.View
{
    partial class UnitListView
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
            this.textSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.listUnit = new System.Windows.Forms.ListView();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(144, 12);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(125, 25);
            this.textSearch.TabIndex = 0;
            this.textSearch.TextChanged += new System.EventHandler(this.textSearch_TextChanged);
            this.textSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textSearch_KeyDown);
            // 
            // labelSearch
            // 
            this.labelSearch.Font = new System.Drawing.Font("PMingLiU", 12F);
            this.labelSearch.Location = new System.Drawing.Point(49, 12);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(89, 25);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Search by:";
            this.labelSearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(275, 11);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("PT Separated Baloon", 12F);
            this.labelTitle.Location = new System.Drawing.Point(111, 61);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(121, 36);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Unit List";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listUnit
            // 
            this.listUnit.HideSelection = false;
            this.listUnit.Location = new System.Drawing.Point(27, 110);
            this.listUnit.Name = "listUnit";
            this.listUnit.Size = new System.Drawing.Size(295, 345);
            this.listUnit.TabIndex = 4;
            this.listUnit.UseCompatibleStateImageBehavior = false;
            this.listUnit.View = System.Windows.Forms.View.List;
            this.listUnit.SelectedIndexChanged += new System.EventHandler(this.listUnit_SelectedIndexChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 11);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(31, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "<";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // UnitListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 484);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.listUnit);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.textSearch);
            this.Name = "UnitListView";
            this.Text = "UnitListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListView listUnit;
        private System.Windows.Forms.Button buttonBack;
    }
}