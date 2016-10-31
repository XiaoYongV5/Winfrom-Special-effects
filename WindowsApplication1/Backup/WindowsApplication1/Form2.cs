using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form2 : Form
    {
        public Form1 m_f1;
        int m_isredraw = 1;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

            Form1.MakeWindowTpt(handle, 0);

            m_isredraw = 0;
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr handle1 = m_f1.Handle;

            Form1.CLAYUI_InitDialog2(handle, handle1);

            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                Form1.WinRedraw(control.Handle, 0);
            }

            timer1.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            IntPtr handle = this.Handle;
            if (m_isredraw == 1)
                base.OnPaint(e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            if (Form1.IsPlay() == 0)
            {
                timer1.Stop();
                foreach (System.Windows.Forms.Control control in this.Controls)
                {
                    Form1.WinRedraw(control.Handle, 1);
                }
                Update();
            }
            else
                Form1.Redraw(handle, 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

	        m_f1.EnableControl(0);
            m_f1.m_isredraw = 0;

            Form1.desktomemdc1(handle);
            Form1.CLAYUI_OnAnimation(handle, 1, 1, 0, 0);
            m_f1.StartTimer();

            Form1.Redraw(m_f1.Handle, 0);

            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

            m_f1.EnableControl(0);
            m_f1.m_isredraw = 0;

            Form1.desktomemdc1(handle);
            Form1.CLAYUI_OnAnimation(handle, 1, 2, 1, 0);
            m_f1.StartTimer();

            Form1.Redraw(m_f1.Handle, 0);

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

            m_f1.EnableControl(0);
            m_f1.m_isredraw = 0;

            Form1.desktomemdc1(handle);
            Form1.CLAYUI_OnAnimation(handle, 1, 0, 4, 0);
            m_f1.StartTimer();

            Form1.Redraw(m_f1.Handle, 0);

            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

            m_f1.EnableControl(0);
            m_f1.m_isredraw = 0;

            Form1.desktomemdc1(handle);
            Form1.CLAYUI_OnAnimation(handle, 1, 0, 5, 0);
            m_f1.StartTimer();

            Form1.Redraw(m_f1.Handle, 0);

            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

            m_f1.EnableControl(0);
            m_f1.m_isredraw = 0;

            Form1.desktomemdc1(handle);
            Form1.CLAYUI_OnAnimation(handle, 1, 0, 2, 0);
            m_f1.StartTimer();

            Form1.Redraw(m_f1.Handle, 0);

            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

            m_f1.EnableControl(0);
            m_f1.m_isredraw = 0;

            Form1.desktomemdc1(handle);
            Form1.CLAYUI_OnAnimation(handle, 1, 0, 3, 0);
            m_f1.StartTimer();

            Form1.Redraw(m_f1.Handle, 0);

            Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

            m_f1.EnableControl(0);
            m_f1.m_isredraw = 0;

            Form1.desktomemdc1(handle);
            Form1.CLAYUI_OnAnimation(handle, 1, 0, 6, 0);
            m_f1.StartTimer();

            Form1.Redraw(m_f1.Handle, 0);

            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

            m_f1.EnableControl(0);
            m_f1.m_isredraw = 0;

            Form1.desktomemdc1(handle);
            Form1.CLAYUI_OnAnimation(handle, 1, 0, 7, 0);
            m_f1.StartTimer();

            Form1.Redraw(m_f1.Handle, 0);

            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

            m_f1.EnableControl(0);
            m_f1.m_isredraw = 0;

            Form1.desktomemdc1(handle);
            Form1.CLAYUI_OnAnimation(handle, 1, 0, 9, 0);
            m_f1.StartTimer();

            Form1.Redraw(m_f1.Handle, 0);

            Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

            m_f1.EnableControl(0);
            m_f1.m_isredraw = 0;

            Form1.desktomemdc1(handle);
            Form1.CLAYUI_OnAnimation(handle, 1, 0, 10, 0);
            m_f1.StartTimer();

            Form1.Redraw(m_f1.Handle, 0);

            Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

            m_f1.EnableControl(0);
            m_f1.m_isredraw = 0;

            Form1.desktomemdc1(handle);
            Form1.CLAYUI_OnAnimation(handle, 1, 0, 11, 0);
            m_f1.StartTimer();

            Form1.Redraw(m_f1.Handle, 0);

            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;

            m_f1.EnableControl(0);
            m_f1.m_isredraw = 0;

            Form1.desktomemdc1(handle);
            Form1.CLAYUI_OnAnimation(handle, 1, 0, 12, 0);
            m_f1.StartTimer();

            Form1.Redraw(m_f1.Handle, 0);

            Close();
        }
    }
}