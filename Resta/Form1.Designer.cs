
namespace Resta
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
            this.num1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(185, 122);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(70, 17);
            this.num1.TabIndex = 1;
            this.num1.Text = "Número 1";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(188, 167);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 22);
            this.txt1.TabIndex = 3;
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(185, 218);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(70, 17);
            this.num2.TabIndex = 4;
            this.num2.Text = "Número 2";
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(188, 250);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 22);
            this.txt2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Resultado";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(371, 167);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 22);
            this.txtResult.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 240);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 32);
            this.button2.TabIndex = 9;
            this.button2.Text = "calcular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button2;
    }
}

