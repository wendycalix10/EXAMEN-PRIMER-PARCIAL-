namespace WendyCalix
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Valortxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Interestxt = new System.Windows.Forms.TextBox();
            this.lisboxejer1 = new System.Windows.Forms.ListBox();
            this.CalculardateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "CALCULAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CALCULO DE INTERESES ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "INGRESE EL VALOR ";
            // 
            // Valortxt
            // 
            this.Valortxt.Location = new System.Drawing.Point(156, 44);
            this.Valortxt.Name = "Valortxt";
            this.Valortxt.Size = new System.Drawing.Size(200, 20);
            this.Valortxt.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "INGRESE EL INTERES";
            // 
            // Interestxt
            // 
            this.Interestxt.Location = new System.Drawing.Point(156, 70);
            this.Interestxt.Name = "Interestxt";
            this.Interestxt.Size = new System.Drawing.Size(200, 20);
            this.Interestxt.TabIndex = 5;
            // 
            // lisboxejer1
            // 
            this.lisboxejer1.FormattingEnabled = true;
            this.lisboxejer1.Location = new System.Drawing.Point(30, 168);
            this.lisboxejer1.Name = "lisboxejer1";
            this.lisboxejer1.Size = new System.Drawing.Size(251, 264);
            this.lisboxejer1.TabIndex = 6;
            // 
            // CalculardateTimePicker
            // 
            this.CalculardateTimePicker.Location = new System.Drawing.Point(156, 96);
            this.CalculardateTimePicker.Name = "CalculardateTimePicker";
            this.CalculardateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.CalculardateTimePicker.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "FECHA DE INICIO ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 447);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalculardateTimePicker);
            this.Controls.Add(this.lisboxejer1);
            this.Controls.Add(this.Interestxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Valortxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Valortxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Interestxt;
        private System.Windows.Forms.ListBox lisboxejer1;
        private System.Windows.Forms.DateTimePicker CalculardateTimePicker;
        private System.Windows.Forms.Label label4;
    }
}

