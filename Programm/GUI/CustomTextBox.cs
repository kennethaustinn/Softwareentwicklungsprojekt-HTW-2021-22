using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class CustomTextBox : UserControl
    {
        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        public CustomTextBox()
        {
            InitializeComponent();
        }

        public Color BorderColor { get => borderColor; set => borderColor = value;}
        public int BorderSize { get => borderSize; set => borderSize = value; }
        public bool UnderlinedStyle { get => underlinedStyle; set => underlinedStyle = value; }
    }
}
