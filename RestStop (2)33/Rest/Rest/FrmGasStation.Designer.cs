﻿namespace Rest
{
    partial class FrmGasStation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGasStation));
            this.cmbRoute = new System.Windows.Forms.ComboBox();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdoSearchByRoute = new System.Windows.Forms.RadioButton();
            this.rdoSearchByReststop = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblLpgPrice = new System.Windows.Forms.Label();
            this.lblDieselPrice = new System.Windows.Forms.Label();
            this.lblGasolinePrice = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblRestName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbRoute
            // 
            this.cmbRoute.BackColor = System.Drawing.Color.Gray;
            this.cmbRoute.ForeColor = System.Drawing.Color.Black;
            this.cmbRoute.FormattingEnabled = true;
            this.cmbRoute.Location = new System.Drawing.Point(170, 11);
            this.cmbRoute.Name = "cmbRoute";
            this.cmbRoute.Size = new System.Drawing.Size(192, 20);
            this.cmbRoute.TabIndex = 4;
            this.cmbRoute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbRoute_KeyDown);
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.BackColor = System.Drawing.Color.Gray;
            this.txtSearchByName.ForeColor = System.Drawing.Color.Black;
            this.txtSearchByName.Location = new System.Drawing.Point(170, 42);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(192, 21);
            this.txtSearchByName.TabIndex = 6;
            this.txtSearchByName.Visible = false;
            this.txtSearchByName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchByName_KeyDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(368, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 19);
            this.button1.TabIndex = 3;
            this.button1.Text = "검색";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdoSearchByRoute
            // 
            this.rdoSearchByRoute.AutoSize = true;
            this.rdoSearchByRoute.Location = new System.Drawing.Point(13, 15);
            this.rdoSearchByRoute.Name = "rdoSearchByRoute";
            this.rdoSearchByRoute.Size = new System.Drawing.Size(151, 16);
            this.rdoSearchByRoute.TabIndex = 4;
            this.rdoSearchByRoute.TabStop = true;
            this.rdoSearchByRoute.Text = "고속도로 이름으로 찾기";
            this.rdoSearchByRoute.UseVisualStyleBackColor = true;
            this.rdoSearchByRoute.CheckedChanged += new System.EventHandler(this.rdoSearchByRoute_CheckedChanged);
            // 
            // rdoSearchByReststop
            // 
            this.rdoSearchByReststop.AutoSize = true;
            this.rdoSearchByReststop.Location = new System.Drawing.Point(13, 42);
            this.rdoSearchByReststop.Name = "rdoSearchByReststop";
            this.rdoSearchByReststop.Size = new System.Drawing.Size(139, 16);
            this.rdoSearchByReststop.TabIndex = 5;
            this.rdoSearchByReststop.TabStop = true;
            this.rdoSearchByReststop.Text = "휴게소 이름으로 찾기";
            this.rdoSearchByReststop.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 539);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "데이터는 하루를 기준으로 갱신됩니다.";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(418, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 32;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.Location = new System.Drawing.Point(368, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "<";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblLpgPrice
            // 
            this.lblLpgPrice.AutoSize = true;
            this.lblLpgPrice.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblLpgPrice.ForeColor = System.Drawing.Color.Black;
            this.lblLpgPrice.Location = new System.Drawing.Point(13, 13);
            this.lblLpgPrice.Name = "lblLpgPrice";
            this.lblLpgPrice.Size = new System.Drawing.Size(0, 23);
            this.lblLpgPrice.TabIndex = 28;
            // 
            // lblDieselPrice
            // 
            this.lblDieselPrice.AutoSize = true;
            this.lblDieselPrice.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblDieselPrice.ForeColor = System.Drawing.Color.Black;
            this.lblDieselPrice.Location = new System.Drawing.Point(13, 12);
            this.lblDieselPrice.Name = "lblDieselPrice";
            this.lblDieselPrice.Size = new System.Drawing.Size(0, 23);
            this.lblDieselPrice.TabIndex = 27;
            // 
            // lblGasolinePrice
            // 
            this.lblGasolinePrice.AutoSize = true;
            this.lblGasolinePrice.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold);
            this.lblGasolinePrice.ForeColor = System.Drawing.Color.Black;
            this.lblGasolinePrice.Location = new System.Drawing.Point(13, 11);
            this.lblGasolinePrice.Name = "lblGasolinePrice";
            this.lblGasolinePrice.Size = new System.Drawing.Size(0, 23);
            this.lblGasolinePrice.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Lpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "경유";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("맑은 고딕", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 23);
            this.label6.TabIndex = 21;
            this.label6.Text = "휘발유";
            // 
            // lblRestName
            // 
            this.lblRestName.AutoSize = true;
            this.lblRestName.BackColor = System.Drawing.Color.Black;
            this.lblRestName.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRestName.ForeColor = System.Drawing.Color.White;
            this.lblRestName.Location = new System.Drawing.Point(9, 0);
            this.lblRestName.Name = "lblRestName";
            this.lblRestName.Size = new System.Drawing.Size(0, 28);
            this.lblRestName.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rest.Properties.Resources.GAS1;
            this.pictureBox1.Location = new System.Drawing.Point(22, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(349, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel1.Controls.Add(this.lblRestName);
            this.panel1.Location = new System.Drawing.Point(38, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 44);
            this.panel1.TabIndex = 34;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.label6);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(38, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 41);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.label3);
            this.panel3.ForeColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(38, 396);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(102, 41);
            this.panel3.TabIndex = 36;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.label4);
            this.panel4.ForeColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(38, 454);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(102, 41);
            this.panel4.TabIndex = 36;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lblGasolinePrice);
            this.panel5.Location = new System.Drawing.Point(180, 334);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(171, 41);
            this.panel5.TabIndex = 36;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lblDieselPrice);
            this.panel6.Location = new System.Drawing.Point(180, 396);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(171, 41);
            this.panel6.TabIndex = 36;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblLpgPrice);
            this.panel7.Location = new System.Drawing.Point(180, 454);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(171, 41);
            this.panel7.TabIndex = 37;
            // 
            // FrmGasStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(456, 558);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rdoSearchByReststop);
            this.Controls.Add(this.rdoSearchByRoute);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.cmbRoute);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "FrmGasStation";
            this.Text = "주유";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.FrmGasStation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbRoute;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdoSearchByRoute;
        private System.Windows.Forms.RadioButton rdoSearchByReststop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblLpgPrice;
        private System.Windows.Forms.Label lblDieselPrice;
        private System.Windows.Forms.Label lblGasolinePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblRestName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}