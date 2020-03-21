namespace WindowsFormsApplication3
{
    partial class GameForm
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Skor1 = new System.Windows.Forms.Label();
            this.Skor2 = new System.Windows.Forms.Label();
            this.Skor4 = new System.Windows.Forms.Label();
            this.Skor3 = new System.Windows.Forms.Label();
            this.Skor8 = new System.Windows.Forms.Label();
            this.Skor7 = new System.Windows.Forms.Label();
            this.Skor6 = new System.Windows.Forms.Label();
            this.Skor5 = new System.Windows.Forms.Label();
            this.Skor10 = new System.Windows.Forms.Label();
            this.Skor9 = new System.Windows.Forms.Label();
            this.Skor12 = new System.Windows.Forms.Label();
            this.Skor11 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 700);
            this.panel1.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(1190, 690);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 10);
            this.panel4.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkRed;
            this.panel3.Location = new System.Drawing.Point(784, 520);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(16, 15);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(30, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 25);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1218, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Score :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(1218, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "İvme :";
            // 
            // Skor1
            // 
            this.Skor1.AutoSize = true;
            this.Skor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor1.Location = new System.Drawing.Point(1218, 222);
            this.Skor1.Name = "Skor1";
            this.Skor1.Size = new System.Drawing.Size(49, 17);
            this.Skor1.TabIndex = 11;
            this.Skor1.Text = "Skor 1";
            this.Skor1.Visible = false;
            // 
            // Skor2
            // 
            this.Skor2.AutoSize = true;
            this.Skor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor2.Location = new System.Drawing.Point(1218, 255);
            this.Skor2.Name = "Skor2";
            this.Skor2.Size = new System.Drawing.Size(49, 17);
            this.Skor2.TabIndex = 12;
            this.Skor2.Text = "Skor 2";
            this.Skor2.Visible = false;
            // 
            // Skor4
            // 
            this.Skor4.AutoSize = true;
            this.Skor4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor4.Location = new System.Drawing.Point(1217, 330);
            this.Skor4.Name = "Skor4";
            this.Skor4.Size = new System.Drawing.Size(45, 17);
            this.Skor4.TabIndex = 14;
            this.Skor4.Text = "Skor4";
            this.Skor4.Visible = false;
            // 
            // Skor3
            // 
            this.Skor3.AutoSize = true;
            this.Skor3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor3.Location = new System.Drawing.Point(1218, 291);
            this.Skor3.Name = "Skor3";
            this.Skor3.Size = new System.Drawing.Size(49, 17);
            this.Skor3.TabIndex = 13;
            this.Skor3.Text = "Skor 3";
            this.Skor3.Visible = false;
            // 
            // Skor8
            // 
            this.Skor8.AutoSize = true;
            this.Skor8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor8.Location = new System.Drawing.Point(1217, 475);
            this.Skor8.Name = "Skor8";
            this.Skor8.Size = new System.Drawing.Size(49, 17);
            this.Skor8.TabIndex = 18;
            this.Skor8.Text = "Skor 8";
            this.Skor8.Visible = false;
            // 
            // Skor7
            // 
            this.Skor7.AutoSize = true;
            this.Skor7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor7.Location = new System.Drawing.Point(1218, 436);
            this.Skor7.Name = "Skor7";
            this.Skor7.Size = new System.Drawing.Size(49, 17);
            this.Skor7.TabIndex = 17;
            this.Skor7.Text = "Skor 7";
            this.Skor7.Visible = false;
            // 
            // Skor6
            // 
            this.Skor6.AutoSize = true;
            this.Skor6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor6.Location = new System.Drawing.Point(1218, 400);
            this.Skor6.Name = "Skor6";
            this.Skor6.Size = new System.Drawing.Size(49, 17);
            this.Skor6.TabIndex = 16;
            this.Skor6.Text = "Skor 6";
            this.Skor6.Visible = false;
            // 
            // Skor5
            // 
            this.Skor5.AutoSize = true;
            this.Skor5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor5.Location = new System.Drawing.Point(1218, 367);
            this.Skor5.Name = "Skor5";
            this.Skor5.Size = new System.Drawing.Size(49, 17);
            this.Skor5.TabIndex = 15;
            this.Skor5.Text = "Skor 5";
            this.Skor5.Visible = false;
            // 
            // Skor10
            // 
            this.Skor10.AutoSize = true;
            this.Skor10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor10.Location = new System.Drawing.Point(1217, 549);
            this.Skor10.Name = "Skor10";
            this.Skor10.Size = new System.Drawing.Size(57, 17);
            this.Skor10.TabIndex = 20;
            this.Skor10.Text = "Skor 10";
            this.Skor10.Visible = false;
            // 
            // Skor9
            // 
            this.Skor9.AutoSize = true;
            this.Skor9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor9.Location = new System.Drawing.Point(1218, 510);
            this.Skor9.Name = "Skor9";
            this.Skor9.Size = new System.Drawing.Size(49, 17);
            this.Skor9.TabIndex = 19;
            this.Skor9.Text = "Skor 9";
            this.Skor9.Visible = false;
            // 
            // Skor12
            // 
            this.Skor12.AutoSize = true;
            this.Skor12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor12.Location = new System.Drawing.Point(1217, 627);
            this.Skor12.Name = "Skor12";
            this.Skor12.Size = new System.Drawing.Size(57, 17);
            this.Skor12.TabIndex = 22;
            this.Skor12.Text = "Skor 12";
            this.Skor12.Visible = false;
            // 
            // Skor11
            // 
            this.Skor11.AutoSize = true;
            this.Skor11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Skor11.Location = new System.Drawing.Point(1218, 588);
            this.Skor11.Name = "Skor11";
            this.Skor11.Size = new System.Drawing.Size(57, 17);
            this.Skor11.TabIndex = 21;
            this.Skor11.Text = "Skor 11";
            this.Skor11.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 733);
            this.Controls.Add(this.Skor12);
            this.Controls.Add(this.Skor11);
            this.Controls.Add(this.Skor10);
            this.Controls.Add(this.Skor9);
            this.Controls.Add(this.Skor8);
            this.Controls.Add(this.Skor7);
            this.Controls.Add(this.Skor6);
            this.Controls.Add(this.Skor5);
            this.Controls.Add(this.Skor4);
            this.Controls.Add(this.Skor3);
            this.Controls.Add(this.Skor2);
            this.Controls.Add(this.Skor1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Skor1;
        private System.Windows.Forms.Label Skor2;
        private System.Windows.Forms.Label Skor4;
        private System.Windows.Forms.Label Skor3;
        private System.Windows.Forms.Label Skor8;
        private System.Windows.Forms.Label Skor7;
        private System.Windows.Forms.Label Skor6;
        private System.Windows.Forms.Label Skor5;
        private System.Windows.Forms.Label Skor10;
        private System.Windows.Forms.Label Skor9;
        private System.Windows.Forms.Label Skor12;
        private System.Windows.Forms.Label Skor11;
    }
}

