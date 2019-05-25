namespace GridMethod
{
    partial class StartDataForm
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
            this.f_lable = new System.Windows.Forms.Label();
            this.u0 = new System.Windows.Forms.Label();
            this.f0 = new System.Windows.Forms.Label();
            this.f1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.l_box = new System.Windows.Forms.NumericUpDown();
            this.a = new System.Windows.Forms.Label();
            this.a_box = new System.Windows.Forms.NumericUpDown();
            this.dt = new System.Windows.Forms.Label();
            this.dt_box = new System.Windows.Forms.NumericUpDown();
            this.Nx = new System.Windows.Forms.Label();
            this.Nx_box = new System.Windows.Forms.NumericUpDown();
            this.Nt = new System.Windows.Forms.Label();
            this.Nt_box = new System.Windows.Forms.NumericUpDown();
            this.Calculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.l_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nx_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nt_box)).BeginInit();
            this.SuspendLayout();
            // 
            // f_lable
            // 
            this.f_lable.AutoSize = true;
            this.f_lable.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_lable.Location = new System.Drawing.Point(13, 13);
            this.f_lable.Name = "f_lable";
            this.f_lable.Size = new System.Drawing.Size(104, 24);
            this.f_lable.TabIndex = 0;
            this.f_lable.Text = "f(x,t) = x+t";
            // 
            // u0
            // 
            this.u0.AutoSize = true;
            this.u0.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.u0.Location = new System.Drawing.Point(12, 46);
            this.u0.Name = "u0";
            this.u0.Size = new System.Drawing.Size(131, 24);
            this.u0.TabIndex = 1;
            this.u0.Text = "u(x,0) = sin(x)";
            // 
            // f0
            // 
            this.f0.AutoSize = true;
            this.f0.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f0.Location = new System.Drawing.Point(12, 81);
            this.f0.Name = "f0";
            this.f0.Size = new System.Drawing.Size(87, 24);
            this.f0.TabIndex = 2;
            this.f0.Text = "u(0,t) = t";
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f1.Location = new System.Drawing.Point(13, 117);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(86, 24);
            this.f1.TabIndex = 3;
            this.f1.Text = "u(l,t) = t ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "l = ";
            // 
            // l_box
            // 
            this.l_box.DecimalPlaces = 4;
            this.l_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.l_box.Location = new System.Drawing.Point(75, 150);
            this.l_box.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.l_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.l_box.Name = "l_box";
            this.l_box.Size = new System.Drawing.Size(80, 20);
            this.l_box.TabIndex = 6;
            this.l_box.Value = new decimal(new int[] {
            31415,
            0,
            0,
            262144});
            // 
            // a
            // 
            this.a.AutoSize = true;
            this.a.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a.Location = new System.Drawing.Point(13, 187);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(43, 24);
            this.a.TabIndex = 7;
            this.a.Text = "a = ";
            // 
            // a_box
            // 
            this.a_box.DecimalPlaces = 4;
            this.a_box.Location = new System.Drawing.Point(75, 191);
            this.a_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.a_box.Name = "a_box";
            this.a_box.Size = new System.Drawing.Size(80, 20);
            this.a_box.TabIndex = 8;
            this.a_box.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dt.Location = new System.Drawing.Point(13, 225);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(50, 24);
            this.dt.TabIndex = 9;
            this.dt.Text = "dt = ";
            // 
            // dt_box
            // 
            this.dt_box.DecimalPlaces = 5;
            this.dt_box.Location = new System.Drawing.Point(75, 229);
            this.dt_box.Name = "dt_box";
            this.dt_box.Size = new System.Drawing.Size(80, 20);
            this.dt_box.TabIndex = 10;
            this.dt_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // Nx
            // 
            this.Nx.AutoSize = true;
            this.Nx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nx.Location = new System.Drawing.Point(13, 261);
            this.Nx.Name = "Nx";
            this.Nx.Size = new System.Drawing.Size(57, 24);
            this.Nx.TabIndex = 11;
            this.Nx.Text = "Nx = ";
            // 
            // Nx_box
            // 
            this.Nx_box.Location = new System.Drawing.Point(75, 265);
            this.Nx_box.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Nx_box.Name = "Nx_box";
            this.Nx_box.Size = new System.Drawing.Size(80, 20);
            this.Nx_box.TabIndex = 12;
            this.Nx_box.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Nt
            // 
            this.Nt.AutoSize = true;
            this.Nt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nt.Location = new System.Drawing.Point(13, 295);
            this.Nt.Name = "Nt";
            this.Nt.Size = new System.Drawing.Size(54, 24);
            this.Nt.TabIndex = 13;
            this.Nt.Text = "Nt = ";
            // 
            // Nt_box
            // 
            this.Nt_box.Location = new System.Drawing.Point(75, 299);
            this.Nt_box.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Nt_box.Name = "Nt_box";
            this.Nt_box.Size = new System.Drawing.Size(80, 20);
            this.Nt_box.TabIndex = 14;
            this.Nt_box.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(16, 334);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 15;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // StartDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 366);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.Nt_box);
            this.Controls.Add(this.Nt);
            this.Controls.Add(this.Nx_box);
            this.Controls.Add(this.Nx);
            this.Controls.Add(this.dt_box);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.a_box);
            this.Controls.Add(this.a);
            this.Controls.Add(this.l_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.f1);
            this.Controls.Add(this.f0);
            this.Controls.Add(this.u0);
            this.Controls.Add(this.f_lable);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartDataForm";
            this.Text = "StartDataForm";
            ((System.ComponentModel.ISupportInitialize)(this.l_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nx_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nt_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label f_lable;
        private System.Windows.Forms.Label u0;
        private System.Windows.Forms.Label f0;
        private System.Windows.Forms.Label f1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown l_box;
        private System.Windows.Forms.Label a;
        private System.Windows.Forms.NumericUpDown a_box;
        private System.Windows.Forms.Label dt;
        private System.Windows.Forms.NumericUpDown dt_box;
        private System.Windows.Forms.Label Nx;
        private System.Windows.Forms.NumericUpDown Nx_box;
        private System.Windows.Forms.Label Nt;
        private System.Windows.Forms.NumericUpDown Nt_box;
        private System.Windows.Forms.Button Calculate;
    }
}