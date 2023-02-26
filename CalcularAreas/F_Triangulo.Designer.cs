namespace CalcularAreas
{
    partial class F_Triangulo
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
            this.lblValorB = new System.Windows.Forms.Label();
            this.lblValorA = new System.Windows.Forms.Label();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblValorB
            // 
            this.lblValorB.BackColor = System.Drawing.Color.Transparent;
            this.lblValorB.Location = new System.Drawing.Point(12, 9);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(95, 35);
            this.lblValorB.TabIndex = 0;
            this.lblValorB.Text = "Valor da Base:";
            this.lblValorB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorA
            // 
            this.lblValorA.BackColor = System.Drawing.Color.Transparent;
            this.lblValorA.Location = new System.Drawing.Point(12, 44);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(95, 35);
            this.lblValorA.TabIndex = 1;
            this.lblValorA.Text = "Valor da Altura:";
            this.lblValorA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(113, 16);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(221, 23);
            this.txtValorB.TabIndex = 2;
            this.txtValorB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorB_KeyPress);
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(113, 51);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(221, 23);
            this.txtValorA.TabIndex = 3;
            this.txtValorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorA_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(113, 100);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 38);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Location = new System.Drawing.Point(12, 174);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(95, 35);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Resultado: ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(113, 181);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(221, 23);
            this.txtResult.TabIndex = 6;
            // 
            // F_Triangulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 252);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.lblValorA);
            this.Controls.Add(this.lblValorB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Triangulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Área Triângulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblValorB;
        private Label lblValorA;
        private TextBox txtValorB;
        private TextBox txtValorA;
        private Button btnCalcular;
        private Label lblResult;
        private TextBox txtResult;
    }
}