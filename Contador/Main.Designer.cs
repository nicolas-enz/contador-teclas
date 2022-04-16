
namespace Contador
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.count = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ctrlRB = new System.Windows.Forms.RadioButton();
            this.shiftRB = new System.Windows.Forms.RadioButton();
            this.altRB = new System.Windows.Forms.RadioButton();
            this.txtTecla = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Contador";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.count.Location = new System.Drawing.Point(143, 52);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(72, 86);
            this.count.TabIndex = 0;
            this.count.Text = "0";
            this.count.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.altRB);
            this.panel1.Controls.Add(this.shiftRB);
            this.panel1.Controls.Add(this.ctrlRB);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(101, 86);
            this.panel1.TabIndex = 1;
            // 
            // ctrlRB
            // 
            this.ctrlRB.AutoSize = true;
            this.ctrlRB.Location = new System.Drawing.Point(3, 3);
            this.ctrlRB.Name = "ctrlRB";
            this.ctrlRB.Size = new System.Drawing.Size(44, 19);
            this.ctrlRB.TabIndex = 0;
            this.ctrlRB.Text = "Ctrl";
            this.ctrlRB.UseVisualStyleBackColor = true;
            this.ctrlRB.CheckedChanged += new System.EventHandler(this.ctrlRB_CheckedChanged);
            // 
            // shiftRB
            // 
            this.shiftRB.AutoSize = true;
            this.shiftRB.Location = new System.Drawing.Point(3, 29);
            this.shiftRB.Name = "shiftRB";
            this.shiftRB.Size = new System.Drawing.Size(49, 19);
            this.shiftRB.TabIndex = 1;
            this.shiftRB.Text = "Shift";
            this.shiftRB.UseVisualStyleBackColor = true;
            this.shiftRB.CheckedChanged += new System.EventHandler(this.shiftRB_CheckedChanged);
            // 
            // altRB
            // 
            this.altRB.AutoSize = true;
            this.altRB.Location = new System.Drawing.Point(4, 54);
            this.altRB.Name = "altRB";
            this.altRB.Size = new System.Drawing.Size(40, 19);
            this.altRB.TabIndex = 2;
            this.altRB.Text = "Alt";
            this.altRB.UseVisualStyleBackColor = true;
            this.altRB.CheckedChanged += new System.EventHandler(this.altRB_CheckedChanged);
            // 
            // txtTecla
            // 
            this.txtTecla.Location = new System.Drawing.Point(15, 144);
            this.txtTecla.MaxLength = 1;
            this.txtTecla.Name = "txtTecla";
            this.txtTecla.Size = new System.Drawing.Size(39, 23);
            this.txtTecla.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "No se acepta F1-F12, ni teclas del pad numerico.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tecla";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(140, 207);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar Hotkey";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 255);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTecla);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.count);
            this.Name = "Main";
            this.Text = "Contador";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton altRB;
        private System.Windows.Forms.RadioButton shiftRB;
        private System.Windows.Forms.RadioButton ctrlRB;
        private System.Windows.Forms.TextBox txtTecla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
    }
}

