namespace Phrases_project
{
	partial class Form1
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
			panel1 = new Panel();
			label1 = new Label();
			txt_phrase = new TextBox();
			panel2 = new Panel();
			label2 = new Label();
			list_phrases = new ListBox();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(0, 150, 137);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(811, 90);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Poppins Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(230, 27);
			label1.Name = "label1";
			label1.Size = new Size(314, 39);
			label1.TabIndex = 0;
			label1.Text = "Entregable 5 - Phrases App";
			// 
			// txt_phrase
			// 
			txt_phrase.BackColor = SystemColors.Control;
			txt_phrase.BorderStyle = BorderStyle.None;
			txt_phrase.Location = new Point(267, 114);
			txt_phrase.Name = "txt_phrase";
			txt_phrase.Size = new Size(407, 24);
			txt_phrase.TabIndex = 1;
			txt_phrase.KeyPress += txt_phrase_keyPress;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(0, 150, 137);
			panel2.Location = new Point(267, 140);
			panel2.Name = "panel2";
			panel2.Size = new Size(407, 1);
			panel2.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(92, 117);
			label2.Name = "label2";
			label2.Size = new Size(172, 31);
			label2.TabIndex = 3;
			label2.Text = "Ingresa una frase:";
			// 
			// list_phrases
			// 
			list_phrases.BackColor = SystemColors.Control;
			list_phrases.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
			list_phrases.FormattingEnabled = true;
			list_phrases.ItemHeight = 31;
			list_phrases.Location = new Point(118, 248);
			list_phrases.Name = "list_phrases";
			list_phrases.Size = new Size(556, 252);
			list_phrases.TabIndex = 4;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(811, 615);
			Controls.Add(list_phrases);
			Controls.Add(label2);
			Controls.Add(panel2);
			Controls.Add(txt_phrase);
			Controls.Add(panel1);
			Name = "Form1";
			Text = "Form1";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		public TextBox txt_phrase;
		private Panel panel2;
		private Label label2;
		public ListBox list_phrases;
	}
}