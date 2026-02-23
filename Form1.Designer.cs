namespace mp4ClipCutter
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
            this.fileDialog = new System.Windows.Forms.OpenFileDialog();
            this.chooseFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.resolutionChange = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.resDropDown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chooseFile
            // 
            this.chooseFile.Location = new System.Drawing.Point(136, 25);
            this.chooseFile.Name = "chooseFile";
            this.chooseFile.Size = new System.Drawing.Size(75, 23);
            this.chooseFile.TabIndex = 0;
            this.chooseFile.Text = "button1";
            this.chooseFile.UseVisualStyleBackColor = true;
            this.chooseFile.Click += new System.EventHandler(this.chooseFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose file";
            // 
            // resolutionChange
            // 
            this.resolutionChange.AutoSize = true;
            this.resolutionChange.Location = new System.Drawing.Point(87, 83);
            this.resolutionChange.Name = "resolutionChange";
            this.resolutionChange.Size = new System.Drawing.Size(80, 17);
            this.resolutionChange.TabIndex = 2;
            this.resolutionChange.Text = "checkBox1";
            this.resolutionChange.UseVisualStyleBackColor = true;
            this.resolutionChange.CheckedChanged += new System.EventHandler(this.resolutionChange_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // resDropDown
            // 
            this.resDropDown.FormattingEnabled = true;
            this.resDropDown.Location = new System.Drawing.Point(87, 137);
            this.resDropDown.Name = "resDropDown";
            this.resDropDown.Size = new System.Drawing.Size(121, 21);
            this.resDropDown.TabIndex = 4;
            this.resDropDown.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 317);
            this.Controls.Add(this.resDropDown);
            this.Controls.Add(this.resolutionChange);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chooseFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog fileDialog;
        private System.Windows.Forms.Button chooseFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox resolutionChange;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ComboBox resDropDown;
    }
}

