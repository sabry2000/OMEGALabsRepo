
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
            this.DownButton = new System.Windows.Forms.Button();
            this.UpButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.unitsComboBox = new System.Windows.Forms.ComboBox();
            this.SetPositionTextBox = new System.Windows.Forms.TextBox();
            this.SetPositionButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Terminal = new System.Windows.Forms.RichTextBox();
            this.unitsLabel = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(296, 36);
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
            this.CalibrateButton.Location = new System.Drawing.Point(218, 3);
            this.CalibrateButton.Name = "CalibrateButton";
            this.CalibrateButton.Size = new System.Drawing.Size(75, 23);
            this.CalibrateButton.TabIndex = 2;
            this.CalibrateButton.Text = "Calibrate";
            this.CalibrateButton.UseVisualStyleBackColor = true;
            this.CalibrateButton.Click += new System.EventHandler(this.CalibrateButton_Click);
            // 
            // DownButton
            // 
            this.DownButton.Location = new System.Drawing.Point(109, 3);
            this.DownButton.Name = "DownButton";
            this.DownButton.Size = new System.Drawing.Size(75, 23);
            this.DownButton.TabIndex = 1;
            this.DownButton.Text = "Down";
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Location = new System.Drawing.Point(7, 3);
            this.UpButton.Name = "UpButton";
            this.UpButton.Size = new System.Drawing.Size(75, 23);
            this.UpButton.TabIndex = 0;
            this.UpButton.Text = "Up";
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.unitsLabel);
            this.panel3.Controls.Add(this.CalibrateButton);
            this.panel3.Controls.Add(this.unitsComboBox);
            this.panel3.Controls.Add(this.SetPositionTextBox);
            this.panel3.Controls.Add(this.DownButton);
            this.panel3.Controls.Add(this.SetPositionButton);
            this.panel3.Controls.Add(this.UpButton);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 54);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 100);
            this.panel3.TabIndex = 3;
            // 
            // unitsComboBox
            // 
            this.unitsComboBox.FormattingEnabled = true;
            this.unitsComboBox.Items.AddRange(new object[] {
            "mm",
            "cm",
            "inches"});
            this.unitsComboBox.Location = new System.Drawing.Point(229, 60);
            this.unitsComboBox.Name = "unitsComboBox";
            this.unitsComboBox.Size = new System.Drawing.Size(64, 24);
            this.unitsComboBox.TabIndex = 5;
            this.unitsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // SetPositionTextBox
            // 
            this.SetPositionTextBox.Location = new System.Drawing.Point(92, 32);
            this.SetPositionTextBox.Name = "SetPositionTextBox";
            this.SetPositionTextBox.Size = new System.Drawing.Size(121, 22);
            this.SetPositionTextBox.TabIndex = 2;
            // 
            // SetPositionButton
            // 
            this.SetPositionButton.Location = new System.Drawing.Point(219, 31);
            this.SetPositionButton.Name = "SetPositionButton";
            this.SetPositionButton.Size = new System.Drawing.Size(75, 23);
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
            this.Terminal.Size = new System.Drawing.Size(296, 96);
            this.Terminal.TabIndex = 4;
            this.Terminal.Text = "";
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Location = new System.Drawing.Point(166, 66);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(48, 17);
            this.unitsLabel.TabIndex = 6;
            this.unitsLabel.Text = "Units: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 274);
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
        private System.Windows.Forms.Button UpButton;
        private System.Windows.Forms.Button DownButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SetPositionButton;
        private System.Windows.Forms.TextBox SetPositionTextBox;
        private System.Windows.Forms.RichTextBox Terminal;
        private System.Windows.Forms.Button CalibrateButton;
        private System.Windows.Forms.ComboBox unitsComboBox;
        private System.Windows.Forms.Label unitsLabel;
    }
}

