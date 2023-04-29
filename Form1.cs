namespace Bouncing_Ball
{
    public partial class BouncingBall : Form
    {
        System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        int culoare = 0;
        int Ox = 0;
        int Oy = 0;
        int l = 45;
        int x = 0;
        int y = 0;
        int mx = 6;
        int my = 11;
        public BouncingBall()
        {
            InitializeComponent();
        }


        private void Ball(object sender, PaintEventArgs e)
        {
            if (culoare == 0)
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.Clear(this.BackColor);
                e.Graphics.FillEllipse(myBrush, x, y, l, l);
                e.Graphics.DrawEllipse(Pens.Black, x, y, l, l);
            }

        }
        private void MoveBall(object sender, EventArgs e)
        {

            if (x <= 0)
                Ox = 0;
            if (x + l >= this.ClientSize.Width)
                Ox = 1;
            if (Ox == 0)
                x += mx;
            else
                x -= mx;

            if (y <= 0)
                Oy = 0;
            if (y + l >= this.ClientSize.Height)
                Oy = 1;
            if (Oy == 0)
                y += my;
            else
                y -= my;

            this.Refresh();
        }




        private void B1_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            colorDlg.AllowFullOpen = false;
            colorDlg.AnyColor = true;
            colorDlg.SolidColorOnly = false;
            colorDlg.Color = Color.Red;

            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                myBrush.Color = colorDlg.Color;
            }
        }

    }
}