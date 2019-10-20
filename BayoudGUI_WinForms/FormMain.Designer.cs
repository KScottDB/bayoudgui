namespace BayoudGUI {
    partial class FormMain {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.textBoxURL = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.checkBoxCertCheck = new System.Windows.Forms.CheckBox();
            this.checkBoxDLAudio = new System.Windows.Forms.CheckBox();
            this.labelURL = new System.Windows.Forms.Label();
            this.panelURL = new System.Windows.Forms.Panel();
            this.panelFF = new System.Windows.Forms.Panel();
            this.buttonFFLoad = new System.Windows.Forms.Button();
            this.buttonFFSave = new System.Windows.Forms.Button();
            this.labelFFExt = new System.Windows.Forms.Label();
            this.labelFFOpt = new System.Windows.Forms.Label();
            this.textBoxFFExt = new System.Windows.Forms.TextBox();
            this.textBoxFFOpt = new System.Windows.Forms.TextBox();
            this.labelFF = new System.Windows.Forms.Label();
            this.panelURL.SuspendLayout();
            this.panelFF.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(12, 79);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(172, 23);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "update your copy of youtube-dl";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(190, 79);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(118, 23);
            this.buttonDownload.TabIndex = 1;
            this.buttonDownload.Text = "download video";
            this.buttonDownload.UseVisualStyleBackColor = true;
            // 
            // textBoxURL
            // 
            this.textBoxURL.Location = new System.Drawing.Point(68, 3);
            this.textBoxURL.Name = "textBoxURL";
            this.textBoxURL.Size = new System.Drawing.Size(228, 20);
            this.textBoxURL.TabIndex = 2;
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelStatus.Location = new System.Drawing.Point(12, 30);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(296, 19);
            this.labelStatus.TabIndex = 3;
            this.labelStatus.Text = "Status: Idle";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 12);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(296, 15);
            this.progressBar.TabIndex = 4;
            this.progressBar.Visible = false;
            // 
            // checkBoxCertCheck
            // 
            this.checkBoxCertCheck.AutoSize = true;
            this.checkBoxCertCheck.Location = new System.Drawing.Point(164, 195);
            this.checkBoxCertCheck.Name = "checkBoxCertCheck";
            this.checkBoxCertCheck.Size = new System.Drawing.Size(144, 17);
            this.checkBoxCertCheck.TabIndex = 13;
            this.checkBoxCertCheck.Text = "Bypass Certificate Check";
            this.checkBoxCertCheck.UseVisualStyleBackColor = true;
            // 
            // checkBoxDLAudio
            // 
            this.checkBoxDLAudio.AutoSize = true;
            this.checkBoxDLAudio.Location = new System.Drawing.Point(12, 195);
            this.checkBoxDLAudio.Name = "checkBoxDLAudio";
            this.checkBoxDLAudio.Size = new System.Drawing.Size(128, 17);
            this.checkBoxDLAudio.TabIndex = 14;
            this.checkBoxDLAudio.Text = "Download Audio Only";
            this.checkBoxDLAudio.UseVisualStyleBackColor = true;
            // 
            // labelURL
            // 
            this.labelURL.AutoSize = true;
            this.labelURL.Location = new System.Drawing.Point(3, 6);
            this.labelURL.Name = "labelURL";
            this.labelURL.Size = new System.Drawing.Size(59, 13);
            this.labelURL.TabIndex = 15;
            this.labelURL.Text = "Video URL";
            // 
            // panelURL
            // 
            this.panelURL.Controls.Add(this.labelURL);
            this.panelURL.Controls.Add(this.textBoxURL);
            this.panelURL.Location = new System.Drawing.Point(12, 49);
            this.panelURL.Name = "panelURL";
            this.panelURL.Size = new System.Drawing.Size(296, 26);
            this.panelURL.TabIndex = 16;
            // 
            // panelFF
            // 
            this.panelFF.Controls.Add(this.buttonFFLoad);
            this.panelFF.Controls.Add(this.buttonFFSave);
            this.panelFF.Controls.Add(this.labelFFExt);
            this.panelFF.Controls.Add(this.labelFFOpt);
            this.panelFF.Controls.Add(this.textBoxFFExt);
            this.panelFF.Controls.Add(this.textBoxFFOpt);
            this.panelFF.Controls.Add(this.labelFF);
            this.panelFF.Location = new System.Drawing.Point(12, 105);
            this.panelFF.Name = "panelFF";
            this.panelFF.Size = new System.Drawing.Size(296, 84);
            this.panelFF.TabIndex = 18;
            // 
            // buttonFFLoad
            // 
            this.buttonFFLoad.Location = new System.Drawing.Point(221, 4);
            this.buttonFFLoad.Name = "buttonFFLoad";
            this.buttonFFLoad.Size = new System.Drawing.Size(75, 23);
            this.buttonFFLoad.TabIndex = 19;
            this.buttonFFLoad.Text = "Load";
            this.buttonFFLoad.UseVisualStyleBackColor = true;
            // 
            // buttonFFSave
            // 
            this.buttonFFSave.Location = new System.Drawing.Point(0, 3);
            this.buttonFFSave.Name = "buttonFFSave";
            this.buttonFFSave.Size = new System.Drawing.Size(75, 23);
            this.buttonFFSave.TabIndex = 18;
            this.buttonFFSave.Text = "Save";
            this.buttonFFSave.UseVisualStyleBackColor = true;
            // 
            // labelFFExt
            // 
            this.labelFFExt.AutoSize = true;
            this.labelFFExt.Location = new System.Drawing.Point(-3, 62);
            this.labelFFExt.Name = "labelFFExt";
            this.labelFFExt.Size = new System.Drawing.Size(53, 13);
            this.labelFFExt.TabIndex = 17;
            this.labelFFExt.Text = "Extension";
            // 
            // labelFFOpt
            // 
            this.labelFFOpt.AutoSize = true;
            this.labelFFOpt.Location = new System.Drawing.Point(7, 36);
            this.labelFFOpt.Name = "labelFFOpt";
            this.labelFFOpt.Size = new System.Drawing.Size(43, 13);
            this.labelFFOpt.TabIndex = 16;
            this.labelFFOpt.Text = "Options";
            // 
            // textBoxFFExt
            // 
            this.textBoxFFExt.Location = new System.Drawing.Point(56, 59);
            this.textBoxFFExt.Name = "textBoxFFExt";
            this.textBoxFFExt.Size = new System.Drawing.Size(45, 20);
            this.textBoxFFExt.TabIndex = 15;
            this.textBoxFFExt.Text = "mp3";
            // 
            // textBoxFFOpt
            // 
            this.textBoxFFOpt.Location = new System.Drawing.Point(56, 33);
            this.textBoxFFOpt.Name = "textBoxFFOpt";
            this.textBoxFFOpt.Size = new System.Drawing.Size(240, 20);
            this.textBoxFFOpt.TabIndex = 14;
            this.textBoxFFOpt.Text = "-ab 192k";
            // 
            // labelFF
            // 
            this.labelFF.AutoSize = true;
            this.labelFF.Location = new System.Drawing.Point(105, 8);
            this.labelFF.Name = "labelFF";
            this.labelFF.Size = new System.Drawing.Size(91, 13);
            this.labelFF.TabIndex = 13;
            this.labelFF.Text = "FFMPEG Settings";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 222);
            this.Controls.Add(this.panelFF);
            this.Controls.Add(this.panelURL);
            this.Controls.Add(this.checkBoxDLAudio);
            this.Controls.Add(this.checkBoxCertCheck);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "BayoudGUI";
            this.panelURL.ResumeLayout(false);
            this.panelURL.PerformLayout();
            this.panelFF.ResumeLayout(false);
            this.panelFF.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.TextBox textBoxURL;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.CheckBox checkBoxCertCheck;
        private System.Windows.Forms.CheckBox checkBoxDLAudio;
        private System.Windows.Forms.Label labelURL;
        private System.Windows.Forms.Panel panelURL;
        private System.Windows.Forms.Panel panelFF;
        private System.Windows.Forms.Button buttonFFLoad;
        private System.Windows.Forms.Button buttonFFSave;
        private System.Windows.Forms.Label labelFFExt;
        private System.Windows.Forms.Label labelFFOpt;
        private System.Windows.Forms.TextBox textBoxFFExt;
        private System.Windows.Forms.TextBox textBoxFFOpt;
        private System.Windows.Forms.Label labelFF;
    }
}

