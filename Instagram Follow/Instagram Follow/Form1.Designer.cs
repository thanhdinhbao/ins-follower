
namespace Instagram_Follow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnFollow1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFollow2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnLike1 = new System.Windows.Forms.Button();
            this.btnLike2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxUser = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnFollow1
            // 
            this.btnFollow1.Location = new System.Drawing.Point(22, 80);
            this.btnFollow1.Name = "btnFollow1";
            this.btnFollow1.Size = new System.Drawing.Size(161, 62);
            this.btnFollow1.TabIndex = 0;
            this.btnFollow1.Text = "Mr.Insta";
            this.btnFollow1.UseVisualStyleBackColor = true;
            this.btnFollow1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Instagram Auto v1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "by Dinh Bao Thanh";
            // 
            // btnFollow2
            // 
            this.btnFollow2.Location = new System.Drawing.Point(308, 80);
            this.btnFollow2.Name = "btnFollow2";
            this.btnFollow2.Size = new System.Drawing.Size(161, 62);
            this.btnFollow2.TabIndex = 3;
            this.btnFollow2.Text = "Turbo Media";
            this.btnFollow2.UseVisualStyleBackColor = true;
            this.btnFollow2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxUser);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnFollow1);
            this.groupBox1.Controls.Add(this.btnFollow2);
            this.groupBox1.Location = new System.Drawing.Point(15, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 158);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Follow";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtURL);
            this.groupBox2.Controls.Add(this.btnLike1);
            this.groupBox2.Controls.Add(this.btnLike2);
            this.groupBox2.Location = new System.Drawing.Point(15, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(491, 173);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Like post";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "URL Post:";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(82, 37);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(387, 20);
            this.txtURL.TabIndex = 4;
            // 
            // btnLike1
            // 
            this.btnLike1.Location = new System.Drawing.Point(22, 79);
            this.btnLike1.Name = "btnLike1";
            this.btnLike1.Size = new System.Drawing.Size(161, 62);
            this.btnLike1.TabIndex = 0;
            this.btnLike1.Text = "Mr.Insta";
            this.btnLike1.UseVisualStyleBackColor = true;
            this.btnLike1.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLike2
            // 
            this.btnLike2.Location = new System.Drawing.Point(308, 79);
            this.btnLike2.Name = "btnLike2";
            this.btnLike2.Size = new System.Drawing.Size(161, 62);
            this.btnLike2.TabIndex = 3;
            this.btnLike2.Text = "Turbo Media";
            this.btnLike2.UseVisualStyleBackColor = true;
            this.btnLike2.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "User:";
            // 
            // cbxUser
            // 
            this.cbxUser.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbxUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbxUser.FormattingEnabled = true;
            this.cbxUser.Items.AddRange(new object[] {
            "baothanhdangbanhoc",
            "_k20.ppa_"});
            this.cbxUser.Location = new System.Drawing.Point(82, 34);
            this.cbxUser.Name = "cbxUser";
            this.cbxUser.Size = new System.Drawing.Size(387, 21);
            this.cbxUser.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Instagram Auto v1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFollow1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFollow2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLike1;
        private System.Windows.Forms.Button btnLike2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.ComboBox cbxUser;
        private System.Windows.Forms.Label label4;
    }
}

