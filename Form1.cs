
using System.Windows.Forms; 

namespace Word
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            setfont();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void setfont()
        {
            // Default font
            string fontName = "Tahoma";

            // Get selected font from the combobox if any
            if (cb.SelectedIndex > -1)
            {
                fontName = cb.SelectedItem.ToString();
            }

            // Initialize font style as regular
            FontStyle fontStyle = FontStyle.Regular;

            // Check which styles are selected and combine them
            if (Underline.Checked)
            {
                fontStyle |= FontStyle.Underline;
            }
            if (Bold.Checked)
            {
                fontStyle |= FontStyle.Bold;
            }
            if (Italic.Checked)
            {
                fontStyle |= FontStyle.Italic;
            }


            // Create the font with the selected properties
            Font myFont = new Font(fontName, (int)size.Value, fontStyle);

            // Apply the font to the desired control, for example a TextBox
            text.SelectionFont = myFont;
        }

        private void Form1_Load(object sender, EventArgs e)
        {



            foreach (FontFamily f in FontFamily.Families)
            {
                cb.Items.Add(f.Name);
            }

            cb.SelectedItem = "Tahoma";
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            setfont();
        }

        private void Underline_CheckedChanged(object sender, EventArgs e)
        {
            setfont();
        }

        private void Bold_CheckedChanged(object sender, EventArgs e)
        {
            setfont();
        }

        private void Italic_CheckedChanged(object sender, EventArgs e)
        {
            setfont();
        }


        private void black_Click(object sender, EventArgs e)
        {
            if (chtext.Checked)
            {
                text.SelectionColor = ((Panel)sender).BackColor;
            }
            else
            {
                text.SelectionBackColor = ((Panel)sender).BackColor;
            }
        }

        private void More_Color_Click(object sender, EventArgs e)
        {
            ColorDialog cd=new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                if (chtext.Checked)
                {
                    text.SelectionColor = cd.Color;
                }
                else
                {
                    text.SelectionBackColor = cd.Color;
                }
            }
        }
    }
}
