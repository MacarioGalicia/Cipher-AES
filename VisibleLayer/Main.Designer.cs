
namespace VisibleLayer
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCipher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDecipher = new System.Windows.Forms.Button();
            this.txtClearMessageCipher = new System.Windows.Forms.TextBox();
            this.txtCipherMessageCipher = new System.Windows.Forms.TextBox();
            this.btnSetKey = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtClearMessageDecipher = new System.Windows.Forms.TextBox();
            this.txtCipherMessageDecipher = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNumCharacteres = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbShowImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cifrado AES";
            // 
            // btnCipher
            // 
            this.btnCipher.Location = new System.Drawing.Point(254, 305);
            this.btnCipher.Name = "btnCipher";
            this.btnCipher.Size = new System.Drawing.Size(100, 32);
            this.btnCipher.TabIndex = 1;
            this.btnCipher.Text = "Cifrado";
            this.btnCipher.UseVisualStyleBackColor = true;
            this.btnCipher.Click += new System.EventHandler(this.btnCipher_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mensaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mensaje cifrado:";
            // 
            // btnDecipher
            // 
            this.btnDecipher.Location = new System.Drawing.Point(254, 563);
            this.btnDecipher.Name = "btnDecipher";
            this.btnDecipher.Size = new System.Drawing.Size(100, 32);
            this.btnDecipher.TabIndex = 11;
            this.btnDecipher.Text = "Descifrado";
            this.btnDecipher.UseVisualStyleBackColor = true;
            this.btnDecipher.Click += new System.EventHandler(this.btnDecipher_Click);
            // 
            // txtClearMessageCipher
            // 
            this.txtClearMessageCipher.Location = new System.Drawing.Point(26, 120);
            this.txtClearMessageCipher.Multiline = true;
            this.txtClearMessageCipher.Name = "txtClearMessageCipher";
            this.txtClearMessageCipher.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtClearMessageCipher.Size = new System.Drawing.Size(328, 179);
            this.txtClearMessageCipher.TabIndex = 15;
            // 
            // txtCipherMessageCipher
            // 
            this.txtCipherMessageCipher.Location = new System.Drawing.Point(371, 120);
            this.txtCipherMessageCipher.Multiline = true;
            this.txtCipherMessageCipher.Name = "txtCipherMessageCipher";
            this.txtCipherMessageCipher.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCipherMessageCipher.Size = new System.Drawing.Size(328, 179);
            this.txtCipherMessageCipher.TabIndex = 16;
            // 
            // btnSetKey
            // 
            this.btnSetKey.Location = new System.Drawing.Point(598, 58);
            this.btnSetKey.Name = "btnSetKey";
            this.btnSetKey.Size = new System.Drawing.Size(100, 32);
            this.btnSetKey.TabIndex = 17;
            this.btnSetKey.Text = "Cargar llave";
            this.btnSetKey.UseVisualStyleBackColor = true;
            this.btnSetKey.Click += new System.EventHandler(this.btnSetKey_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(26, 61);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(566, 26);
            this.txtKey.TabIndex = 18;
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // txtClearMessageDecipher
            // 
            this.txtClearMessageDecipher.Location = new System.Drawing.Point(371, 378);
            this.txtClearMessageDecipher.Multiline = true;
            this.txtClearMessageDecipher.Name = "txtClearMessageDecipher";
            this.txtClearMessageDecipher.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtClearMessageDecipher.Size = new System.Drawing.Size(328, 179);
            this.txtClearMessageDecipher.TabIndex = 20;
            // 
            // txtCipherMessageDecipher
            // 
            this.txtCipherMessageDecipher.Location = new System.Drawing.Point(26, 378);
            this.txtCipherMessageDecipher.Multiline = true;
            this.txtCipherMessageDecipher.Name = "txtCipherMessageDecipher";
            this.txtCipherMessageDecipher.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtCipherMessageDecipher.Size = new System.Drawing.Size(328, 179);
            this.txtCipherMessageDecipher.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Llave AES:";
            // 
            // lblNumCharacteres
            // 
            this.lblNumCharacteres.AutoSize = true;
            this.lblNumCharacteres.Location = new System.Drawing.Point(462, 90);
            this.lblNumCharacteres.Name = "lblNumCharacteres";
            this.lblNumCharacteres.Size = new System.Drawing.Size(104, 20);
            this.lblNumCharacteres.TabIndex = 22;
            this.lblNumCharacteres.Text = "Caracteres: 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(621, 569);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Cipher v1.1";
            // 
            // pbShowImage
            // 
            this.pbShowImage.BackColor = System.Drawing.Color.White;
            this.pbShowImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowImage.Image = ((System.Drawing.Image)(resources.GetObject("pbShowImage.Image")));
            this.pbShowImage.Location = new System.Drawing.Point(569, 63);
            this.pbShowImage.Name = "pbShowImage";
            this.pbShowImage.Size = new System.Drawing.Size(21, 20);
            this.pbShowImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowImage.TabIndex = 24;
            this.pbShowImage.TabStop = false;
            this.pbShowImage.Click += new System.EventHandler(this.pbShowImage_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 605);
            this.Controls.Add(this.pbShowImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumCharacteres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClearMessageDecipher);
            this.Controls.Add(this.txtCipherMessageDecipher);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnSetKey);
            this.Controls.Add(this.txtCipherMessageCipher);
            this.Controls.Add(this.txtClearMessageCipher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDecipher);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCipher);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbShowImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCipher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDecipher;
        private System.Windows.Forms.TextBox txtClearMessageCipher;
        private System.Windows.Forms.TextBox txtCipherMessageCipher;
        private System.Windows.Forms.Button btnSetKey;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtClearMessageDecipher;
        private System.Windows.Forms.TextBox txtCipherMessageDecipher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNumCharacteres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbShowImage;
    }
}