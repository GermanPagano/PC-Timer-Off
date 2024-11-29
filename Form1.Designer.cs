namespace Apagador
{
    partial class Form1
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
            lblEstado = new Label();
            numericUpDownTiempo = new NumericUpDown();
            BtnEstablecerApagado = new Button();
            BtnCancelarApagado = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTiempo).BeginInit();
            SuspendLayout();
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(334, 91);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(43, 20);
            lblEstado.TabIndex = 0;
            lblEstado.Text = "Valor";
            // 
            // numericUpDownTiempo
            // 
            numericUpDownTiempo.Location = new Point(238, 146);
            numericUpDownTiempo.Name = "numericUpDownTiempo";
            numericUpDownTiempo.Size = new Size(250, 27);
            numericUpDownTiempo.TabIndex = 1;
            // 
            // BtnEstablecerApagado
            // 
            BtnEstablecerApagado.Location = new Point(238, 213);
            BtnEstablecerApagado.Name = "BtnEstablecerApagado";
            BtnEstablecerApagado.Size = new Size(250, 29);
            BtnEstablecerApagado.TabIndex = 2;
            BtnEstablecerApagado.Text = "Establecer";
            BtnEstablecerApagado.UseVisualStyleBackColor = true;
            BtnEstablecerApagado.Click += BtnEstablecerApagado_Click_1;
            // 
            // BtnCancelarApagado
            // 
            BtnCancelarApagado.Location = new Point(238, 260);
            BtnCancelarApagado.Name = "BtnCancelarApagado";
            BtnCancelarApagado.Size = new Size(250, 29);
            BtnCancelarApagado.TabIndex = 3;
            BtnCancelarApagado.Text = "Cancelar Apagado";
            BtnCancelarApagado.UseVisualStyleBackColor = true;
            BtnCancelarApagado.Click += BtnCancelarApagado_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnCancelarApagado);
            Controls.Add(BtnEstablecerApagado);
            Controls.Add(numericUpDownTiempo);
            Controls.Add(lblEstado);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownTiempo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstado;
        private NumericUpDown numericUpDownTiempo;
        private Button BtnEstablecerApagado;
        private Button BtnCancelarApagado;
    }
}