
namespace TB6600_Application
{
    partial class LinearStagesApplication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LinearStagesApplication));
            this.COMPortComboBox = new System.Windows.Forms.ComboBox();
            this.COMPortPanel = new System.Windows.Forms.Panel();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.COMPortLabel = new System.Windows.Forms.Label();
            this.CalibrateButton = new System.Windows.Forms.Button();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.MovePanel = new System.Windows.Forms.Panel();
            this.MoveButton = new System.Windows.Forms.Button();
            this.MoveByTextBox = new System.Windows.Forms.TextBox();
            this.MoveByLabel = new System.Windows.Forms.Label();
            this.SetPositionTextBox = new System.Windows.Forms.TextBox();
            this.SetPositionButton = new System.Windows.Forms.Button();
            this.SetPostionLabel = new System.Windows.Forms.Label();
            this.unitsLabel = new System.Windows.Forms.Label();
            this.UnitsComboBox = new System.Windows.Forms.ComboBox();
            this.Terminal = new System.Windows.Forms.RichTextBox();
            this.SweepPanel = new System.Windows.Forms.Panel();
            this.MillisSecondsLabel = new System.Windows.Forms.Label();
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.DelayTextBox = new System.Windows.Forms.TextBox();
            this.DelayLabel = new System.Windows.Forms.Label();
            this.StepsTextBox = new System.Windows.Forms.TextBox();
            this.StepsLabel = new System.Windows.Forms.Label();
            this.MaxButton = new System.Windows.Forms.Button();
            this.EndTextBox = new System.Windows.Forms.TextBox();
            this.EndLabel = new System.Windows.Forms.Label();
            this.MinButton = new System.Windows.Forms.Button();
            this.StartTextBox = new System.Windows.Forms.TextBox();
            this.StartLabel = new System.Windows.Forms.Label();
            this.UnitsPanel = new System.Windows.Forms.Panel();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.MoveTab = new System.Windows.Forms.TabPage();
            this.SweepTab = new System.Windows.Forms.TabPage();
            this.CurrentPositionPanel = new System.Windows.Forms.Panel();
            this.CurrentPositionTextBox = new System.Windows.Forms.TextBox();
            this.CurrentPositionLabel = new System.Windows.Forms.Label();
            this.TerminalPanel = new System.Windows.Forms.Panel();
            this.TerminalLabel = new System.Windows.Forms.Label();
            this.COMPortPanel.SuspendLayout();
            this.MovePanel.SuspendLayout();
            this.SweepPanel.SuspendLayout();
            this.UnitsPanel.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.MoveTab.SuspendLayout();
            this.SweepTab.SuspendLayout();
            this.CurrentPositionPanel.SuspendLayout();
            this.TerminalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // COMPortComboBox
            // 
            this.COMPortComboBox.FormattingEnabled = true;
            this.COMPortComboBox.Location = new System.Drawing.Point(83, 4);
            this.COMPortComboBox.Name = "COMPortComboBox";
            this.COMPortComboBox.Size = new System.Drawing.Size(84, 24);
            this.COMPortComboBox.TabIndex = 0;
            this.COMPortComboBox.SelectedIndexChanged += new System.EventHandler(this.COMPortComboBox_SelectedIndexChanged);
            this.COMPortComboBox.Click += new System.EventHandler(this.COMPortComboBox_Click);
            // 
            // COMPortPanel
            // 
            this.COMPortPanel.Controls.Add(this.ConnectButton);
            this.COMPortPanel.Controls.Add(this.COMPortLabel);
            this.COMPortPanel.Controls.Add(this.COMPortComboBox);
            this.COMPortPanel.Location = new System.Drawing.Point(12, 12);
            this.COMPortPanel.Name = "COMPortPanel";
            this.COMPortPanel.Size = new System.Drawing.Size(286, 36);
            this.COMPortPanel.TabIndex = 1;
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(173, 5);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(110, 28);
            this.ConnectButton.TabIndex = 1;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // COMPortLabel
            // 
            this.COMPortLabel.AutoSize = true;
            this.COMPortLabel.Location = new System.Drawing.Point(4, 4);
            this.COMPortLabel.Name = "COMPortLabel";
            this.COMPortLabel.Size = new System.Drawing.Size(69, 17);
            this.COMPortLabel.TabIndex = 0;
            this.COMPortLabel.Text = "COM Port";
            // 
            // CalibrateButton
            // 
            this.CalibrateButton.Location = new System.Drawing.Point(234, 3);
            this.CalibrateButton.Name = "CalibrateButton";
            this.CalibrateButton.Size = new System.Drawing.Size(85, 28);
            this.CalibrateButton.TabIndex = 2;
            this.CalibrateButton.Text = "Calibrate";
            this.CalibrateButton.UseVisualStyleBackColor = true;
            this.CalibrateButton.Click += new System.EventHandler(this.CalibrateButton_Click);
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Location = new System.Drawing.Point(309, 36);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(68, 28);
            this.MoveDownButton.TabIndex = 1;
            this.MoveDownButton.Text = "Down";
            this.MoveDownButton.UseVisualStyleBackColor = true;
            this.MoveDownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Location = new System.Drawing.Point(308, 10);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(69, 24);
            this.MoveUpButton.TabIndex = 0;
            this.MoveUpButton.Text = "Up";
            this.MoveUpButton.UseVisualStyleBackColor = true;
            this.MoveUpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // MovePanel
            // 
            this.MovePanel.Controls.Add(this.MoveButton);
            this.MovePanel.Controls.Add(this.MoveByTextBox);
            this.MovePanel.Controls.Add(this.MoveByLabel);
            this.MovePanel.Controls.Add(this.SetPositionTextBox);
            this.MovePanel.Controls.Add(this.MoveDownButton);
            this.MovePanel.Controls.Add(this.SetPositionButton);
            this.MovePanel.Controls.Add(this.MoveUpButton);
            this.MovePanel.Controls.Add(this.SetPostionLabel);
            this.MovePanel.Location = new System.Drawing.Point(6, 6);
            this.MovePanel.Name = "MovePanel";
            this.MovePanel.Size = new System.Drawing.Size(380, 68);
            this.MovePanel.TabIndex = 3;
            // 
            // MoveButton
            // 
            this.MoveButton.Location = new System.Drawing.Point(224, 36);
            this.MoveButton.Name = "MoveButton";
            this.MoveButton.Size = new System.Drawing.Size(75, 28);
            this.MoveButton.TabIndex = 12;
            this.MoveButton.Text = "Move";
            this.MoveButton.UseVisualStyleBackColor = true;
            this.MoveButton.Click += new System.EventHandler(this.MoveButton_Click);
            // 
            // MoveByTextBox
            // 
            this.MoveByTextBox.Location = new System.Drawing.Point(90, 39);
            this.MoveByTextBox.Name = "MoveByTextBox";
            this.MoveByTextBox.Size = new System.Drawing.Size(120, 22);
            this.MoveByTextBox.TabIndex = 8;
            this.MoveByTextBox.Text = "0";
            // 
            // MoveByLabel
            // 
            this.MoveByLabel.AutoSize = true;
            this.MoveByLabel.Location = new System.Drawing.Point(3, 39);
            this.MoveByLabel.Name = "MoveByLabel";
            this.MoveByLabel.Size = new System.Drawing.Size(62, 17);
            this.MoveByLabel.TabIndex = 7;
            this.MoveByLabel.Text = "Move By";
            // 
            // SetPositionTextBox
            // 
            this.SetPositionTextBox.Location = new System.Drawing.Point(90, 9);
            this.SetPositionTextBox.Name = "SetPositionTextBox";
            this.SetPositionTextBox.Size = new System.Drawing.Size(120, 22);
            this.SetPositionTextBox.TabIndex = 2;
            this.SetPositionTextBox.Text = "0";
            // 
            // SetPositionButton
            // 
            this.SetPositionButton.Location = new System.Drawing.Point(224, 9);
            this.SetPositionButton.Name = "SetPositionButton";
            this.SetPositionButton.Size = new System.Drawing.Size(75, 24);
            this.SetPositionButton.TabIndex = 1;
            this.SetPositionButton.Text = "Set";
            this.SetPositionButton.UseVisualStyleBackColor = true;
            this.SetPositionButton.Click += new System.EventHandler(this.SetPosition_Click);
            // 
            // SetPostionLabel
            // 
            this.SetPostionLabel.AutoSize = true;
            this.SetPostionLabel.Location = new System.Drawing.Point(3, 9);
            this.SetPostionLabel.Name = "SetPostionLabel";
            this.SetPostionLabel.Size = new System.Drawing.Size(83, 17);
            this.SetPostionLabel.TabIndex = 0;
            this.SetPostionLabel.Text = "Set Position";
            // 
            // unitsLabel
            // 
            this.unitsLabel.AutoSize = true;
            this.unitsLabel.Location = new System.Drawing.Point(3, 4);
            this.unitsLabel.Name = "unitsLabel";
            this.unitsLabel.Size = new System.Drawing.Size(40, 17);
            this.unitsLabel.TabIndex = 6;
            this.unitsLabel.Text = "Units";
            // 
            // UnitsComboBox
            // 
            this.UnitsComboBox.FormattingEnabled = true;
            this.UnitsComboBox.Location = new System.Drawing.Point(73, 5);
            this.UnitsComboBox.Name = "UnitsComboBox";
            this.UnitsComboBox.Size = new System.Drawing.Size(82, 24);
            this.UnitsComboBox.TabIndex = 5;
            this.UnitsComboBox.SelectedIndexChanged += new System.EventHandler(this.UnitsComboBox_SelectedIndexChanged);
            // 
            // Terminal
            // 
            this.Terminal.Location = new System.Drawing.Point(3, 25);
            this.Terminal.Name = "Terminal";
            this.Terminal.ReadOnly = true;
            this.Terminal.Size = new System.Drawing.Size(452, 85);
            this.Terminal.TabIndex = 4;
            this.Terminal.Text = "";
            // 
            // SweepPanel
            // 
            this.SweepPanel.Controls.Add(this.MillisSecondsLabel);
            this.SweepPanel.Controls.Add(this.ExecuteButton);
            this.SweepPanel.Controls.Add(this.DelayTextBox);
            this.SweepPanel.Controls.Add(this.DelayLabel);
            this.SweepPanel.Controls.Add(this.StepsTextBox);
            this.SweepPanel.Controls.Add(this.StepsLabel);
            this.SweepPanel.Controls.Add(this.MaxButton);
            this.SweepPanel.Controls.Add(this.EndTextBox);
            this.SweepPanel.Controls.Add(this.EndLabel);
            this.SweepPanel.Controls.Add(this.MinButton);
            this.SweepPanel.Controls.Add(this.StartTextBox);
            this.SweepPanel.Controls.Add(this.StartLabel);
            this.SweepPanel.Location = new System.Drawing.Point(6, 6);
            this.SweepPanel.Name = "SweepPanel";
            this.SweepPanel.Size = new System.Drawing.Size(437, 90);
            this.SweepPanel.TabIndex = 5;
            // 
            // MillisSecondsLabel
            // 
            this.MillisSecondsLabel.AutoSize = true;
            this.MillisSecondsLabel.Location = new System.Drawing.Point(409, 35);
            this.MillisSecondsLabel.Name = "MillisSecondsLabel";
            this.MillisSecondsLabel.Size = new System.Drawing.Size(26, 17);
            this.MillisSecondsLabel.TabIndex = 12;
            this.MillisSecondsLabel.Text = "ms";
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Location = new System.Drawing.Point(313, 60);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(75, 23);
            this.ExecuteButton.TabIndex = 11;
            this.ExecuteButton.Text = "Execute";
            this.ExecuteButton.UseVisualStyleBackColor = true;
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // DelayTextBox
            // 
            this.DelayTextBox.Location = new System.Drawing.Point(303, 32);
            this.DelayTextBox.Name = "DelayTextBox";
            this.DelayTextBox.Size = new System.Drawing.Size(100, 22);
            this.DelayTextBox.TabIndex = 10;
            // 
            // DelayLabel
            // 
            this.DelayLabel.AutoSize = true;
            this.DelayLabel.Location = new System.Drawing.Point(253, 32);
            this.DelayLabel.Name = "DelayLabel";
            this.DelayLabel.Size = new System.Drawing.Size(44, 17);
            this.DelayLabel.TabIndex = 9;
            this.DelayLabel.Text = "Delay";
            // 
            // StepsTextBox
            // 
            this.StepsTextBox.Location = new System.Drawing.Point(303, 4);
            this.StepsTextBox.Name = "StepsTextBox";
            this.StepsTextBox.Size = new System.Drawing.Size(100, 22);
            this.StepsTextBox.TabIndex = 8;
            // 
            // StepsLabel
            // 
            this.StepsLabel.AutoSize = true;
            this.StepsLabel.Location = new System.Drawing.Point(253, 7);
            this.StepsLabel.Name = "StepsLabel";
            this.StepsLabel.Size = new System.Drawing.Size(44, 17);
            this.StepsLabel.TabIndex = 7;
            this.StepsLabel.Text = "Steps";
            // 
            // MaxButton
            // 
            this.MaxButton.Location = new System.Drawing.Point(151, 31);
            this.MaxButton.Name = "MaxButton";
            this.MaxButton.Size = new System.Drawing.Size(75, 23);
            this.MaxButton.TabIndex = 6;
            this.MaxButton.Text = "Max";
            this.MaxButton.UseVisualStyleBackColor = true;
            this.MaxButton.Click += new System.EventHandler(this.MaxButton_Click);
            // 
            // EndTextBox
            // 
            this.EndTextBox.Location = new System.Drawing.Point(45, 32);
            this.EndTextBox.Name = "EndTextBox";
            this.EndTextBox.Size = new System.Drawing.Size(100, 22);
            this.EndTextBox.TabIndex = 5;
            // 
            // EndLabel
            // 
            this.EndLabel.AutoSize = true;
            this.EndLabel.Location = new System.Drawing.Point(1, 31);
            this.EndLabel.Name = "EndLabel";
            this.EndLabel.Size = new System.Drawing.Size(33, 17);
            this.EndLabel.TabIndex = 4;
            this.EndLabel.Text = "End";
            // 
            // MinButton
            // 
            this.MinButton.Location = new System.Drawing.Point(151, 4);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(75, 23);
            this.MinButton.TabIndex = 3;
            this.MinButton.Text = "Min";
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // StartTextBox
            // 
            this.StartTextBox.Location = new System.Drawing.Point(45, 4);
            this.StartTextBox.Name = "StartTextBox";
            this.StartTextBox.Size = new System.Drawing.Size(100, 22);
            this.StartTextBox.TabIndex = 2;
            // 
            // StartLabel
            // 
            this.StartLabel.AutoSize = true;
            this.StartLabel.Location = new System.Drawing.Point(1, 4);
            this.StartLabel.Name = "StartLabel";
            this.StartLabel.Size = new System.Drawing.Size(38, 17);
            this.StartLabel.TabIndex = 1;
            this.StartLabel.Text = "Start";
            // 
            // UnitsPanel
            // 
            this.UnitsPanel.Controls.Add(this.unitsLabel);
            this.UnitsPanel.Controls.Add(this.UnitsComboBox);
            this.UnitsPanel.Location = new System.Drawing.Point(304, 12);
            this.UnitsPanel.Name = "UnitsPanel";
            this.UnitsPanel.Size = new System.Drawing.Size(167, 36);
            this.UnitsPanel.TabIndex = 11;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.MoveTab);
            this.TabControl.Controls.Add(this.SweepTab);
            this.TabControl.Location = new System.Drawing.Point(12, 94);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(459, 128);
            this.TabControl.TabIndex = 12;
            // 
            // MoveTab
            // 
            this.MoveTab.Controls.Add(this.MovePanel);
            this.MoveTab.Location = new System.Drawing.Point(4, 25);
            this.MoveTab.Name = "MoveTab";
            this.MoveTab.Padding = new System.Windows.Forms.Padding(3);
            this.MoveTab.Size = new System.Drawing.Size(451, 99);
            this.MoveTab.TabIndex = 1;
            this.MoveTab.Text = "Move";
            this.MoveTab.UseVisualStyleBackColor = true;
            // 
            // SweepTab
            // 
            this.SweepTab.Controls.Add(this.SweepPanel);
            this.SweepTab.Location = new System.Drawing.Point(4, 25);
            this.SweepTab.Name = "SweepTab";
            this.SweepTab.Padding = new System.Windows.Forms.Padding(3);
            this.SweepTab.Size = new System.Drawing.Size(451, 99);
            this.SweepTab.TabIndex = 2;
            this.SweepTab.Text = "Sweep";
            this.SweepTab.UseVisualStyleBackColor = true;
            // 
            // CurrentPositionPanel
            // 
            this.CurrentPositionPanel.Controls.Add(this.CurrentPositionTextBox);
            this.CurrentPositionPanel.Controls.Add(this.CurrentPositionLabel);
            this.CurrentPositionPanel.Controls.Add(this.CalibrateButton);
            this.CurrentPositionPanel.Location = new System.Drawing.Point(12, 54);
            this.CurrentPositionPanel.Name = "CurrentPositionPanel";
            this.CurrentPositionPanel.Size = new System.Drawing.Size(333, 34);
            this.CurrentPositionPanel.TabIndex = 13;
            // 
            // CurrentPositionTextBox
            // 
            this.CurrentPositionTextBox.Location = new System.Drawing.Point(118, 6);
            this.CurrentPositionTextBox.Name = "CurrentPositionTextBox";
            this.CurrentPositionTextBox.ReadOnly = true;
            this.CurrentPositionTextBox.Size = new System.Drawing.Size(100, 22);
            this.CurrentPositionTextBox.TabIndex = 1;
            // 
            // CurrentPositionLabel
            // 
            this.CurrentPositionLabel.AutoSize = true;
            this.CurrentPositionLabel.Location = new System.Drawing.Point(3, 6);
            this.CurrentPositionLabel.Name = "CurrentPositionLabel";
            this.CurrentPositionLabel.Size = new System.Drawing.Size(109, 17);
            this.CurrentPositionLabel.TabIndex = 0;
            this.CurrentPositionLabel.Text = "Current Position";
            // 
            // TerminalPanel
            // 
            this.TerminalPanel.Controls.Add(this.TerminalLabel);
            this.TerminalPanel.Controls.Add(this.Terminal);
            this.TerminalPanel.Location = new System.Drawing.Point(12, 224);
            this.TerminalPanel.Name = "TerminalPanel";
            this.TerminalPanel.Size = new System.Drawing.Size(459, 117);
            this.TerminalPanel.TabIndex = 14;
            // 
            // TerminalLabel
            // 
            this.TerminalLabel.AutoSize = true;
            this.TerminalLabel.Location = new System.Drawing.Point(7, 5);
            this.TerminalLabel.Name = "TerminalLabel";
            this.TerminalLabel.Size = new System.Drawing.Size(63, 17);
            this.TerminalLabel.TabIndex = 5;
            this.TerminalLabel.Text = "Terminal";
            // 
            // LinearStagesApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 346);
            this.Controls.Add(this.TerminalPanel);
            this.Controls.Add(this.CurrentPositionPanel);
            this.Controls.Add(this.COMPortPanel);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.UnitsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LinearStagesApplication";
            this.Text = "Linear Stages Application";
            this.COMPortPanel.ResumeLayout(false);
            this.COMPortPanel.PerformLayout();
            this.MovePanel.ResumeLayout(false);
            this.MovePanel.PerformLayout();
            this.SweepPanel.ResumeLayout(false);
            this.SweepPanel.PerformLayout();
            this.UnitsPanel.ResumeLayout(false);
            this.UnitsPanel.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.MoveTab.ResumeLayout(false);
            this.SweepTab.ResumeLayout(false);
            this.CurrentPositionPanel.ResumeLayout(false);
            this.CurrentPositionPanel.PerformLayout();
            this.TerminalPanel.ResumeLayout(false);
            this.TerminalPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox COMPortComboBox;
        private System.Windows.Forms.Panel COMPortPanel;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label COMPortLabel;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Panel MovePanel;
        private System.Windows.Forms.Label SetPostionLabel;
        private System.Windows.Forms.Button SetPositionButton;
        private System.Windows.Forms.TextBox SetPositionTextBox;
        private System.Windows.Forms.RichTextBox Terminal;
        private System.Windows.Forms.Button CalibrateButton;
        private System.Windows.Forms.Label unitsLabel;
        private System.Windows.Forms.Label MoveByLabel;
        private System.Windows.Forms.TextBox MoveByTextBox;
        private System.Windows.Forms.Panel SweepPanel;
        private System.Windows.Forms.Panel UnitsPanel;
        private System.Windows.Forms.TextBox DelayTextBox;
        private System.Windows.Forms.Label DelayLabel;
        private System.Windows.Forms.TextBox StepsTextBox;
        private System.Windows.Forms.Label StepsLabel;
        private System.Windows.Forms.Button MaxButton;
        private System.Windows.Forms.TextBox EndTextBox;
        private System.Windows.Forms.Label EndLabel;
        private System.Windows.Forms.Button MinButton;
        private System.Windows.Forms.TextBox StartTextBox;
        private System.Windows.Forms.Label StartLabel;
        private System.Windows.Forms.Button MoveButton;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage MoveTab;
        private System.Windows.Forms.TabPage SweepTab;
        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Panel CurrentPositionPanel;
        private System.Windows.Forms.TextBox CurrentPositionTextBox;
        private System.Windows.Forms.Label CurrentPositionLabel;
        private System.Windows.Forms.ComboBox UnitsComboBox;
        private System.Windows.Forms.Label MillisSecondsLabel;
        private System.Windows.Forms.Panel TerminalPanel;
        private System.Windows.Forms.Label TerminalLabel;
    }
}

