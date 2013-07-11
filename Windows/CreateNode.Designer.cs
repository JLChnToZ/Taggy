namespace Taggy.Windows
{
    partial class CreateNodeForm
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
          this._sizeField = new System.Windows.Forms.NumericUpDown();
          this._sizeFieldLabel = new System.Windows.Forms.Label();
          this._nameFieldLabel = new System.Windows.Forms.Label();
          this._nameField = new System.Windows.Forms.TextBox();
          this._buttonCancel = new System.Windows.Forms.Button();
          this._buttonOK = new System.Windows.Forms.Button();
          this.SuspendLayout();
          // 
          // _sizeField
          // 
          this._sizeField.Location = new System.Drawing.Point(56, 34);
          this._sizeField.Name = "_sizeField";
          this._sizeField.Size = new System.Drawing.Size(67, 22);
          this._sizeField.Minimum = 0;
          this._sizeField.Maximum = 4294967296;
          this._sizeField.TabIndex = 7;
          // 
          // _sizeFieldLabel
          // 
          this._sizeFieldLabel.AutoSize = true;
          this._sizeFieldLabel.Location = new System.Drawing.Point(12, 37);
          this._sizeFieldLabel.Name = "_sizeFieldLabel";
          this._sizeFieldLabel.Size = new System.Drawing.Size(29, 12);
          this._sizeFieldLabel.TabIndex = 6;
          this._sizeFieldLabel.Text = "大小";
          // 
          // _nameFieldLabel
          // 
          this._nameFieldLabel.AutoSize = true;
          this._nameFieldLabel.Location = new System.Drawing.Point(12, 8);
          this._nameFieldLabel.Name = "_nameFieldLabel";
          this._nameFieldLabel.Size = new System.Drawing.Size(32, 12);
          this._nameFieldLabel.TabIndex = 5;
          this._nameFieldLabel.Text = "名稱:";
          // 
          // _nameField
          // 
          this._nameField.Location = new System.Drawing.Point(56, 6);
          this._nameField.Name = "_nameField";
          this._nameField.Size = new System.Drawing.Size(209, 22);
          this._nameField.TabIndex = 4;
          // 
          // _buttonCancel
          // 
          this._buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this._buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
          this._buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
          this._buttonCancel.Location = new System.Drawing.Point(109, 64);
          this._buttonCancel.Name = "_buttonCancel";
          this._buttonCancel.Size = new System.Drawing.Size(75, 21);
          this._buttonCancel.TabIndex = 9;
          this._buttonCancel.Text = "取消";
          this._buttonCancel.UseVisualStyleBackColor = true;
          // 
          // _buttonOK
          // 
          this._buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
          this._buttonOK.FlatStyle = System.Windows.Forms.FlatStyle.System;
          this._buttonOK.Location = new System.Drawing.Point(190, 64);
          this._buttonOK.Name = "_buttonOK";
          this._buttonOK.Size = new System.Drawing.Size(75, 21);
          this._buttonOK.TabIndex = 8;
          this._buttonOK.Text = "確定";
          this._buttonOK.UseVisualStyleBackColor = true;
          this._buttonOK.Click += new System.EventHandler(this._buttonOK_Click);
          // 
          // CreateNodeForm
          // 
          this.AcceptButton = this._buttonOK;
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.CancelButton = this._buttonCancel;
          this.ClientSize = new System.Drawing.Size(277, 96);
          this.Controls.Add(this._buttonCancel);
          this.Controls.Add(this._buttonOK);
          this.Controls.Add(this._sizeField);
          this.Controls.Add(this._sizeFieldLabel);
          this.Controls.Add(this._nameFieldLabel);
          this.Controls.Add(this._nameField);
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.Name = "CreateNodeForm";
          this.ShowIcon = false;
          this.ShowInTaskbar = false;
          this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
          this.Text = "建立標籤…";
          this.ResumeLayout(false);
          this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.NumericUpDown _sizeField;
        private System.Windows.Forms.Label _sizeFieldLabel;
        private System.Windows.Forms.Label _nameFieldLabel;
        private System.Windows.Forms.TextBox _nameField;
        private System.Windows.Forms.Button _buttonCancel;
        private System.Windows.Forms.Button _buttonOK;
    }
}