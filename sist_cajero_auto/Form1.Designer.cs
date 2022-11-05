/*
 * Created by SharpDevelop.
 * User: 1
 * Date: 2/10/2022
 * Time: 00:59
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sist_cajero_auto
{
	partial class Form1
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
			this.textBoxSaldo = new System.Windows.Forms.TextBox();
			this.btnConsulta = new System.Windows.Forms.Button();
			this.btnCargarSaldo = new System.Windows.Forms.Button();
			this.btnExtraccion = new System.Windows.Forms.Button();
			this.btnDepositar = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnTicket = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBoxSaldo
			// 
			this.textBoxSaldo.Location = new System.Drawing.Point(87, 56);
			this.textBoxSaldo.Name = "textBoxSaldo";
			this.textBoxSaldo.Size = new System.Drawing.Size(111, 20);
			this.textBoxSaldo.TabIndex = 0;
			// 
			// btnConsulta
			// 
			this.btnConsulta.Location = new System.Drawing.Point(12, 19);
			this.btnConsulta.Name = "btnConsulta";
			this.btnConsulta.Size = new System.Drawing.Size(84, 23);
			this.btnConsulta.TabIndex = 1;
			this.btnConsulta.Text = "Consulta";
			this.btnConsulta.UseVisualStyleBackColor = true;
			this.btnConsulta.Click += new System.EventHandler(this.BtnConsultaClick);
			// 
			// btnCargarSaldo
			// 
			this.btnCargarSaldo.Location = new System.Drawing.Point(12, 61);
			this.btnCargarSaldo.Name = "btnCargarSaldo";
			this.btnCargarSaldo.Size = new System.Drawing.Size(84, 23);
			this.btnCargarSaldo.TabIndex = 2;
			this.btnCargarSaldo.Text = "Cargar Saldo";
			this.btnCargarSaldo.UseVisualStyleBackColor = true;
			this.btnCargarSaldo.Click += new System.EventHandler(this.BtnCargarSaldoClick);
			// 
			// btnExtraccion
			// 
			this.btnExtraccion.Location = new System.Drawing.Point(123, 19);
			this.btnExtraccion.Name = "btnExtraccion";
			this.btnExtraccion.Size = new System.Drawing.Size(84, 23);
			this.btnExtraccion.TabIndex = 3;
			this.btnExtraccion.Text = "Extracción";
			this.btnExtraccion.UseVisualStyleBackColor = true;
			this.btnExtraccion.Click += new System.EventHandler(this.BtnExtraccionClick);
			// 
			// btnDepositar
			// 
			this.btnDepositar.Location = new System.Drawing.Point(123, 60);
			this.btnDepositar.Name = "btnDepositar";
			this.btnDepositar.Size = new System.Drawing.Size(84, 24);
			this.btnDepositar.TabIndex = 4;
			this.btnDepositar.Text = "Depósito";
			this.btnDepositar.UseVisualStyleBackColor = true;
			this.btnDepositar.Click += new System.EventHandler(this.BtnDepositarClick);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(157, 210);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(83, 29);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// btnTicket
			// 
			this.btnTicket.Location = new System.Drawing.Point(45, 210);
			this.btnTicket.Name = "btnTicket";
			this.btnTicket.Size = new System.Drawing.Size(84, 29);
			this.btnTicket.TabIndex = 6;
			this.btnTicket.Text = "Imprimir Ticket";
			this.btnTicket.UseVisualStyleBackColor = true;
			this.btnTicket.Click += new System.EventHandler(this.BtnTicketClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnConsulta);
			this.groupBox1.Controls.Add(this.btnCargarSaldo);
			this.groupBox1.Controls.Add(this.btnDepositar);
			this.groupBox1.Controls.Add(this.btnExtraccion);
			this.groupBox1.Location = new System.Drawing.Point(33, 84);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(220, 100);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Coral;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnTicket);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.textBoxSaldo);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btnTicket;
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.Button btnDepositar;
		private System.Windows.Forms.Button btnExtraccion;
		private System.Windows.Forms.Button btnCargarSaldo;
		private System.Windows.Forms.Button btnConsulta;
		private System.Windows.Forms.TextBox textBoxSaldo;
	}
}
