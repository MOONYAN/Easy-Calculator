namespace Easy_Calculator
{
    partial class EchoForm
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
            this._replyLabel = new System.Windows.Forms.Label();
            this._radioTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this._comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // _replyLabel
            // 
            this._replyLabel.AccessibleName = "ReplyLabel";
            this._replyLabel.AutoSize = true;
            this._replyLabel.Location = new System.Drawing.Point(36, 210);
            this._replyLabel.Name = "_replyLabel";
            this._replyLabel.Size = new System.Drawing.Size(35, 13);
            this._replyLabel.TabIndex = 0;
            this._replyLabel.Text = "label1";
            // 
            // _radioTableLayoutPanel
            // 
            this._radioTableLayoutPanel.ColumnCount = 1;
            this._radioTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this._radioTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this._radioTableLayoutPanel.Location = new System.Drawing.Point(29, 50);
            this._radioTableLayoutPanel.Name = "_radioTableLayoutPanel";
            this._radioTableLayoutPanel.RowCount = 3;
            this._radioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._radioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._radioTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this._radioTableLayoutPanel.Size = new System.Drawing.Size(200, 100);
            this._radioTableLayoutPanel.TabIndex = 1;
            // 
            // _comboBox
            // 
            this._comboBox.AccessibleName = "ComBo";
            this._comboBox.FormattingEnabled = true;
            this._comboBox.Location = new System.Drawing.Point(108, 202);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(121, 21);
            this._comboBox.TabIndex = 2;
            // 
            // EchoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this._comboBox);
            this.Controls.Add(this._radioTableLayoutPanel);
            this.Controls.Add(this._replyLabel);
            this.Name = "EchoForm";
            this.Text = "EchoForm";
            this.Load += new System.EventHandler(this.EchoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _replyLabel;
        private System.Windows.Forms.TableLayoutPanel _radioTableLayoutPanel;
        private System.Windows.Forms.ComboBox _comboBox;
    }
}