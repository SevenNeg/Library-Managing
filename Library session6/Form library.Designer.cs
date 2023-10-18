namespace Library_session6
{
    partial class Main
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
            textBoxwelcome = new TextBox();
            textBoxchoose = new TextBox();
            MaincheckedListBox = new CheckedListBox();
            continuebutton = new Button();
            SuspendLayout();
            // 
            // textBoxwelcome
            // 
            textBoxwelcome.Font = new Font("Lucida Fax", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxwelcome.Location = new Point(234, 41);
            textBoxwelcome.Name = "textBoxwelcome";
            textBoxwelcome.Size = new Size(710, 45);
            textBoxwelcome.TabIndex = 0;
            textBoxwelcome.Text = "Welcome to the library Managing system!";
            // 
            // textBoxchoose
            // 
            textBoxchoose.BackColor = SystemColors.Info;
            textBoxchoose.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxchoose.Location = new Point(306, 148);
            textBoxchoose.Multiline = true;
            textBoxchoose.Name = "textBoxchoose";
            textBoxchoose.Size = new Size(537, 44);
            textBoxchoose.TabIndex = 1;
            textBoxchoose.Text = "Choose what are you going to do next:";
            // 
            // MaincheckedListBox
            // 
            MaincheckedListBox.Font = new Font("Lucida Fax", 9F, FontStyle.Regular, GraphicsUnit.Point);
            MaincheckedListBox.FormattingEnabled = true;
            MaincheckedListBox.Items.AddRange(new object[] { "Add a user", "Add a book", "Reserve books for a user" });
            MaincheckedListBox.Location = new Point(359, 251);
            MaincheckedListBox.Name = "MaincheckedListBox";
            MaincheckedListBox.Size = new Size(400, 103);
            MaincheckedListBox.TabIndex = 2;
            // 
            // continuebutton
            // 
            continuebutton.BackColor = SystemColors.ButtonShadow;
            continuebutton.Location = new Point(411, 445);
            continuebutton.Name = "continuebutton";
            continuebutton.Size = new Size(312, 58);
            continuebutton.TabIndex = 13;
            continuebutton.Text = "Continue";
            continuebutton.UseVisualStyleBackColor = false;
            continuebutton.Click += continuebutton_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1166, 592);
            Controls.Add(continuebutton);
            Controls.Add(MaincheckedListBox);
            Controls.Add(textBoxchoose);
            Controls.Add(textBoxwelcome);
            Name = "Main";
            Text = "Form library";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxwelcome;
        private TextBox textBoxchoose;
        private CheckedListBox MaincheckedListBox;
        private Button continuebutton;
    }
}