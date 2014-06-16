namespace Jarp.Presentation
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
            this._lblProject = new System.Windows.Forms.Label();
            this._txtBoxRoot = new System.Windows.Forms.TextBox();
            this._btnBrowse = new System.Windows.Forms.Button();
            this._btnRead = new System.Windows.Forms.Button();
            this._lblDestination = new System.Windows.Forms.Label();
            this._txtBoxDestination = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this._listBoxProject = new System.Windows.Forms.ListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // _lblProject
            // 
            this._lblProject.AutoSize = true;
            this._lblProject.Location = new System.Drawing.Point(15, 15);
            this._lblProject.Name = "_lblProject";
            this._lblProject.Size = new System.Drawing.Size(40, 13);
            this._lblProject.TabIndex = 0;
            this._lblProject.Text = "Project";
            // 
            // _txtBoxRoot
            // 
            this._txtBoxRoot.Location = new System.Drawing.Point(81, 12);
            this._txtBoxRoot.Name = "_txtBoxRoot";
            this._txtBoxRoot.Size = new System.Drawing.Size(244, 20);
            this._txtBoxRoot.TabIndex = 1;
            // 
            // _btnBrowse
            // 
            this._btnBrowse.Location = new System.Drawing.Point(331, 12);
            this._btnBrowse.Name = "_btnBrowse";
            this._btnBrowse.Size = new System.Drawing.Size(69, 20);
            this._btnBrowse.TabIndex = 2;
            this._btnBrowse.Text = "Browse";
            this._btnBrowse.UseVisualStyleBackColor = true;
            this._btnBrowse.Click += new System.EventHandler(this.BrowseProject_Click);
            // 
            // _btnRead
            // 
            this._btnRead.Location = new System.Drawing.Point(450, 134);
            this._btnRead.Name = "_btnRead";
            this._btnRead.Size = new System.Drawing.Size(69, 21);
            this._btnRead.TabIndex = 3;
            this._btnRead.Text = "Start";
            this._btnRead.UseVisualStyleBackColor = true;
            this._btnRead.Click += new System.EventHandler(this.ReadProject_Click);
            // 
            // _lblDestination
            // 
            this._lblDestination.AutoSize = true;
            this._lblDestination.Location = new System.Drawing.Point(15, 41);
            this._lblDestination.Name = "_lblDestination";
            this._lblDestination.Size = new System.Drawing.Size(60, 13);
            this._lblDestination.TabIndex = 4;
            this._lblDestination.Text = "Destination";
            // 
            // _txtBoxDestination
            // 
            this._txtBoxDestination.Location = new System.Drawing.Point(81, 38);
            this._txtBoxDestination.Name = "_txtBoxDestination";
            this._txtBoxDestination.Size = new System.Drawing.Size(244, 20);
            this._txtBoxDestination.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Destination";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OutputDestination_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 203);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this._lblProject);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this._txtBoxRoot);
            this.tabPage1.Controls.Add(this._txtBoxDestination);
            this.tabPage1.Controls.Add(this._btnBrowse);
            this.tabPage1.Controls.Add(this._lblDestination);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(525, 177);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this._listBoxProject);
            this.tabPage2.Controls.Add(this._btnRead);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(525, 177);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // _listBoxProject
            // 
            this._listBoxProject.FormattingEnabled = true;
            this._listBoxProject.Location = new System.Drawing.Point(7, 7);
            this._listBoxProject.Name = "_listBoxProject";
            this._listBoxProject.Size = new System.Drawing.Size(512, 121);
            this._listBoxProject.TabIndex = 0;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(8, 216);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(533, 10);
            this.progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 232);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label _lblProject;
        private System.Windows.Forms.TextBox _txtBoxRoot;
        private System.Windows.Forms.Button _btnBrowse;
        private System.Windows.Forms.Button _btnRead;
        private System.Windows.Forms.Label _lblDestination;
        private System.Windows.Forms.TextBox _txtBoxDestination;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox _listBoxProject;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

