
namespace TB6600_Application
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
            this.COMPortComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CalibrateButton = new System.Windows.Forms.Button();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.MoveByLabel = new System.Windows.Forms.Label();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.unitsComboBox = new System.Windows.Forms.ComboBox();
            this.SetPositionTextBox = new System.Windows.Forms.TextBox();
            this.SetPositionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Terminal = new System.Windows.Forms.RichTextBox();
            this.MoveByTextBox = new System.Windows.Forms.TextBox();
            this.MoveDownByButton = new System.Windows.Forms.Button();
            this.MoveUpByButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMPortComboBox
            // 
            this.COMPortComboBox.FormattingEnabled = true;
            this.COMPortComboBox.Location = new System.Drawing.Point(83, 4);
            this.COMPortComboBox.Name = "COMPortComboBox";
            this.COMPortComboBox.Size = new System.Drawing.Size(121, 24);
            this.COMPortComboBox.TabIndex = 0;
            this.COMPortComboBox.SelectedIndexChanged += new System.EventHandler(this.COMPortComboBox_SelectedIndexChanged);
            this.COMPortComboBox.Click += new System.EventHandler(this.COMPortComboBox_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ConnectButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.COMPortComboBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 36);
            this.panel1.TabIndex = 1;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(218, 4);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "COM Port:";
            // 
            // CalibrateButton
            // 
            this.CalibrateButton.Location = new System.Drawing.Point(295, 31);
            this.CalibrateButton.Name = "CalibrateButton";
            this.CalibrateButton.Size = new System.Drawing.Size(75, 23);
            this.CalibrateButton.TabIndex = 2;
            this.CalibrateButton.Text = "Calibrate";
            this.CalibrateButton.UseVisualStyleBackColor = true;
            this.CalibrateButton.Click += new System.EventHandler(this.CalibrateButton_Click);
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Location = new System.Drawing.Point(147, 7);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(65, 23);
            this.MoveDownButton.TabIndex = 1;
            this.MoveDownButton.Text = "Down";
            this.MoveDownButton.UseVisualStyleBackColor = true;
            this.MoveDownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Location = new System.Drawing.Point(57, 7);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(69, 23);
            this.MoveUpButton.TabIndex = 0;
            this.MoveUpButton.Text = "Up";
            this.MoveUpButton.UseVisualStyleBackColor = true;
            this.MoveUpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.MoveDownByButton);
            this.panel3.Controls.Add(this.MoveUpByButton);
            this.panel3.Controls.Add(this.MoveByTextBox);
            this.panel3.Controls.Add(this.MoveByLabel);
            this.panel3.Controls.Add(this.unitsLabel);
            this.panel3.Controls.Add(this.CalibrateButton);
            this.panel3.Controls.Add(this.unitsComboBox);
            this.panel3.Controls.Add(this.SetPositionTextBox);
            this.panel3.Controls.Add(this.MoveDownButton);
            this.panel3.Controls.Add(this.SetPositionButton);
            this.panel3.Controls.Add(this.MoveUpButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 100);
            this.panel3.TabIndex = 3;
            // 
            // MoveByLabel
            // 
            this.MoveByLabel.AutoSize = true;
            this.MoveByLabel.Location = new System.Drawing.Point(5, 67);
            this.MoveByLabel.Name = "MoveByLabel";
            this.MoveByLabel.Size = new System.Drawing.Size(66, 17);
            this.MoveByLabel.TabIndex = 7;
            this.MoveByLabel.Text = "Move By:";
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Location = new System.Drawing.Point(223, 6);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(48, 17);
            this.unitsLabel.TabIndex = 6;
            this.unitsLabel.Text = "Units: ";
            // 
            // unitsComboBox
            // 
            this.unitsComboBox.FormattingEnabled = true;
            this.unitsComboBox.Items.AddRange(new object[] {
            "mm",
            "cm",
            "inches"});
            this.unitsComboBox.Location = new System.Drawing.Point(288, 3);
            this.unitsComboBox.Name = "unitsComboBox";
            this.unitsComboBox.Size = new System.Drawing.Size(82, 24);
            this.unitsComboBox.TabIndex = 5;
            this.unitsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SetPositionTextBox
            // 
            this.SetPositionTextBox.Location = new System.Drawing.Point(92, 37);
            this.SetPositionTextBox.Name = "SetPositionTextBox";
            this.SetPositionTextBox.Size = new System.Drawing.Size(120, 22);
            this.SetPositionTextBox.TabIndex = 2;
            // 
            // SetPositionButton
            // 
            this.SetPositionButton.Location = new System.Drawing.Point(226, 34);
            this.SetPositionButton.Name = "SetPositionButton";
            this.SetPositionButton.Size = new System.Drawing.Size(67, 23);
            this.SetPositionButton.TabIndex = 1;
            this.SetPositionButton.Text = "Set";
            this.SetPositionButton.UseVisualStyleBackColor = true;
            this.SetPositionButton.Click += new System.EventHandler(this.SetPosition_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Set Position";
            // 
            // Terminal
            // 
            this.Terminal.Location = new System.Drawing.Point(12, 160);
            this.Terminal.Name = "Terminal";
            this.Terminal.Size = new System.Drawing.Size(373, 96);
            this.Terminal.TabIndex = 4;
            this.Terminal.Text = "";
            // 
            // MoveByTextBox
            // 
            this.MoveByTextBox.Location = new System.Drawing.Point(77, 67);
            this.MoveByTextBox.Name = "MoveByTextBox";
            this.MoveByTextBox.Size = new System.Drawing.Size(135, 22);
            this.MoveByTextBox.TabIndex = 8;
            // 
            // MoveDownByButton
            // 
            this.MoveDownByButton.Location = new System.Drawing.Point(295, 64);
            this.MoveDownByButton.Name = "MoveDownByButton";
            this.MoveDownByButton.Size = new System.Drawing.Size(75, 23);
            this.MoveDownByButton.TabIndex = 10;
            this.MoveDownByButton.Text = "Down";
            this.MoveDownByButton.UseVisualStyleBackColor = true;
            this.MoveDownByButton.Click += new System.EventHandler(this.MoveDownByButton_Click);
            // 
            // MoveUpByButton
            // 
            this.MoveUpByButton.Location = new System.Drawing.Point(218, 64);
            this.MoveUpByButton.Name = "MoveUpByButton";
            this.MoveUpByButton.Size = new System.Drawing.Size(75, 23);
            this.MoveUpByButton.TabIndex = 9;
            this.MoveUpByButton.Text = "Up";
            this.MoveUpByButton.UseVisualStyleBackColor = true;
            this.MoveUpByButton.Click += new System.EventHandler(this.MoveUpByButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Move:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 271);
            this.Controls.Add(this.Terminal);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox COMPortComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetPositionButton;
        private System.Windows.Forms.TextBox SetPositionTextBox;
        private System.Windows.Forms.RichTextBox Terminal;
        private System.Windows.Forms.Button CalibrateButton;
        private System.Windows.Forms.ComboBox unitsComboBox;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.Label MoveByLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MoveDownByButton;
        private System.Windows.Forms.Button MoveUpByButton;
        private System.Windows.Forms.TextBox MoveByTextBox;
    }
}

