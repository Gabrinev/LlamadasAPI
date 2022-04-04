
namespace LlamadasAPI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblJoke = new System.Windows.Forms.Label();
            this.btnGetJoke = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblJoke);
            this.groupBox1.Location = new System.Drawing.Point(81, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(621, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chistako";
            // 
            // lblJoke
            // 
            this.lblJoke.AutoSize = true;
            this.lblJoke.Location = new System.Drawing.Point(28, 26);
            this.lblJoke.Name = "lblJoke";
            this.lblJoke.Size = new System.Drawing.Size(0, 13);
            this.lblJoke.TabIndex = 0;
            // 
            // btnGetJoke
            // 
            this.btnGetJoke.Location = new System.Drawing.Point(81, 197);
            this.btnGetJoke.Name = "btnGetJoke";
            this.btnGetJoke.Size = new System.Drawing.Size(93, 23);
            this.btnGetJoke.TabIndex = 1;
            this.btnGetJoke.Text = "Nuevo Chistako";
            this.btnGetJoke.UseVisualStyleBackColor = true;
            this.btnGetJoke.Click += new System.EventHandler(this.btnGetJoke_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGetJoke);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblJoke;
        private System.Windows.Forms.Button btnGetJoke;
    }
}

