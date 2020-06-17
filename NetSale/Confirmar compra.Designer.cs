namespace NetSale
{
    partial class Confirmar_compra
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
            this.lvProductos = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Total = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lvProductos
            // 
            this.lvProductos.HideSelection = false;
            this.lvProductos.Location = new System.Drawing.Point(12, 58);
            this.lvProductos.Name = "lvProductos";
            this.lvProductos.Size = new System.Drawing.Size(874, 315);
            this.lvProductos.TabIndex = 0;
            this.lvProductos.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Regresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(153, 406);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "Realizar Venta";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "Orden de venta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total: ";
            // 
            // txt_Total
            // 
            this.txt_Total.Location = new System.Drawing.Point(442, 409);
            this.txt_Total.Mask = "$000000";
            this.txt_Total.Name = "txt_Total";
            this.txt_Total.ReadOnly = true;
            this.txt_Total.Size = new System.Drawing.Size(73, 26);
            this.txt_Total.TabIndex = 6;
            this.txt_Total.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // Confirmar_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 472);
            this.Controls.Add(this.txt_Total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lvProductos);
            this.Name = "Confirmar_compra";
            this.Text = "Confirmar compra";
            this.Load += new System.EventHandler(this.Confirmar_compra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txt_Total;
    }
}