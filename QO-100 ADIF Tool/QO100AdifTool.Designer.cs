namespace QO_100_ADIF_Tool
{
    partial class QO100AdifTool
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
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.openFileDialogLogFile = new System.Windows.Forms.OpenFileDialog();
            this.buttonLoadLog = new System.Windows.Forms.Button();
            this.textBoxSatName = new System.Windows.Forms.TextBox();
            this.checkBoxGridsquare = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Enabled = false;
            this.checkBoxName.Location = new System.Drawing.Point(6, 21);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(66, 20);
            this.checkBoxName.TabIndex = 0;
            this.checkBoxName.Text = "NAME";
            this.checkBoxName.UseVisualStyleBackColor = true;
            // 
            // openFileDialogLogFile
            // 
            this.openFileDialogLogFile.Title = "Select your ADIF Log file";
            // 
            // buttonLoadLog
            // 
            this.buttonLoadLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLoadLog.Location = new System.Drawing.Point(12, 12);
            this.buttonLoadLog.Name = "buttonLoadLog";
            this.buttonLoadLog.Size = new System.Drawing.Size(189, 34);
            this.buttonLoadLog.TabIndex = 1;
            this.buttonLoadLog.Text = "Select Log File";
            this.buttonLoadLog.UseVisualStyleBackColor = true;
            this.buttonLoadLog.Click += new System.EventHandler(this.buttonLoadLog_Click);
            // 
            // textBoxSatName
            // 
            this.textBoxSatName.Enabled = false;
            this.textBoxSatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSatName.Location = new System.Drawing.Point(118, 140);
            this.textBoxSatName.Name = "textBoxSatName";
            this.textBoxSatName.Size = new System.Drawing.Size(84, 22);
            this.textBoxSatName.TabIndex = 2;
            this.textBoxSatName.Text = "QO-100";
            // 
            // checkBoxGridsquare
            // 
            this.checkBoxGridsquare.AutoSize = true;
            this.checkBoxGridsquare.Enabled = false;
            this.checkBoxGridsquare.Location = new System.Drawing.Point(6, 47);
            this.checkBoxGridsquare.Name = "checkBoxGridsquare";
            this.checkBoxGridsquare.Size = new System.Drawing.Size(117, 20);
            this.checkBoxGridsquare.TabIndex = 3;
            this.checkBoxGridsquare.Text = "GRIDSQUARE";
            this.checkBoxGridsquare.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxGridsquare);
            this.groupBox1.Controls.Add(this.checkBoxName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 75);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Transform COMMENT to";
            // 
            // buttonProcess
            // 
            this.buttonProcess.Enabled = false;
            this.buttonProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProcess.Location = new System.Drawing.Point(12, 168);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(190, 37);
            this.buttonProcess.TabIndex = 5;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Satellite Name";
            // 
            // QO100AdifTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBoxSatName);
            this.Controls.Add(this.buttonLoadLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QO100AdifTool";
            this.ShowIcon = false;
            this.Text = "QO-100 ADIF Tool";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.OpenFileDialog openFileDialogLogFile;
        private System.Windows.Forms.Button buttonLoadLog;
        private System.Windows.Forms.TextBox textBoxSatName;
        private System.Windows.Forms.CheckBox checkBoxGridsquare;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonProcess;
        private System.Windows.Forms.Label label1;
    }
}

