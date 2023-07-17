using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Window
{
    public partial class Article : Form
    {
        public Article()
        {
            InitializeComponent();
        }

         void Article_Load(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + "-" + height.ToString();
        }

         void Article_ResizeEnd(object sender, EventArgs e)
        {
            int width = this.Size.Width;
            int height = this.Size.Height;
            this.Text = width.ToString() + "-" + height.ToString();
        }

      
    } 
}

  