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
            button1 = new Button();
            trackBar1 = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(115, 35);
            button1.TabIndex = 0;
            button1.Text = "Reiniciar";
            button1.UseVisualStyleBackColor = true;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(144, 12);
            trackBar1.Maximum = 13;
            trackBar1.Minimum = 2;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(380, 45);
            trackBar1.TabIndex = 1;
            trackBar1.Value = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F);
            label1.Location = new Point(530, 15);
            label1.Name = "label1";
            label1.Size = new Size(29, 32);
            label1.TabIndex = 2;
            label1.Text = "2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(678, 10);
            label2.Name = "label2";
            label2.Size = new Size(192, 32);
            label2.TabIndex = 3;
            label2.Text = "Movimientos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(678, 52);
            label3.Name = "label3";
            label3.Size = new Size(96, 32);
            label3.TabIndex = 4;
            label3.Text = "Mejor:";
            // 
            // groupBox1
            // 
            groupBox1.BackgroundImage = Properties.Resources.Recurso_1_2x;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Location = new Point(12, 144);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(375, 500);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Torre 1";
            // 
            // groupBox2
            // 
            groupBox2.BackgroundImage = Properties.Resources.Recurso_1_2x;
            groupBox2.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox2.Location = new Point(393, 144);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(375, 500);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Torre 2";
            // 
            // groupBox3
            // 
            groupBox3.BackgroundImage = Properties.Resources.Recurso_1_2x;
            groupBox3.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox3.Location = new Point(774, 144);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(375, 500);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Torre 3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 656);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBar1);
            Controls.Add(button1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Torres de Hanoi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TrackBar trackBar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
