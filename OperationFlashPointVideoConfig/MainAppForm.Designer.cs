namespace OperationFlashPointVideoConfig
{
    partial class MainAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppForm));
            this.comboBoxRes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRefresh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxFullscreen = new System.Windows.Forms.CheckBox();
            this.checkBoxVsync = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLaunch = new System.Windows.Forms.Button();
            this.checkBoxSteam = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // comboBoxRes
            // 
            this.comboBoxRes.FormattingEnabled = true;
            this.comboBoxRes.Location = new System.Drawing.Point(108, 28);
            this.comboBoxRes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxRes.Name = "comboBoxRes";
            this.comboBoxRes.Size = new System.Drawing.Size(223, 23);
            this.comboBoxRes.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Set Resolution:";
            // 
            // comboBoxRefresh
            // 
            this.comboBoxRefresh.FormattingEnabled = true;
            this.comboBoxRefresh.Location = new System.Drawing.Point(108, 61);
            this.comboBoxRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxRefresh.Name = "comboBoxRefresh";
            this.comboBoxRefresh.Size = new System.Drawing.Size(66, 23);
            this.comboBoxRefresh.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Set Refresh:";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.Black;
            this.buttonSave.Location = new System.Drawing.Point(108, 108);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 48);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxFullscreen
            // 
            this.checkBoxFullscreen.AutoSize = true;
            this.checkBoxFullscreen.Location = new System.Drawing.Point(13, 108);
            this.checkBoxFullscreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxFullscreen.Name = "checkBoxFullscreen";
            this.checkBoxFullscreen.Size = new System.Drawing.Size(88, 19);
            this.checkBoxFullscreen.TabIndex = 3;
            this.checkBoxFullscreen.Text = "Full Screen";
            this.checkBoxFullscreen.UseVisualStyleBackColor = true;
            // 
            // checkBoxVsync
            // 
            this.checkBoxVsync.AutoSize = true;
            this.checkBoxVsync.Location = new System.Drawing.Point(13, 137);
            this.checkBoxVsync.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxVsync.Name = "checkBoxVsync";
            this.checkBoxVsync.Size = new System.Drawing.Size(57, 19);
            this.checkBoxVsync.TabIndex = 4;
            this.checkBoxVsync.Text = "Vsync";
            this.checkBoxVsync.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 65);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hz";
            // 
            // buttonLaunch
            // 
            this.buttonLaunch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLaunch.ForeColor = System.Drawing.Color.Black;
            this.buttonLaunch.Location = new System.Drawing.Point(221, 108);
            this.buttonLaunch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLaunch.Name = "buttonLaunch";
            this.buttonLaunch.Size = new System.Drawing.Size(110, 48);
            this.buttonLaunch.TabIndex = 6;
            this.buttonLaunch.Text = "Launch";
            this.buttonLaunch.UseVisualStyleBackColor = true;
            this.buttonLaunch.Click += new System.EventHandler(this.buttonLaunch_Click);
            // 
            // checkBoxSteam
            // 
            this.checkBoxSteam.AutoSize = true;
            this.checkBoxSteam.Location = new System.Drawing.Point(221, 65);
            this.checkBoxSteam.Name = "checkBoxSteam";
            this.checkBoxSteam.Size = new System.Drawing.Size(106, 19);
            this.checkBoxSteam.TabIndex = 7;
            this.checkBoxSteam.Text = "Steam Version";
            this.checkBoxSteam.UseVisualStyleBackColor = true;
            this.checkBoxSteam.CheckedChanged += new System.EventHandler(this.checkBoxSteam_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::OperationFlashPointVideoConfig.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(344, 171);
            this.Controls.Add(this.checkBoxSteam);
            this.Controls.Add(this.checkBoxVsync);
            this.Controls.Add(this.checkBoxFullscreen);
            this.Controls.Add(this.buttonLaunch);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRefresh);
            this.Controls.Add(this.comboBoxRes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "OFDR High Res Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxRes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxRefresh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxFullscreen;
        private System.Windows.Forms.CheckBox checkBoxVsync;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLaunch;
        private System.Windows.Forms.CheckBox checkBoxSteam;
    }
}

