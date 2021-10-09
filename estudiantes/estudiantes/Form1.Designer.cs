
namespace estudiantes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.no = new System.Windows.Forms.TextBox();
            this.con = new System.Windows.Forms.TextBox();
            this.ap = new System.Windows.Forms.TextBox();
            this.usu = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nombreT = new System.Windows.Forms.Label();
            this.apellidoT = new System.Windows.Forms.Label();
            this.usuarioT = new System.Windows.Forms.Label();
            this.contraT = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // no
            // 
            this.no.Location = new System.Drawing.Point(78, 45);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(270, 20);
            this.no.TabIndex = 0;
            // 
            // con
            // 
            this.con.Location = new System.Drawing.Point(69, 303);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(279, 20);
            this.con.TabIndex = 2;
            // 
            // ap
            // 
            this.ap.Location = new System.Drawing.Point(78, 132);
            this.ap.Name = "ap";
            this.ap.Size = new System.Drawing.Size(270, 20);
            this.ap.TabIndex = 3;
            // 
            // usu
            // 
            this.usu.Location = new System.Drawing.Point(78, 215);
            this.usu.Name = "usu";
            this.usu.Size = new System.Drawing.Size(270, 20);
            this.usu.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(78, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreT
            // 
            this.nombreT.AutoSize = true;
            this.nombreT.Location = new System.Drawing.Point(78, 13);
            this.nombreT.Name = "nombreT";
            this.nombreT.Size = new System.Drawing.Size(42, 13);
            this.nombreT.TabIndex = 6;
            this.nombreT.Text = "nombre";
            // 
            // apellidoT
            // 
            this.apellidoT.AutoSize = true;
            this.apellidoT.Location = new System.Drawing.Point(78, 103);
            this.apellidoT.Name = "apellidoT";
            this.apellidoT.Size = new System.Drawing.Size(43, 13);
            this.apellidoT.TabIndex = 7;
            this.apellidoT.Text = "apellido";
            // 
            // usuarioT
            // 
            this.usuarioT.AutoSize = true;
            this.usuarioT.Location = new System.Drawing.Point(75, 184);
            this.usuarioT.Name = "usuarioT";
            this.usuarioT.Size = new System.Drawing.Size(41, 13);
            this.usuarioT.TabIndex = 8;
            this.usuarioT.Text = "usuario";
            // 
            // contraT
            // 
            this.contraT.AutoSize = true;
            this.contraT.Location = new System.Drawing.Point(78, 273);
            this.contraT.Name = "contraT";
            this.contraT.Size = new System.Drawing.Size(60, 13);
            this.contraT.TabIndex = 9;
            this.contraT.Text = "contraseña";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 330);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 78);
            this.button2.TabIndex = 10;
            this.button2.Text = "Agg Materias";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(611, 330);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 78);
            this.button3.TabIndex = 11;
            this.button3.Text = "Agg Notas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(572, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Funciona pero no se si era asi...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.contraT);
            this.Controls.Add(this.usuarioT);
            this.Controls.Add(this.apellidoT);
            this.Controls.Add(this.nombreT);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usu);
            this.Controls.Add(this.ap);
            this.Controls.Add(this.con);
            this.Controls.Add(this.no);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox no;
        private System.Windows.Forms.TextBox con;
        private System.Windows.Forms.TextBox ap;
        private System.Windows.Forms.TextBox usu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label nombreT;
        private System.Windows.Forms.Label apellidoT;
        private System.Windows.Forms.Label usuarioT;
        private System.Windows.Forms.Label contraT;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
    }
}

