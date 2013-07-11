namespace Taggy.Windows
{
    partial class EditValue
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
          this.textBox1 = new System.Windows.Forms.NumericUpDown();
          this._buttonCancel = new System.Windows.Forms.Button();
          this._buttonOK = new System.Windows.Forms.Button();
          ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
          this.SuspendLayout();
          // 
          // textBox1
          // 
          this.textBox1.Location = new System.Drawing.Point(12, 9);
          this.textBox1.Name = "textBox1";
          this.textBox1.Size = new System.Drawing.Size(196, 22);
          this.textBox1.TabIndex = 0;
          this.textBox1.ThousandsSeparator = true;
          this.textBox1.ValueChanged += new System.EventHandler(this.TextBox1ValueChanged);
          // 
          // _buttonCancel
          // 
          this._buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          this._buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
          this._buttonCancel.Location = new System.Drawing.Point(52, 34);
          this._buttonCancel.Name = "_buttonCancel";
          this._buttonCancel.Size = new System.Drawing.Size(75, 21);
          this._buttonCancel.TabIndex = 11;
          this._buttonCancel.Text = "取消";
          this._buttonCancel.UseVisualStyleBackColor = true;
          // 
          // _buttonOK
          // 
          this._buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this._buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
          this._buttonOK.Location = new System.Drawing.Point(133, 34);
          this._buttonOK.Name = "_buttonOK";
          this._buttonOK.Size = new System.Drawing.Size(75, 21);
          this._buttonOK.TabIndex = 10;
          this._buttonOK.Text = "確定";
          this._buttonOK.UseVisualStyleBackColor = true;
          this._buttonOK.Click += new System.EventHandler(this._buttonOK_Click);
          // 
          // EditValue
          // 
          this.AcceptButton = this._buttonOK;
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.CancelButton = this._buttonCancel;
          this.ClientSize = new System.Drawing.Size(220, 66);
          this.Controls.Add(this._buttonCancel);
          this.Controls.Add(this._buttonOK);
          this.Controls.Add(this.textBox1);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
          this.KeyPreview = true;
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "EditValue";
          this.ShowInTaskbar = false;
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "編輯值…";
          ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
          this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.NumericUpDown textBox1;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Button _buttonOK;
    }
}