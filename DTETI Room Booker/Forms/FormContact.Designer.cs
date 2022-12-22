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
            this.txtBoxMessage1 = new System.Windows.Forms.TextBox();
            this.txtBoxMessage2 = new System.Windows.Forms.TextBox();
            this.lblName2 = new System.Windows.Forms.Label();
            this.txtBoxMessage3 = new System.Windows.Forms.TextBox();
            this.lblName3 = new System.Windows.Forms.Label();
            this.btnSend1 = new System.Windows.Forms.Button();
            this.btnSend2 = new System.Windows.Forms.Button();
            this.btnSend3 = new System.Windows.Forms.Button();
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
            // txtBoxMessage1
            // 
            this.txtBoxMessage1.BackColor = System.Drawing.Color.Orange;
            this.txtBoxMessage1.Location = new System.Drawing.Point(70, 170);
            this.txtBoxMessage1.Multiline = true;
            this.txtBoxMessage1.Name = "txtBoxMessage1";
            this.txtBoxMessage1.Size = new System.Drawing.Size(723, 152);
            this.txtBoxMessage1.TabIndex = 2;
            // 
            // txtBoxMessage2
            // 
            this.txtBoxMessage2.BackColor = System.Drawing.Color.Orange;
            this.txtBoxMessage2.Location = new System.Drawing.Point(70, 398);
            this.txtBoxMessage2.Multiline = true;
            this.txtBoxMessage2.Name = "txtBoxMessage2";
            this.txtBoxMessage2.Size = new System.Drawing.Size(723, 152);
            this.txtBoxMessage2.TabIndex = 4;
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
            // txtBoxMessage3
            // 
            this.txtBoxMessage3.BackColor = System.Drawing.Color.Orange;
            this.txtBoxMessage3.Location = new System.Drawing.Point(70, 639);
            this.txtBoxMessage3.Multiline = true;
            this.txtBoxMessage3.Name = "txtBoxMessage3";
            this.txtBoxMessage3.Size = new System.Drawing.Size(723, 152);
            this.txtBoxMessage3.TabIndex = 6;
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
            // FormContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 916);
            this.Controls.Add(this.btnSend3);
            this.Controls.Add(this.btnSend2);
            this.Controls.Add(this.btnSend1);
            this.Controls.Add(this.txtBoxMessage3);
            this.Controls.Add(this.lblName3);
            this.Controls.Add(this.txtBoxMessage2);
            this.Controls.Add(this.lblName2);
            this.Controls.Add(this.txtBoxMessage1);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.lblSendMessage);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormContact";
            this.Text = "CONTACT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSendMessage;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.TextBox txtBoxMessage1;
        private System.Windows.Forms.TextBox txtBoxMessage2;
        private System.Windows.Forms.Label lblName2;
        private System.Windows.Forms.TextBox txtBoxMessage3;
        private System.Windows.Forms.Label lblName3;
        private System.Windows.Forms.Button btnSend1;
        private System.Windows.Forms.Button btnSend2;
        private System.Windows.Forms.Button btnSend3;
    }
}