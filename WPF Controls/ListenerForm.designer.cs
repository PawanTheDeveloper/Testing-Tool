/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 03/03/2010
 * Time: 4:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TesterBuddy
{
	partial class ListenerForm
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
			this.components = new System.ComponentModel.Container();
			this.ListnerMainTabControl = new System.Windows.Forms.TabControl();
			this.EventsTab = new System.Windows.Forms.TabPage();
			this.ListnerEventsTextBox = new System.Windows.Forms.TextBox();
			this.TextPushedTab = new System.Windows.Forms.TabPage();
			this.ListnerTextPushedTextBox = new System.Windows.Forms.TextBox();
			this.ImagePushedTab = new System.Windows.Forms.TabPage();
			this.ListnerPushedPictureBox = new System.Windows.Forms.PictureBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.ListnerMainTabControl.SuspendLayout();
			this.EventsTab.SuspendLayout();
			this.TextPushedTab.SuspendLayout();
			this.ImagePushedTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ListnerPushedPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// ListnerMainTabControl
			// 
			this.ListnerMainTabControl.Controls.Add(this.EventsTab);
			this.ListnerMainTabControl.Controls.Add(this.TextPushedTab);
			this.ListnerMainTabControl.Controls.Add(this.ImagePushedTab);
			this.ListnerMainTabControl.Controls.Add(this.tabPage2);
			this.ListnerMainTabControl.Location = new System.Drawing.Point(10, 20);
			this.ListnerMainTabControl.Name = "ListnerMainTabControl";
			this.ListnerMainTabControl.SelectedIndex = 0;
			this.ListnerMainTabControl.Size = new System.Drawing.Size(606, 503);
			this.ListnerMainTabControl.TabIndex = 0;
			// 
			// EventsTab
			// 
			this.EventsTab.Controls.Add(this.ListnerEventsTextBox);
			this.EventsTab.Location = new System.Drawing.Point(4, 22);
			this.EventsTab.Name = "EventsTab";
			this.EventsTab.Padding = new System.Windows.Forms.Padding(3);
			this.EventsTab.Size = new System.Drawing.Size(598, 477);
			this.EventsTab.TabIndex = 0;
			this.EventsTab.Text = "Events";
			this.EventsTab.UseVisualStyleBackColor = true;
			// 
			// ListnerEventsTextBox
			// 
			this.ListnerEventsTextBox.Location = new System.Drawing.Point(3, 3);
			this.ListnerEventsTextBox.Multiline = true;
			this.ListnerEventsTextBox.Name = "ListnerEventsTextBox";
			this.ListnerEventsTextBox.Size = new System.Drawing.Size(589, 468);
			this.ListnerEventsTextBox.TabIndex = 0;
			this.ListnerEventsTextBox.TextChanged += new System.EventHandler(this.ListnerEventsTextBoxTextChanged);
			// 
			// TextPushedTab
			// 
			this.TextPushedTab.Controls.Add(this.ListnerTextPushedTextBox);
			this.TextPushedTab.Location = new System.Drawing.Point(4, 22);
			this.TextPushedTab.Name = "TextPushedTab";
			this.TextPushedTab.Padding = new System.Windows.Forms.Padding(3);
			this.TextPushedTab.Size = new System.Drawing.Size(598, 477);
			this.TextPushedTab.TabIndex = 1;
			this.TextPushedTab.Text = "Text";
			this.TextPushedTab.UseVisualStyleBackColor = true;
			// 
			// ListnerTextPushedTextBox
			// 
			this.ListnerTextPushedTextBox.Location = new System.Drawing.Point(3, 3);
			this.ListnerTextPushedTextBox.Multiline = true;
			this.ListnerTextPushedTextBox.Name = "ListnerTextPushedTextBox";
			this.ListnerTextPushedTextBox.Size = new System.Drawing.Size(589, 468);
			this.ListnerTextPushedTextBox.TabIndex = 1;
			// 
			// ImagePushedTab
			// 
			this.ImagePushedTab.Controls.Add(this.ListnerPushedPictureBox);
			this.ImagePushedTab.Location = new System.Drawing.Point(4, 22);
			this.ImagePushedTab.Name = "ImagePushedTab";
			this.ImagePushedTab.Padding = new System.Windows.Forms.Padding(3);
			this.ImagePushedTab.Size = new System.Drawing.Size(598, 477);
			this.ImagePushedTab.TabIndex = 2;
			this.ImagePushedTab.Text = "Images";
			this.ImagePushedTab.UseVisualStyleBackColor = true;
			// 
			// ListnerPushedPictureBox
			// 
			this.ListnerPushedPictureBox.Location = new System.Drawing.Point(5, 3);
			this.ListnerPushedPictureBox.Name = "ListnerPushedPictureBox";
			this.ListnerPushedPictureBox.Size = new System.Drawing.Size(587, 464);
			this.ListnerPushedPictureBox.TabIndex = 0;
			this.ListnerPushedPictureBox.TabStop = false;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(598, 477);
			this.tabPage2.TabIndex = 3;
			this.tabPage2.Text = "Files";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
			// 
			// ListenerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(631, 534);
			this.Controls.Add(this.ListnerMainTabControl);
			this.Name = "ListenerForm";
			this.Text = "ListenerForm";
			this.Load += new System.EventHandler(this.ListenerFormLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListenerFormFormClosed);
			this.ListnerMainTabControl.ResumeLayout(false);
			this.EventsTab.ResumeLayout(false);
			this.EventsTab.PerformLayout();
			this.TextPushedTab.ResumeLayout(false);
			this.TextPushedTab.PerformLayout();
			this.ImagePushedTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ListnerPushedPictureBox)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.PictureBox ListnerPushedPictureBox;
		private System.Windows.Forms.TabPage ImagePushedTab;
		private System.Windows.Forms.TextBox ListnerTextPushedTextBox;
		private System.Windows.Forms.TabPage TextPushedTab;
		private System.Windows.Forms.TextBox ListnerEventsTextBox;
		private System.Windows.Forms.TabPage EventsTab;
		private System.Windows.Forms.TabControl ListnerMainTabControl;
	}
}
