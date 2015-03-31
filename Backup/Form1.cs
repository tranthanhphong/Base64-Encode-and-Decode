using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Text;

namespace TestBase64
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.TextBox txtDecoded;
		private System.Windows.Forms.Button btnEncode;
		private System.Windows.Forms.Button btnDecode;
		private System.Windows.Forms.TextBox txtEncoded;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuAbout;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
			this.txtDecoded = new System.Windows.Forms.TextBox();
			this.txtEncoded = new System.Windows.Forms.TextBox();
			this.btnEncode = new System.Windows.Forms.Button();
			this.btnDecode = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.menuAbout = new System.Windows.Forms.MenuItem();
			this.SuspendLayout();
			// 
			// txtDecoded
			// 
			this.txtDecoded.Location = new System.Drawing.Point(144, 24);
			this.txtDecoded.Multiline = true;
			this.txtDecoded.Name = "txtDecoded";
			this.txtDecoded.Size = new System.Drawing.Size(304, 80);
			this.txtDecoded.TabIndex = 0;
			this.txtDecoded.Text = "decoded";
			// 
			// txtEncoded
			// 
			this.txtEncoded.Location = new System.Drawing.Point(144, 176);
			this.txtEncoded.Multiline = true;
			this.txtEncoded.Name = "txtEncoded";
			this.txtEncoded.Size = new System.Drawing.Size(304, 88);
			this.txtEncoded.TabIndex = 1;
			this.txtEncoded.Text = "encoded";
			// 
			// btnEncode
			// 
			this.btnEncode.Location = new System.Drawing.Point(176, 128);
			this.btnEncode.Name = "btnEncode";
			this.btnEncode.Size = new System.Drawing.Size(104, 23);
			this.btnEncode.TabIndex = 2;
			this.btnEncode.Text = "Encode";
			this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
			// 
			// btnDecode
			// 
			this.btnDecode.Location = new System.Drawing.Point(312, 128);
			this.btnDecode.Name = "btnDecode";
			this.btnDecode.TabIndex = 3;
			this.btnDecode.Text = "Decode";
			this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(32, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(104, 23);
			this.label1.TabIndex = 4;
			this.label1.Text = "Original Text";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(32, 208);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(104, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Base64 Encoded";
			// 
			// mainMenu1
			// 
			this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
																					  this.menuAbout});
			// 
			// menuAbout
			// 
			this.menuAbout.Index = 0;
			this.menuAbout.Text = "&About";
			this.menuAbout.Click += new System.EventHandler(this.menuAbout_Click);
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(472, 273);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnDecode);
			this.Controls.Add(this.btnEncode);
			this.Controls.Add(this.txtEncoded);
			this.Controls.Add(this.txtDecoded);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Menu = this.mainMenu1;
			this.Name = "Form1";
			this.Text = "TestBase64";
			this.ResumeLayout(false);

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
			MessageBox.Show("This Base64 encoder/decoder is written by Wei Cheng, 2003");
		}
	}
}
