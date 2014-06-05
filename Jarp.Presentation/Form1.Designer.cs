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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this._btnBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _lblProject
            // 
            this._lblProject.AutoSize = true;
            this._lblProject.Location = new System.Drawing.Point(9, 17);
            this._lblProject.Name = "_lblProject";
            this._lblProject.Size = new System.Drawing.Size(40, 13);
            this._lblProject.TabIndex = 0;
            this._lblProject.Text = "Project";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(55, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(124, 20);
            this.textBox1.TabIndex = 1;
            // 
            // _btnBrowse
            // 
            this._btnBrowse.Location = new System.Drawing.Point(185, 13);
            this._btnBrowse.Name = "_btnBrowse";
            this._btnBrowse.Size = new System.Drawing.Size(58, 20);
            this._btnBrowse.TabIndex = 2;
            this._btnBrowse.Text = "Browse";
            this._btnBrowse.UseVisualStyleBackColor = true;
            this._btnBrowse.Click += new System.EventHandler(this._btnBrowse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 73);
            this.Controls.Add(this._btnBrowse);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this._lblProject);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblProject;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button _btnBrowse;
    }
}

