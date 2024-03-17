namespace Download_Renamer
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            selectDirBtn = new Button();
            runBtn = new Button();
            seasonValueInput = new NumericUpDown();
            fromRangeInput = new NumericUpDown();
            label2 = new Label();
            rangeSettingsGB = new GroupBox();
            initialSettingsGB = new GroupBox();
            createDirectoryCheckBox = new CheckBox();
            directoryGB = new GroupBox();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)seasonValueInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fromRangeInput).BeginInit();
            rangeSettingsGB.SuspendLayout();
            initialSettingsGB.SuspendLayout();
            directoryGB.SuspendLayout();
            SuspendLayout();
            // 
            // selectDirBtn
            // 
            selectDirBtn.BackgroundImage = Properties.Resources.FolderIcon;
            selectDirBtn.BackgroundImageLayout = ImageLayout.Stretch;
            selectDirBtn.Location = new Point(12, 160);
            selectDirBtn.Name = "selectDirBtn";
            selectDirBtn.Size = new Size(90, 90);
            selectDirBtn.TabIndex = 0;
            toolTip1.SetToolTip(selectDirBtn, "Select The Directory In Which You'd Like To Rename Your Files");
            selectDirBtn.UseVisualStyleBackColor = true;
            selectDirBtn.Click += selectDirBtn_Click;
            // 
            // runBtn
            // 
            runBtn.BackgroundImage = Properties.Resources.RunIcon;
            runBtn.BackgroundImageLayout = ImageLayout.Stretch;
            runBtn.Location = new Point(702, 160);
            runBtn.Name = "runBtn";
            runBtn.Size = new Size(90, 90);
            runBtn.TabIndex = 3;
            toolTip1.SetToolTip(runBtn, "Start Renaming All Of The Files In The Given Directory");
            runBtn.UseVisualStyleBackColor = true;
            runBtn.Click += runBtn_Click;
            // 
            // seasonValueInput
            // 
            seasonValueInput.Location = new Point(28, 36);
            seasonValueInput.Name = "seasonValueInput";
            seasonValueInput.Size = new Size(105, 23);
            seasonValueInput.TabIndex = 4;
            toolTip1.SetToolTip(seasonValueInput, "Specify The Season Value");
            seasonValueInput.ValueChanged += seasonValueInput_ValueChanged;
            // 
            // fromRangeInput
            // 
            fromRangeInput.Location = new Point(50, 37);
            fromRangeInput.Name = "fromRangeInput";
            fromRangeInput.Size = new Size(55, 23);
            fromRangeInput.TabIndex = 6;
            toolTip1.SetToolTip(fromRangeInput, "Specify The First Episode Value Here, Leave At 0 For Default");
            fromRangeInput.ValueChanged += fromRangeInput_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 39);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "From:";
            // 
            // rangeSettingsGB
            // 
            rangeSettingsGB.Controls.Add(label2);
            rangeSettingsGB.Controls.Add(fromRangeInput);
            rangeSettingsGB.Location = new Point(429, 160);
            rangeSettingsGB.Name = "rangeSettingsGB";
            rangeSettingsGB.Size = new Size(121, 90);
            rangeSettingsGB.TabIndex = 10;
            rangeSettingsGB.TabStop = false;
            rangeSettingsGB.Text = "Range Settings";
            // 
            // initialSettingsGB
            // 
            initialSettingsGB.Controls.Add(seasonValueInput);
            initialSettingsGB.Location = new Point(108, 160);
            initialSettingsGB.Name = "initialSettingsGB";
            initialSettingsGB.Size = new Size(162, 90);
            initialSettingsGB.TabIndex = 11;
            initialSettingsGB.TabStop = false;
            initialSettingsGB.Text = "Enter Season Value";
            // 
            // createDirectoryCheckBox
            // 
            createDirectoryCheckBox.AutoSize = true;
            createDirectoryCheckBox.Location = new Point(20, 37);
            createDirectoryCheckBox.Name = "createDirectoryCheckBox";
            createDirectoryCheckBox.Size = new Size(111, 19);
            createDirectoryCheckBox.TabIndex = 12;
            createDirectoryCheckBox.Text = "Create Directory";
            toolTip1.SetToolTip(createDirectoryCheckBox, "Creates a Directory Based On The Specified Season Value Like: \"Season \" + Value");
            createDirectoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // directoryGB
            // 
            directoryGB.Controls.Add(createDirectoryCheckBox);
            directoryGB.Location = new Point(276, 160);
            directoryGB.Name = "directoryGB";
            directoryGB.Size = new Size(147, 90);
            directoryGB.TabIndex = 13;
            directoryGB.TabStop = false;
            directoryGB.Text = "Directory Settings";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(804, 481);
            Controls.Add(directoryGB);
            Controls.Add(initialSettingsGB);
            Controls.Add(rangeSettingsGB);
            Controls.Add(runBtn);
            Controls.Add(selectDirBtn);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Download Renamer";
            ((System.ComponentModel.ISupportInitialize)seasonValueInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)fromRangeInput).EndInit();
            rangeSettingsGB.ResumeLayout(false);
            rangeSettingsGB.PerformLayout();
            initialSettingsGB.ResumeLayout(false);
            directoryGB.ResumeLayout(false);
            directoryGB.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button selectDirBtn;
        private Button runBtn;
        private NumericUpDown seasonValueInput;
        private NumericUpDown fromRangeInput;
        private Label label2;
        private GroupBox rangeSettingsGB;
        private GroupBox initialSettingsGB;
        private CheckBox createDirectoryCheckBox;
        private GroupBox directoryGB;
        private ToolTip toolTip1;
    }
}