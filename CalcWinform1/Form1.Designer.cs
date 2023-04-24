namespace CalcWinform1
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
            labelEstado = new Label();
            panelCalculadora = new Panel();
            buttonRemover = new Button();
            buttonGenerate = new Button();
            textBoxProcesar = new TextBox();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.BackColor = Color.LightSalmon;
            labelEstado.Dock = DockStyle.Bottom;
            labelEstado.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelEstado.Location = new Point(0, 452);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(64, 20);
            labelEstado.TabIndex = 7;
            labelEstado.Text = "ESTADO";
            labelEstado.TextAlign = ContentAlignment.TopCenter;
            labelEstado.Click += labelEstado_Click;
            // 
            // panelCalculadora
            // 
            panelCalculadora.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panelCalculadora.Location = new Point(21, 130);
            panelCalculadora.Name = "panelCalculadora";
            panelCalculadora.Size = new Size(397, 279);
            panelCalculadora.TabIndex = 6;
            panelCalculadora.Paint += panelCalculadora_Paint;
            // 
            // buttonRemover
            // 
            buttonRemover.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonRemover.Location = new Point(310, 12);
            buttonRemover.Name = "buttonRemover";
            buttonRemover.Size = new Size(108, 43);
            buttonRemover.TabIndex = 5;
            buttonRemover.Text = "Remover";
            buttonRemover.UseVisualStyleBackColor = true;
            buttonRemover.Click += buttonRemover_Click;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(21, 12);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(108, 43);
            buttonGenerate.TabIndex = 4;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // textBoxProcesar
            // 
            textBoxProcesar.Location = new Point(21, 82);
            textBoxProcesar.Name = "textBoxProcesar";
            textBoxProcesar.Size = new Size(397, 23);
            textBoxProcesar.TabIndex = 8;
            textBoxProcesar.TextChanged += textBoxProcesar_TextChanged;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.Tomato;
            buttonClear.Location = new Point(181, 32);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(75, 23);
            buttonClear.TabIndex = 10;
            buttonClear.Text = "Borrar";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 472);
            Controls.Add(buttonClear);
            Controls.Add(textBoxProcesar);
            Controls.Add(labelEstado);
            Controls.Add(panelCalculadora);
            Controls.Add(buttonRemover);
            Controls.Add(buttonGenerate);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelEstado;
        private Panel panelCalculadora;
        private Button buttonRemover;
        private Button buttonGenerate;
        private TextBox textBoxProcesar;
        private Button buttonClear;
    }
}