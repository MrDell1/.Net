namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.constBox = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.varBox = new System.Windows.Forms.ListBox();
            this.speed = new System.Windows.Forms.TrackBar();
            this.deepnes = new System.Windows.Forms.TrackBar();
            this.altitude = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.accelerate = new System.Windows.Forms.GroupBox();
            this.deep = new System.Windows.Forms.GroupBox();
            this.height = new System.Windows.Forms.GroupBox();
            this.SpeedValue = new System.Windows.Forms.Label();
            this.DeepValue = new System.Windows.Forms.Label();
            this.AltitudeValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deepnes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.altitude)).BeginInit();
            this.accelerate.SuspendLayout();
            this.deep.SuspendLayout();
            this.height.SuspendLayout();
            this.SuspendLayout();
            // 
            // constBox
            // 
            this.constBox.FormattingEnabled = true;
            this.constBox.Items.AddRange(new object[] {
            "Car",
            "Submarine",
            "Plane",
            "Computer"});
            this.constBox.Location = new System.Drawing.Point(27, 88);
            this.constBox.Name = "constBox";
            this.constBox.Size = new System.Drawing.Size(158, 147);
            this.constBox.TabIndex = 0;
            this.constBox.SelectedIndexChanged += new System.EventHandler(this.ConstBox_SelectedIndexChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(211, 115);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(96, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(211, 168);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(96, 28);
            this.remove.TabIndex = 2;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // varBox
            // 
            this.varBox.FormattingEnabled = true;
            this.varBox.Location = new System.Drawing.Point(328, 88);
            this.varBox.Name = "varBox";
            this.varBox.Size = new System.Drawing.Size(169, 160);
            this.varBox.TabIndex = 3;
            this.varBox.SelectedIndexChanged += new System.EventHandler(this.VarBox_SelectedIndexChanged);
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(9, 38);
            this.speed.Maximum = 250;
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(157, 45);
            this.speed.TabIndex = 4;
            this.speed.ValueChanged += new System.EventHandler(this.Speed_ValueChanged);
            // 
            // deepnes
            // 
            this.deepnes.Location = new System.Drawing.Point(9, 39);
            this.deepnes.Maximum = 1000;
            this.deepnes.Name = "deepnes";
            this.deepnes.Size = new System.Drawing.Size(154, 45);
            this.deepnes.TabIndex = 5;
            this.deepnes.ValueChanged += new System.EventHandler(this.Deepnes_ValueChanged);
            // 
            // altitude
            // 
            this.altitude.Location = new System.Drawing.Point(6, 36);
            this.altitude.Maximum = 10000;
            this.altitude.Name = "altitude";
            this.altitude.Size = new System.Drawing.Size(157, 45);
            this.altitude.TabIndex = 6;
            this.altitude.ValueChanged += new System.EventHandler(this.Altitude_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Szybkość";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Głębokość";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wysokość";
            // 
            // accelerate
            // 
            this.accelerate.Controls.Add(this.SpeedValue);
            this.accelerate.Controls.Add(this.label1);
            this.accelerate.Controls.Add(this.speed);
            this.accelerate.Location = new System.Drawing.Point(524, 64);
            this.accelerate.Name = "accelerate";
            this.accelerate.Size = new System.Drawing.Size(178, 105);
            this.accelerate.TabIndex = 10;
            this.accelerate.TabStop = false;
            this.accelerate.Visible = false;
            // 
            // deep
            // 
            this.deep.Controls.Add(this.DeepValue);
            this.deep.Controls.Add(this.label2);
            this.deep.Controls.Add(this.deepnes);
            this.deep.Location = new System.Drawing.Point(524, 175);
            this.deep.Name = "deep";
            this.deep.Size = new System.Drawing.Size(177, 90);
            this.deep.TabIndex = 11;
            this.deep.TabStop = false;
            this.deep.Visible = false;
            // 
            // height
            // 
            this.height.Controls.Add(this.AltitudeValue);
            this.height.Controls.Add(this.label3);
            this.height.Controls.Add(this.altitude);
            this.height.Location = new System.Drawing.Point(524, 271);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(178, 87);
            this.height.TabIndex = 12;
            this.height.TabStop = false;
            this.height.Visible = false;
            // 
            // SpeedValue
            // 
            this.SpeedValue.AutoSize = true;
            this.SpeedValue.Location = new System.Drawing.Point(16, 70);
            this.SpeedValue.Name = "SpeedValue";
            this.SpeedValue.Size = new System.Drawing.Size(35, 13);
            this.SpeedValue.TabIndex = 8;
            this.SpeedValue.Text = "label4";
            // 
            // DeepValue
            // 
            this.DeepValue.AutoSize = true;
            this.DeepValue.Location = new System.Drawing.Point(19, 71);
            this.DeepValue.Name = "DeepValue";
            this.DeepValue.Size = new System.Drawing.Size(35, 13);
            this.DeepValue.TabIndex = 9;
            this.DeepValue.Text = "label5";
            // 
            // AltitudeValue
            // 
            this.AltitudeValue.AutoSize = true;
            this.AltitudeValue.Location = new System.Drawing.Point(19, 69);
            this.AltitudeValue.Name = "AltitudeValue";
            this.AltitudeValue.Size = new System.Drawing.Size(35, 13);
            this.AltitudeValue.TabIndex = 10;
            this.AltitudeValue.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deep);
            this.Controls.Add(this.accelerate);
            this.Controls.Add(this.varBox);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.add);
            this.Controls.Add(this.constBox);
            this.Controls.Add(this.height);
            this.Name = "Form1";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deepnes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.altitude)).EndInit();
            this.accelerate.ResumeLayout(false);
            this.accelerate.PerformLayout();
            this.deep.ResumeLayout(false);
            this.deep.PerformLayout();
            this.height.ResumeLayout(false);
            this.height.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox constBox;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.ListBox varBox;
        private System.Windows.Forms.TrackBar speed;
        private System.Windows.Forms.TrackBar deepnes;
        private System.Windows.Forms.TrackBar altitude;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox accelerate;
        private System.Windows.Forms.GroupBox deep;
        private System.Windows.Forms.GroupBox height;
        private System.Windows.Forms.Label SpeedValue;
        private System.Windows.Forms.Label DeepValue;
        private System.Windows.Forms.Label AltitudeValue;
    }
}

