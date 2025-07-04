namespace TorresDeHanoi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            buttonReiniciar = new Button();
            trackBarDiscos = new TrackBar();
            labelCantidadDiscos = new Label();
            labelMovimientos = new Label();
            labelMejor = new Label();
            groupBoxTorre1 = new GroupBox();
            groupBoxTorre2 = new GroupBox();
            labelGanador = new Label();
            groupBoxTorre3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)trackBarDiscos).BeginInit();
            SuspendLayout();
            // 
            // buttonReiniciar
            // 
            buttonReiniciar.BackColor = SystemColors.InactiveCaption;
            buttonReiniciar.Cursor = Cursors.Hand;
            buttonReiniciar.Location = new Point(12, 12);
            buttonReiniciar.Name = "buttonReiniciar";
            buttonReiniciar.Size = new Size(115, 35);
            buttonReiniciar.TabIndex = 0;
            buttonReiniciar.Text = "Reiniciar";
            buttonReiniciar.UseVisualStyleBackColor = false;
            buttonReiniciar.Click += buttonReiniciar_Click;
            // 
            // trackBarDiscos
            // 
            trackBarDiscos.Location = new Point(144, 12);
            trackBarDiscos.Maximum = 13;
            trackBarDiscos.Minimum = 2;
            trackBarDiscos.Name = "trackBarDiscos";
            trackBarDiscos.Size = new Size(380, 45);
            trackBarDiscos.TabIndex = 1;
            trackBarDiscos.Value = 2;
            trackBarDiscos.Scroll += trackBarDiscos_Scroll;
            // 
            // labelCantidadDiscos
            // 
            labelCantidadDiscos.AutoSize = true;
            labelCantidadDiscos.Font = new Font("Arial", 20.25F);
            labelCantidadDiscos.Location = new Point(530, 15);
            labelCantidadDiscos.Name = "labelCantidadDiscos";
            labelCantidadDiscos.Size = new Size(29, 32);
            labelCantidadDiscos.TabIndex = 2;
            labelCantidadDiscos.Text = "2";
            // 
            // labelMovimientos
            // 
            labelMovimientos.AutoSize = true;
            labelMovimientos.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            labelMovimientos.ForeColor = SystemColors.MenuHighlight;
            labelMovimientos.Location = new Point(678, 10);
            labelMovimientos.Name = "labelMovimientos";
            labelMovimientos.Size = new Size(215, 32);
            labelMovimientos.TabIndex = 3;
            labelMovimientos.Text = "Movimientos: 0";
            // 
            // labelMejor
            // 
            labelMejor.AutoSize = true;
            labelMejor.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            labelMejor.ForeColor = SystemColors.Highlight;
            labelMejor.Location = new Point(678, 52);
            labelMejor.Name = "labelMejor";
            labelMejor.Size = new Size(119, 32);
            labelMejor.TabIndex = 4;
            labelMejor.Text = "Mejor: 3";
            // 
            // groupBoxTorre1
            // 
            groupBoxTorre1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxTorre1.BackColor = SystemColors.Control;
            groupBoxTorre1.BackgroundImage = Properties.Resources.Recurso_1_2x;
            groupBoxTorre1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxTorre1.Location = new Point(12, 94);
            groupBoxTorre1.Name = "groupBoxTorre1";
            groupBoxTorre1.Size = new Size(375, 500);
            groupBoxTorre1.TabIndex = 2;
            groupBoxTorre1.TabStop = false;
            // 
            // groupBoxTorre2
            // 
            groupBoxTorre2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxTorre2.BackgroundImage = Properties.Resources.Recurso_1_2x;
            groupBoxTorre2.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxTorre2.Location = new Point(393, 94);
            groupBoxTorre2.Name = "groupBoxTorre2";
            groupBoxTorre2.Size = new Size(375, 500);
            groupBoxTorre2.TabIndex = 3;
            groupBoxTorre2.TabStop = false;
            // 
            // labelGanador
            // 
            labelGanador.AutoSize = true;
            labelGanador.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            labelGanador.ForeColor = Color.Red;
            labelGanador.Location = new Point(12, 52);
            labelGanador.Name = "labelGanador";
            labelGanador.Size = new Size(295, 32);
            labelGanador.TabIndex = 5;
            labelGanador.Text = "¡Ganaste, felicidades!";
            labelGanador.Visible = false;
            // 
            // groupBoxTorre3
            // 
            groupBoxTorre3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBoxTorre3.BackgroundImage = Properties.Resources.Recurso_1_2x;
            groupBoxTorre3.BackgroundImageLayout = ImageLayout.Stretch;
            groupBoxTorre3.Location = new Point(774, 94);
            groupBoxTorre3.Name = "groupBoxTorre3";
            groupBoxTorre3.Size = new Size(375, 500);
            groupBoxTorre3.TabIndex = 4;
            groupBoxTorre3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1161, 606);
            Controls.Add(groupBoxTorre3);
            Controls.Add(labelGanador);
            Controls.Add(groupBoxTorre2);
            Controls.Add(groupBoxTorre1);
            Controls.Add(labelMejor);
            Controls.Add(labelMovimientos);
            Controls.Add(labelCantidadDiscos);
            Controls.Add(trackBarDiscos);
            Controls.Add(buttonReiniciar);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(1177, 645);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Torres de Hanoi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBarDiscos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonReiniciar;
        private TrackBar trackBarDiscos;
        private Label labelCantidadDiscos;
        private Label labelMovimientos;
        private Label labelMejor;
        private GroupBox groupBoxTorre1;
        private GroupBox groupBoxTorre2;
        private Label labelGanador;
        private GroupBox groupBoxTorre3;
    }
}
