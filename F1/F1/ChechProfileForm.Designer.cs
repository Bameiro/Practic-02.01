using System.Windows.Forms;

namespace F1
{
    partial class ChechProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChechProfileForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roleBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // roleBox
            // 
            this.roleBox.Enabled = false;
            this.roleBox.Location = new System.Drawing.Point(48, 99);
            this.roleBox.Margin = new System.Windows.Forms.Padding(2);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(131, 20);
            this.roleBox.TabIndex = 15;
            // 
            // nameBox
            // 
            this.nameBox.Enabled = false;
            this.nameBox.Location = new System.Drawing.Point(34, 65);
            this.nameBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(145, 20);
            this.nameBox.TabIndex = 13;
            // 
            // surnameBox
            // 
            this.surnameBox.Enabled = false;
            this.surnameBox.Location = new System.Drawing.Point(48, 33);
            this.surnameBox.Margin = new System.Windows.Forms.Padding(2);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(131, 20);
            this.surnameBox.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(193, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Your Profile";
            // 
            // IDBox
            // 
            this.IDBox.Enabled = false;
            this.IDBox.Location = new System.Drawing.Point(48, 134);
            this.IDBox.Margin = new System.Windows.Forms.Padding(2);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(131, 20);
            this.IDBox.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "FIO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "ID:";
            // 
            // ChechProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 161);
            this.ControlBox = false;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 200);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(326, 200);
            this.Name = "ChechProfileForm";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ChechProfileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox roleBox;
        private TextBox nameBox;
        private TextBox surnameBox;
        private Label label5;
        private TextBox IDBox;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label6;
    }
}