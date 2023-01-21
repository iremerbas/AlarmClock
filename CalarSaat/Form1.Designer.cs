namespace CalarSaat
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
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.alarmAddBtn = new System.Windows.Forms.Button();
            this.alarmListLb = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.alarmEditBtn = new System.Windows.Forms.Button();
            this.alarmDeleteBtn = new System.Windows.Forms.Button();
            this.clockLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Stop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(14, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(138, 27);
            this.textBox1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(14, 129);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(138, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alarm Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(11, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alarm Music";
            // 
            // alarmAddBtn
            // 
            this.alarmAddBtn.BackColor = System.Drawing.Color.Green;
            this.alarmAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alarmAddBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alarmAddBtn.ForeColor = System.Drawing.Color.White;
            this.alarmAddBtn.Location = new System.Drawing.Point(14, 168);
            this.alarmAddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alarmAddBtn.Name = "alarmAddBtn";
            this.alarmAddBtn.Size = new System.Drawing.Size(138, 31);
            this.alarmAddBtn.TabIndex = 4;
            this.alarmAddBtn.Text = "Alarm Add";
            this.alarmAddBtn.UseVisualStyleBackColor = false;
            this.alarmAddBtn.Click += new System.EventHandler(this.alarmAddBtn_Click);
            // 
            // alarmListLb
            // 
            this.alarmListLb.FormattingEnabled = true;
            this.alarmListLb.ItemHeight = 20;
            this.alarmListLb.Location = new System.Drawing.Point(15, 251);
            this.alarmListLb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alarmListLb.Name = "alarmListLb";
            this.alarmListLb.Size = new System.Drawing.Size(137, 184);
            this.alarmListLb.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(14, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alarm List";
            // 
            // alarmEditBtn
            // 
            this.alarmEditBtn.BackColor = System.Drawing.Color.Blue;
            this.alarmEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alarmEditBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alarmEditBtn.ForeColor = System.Drawing.Color.White;
            this.alarmEditBtn.Location = new System.Drawing.Point(15, 444);
            this.alarmEditBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alarmEditBtn.Name = "alarmEditBtn";
            this.alarmEditBtn.Size = new System.Drawing.Size(70, 31);
            this.alarmEditBtn.TabIndex = 7;
            this.alarmEditBtn.Text = "Edit";
            this.alarmEditBtn.UseVisualStyleBackColor = false;
            // 
            // alarmDeleteBtn
            // 
            this.alarmDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.alarmDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.alarmDeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.alarmDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.alarmDeleteBtn.Location = new System.Drawing.Point(83, 444);
            this.alarmDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.alarmDeleteBtn.Name = "alarmDeleteBtn";
            this.alarmDeleteBtn.Size = new System.Drawing.Size(69, 31);
            this.alarmDeleteBtn.TabIndex = 8;
            this.alarmDeleteBtn.Text = "Delete";
            this.alarmDeleteBtn.UseVisualStyleBackColor = false;
            this.alarmDeleteBtn.Click += new System.EventHandler(this.alarmDeleteBtn_Click);
            // 
            // clockLbl
            // 
            this.clockLbl.AutoSize = true;
            this.clockLbl.BackColor = System.Drawing.Color.Transparent;
            this.clockLbl.Font = new System.Drawing.Font("DS-Digital", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clockLbl.Location = new System.Drawing.Point(195, 37);
            this.clockLbl.Name = "clockLbl";
            this.clockLbl.Size = new System.Drawing.Size(392, 99);
            this.clockLbl.TabIndex = 9;
            this.clockLbl.Text = "00:00:00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(214, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 35);
            this.label4.TabIndex = 10;
            this.label4.Text = "Alarm Bildirimi";
            this.label4.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Stop
            // 
            this.btn_Stop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_Stop.Location = new System.Drawing.Point(421, 164);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(138, 39);
            this.btn_Stop.TabIndex = 11;
            this.btn_Stop.Text = "Stop";
            this.btn_Stop.UseVisualStyleBackColor = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CalarSaat.Properties.Resources.bg1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 515);
            this.Controls.Add(this.btn_Stop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clockLbl);
            this.Controls.Add(this.alarmDeleteBtn);
            this.Controls.Add(this.alarmEditBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.alarmListLb);
            this.Controls.Add(this.alarmAddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private Button alarmAddBtn;
        private ListBox alarmListLb;
        private Label label3;
        private Button alarmEditBtn;
        private Button alarmDeleteBtn;
        private Label clockLbl;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Button btn_Stop;
    }
}