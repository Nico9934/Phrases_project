
namespace Phrases_project


{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

		}


		string[] ary_list = new string[0];

		private void txt_phrase_keyPress(object sender, KeyPressEventArgs e)
		{
			string new_phrase = txt_phrase.Text;
			if (e.KeyChar == 13)
			{
				if (new_phrase.Length <= 0)
					ShowPersonalMessage("error", "Debes ingresar una frase", "¡Ha ocurrido un problema!");
				else
				{
					ShowPersonalMessage("confirm", "¿Seguro que quieres agregar la frase?", "Confirmar");
					if (list_phrases.Items.Count > 0)
					{
						list_phrases.Visible = true;
						lbl_info.Text = "Haz click en alguna frase para ver sus detalles...";
						btn_clean.Visible = true;
					}
				}

			}
		}

		private void ShowPersonalMessage(string tipo, string mensaje, string titulo)
		{
			msg mensajeForm = new msg(ary_list, this);

			mensajeForm.lbl_title.Text = titulo;
			mensajeForm.lbl_message.Text = mensaje;
			mensajeForm.StartPosition = FormStartPosition.CenterParent;

			switch (tipo)
			{
				case "error":
					mensajeForm.btn_cancel.Hide();
					mensajeForm.pnl_header.BackColor = Color.FromArgb(219, 90, 61);
					txt_phrase.Focus();
					break;
				case "confirm":
					//mensajeForm.btn_accept
					mensajeForm.btn_clean.Hide();
					mensajeForm.pnl_header.BackColor = Color.FromArgb(44, 117, 120);
					break;
				case "clean":
					mensajeForm.btn_accept.Text = "";
					mensajeForm.btn_accept.Hide();
					mensajeForm.pnl_header.BackColor = Color.FromArgb(44, 117, 120);
					break;
			}
			mensajeForm.ShowDialog();
		}

		private void phrase_selected(object sender, EventArgs e)
		{
			string selected_phrase = list_phrases.SelectedItem.ToString();
			lbl_char_count.Text = "Cantidad de caracteres: " + Funciones.char_counter(selected_phrase).ToString();
			lbl_spaces_count.Text = "Cantidad de espacios: " + Funciones.space_counter(selected_phrase).ToString();
			lbl_start_word.Text = "Comienza con la palabra: " + Funciones.started_word(selected_phrase).ToString();
			lbl_finish_word.Text = "Termina con la palabra: " + Funciones.finish_word(selected_phrase).ToString();
		}

		private void btn_clean_MouseEnter(object sender, EventArgs e)
		{
			btn_clean.BackColor = Color.FromArgb(44, 117, 120);
		}

		private void btn_clean_Click(object sender, EventArgs e)
		{
			ShowPersonalMessage("clean", "¿Seguro que quieres limpiar la lista?", "Confirmar" );
		}
	}
}