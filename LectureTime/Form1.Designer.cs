
namespace LectureTime
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.NowTimeFormLabel = new System.Windows.Forms.Label();
            this.NowTimeStatusLabel = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.EndedTimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.leftTimeLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NowTimeFormLabel
            // 
            this.NowTimeFormLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NowTimeFormLabel.Font = new System.Drawing.Font("Consolas", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowTimeFormLabel.ForeColor = System.Drawing.Color.White;
            this.NowTimeFormLabel.Location = new System.Drawing.Point(12, 113);
            this.NowTimeFormLabel.Name = "NowTimeFormLabel";
            this.NowTimeFormLabel.Size = new System.Drawing.Size(960, 239);
            this.NowTimeFormLabel.TabIndex = 0;
            this.NowTimeFormLabel.Text = "00:00:00";
            this.NowTimeFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NowTimeStatusLabel
            // 
            this.NowTimeStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NowTimeStatusLabel.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowTimeStatusLabel.ForeColor = System.Drawing.Color.White;
            this.NowTimeStatusLabel.Location = new System.Drawing.Point(12, 352);
            this.NowTimeStatusLabel.Name = "NowTimeStatusLabel";
            this.NowTimeStatusLabel.Size = new System.Drawing.Size(960, 95);
            this.NowTimeStatusLabel.TabIndex = 0;
            this.NowTimeStatusLabel.Text = "None";
            this.NowTimeStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(12, 534);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(960, 15);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 1;
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLabel.ForeColor = System.Drawing.Color.White;
            this.StartTimeLabel.Location = new System.Drawing.Point(12, 499);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(135, 32);
            this.StartTimeLabel.TabIndex = 2;
            this.StartTimeLabel.Text = "00:00:00";
            // 
            // EndedTimeLabel
            // 
            this.EndedTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.EndedTimeLabel.AutoSize = true;
            this.EndedTimeLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndedTimeLabel.ForeColor = System.Drawing.Color.White;
            this.EndedTimeLabel.Location = new System.Drawing.Point(837, 499);
            this.EndedTimeLabel.Name = "EndedTimeLabel";
            this.EndedTimeLabel.Size = new System.Drawing.Size(135, 32);
            this.EndedTimeLabel.TabIndex = 2;
            this.EndedTimeLabel.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // leftTimeLabel
            // 
            this.leftTimeLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.leftTimeLabel.AutoSize = true;
            this.leftTimeLabel.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTimeLabel.ForeColor = System.Drawing.Color.White;
            this.leftTimeLabel.Location = new System.Drawing.Point(406, 497);
            this.leftTimeLabel.Name = "leftTimeLabel";
            this.leftTimeLabel.Size = new System.Drawing.Size(159, 34);
            this.leftTimeLabel.TabIndex = 4;
            this.leftTimeLabel.Text = "00::00:00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // SettingsToolStripMenuItem
            // 
            this.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem";
            this.SettingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SettingsToolStripMenuItem.Text = "Settings";
            this.SettingsToolStripMenuItem.Click += new System.EventHandler(this.setteiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.leftTimeLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndedTimeLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.NowTimeStatusLabel);
            this.Controls.Add(this.NowTimeFormLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "LectureTime";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing_event);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NowTimeFormLabel;
        private System.Windows.Forms.Label NowTimeStatusLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label EndedTimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label leftTimeLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsToolStripMenuItem;
    }
}

