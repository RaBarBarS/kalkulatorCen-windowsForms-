namespace nowy
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_monitor = new System.Windows.Forms.Button();
            this.button_komputer = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_monitor_aktu = new System.Windows.Forms.Button();
            this.button_procesor = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(798, 457);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.sum);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button_monitor);
            this.tabPage1.Controls.Add(this.button_komputer);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(790, 429);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "NOWY";
            // 
            // sum
            // 
            this.sum.BackColor = System.Drawing.SystemColors.Menu;
            this.sum.Enabled = false;
            this.sum.Location = new System.Drawing.Point(539, 188);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(150, 22);
            this.sum.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(536, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "CENA zł";
            // 
            // button_monitor
            // 
            this.button_monitor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_monitor.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_monitor.ForeColor = System.Drawing.Color.White;
            this.button_monitor.Location = new System.Drawing.Point(331, 164);
            this.button_monitor.Name = "button_monitor";
            this.button_monitor.Size = new System.Drawing.Size(150, 50);
            this.button_monitor.TabIndex = 1;
            this.button_monitor.Text = "MONITOR";
            this.button_monitor.UseVisualStyleBackColor = false;
            this.button_monitor.Click += new System.EventHandler(this.button_monitor_Click);
            // 
            // button_komputer
            // 
            this.button_komputer.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_komputer.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_komputer.ForeColor = System.Drawing.Color.White;
            this.button_komputer.Location = new System.Drawing.Point(125, 164);
            this.button_komputer.Name = "button_komputer";
            this.button_komputer.Size = new System.Drawing.Size(150, 50);
            this.button_komputer.TabIndex = 0;
            this.button_komputer.Text = "KOMPUTER";
            this.button_komputer.UseVisualStyleBackColor = false;
            this.button_komputer.Click += new System.EventHandler(this.button_komputer_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.button_monitor_aktu);
            this.tabPage2.Controls.Add(this.button_procesor);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(790, 429);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "AKTUALIZACJA";
            // 
            // button_monitor_aktu
            // 
            this.button_monitor_aktu.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_monitor_aktu.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_monitor_aktu.ForeColor = System.Drawing.Color.White;
            this.button_monitor_aktu.Location = new System.Drawing.Point(426, 147);
            this.button_monitor_aktu.Name = "button_monitor_aktu";
            this.button_monitor_aktu.Size = new System.Drawing.Size(150, 50);
            this.button_monitor_aktu.TabIndex = 1;
            this.button_monitor_aktu.Text = "MONITOR";
            this.button_monitor_aktu.UseVisualStyleBackColor = false;
            this.button_monitor_aktu.Click += new System.EventHandler(this.button_monitor_aktu_Click);
            // 
            // button_procesor
            // 
            this.button_procesor.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button_procesor.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_procesor.ForeColor = System.Drawing.Color.White;
            this.button_procesor.Location = new System.Drawing.Point(217, 147);
            this.button_procesor.Name = "button_procesor";
            this.button_procesor.Size = new System.Drawing.Size(150, 50);
            this.button_procesor.TabIndex = 0;
            this.button_procesor.Text = "PROCESOR";
            this.button_procesor.UseVisualStyleBackColor = false;
            this.button_procesor.Click += new System.EventHandler(this.button_procesor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "KALKULATOR ZESTAWÓW KOMPUTEROWYCH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox sum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_monitor;
        private System.Windows.Forms.Button button_komputer;
        private System.Windows.Forms.Button button_monitor_aktu;
        private System.Windows.Forms.Button button_procesor;
    }
}

