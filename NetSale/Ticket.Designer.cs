namespace NetSale
{
    partial class Ticket
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
            this.txt_totalPagar = new System.Windows.Forms.TextBox();
            this.txt_Dinero = new System.Windows.Forms.TextBox();
            this.txt_Cambio = new System.Windows.Forms.TextBox();
            this.cancelar = new System.Windows.Forms.Button();
            this.pagar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_totalPagar
            // 
            this.txt_totalPagar.Location = new System.Drawing.Point(167, 44);
            this.txt_totalPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_totalPagar.Name = "txt_totalPagar";
            this.txt_totalPagar.ReadOnly = true;
            this.txt_totalPagar.Size = new System.Drawing.Size(68, 20);
            this.txt_totalPagar.TabIndex = 0;
            // 
            // txt_Dinero
            // 
            this.txt_Dinero.Location = new System.Drawing.Point(167, 108);
            this.txt_Dinero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Dinero.Name = "txt_Dinero";
            this.txt_Dinero.Size = new System.Drawing.Size(68, 20);
            this.txt_Dinero.TabIndex = 1;
            // 
            // txt_Cambio
            // 
            this.txt_Cambio.Location = new System.Drawing.Point(167, 170);
            this.txt_Cambio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Cambio.Name = "txt_Cambio";
            this.txt_Cambio.ReadOnly = true;
            this.txt_Cambio.Size = new System.Drawing.Size(68, 20);
            this.txt_Cambio.TabIndex = 2;
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cancelar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(29, 205);
            this.cancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(80, 35);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            // 
            // pagar
            // 
            this.pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pagar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagar.Location = new System.Drawing.Point(200, 205);
            this.pagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pagar.Name = "pagar";
            this.pagar.Size = new System.Drawing.Size(84, 35);
            this.pagar.TabIndex = 4;
            this.pagar.Text = "Pagar";
            this.pagar.UseVisualStyleBackColor = false;
            this.pagar.Click += new System.EventHandler(this.pagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total a pagar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(78, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dinero :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cambio :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "_____________________________";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "¡GRACIAS POR SU COMPRA!";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 315);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pagar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.txt_Cambio);
            this.Controls.Add(this.txt_Dinero);
            this.Controls.Add(this.txt_totalPagar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Ticket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            this.Load += new System.EventHandler(this.Ticket_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_totalPagar;
        private System.Windows.Forms.TextBox txt_Dinero;
        private System.Windows.Forms.TextBox txt_Cambio;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Button pagar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}