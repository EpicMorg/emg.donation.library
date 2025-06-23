namespace emg.donation.library.net20.test
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonShow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonEmulate = new System.Windows.Forms.Button();
            this.numericUpDownDays = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.buttonShow.Location = new System.Drawing.Point(12, 12);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(117, 52);
            this.buttonShow.TabIndex = 0;
            this.buttonShow.Text = "Show debug";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // button1
            // 
            this.button1.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.button1.Location = new System.Drawing.Point(135, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Remove all flags";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEmulate
            // 
            this.buttonEmulate.AccessibleRole = System.Windows.Forms.AccessibleRole.Equation;
            this.buttonEmulate.Location = new System.Drawing.Point(12, 70);
            this.buttonEmulate.Name = "buttonEmulate";
            this.buttonEmulate.Size = new System.Drawing.Size(160, 27);
            this.buttonEmulate.TabIndex = 0;
            this.buttonEmulate.Text = "Set delay days and show";
            this.buttonEmulate.UseVisualStyleBackColor = true;
            this.buttonEmulate.Click += new System.EventHandler(this.buttonEmulate_Click);
            // 
            // numericUpDownDays
            // 
            this.numericUpDownDays.Location = new System.Drawing.Point(178, 75);
            this.numericUpDownDays.Name = "numericUpDownDays";
            this.numericUpDownDays.Size = new System.Drawing.Size(74, 20);
            this.numericUpDownDays.TabIndex = 1;
            this.numericUpDownDays.ValueChanged += new System.EventHandler(this.numericUpDownDays_ValueChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 105);
            this.Controls.Add(this.numericUpDownDays);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEmulate);
            this.Controls.Add(this.buttonShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Donation Test";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDays)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonEmulate;
        private System.Windows.Forms.NumericUpDown numericUpDownDays;
    }
}

