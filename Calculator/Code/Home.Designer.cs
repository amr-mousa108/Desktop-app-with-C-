namespace Calc
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.num1 = new System.Windows.Forms.TextBox();
            this.ops = new System.Windows.Forms.TextBox();
            this.num2 = new System.Windows.Forms.TextBox();
            this.Lblresult = new System.Windows.Forms.Label();
            this.results = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num1
            // 
            this.num1.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(373, 191);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(128, 33);
            this.num1.TabIndex = 0;
            // 
            // ops
            // 
            this.ops.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ops.Location = new System.Drawing.Point(373, 236);
            this.ops.Name = "ops";
            this.ops.Size = new System.Drawing.Size(128, 33);
            this.ops.TabIndex = 1;
            // 
            // num2
            // 
            this.num2.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(373, 280);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(128, 33);
            this.num2.TabIndex = 2;
            // 
            // Lblresult
            // 
            this.Lblresult.AutoSize = true;
            this.Lblresult.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblresult.Location = new System.Drawing.Point(316, 106);
            this.Lblresult.Name = "Lblresult";
            this.Lblresult.Size = new System.Drawing.Size(20, 25);
            this.Lblresult.TabIndex = 3;
            this.Lblresult.Text = "0";
            this.Lblresult.Click += new System.EventHandler(this.Lblresult_Click);
            // 
            // results
            // 
            this.results.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.results.Location = new System.Drawing.Point(142, 191);
            this.results.Name = "results";
            this.results.Size = new System.Drawing.Size(152, 129);
            this.results.TabIndex = 4;
            this.results.Text = "اجراء العملية";
            this.results.UseVisualStyleBackColor = true;
            this.results.Click += new System.EventHandler(this.result_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(552, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "الرقم الأول";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(552, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "العملية";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(552, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "الرقم الثاني";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sakkal Majalla", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "النتيجة";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.results);
            this.Controls.Add(this.Lblresult);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.ops);
            this.Controls.Add(this.num1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Calculator";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox num1;
        private System.Windows.Forms.TextBox ops;
        private System.Windows.Forms.TextBox num2;
        private System.Windows.Forms.Label Lblresult;
        private System.Windows.Forms.Button results;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}