//librerías que contienen varias funciones predefinidas
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sist_cajero_auto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	
	//los : indican herencia
	public partial class MainForm : Form
	{
		public string user;
		public int pass;
		public int intentos;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		//EventArgs está a la espera de q suceda algo
		void BtnIngresarClick(object sender, EventArgs e)
		{	
			try{
				user = textBoxUser.Text;
				pass = Convert.ToInt16(textBoxPass.Text);
				
				if(user == "admin" && pass == 1234){
					MessageBox.Show("Bienvenido "+user);
					Form1 menuCajero = new Form1();
					menuCajero.Show();
					this.Hide();
					
					}else if(user != "admin" || pass != 1234){	
						MessageBox.Show("Asegurate de ingresar el usuario y contraseña correcta."+intentos);
						intentos++;
						
				}if(intentos == 3){
					
					MessageBox.Show("Has superado los 3 intentos permitidos.");
					this.Close();
					Application.Exit();
				}
		 	}
			 catch(Exception){
		 		MessageBox.Show("Debes ingresar un usuario y una constraseña.");
		 	}
			
		}
		
		void BtnSalirClick(object sender, EventArgs e)
		{
			MessageBox.Show("Good bye!"+user);
			this.Close();
			Application.Exit();
		}
		
		void TextBoxPassKeyPress(object sender, KeyPressEventArgs e)//evento KeyPress
		{
			//condicion para solo números
			if(char.IsDigit(e.KeyChar))
			{
				e.Handled = false;
			}else if(char.IsControl(e.KeyChar)){ //permite usar tecla para borrar 'backspace'
				e.Handled = false;
			}else {
				e.Handled = true;
				MessageBox.Show("Solo se admiten numeros");
			}
		}
	}
}

/*
   Cuando escribo this. se llaman a las propiedades y métodos
  	las llaves -> propiedades
  	las cajitas -> métodos
   rayos -> eventos
*/