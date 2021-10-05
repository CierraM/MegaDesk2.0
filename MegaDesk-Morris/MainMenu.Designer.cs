
namespace MegaDesk_Morris
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.addQuoteBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.viewQuoteBtn = new System.Windows.Forms.Button();
            this.searchQuoteBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // addQuoteBtn
            // 
            this.addQuoteBtn.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuoteBtn.Location = new System.Drawing.Point(107, 70);
            this.addQuoteBtn.Name = "addQuoteBtn";
            this.addQuoteBtn.Size = new System.Drawing.Size(318, 92);
            this.addQuoteBtn.TabIndex = 0;
            this.addQuoteBtn.Text = "Add Quote";
            this.addQuoteBtn.UseVisualStyleBackColor = true;
            this.addQuoteBtn.Click += new System.EventHandler(this.addQuoteBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(107, 447);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(318, 92);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // viewQuoteBtn
            // 
            this.viewQuoteBtn.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuoteBtn.Location = new System.Drawing.Point(107, 185);
            this.viewQuoteBtn.Name = "viewQuoteBtn";
            this.viewQuoteBtn.Size = new System.Drawing.Size(318, 92);
            this.viewQuoteBtn.TabIndex = 2;
            this.viewQuoteBtn.Text = "View Quotes";
            this.viewQuoteBtn.UseVisualStyleBackColor = true;
            this.viewQuoteBtn.Click += new System.EventHandler(this.viewQuoteBtn_Click);
            // 
            // searchQuoteBtn
            // 
            this.searchQuoteBtn.Font = new System.Drawing.Font("Yu Gothic Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuoteBtn.Location = new System.Drawing.Point(107, 311);
            this.searchQuoteBtn.Name = "searchQuoteBtn";
            this.searchQuoteBtn.Size = new System.Drawing.Size(318, 92);
            this.searchQuoteBtn.TabIndex = 3;
            this.searchQuoteBtn.Text = "Search Quotes";
            this.searchQuoteBtn.UseVisualStyleBackColor = true;
            this.searchQuoteBtn.Click += new System.EventHandler(this.searchQuoteBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(639, 158);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 295);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1110, 614);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.searchQuoteBtn);
            this.Controls.Add(this.viewQuoteBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.addQuoteBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainMenu";
            this.Text = "Mega Desk Quote Manager";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addQuoteBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button viewQuoteBtn;
        private System.Windows.Forms.Button searchQuoteBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

