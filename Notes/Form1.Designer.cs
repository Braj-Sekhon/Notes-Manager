namespace Notes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            fileNameBox = new TextBox();
            textBox = new TextBox();
            folderBox = new TextBox();
            deleteButton = new Button();
            clearButton = new Button();
            loadButton = new Button();
            saveButton = new Button();
            fcTimeBox = new Label();
            toolStrip = new ToolStrip();
            directoriesDropDown = new ToolStripDropDownButton();
            encryptButton = new Button();
            decryptButton = new Button();
            encryptCode = new TextBox();
            toolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // fileNameBox
            // 
            fileNameBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            fileNameBox.CharacterCasing = CharacterCasing.Upper;
            fileNameBox.Location = new Point(12, 381);
            fileNameBox.Multiline = true;
            fileNameBox.Name = "fileNameBox";
            fileNameBox.PlaceholderText = "File Name Here";
            fileNameBox.ScrollBars = ScrollBars.Horizontal;
            fileNameBox.Size = new Size(212, 60);
            fileNameBox.TabIndex = 0;
            fileNameBox.WordWrap = false;
            fileNameBox.TextChanged += fileNameBox_TextChanged;
            // 
            // textBox
            // 
            textBox.AcceptsReturn = true;
            textBox.AcceptsTab = true;
            textBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox.Location = new Point(12, 30);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.PlaceholderText = "Type Text Here";
            textBox.ScrollBars = ScrollBars.Vertical;
            textBox.Size = new Size(776, 310);
            textBox.TabIndex = 1;
            // 
            // folderBox
            // 
            folderBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            folderBox.CharacterCasing = CharacterCasing.Upper;
            folderBox.Location = new Point(402, 381);
            folderBox.Multiline = true;
            folderBox.Name = "folderBox";
            folderBox.PlaceholderText = "Folder/User Name Here";
            folderBox.ScrollBars = ScrollBars.Horizontal;
            folderBox.Size = new Size(386, 64);
            folderBox.TabIndex = 2;
            folderBox.Text = "NOTES";
            folderBox.WordWrap = false;
            folderBox.TextChanged += folderBox_TextChanged;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            deleteButton.BackColor = Color.Red;
            deleteButton.Location = new Point(700, 346);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(88, 29);
            deleteButton.TabIndex = 4;
            deleteButton.Text = "Delete File";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearButton.BackColor = Color.LightSalmon;
            clearButton.Location = new Point(606, 346);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(88, 29);
            clearButton.TabIndex = 5;
            clearButton.Text = "Clear Text";
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // loadButton
            // 
            loadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            loadButton.BackColor = Color.Yellow;
            loadButton.Location = new Point(512, 346);
            loadButton.Name = "loadButton";
            loadButton.Size = new Size(88, 29);
            loadButton.TabIndex = 6;
            loadButton.Text = "Load File";
            loadButton.UseVisualStyleBackColor = false;
            loadButton.Click += loadButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            saveButton.BackColor = Color.Lime;
            saveButton.Location = new Point(418, 346);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(88, 29);
            saveButton.TabIndex = 7;
            saveButton.Text = "Save File";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // fcTimeBox
            // 
            fcTimeBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            fcTimeBox.BackColor = SystemColors.ActiveCaptionText;
            fcTimeBox.BorderStyle = BorderStyle.FixedSingle;
            fcTimeBox.Font = new Font("Trebuchet MS", 10F);
            fcTimeBox.ForeColor = SystemColors.ButtonFace;
            fcTimeBox.Location = new Point(12, 347);
            fcTimeBox.Name = "fcTimeBox";
            fcTimeBox.Size = new Size(212, 28);
            fcTimeBox.TabIndex = 8;
            fcTimeBox.Text = "Time of File Creation";
            fcTimeBox.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(20, 20);
            toolStrip.Items.AddRange(new ToolStripItem[] { directoriesDropDown });
            toolStrip.Location = new Point(0, 0);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(800, 27);
            toolStrip.TabIndex = 11;
            // 
            // directoriesDropDown
            // 
            directoriesDropDown.DisplayStyle = ToolStripItemDisplayStyle.Text;
            directoriesDropDown.Image = (Image)resources.GetObject("directoriesDropDown.Image");
            directoriesDropDown.ImageTransparentColor = Color.Magenta;
            directoriesDropDown.Name = "directoriesDropDown";
            directoriesDropDown.Size = new Size(95, 24);
            directoriesDropDown.Text = "Directories";
            directoriesDropDown.ToolTipText = "Diplays Directories, Click to Select";
            directoriesDropDown.Click += directoriesDropDown_Click;
            // 
            // encryptButton
            // 
            encryptButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            encryptButton.BackColor = Color.Violet;
            encryptButton.Location = new Point(324, 346);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(88, 29);
            encryptButton.TabIndex = 12;
            encryptButton.Text = "Encrypt";
            encryptButton.UseVisualStyleBackColor = false;
            encryptButton.Click += encryptButton_Click;
            // 
            // decryptButton
            // 
            decryptButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            decryptButton.BackColor = Color.SlateBlue;
            decryptButton.Location = new Point(230, 346);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(88, 29);
            decryptButton.TabIndex = 13;
            decryptButton.Text = "Decrypt";
            decryptButton.UseVisualStyleBackColor = false;
            decryptButton.Click += decryptButton_Click;
            // 
            // encryptCode
            // 
            encryptCode.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            encryptCode.CharacterCasing = CharacterCasing.Upper;
            encryptCode.Location = new Point(230, 381);
            encryptCode.Multiline = true;
            encryptCode.Name = "encryptCode";
            encryptCode.PlaceholderText = "Encryption Code Here";
            encryptCode.ScrollBars = ScrollBars.Horizontal;
            encryptCode.Size = new Size(166, 60);
            encryptCode.TabIndex = 14;
            encryptCode.WordWrap = false;
            encryptCode.TextChanged += encryptCode_TextChanged;
            encryptCode.MouseLeave += encryptCode_MouseLeave;
            encryptCode.MouseHover += encryptCode_MouseHover;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(encryptCode);
            Controls.Add(decryptButton);
            Controls.Add(encryptButton);
            Controls.Add(toolStrip);
            Controls.Add(fcTimeBox);
            Controls.Add(saveButton);
            Controls.Add(loadButton);
            Controls.Add(clearButton);
            Controls.Add(deleteButton);
            Controls.Add(folderBox);
            Controls.Add(textBox);
            Controls.Add(fileNameBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Notes Manager";
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fileNameBox;
        private TextBox textBox;
        private TextBox folderBox;
        private Button deleteButton;
        private Button clearButton;
        private Button loadButton;
        private Button saveButton;
        private Label fcTimeBox;
        private ToolStrip toolStrip;
        private ToolStripDropDownButton directoriesDropDown;
        private Button encryptButton;
        private Button decryptButton;
        private TextBox encryptCode;
    }
}
