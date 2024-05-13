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
					ShowPersonalMessage("confirm", "Confirmar", "¿Seguro que quieres agregar la frase?");
				}
			}
		}

		private void ShowPersonalMessage(string tipo, string mensaje, string titulo)
		{
			// Crear una instancia de tu formulario msg
			msg mensajeForm = new msg(ary_list, this );

			// Configurar las propiedades del formulario msg
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
					mensajeForm.pnl_header.BackColor = Color.FromArgb(44, 117, 120);
					break;
			}


			// Mostrar el formulario msg como un diálogo modal
			mensajeForm.ShowDialog();
		}


	}
}