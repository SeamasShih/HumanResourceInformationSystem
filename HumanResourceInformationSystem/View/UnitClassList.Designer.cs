namespace HumanResourceInformationSystem.View
{
    partial class UnitClassList
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
            this.labelCampusFilter = new System.Windows.Forms.Label();
            this.comboBoxCampusFilter = new System.Windows.Forms.ComboBox();
            this.classListView = new System.Windows.Forms.ListView();
            this.labelListView = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCampusFilter
            // 
            this.labelCampusFilter.AutoSize = true;
            this.labelCampusFilter.Location = new System.Drawing.Point(26, 13);
            this.labelCampusFilter.Name = "labelCampusFilter";
            this.labelCampusFilter.Size = new System.Drawing.Size(52, 15);
            this.labelCampusFilter.TabIndex = 0;
            this.labelCampusFilter.Text = "Campus";
            // 
            // comboBoxCampusFilter
            // 
            this.comboBoxCampusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampusFilter.FormattingEnabled = true;
            this.comboBoxCampusFilter.Location = new System.Drawing.Point(93, 10);
            this.comboBoxCampusFilter.Name = "comboBoxCampusFilter";
            this.comboBoxCampusFilter.Size = new System.Drawing.Size(121, 23);
            this.comboBoxCampusFilter.TabIndex = 1;
            this.comboBoxCampusFilter.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampusFilter_SelectedIndexChanged);
            // 
            // classListView
            // 
            this.classListView.FullRowSelect = true;
            this.classListView.GridLines = true;
            this.classListView.HideSelection = false;
            this.classListView.Location = new System.Drawing.Point(12, 82);
            this.classListView.Name = "classListView";
            this.classListView.Size = new System.Drawing.Size(545, 337);
            this.classListView.TabIndex = 2;
            this.classListView.UseCompatibleStateImageBehavior = false;
            this.classListView.View = System.Windows.Forms.View.Details;
            // 
            // labelListView
            // 
            this.labelListView.Font = new System.Drawing.Font("Diwani Simple Outline", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelListView.Location = new System.Drawing.Point(196, 45);
            this.labelListView.Name = "labelListView";
            this.labelListView.Size = new System.Drawing.Size(156, 34);
            this.labelListView.TabIndex = 3;
            this.labelListView.Text = "Class List";
            // 
            // UnitClassList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.labelListView);
            this.Controls.Add(this.classListView);
            this.Controls.Add(this.comboBoxCampusFilter);
            this.Controls.Add(this.labelCampusFilter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnitClassList";
            this.Text = "UnitClassList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCampusFilter;
        private System.Windows.Forms.ComboBox comboBoxCampusFilter;
        private System.Windows.Forms.ListView classListView;
        private System.Windows.Forms.Label labelListView;
    }
}