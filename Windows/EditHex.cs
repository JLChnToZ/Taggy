﻿using System;
using System.Windows.Forms;
using Be.Windows.Forms;

namespace Taggy.Windows
{
    public partial class HexEditor : Form
    {
        private int _bytesPerElem;
        private byte[] _data;
        private bool _modified;
        DynamicByteProvider _byteProvider;

        private class FixedByteProvider : DynamicByteProvider
        {
            public FixedByteProvider (byte[] data)
                : base(data)
            { }

            public override bool SupportsInsertBytes ()
            {
                return false;
            }
        }

        public HexEditor (string tagName, byte[] data, int bytesPerElem)
        {
            InitializeComponent();

            this.Text = "正在編輯: " + tagName;

            _bytesPerElem = bytesPerElem;
            _curPositionLabel.Text = "0x0000";
            _curElementLabel.Text = "位置 0";

            _data = new byte[data.Length];
            Array.Copy(data, _data, data.Length);

            _byteProvider = new DynamicByteProvider(_data);
            _byteProvider.Changed += (o, e) => { _modified = true; };

            hexBox1.ByteProvider = _byteProvider;

            hexBox1.HorizontalByteCountChanged += HexBox_HorizontalByteCountChanged;
            hexBox1.CurrentLineChanged += HexBox_CurrentLineChanged;
            hexBox1.CurrentPositionInLineChanged += HexBox_CurrentPositionInLineChanged;
            hexBox1.InsertActiveChanged += HexBox_InsertActiveChanged;

            hexBox1.ReadOnly = false;
        }

        public byte[] Data
        {
            get { return _data; }
        }

        public bool Modified
        {
            get { return _modified; }
        }

        private void HexBox_HorizontalByteCountChanged (object sender, EventArgs e)
        {
            UpdatePosition();
        }

        private void HexBox_CurrentLineChanged (object sender, EventArgs e)
        {
            UpdatePosition();
        }

        private void HexBox_CurrentPositionInLineChanged (object sender, EventArgs e)
        {
            UpdatePosition();
        }

        private void HexBox_InsertActiveChanged (object sender, EventArgs e)
        {
            if (hexBox1.InsertActive)
                _insertStateLabel.Text = "插入";
            else
                _insertStateLabel.Text = "覆寫";
        }

        private void UpdatePosition ()
        {
            long pos = (hexBox1.CurrentLine - 1) * hexBox1.HorizontalByteCount + hexBox1.CurrentPositionInLine - 1;

            _curPositionLabel.Text = "0x" + pos.ToString("X4");
            _curElementLabel.Text = "位置 " + pos / _bytesPerElem;
        }

        private void Apply ()
        {
            if (_data.Length != _byteProvider.Length)
                _data = new byte[_byteProvider.Length];

            for (int i = 0; i < _data.Length; i++) {
                _data[i] = _byteProvider.Bytes[i];
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void _buttonOK_Click (object sender, EventArgs e)
        {
            Apply();
        }
    }
}
