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
    public partial class CustomBackButton : UserControl
    {
        public CustomBackButton()
        {
            InitializeComponent();
            backBtn.Click += (s, e) => OnButtonClick(e);
        }

        public EventHandler BackButtonClicked;

        protected virtual void OnButtonClick(EventArgs e)
        {
            BackButtonClicked?.Invoke(this, e);
        }
    }
}
