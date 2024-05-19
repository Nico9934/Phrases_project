namespace Phrases_project
{
	partial class msg
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			btn_understood = new Button();
			btn_clean = new Button();
			btn_cancel = new Button();
			lbl_message = new Label();
			btn_accept = new Button();
			pnl_header = new Panel();
			lbl_title = new Label();
			panel1.SuspendLayout();
			pnl_header.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlLightLight;
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(btn_understood);
			panel1.Controls.Add(btn_clean);
			panel1.Controls.Add(btn_cancel);
			panel1.Controls.Add(lbl_message);
			panel1.Controls.Add(btn_accept);
			panel1.Controls.Add(pnl_header);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(517, 175);
			panel1.TabIndex = 0;
			// 
			// btn_understood
			// 
			btn_understood.BackColor = SystemColors.ControlLight;
			btn_understood.FlatStyle = FlatStyle.Flat;
			btn_understood.Font = new Font("Poppins Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
			btn_understood.Location = new Point(381, 128);
			btn_understood.Name = "btn_understood";
			btn_understood.Size = new Size(112, 34);
			btn_understood.TabIndex = 5;
			btn_understood.Text = "¡Entendido!";
			btn_understood.UseVisualStyleBackColor = false;
			btn_understood.Click += btn_understood_Click;
			// 
			// btn_clean
			// 
			btn_clean.BackColor = SystemColors.ControlLight;
			btn_clean.FlatStyle = FlatStyle.Flat;
			btn_clean.Font = new Font("Poppins Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
			btn_clean.Location = new Point(145, 128);
			btn_clean.Name = "btn_clean";
			btn_clean.Size = new Size(112, 34);
			btn_clean.TabIndex = 4;
			btn_clean.Text = "Limpiar";
			btn_clean.UseVisualStyleBackColor = false;
			btn_clean.Click += btn_clean_Click;
			// 
			// btn_cancel
			// 
			btn_cancel.BackColor = SystemColors.ControlLight;
			btn_cancel.FlatStyle = FlatStyle.Flat;
			btn_cancel.Font = new Font("Poppins Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
			btn_cancel.Location = new Point(263, 128);
			btn_cancel.Name = "btn_cancel";
			btn_cancel.Size = new Size(112, 34);
			btn_cancel.TabIndex = 3;
			btn_cancel.Text = "Cancelar";
			btn_cancel.UseVisualStyleBackColor = false;
			btn_cancel.Click += btn_cancel_Click;
			// 
			// lbl_message
			// 
			lbl_message.AutoSize = true;
			lbl_message.Font = new Font("Poppins Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_message.Location = new Point(42, 86);
			lbl_message.Name = "lbl_message";
			lbl_message.Size = new Size(0, 28);
			lbl_message.TabIndex = 2;
			// 
			// btn_accept
			// 
			btn_accept.BackColor = SystemColors.ControlLight;
			btn_accept.FlatStyle = FlatStyle.Flat;
			btn_accept.Font = new Font("Poppins Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
			btn_accept.Location = new Point(27, 128);
			btn_accept.Name = "btn_accept";
			btn_accept.Size = new Size(112, 34);
			btn_accept.TabIndex = 1;
			btn_accept.Text = "Aceptar";
			btn_accept.UseVisualStyleBackColor = false;
			btn_accept.Click += btn_accept_Click;
			// 
			// pnl_header
			// 
			pnl_header.BackColor = Color.FromArgb(142, 0, 0);
			pnl_header.Controls.Add(lbl_title);
			pnl_header.Dock = DockStyle.Top;
			pnl_header.Location = new Point(0, 0);
			pnl_header.Name = "pnl_header";
			pnl_header.Size = new Size(515, 58);
			pnl_header.TabIndex = 0;
			// 
			// lbl_title
			// 
			lbl_title.AutoSize = true;
			lbl_title.Font = new Font("Poppins Light", 8F, FontStyle.Regular, GraphicsUnit.Point);
			lbl_title.ForeColor = SystemColors.Control;
			lbl_title.Location = new Point(42, 17);
			lbl_title.Name = "lbl_title";
			lbl_title.Size = new Size(0, 28);
			lbl_title.TabIndex = 0;
			// 
			// msg
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(517, 175);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.None;
			Name = "msg";
			Text = "msg_form";
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			pnl_header.ResumeLayout(false);
			pnl_header.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		public Panel pnl_header;
		public Label lbl_title;
		public Label lbl_message;
		public Button btn_accept;
		public Button btn_cancel;
		public Button btn_clean;
		public Button btn_understood;
	}
}