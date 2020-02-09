namespace LagSwitchEFT
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartButton = new System.Windows.Forms.Button();
            this.PathLabel = new System.Windows.Forms.Label();
            this.LagTextLabel = new System.Windows.Forms.Label();
            this.TextBoxPath = new System.Windows.Forms.TextBox();
            this.TimeoutTrackbar = new System.Windows.Forms.TrackBar();
            this.MsLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.StatusTextLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.FindButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.StartButton.Location = new System.Drawing.Point(74, 306);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(153, 63);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start!";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PathLabel
            // 
            this.PathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathLabel.AutoSize = true;
            this.PathLabel.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold);
            this.PathLabel.Location = new System.Drawing.Point(36, 52);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(300, 22);
            this.PathLabel.TabIndex = 1;
            this.PathLabel.Text = "Please enter the path of your game :";
            // 
            // LagTextLabel
            // 
            this.LagTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LagTextLabel.AutoSize = true;
            this.LagTextLabel.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold);
            this.LagTextLabel.Location = new System.Drawing.Point(148, 109);
            this.LagTextLabel.Name = "LagTextLabel";
            this.LagTextLabel.Size = new System.Drawing.Size(311, 22);
            this.LagTextLabel.TabIndex = 2;
            this.LagTextLabel.Text = "Please enter the timer for the switch :";
            // 
            // TextBoxPath
            // 
            this.TextBoxPath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxPath.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Italic);
            this.TextBoxPath.Location = new System.Drawing.Point(358, 49);
            this.TextBoxPath.Name = "TextBoxPath";
            this.TextBoxPath.Size = new System.Drawing.Size(250, 29);
            this.TextBoxPath.TabIndex = 3;
            this.TextBoxPath.Text = "C:/MyGame.exe";
            // 
            // TimeoutTrackbar
            // 
            this.TimeoutTrackbar.LargeChange = 2;
            this.TimeoutTrackbar.Location = new System.Drawing.Point(141, 151);
            this.TimeoutTrackbar.Maximum = 6;
            this.TimeoutTrackbar.Name = "TimeoutTrackbar";
            this.TimeoutTrackbar.Size = new System.Drawing.Size(398, 69);
            this.TimeoutTrackbar.TabIndex = 4;
            this.TimeoutTrackbar.Scroll += new System.EventHandler(this.TimeoutScroll);
            // 
            // MsLabel
            // 
            this.MsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MsLabel.AutoSize = true;
            this.MsLabel.Font = new System.Drawing.Font("Noto Sans", 8F);
            this.MsLabel.ForeColor = System.Drawing.Color.Lime;
            this.MsLabel.Location = new System.Drawing.Point(482, 109);
            this.MsLabel.Name = "MsLabel";
            this.MsLabel.Size = new System.Drawing.Size(46, 22);
            this.MsLabel.TabIndex = 5;
            this.MsLabel.Text = "0 ms";
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Noto Sans", 12F);
            this.StopButton.Location = new System.Drawing.Point(514, 306);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(153, 63);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // StatusTextLabel
            // 
            this.StatusTextLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTextLabel.AutoSize = true;
            this.StatusTextLabel.Font = new System.Drawing.Font("Noto Sans", 8F, System.Drawing.FontStyle.Bold);
            this.StatusTextLabel.Location = new System.Drawing.Point(266, 223);
            this.StatusTextLabel.Name = "StatusTextLabel";
            this.StatusTextLabel.Size = new System.Drawing.Size(71, 22);
            this.StatusTextLabel.TabIndex = 7;
            this.StatusTextLabel.Text = "Status :";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Noto Sans", 8F);
            this.StatusLabel.ForeColor = System.Drawing.Color.Red;
            this.StatusLabel.Location = new System.Drawing.Point(344, 223);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(111, 22);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Not Assigned";
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "openFileDialog1";
            // 
            // FindButton
            // 
            this.FindButton.Font = new System.Drawing.Font("Noto Sans", 8.249999F);
            this.FindButton.Location = new System.Drawing.Point(616, 49);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(90, 34);
            this.FindButton.TabIndex = 9;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 449);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.StatusTextLabel);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.MsLabel);
            this.Controls.Add(this.TimeoutTrackbar);
            this.Controls.Add(this.TextBoxPath);
            this.Controls.Add(this.LagTextLabel);
            this.Controls.Add(this.PathLabel);
            this.Controls.Add(this.StartButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "HelloBoyssss";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TimeoutScroll);
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label PathLabel;
        private System.Windows.Forms.Label LagTextLabel;
        private System.Windows.Forms.TextBox TextBoxPath;
        private System.Windows.Forms.TrackBar TimeoutTrackbar;
        private System.Windows.Forms.Label MsLabel;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Label StatusTextLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button FindButton;
    }
}

