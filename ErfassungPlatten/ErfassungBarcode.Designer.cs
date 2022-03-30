
namespace ErfassungPlatten
{
    partial class ErfassungBarcode
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxNVE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInventarNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelScanner = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonCom1 = new System.Windows.Forms.RadioButton();
            this.radioButtonCom2 = new System.Windows.Forms.RadioButton();
            this.radioButtonCom3 = new System.Windows.Forms.RadioButton();
            this.radioButtonCom4 = new System.Windows.Forms.RadioButton();
            this.radioButtonCom5 = new System.Windows.Forms.RadioButton();
            this.radioButtonCom6 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonCom8 = new System.Windows.Forms.RadioButton();
            this.radioButtonCom7 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonDatabase = new System.Windows.Forms.RadioButton();
            this.radioButtonCSV = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 19);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(212, 206);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(250, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "Einschalten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(250, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ausschalten";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(218, 337);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 231);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Port Datalogic";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBoxNVE
            // 
            this.textBoxNVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNVE.Location = new System.Drawing.Point(116, 56);
            this.textBoxNVE.Name = "textBoxNVE";
            this.textBoxNVE.ReadOnly = true;
            this.textBoxNVE.Size = new System.Drawing.Size(308, 26);
            this.textBoxNVE.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Barcode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "InventarNo";
            // 
            // textBoxInventarNo
            // 
            this.textBoxInventarNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInventarNo.Location = new System.Drawing.Point(116, 88);
            this.textBoxInventarNo.Name = "textBoxInventarNo";
            this.textBoxInventarNo.Size = new System.Drawing.Size(308, 26);
            this.textBoxInventarNo.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Scanner Erfassung";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelScanner
            // 
            this.LabelScanner.AutoSize = true;
            this.LabelScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelScanner.Location = new System.Drawing.Point(246, 19);
            this.LabelScanner.Name = "LabelScanner";
            this.LabelScanner.Size = new System.Drawing.Size(97, 24);
            this.LabelScanner.TabIndex = 10;
            this.LabelScanner.Text = "Nicht Aktiv";
            this.LabelScanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Scanner Barcode:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxNVE);
            this.groupBox2.Controls.Add(this.textBoxInventarNo);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 120);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // radioButtonCom1
            // 
            this.radioButtonCom1.AutoSize = true;
            this.radioButtonCom1.Location = new System.Drawing.Point(22, 19);
            this.radioButtonCom1.Name = "radioButtonCom1";
            this.radioButtonCom1.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCom1.TabIndex = 13;
            this.radioButtonCom1.Text = "COM1";
            this.radioButtonCom1.UseVisualStyleBackColor = true;
            this.radioButtonCom1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButtonCom2
            // 
            this.radioButtonCom2.AutoSize = true;
            this.radioButtonCom2.Location = new System.Drawing.Point(22, 42);
            this.radioButtonCom2.Name = "radioButtonCom2";
            this.radioButtonCom2.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCom2.TabIndex = 14;
            this.radioButtonCom2.Text = "COM2";
            this.radioButtonCom2.UseVisualStyleBackColor = true;
            // 
            // radioButtonCom3
            // 
            this.radioButtonCom3.AutoSize = true;
            this.radioButtonCom3.Location = new System.Drawing.Point(22, 65);
            this.radioButtonCom3.Name = "radioButtonCom3";
            this.radioButtonCom3.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCom3.TabIndex = 15;
            this.radioButtonCom3.Text = "COM3";
            this.radioButtonCom3.UseVisualStyleBackColor = true;
            // 
            // radioButtonCom4
            // 
            this.radioButtonCom4.AutoSize = true;
            this.radioButtonCom4.Location = new System.Drawing.Point(22, 88);
            this.radioButtonCom4.Name = "radioButtonCom4";
            this.radioButtonCom4.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCom4.TabIndex = 16;
            this.radioButtonCom4.Text = "COM4";
            this.radioButtonCom4.UseVisualStyleBackColor = true;
            // 
            // radioButtonCom5
            // 
            this.radioButtonCom5.AutoSize = true;
            this.radioButtonCom5.Location = new System.Drawing.Point(107, 20);
            this.radioButtonCom5.Name = "radioButtonCom5";
            this.radioButtonCom5.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCom5.TabIndex = 17;
            this.radioButtonCom5.Text = "COM5";
            this.radioButtonCom5.UseVisualStyleBackColor = true;
            // 
            // radioButtonCom6
            // 
            this.radioButtonCom6.AutoSize = true;
            this.radioButtonCom6.Checked = true;
            this.radioButtonCom6.Location = new System.Drawing.Point(107, 43);
            this.radioButtonCom6.Name = "radioButtonCom6";
            this.radioButtonCom6.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCom6.TabIndex = 18;
            this.radioButtonCom6.TabStop = true;
            this.radioButtonCom6.Text = "COM6";
            this.radioButtonCom6.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.radioButtonCom8);
            this.groupBox3.Controls.Add(this.radioButtonCom7);
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.radioButtonCom4);
            this.groupBox3.Controls.Add(this.radioButtonCom6);
            this.groupBox3.Controls.Add(this.radioButtonCom1);
            this.groupBox3.Controls.Add(this.radioButtonCom5);
            this.groupBox3.Controls.Add(this.radioButtonCom2);
            this.groupBox3.Controls.Add(this.radioButtonCom3);
            this.groupBox3.Location = new System.Drawing.Point(12, 412);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 156);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Serial Port";
            // 
            // radioButtonCom8
            // 
            this.radioButtonCom8.AutoSize = true;
            this.radioButtonCom8.Location = new System.Drawing.Point(107, 89);
            this.radioButtonCom8.Name = "radioButtonCom8";
            this.radioButtonCom8.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCom8.TabIndex = 21;
            this.radioButtonCom8.Text = "COM8";
            this.radioButtonCom8.UseVisualStyleBackColor = true;
            // 
            // radioButtonCom7
            // 
            this.radioButtonCom7.AutoSize = true;
            this.radioButtonCom7.Location = new System.Drawing.Point(107, 66);
            this.radioButtonCom7.Name = "radioButtonCom7";
            this.radioButtonCom7.Size = new System.Drawing.Size(55, 17);
            this.radioButtonCom7.TabIndex = 20;
            this.radioButtonCom7.Text = "COM7";
            this.radioButtonCom7.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(22, 122);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Port aktivieren";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonDatabase);
            this.groupBox4.Controls.Add(this.radioButtonCSV);
            this.groupBox4.Location = new System.Drawing.Point(12, 357);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 49);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Storage";
            // 
            // radioButtonDatabase
            // 
            this.radioButtonDatabase.AutoSize = true;
            this.radioButtonDatabase.Location = new System.Drawing.Point(116, 19);
            this.radioButtonDatabase.Name = "radioButtonDatabase";
            this.radioButtonDatabase.Size = new System.Drawing.Size(71, 17);
            this.radioButtonDatabase.TabIndex = 1;
            this.radioButtonDatabase.Text = "Database";
            this.radioButtonDatabase.UseVisualStyleBackColor = true;
            this.radioButtonDatabase.CheckedChanged += new System.EventHandler(this.radioButtonDatabase_CheckedChanged);
            // 
            // radioButtonCSV
            // 
            this.radioButtonCSV.AutoSize = true;
            this.radioButtonCSV.Checked = true;
            this.radioButtonCSV.Location = new System.Drawing.Point(13, 19);
            this.radioButtonCSV.Name = "radioButtonCSV";
            this.radioButtonCSV.Size = new System.Drawing.Size(65, 17);
            this.radioButtonCSV.TabIndex = 0;
            this.radioButtonCSV.TabStop = true;
            this.radioButtonCSV.Text = "CSV File";
            this.radioButtonCSV.UseVisualStyleBackColor = true;
            this.radioButtonCSV.CheckedChanged += new System.EventHandler(this.radioButtonCSV_CheckedChanged);
            // 
            // ErfassungBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 580);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LabelScanner);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "ErfassungBarcode";
            this.Text = "Erfassung Barcode";
            this.Load += new System.EventHandler(this.ErfassungPlatten_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxNVE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInventarNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelScanner;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonCom1;
        private System.Windows.Forms.RadioButton radioButtonCom2;
        private System.Windows.Forms.RadioButton radioButtonCom3;
        private System.Windows.Forms.RadioButton radioButtonCom4;
        private System.Windows.Forms.RadioButton radioButtonCom5;
        private System.Windows.Forms.RadioButton radioButtonCom6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButtonCom8;
        private System.Windows.Forms.RadioButton radioButtonCom7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButtonDatabase;
        private System.Windows.Forms.RadioButton radioButtonCSV;
    }
}

