/*
 * Created by SharpDevelop.
 * User: CUDI-07
 * Date: 28/9/2022
 * Time: 10:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace sist_cajero_auto
{
	partial class MainForm
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
			this.btnIngresar = new System.Windows.Forms.Button();
			this.labelUser = new System.Windows.Forms.Label();
			this.labelPass = new System.Windows.Forms.Label();
			this.textBoxUser = new System.Windows.Forms.TextBox();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnIngresar
			// 
			this.btnIngresar.Location = new System.Drawing.Point(159, 138);
			this.btnIngresar.Name = "btnIngresar";
			this.btnIngresar.Size = new System.Drawing.Size(75, 30);
			this.btnIngresar.TabIndex = 0;
			this.btnIngresar.Text = "Ingresar";
			this.btnIngresar.UseVisualStyleBackColor = true;
			this.btnIngresar.Click += new System.EventHandler(this.BtnIngresarClick);
			// 
			// labelUser
			// 
			this.labelUser.Location = new System.Drawing.Point(39, 49);
			this.labelUser.Name = "labelUser";
			this.labelUser.Size = new System.Drawing.Size(100, 23);
			this.labelUser.TabIndex = 1;
			this.labelUser.Text = "Usuario";
			// 
			// labelPass
			// 
			this.labelPass.Location = new System.Drawing.Point(39, 90);
			this.labelPass.Name = "labelPass";
			this.labelPass.Size = new System.Drawing.Size(100, 23);
			this.labelPass.TabIndex = 2;
			this.labelPass.Text = "Contraseña";
			// 
			// textBoxUser
			// 
			this.textBoxUser.Location = new System.Drawing.Point(146, 46);
			this.textBoxUser.Name = "textBoxUser";
			this.textBoxUser.Size = new System.Drawing.Size(100, 20);
			this.textBoxUser.TabIndex = 3;
			// 
			// textBoxPass
			// 
			this.textBoxPass.Location = new System.Drawing.Point(146, 87);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.PasswordChar = '*';
			this.textBoxPass.Size = new System.Drawing.Size(100, 20);
			this.textBoxPass.TabIndex = 4;
			this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPassKeyPress);
			// 
			// btnSalir
			// 
			this.btnSalir.Location = new System.Drawing.Point(159, 187);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 30);
			this.btnSalir.TabIndex = 5;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = true;
			this.btnSalir.Click += new System.EventHandler(this.BtnSalirClick);
			// 
			// MainForm
			// 
			this.AcceptButton = this.btnIngresar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Coral;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.textBoxPass);
			this.Controls.Add(this.textBoxUser);
			this.Controls.Add(this.labelPass);
			this.Controls.Add(this.labelUser);
			this.Controls.Add(this.btnIngresar);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "sist_cajero_auto";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnSalir;
		private System.Windows.Forms.TextBox textBoxPass;
		private System.Windows.Forms.TextBox textBoxUser;
		private System.Windows.Forms.Label labelPass;
		private System.Windows.Forms.Label labelUser;
		private System.Windows.Forms.Button btnIngresar;
		
		
		
	}
}
