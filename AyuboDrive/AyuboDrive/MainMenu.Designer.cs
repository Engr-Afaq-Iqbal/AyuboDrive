namespace AyuboDrive
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
            this.btnRentCalculation = new System.Windows.Forms.Button();
            this.btnDayTour = new System.Windows.Forms.Button();
            this.btnLongTour = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRentCalculation
            // 
            this.btnRentCalculation.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRentCalculation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRentCalculation.Location = new System.Drawing.Point(111, 104);
            this.btnRentCalculation.Name = "btnRentCalculation";
            this.btnRentCalculation.Size = new System.Drawing.Size(176, 53);
            this.btnRentCalculation.TabIndex = 0;
            this.btnRentCalculation.Text = "Rent Calculation";
            this.btnRentCalculation.UseVisualStyleBackColor = false;
            this.btnRentCalculation.Click += new System.EventHandler(this.btnRentCalculation_Click);
            // 
            // btnDayTour
            // 
            this.btnDayTour.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDayTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDayTour.Location = new System.Drawing.Point(350, 104);
            this.btnDayTour.Name = "btnDayTour";
            this.btnDayTour.Size = new System.Drawing.Size(176, 53);
            this.btnDayTour.TabIndex = 1;
            this.btnDayTour.Text = "Day Tour";
            this.btnDayTour.UseVisualStyleBackColor = false;
            this.btnDayTour.Click += new System.EventHandler(this.btnDayTour_Click);
            // 
            // btnLongTour
            // 
            this.btnLongTour.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLongTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongTour.Location = new System.Drawing.Point(221, 185);
            this.btnLongTour.Name = "btnLongTour";
            this.btnLongTour.Size = new System.Drawing.Size(176, 53);
            this.btnLongTour.TabIndex = 2;
            this.btnLongTour.Text = "Long Tour";
            this.btnLongTour.UseVisualStyleBackColor = false;
            this.btnLongTour.Click += new System.EventHandler(this.btnLongTour_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(221, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(610, 345);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLongTour);
            this.Controls.Add(this.btnDayTour);
            this.Controls.Add(this.btnRentCalculation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRentCalculation;
        private System.Windows.Forms.Button btnDayTour;
        private System.Windows.Forms.Button btnLongTour;
        private System.Windows.Forms.Button button1;
    }
}