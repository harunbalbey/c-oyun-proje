namespace Proje_Oyunlar
{
    partial class FormYılanOyunu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYılanOyunu));
            label1 = new Label();
            pnl = new Panel();
            label2 = new Label();
            lblPuan = new Label();
            label5 = new Label();
            lblSure = new Label();
            timerYilanHareket = new System.Windows.Forms.Timer(components);
            timerSaat = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(18, 9);
            label1.Name = "label1";
            label1.Size = new Size(1001, 97);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // pnl
            // 
            pnl.BorderStyle = BorderStyle.FixedSingle;
            pnl.Location = new Point(18, 120);
            pnl.Name = "pnl";
            pnl.Size = new Size(1000, 480);
            pnl.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(55, 38);
            label2.Name = "label2";
            label2.Size = new Size(75, 27);
            label2.TabIndex = 0;
            label2.Text = "PUAN:";
            // 
            // lblPuan
            // 
            lblPuan.AutoSize = true;
            lblPuan.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblPuan.ForeColor = SystemColors.ButtonHighlight;
            lblPuan.Location = new Point(136, 38);
            lblPuan.Name = "lblPuan";
            lblPuan.Size = new Size(25, 27);
            lblPuan.TabIndex = 2;
            lblPuan.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(839, 38);
            label5.Name = "label5";
            label5.Size = new Size(71, 27);
            label5.TabIndex = 4;
            label5.Text = "SÜRE:";
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.Font = new Font("Cambria", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblSure.ForeColor = SystemColors.ButtonHighlight;
            lblSure.Location = new Point(915, 38);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(25, 27);
            lblSure.TabIndex = 5;
            lblSure.Text = "0";
            // 
            // timerYilanHareket
            // 
            timerYilanHareket.Interval = 150;
            timerYilanHareket.Tick += timerYilanHareket_Tick;
            // 
            // timerSaat
            // 
            timerSaat.Interval = 1000;
            timerSaat.Tick += timerSaat_Tick;
            // 
            // FormYılanOyunu
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1036, 621);
            Controls.Add(lblSure);
            Controls.Add(label5);
            Controls.Add(lblPuan);
            Controls.Add(label2);
            Controls.Add(pnl);
            Controls.Add(label1);
            Font = new Font("Cambria", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FormYılanOyunu";
            Text = "YILAN OYUNU";
            Load += FormYılanOyunu_Load;
            KeyDown += FormYılanOyunu_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel pnl;
        private Label label2;
        private Label lblPuan;
        private Label label5;
        private Label lblSure;
        private System.Windows.Forms.Timer timerYilanHareket;
        private System.Windows.Forms.Timer timerSaat;
    }
}