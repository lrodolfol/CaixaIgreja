using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuncoesCaixaCeo
{
    public class Class1
    {
        public static void limpaCampos(GroupBox grp)
        {
            foreach (Control c in grp.Controls)
            {
                if (c is TextBox || c is RichTextBox || c is Label) { c.Text = ""; } //LIMPA TEXTBOX E RICHTEXTBOX
                if (c is ComboBox) { (c as ComboBox).SelectedIndex = 0; } //ZERA COMBOBOX
            }
        }
    }
}
