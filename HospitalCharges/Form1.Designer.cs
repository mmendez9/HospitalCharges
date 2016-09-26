namespace HospitalCharges
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
            this.days = new System.Windows.Forms.Label();
            this.medic = new System.Windows.Forms.Label();
            this.surgic = new System.Windows.Forms.Label();
            this.labf = new System.Windows.Forms.Label();
            this.phyrehab = new System.Windows.Forms.Label();
            this.numDays = new System.Windows.Forms.TextBox();
            this.med = new System.Windows.Forms.TextBox();
            this.surgch = new System.Windows.Forms.TextBox();
            this.labch = new System.Windows.Forms.TextBox();
            this.lbtotal = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.TextBox();
            this.phychar = new System.Windows.Forms.TextBox();
            this.cal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // days
            // 
            this.days.AutoSize = true;
            this.days.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days.Location = new System.Drawing.Point(25, 32);
            this.days.Name = "days";
            this.days.Size = new System.Drawing.Size(42, 16);
            this.days.TabIndex = 0;
            this.days.Text = "Days ";
            // 
            // medic
            // 
            this.medic.AutoSize = true;
            this.medic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medic.Location = new System.Drawing.Point(25, 58);
            this.medic.Name = "medic";
            this.medic.Size = new System.Drawing.Size(71, 16);
            this.medic.TabIndex = 1;
            this.medic.Text = "Medication";
            // 
            // surgic
            // 
            this.surgic.AutoSize = true;
            this.surgic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surgic.Location = new System.Drawing.Point(25, 84);
            this.surgic.Name = "surgic";
            this.surgic.Size = new System.Drawing.Size(55, 16);
            this.surgic.TabIndex = 2;
            this.surgic.Text = "Surgical";
            // 
            // labf
            // 
            this.labf.AutoSize = true;
            this.labf.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labf.Location = new System.Drawing.Point(25, 110);
            this.labf.Name = "labf";
            this.labf.Size = new System.Drawing.Size(29, 16);
            this.labf.TabIndex = 3;
            this.labf.Text = "Lab";
            // 
            // phyrehab
            // 
            this.phyrehab.AutoSize = true;
            this.phyrehab.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phyrehab.Location = new System.Drawing.Point(25, 136);
            this.phyrehab.Name = "phyrehab";
            this.phyrehab.Size = new System.Drawing.Size(140, 16);
            this.phyrehab.TabIndex = 4;
            this.phyrehab.Text = "Physical Rehabilitation";
            // 
            // numDays
            // 
            this.numDays.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDays.Location = new System.Drawing.Point(190, 26);
            this.numDays.Name = "numDays";
            this.numDays.Size = new System.Drawing.Size(100, 22);
            this.numDays.TabIndex = 6;
            this.numDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // med
            // 
            this.med.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.med.Location = new System.Drawing.Point(190, 52);
            this.med.Name = "med";
            this.med.Size = new System.Drawing.Size(100, 22);
            this.med.TabIndex = 7;
            this.med.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // surgch
            // 
            this.surgch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surgch.Location = new System.Drawing.Point(190, 78);
            this.surgch.Name = "surgch";
            this.surgch.Size = new System.Drawing.Size(100, 22);
            this.surgch.TabIndex = 8;
            this.surgch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labch
            // 
            this.labch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labch.Location = new System.Drawing.Point(190, 104);
            this.labch.Name = "labch";
            this.labch.Size = new System.Drawing.Size(100, 22);
            this.labch.TabIndex = 9;
            this.labch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbtotal
            // 
            this.lbtotal.AutoSize = true;
            this.lbtotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtotal.Location = new System.Drawing.Point(25, 185);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(43, 18);
            this.lbtotal.TabIndex = 10;
            this.lbtotal.Text = "Total";
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(190, 183);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(100, 22);
            this.total.TabIndex = 11;
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // phychar
            // 
            this.phychar.Location = new System.Drawing.Point(190, 136);
            this.phychar.Name = "phychar";
            this.phychar.Size = new System.Drawing.Size(100, 20);
            this.phychar.TabIndex = 12;
            this.phychar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(125, 226);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 23);
            this.cal.TabIndex = 13;
            this.cal.Text = "Claculate";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.phychar);
            this.Controls.Add(this.total);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.labch);
            this.Controls.Add(this.surgch);
            this.Controls.Add(this.med);
            this.Controls.Add(this.numDays);
            this.Controls.Add(this.phyrehab);
            this.Controls.Add(this.labf);
            this.Controls.Add(this.surgic);
            this.Controls.Add(this.medic);
            this.Controls.Add(this.days);
            this.Name = "Form1";
            this.Text = "Hospital Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label days;
        private System.Windows.Forms.Label medic;
        private System.Windows.Forms.Label surgic;
        private System.Windows.Forms.Label labf;
        private System.Windows.Forms.Label phyrehab;
        private System.Windows.Forms.TextBox numDays;
        private System.Windows.Forms.TextBox med;
        private System.Windows.Forms.TextBox surgch;
        private System.Windows.Forms.TextBox labch;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox phychar;
        private System.Windows.Forms.Button cal;
    }
}

