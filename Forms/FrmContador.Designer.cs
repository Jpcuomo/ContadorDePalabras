namespace Forms
{
    partial class FrmContador
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
            richTextBox = new RichTextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(7, 0);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(469, 375);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(195, 396);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 450);
            Controls.Add(btnCalcular);
            Controls.Add(richTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contador de Palabras";
            TopMost = true;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox;
        private Button btnCalcular;
    }
}
