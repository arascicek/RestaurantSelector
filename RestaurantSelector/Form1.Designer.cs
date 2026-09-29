namespace RestaurantSelector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            chkGluten = new CheckBox();
            chkVegan = new CheckBox();
            chkVegetarian = new CheckBox();
            lstRestaurants = new ListBox();
            btnShow = new Button();
            btnExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkGluten);
            groupBox1.Controls.Add(chkVegan);
            groupBox1.Controls.Add(chkVegetarian);
            groupBox1.Location = new Point(162, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(203, 192);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Dietary Restrictions";
            // 
            // chkGluten
            // 
            chkGluten.AutoSize = true;
            chkGluten.Location = new Point(24, 144);
            chkGluten.Name = "chkGluten";
            chkGluten.Size = new Size(108, 24);
            chkGluten.TabIndex = 2;
            chkGluten.Text = "Gluten-Free";
            chkGluten.UseVisualStyleBackColor = true;
            // 
            // chkVegan
            // 
            chkVegan.AutoSize = true;
            chkVegan.Location = new Point(24, 92);
            chkVegan.Name = "chkVegan";
            chkVegan.Size = new Size(72, 24);
            chkVegan.TabIndex = 1;
            chkVegan.Text = "Vegan";
            chkVegan.UseVisualStyleBackColor = true;
            // 
            // chkVegetarian
            // 
            chkVegetarian.AutoSize = true;
            chkVegetarian.Location = new Point(24, 46);
            chkVegetarian.Name = "chkVegetarian";
            chkVegetarian.Size = new Size(102, 24);
            chkVegetarian.TabIndex = 0;
            chkVegetarian.Text = "Vegetarian";
            chkVegetarian.UseVisualStyleBackColor = true;
            // 
            // lstRestaurants
            // 
            lstRestaurants.FormattingEnabled = true;
            lstRestaurants.Location = new Point(162, 247);
            lstRestaurants.Name = "lstRestaurants";
            lstRestaurants.Size = new Size(203, 164);
            lstRestaurants.TabIndex = 3;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(162, 437);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(94, 29);
            btnShow.TabIndex = 4;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(271, 437);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 496);
            Controls.Add(btnExit);
            Controls.Add(btnShow);
            Controls.Add(lstRestaurants);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Restaurant Selector";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox chkGluten;
        private CheckBox chkVegan;
        private CheckBox chkVegetarian;
        private ListBox lstRestaurants;
        private Button btnShow;
        private Button btnExit;
    }
}
