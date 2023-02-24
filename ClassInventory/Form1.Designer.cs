namespace ClassInventory
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
            this.addBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.positionInput = new System.Windows.Forms.TextBox();
            this.teamInput = new System.Windows.Forms.TextBox();
            this.ageInput = new System.Windows.Forms.TextBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.teamLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.removeBox = new System.Windows.Forms.GroupBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.removeInput = new System.Windows.Forms.TextBox();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.GroupBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.nameSearchInput = new System.Windows.Forms.TextBox();
            this.nameLabel3 = new System.Windows.Forms.Label();
            this.addBox.SuspendLayout();
            this.removeBox.SuspendLayout();
            this.displayBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addBox
            // 
            this.addBox.Controls.Add(this.addButton);
            this.addBox.Controls.Add(this.positionInput);
            this.addBox.Controls.Add(this.teamInput);
            this.addBox.Controls.Add(this.ageInput);
            this.addBox.Controls.Add(this.nameInput);
            this.addBox.Controls.Add(this.positionLabel);
            this.addBox.Controls.Add(this.teamLabel);
            this.addBox.Controls.Add(this.ageLabel);
            this.addBox.Controls.Add(this.nameLabel);
            this.addBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBox.ForeColor = System.Drawing.Color.White;
            this.addBox.Location = new System.Drawing.Point(43, 85);
            this.addBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBox.Name = "addBox";
            this.addBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addBox.Size = new System.Drawing.Size(277, 270);
            this.addBox.TabIndex = 0;
            this.addBox.TabStop = false;
            this.addBox.Text = "New Player";
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(159, 208);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(100, 46);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // positionInput
            // 
            this.positionInput.Location = new System.Drawing.Point(97, 164);
            this.positionInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.positionInput.Name = "positionInput";
            this.positionInput.Size = new System.Drawing.Size(160, 26);
            this.positionInput.TabIndex = 7;
            // 
            // teamInput
            // 
            this.teamInput.Location = new System.Drawing.Point(97, 121);
            this.teamInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.teamInput.Name = "teamInput";
            this.teamInput.Size = new System.Drawing.Size(160, 26);
            this.teamInput.TabIndex = 6;
            // 
            // ageInput
            // 
            this.ageInput.Location = new System.Drawing.Point(97, 80);
            this.ageInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(47, 26);
            this.ageInput.TabIndex = 5;
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(97, 41);
            this.nameInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(160, 26);
            this.nameInput.TabIndex = 4;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(8, 169);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(70, 23);
            this.positionLabel.TabIndex = 3;
            this.positionLabel.Text = "Position";
            // 
            // teamLabel
            // 
            this.teamLabel.AutoSize = true;
            this.teamLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamLabel.Location = new System.Drawing.Point(9, 127);
            this.teamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.teamLabel.Name = "teamLabel";
            this.teamLabel.Size = new System.Drawing.Size(50, 23);
            this.teamLabel.TabIndex = 2;
            this.teamLabel.Text = "Team";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.Location = new System.Drawing.Point(9, 80);
            this.ageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(40, 23);
            this.ageLabel.TabIndex = 1;
            this.ageLabel.Text = "Age";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(9, 41);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(56, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.DarkRed;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(-4, -2);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(797, 69);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Team Database";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeBox
            // 
            this.removeBox.Controls.Add(this.removeButton);
            this.removeBox.Controls.Add(this.removeInput);
            this.removeBox.Controls.Add(this.nameLabel2);
            this.removeBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBox.ForeColor = System.Drawing.Color.White;
            this.removeBox.Location = new System.Drawing.Point(43, 379);
            this.removeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeBox.Name = "removeBox";
            this.removeBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeBox.Size = new System.Drawing.Size(277, 148);
            this.removeBox.TabIndex = 2;
            this.removeBox.TabStop = false;
            this.removeBox.Text = "Remove Player";
            // 
            // removeButton
            // 
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Location = new System.Drawing.Point(159, 80);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 46);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // removeInput
            // 
            this.removeInput.Location = new System.Drawing.Point(97, 41);
            this.removeInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeInput.Name = "removeInput";
            this.removeInput.Size = new System.Drawing.Size(160, 26);
            this.removeInput.TabIndex = 4;
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel2.Location = new System.Drawing.Point(9, 41);
            this.nameLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(56, 23);
            this.nameLabel2.TabIndex = 0;
            this.nameLabel2.Text = "Name";
            // 
            // displayBox
            // 
            this.displayBox.Controls.Add(this.outputLabel);
            this.displayBox.Controls.Add(this.showButton);
            this.displayBox.Controls.Add(this.searchButton);
            this.displayBox.Controls.Add(this.nameSearchInput);
            this.displayBox.Controls.Add(this.nameLabel3);
            this.displayBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.ForeColor = System.Drawing.Color.White;
            this.displayBox.Location = new System.Drawing.Point(359, 85);
            this.displayBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayBox.Name = "displayBox";
            this.displayBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayBox.Size = new System.Drawing.Size(385, 442);
            this.displayBox.TabIndex = 3;
            this.displayBox.TabStop = false;
            this.displayBox.Text = "Output";
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Black;
            this.outputLabel.Location = new System.Drawing.Point(13, 127);
            this.outputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(353, 293);
            this.outputLabel.TabIndex = 10;
            // 
            // showButton
            // 
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showButton.Location = new System.Drawing.Point(267, 80);
            this.showButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(100, 27);
            this.showButton.TabIndex = 9;
            this.showButton.Text = "Show All";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Location = new System.Drawing.Point(267, 41);
            this.searchButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 27);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // nameSearchInput
            // 
            this.nameSearchInput.Location = new System.Drawing.Point(97, 41);
            this.nameSearchInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameSearchInput.Name = "nameSearchInput";
            this.nameSearchInput.Size = new System.Drawing.Size(160, 26);
            this.nameSearchInput.TabIndex = 4;
            // 
            // nameLabel3
            // 
            this.nameLabel3.AutoSize = true;
            this.nameLabel3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel3.Location = new System.Drawing.Point(9, 41);
            this.nameLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel3.Name = "nameLabel3";
            this.nameLabel3.Size = new System.Drawing.Size(56, 23);
            this.nameLabel3.TabIndex = 0;
            this.nameLabel3.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(788, 559);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.removeBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.addBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Class Inventory";
            this.addBox.ResumeLayout(false);
            this.addBox.PerformLayout();
            this.removeBox.ResumeLayout(false);
            this.removeBox.PerformLayout();
            this.displayBox.ResumeLayout(false);
            this.displayBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox positionInput;
        private System.Windows.Forms.TextBox teamInput;
        private System.Windows.Forms.TextBox ageInput;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label teamLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.GroupBox removeBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TextBox removeInput;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.GroupBox displayBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox nameSearchInput;
        private System.Windows.Forms.Label nameLabel3;
    }
}

