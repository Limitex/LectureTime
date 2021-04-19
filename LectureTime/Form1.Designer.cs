
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
            this.SuspendLayout();
            // 
            // NowTimeFormLabel
            // 
            this.NowTimeFormLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NowTimeFormLabel.Font = new System.Drawing.Font("Consolas", 140.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NowTimeFormLabel.ForeColor = System.Drawing.Color.White;
            this.NowTimeFormLabel.Location = new System.Drawing.Point(12, 127);
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
            this.NowTimeStatusLabel.Location = new System.Drawing.Point(12, 366);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.NowTimeStatusLabel);
            this.Controls.Add(this.NowTimeFormLabel);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing_event);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NowTimeFormLabel;
        private System.Windows.Forms.Label NowTimeStatusLabel;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

