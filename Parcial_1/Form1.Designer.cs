
namespace Parcial_1
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
            this.btn1ConvertirConversores = new System.Windows.Forms.Button();
            this.txt1CantidadConversores = new System.Windows.Forms.TextBox();
            this.lblrespuestaconversores = new System.Windows.Forms.Label();
            this.cbo1DeConversores = new System.Windows.Forms.ComboBox();
            this.cbo2Aconversores = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn1ConvertirConversores
            // 
            this.btn1ConvertirConversores.BackColor = System.Drawing.Color.Yellow;
            this.btn1ConvertirConversores.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1ConvertirConversores.Location = new System.Drawing.Point(198, 175);
            this.btn1ConvertirConversores.Name = "btn1ConvertirConversores";
            this.btn1ConvertirConversores.Size = new System.Drawing.Size(141, 39);
            this.btn1ConvertirConversores.TabIndex = 0;
            this.btn1ConvertirConversores.Text = "CONVERTIR";
            this.btn1ConvertirConversores.UseVisualStyleBackColor = false;
            this.btn1ConvertirConversores.Click += new System.EventHandler(this.btn1ConvertirConversores_Click);
            // 
            // txt1CantidadConversores
            // 
            this.txt1CantidadConversores.Location = new System.Drawing.Point(219, 129);
            this.txt1CantidadConversores.Multiline = true;
            this.txt1CantidadConversores.Name = "txt1CantidadConversores";
            this.txt1CantidadConversores.Size = new System.Drawing.Size(100, 18);
            this.txt1CantidadConversores.TabIndex = 1;
            this.txt1CantidadConversores.TextChanged += new System.EventHandler(this.txt1CantidadConversores_TextChanged);
            // 
            // lblrespuestaconversores
            // 
            this.lblrespuestaconversores.AutoSize = true;
            this.lblrespuestaconversores.Location = new System.Drawing.Point(216, 190);
            this.lblrespuestaconversores.Name = "lblrespuestaconversores";
            this.lblrespuestaconversores.Size = new System.Drawing.Size(0, 13);
            this.lblrespuestaconversores.TabIndex = 2;
            this.lblrespuestaconversores.Click += new System.EventHandler(this.lblrespuestaconversores_Click);
            // 
            // cbo1DeConversores
            // 
            this.cbo1DeConversores.FormattingEnabled = true;
            this.cbo1DeConversores.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            " Hectárea"});
            this.cbo1DeConversores.Location = new System.Drawing.Point(198, 31);
            this.cbo1DeConversores.Name = "cbo1DeConversores";
            this.cbo1DeConversores.Size = new System.Drawing.Size(121, 21);
            this.cbo1DeConversores.TabIndex = 3;
            // 
            // cbo2Aconversores
            // 
            this.cbo2Aconversores.FormattingEnabled = true;
            this.cbo2Aconversores.Items.AddRange(new object[] {
            "Pie Cuadrado",
            "Vara Cuadrada",
            "Yarda Cuadrada",
            "Metro Cuadrado",
            "Tareas",
            "Manzana",
            "Hectárea"});
            this.cbo2Aconversores.Location = new System.Drawing.Point(198, 91);
            this.cbo2Aconversores.Name = "cbo2Aconversores";
            this.cbo2Aconversores.Size = new System.Drawing.Size(121, 21);
            this.cbo2Aconversores.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "DE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(164, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "A:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad:";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(552, 319);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo2Aconversores);
            this.Controls.Add(this.cbo1DeConversores);
            this.Controls.Add(this.lblrespuestaconversores);
            this.Controls.Add(this.txt1CantidadConversores);
            this.Controls.Add(this.btn1ConvertirConversores);
            this.Name = "Form1";
            this.Text = "PARCIAL 1 CONVERSORES";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn1ConvertirConversores;
        private System.Windows.Forms.TextBox txt1CantidadConversores;
        private System.Windows.Forms.Label lblrespuestaconversores;
        private System.Windows.Forms.ComboBox cbo1DeConversores;
        private System.Windows.Forms.ComboBox cbo2Aconversores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

