
namespace MyFirstExam
{
    partial class FoundsCalculator
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
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_FinishVal_3d = new System.Windows.Forms.Label();
            this.lbl_FinishVal_RHE = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(344, 220);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "Calcular";
            this.btn_calc.UseVisualStyleBackColor = true;
            // 
            // lbl_FinishVal_3d
            // 
            this.lbl_FinishVal_3d.AutoSize = true;
            this.lbl_FinishVal_3d.Location = new System.Drawing.Point(344, 126);
            this.lbl_FinishVal_3d.Name = "lbl_FinishVal_3d";
            this.lbl_FinishVal_3d.Size = new System.Drawing.Size(99, 13);
            this.lbl_FinishVal_3d.TabIndex = 1;
            this.lbl_FinishVal_3d.Text = "Valor Redonedo 3d";
            // 
            // lbl_FinishVal_RHE
            // 
            this.lbl_FinishVal_RHE.AutoSize = true;
            this.lbl_FinishVal_RHE.Location = new System.Drawing.Point(344, 158);
            this.lbl_FinishVal_RHE.Name = "lbl_FinishVal_RHE";
            this.lbl_FinishVal_RHE.Size = new System.Drawing.Size(110, 13);
            this.lbl_FinishVal_RHE.TabIndex = 2;
            this.lbl_FinishVal_RHE.Text = "Valor Redondeo RHE";
            // 
            // FoundsCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_FinishVal_RHE);
            this.Controls.Add(this.lbl_FinishVal_3d);
            this.Controls.Add(this.btn_calc);
            this.Name = "FoundsCalculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_FinishVal_3d;
        private System.Windows.Forms.Label lbl_FinishVal_RHE;
    }
}

