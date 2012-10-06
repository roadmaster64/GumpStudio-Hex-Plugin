using System.Windows.Forms;

namespace ConversionUtility
{
    public partial class WaitFormLoading : Form
    {
        public WaitFormLoading(string html)
        {
            InitializeComponent();
            Text += "....";
            label2.Text = html;
        }
    }
}
