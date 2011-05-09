namespace DotTouch
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtCreation = new System.Windows.Forms.DateTimePicker();
            this.dtModification = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtLastAccess = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.grpFiles = new System.Windows.Forms.GroupBox();
            this.dropPanel = new System.Windows.Forms.Panel();
            this.grpFiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Creation Date";
            // 
            // dtCreation
            // 
            this.dtCreation.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtCreation.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtCreation.Location = new System.Drawing.Point(92, 8);
            this.dtCreation.Name = "dtCreation";
            this.dtCreation.ShowCheckBox = true;
            this.dtCreation.Size = new System.Drawing.Size(161, 20);
            this.dtCreation.TabIndex = 1;
            // 
            // dtModification
            // 
            this.dtModification.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtModification.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtModification.Location = new System.Drawing.Point(92, 34);
            this.dtModification.Name = "dtModification";
            this.dtModification.ShowCheckBox = true;
            this.dtModification.Size = new System.Drawing.Size(161, 20);
            this.dtModification.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modified Date";
            // 
            // dtLastAccess
            // 
            this.dtLastAccess.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtLastAccess.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLastAccess.Location = new System.Drawing.Point(92, 60);
            this.dtLastAccess.Name = "dtLastAccess";
            this.dtLastAccess.ShowCheckBox = true;
            this.dtLastAccess.Size = new System.Drawing.Size(161, 20);
            this.dtLastAccess.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last access";
            // 
            // grpFiles
            // 
            this.grpFiles.Controls.Add(this.dropPanel);
            this.grpFiles.Location = new System.Drawing.Point(259, 8);
            this.grpFiles.Name = "grpFiles";
            this.grpFiles.Size = new System.Drawing.Size(91, 72);
            this.grpFiles.TabIndex = 7;
            this.grpFiles.TabStop = false;
            this.grpFiles.Text = "Drop files here";
            // 
            // dropPanel
            // 
            this.dropPanel.AllowDrop = true;
            this.dropPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropPanel.ForeColor = System.Drawing.Color.Transparent;
            this.dropPanel.Location = new System.Drawing.Point(3, 16);
            this.dropPanel.Name = "dropPanel";
            this.dropPanel.Size = new System.Drawing.Size(85, 53);
            this.dropPanel.TabIndex = 0;
            this.dropPanel.DragOver += new System.Windows.Forms.DragEventHandler(this.panel1_DragOver);
            this.dropPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 89);
            this.Controls.Add(this.grpFiles);
            this.Controls.Add(this.dtLastAccess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtModification);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtCreation);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = ".Touch";
            this.grpFiles.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtCreation;
        private System.Windows.Forms.DateTimePicker dtModification;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtLastAccess;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpFiles;
        private System.Windows.Forms.Panel dropPanel;
    }
}

