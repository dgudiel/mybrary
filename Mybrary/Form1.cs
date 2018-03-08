using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Mybrary
{
    public partial class Form1 : Form
    {
        const int Spacer = 3;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void btSearch_Click(object sender, EventArgs e)
        {
            resultsPanel.Controls.Clear();
            var results = Program.service.Volumes.List(textBox1.Text).Execute().Items.ToArray();

            foreach (var vol in results)
            {
                ResultItem resultItem = new ResultItem(vol);
                ResultItem previous;

                resultItem.SetControls();
                resultsPanel.Controls.Add(resultItem);

                if (resultsPanel.Controls.Count < 2)
                {
                    resultItem.Location = new Point(0, 0);
                }
                else
                {
                    previous = (ResultItem)resultsPanel.Controls[resultsPanel.Controls.Count - 2];
                    resultItem.Location = new Point(0, previous.Location.Y + previous.Height + Spacer);
                }

                resultItem.Width = resultsPanel.Width;
                resultItem.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            }
        }
    }
}
