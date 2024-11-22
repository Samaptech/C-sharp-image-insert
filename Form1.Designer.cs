
namespace Insert_image_in_C_Sharp
{
    partial class Form1
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
            this.productImage = new System.Windows.Forms.PictureBox();
            this.insertBtn = new System.Windows.Forms.Button();
            this.imgBtn = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.Label();
            this.pathName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).BeginInit();
            this.SuspendLayout();
            // 
            // productImage
            // 
            this.productImage.Location = new System.Drawing.Point(476, 85);
            this.productImage.Name = "productImage";
            this.productImage.Size = new System.Drawing.Size(441, 426);
            this.productImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.productImage.TabIndex = 0;
            this.productImage.TabStop = false;
            // 
            // insertBtn
            // 
            this.insertBtn.Location = new System.Drawing.Point(186, 298);
            this.insertBtn.Name = "insertBtn";
            this.insertBtn.Size = new System.Drawing.Size(173, 88);
            this.insertBtn.TabIndex = 1;
            this.insertBtn.Text = "Insert Image";
            this.insertBtn.UseVisualStyleBackColor = true;
            this.insertBtn.Click += new System.EventHandler(this.insertBtn_Click);
            // 
            // imgBtn
            // 
            this.imgBtn.Location = new System.Drawing.Point(186, 159);
            this.imgBtn.Name = "imgBtn";
            this.imgBtn.Size = new System.Drawing.Size(173, 88);
            this.imgBtn.TabIndex = 1;
            this.imgBtn.Text = "Select Image";
            this.imgBtn.UseVisualStyleBackColor = true;
            this.imgBtn.Click += new System.EventHandler(this.imgBtn_Click);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(72, 432);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(0, 20);
            this.fileName.TabIndex = 2;
            // 
            // pathName
            // 
            this.pathName.AutoSize = true;
            this.pathName.Location = new System.Drawing.Point(72, 475);
            this.pathName.Name = "pathName";
            this.pathName.Size = new System.Drawing.Size(0, 20);
            this.pathName.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 568);
            this.Controls.Add(this.pathName);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.imgBtn);
            this.Controls.Add(this.insertBtn);
            this.Controls.Add(this.productImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.productImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productImage;
        private System.Windows.Forms.Button insertBtn;
        private System.Windows.Forms.Button imgBtn;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label pathName;
    }
}

