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
            this.f_box = new System.Windows.Forms.TextBox();
            this.u0_box = new System.Windows.Forms.TextBox();
            this.f0_box = new System.Windows.Forms.TextBox();
            this.f1_box = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.delay = new System.Windows.Forms.Label();
            this.delay_box = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.l_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nx_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nt_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_box)).BeginInit();
            this.SuspendLayout();
            // 
            // f_lable
            // 
            this.f_lable.AutoSize = true;
            this.f_lable.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_lable.Location = new System.Drawing.Point(13, 13);
            this.f_lable.Name = "f_lable";
            this.f_lable.Size = new System.Drawing.Size(75, 24);
            this.f_lable.TabIndex = 0;
            this.f_lable.Text = "f(x,t) = ";
            // 
            // u0
            // 
            this.u0.AutoSize = true;
            this.u0.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.u0.Location = new System.Drawing.Point(12, 46);
            this.u0.Name = "u0";
            this.u0.Size = new System.Drawing.Size(83, 24);
            this.u0.TabIndex = 1;
            this.u0.Text = "u(x,0) = ";
            // 
            // f0
            // 
            this.f0.AutoSize = true;
            this.f0.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f0.Location = new System.Drawing.Point(12, 81);
            this.f0.Name = "f0";
            this.f0.Size = new System.Drawing.Size(80, 24);
            this.f0.TabIndex = 2;
            this.f0.Text = "u(0,t) = ";
            // 
            // f1
            // 
            this.f1.AutoSize = true;
            this.f1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f1.Location = new System.Drawing.Point(13, 117);
            this.f1.Name = "f1";
            this.f1.Size = new System.Drawing.Size(74, 24);
            this.f1.TabIndex = 3;
            this.f1.Text = "u(l,t) = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "l = ";
            // 
            // l_box
            // 
            this.l_box.DecimalPlaces = 4;
            this.l_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_box.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.l_box.Location = new System.Drawing.Point(93, 154);
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
            this.l_box.Size = new System.Drawing.Size(100, 26);
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
            this.a.Location = new System.Drawing.Point(12, 192);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(44, 24);
            this.a.TabIndex = 7;
            this.a.Text = "α = ";
            // 
            // a_box
            // 
            this.a_box.DecimalPlaces = 4;
            this.a_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.a_box.Location = new System.Drawing.Point(93, 195);
            this.a_box.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.a_box.Name = "a_box";
            this.a_box.Size = new System.Drawing.Size(100, 26);
            this.a_box.TabIndex = 8;
            this.a_box.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dt.Location = new System.Drawing.Point(12, 230);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(50, 24);
            this.dt.TabIndex = 9;
            this.dt.Text = "dt = ";
            // 
            // dt_box
            // 
            this.dt_box.DecimalPlaces = 5;
            this.dt_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dt_box.Location = new System.Drawing.Point(93, 233);
            this.dt_box.Name = "dt_box";
            this.dt_box.Size = new System.Drawing.Size(100, 26);
            this.dt_box.TabIndex = 10;
            this.dt_box.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // Nx
            // 
            this.Nx.AutoSize = true;
            this.Nx.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nx.Location = new System.Drawing.Point(12, 266);
            this.Nx.Name = "Nx";
            this.Nx.Size = new System.Drawing.Size(57, 24);
            this.Nx.TabIndex = 11;
            this.Nx.Text = "Nx = ";
            // 
            // Nx_box
            // 
            this.Nx_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nx_box.Location = new System.Drawing.Point(93, 269);
            this.Nx_box.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Nx_box.Name = "Nx_box";
            this.Nx_box.Size = new System.Drawing.Size(100, 26);
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
            this.Nt.Location = new System.Drawing.Point(12, 300);
            this.Nt.Name = "Nt";
            this.Nt.Size = new System.Drawing.Size(54, 24);
            this.Nt.TabIndex = 13;
            this.Nt.Text = "Nt = ";
            // 
            // Nt_box
            // 
            this.Nt_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nt_box.Location = new System.Drawing.Point(93, 303);
            this.Nt_box.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Nt_box.Name = "Nt_box";
            this.Nt_box.Size = new System.Drawing.Size(100, 26);
            this.Nt_box.TabIndex = 14;
            this.Nt_box.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Calculate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.Location = new System.Drawing.Point(209, 266);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(192, 58);
            this.Calculate.TabIndex = 15;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // f_box
            // 
            this.f_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f_box.Location = new System.Drawing.Point(94, 13);
            this.f_box.Name = "f_box";
            this.f_box.Size = new System.Drawing.Size(100, 26);
            this.f_box.TabIndex = 0;
            this.f_box.Text = "t + x";
            // 
            // u0_box
            // 
            this.u0_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.u0_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.u0_box.Location = new System.Drawing.Point(94, 46);
            this.u0_box.Name = "u0_box";
            this.u0_box.Size = new System.Drawing.Size(100, 26);
            this.u0_box.TabIndex = 16;
            this.u0_box.Text = "sin(x)";
            // 
            // f0_box
            // 
            this.f0_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.f0_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f0_box.Location = new System.Drawing.Point(94, 81);
            this.f0_box.Name = "f0_box";
            this.f0_box.Size = new System.Drawing.Size(100, 26);
            this.f0_box.TabIndex = 17;
            this.f0_box.Text = "t";
            // 
            // f1_box
            // 
            this.f1_box.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.f1_box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.f1_box.Location = new System.Drawing.Point(94, 117);
            this.f1_box.Name = "f1_box";
            this.f1_box.Size = new System.Drawing.Size(100, 26);
            this.f1_box.TabIndex = 18;
            this.f1_box.Text = "t";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GridMethod.Properties.Resources._60770b4a18191f3a11d761589a9047cb;
            this.pictureBox1.Location = new System.Drawing.Point(209, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // delay
            // 
            this.delay.AutoSize = true;
            this.delay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delay.Location = new System.Drawing.Point(210, 229);
            this.delay.Name = "delay";
            this.delay.Size = new System.Drawing.Size(83, 24);
            this.delay.TabIndex = 20;
            this.delay.Text = "Delay = ";
            // 
            // delay_box
            // 
            this.delay_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delay_box.Location = new System.Drawing.Point(290, 227);
            this.delay_box.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.delay_box.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.delay_box.Name = "delay_box";
            this.delay_box.Size = new System.Drawing.Size(100, 26);
            this.delay_box.TabIndex = 21;
            this.delay_box.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // StartDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(413, 336);
            this.Controls.Add(this.delay_box);
            this.Controls.Add(this.delay);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.f1_box);
            this.Controls.Add(this.f0_box);
            this.Controls.Add(this.u0_box);
            this.Controls.Add(this.f_box);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delay_box)).EndInit();
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
        private System.Windows.Forms.TextBox f_box;
        private System.Windows.Forms.TextBox u0_box;
        private System.Windows.Forms.TextBox f0_box;
        private System.Windows.Forms.TextBox f1_box;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label delay;
        private System.Windows.Forms.NumericUpDown delay_box;
    }
}