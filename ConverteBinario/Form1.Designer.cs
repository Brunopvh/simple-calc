
namespace ConverteBinario
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
            this.textBoxOrigem = new System.Windows.Forms.TextBox();
            this.comboBoxBases = new System.Windows.Forms.ComboBox();
            this.labelNumDestino = new System.Windows.Forms.Label();
            this.buttonConverter = new System.Windows.Forms.Button();
            this.labelNumOrigem = new System.Windows.Forms.Label();
            this.labelBaseOrigem = new System.Windows.Forms.Label();
            this.textBoxDestino = new System.Windows.Forms.TextBox();
            this.labelBaseDestino = new System.Windows.Forms.Label();
            this.labelBaseAtualDestino = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxOrigem
            // 
            this.textBoxOrigem.Location = new System.Drawing.Point(186, 33);
            this.textBoxOrigem.Name = "textBoxOrigem";
            this.textBoxOrigem.Size = new System.Drawing.Size(305, 23);
            this.textBoxOrigem.TabIndex = 0;
            // 
            // comboBoxBases
            // 
            this.comboBoxBases.FormattingEnabled = true;
            this.comboBoxBases.Items.AddRange(new object[] {
            "Binário",
            "Decimal"});
            this.comboBoxBases.Location = new System.Drawing.Point(52, 33);
            this.comboBoxBases.Name = "comboBoxBases";
            this.comboBoxBases.Size = new System.Drawing.Size(108, 23);
            this.comboBoxBases.TabIndex = 2;
            this.comboBoxBases.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelNumDestino
            // 
            this.labelNumDestino.AutoSize = true;
            this.labelNumDestino.Location = new System.Drawing.Point(186, 87);
            this.labelNumDestino.Name = "labelNumDestino";
            this.labelNumDestino.Size = new System.Drawing.Size(94, 15);
            this.labelNumDestino.TabIndex = 3;
            this.labelNumDestino.Text = "Número Destino";
            this.labelNumDestino.Click += new System.EventHandler(this.labelBaseFinal_Click);
            // 
            // buttonConverter
            // 
            this.buttonConverter.Location = new System.Drawing.Point(186, 171);
            this.buttonConverter.Name = "buttonConverter";
            this.buttonConverter.Size = new System.Drawing.Size(108, 29);
            this.buttonConverter.TabIndex = 4;
            this.buttonConverter.Text = "Converter";
            this.buttonConverter.UseVisualStyleBackColor = true;
            this.buttonConverter.Click += new System.EventHandler(this.buttonConverter_Click);
            // 
            // labelNumOrigem
            // 
            this.labelNumOrigem.AutoSize = true;
            this.labelNumOrigem.Location = new System.Drawing.Point(183, 9);
            this.labelNumOrigem.Name = "labelNumOrigem";
            this.labelNumOrigem.Size = new System.Drawing.Size(94, 15);
            this.labelNumOrigem.TabIndex = 5;
            this.labelNumOrigem.Text = "Número Origem";
            // 
            // labelBaseOrigem
            // 
            this.labelBaseOrigem.AutoSize = true;
            this.labelBaseOrigem.Location = new System.Drawing.Point(52, 9);
            this.labelBaseOrigem.Name = "labelBaseOrigem";
            this.labelBaseOrigem.Size = new System.Drawing.Size(74, 15);
            this.labelBaseOrigem.TabIndex = 6;
            this.labelBaseOrigem.Text = "Base Origem";
            // 
            // textBoxDestino
            // 
            this.textBoxDestino.Location = new System.Drawing.Point(186, 108);
            this.textBoxDestino.Name = "textBoxDestino";
            this.textBoxDestino.Size = new System.Drawing.Size(305, 23);
            this.textBoxDestino.TabIndex = 7;
            this.textBoxDestino.TextChanged += new System.EventHandler(this.textBoxDestino_TextChanged);
            // 
            // labelBaseDestino
            // 
            this.labelBaseDestino.AutoSize = true;
            this.labelBaseDestino.Location = new System.Drawing.Point(52, 87);
            this.labelBaseDestino.Name = "labelBaseDestino";
            this.labelBaseDestino.Size = new System.Drawing.Size(74, 15);
            this.labelBaseDestino.TabIndex = 8;
            this.labelBaseDestino.Text = "Base Destino";
            // 
            // labelBaseAtualDestino
            // 
            this.labelBaseAtualDestino.AutoSize = true;
            this.labelBaseAtualDestino.Location = new System.Drawing.Point(52, 116);
            this.labelBaseAtualDestino.Name = "labelBaseAtualDestino";
            this.labelBaseAtualDestino.Size = new System.Drawing.Size(50, 15);
            this.labelBaseAtualDestino.TabIndex = 9;
            this.labelBaseAtualDestino.Text = "Decimal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 246);
            this.Controls.Add(this.labelBaseAtualDestino);
            this.Controls.Add(this.labelBaseDestino);
            this.Controls.Add(this.textBoxDestino);
            this.Controls.Add(this.labelBaseOrigem);
            this.Controls.Add(this.labelNumOrigem);
            this.Controls.Add(this.buttonConverter);
            this.Controls.Add(this.labelNumDestino);
            this.Controls.Add(this.comboBoxBases);
            this.Controls.Add(this.textBoxOrigem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOrigem;
        private System.Windows.Forms.ComboBox comboBoxBases;
        private System.Windows.Forms.Label labelNumDestino;
        private System.Windows.Forms.Button buttonConverter;
        private System.Windows.Forms.Label labelNumOrigem;
        private System.Windows.Forms.Label labelBaseOrigem;
        private System.Windows.Forms.TextBox textBoxDestino;
        private System.Windows.Forms.Label labelBaseDestino;
        private System.Windows.Forms.Label labelBaseAtualDestino;
    }
}

