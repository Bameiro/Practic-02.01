using System.Windows.Forms;

namespace F1
{
    partial class AddRequestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRequestForm));
            this.problemBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.modelList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // problemBox
            // 
            this.problemBox.Location = new System.Drawing.Point(130, 23);
            this.problemBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.problemBox.Multiline = true;
            this.problemBox.Name = "problemBox";
            this.problemBox.Size = new System.Drawing.Size(236, 65);
            this.problemBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Model:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(127, 8);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Problem description:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(11, 102);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(355, 25);
            this.button1.TabIndex = 15;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // modelList
            // 
            this.modelList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modelList.FormattingEnabled = true;
            this.modelList.Location = new System.Drawing.Point(4, 23);
            this.modelList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.modelList.Name = "modelList";
            this.modelList.Size = new System.Drawing.Size(114, 21);
            this.modelList.TabIndex = 17;
            // 
            // AddRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 137);
            this.Controls.Add(this.modelList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.problemBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(393, 176);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(393, 176);
            this.Name = "AddRequestForm";
            this.Text = "NewRequest";
            this.Load += new System.EventHandler(this.AddRequestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox problemBox;
        private Label label6;
        private Label label7;
        private Button button1;
        private ComboBox modelList;
    }
}