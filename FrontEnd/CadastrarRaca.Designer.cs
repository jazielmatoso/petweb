namespace FrontEnd
{
    partial class CadastrarRaca
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
            this.buttonInserirRaca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNovaRaça = new System.Windows.Forms.TextBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonInserirRaca
            // 
            this.buttonInserirRaca.Location = new System.Drawing.Point(12, 102);
            this.buttonInserirRaca.Name = "buttonInserirRaca";
            this.buttonInserirRaca.Size = new System.Drawing.Size(75, 23);
            this.buttonInserirRaca.TabIndex = 0;
            this.buttonInserirRaca.Text = "Inserir";
            this.buttonInserirRaca.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Raça";
            // 
            // textBoxNovaRaça
            // 
            this.textBoxNovaRaça.Location = new System.Drawing.Point(64, 34);
            this.textBoxNovaRaça.Name = "textBoxNovaRaça";
            this.textBoxNovaRaça.Size = new System.Drawing.Size(129, 20);
            this.textBoxNovaRaça.TabIndex = 2;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(118, 102);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // CadastrarRaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 137);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.textBoxNovaRaça);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonInserirRaca);
            this.Name = "CadastrarRaca";
            this.Text = "Cadastro Raça";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonInserirRaca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNovaRaça;
        private System.Windows.Forms.Button buttonCancelar;
    }
}