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
            this._numericUpDown = new System.Windows.Forms.NumericUpDown();
            this._linkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _replyLabel
            // 
            this._replyLabel.AccessibleName = "ReplyLabel";
            this._replyLabel.AutoSize = true;
            this._replyLabel.Location = new System.Drawing.Point(26, 246);
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
            this._comboBox.Location = new System.Drawing.Point(29, 171);
            this._comboBox.Name = "_comboBox";
            this._comboBox.Size = new System.Drawing.Size(121, 21);
            this._comboBox.TabIndex = 2;
            // 
            // _numericUpDown
            // 
            this._numericUpDown.AccessibleName = "Numeric";
            this._numericUpDown.Location = new System.Drawing.Point(29, 209);
            this._numericUpDown.Name = "_numericUpDown";
            this._numericUpDown.Size = new System.Drawing.Size(120, 20);
            this._numericUpDown.TabIndex = 3;
            // 
            // _linkLabel
            // 
            this._linkLabel.AccessibleName = "";
            this._linkLabel.AutoSize = true;
            this._linkLabel.Location = new System.Drawing.Point(29, 285);
            this._linkLabel.Name = "_linkLabel";
            this._linkLabel.Size = new System.Drawing.Size(41, 13);
            this._linkLabel.TabIndex = 4;
            this._linkLabel.TabStop = true;
            this._linkLabel.Text = "Google";
            // 
            // EchoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 348);
            this.Controls.Add(this._linkLabel);
            this.Controls.Add(this._numericUpDown);
            this.Controls.Add(this._comboBox);
            this.Controls.Add(this._radioTableLayoutPanel);
            this.Controls.Add(this._replyLabel);
            this.Name = "EchoForm";
            this.Text = "EchoForm";
            this.Load += new System.EventHandler(this.EchoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _replyLabel;
        private System.Windows.Forms.TableLayoutPanel _radioTableLayoutPanel;
        private System.Windows.Forms.ComboBox _comboBox;
        private System.Windows.Forms.NumericUpDown _numericUpDown;
        private System.Windows.Forms.LinkLabel _linkLabel;
    }
}