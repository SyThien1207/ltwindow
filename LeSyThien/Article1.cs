using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Window
{
    public partial class Article1 : Form
    {
        public Article1()
        {
            InitializeComponent();
        }

         void Article1_Load(object sender, EventArgs e)
        {
            InfoWindows iw = new InfoWindows();
            iw.Width = this.Size.Width;
            iw.Height = this.Size.Height;
            Write(iw);
        }

         void Article1_ResizeEnd(object sender, EventArgs e)
        {
            InfoWindows iw =new InfoWindows();
            iw.Width=this.Size.Width;
            iw.Height=this.Size.Height;
            Write(iw);
        }
        string path = @"D:\form.xml";
        public void Write(InfoWindows iw)
        {
            XmlSerializer writer= new XmlSerializer(typeof(InfoWindows));
            StreamWriter file= new StreamWriter(path);
            writer.Serialize(file, iw);
            file.Close();
        }
    }
}
