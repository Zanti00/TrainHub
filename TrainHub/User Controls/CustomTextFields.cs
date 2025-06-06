using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainHub.User_Controls
{
    public partial class CustomTextFields : UserControl
    {
        public CustomTextFields()
        {
            InitializeComponent();
        }

        public string PlaceHolderText
        {
            get => txt.PlaceholderText;
            set => txt.PlaceholderText = value;
        }

        public string TextContent
        {
            get => txt.Content;
            set => txt.Content = value;
        }

        public bool PasswordChar
        {
            get => txt.PasswordChar;
            set => txt.PasswordChar = value;
        }
    }
}
