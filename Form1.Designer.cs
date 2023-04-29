namespace Bouncing_Ball
{
    partial class BouncingBall
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            colorDialog1 = new ColorDialog();
            B1 = new Button();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += MoveBall;
            // 
            // B1
            // 
            B1.BackColor = Color.DimGray;
            B1.Location = new Point(607, 39);
            B1.Name = "B1";
            B1.Size = new Size(153, 32);
            B1.TabIndex = 0;
            B1.Text = "Schimba Culoarea";
            B1.UseVisualStyleBackColor = false;
            B1.Click += B1_Click;
            // 
            // BouncingBall
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(B1);
            Name = "BouncingBall";
            Text = "BouncingBall";
            Paint += Ball;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private ColorDialog colorDialog1;
        private Button B1;
    }
}