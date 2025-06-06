using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrainHub
{
    public partial class CustomButton : UserControl
    {
        public CustomButton()
        {
            InitializeComponent();
            btn.Click += (s, e) => OnButtonClick(e);
        }

        public event EventHandler ButtonClicked;

        public string ButtonContent
        {
            get => btn.Content;
            set => btn.Content = value;
        }

        protected virtual void OnButtonClick(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

    }
}
