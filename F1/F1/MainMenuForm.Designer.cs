using System.Windows.Forms;

namespace F1
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.roleBox = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.menuBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searcBox = new System.Windows.Forms.TextBox();
            this.profileBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // roleBox
            // 
            this.roleBox.AutoSize = true;
            this.roleBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.roleBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.roleBox.Location = new System.Drawing.Point(523, 285);
            this.roleBox.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(33, 15);
            this.roleBox.TabIndex = 0;
            this.roleBox.Text = "Type";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.logoutBtn.Location = new System.Drawing.Point(526, 0);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(2);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(70, 21);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Exit";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(582, 208);
            this.dataGridView1.TabIndex = 4;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.addBtn.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(9, 281);
            this.addBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(95, 23);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.delBtn.Location = new System.Drawing.Point(109, 281);
            this.delBtn.Margin = new System.Windows.Forms.Padding(2);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(94, 23);
            this.delBtn.TabIndex = 6;
            this.delBtn.Text = "Delete";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // menuBtn
            // 
            this.menuBtn.Location = new System.Drawing.Point(9, 0);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(2);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(152, 19);
            this.menuBtn.TabIndex = 7;
            this.menuBtn.UseVisualStyleBackColor = true;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(423, 25);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 33);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Total: 0";
            // 
            // searcBox
            // 
            this.searcBox.Location = new System.Drawing.Point(9, 32);
            this.searcBox.Margin = new System.Windows.Forms.Padding(2);
            this.searcBox.Name = "searcBox";
            this.searcBox.Size = new System.Drawing.Size(410, 20);
            this.searcBox.TabIndex = 10;
            // 
            // profileBtn
            // 
            this.profileBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.profileBtn.Location = new System.Drawing.Point(442, 0);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(2);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(70, 21);
            this.profileBtn.TabIndex = 12;
            this.profileBtn.Text = "Profile";
            this.profileBtn.UseVisualStyleBackColor = false;
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 315);
            this.ControlBox = false;
            this.Controls.Add(this.profileBtn);
            this.Controls.Add(this.searcBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.logoutBtn);
            this.Controls.Add(this.roleBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label roleBox;
        private Button logoutBtn;
        private DataGridView dataGridView1;
        private Button addBtn;
        private Button delBtn;
        private Button menuBtn;
        private Button button1;
        private Label label1;
        private TextBox searcBox;
        private Button profileBtn;
    }
}