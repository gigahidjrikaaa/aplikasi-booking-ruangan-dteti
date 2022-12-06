namespace DTETI_Room_Booker.Forms
{
    partial class FormBook
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
            this.btnTombol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTombol
            // 
            this.btnTombol.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTombol.AutoSize = true;
            this.btnTombol.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTombol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTombol.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTombol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTombol.Location = new System.Drawing.Point(281, 186);
            this.btnTombol.Margin = new System.Windows.Forms.Padding(0);
            this.btnTombol.Name = "btnTombol";
            this.btnTombol.Size = new System.Drawing.Size(164, 56);
            this.btnTombol.TabIndex = 0;
            this.btnTombol.Text = "Tombol";
            this.btnTombol.UseVisualStyleBackColor = true;
            this.btnTombol.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTombol);
            this.Name = "FormBook";
            this.Text = "BOOK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTombol;
    }
}