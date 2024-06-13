namespace Proje_Oyunlar
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
            buttonYilanOyunu = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // buttonYilanOyunu
            // 
            buttonYilanOyunu.BackgroundImage = (Image)resources.GetObject("buttonYilanOyunu.BackgroundImage");
            buttonYilanOyunu.BackgroundImageLayout = ImageLayout.Stretch;
            buttonYilanOyunu.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonYilanOyunu.ForeColor = Color.Black;
            buttonYilanOyunu.Location = new Point(676, 215);
            buttonYilanOyunu.Name = "buttonYilanOyunu";
            buttonYilanOyunu.Size = new Size(273, 173);
            buttonYilanOyunu.TabIndex = 0;
            buttonYilanOyunu.Text = "YILAN OYUNU";
            buttonYilanOyunu.UseVisualStyleBackColor = true;
            buttonYilanOyunu.Click += buttonYilanOyunu_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Brown;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Font = new Font("Showcard Gothic", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(91, 215);
            button1.Name = "button1";
            button1.Size = new Size(273, 173);
            button1.TabIndex = 1;
            button1.Text = "KELİME TAHMİN OYUNU";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1016, 600);
            Controls.Add(button1);
            Controls.Add(buttonYilanOyunu);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonYilanOyunu;
        private Button button1;
    }
}
