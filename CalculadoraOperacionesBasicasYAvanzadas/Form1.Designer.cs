namespace CalculadoraOperacionesBasicasYAvanzadas
{
    partial class Form1
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.Resultado = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnMultiplicacion = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.btnRedondear = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnPotenciaRaiz = new System.Windows.Forms.Button();
            this.lblOB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(90, 43);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(100, 20);
            this.txtValor1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor 2";
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(90, 89);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(100, 20);
            this.txtValor2.TabIndex = 2;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(225, 67);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(24, 25);
            this.Resultado.TabIndex = 4;
            this.Resultado.Text = "_";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(60, 192);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(130, 23);
            this.btnSuma.TabIndex = 5;
            this.btnSuma.Text = "Suma";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Operaciones Avanzadas";
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(60, 221);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(130, 23);
            this.btnResta.TabIndex = 8;
            this.btnResta.Text = "Resta";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnMultiplicacion
            // 
            this.btnMultiplicacion.Location = new System.Drawing.Point(60, 250);
            this.btnMultiplicacion.Name = "btnMultiplicacion";
            this.btnMultiplicacion.Size = new System.Drawing.Size(130, 23);
            this.btnMultiplicacion.TabIndex = 9;
            this.btnMultiplicacion.Text = "Multiplicacion";
            this.btnMultiplicacion.UseVisualStyleBackColor = true;
            this.btnMultiplicacion.Click += new System.EventHandler(this.btnMultiplicacion_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(60, 279);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(130, 23);
            this.btnDivision.TabIndex = 10;
            this.btnDivision.Text = "Division";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.Location = new System.Drawing.Point(233, 192);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(130, 23);
            this.btnMaxMin.TabIndex = 11;
            this.btnMaxMin.Text = "Max y Min";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // btnRedondear
            // 
            this.btnRedondear.Location = new System.Drawing.Point(233, 221);
            this.btnRedondear.Name = "btnRedondear";
            this.btnRedondear.Size = new System.Drawing.Size(130, 23);
            this.btnRedondear.TabIndex = 12;
            this.btnRedondear.Text = "Redondear";
            this.btnRedondear.UseVisualStyleBackColor = true;
            this.btnRedondear.Click += new System.EventHandler(this.btnRedondear_Click);
            // 
            // btnPi
            // 
            this.btnPi.Location = new System.Drawing.Point(233, 250);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(130, 23);
            this.btnPi.TabIndex = 13;
            this.btnPi.Text = "PI";
            this.btnPi.UseVisualStyleBackColor = true;
            this.btnPi.Click += new System.EventHandler(this.btnPi_Click);
            // 
            // btnPotenciaRaiz
            // 
            this.btnPotenciaRaiz.Location = new System.Drawing.Point(233, 279);
            this.btnPotenciaRaiz.Name = "btnPotenciaRaiz";
            this.btnPotenciaRaiz.Size = new System.Drawing.Size(130, 23);
            this.btnPotenciaRaiz.TabIndex = 14;
            this.btnPotenciaRaiz.Text = "Potencia / Raiz";
            this.btnPotenciaRaiz.UseVisualStyleBackColor = true;
            this.btnPotenciaRaiz.Click += new System.EventHandler(this.btnPotenciaRaiz_Click);
            // 
            // lblOB
            // 
            this.lblOB.AutoSize = true;
            this.lblOB.Location = new System.Drawing.Point(57, 160);
            this.lblOB.Name = "lblOB";
            this.lblOB.Size = new System.Drawing.Size(107, 13);
            this.lblOB.TabIndex = 6;
            this.lblOB.Text = "Operaciones Basicas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 340);
            this.Controls.Add(this.btnPotenciaRaiz);
            this.Controls.Add(this.btnPi);
            this.Controls.Add(this.btnRedondear);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMultiplicacion);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOB);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnResta;
        private System.Windows.Forms.Button btnMultiplicacion;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMaxMin;
        private System.Windows.Forms.Button btnRedondear;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnPotenciaRaiz;
        private System.Windows.Forms.Label lblOB;
    }
}

