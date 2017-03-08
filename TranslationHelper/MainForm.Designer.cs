namespace TranslationHelper
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
            this.inFileWindows = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inFileAndroid = new System.Windows.Forms.TextBox();
            this.inFileiOS = new System.Windows.Forms.TextBox();
            this.checkBoxEN = new System.Windows.Forms.CheckBox();
            this.checkBoxNL = new System.Windows.Forms.CheckBox();
            this.checkBoxFR = new System.Windows.Forms.CheckBox();
            this.checkBoxDE = new System.Windows.Forms.CheckBox();
            this.checkBoxPT = new System.Windows.Forms.CheckBox();
            this.checkBoxES = new System.Windows.Forms.CheckBox();
            this.extractButton = new System.Windows.Forms.Button();
            this.openFileDialogWindows = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogAndroid = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogiOS = new System.Windows.Forms.OpenFileDialog();
            this.browseWindows = new System.Windows.Forms.Button();
            this.browseAndroid = new System.Windows.Forms.Button();
            this.browseiOS = new System.Windows.Forms.Button();
            this.outFileLabel = new System.Windows.Forms.Label();
            this.outFilePath = new System.Windows.Forms.TextBox();
            this.outFileButton = new System.Windows.Forms.Button();
            this.outFileDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(56, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Windows (.resx) file: ";
            // 
            // inFileWindows
            // 
            this.inFileWindows.Location = new System.Drawing.Point(179, 92);
            this.inFileWindows.Name = "inFileWindows";
            this.inFileWindows.Size = new System.Drawing.Size(200, 20);
            this.inFileWindows.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(56, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Android (.xml) file: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(56, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "iOS (.plist) file: ";
            // 
            // inFileAndroid
            // 
            this.inFileAndroid.Location = new System.Drawing.Point(179, 118);
            this.inFileAndroid.Name = "inFileAndroid";
            this.inFileAndroid.Size = new System.Drawing.Size(200, 20);
            this.inFileAndroid.TabIndex = 4;
            // 
            // inFileiOS
            // 
            this.inFileiOS.Location = new System.Drawing.Point(179, 144);
            this.inFileiOS.Name = "inFileiOS";
            this.inFileiOS.Size = new System.Drawing.Size(200, 20);
            this.inFileiOS.TabIndex = 5;
            // 
            // checkBoxEN
            // 
            this.checkBoxEN.AutoSize = true;
            this.checkBoxEN.Checked = true;
            this.checkBoxEN.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEN.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEN.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxEN.Location = new System.Drawing.Point(59, 194);
            this.checkBoxEN.Name = "checkBoxEN";
            this.checkBoxEN.Size = new System.Drawing.Size(67, 17);
            this.checkBoxEN.TabIndex = 6;
            this.checkBoxEN.Text = "English";
            this.checkBoxEN.UseVisualStyleBackColor = true;
            // 
            // checkBoxNL
            // 
            this.checkBoxNL.AutoSize = true;
            this.checkBoxNL.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxNL.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxNL.Location = new System.Drawing.Point(59, 217);
            this.checkBoxNL.Name = "checkBoxNL";
            this.checkBoxNL.Size = new System.Drawing.Size(57, 18);
            this.checkBoxNL.TabIndex = 7;
            this.checkBoxNL.Text = "Dutch";
            this.checkBoxNL.UseVisualStyleBackColor = true;
            // 
            // checkBoxFR
            // 
            this.checkBoxFR.AutoSize = true;
            this.checkBoxFR.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFR.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxFR.Location = new System.Drawing.Point(59, 240);
            this.checkBoxFR.Name = "checkBoxFR";
            this.checkBoxFR.Size = new System.Drawing.Size(64, 18);
            this.checkBoxFR.TabIndex = 8;
            this.checkBoxFR.Text = "French";
            this.checkBoxFR.UseVisualStyleBackColor = true;
            // 
            // checkBoxDE
            // 
            this.checkBoxDE.AutoSize = true;
            this.checkBoxDE.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDE.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxDE.Location = new System.Drawing.Point(59, 263);
            this.checkBoxDE.Name = "checkBoxDE";
            this.checkBoxDE.Size = new System.Drawing.Size(70, 18);
            this.checkBoxDE.TabIndex = 9;
            this.checkBoxDE.Text = "German";
            this.checkBoxDE.UseVisualStyleBackColor = true;
            // 
            // checkBoxPT
            // 
            this.checkBoxPT.AutoSize = true;
            this.checkBoxPT.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPT.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxPT.Location = new System.Drawing.Point(59, 286);
            this.checkBoxPT.Name = "checkBoxPT";
            this.checkBoxPT.Size = new System.Drawing.Size(91, 18);
            this.checkBoxPT.TabIndex = 10;
            this.checkBoxPT.Text = "Portuguese";
            this.checkBoxPT.UseVisualStyleBackColor = true;
            // 
            // checkBoxES
            // 
            this.checkBoxES.AutoSize = true;
            this.checkBoxES.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxES.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxES.Location = new System.Drawing.Point(59, 309);
            this.checkBoxES.Name = "checkBoxES";
            this.checkBoxES.Size = new System.Drawing.Size(70, 18);
            this.checkBoxES.TabIndex = 11;
            this.checkBoxES.Text = "Spanish";
            this.checkBoxES.UseVisualStyleBackColor = true;
            // 
            // extractButton
            // 
            this.extractButton.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extractButton.Location = new System.Drawing.Point(759, 170);
            this.extractButton.Name = "extractButton";
            this.extractButton.Size = new System.Drawing.Size(110, 41);
            this.extractButton.TabIndex = 12;
            this.extractButton.Text = "Extract strings!";
            this.extractButton.UseVisualStyleBackColor = true;
            // 
            // openFileDialogWindows
            // 
            this.openFileDialogWindows.FileName = "openFileWindows";
            // 
            // openFileDialogAndroid
            // 
            this.openFileDialogAndroid.FileName = "openFileAndroid";
            // 
            // openFileDialogiOS
            // 
            this.openFileDialogiOS.FileName = "openFileiOS";
            // 
            // browseWindows
            // 
            this.browseWindows.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseWindows.Location = new System.Drawing.Point(385, 90);
            this.browseWindows.Name = "browseWindows";
            this.browseWindows.Size = new System.Drawing.Size(64, 23);
            this.browseWindows.TabIndex = 13;
            this.browseWindows.Text = "Browse...";
            this.browseWindows.UseVisualStyleBackColor = true;
            // 
            // browseAndroid
            // 
            this.browseAndroid.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseAndroid.Location = new System.Drawing.Point(385, 116);
            this.browseAndroid.Name = "browseAndroid";
            this.browseAndroid.Size = new System.Drawing.Size(64, 23);
            this.browseAndroid.TabIndex = 14;
            this.browseAndroid.Text = "Browse...";
            this.browseAndroid.UseVisualStyleBackColor = true;
            // 
            // browseiOS
            // 
            this.browseiOS.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseiOS.Location = new System.Drawing.Point(385, 142);
            this.browseiOS.Name = "browseiOS";
            this.browseiOS.Size = new System.Drawing.Size(64, 23);
            this.browseiOS.TabIndex = 15;
            this.browseiOS.Text = "Browse...";
            this.browseiOS.UseVisualStyleBackColor = true;
            // 
            // outFileLabel
            // 
            this.outFileLabel.AutoSize = true;
            this.outFileLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outFileLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.outFileLabel.Location = new System.Drawing.Point(465, 121);
            this.outFileLabel.Name = "outFileLabel";
            this.outFileLabel.Size = new System.Drawing.Size(128, 15);
            this.outFileLabel.TabIndex = 16;
            this.outFileLabel.Text = "Extracted File Output:";
            // 
            // outFilePath
            // 
            this.outFilePath.Location = new System.Drawing.Point(599, 119);
            this.outFilePath.Name = "outFilePath";
            this.outFilePath.Size = new System.Drawing.Size(200, 20);
            this.outFilePath.TabIndex = 17;
            // 
            // outFileButton
            // 
            this.outFileButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outFileButton.Location = new System.Drawing.Point(805, 118);
            this.outFileButton.Name = "outFileButton";
            this.outFileButton.Size = new System.Drawing.Size(64, 23);
            this.outFileButton.TabIndex = 18;
            this.outFileButton.Text = "Browse...";
            this.outFileButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(984, 442);
            this.Controls.Add(this.outFileButton);
            this.Controls.Add(this.outFilePath);
            this.Controls.Add(this.outFileLabel);
            this.Controls.Add(this.browseiOS);
            this.Controls.Add(this.browseAndroid);
            this.Controls.Add(this.browseWindows);
            this.Controls.Add(this.extractButton);
            this.Controls.Add(this.checkBoxES);
            this.Controls.Add(this.checkBoxPT);
            this.Controls.Add(this.checkBoxDE);
            this.Controls.Add(this.checkBoxFR);
            this.Controls.Add(this.checkBoxNL);
            this.Controls.Add(this.checkBoxEN);
            this.Controls.Add(this.inFileiOS);
            this.Controls.Add(this.inFileAndroid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inFileWindows);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inFileWindows;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inFileAndroid;
        private System.Windows.Forms.TextBox inFileiOS;
        private System.Windows.Forms.CheckBox checkBoxEN;
        private System.Windows.Forms.CheckBox checkBoxNL;
        private System.Windows.Forms.CheckBox checkBoxFR;
        private System.Windows.Forms.CheckBox checkBoxDE;
        private System.Windows.Forms.CheckBox checkBoxPT;
        private System.Windows.Forms.CheckBox checkBoxES;
        private System.Windows.Forms.Button extractButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogWindows;
        private System.Windows.Forms.OpenFileDialog openFileDialogAndroid;
        private System.Windows.Forms.OpenFileDialog openFileDialogiOS;
        private System.Windows.Forms.Button browseWindows;
        private System.Windows.Forms.Button browseAndroid;
        private System.Windows.Forms.Button browseiOS;
        private System.Windows.Forms.Label outFileLabel;
        private System.Windows.Forms.TextBox outFilePath;
        private System.Windows.Forms.Button outFileButton;
        private System.Windows.Forms.FolderBrowserDialog outFileDialog;
    }
}

