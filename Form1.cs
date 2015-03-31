using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;
using System.Runtime.InteropServices;


namespace TestBase64
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtDecoded;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.TextBox txtEncoded;
        private System.Windows.Forms.MainMenu mainMenu1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Button button1;
        private IContainer components;
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        private static extern bool ReleaseCapture();

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDecoded = new System.Windows.Forms.TextBox();
            this.txtEncoded = new System.Windows.Forms.TextBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDecoded
            // 
            this.txtDecoded.Location = new System.Drawing.Point(0, 23);
            this.txtDecoded.Multiline = true;
            this.txtDecoded.Name = "txtDecoded";
            this.txtDecoded.Size = new System.Drawing.Size(304, 80);
            this.txtDecoded.TabIndex = 0;
            this.txtDecoded.Text = "decoded";
            // 
            // txtEncoded
            // 
            this.txtEncoded.Location = new System.Drawing.Point(378, 23);
            this.txtEncoded.Multiline = true;
            this.txtEncoded.Name = "txtEncoded";
            this.txtEncoded.Size = new System.Drawing.Size(303, 80);
            this.txtEncoded.TabIndex = 1;
            this.txtEncoded.Text = "encoded";
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(301, 23);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(78, 80);
            this.btnEncode.TabIndex = 2;
            this.btnEncode.Text = "Encode >";
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Base64 Encode by Nguyen Minh Huy";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.menuStrip1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.menuStrip1_KeyDown);
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(654, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 24);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(681, 118);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.txtEncoded);
            this.Controls.Add(this.txtDecoded);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestBase64";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void btnEncode_Click(object sender, System.EventArgs e)
		{
			//first get the bytes for the original
			byte[] data=System.Text.UnicodeEncoding.UTF8.GetBytes(txtDecoded.Text);
			Base64Encoder myEncoder=new Base64Encoder(data);
			StringBuilder sb=new StringBuilder();

			sb.Append(myEncoder.GetEncoded());

			txtEncoded.Text=sb.ToString();
		}

		private void btnDecode_Click(object sender, System.EventArgs e)
		{
			char[] data=txtEncoded.Text.ToCharArray();
			Base64Decoder myDecoder=new Base64Decoder(data);
			StringBuilder sb=new StringBuilder();

			byte[] temp=myDecoder.GetDecoded();
			sb.Append(System.Text.UTF8Encoding.UTF8.GetChars(temp));

			txtDecoded.Text=sb.ToString();
		}

		private void menuAbout_Click(object sender, System.EventArgs e)
		{
            About frm = new About();
            frm.TopMost = true;
            frm.Show();
		}

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About fm = new About();
            fm.TopMost = true;
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }

        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void menuStrip1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
	}
}
