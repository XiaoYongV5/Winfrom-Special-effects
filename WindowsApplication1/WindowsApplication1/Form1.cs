using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        [DllImport(@"clayui_forcsharp.dll")]
        public static extern void CLAYUI_CSharp_Init(IntPtr handle);

        [DllImport(@"clayui_forcsharp.dll")]
        public static extern void CLAYUI_CSharp_Release();

        [DllImport(@"clayui_forcsharp.dll")]
        public static extern void CLAYUI_OnAnimation(IntPtr handle, int vert, int flag, int anitype, int invert);

        [DllImport(@"clayui_forcsharp.dll")]
        public static extern void Redraw(IntPtr handle, int usetime);

        [DllImport(@"clayui_forcsharp.dll")]
        public static extern int IsPlay();

        [DllImport(@"clayui_forcsharp.dll")]
        public static extern void CLAYUI_InitDialog2(IntPtr handle, IntPtr handle1);

        [DllImport(@"clayui_forcsharp.dll")]
        public static extern void MakeWindowTpt(IntPtr handle, int factor);

        [DllImport(@"clayui_forcsharp.dll")]
        public static extern void WinRedraw(IntPtr handle, int redraw);

        [DllImport(@"clayui_forcsharp.dll")]
        public static extern void desktomemdc1(IntPtr handle);

        public int m_isredraw = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            CLAYUI_CSharp_Init(handle);
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            IntPtr handle = this.Handle;
            if (m_isredraw == 1)
                base.OnPaint(e);
        }

        public void EnableControl(int isenable)
        {
            foreach (System.Windows.Forms.Control control in this.Controls)
            {
                Form1.WinRedraw(control.Handle, isenable);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 1, 0, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            IntPtr handle = this.Handle;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CLAYUI_CSharp_Release();
        }

        public void StartTimer()
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            if (IsPlay() == 0)
            {
                EnableControl(1);
                timer1.Stop();
            }
            else
                Redraw(handle, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 2, 1, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 0, 4, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 0, 2, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 0, 3, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 0, 5, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 0, 6, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 0, 7, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 3, 8, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 0, 9, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 0, 10, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 0, 11, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            IntPtr handle = this.Handle;
            IntPtr h1 = (IntPtr)0, h2 = (IntPtr)0;
            CLAYUI_OnAnimation(handle, 0, 0, 12, 0);
            Form2 f2 = new Form2();
            f2.m_f1 = this;
            f2.ShowDialog();
        }
    }
}