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
            this.SuspendLayout();
            // 
            // txt_totalPagar
            // 
            this.txt_totalPagar.Location = new System.Drawing.Point(173, 62);
            this.txt_totalPagar.Name = "txt_totalPagar";
            this.txt_totalPagar.ReadOnly = true;
            this.txt_totalPagar.Size = new System.Drawing.Size(100, 26);
            this.txt_totalPagar.TabIndex = 0;
            // 
            // txt_Dinero
            // 
            this.txt_Dinero.Location = new System.Drawing.Point(173, 133);
            this.txt_Dinero.Name = "txt_Dinero";
            this.txt_Dinero.Size = new System.Drawing.Size(100, 26);
            this.txt_Dinero.TabIndex = 1;
            // 
            // txt_Cambio
            // 
            this.txt_Cambio.Location = new System.Drawing.Point(173, 210);
            this.txt_Cambio.Name = "txt_Cambio";
            this.txt_Cambio.ReadOnly = true;
            this.txt_Cambio.Size = new System.Drawing.Size(100, 26);
            this.txt_Cambio.TabIndex = 2;
            // 
            // cancelar
            // 
            this.cancelar.Location = new System.Drawing.Point(64, 282);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(91, 39);
            this.cancelar.TabIndex = 3;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = true;
            // 
            // pagar
            // 
            this.pagar.Location = new System.Drawing.Point(297, 282);
            this.pagar.Name = "pagar";
            this.pagar.Size = new System.Drawing.Size(108, 39);
            this.pagar.TabIndex = 4;
            this.pagar.Text = "Pagar";
            this.pagar.UseVisualStyleBackColor = true;
            this.pagar.Click += new System.EventHandler(this.pagar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total a pagar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(187, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Dinero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(187, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cambio";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pagar);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.txt_Cambio);
            this.Controls.Add(this.txt_Dinero);
            this.Controls.Add(this.txt_totalPagar);
            this.Name = "Ticket";
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
    }
}