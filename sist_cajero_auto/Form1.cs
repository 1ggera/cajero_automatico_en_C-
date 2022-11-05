/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 2/10/2022
 * Time: 00:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace sist_cajero_auto
{
	public partial class Form1 : Form
	{
		int saldoDisp, carga, deposito;
		
		public Form1()
		{
			InitializeComponent();
		}
		
		void BtnConsultaClick(object sender, EventArgs e)
		{
			MessageBox.Show("Tu saldo disponible es: $" + saldoDisp);
		}
		
		void BtnExtraccionClick(object sender, EventArgs e)
		{
			try
            {
				int extraccion = Convert.ToInt32(textBoxSaldo.Text);
				
				if(extraccion < 100){
					MessageBox.Show("Debes elegir un monto igual o superior a $100");
					
				}if((extraccion % 100 == 0) && (extraccion <= saldoDisp) ){
					
					saldoDisp = saldoDisp - extraccion;
					MessageBox.Show("Has extraído: $"+extraccion+".\nTu saldo es: "+saldoDisp);
					textBoxSaldo.Clear();
					// algoritmo de billetes
					
					
						int resultado = extraccion;
						int [] billetes = {1000, 500, 200, 100};
						
						for(int j=0; j<4; j++){
			           		//lleva la cuenta de los billetes de cada denominación
							int contador=0;
							if(resultado >= billetes[j]){
						        for(int i = resultado; i >= billetes[j]; i = i - billetes[j]){
									//es la cantidad de billetes de cada denominación
									contador++;
							        resultado = resultado - billetes[j];
							        }
								}
								//comprueba que no se muestren cantidades de billetes en cero
								if(contador>0){
									//textBox1.Text += ("Tienes "+ contador +"billetes de "+ billetesDolar[j]+"\r");
									MessageBox.Show((Convert.ToString(contador)+ " Billetes de " + billetes[j] + " pesos"));
								}
					    }
				}else{
					MessageBox.Show("Debes extraer un valor multiplo de 100");
				}	
            }
            catch(Exception)
            {
			   MessageBox.Show("Por favor, ingrese datos correctos.");
            }
		}
		
		void BtnCargarSaldoClick(object sender, EventArgs e)
		{
			try
            {
                carga = Convert.ToInt32(textBoxSaldo.Text);
				saldoDisp = saldoDisp + carga;
				MessageBox.Show("Se cargó: "+carga+"\nTu saldo es: "+saldoDisp);
				textBoxSaldo.Clear();
            }
            catch (Exception)
            {
			   MessageBox.Show("Por favor, ingrese datos correctos.");
            }
		}
		
		void BtnDepositarClick(object sender, EventArgs e)
		{
			try
            {
                deposito = Convert.ToInt32(textBoxSaldo.Text);
				saldoDisp = saldoDisp + deposito;
				MessageBox.Show("Se depositaron: "+deposito+"\nTu saldo es: "+saldoDisp);
				textBoxSaldo.Clear();
            }
            catch (Exception)
            {
			   MessageBox.Show("Por favor, ingrese datos correctos.");
            }
		}
		
		void BtnTicketClick(object sender, EventArgs e)
		{
			MessageBox.Show("Últimos movimientos: \n ");
		}
		void BtnSalirClick(object sender, EventArgs e)
		{
			MessageBox.Show("Últimos movimientos: \n ");
			this.Close();
			Application.Exit();
		}
	}
}