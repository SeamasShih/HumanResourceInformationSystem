﻿namespace HumanResourceInformationSystem.View
{
    partial class MainView
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
            this.tabPageUnits = new System.Windows.Forms.TabPage();
            this.UnitsplitContainer = new System.Windows.Forms.SplitContainer();
            this.tabPageStaff = new System.Windows.Forms.TabPage();
            this.staffSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabPageUnits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnitsplitContainer)).BeginInit();
            this.UnitsplitContainer.SuspendLayout();
            this.tabPageStaff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffSplitContainer)).BeginInit();
            this.staffSplitContainer.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageUnits
            // 
            this.tabPageUnits.Controls.Add(this.UnitsplitContainer);
            this.tabPageUnits.Location = new System.Drawing.Point(4, 25);
            this.tabPageUnits.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageUnits.Name = "tabPageUnits";
            this.tabPageUnits.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageUnits.Size = new System.Drawing.Size(1057, 496);
            this.tabPageUnits.TabIndex = 1;
            this.tabPageUnits.Text = "Units";
            this.tabPageUnits.UseVisualStyleBackColor = true;
            // 
            // UnitsplitContainer
            // 
            this.UnitsplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UnitsplitContainer.Location = new System.Drawing.Point(4, 3);
            this.UnitsplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UnitsplitContainer.Name = "UnitsplitContainer";
            this.UnitsplitContainer.Size = new System.Drawing.Size(1049, 490);
            this.UnitsplitContainer.SplitterDistance = 439;
            this.UnitsplitContainer.SplitterWidth = 5;
            this.UnitsplitContainer.TabIndex = 0;
            // 
            // tabPageStaff
            // 
            this.tabPageStaff.Controls.Add(this.staffSplitContainer);
            this.tabPageStaff.Location = new System.Drawing.Point(4, 25);
            this.tabPageStaff.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageStaff.Name = "tabPageStaff";
            this.tabPageStaff.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageStaff.Size = new System.Drawing.Size(1057, 496);
            this.tabPageStaff.TabIndex = 0;
            this.tabPageStaff.Text = "Staff";
            this.tabPageStaff.UseVisualStyleBackColor = true;
            // 
            // staffSplitContainer
            // 
            this.staffSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffSplitContainer.Location = new System.Drawing.Point(4, 3);
            this.staffSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.staffSplitContainer.Name = "staffSplitContainer";
            this.staffSplitContainer.Size = new System.Drawing.Size(1049, 490);
            this.staffSplitContainer.SplitterDistance = 323;
            this.staffSplitContainer.SplitterWidth = 5;
            this.staffSplitContainer.TabIndex = 0;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabPageStaff);
            this.mainTabControl.Controls.Add(this.tabPageUnits);
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1065, 525);
            this.mainTabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mainTabControl.TabIndex = 0;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 519);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainView";
            this.Text = "MainView";
            this.tabPageUnits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnitsplitContainer)).EndInit();
            this.UnitsplitContainer.ResumeLayout(false);
            this.tabPageStaff.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.staffSplitContainer)).EndInit();
            this.staffSplitContainer.ResumeLayout(false);
            this.mainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageUnits;
        private System.Windows.Forms.TabPage tabPageStaff;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.SplitContainer UnitsplitContainer;
        private System.Windows.Forms.SplitContainer staffSplitContainer;
    }
}