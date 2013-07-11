namespace Taggy.Windows
{
    partial class HexEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
        {
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
        private void InitializeComponent ()
        {
            this.hexBox1 = new Be.Windows.Forms.HexBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this._curPositionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._curElementLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._space = new System.Windows.Forms.ToolStripStatusLabel();
            this._insertStateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this._buttonCancel = new System.Windows.Forms.Button();
            this._buttonOK = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hexBox1
            // 
            this.hexBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hexBox1.BackColor = System.Drawing.SystemColors.Window;
            this.hexBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hexBox1.LineInfoForeColor = System.Drawing.Color.Empty;
            this.hexBox1.LineInfoVisible = true;
            this.hexBox1.Location = new System.Drawing.Point(12, 11);
            this.hexBox1.Name = "hexBox1";
            this.hexBox1.ReadOnly = true;
            this.hexBox1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.hexBox1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.hexBox1.ShadowSelectionColor = System.Drawing.SystemColors.Highlight;
            this.hexBox1.Size = new System.Drawing.Size(492, 267);
            this.hexBox1.TabIndex = 0;
            this.hexBox1.VScrollBarVisible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._curPositionLabel,
            this._curElementLabel,
            this._space,
            this._insertStateLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 306);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(516, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // _curPositionLabel
            // 
            this._curPositionLabel.AutoSize = false;
            this._curPositionLabel.Name = "_curPositionLabel";
            this._curPositionLabel.Size = new System.Drawing.Size(100, 17);
            this._curPositionLabel.Text = "0000";
            // 
            // _curElementLabel
            // 
            this._curElementLabel.Name = "_curElementLabel";
            this._curElementLabel.Size = new System.Drawing.Size(64, 17);
            this._curElementLabel.Text = "Element 0";
            this._curElementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // _space
            // 
            this._space.Name = "_space";
            this._space.Size = new System.Drawing.Size(305, 17);
            this._space.Spring = true;
            // 
            // _insertStateLabel
            // 
            this._insertStateLabel.Name = "_insertStateLabel";
            this._insertStateLabel.Size = new System.Drawing.Size(32, 17);
            this._insertStateLabel.Text = "覆寫";
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._buttonCancel.Location = new System.Drawing.Point(348, 283);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(75, 21);
            this._buttonCancel.TabIndex = 13;
            this._buttonCancel.Text = "取消";
            this._buttonCancel.UseVisualStyleBackColor = true;
            // 
            // _buttonOK
            // 
            this._buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this._buttonOK.Location = new System.Drawing.Point(429, 283);
            this._buttonOK.Name = "_buttonOK";
            this._buttonOK.Size = new System.Drawing.Size(75, 21);
            this._buttonOK.TabIndex = 12;
            this._buttonOK.Text = "確定";
            this._buttonOK.UseVisualStyleBackColor = true;
            this._buttonOK.Click += new System.EventHandler(this._buttonOK_Click);
            // 
            // HexEditor
            // 
            this.AcceptButton = this._buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._buttonCancel;
            this.ClientSize = new System.Drawing.Size(516, 328);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonOK);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.hexBox1);
            this.Name = "HexEditor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "十六進制編輯器";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Be.Windows.Forms.HexBox hexBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel _curPositionLabel;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Button _buttonOK;
        private System.Windows.Forms.ToolStripStatusLabel _curElementLabel;
        private System.Windows.Forms.ToolStripStatusLabel _space;
        private System.Windows.Forms.ToolStripStatusLabel _insertStateLabel;
    }
}