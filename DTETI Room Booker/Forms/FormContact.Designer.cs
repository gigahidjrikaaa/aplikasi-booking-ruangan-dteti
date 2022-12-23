namespace DTETI_Room_Booker.Forms
{
    partial class FormContact
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
            this.lblSendMessage = new System.Windows.Forms.Label();
            this.lblName1 = new System.Windows.Forms.Label();
            this.lblName2 = new System.Windows.Forms.Label();
            this.lblName3 = new System.Windows.Forms.Label();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.btnSend3 = new System.Windows.Forms.Button();
            this.txtBoxMessage3 = new DTETI_Room_Booker.CustomTextBox();
            this.txtBoxMessage2 = new DTETI_Room_Booker.CustomTextBox();
            this.txtBoxMessage1 = new DTETI_Room_Booker.CustomTextBox();
            this.circularPictureBox2 = new DTETI_Room_Booker.CircularPictureBox();
            this.circularPictureBox3 = new DTETI_Room_Booker.CircularPictureBox();
            this.circularPictureBox1 = new DTETI_Room_Booker.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSendMessage
            // 
            this.lblSendMessage.AutoSize = true;
            this.lblSendMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendMessage.ForeColor = System.Drawing.Color.Black;
            this.lblSendMessage.Location = new System.Drawing.Point(62, 53);
            this.lblSendMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSendMessage.Name = "lblSendMessage";
            this.lblSendMessage.Size = new System.Drawing.Size(541, 44);
            this.lblSendMessage.TabIndex = 0;
            this.lblSendMessage.Text = "Send a Message to the Devs!";
            this.lblSendMessage.Click += new System.EventHandler(this.lblContact1_Click);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.ForeColor = System.Drawing.Color.Black;
            this.lblName1.Location = new System.Drawing.Point(64, 116);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(78, 36);
            this.lblName1.TabIndex = 1;
            this.lblName1.Text = "Giga";
            // 
            // lblName2
            // 
            this.lblName2.AutoSize = true;
            this.lblName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName2.ForeColor = System.Drawing.Color.Black;
            this.lblName2.Location = new System.Drawing.Point(64, 344);
            this.lblName2.Name = "lblName2";
            this.lblName2.Size = new System.Drawing.Size(75, 36);
            this.lblName2.TabIndex = 3;
            this.lblName2.Text = "Difta";
            // 
            // lblName3
            // 
            this.lblName3.AutoSize = true;
            this.lblName3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName3.ForeColor = System.Drawing.Color.Black;
            this.lblName3.Location = new System.Drawing.Point(64, 585);
            this.lblName3.Name = "lblName3";
            this.lblName3.Size = new System.Drawing.Size(84, 36);
            this.lblName3.TabIndex = 5;
            this.lblName3.Text = "Daffa";
            // 
            // btnSend1
            // 
            this.btnSend1.Location = new System.Drawing.Point(824, 170);
            this.btnSend1.Name = "btnSend1";
            this.btnSend1.Size = new System.Drawing.Size(131, 152);
            this.btnSend1.TabIndex = 7;
            this.btnSend1.Text = "SEND!";
            this.btnSend1.UseVisualStyleBackColor = true;
            this.btnSend1.Click += new System.EventHandler(this.btnSend1_Click);
            this.btnSend1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSend1_MouseDown);
            this.btnSend1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSend1_MouseUp);
            // 
            // btnSend2
            // 
            this.btnSend2.Location = new System.Drawing.Point(824, 398);
            this.btnSend2.Name = "btnSend2";
            this.btnSend2.Size = new System.Drawing.Size(131, 152);
            this.btnSend2.TabIndex = 8;
            this.btnSend2.Text = "SEND!";
            this.btnSend2.UseVisualStyleBackColor = true;
            this.btnSend2.Click += new System.EventHandler(this.btnSend2_Click);
            this.btnSend2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSend1_MouseDown);
            this.btnSend2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSend1_MouseUp);
            // 
            // btnSend3
            // 
            this.btnSend3.Location = new System.Drawing.Point(824, 639);
            this.btnSend3.Name = "btnSend3";
            this.btnSend3.Size = new System.Drawing.Size(131, 152);
            this.btnSend3.TabIndex = 9;
            this.btnSend3.Text = "SEND!";
            this.btnSend3.UseVisualStyleBackColor = true;
            this.btnSend3.Click += new System.EventHandler(this.btnSend3_Click);
            this.btnSend3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSend1_MouseDown);
            this.btnSend3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnSend1_MouseUp);
            // 
            // txtBoxMessage3
            // 
            this.txtBoxMessage3.BackColor = System.Drawing.Color.Orange;
            this.txtBoxMessage3.BorderColor = System.Drawing.Color.Blue;
            this.txtBoxMessage3.BorderFocusColor = System.Drawing.Color.DarkViolet;
            this.txtBoxMessage3.BorderSize = 2;
            this.txtBoxMessage3.Location = new System.Drawing.Point(271, 639);
            this.txtBoxMessage3.Multiline = true;
            this.txtBoxMessage3.Name = "txtBoxMessage3";
            this.txtBoxMessage3.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxMessage3.PasswordChar = false;
            this.txtBoxMessage3.Size = new System.Drawing.Size(517, 166);
            this.txtBoxMessage3.TabIndex = 16;
            this.txtBoxMessage3.Texts = "";
            this.txtBoxMessage3.UnderlinedStyle = false;
            // 
            // txtBoxMessage2
            // 
            this.txtBoxMessage2.BackColor = System.Drawing.Color.Orange;
            this.txtBoxMessage2.BorderColor = System.Drawing.Color.Blue;
            this.txtBoxMessage2.BorderFocusColor = System.Drawing.Color.DarkViolet;
            this.txtBoxMessage2.BorderSize = 2;
            this.txtBoxMessage2.Location = new System.Drawing.Point(276, 398);
            this.txtBoxMessage2.Multiline = true;
            this.txtBoxMessage2.Name = "txtBoxMessage2";
            this.txtBoxMessage2.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxMessage2.PasswordChar = false;
            this.txtBoxMessage2.Size = new System.Drawing.Size(517, 166);
            this.txtBoxMessage2.TabIndex = 15;
            this.txtBoxMessage2.Texts = "";
            this.txtBoxMessage2.UnderlinedStyle = false;
            // 
            // txtBoxMessage1
            // 
            this.txtBoxMessage1.BackColor = System.Drawing.Color.Orange;
            this.txtBoxMessage1.BorderColor = System.Drawing.Color.Blue;
            this.txtBoxMessage1.BorderFocusColor = System.Drawing.Color.DarkViolet;
            this.txtBoxMessage1.BorderSize = 2;
            this.txtBoxMessage1.Location = new System.Drawing.Point(276, 165);
            this.txtBoxMessage1.Multiline = true;
            this.txtBoxMessage1.Name = "txtBoxMessage1";
            this.txtBoxMessage1.Padding = new System.Windows.Forms.Padding(7);
            this.txtBoxMessage1.PasswordChar = false;
            this.txtBoxMessage1.Size = new System.Drawing.Size(517, 166);
            this.txtBoxMessage1.TabIndex = 14;
            this.txtBoxMessage1.Texts = "";
            this.txtBoxMessage1.UnderlinedStyle = false;
            this.txtBoxMessage1.Load += new System.EventHandler(this.txtBoxMessage1_Load);
            // 
            // circularPictureBox2
            // 
            this.circularPictureBox2.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox2.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularPictureBox2.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularPictureBox2.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularPictureBox2.BorderSize = 2;
            this.circularPictureBox2.GradientAngle = 50F;
            this.circularPictureBox2.Image = global::DTETI_Room_Booker.Properties.Resources.difta;
            this.circularPictureBox2.Location = new System.Drawing.Point(70, 398);
            this.circularPictureBox2.Name = "circularPictureBox2";
            this.circularPictureBox2.Size = new System.Drawing.Size(166, 166);
            this.circularPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox2.TabIndex = 13;
            this.circularPictureBox2.TabStop = false;
            // 
            // circularPictureBox3
            // 
            this.circularPictureBox3.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox3.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularPictureBox3.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularPictureBox3.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularPictureBox3.BorderSize = 2;
            this.circularPictureBox3.GradientAngle = 50F;
            this.circularPictureBox3.Image = global::DTETI_Room_Booker.Properties.Resources.PP;
            this.circularPictureBox3.Location = new System.Drawing.Point(70, 639);
            this.circularPictureBox3.Name = "circularPictureBox3";
            this.circularPictureBox3.Size = new System.Drawing.Size(166, 166);
            this.circularPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox3.TabIndex = 12;
            this.circularPictureBox3.TabStop = false;
            // 
            // circularPictureBox1
            // 
            this.circularPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.circularPictureBox1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.circularPictureBox1.BorderColor2 = System.Drawing.Color.HotPink;
            this.circularPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.circularPictureBox1.BorderSize = 2;
            this.circularPictureBox1.GradientAngle = 50F;
            this.circularPictureBox1.Image = global::DTETI_Room_Booker.Properties.Resources.PP;
            this.circularPictureBox1.Location = new System.Drawing.Point(70, 165);
            this.circularPictureBox1.Name = "circularPictureBox1";
            this.circularPictureBox1.Size = new System.Drawing.Size(166, 166);
            this.circularPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPictureBox1.TabIndex = 10;
            this.circularPictureBox1.TabStop = false;
            // 
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 916);
            this.Controls.Add(this.txtBoxMessage3);
            this.Controls.Add(this.txtBoxMessage2);
            this.Controls.Add(this.txtBoxMessage1);
            this.Controls.Add(this.circularPictureBox2);
            this.Controls.Add(this.circularPictureBox3);
            this.Controls.Add(this.circularPictureBox1);
            this.Controls.Add(this.btnSend3);
            this.Controls.Add(this.btnSend2);
            this.Controls.Add(this.btnSend1);
            this.Controls.Add(this.lblName3);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblSendMessage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormContact";
            this.Text = "CONTACT";
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSendMessage;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Button btnSend3;
        private CircularPictureBox circularPictureBox1;
        private CircularPictureBox circularPictureBox3;
        private CircularPictureBox circularPictureBox2;
        private CustomTextBox txtBoxMessage1;
        private CustomTextBox txtBoxMessage2;
        private CustomTextBox txtBoxMessage3;
    }
}