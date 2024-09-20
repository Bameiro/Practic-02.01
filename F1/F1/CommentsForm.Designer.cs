using System.Windows.Forms;

namespace F1
{
    partial class CommentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentsForm));
            this.backBtn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.backBtn.Location = new System.Drawing.Point(318, 6);
            this.backBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(70, 23);
            this.backBtn.TabIndex = 3;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OrangeRed;
            this.button2.Location = new System.Drawing.Point(101, 275);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 36);
            this.button2.TabIndex = 10;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.addBtn.Location = new System.Drawing.Point(11, 275);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(86, 36);
            this.addBtn.TabIndex = 9;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 35);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(380, 236);
            this.dataGridView1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total: 0";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(8, 11);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(199, 20);
            this.searchBox.TabIndex = 12;
            // 
            // updateBtn
            // 
            this.updateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("updateBtn.BackgroundImage")));
            this.updateBtn.Location = new System.Drawing.Point(258, 2);
            this.updateBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(31, 31);
            this.updateBtn.TabIndex = 14;
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // CommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 314);
            this.ControlBox = false;
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CommentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comments";
            this.Load += new System.EventHandler(this.CommentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button backBtn;
        private Button button2;
        private Button addBtn;
        private DataGridView dataGridView1;
        private Label label1;
        private TextBox searchBox;
        private Button updateBtn;
    }
}