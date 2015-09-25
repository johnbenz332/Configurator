namespace Configurator_Help
{
    partial class main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdo_15min = new System.Windows.Forms.RadioButton();
            this.rdo_1min = new System.Windows.Forms.RadioButton();
            this.txt_SO = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txt_pfl = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_S1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(627, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.rdo_15min);
            this.tabPage1.Controls.Add(this.rdo_1min);
            this.tabPage1.Controls.Add(this.txt_SO);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(619, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "S0: Logger Config";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desired  sampling period";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = " Hours, in 0.25 hour increments. Max 31 hours";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Desired logger Speed";
            // 
            // rdo_15min
            // 
            this.rdo_15min.AutoSize = true;
            this.rdo_15min.Location = new System.Drawing.Point(177, 179);
            this.rdo_15min.Name = "rdo_15min";
            this.rdo_15min.Size = new System.Drawing.Size(107, 17);
            this.rdo_15min.TabIndex = 2;
            this.rdo_15min.TabStop = true;
            this.rdo_15min.Text = "Every 15 Minutes";
            this.rdo_15min.UseVisualStyleBackColor = true;
            this.rdo_15min.CheckedChanged += new System.EventHandler(this.rdo_15min_CheckedChanged);
            // 
            // rdo_1min
            // 
            this.rdo_1min.AutoSize = true;
            this.rdo_1min.Location = new System.Drawing.Point(177, 156);
            this.rdo_1min.Name = "rdo_1min";
            this.rdo_1min.Size = new System.Drawing.Size(96, 17);
            this.rdo_1min.TabIndex = 1;
            this.rdo_1min.TabStop = true;
            this.rdo_1min.Text = "Every 1 Minute";
            this.rdo_1min.UseVisualStyleBackColor = true;
            this.rdo_1min.CheckedChanged += new System.EventHandler(this.rdo_1min_CheckedChanged);
            // 
            // txt_SO
            // 
            this.txt_SO.Location = new System.Drawing.Point(192, 77);
            this.txt_SO.Name = "txt_SO";
            this.txt_SO.Size = new System.Drawing.Size(100, 20);
            this.txt_SO.TabIndex = 0;
            this.txt_SO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SO.TextChanged += new System.EventHandler(this.txt_SO_TextChanged);
            this.txt_SO.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SO_KeyPress);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txt_S1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(619, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "S1: GSM Listen Config";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(619, 277);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "S2: Schedule Configurator";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(619, 277);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "S3: Control Configurator";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txt_pfl
            // 
            this.txt_pfl.Location = new System.Drawing.Point(12, 331);
            this.txt_pfl.Multiline = true;
            this.txt_pfl.Name = "txt_pfl";
            this.txt_pfl.ReadOnly = true;
            this.txt_pfl.Size = new System.Drawing.Size(627, 44);
            this.txt_pfl.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 381);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(208, 381);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 3;
            this.btn_prev.Text = "<< Prev";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(390, 381);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 4;
            this.btn_next.Text = "Next >>";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_copy
            // 
            this.btn_copy.Location = new System.Drawing.Point(544, 381);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(95, 23);
            this.btn_copy.TabIndex = 5;
            this.btn_copy.Text = "Copy Command";
            this.btn_copy.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Multiples of 5  Minutes, (155 minutes max)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Desired GSM listen Period";
            // 
            // txt_S1
            // 
            this.txt_S1.Location = new System.Drawing.Point(192, 77);
            this.txt_S1.Name = "txt_S1";
            this.txt_S1.Size = new System.Drawing.Size(100, 20);
            this.txt_S1.TabIndex = 5;
            this.txt_S1.TextChanged += new System.EventHandler(this.txt_S1_TextChanged);
            this.txt_S1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_S1_KeyPress);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 410);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.txt_pfl);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurator Help";
            this.Load += new System.EventHandler(this.main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txt_pfl;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdo_15min;
        private System.Windows.Forms.RadioButton rdo_1min;
        private System.Windows.Forms.TextBox txt_SO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_S1;
    }
}

