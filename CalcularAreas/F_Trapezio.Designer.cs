namespace CalcularAreas
{
    partial class F_Trapezio
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtValorBM = new System.Windows.Forms.TextBox();
            this.txtValorB = new System.Windows.Forms.TextBox();
            this.lblValorBM = new System.Windows.Forms.Label();
            this.lblValorB = new System.Windows.Forms.Label();
            this.txtValorA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(113, 215);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(221, 23);
            this.txtResult.TabIndex = 13;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Location = new System.Drawing.Point(12, 208);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(95, 35);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "Resultado: ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(113, 134);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 38);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorBM
            // 
            this.txtValorBM.Location = new System.Drawing.Point(113, 51);
            this.txtValorBM.Name = "txtValorBM";
            this.txtValorBM.Size = new System.Drawing.Size(221, 23);
            this.txtValorBM.TabIndex = 10;
            this.txtValorBM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorBM_KeyPress);
            // 
            // txtValorB
            // 
            this.txtValorB.Location = new System.Drawing.Point(113, 16);
            this.txtValorB.Name = "txtValorB";
            this.txtValorB.Size = new System.Drawing.Size(221, 23);
            this.txtValorB.TabIndex = 9;
            this.txtValorB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorB_KeyPress);
            // 
            // lblValorBM
            // 
            this.lblValorBM.BackColor = System.Drawing.Color.Transparent;
            this.lblValorBM.Location = new System.Drawing.Point(12, 44);
            this.lblValorBM.Name = "lblValorBM";
            this.lblValorBM.Size = new System.Drawing.Size(95, 35);
            this.lblValorBM.TabIndex = 8;
            this.lblValorBM.Text = "Valor da Base Menor:";
            this.lblValorBM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorB
            // 
            this.lblValorB.BackColor = System.Drawing.Color.Transparent;
            this.lblValorB.Location = new System.Drawing.Point(12, 9);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(95, 35);
            this.lblValorB.TabIndex = 7;
            this.lblValorB.Text = "Valor da Base Maior:";
            this.lblValorB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtValorA
            // 
            this.txtValorA.Location = new System.Drawing.Point(113, 86);
            this.txtValorA.Name = "txtValorA";
            this.txtValorA.Size = new System.Drawing.Size(221, 23);
            this.txtValorA.TabIndex = 15;
            this.txtValorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorA_KeyPress);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Valor da Altura:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Trapezio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 252);
            this.Controls.Add(this.txtValorA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorBM);
            this.Controls.Add(this.txtValorB);
            this.Controls.Add(this.lblValorBM);
            this.Controls.Add(this.lblValorB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Trapezio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Área Trapézio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResult;
        private Label lblResult;
        private Button btnCalcular;
        private TextBox txtValorBM;
        private TextBox txtValorB;
        private Label lblValorBM;
        private Label lblValorB;
        private TextBox txtValorA;
        private Label label1;
    }
}