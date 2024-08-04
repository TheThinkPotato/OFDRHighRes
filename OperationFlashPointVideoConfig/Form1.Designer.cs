namespace OperationFlashPointVideoConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.comboBoxRes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxRefresh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxFullscreen = new System.Windows.Forms.CheckBox();
            this.checkBoxVsync = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(185, 108);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxFullscreen
            // 
            this.checkBoxFullscreen.AutoSize = true;
            this.checkBoxFullscreen.Location = new System.Drawing.Point(24, 108);
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
            this.checkBoxVsync.Location = new System.Drawing.Point(24, 137);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::OperationFlashPointVideoConfig.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(344, 171);
            this.Controls.Add(this.checkBoxVsync);
            this.Controls.Add(this.checkBoxFullscreen);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxFullscreen;
        private System.Windows.Forms.CheckBox checkBoxVsync;
        private System.Windows.Forms.Label label3;
    }
}

