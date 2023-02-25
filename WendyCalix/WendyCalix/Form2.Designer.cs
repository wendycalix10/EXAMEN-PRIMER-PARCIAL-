namespace WendyCalix
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Product1txt = new System.Windows.Forms.TextBox();
            this.Product2txt = new System.Windows.Forms.TextBox();
            this.Genfactbutton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Imptxt = new System.Windows.Forms.TextBox();
            this.Desctxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURA ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PRODUCTO 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PRODUCTO 2";
            // 
            // Product1txt
            // 
            this.Product1txt.Location = new System.Drawing.Point(146, 51);
            this.Product1txt.Name = "Product1txt";
            this.Product1txt.Size = new System.Drawing.Size(176, 20);
            this.Product1txt.TabIndex = 3;
            // 
            // Product2txt
            // 
            this.Product2txt.Location = new System.Drawing.Point(146, 91);
            this.Product2txt.Name = "Product2txt";
            this.Product2txt.Size = new System.Drawing.Size(176, 20);
            this.Product2txt.TabIndex = 4;
            // 
            // Genfactbutton
            // 
            this.Genfactbutton.Location = new System.Drawing.Point(87, 234);
            this.Genfactbutton.Name = "Genfactbutton";
            this.Genfactbutton.Size = new System.Drawing.Size(208, 94);
            this.Genfactbutton.TabIndex = 5;
            this.Genfactbutton.Text = "GENERAR FACTURA ";
            this.Genfactbutton.UseVisualStyleBackColor = true;
            this.Genfactbutton.Click += new System.EventHandler(this.Genfactbutton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IMPUESTO";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(33, 167);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(74, 13);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "DESCUENTO";
            // 
            // Imptxt
            // 
            this.Imptxt.Location = new System.Drawing.Point(146, 128);
            this.Imptxt.Name = "Imptxt";
            this.Imptxt.Size = new System.Drawing.Size(176, 20);
            this.Imptxt.TabIndex = 8;
            // 
            // Desctxt
            // 
            this.Desctxt.Location = new System.Drawing.Point(146, 167);
            this.Desctxt.Name = "Desctxt";
            this.Desctxt.Size = new System.Drawing.Size(176, 20);
            this.Desctxt.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 354);
            this.Controls.Add(this.Desctxt);
            this.Controls.Add(this.Imptxt);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Genfactbutton);
            this.Controls.Add(this.Product2txt);
            this.Controls.Add(this.Product1txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Product1txt;
        private System.Windows.Forms.TextBox Product2txt;
        private System.Windows.Forms.Button Genfactbutton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TextBox Imptxt;
        private System.Windows.Forms.TextBox Desctxt;
    }
}