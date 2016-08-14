/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 11/08/2009
 * Time: 11:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TesterBuddy
{
	partial class HostNameDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(102, 21);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(313, 22);
			this.textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(102, 144);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(50, 22);
			this.textBox2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 24);
			this.label1.TabIndex = 2;
			this.label1.Text = "Host Name:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(10, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Host IP:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(187, 144);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(58, 22);
			this.textBox3.TabIndex = 4;
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(276, 144);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(54, 22);
			this.textBox4.TabIndex = 5;
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(359, 144);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(56, 22);
			this.textBox5.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(158, 143);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(23, 23);
			this.label3.TabIndex = 7;
			this.label3.Text = ".";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(247, 142);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(23, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = ".";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(336, 142);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(23, 23);
			this.label5.TabIndex = 9;
			this.label5.Text = ".";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(8, 77);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(88, 24);
			this.label6.TabIndex = 11;
			this.label6.Text = "Alias (opt):";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(102, 79);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(313, 22);
			this.textBox6.TabIndex = 10;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(328, 182);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(87, 25);
			this.button1.TabIndex = 12;
			this.button1.Text = "OK";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// HostNameDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 219);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Name = "HostNameDialog";
			this.Text = "HostNameDialog";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
	}
}
