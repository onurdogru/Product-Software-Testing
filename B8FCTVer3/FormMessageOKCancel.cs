using System;
using System.Drawing;
using System.Windows.Forms;

namespace B8FCTVer3
{
    public partial class FormMessageOKCancel : Form
    {
        #region FormMessageContinueCancel related
        public FormMessageOKCancel()
        {
            InitializeComponent();
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panelTitle_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panelTitle_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            panelTitle_MouseDown(sender, e);
        }

        private void lblTitle_MouseMove(object sender, MouseEventArgs e)
        {
            panelTitle_MouseMove(sender, e);
        }

        private void lblTitle_MouseUp(object sender, MouseEventArgs e)
        {
            panelTitle_MouseUp(sender, e);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        #endregion

        public Image MessageIcon
        {
            get { return picMessage.Image; }
            set { picMessage.Image = value; }
        }

        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }
        public string Title
        {
            get { return this.Text; }
            set { this.Text = value; }
        }

        public Button ButtonOK
        {
            get { return btnOK; }
        }

        public Button ButtonCancel
        {
            get { return btnCancel; }
        }
    }
}
