namespace CalcularAreas
{
    partial class F_Losango
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
            this.txtValorDM = new System.Windows.Forms.TextBox();
            this.txtValorD = new System.Windows.Forms.TextBox();
            this.lblValorDM = new System.Windows.Forms.Label();
            this.lblValorD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(113, 181);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(221, 23);
            this.txtResult.TabIndex = 13;
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Location = new System.Drawing.Point(12, 174);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(95, 35);
            this.lblResult.TabIndex = 12;
            this.lblResult.Text = "Resultado: ";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(113, 100);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(111, 38);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtValorDM
            // 
            this.txtValorDM.Location = new System.Drawing.Point(113, 51);
            this.txtValorDM.Name = "txtValorDM";
            this.txtValorDM.Size = new System.Drawing.Size(221, 23);
            this.txtValorDM.TabIndex = 10;
            this.txtValorDM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorDM_KeyPress);
            // 
            // txtValorD
            // 
            this.txtValorD.Location = new System.Drawing.Point(113, 16);
            this.txtValorD.Name = "txtValorD";
            this.txtValorD.Size = new System.Drawing.Size(221, 23);
            this.txtValorD.TabIndex = 9;
            this.txtValorD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorD_KeyPress);
            // 
            // lblValorDM
            // 
            this.lblValorDM.BackColor = System.Drawing.Color.Transparent;
            this.lblValorDM.Location = new System.Drawing.Point(12, 44);
            this.lblValorDM.Name = "lblValorDM";
            this.lblValorDM.Size = new System.Drawing.Size(95, 35);
            this.lblValorDM.TabIndex = 8;
            this.lblValorDM.Text = "Valor da Diagonal Menor:";
            this.lblValorDM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblValorD
            // 
            this.lblValorD.BackColor = System.Drawing.Color.Transparent;
            this.lblValorD.Location = new System.Drawing.Point(12, 9);
            this.lblValorD.Name = "lblValorD";
            this.lblValorD.Size = new System.Drawing.Size(95, 35);
            this.lblValorD.TabIndex = 7;
            this.lblValorD.Text = "Valor da Diagonal Maior:";
            this.lblValorD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F_Losango
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 252);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtValorDM);
            this.Controls.Add(this.txtValorD);
            this.Controls.Add(this.lblValorDM);
            this.Controls.Add(this.lblValorD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "F_Losango";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular [Area Losango";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtResult;
        private Label lblResult;
        private Button btnCalcular;
        private TextBox txtValorDM;
        private TextBox txtValorD;
        private Label lblValorDM;
        private Label lblValorD;
    }
}