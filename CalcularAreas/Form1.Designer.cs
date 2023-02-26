namespace CalcularAreas
{
    partial class Indice
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Indice));
            this.lblTexto = new System.Windows.Forms.Label();
            this.btnQuad = new System.Windows.Forms.Button();
            this.btnTri = new System.Windows.Forms.Button();
            this.btnCir = new System.Windows.Forms.Button();
            this.imgQuadrado = new System.Windows.Forms.PictureBox();
            this.imgTriangulo = new System.Windows.Forms.PictureBox();
            this.imgCirculo = new System.Windows.Forms.PictureBox();
            this.imgTrapezio = new System.Windows.Forms.PictureBox();
            this.imgLosango = new System.Windows.Forms.PictureBox();
            this.imgRetangulo = new System.Windows.Forms.PictureBox();
            this.btnTrap = new System.Windows.Forms.Button();
            this.btnLos = new System.Windows.Forms.Button();
            this.btnRet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgQuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTriangulo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCirculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrapezio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLosango)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRetangulo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTexto
            // 
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTexto.Location = new System.Drawing.Point(12, 9);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(404, 48);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Qual a Área a ser calculada?";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnQuad
            // 
            this.btnQuad.Location = new System.Drawing.Point(12, 98);
            this.btnQuad.Name = "btnQuad";
            this.btnQuad.Size = new System.Drawing.Size(116, 53);
            this.btnQuad.TabIndex = 1;
            this.btnQuad.Text = "Quadrado";
            this.btnQuad.UseVisualStyleBackColor = true;
            this.btnQuad.Click += new System.EventHandler(this.btnQuad_Click);
            // 
            // btnTri
            // 
            this.btnTri.Location = new System.Drawing.Point(156, 98);
            this.btnTri.Name = "btnTri";
            this.btnTri.Size = new System.Drawing.Size(116, 53);
            this.btnTri.TabIndex = 2;
            this.btnTri.Text = "Triângulo";
            this.btnTri.UseVisualStyleBackColor = true;
            this.btnTri.Click += new System.EventHandler(this.btnTri_Click);
            // 
            // btnCir
            // 
            this.btnCir.Location = new System.Drawing.Point(300, 98);
            this.btnCir.Name = "btnCir";
            this.btnCir.Size = new System.Drawing.Size(116, 53);
            this.btnCir.TabIndex = 3;
            this.btnCir.Text = "Círculo";
            this.btnCir.UseVisualStyleBackColor = true;
            this.btnCir.Click += new System.EventHandler(this.btnCir_Click);
            // 
            // imgQuadrado
            // 
            this.imgQuadrado.Image = ((System.Drawing.Image)(resources.GetObject("imgQuadrado.Image")));
            this.imgQuadrado.Location = new System.Drawing.Point(12, 157);
            this.imgQuadrado.Name = "imgQuadrado";
            this.imgQuadrado.Size = new System.Drawing.Size(116, 104);
            this.imgQuadrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgQuadrado.TabIndex = 4;
            this.imgQuadrado.TabStop = false;
            // 
            // imgTriangulo
            // 
            this.imgTriangulo.Image = ((System.Drawing.Image)(resources.GetObject("imgTriangulo.Image")));
            this.imgTriangulo.Location = new System.Drawing.Point(156, 157);
            this.imgTriangulo.Name = "imgTriangulo";
            this.imgTriangulo.Size = new System.Drawing.Size(116, 104);
            this.imgTriangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTriangulo.TabIndex = 5;
            this.imgTriangulo.TabStop = false;
            // 
            // imgCirculo
            // 
            this.imgCirculo.Image = ((System.Drawing.Image)(resources.GetObject("imgCirculo.Image")));
            this.imgCirculo.Location = new System.Drawing.Point(300, 157);
            this.imgCirculo.Name = "imgCirculo";
            this.imgCirculo.Size = new System.Drawing.Size(116, 104);
            this.imgCirculo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgCirculo.TabIndex = 6;
            this.imgCirculo.TabStop = false;
            // 
            // imgTrapezio
            // 
            this.imgTrapezio.Image = ((System.Drawing.Image)(resources.GetObject("imgTrapezio.Image")));
            this.imgTrapezio.Location = new System.Drawing.Point(300, 340);
            this.imgTrapezio.Name = "imgTrapezio";
            this.imgTrapezio.Size = new System.Drawing.Size(116, 104);
            this.imgTrapezio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgTrapezio.TabIndex = 12;
            this.imgTrapezio.TabStop = false;
            // 
            // imgLosango
            // 
            this.imgLosango.Image = ((System.Drawing.Image)(resources.GetObject("imgLosango.Image")));
            this.imgLosango.Location = new System.Drawing.Point(156, 340);
            this.imgLosango.Name = "imgLosango";
            this.imgLosango.Size = new System.Drawing.Size(116, 104);
            this.imgLosango.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLosango.TabIndex = 11;
            this.imgLosango.TabStop = false;
            // 
            // imgRetangulo
            // 
            this.imgRetangulo.Image = ((System.Drawing.Image)(resources.GetObject("imgRetangulo.Image")));
            this.imgRetangulo.Location = new System.Drawing.Point(12, 340);
            this.imgRetangulo.Name = "imgRetangulo";
            this.imgRetangulo.Size = new System.Drawing.Size(116, 104);
            this.imgRetangulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgRetangulo.TabIndex = 10;
            this.imgRetangulo.TabStop = false;
            // 
            // btnTrap
            // 
            this.btnTrap.Location = new System.Drawing.Point(300, 281);
            this.btnTrap.Name = "btnTrap";
            this.btnTrap.Size = new System.Drawing.Size(116, 53);
            this.btnTrap.TabIndex = 9;
            this.btnTrap.Text = "Trapézio";
            this.btnTrap.UseVisualStyleBackColor = true;
            this.btnTrap.Click += new System.EventHandler(this.btnTrap_Click);
            // 
            // btnLos
            // 
            this.btnLos.Location = new System.Drawing.Point(156, 281);
            this.btnLos.Name = "btnLos";
            this.btnLos.Size = new System.Drawing.Size(116, 53);
            this.btnLos.TabIndex = 8;
            this.btnLos.Text = "Losango";
            this.btnLos.UseVisualStyleBackColor = true;
            this.btnLos.Click += new System.EventHandler(this.btnLos_Click);
            // 
            // btnRet
            // 
            this.btnRet.Location = new System.Drawing.Point(12, 281);
            this.btnRet.Name = "btnRet";
            this.btnRet.Size = new System.Drawing.Size(116, 53);
            this.btnRet.TabIndex = 7;
            this.btnRet.Text = "Retângulo";
            this.btnRet.UseVisualStyleBackColor = true;
            this.btnRet.Click += new System.EventHandler(this.btnRet_Click);
            // 
            // Indice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 468);
            this.Controls.Add(this.imgTrapezio);
            this.Controls.Add(this.imgLosango);
            this.Controls.Add(this.imgRetangulo);
            this.Controls.Add(this.btnTrap);
            this.Controls.Add(this.btnLos);
            this.Controls.Add(this.btnRet);
            this.Controls.Add(this.imgCirculo);
            this.Controls.Add(this.imgTriangulo);
            this.Controls.Add(this.imgQuadrado);
            this.Controls.Add(this.btnCir);
            this.Controls.Add(this.btnTri);
            this.Controls.Add(this.btnQuad);
            this.Controls.Add(this.lblTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Indice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Area";
            ((System.ComponentModel.ISupportInitialize)(this.imgQuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTriangulo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCirculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTrapezio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLosango)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRetangulo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblTexto;
        private Button btnQuad;
        private Button btnTri;
        private Button btnCir;
        private PictureBox imgQuadrado;
        private PictureBox imgTriangulo;
        private PictureBox imgCirculo;
        private PictureBox imgTrapezio;
        private PictureBox imgLosango;
        private PictureBox imgRetangulo;
        private Button btnTrap;
        private Button btnLos;
        private Button btnRet;
    }
}