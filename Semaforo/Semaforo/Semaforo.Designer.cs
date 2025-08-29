namespace Semaforo
{
    partial class Semaforo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Semaforo));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_rojo = new System.Windows.Forms.Button();
            this.btn_amarillo = new System.Windows.Forms.Button();
            this.btn_verde = new System.Windows.Forms.Button();
            this.timer_semaforo = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_semaforo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(365, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_rojo
            // 
            this.btn_rojo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_rojo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_rojo.Location = new System.Drawing.Point(302, 110);
            this.btn_rojo.Name = "btn_rojo";
            this.btn_rojo.Size = new System.Drawing.Size(185, 107);
            this.btn_rojo.TabIndex = 1;
            this.btn_rojo.UseVisualStyleBackColor = false;
            // 
            // btn_amarillo
            // 
            this.btn_amarillo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_amarillo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_amarillo.Location = new System.Drawing.Point(302, 225);
            this.btn_amarillo.Name = "btn_amarillo";
            this.btn_amarillo.Size = new System.Drawing.Size(185, 107);
            this.btn_amarillo.TabIndex = 2;
            this.btn_amarillo.UseVisualStyleBackColor = false;
            // 
            // btn_verde
            // 
            this.btn_verde.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_verde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_verde.Location = new System.Drawing.Point(302, 338);
            this.btn_verde.Name = "btn_verde";
            this.btn_verde.Size = new System.Drawing.Size(185, 107);
            this.btn_verde.TabIndex = 3;
            this.btn_verde.UseVisualStyleBackColor = false;
            // 
            // timer_semaforo
            // 
            this.timer_semaforo.Interval = 1000;
            this.timer_semaforo.Tick += new System.EventHandler(this.timer_semaforo_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "SEMAFORO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(615, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rojo  10 segundos\r\nAmarillo 3 segundos \r\nVerde   7 segundos";
            // 
            // btn_semaforo
            // 
            this.btn_semaforo.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_semaforo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_semaforo.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_semaforo.Location = new System.Drawing.Point(22, 225);
            this.btn_semaforo.Name = "btn_semaforo";
            this.btn_semaforo.Size = new System.Drawing.Size(146, 54);
            this.btn_semaforo.TabIndex = 6;
            this.btn_semaforo.TabStop = false;
            this.btn_semaforo.Text = "PARAR";
            this.btn_semaforo.UseVisualStyleBackColor = false;
            this.btn_semaforo.Click += new System.EventHandler(this.btn_semaforo_Click);
            this.btn_semaforo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_semaforo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 80);
            this.label3.TabIndex = 7;
            this.label3.Text = "Herramientas usadas \r\nPictureBox\r\nTimer\r\nButton \r\nLabel";
            // 
            // Semaforo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_semaforo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_verde);
            this.Controls.Add(this.btn_amarillo);
            this.Controls.Add(this.btn_rojo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Semaforo";
            this.Text = "Semaforo";
            this.Load += new System.EventHandler(this.Semaforo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_rojo;
        private System.Windows.Forms.Button btn_amarillo;
        private System.Windows.Forms.Button btn_verde;
        private System.Windows.Forms.Timer timer_semaforo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_semaforo;
        private System.Windows.Forms.Label label3;
    }
}