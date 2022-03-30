namespace Pharmachy
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
            this.MedicinePanel = new Pharmachy.Components.SPanel();
            this.customButton1 = new Pharmachy.Components.CustomButton();
            this.sPanel2 = new Pharmachy.Components.SPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sPanel1 = new Pharmachy.Components.SPanel();
            this.Patiencebutton = new Pharmachy.Components.CustomButton();
            this.prescriptionbutton = new Pharmachy.Components.CustomButton();
            this.customButton3 = new Pharmachy.Components.CustomButton();
            this.Staffbutton = new Pharmachy.Components.CustomButton();
            this.MedicineButton = new Pharmachy.Components.CustomButton();
            this.MedicinePanel.SuspendLayout();
            this.sPanel2.SuspendLayout();
            this.sPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MedicinePanel
            // 
            this.MedicinePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.MedicinePanel.BorderColor = System.Drawing.Color.White;
            this.MedicinePanel.Controls.Add(this.customButton1);
            this.MedicinePanel.Edge = 20;
            this.MedicinePanel.Location = new System.Drawing.Point(213, 82);
            this.MedicinePanel.Name = "MedicinePanel";
            this.MedicinePanel.Size = new System.Drawing.Size(806, 532);
            this.MedicinePanel.TabIndex = 11;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.customButton1.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.customButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton1.BorderRadius = 25;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customButton1.ForeColor = System.Drawing.Color.Transparent;
            this.customButton1.Image = ((System.Drawing.Image)(resources.GetObject("customButton1.Image")));
            this.customButton1.Location = new System.Drawing.Point(556, 410);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(198, 65);
            this.customButton1.TabIndex = 10;
            this.customButton1.Text = "Patience";
            this.customButton1.TextColor = System.Drawing.Color.Transparent;
            this.customButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // sPanel2
            // 
            this.sPanel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sPanel2.BorderColor = System.Drawing.Color.White;
            this.sPanel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sPanel2.Controls.Add(this.label1);
            this.sPanel2.Controls.Add(this.label3);
            this.sPanel2.Controls.Add(this.label2);
            this.sPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.sPanel2.Edge = 20;
            this.sPanel2.Location = new System.Drawing.Point(0, 0);
            this.sPanel2.Name = "sPanel2";
            this.sPanel2.Size = new System.Drawing.Size(1019, 84);
            this.sPanel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(402, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pharmachy";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(930, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 64);
            this.label3.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(29, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 64);
            this.label2.TabIndex = 11;
            // 
            // sPanel1
            // 
            this.sPanel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.sPanel1.BorderColor = System.Drawing.Color.White;
            this.sPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sPanel1.Controls.Add(this.Patiencebutton);
            this.sPanel1.Controls.Add(this.prescriptionbutton);
            this.sPanel1.Controls.Add(this.customButton3);
            this.sPanel1.Controls.Add(this.Staffbutton);
            this.sPanel1.Controls.Add(this.MedicineButton);
            this.sPanel1.Edge = 20;
            this.sPanel1.Location = new System.Drawing.Point(2, 78);
            this.sPanel1.Name = "sPanel1";
            this.sPanel1.Size = new System.Drawing.Size(218, 572);
            this.sPanel1.TabIndex = 9;
            // 
            // Patiencebutton
            // 
            this.Patiencebutton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Patiencebutton.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.Patiencebutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Patiencebutton.BorderRadius = 25;
            this.Patiencebutton.BorderSize = 0;
            this.Patiencebutton.FlatAppearance.BorderSize = 0;
            this.Patiencebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Patiencebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Patiencebutton.ForeColor = System.Drawing.Color.Transparent;
            this.Patiencebutton.Image = ((System.Drawing.Image)(resources.GetObject("Patiencebutton.Image")));
            this.Patiencebutton.Location = new System.Drawing.Point(5, 209);
            this.Patiencebutton.Name = "Patiencebutton";
            this.Patiencebutton.Size = new System.Drawing.Size(198, 65);
            this.Patiencebutton.TabIndex = 6;
            this.Patiencebutton.Text = "İnformation";
            this.Patiencebutton.TextColor = System.Drawing.Color.Transparent;
            this.Patiencebutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Patiencebutton.UseVisualStyleBackColor = false;
            this.Patiencebutton.Click += new System.EventHandler(this.Patiencebutton_Click);
            // 
            // prescriptionbutton
            // 
            this.prescriptionbutton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.prescriptionbutton.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.prescriptionbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.prescriptionbutton.BorderRadius = 25;
            this.prescriptionbutton.BorderSize = 0;
            this.prescriptionbutton.FlatAppearance.BorderSize = 0;
            this.prescriptionbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prescriptionbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.prescriptionbutton.ForeColor = System.Drawing.Color.Transparent;
            this.prescriptionbutton.Image = ((System.Drawing.Image)(resources.GetObject("prescriptionbutton.Image")));
            this.prescriptionbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prescriptionbutton.Location = new System.Drawing.Point(5, 131);
            this.prescriptionbutton.Name = "prescriptionbutton";
            this.prescriptionbutton.Size = new System.Drawing.Size(195, 63);
            this.prescriptionbutton.TabIndex = 9;
            this.prescriptionbutton.Text = "Prescription";
            this.prescriptionbutton.TextColor = System.Drawing.Color.Transparent;
            this.prescriptionbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.prescriptionbutton.UseVisualStyleBackColor = false;
            this.prescriptionbutton.Click += new System.EventHandler(this.prescriptionbutton_Click);
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.customButton3.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.customButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.customButton3.BorderRadius = 25;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customButton3.ForeColor = System.Drawing.Color.Transparent;
            this.customButton3.Location = new System.Drawing.Point(5, 458);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(198, 54);
            this.customButton3.TabIndex = 7;
            this.customButton3.Text = "customButton3";
            this.customButton3.TextColor = System.Drawing.Color.Transparent;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // Staffbutton
            // 
            this.Staffbutton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Staffbutton.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.Staffbutton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Staffbutton.BorderRadius = 25;
            this.Staffbutton.BorderSize = 0;
            this.Staffbutton.FlatAppearance.BorderSize = 0;
            this.Staffbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Staffbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Staffbutton.ForeColor = System.Drawing.Color.Transparent;
            this.Staffbutton.Image = ((System.Drawing.Image)(resources.GetObject("Staffbutton.Image")));
            this.Staffbutton.Location = new System.Drawing.Point(3, 289);
            this.Staffbutton.Name = "Staffbutton";
            this.Staffbutton.Size = new System.Drawing.Size(198, 61);
            this.Staffbutton.TabIndex = 8;
            this.Staffbutton.Text = "Pharmacists";
            this.Staffbutton.TextColor = System.Drawing.Color.Transparent;
            this.Staffbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Staffbutton.UseVisualStyleBackColor = false;
            this.Staffbutton.Click += new System.EventHandler(this.Staffbutton_Click);
            // 
            // MedicineButton
            // 
            this.MedicineButton.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.MedicineButton.BackgroundColor = System.Drawing.Color.DarkSeaGreen;
            this.MedicineButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.MedicineButton.BorderRadius = 25;
            this.MedicineButton.BorderSize = 0;
            this.MedicineButton.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.MedicineButton.FlatAppearance.BorderSize = 0;
            this.MedicineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MedicineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MedicineButton.ForeColor = System.Drawing.Color.Transparent;
            this.MedicineButton.Image = ((System.Drawing.Image)(resources.GetObject("MedicineButton.Image")));
            this.MedicineButton.Location = new System.Drawing.Point(5, 52);
            this.MedicineButton.Name = "MedicineButton";
            this.MedicineButton.Size = new System.Drawing.Size(198, 61);
            this.MedicineButton.TabIndex = 5;
            this.MedicineButton.Text = "Medicine";
            this.MedicineButton.TextColor = System.Drawing.Color.Transparent;
            this.MedicineButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MedicineButton.UseVisualStyleBackColor = false;
            this.MedicineButton.Click += new System.EventHandler(this.MedicineButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 599);
            this.Controls.Add(this.MedicinePanel);
            this.Controls.Add(this.sPanel2);
            this.Controls.Add(this.sPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MedicinePanel.ResumeLayout(false);
            this.sPanel2.ResumeLayout(false);
            this.sPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Components.CustomButton prescriptionbutton;
        private Components.CustomButton Staffbutton;
        private Components.CustomButton customButton3;
        private Components.CustomButton Patiencebutton;
        private Components.CustomButton MedicineButton;
        private Components.SPanel sPanel1;
        private Components.SPanel sPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Components.SPanel MedicinePanel;
        private Components.CustomButton customButton1;
    }
}

