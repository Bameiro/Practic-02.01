using System.Windows.Forms;

namespace F1
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.label5 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.continueBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(11, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Добро пожаловать!";
            // 
            // nameBox
            // 
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(186, 47);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(187, 20);
            this.nameBox.TabIndex = 6;
            // 
            // roleBox
            // 
            this.roleBox.Enabled = false;
            this.roleBox.Location = new System.Drawing.Point(186, 84);
            this.roleBox.Margin = new System.Windows.Forms.Padding(2);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(187, 20);
            this.roleBox.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 35);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // continueBtn
            // 
            this.continueBtn.BackColor = System.Drawing.Color.RosyBrown;
            this.continueBtn.Location = new System.Drawing.Point(224, 108);
            this.continueBtn.Margin = new System.Windows.Forms.Padding(2);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(112, 32);
            this.continueBtn.TabIndex = 10;
            this.continueBtn.Text = "Продолжить";
            this.continueBtn.UseVisualStyleBackColor = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 176);
            this.ControlBox = false;
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 215);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(400, 215);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label5;
        private PictureBox pictureBox1;
        public Button continueBtn;
        public TextBox nameBox;
        public TextBox roleBox;
    }
}