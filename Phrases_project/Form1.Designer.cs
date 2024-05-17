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
			lbl_info = new Label();
			grp_box_detail = new GroupBox();
			lbl_finish_word = new Label();
			lbl_start_word = new Label();
			lbl_spaces_count = new Label();
			lbl_char_count = new Label();
			btn_clean = new Button();
			panel1.SuspendLayout();
			grp_box_detail.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.FromArgb(0, 150, 137);
			panel1.Controls.Add(label1);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(1203, 90);
			panel1.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Poppins Light", 11F, FontStyle.Regular, GraphicsUnit.Point);
			label1.ForeColor = SystemColors.Control;
			label1.Location = new Point(440, 25);
			label1.Name = "label1";
			label1.Size = new Size(314, 39);
			label1.TabIndex = 0;
			label1.Text = "Entregable 5 - Phrases App";
			// 
			// txt_phrase
			// 
			txt_phrase.BackColor = SystemColors.Control;
			txt_phrase.BorderStyle = BorderStyle.None;
			txt_phrase.Location = new Point(213, 151);
			txt_phrase.Name = "txt_phrase";
			txt_phrase.Size = new Size(407, 24);
			txt_phrase.TabIndex = 1;
			txt_phrase.KeyPress += txt_phrase_keyPress;
			// 
			// panel2
			// 
			panel2.BackColor = Color.FromArgb(0, 150, 137);
			panel2.Location = new Point(213, 177);
			panel2.Name = "panel2";
			panel2.Size = new Size(407, 1);
			panel2.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label2.Location = new Point(38, 154);
			label2.Name = "label2";
			label2.Size = new Size(172, 31);
			label2.TabIndex = 3;
			label2.Text = "Ingresa una frase:";
			// 
			// list_phrases
			// 
			list_phrases.BackColor = SystemColors.Control;
			list_phrases.BorderStyle = BorderStyle.FixedSingle;
			list_phrases.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
			list_phrases.FormattingEnabled = true;
			list_phrases.ItemHeight = 31;
			list_phrases.Location = new Point(42, 277);
			list_phrases.Name = "list_phrases";
			list_phrases.Size = new Size(582, 250);
			list_phrases.TabIndex = 4;
			list_phrases.Visible = false;
			list_phrases.SelectedIndexChanged += phrase_selected;
			// 
			// lbl_info
			// 
			lbl_info.AutoSize = true;
			lbl_info.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_info.Location = new Point(42, 216);
			lbl_info.Name = "lbl_info";
			lbl_info.Size = new Size(0, 31);
			lbl_info.TabIndex = 5;
			// 
			// grp_box_detail
			// 
			grp_box_detail.Controls.Add(lbl_finish_word);
			grp_box_detail.Controls.Add(lbl_start_word);
			grp_box_detail.Controls.Add(lbl_spaces_count);
			grp_box_detail.Controls.Add(lbl_char_count);
			grp_box_detail.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
			grp_box_detail.Location = new Point(731, 166);
			grp_box_detail.Name = "grp_box_detail";
			grp_box_detail.Size = new Size(426, 437);
			grp_box_detail.TabIndex = 6;
			grp_box_detail.TabStop = false;
			grp_box_detail.Text = "Detalle";
			// 
			// lbl_finish_word
			// 
			lbl_finish_word.AutoSize = true;
			lbl_finish_word.Location = new Point(35, 166);
			lbl_finish_word.Name = "lbl_finish_word";
			lbl_finish_word.Size = new Size(230, 31);
			lbl_finish_word.TabIndex = 3;
			lbl_finish_word.Text = "Termina con la palabra: ";
			// 
			// lbl_start_word
			// 
			lbl_start_word.AutoSize = true;
			lbl_start_word.Location = new Point(35, 129);
			lbl_start_word.Name = "lbl_start_word";
			lbl_start_word.Size = new Size(248, 31);
			lbl_start_word.TabIndex = 2;
			lbl_start_word.Text = "Comienza con la palabra: ";
			// 
			// lbl_spaces_count
			// 
			lbl_spaces_count.AutoSize = true;
			lbl_spaces_count.Location = new Point(35, 89);
			lbl_spaces_count.Name = "lbl_spaces_count";
			lbl_spaces_count.Size = new Size(218, 31);
			lbl_spaces_count.TabIndex = 1;
			lbl_spaces_count.Text = "Cantidad de espacios: ";
			// 
			// lbl_char_count
			// 
			lbl_char_count.AutoSize = true;
			lbl_char_count.Location = new Point(35, 53);
			lbl_char_count.Name = "lbl_char_count";
			lbl_char_count.Size = new Size(230, 31);
			lbl_char_count.TabIndex = 0;
			lbl_char_count.Text = "Cantidad de caracteres:";
			// 
			// btn_clean
			// 
			btn_clean.BackColor = Color.FromArgb(0, 150, 137);
			btn_clean.Cursor = Cursors.Hand;
			btn_clean.FlatAppearance.MouseDownBackColor = Color.FromArgb(44, 117, 120);
			btn_clean.FlatStyle = FlatStyle.Flat;
			btn_clean.Font = new Font("Poppins Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
			btn_clean.ForeColor = SystemColors.Control;
			btn_clean.Location = new Point(42, 547);
			btn_clean.Name = "btn_clean";
			btn_clean.Size = new Size(582, 46);
			btn_clean.TabIndex = 7;
			btn_clean.Text = "Limpiar todo";
			btn_clean.UseVisualStyleBackColor = false;
			btn_clean.Visible = false;
			btn_clean.Click += btn_clean_Click;
			btn_clean.MouseEnter += btn_clean_MouseEnter;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1203, 615);
			Controls.Add(btn_clean);
			Controls.Add(grp_box_detail);
			Controls.Add(lbl_info);
			Controls.Add(list_phrases);
			Controls.Add(label2);
			Controls.Add(panel2);
			Controls.Add(txt_phrase);
			Controls.Add(panel1);
			Name = "Form1";
			Text = "Form1";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			grp_box_detail.ResumeLayout(false);
			grp_box_detail.PerformLayout();
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
		private Label lbl_info;
		private GroupBox grp_box_detail;
		private Label lbl_finish_word;
		private Label lbl_start_word;
		private Label lbl_spaces_count;
		private Label lbl_char_count;
		private Button btn_clean;
	}
}