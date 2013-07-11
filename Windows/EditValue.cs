using System;
using System.Windows.Forms;
using Substrate.Nbt;

namespace Taggy.Windows {
  public partial class EditValue : Form {
    private TagNode _tag;
    private bool hasDecimal;

    public EditValue (TagNode tag) {
      InitializeComponent();

      _tag = tag;
      
      if (tag == null) {
        DialogResult = DialogResult.Abort;
        Close();
        return;
      }
      switch(_tag.GetTagType()) {
        case TagType.TAG_DOUBLE:
          textBox1.Minimum = decimal.MinValue;
          textBox1.Maximum = decimal.MaxValue;
          hasDecimal = true;
          textBox1.Value = (decimal)_tag.ToTagDouble().Data;
          break;
        case TagType.TAG_FLOAT:
          textBox1.Minimum = decimal.MinValue;
          textBox1.Maximum = decimal.MaxValue;
          hasDecimal = true;
          textBox1.Value = (decimal)_tag.ToTagFloat().Data;
          break;
        case TagType.TAG_SHORT:
          textBox1.Minimum = Int16.MinValue;
          textBox1.Maximum = Int16.MaxValue;
          hasDecimal = false;
          textBox1.Value = (decimal)_tag.ToTagShort().Data;
          break;
        case TagType.TAG_INT:
          textBox1.Minimum = Int32.MinValue;
          textBox1.Maximum = Int32.MaxValue;
          hasDecimal = false;
          textBox1.Value = (decimal)_tag.ToTagInt().Data;
          break;
        case TagType.TAG_LONG:
          textBox1.Minimum = Int64.MinValue;
          textBox1.Maximum = Int64.MaxValue;
          hasDecimal = false;
          textBox1.Value = (decimal)_tag.ToTagLong().Data;
          break;
        case TagType.TAG_BYTE:
          textBox1.Minimum = byte.MinValue;
          textBox1.Maximum = byte.MaxValue;
          hasDecimal = false;
          textBox1.Value = (decimal)_tag.ToTagByte().Data;
          break;
      }

    }

    public TagNode NodeTag {
      get { return _tag; }
    }

    private void Apply () {
      if (ValidateInput()) {
        DialogResult = DialogResult.OK;
        Close();
      }
    }

    private bool ValidateInput () {
      return ValidateValueInput();
    }

    private bool ValidateValueInput () {
      try {
        switch (_tag.GetTagType()) {
          case TagType.TAG_BYTE:
            _tag.ToTagByte().Data = unchecked((byte)textBox1.Value);
            break;

          case TagType.TAG_SHORT:
            _tag.ToTagShort().Data = (short)textBox1.Value;
            break;

          case TagType.TAG_INT:
            _tag.ToTagInt().Data = (int)textBox1.Value;
            break;

          case TagType.TAG_LONG:
            _tag.ToTagLong().Data = (long)textBox1.Value;
            break;

          case TagType.TAG_FLOAT:
            _tag.ToTagFloat().Data = (float)textBox1.Value;
            break;

          case TagType.TAG_DOUBLE:
            _tag.ToTagDouble().Data = (double)textBox1.Value;
            break;

          case TagType.TAG_STRING:
            _tag.ToTagString().Data = textBox1.Text;
            break;
        }
      }
      catch (FormatException) {
        MessageBox.Show("The value is formatted incorrectly for the given type.");
        return false;
      }
      catch (OverflowException) {
        MessageBox.Show("The value is outside the acceptable range for the given type.");
        return false;
      }
      catch {
        return false;
      }

      return true;
    }

    private void _buttonOK_Click (object sender, EventArgs e) {
      Apply();
    }
        
    private void TextBox1ValueChanged (object sender, EventArgs e) {
      if(hasDecimal)
        textBox1.DecimalPlaces = Math.Max(0, Math.Min(99, CountDecimalPlaces(textBox1.Value)));
      else 
        textBox1.DecimalPlaces = 0;
    }
    
    private static int CountDecimalPlaces (decimal dec) {
      if(dec == 0) return 0;
      int[] bits = Decimal.GetBits(Math.Abs(dec));
      int exponent = bits[3] >> 16;
      int result = exponent;
      long lowDecimal = bits[0] | (bits[1] >> 8);
      while((lowDecimal % 10) == 0) {
          result--;
          lowDecimal /= 10;
      }
      return result;
    }
  }
}
