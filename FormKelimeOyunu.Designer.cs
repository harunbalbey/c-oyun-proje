namespace Proje_Oyunlar
{
    partial class FormKelimeOyunu
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
            components = new System.ComponentModel.Container();
            lblSaniye = new Label();
            lblKelime = new Label();
            textBox1 = new TextBox();
            buttonPas = new Button();
            buttonKontrolEt = new Button();
            lblPuan = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            btnBasla = new Button();
            SuspendLayout();
            // 
            // lblSaniye
            // 
            lblSaniye.AutoSize = true;
            lblSaniye.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSaniye.ForeColor = Color.Red;
            lblSaniye.Location = new Point(333, 5);
            lblSaniye.Name = "lblSaniye";
            lblSaniye.Size = new Size(76, 59);
            lblSaniye.TabIndex = 0;
            lblSaniye.Text = "30";
            // 
            // lblKelime
            // 
            lblKelime.AutoSize = true;
            lblKelime.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblKelime.Location = new Point(278, 75);
            lblKelime.Name = "lblKelime";
            lblKelime.Size = new Size(188, 59);
            lblKelime.TabIndex = 1;
            lblKelime.Text = "KELİME";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(205, 172);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 47);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // buttonPas
            // 
            buttonPas.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonPas.Location = new Point(251, 345);
            buttonPas.Name = "buttonPas";
            buttonPas.Size = new Size(234, 85);
            buttonPas.TabIndex = 3;
            buttonPas.Text = "PAS";
            buttonPas.UseVisualStyleBackColor = true;
            buttonPas.Click += buttonPas_Click;
            // 
            // buttonKontrolEt
            // 
            buttonKontrolEt.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonKontrolEt.Location = new Point(251, 247);
            buttonKontrolEt.Name = "buttonKontrolEt";
            buttonKontrolEt.Size = new Size(234, 85);
            buttonKontrolEt.TabIndex = 4;
            buttonKontrolEt.Text = "KONTROL ET";
            buttonKontrolEt.UseVisualStyleBackColor = true;
            buttonKontrolEt.Click += buttonKontrolEt_Click;
            // 
            // lblPuan
            // 
            lblPuan.AutoSize = true;
            lblPuan.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPuan.ForeColor = Color.FromArgb(0, 0, 192);
            lblPuan.Location = new Point(12, 26);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(53, 59);
            lblPuan.TabIndex = 5;
            lblPuan.Text = "0";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // btnBasla
            // 
            btnBasla.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBasla.Location = new Point(251, 439);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(234, 85);
            btnBasla.TabIndex = 6;
            btnBasla.Text = "BAŞLA";
            btnBasla.UseVisualStyleBackColor = true;
            btnBasla.Click += btnBasla_Click;
            // 
            // FormKelimeOyunu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 526);
            Controls.Add(btnBasla);
            Controls.Add(lblPuan);
            Controls.Add(buttonKontrolEt);
            Controls.Add(buttonPas);
            Controls.Add(textBox1);
            Controls.Add(lblKelime);
            Controls.Add(lblSaniye);
            Name = "FormKelimeOyunu";
            Text = "KELİME OYUNU";
            Load += FormKelimeOyunu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaniye;
        private Label lblKelime;
        private TextBox textBox1;
        private Button buttonPas;
        private Button buttonKontrolEt;
        private Label lblPuan;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Button btnBasla;
    }
}