using System.Linq;
using System.Windows.Forms;
using Google.Apis.Books.v1.Data;

namespace Mybrary
{
    public partial class ResultItem : UserControl
    {
        public Volume volume; 

        public ResultItem(Volume volume)
        {
            this.volume = volume;
            InitializeComponent();
        }

        public void SetControls()
        {
            if (volume.VolumeInfo.Title != null)
            {
                textBox1.Text = volume.VolumeInfo.Title;
            }
            if (volume.VolumeInfo.Authors != null)
            {
                textBox2.Text = volume.VolumeInfo.Authors.First();
            }
            if (volume.VolumeInfo.IndustryIdentifiers != null)
            {
                textBox3.Text = volume.VolumeInfo.IndustryIdentifiers.ElementAt(0).Identifier;
            }
            if (volume.VolumeInfo.Publisher != null)
            {
                textBox4.Text = volume.VolumeInfo.Publisher;
            }
            if (volume.VolumeInfo.ImageLinks != null)
            {
                pictureBox1.ImageLocation = volume.VolumeInfo.ImageLinks.SmallThumbnail;
            }
        }
    }
}
