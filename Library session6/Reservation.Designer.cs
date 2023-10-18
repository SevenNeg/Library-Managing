namespace Library_session6
{
    partial class Reservation
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
            SubcodeTxt = new TextBox();
            BookCodeTxt = new TextBox();
            label1 = new Label();
            IdLabel = new Label();
            reservebookLabel = new Label();
            ReserveButton = new Button();
            Addingbutton = new Button();
            NameGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)NameGridView).BeginInit();
            SuspendLayout();
            // 
            // SubcodeTxt
            // 
            SubcodeTxt.Location = new Point(531, 200);
            SubcodeTxt.Name = "SubcodeTxt";
            SubcodeTxt.Size = new Size(269, 39);
            SubcodeTxt.TabIndex = 0;
            // 
            // BookCodeTxt
            // 
            BookCodeTxt.Location = new Point(531, 276);
            BookCodeTxt.Name = "BookCodeTxt";
            BookCodeTxt.Size = new Size(269, 39);
            BookCodeTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 21);
            label1.Name = "label1";
            label1.Size = new Size(634, 59);
            label1.TabIndex = 2;
            label1.Text = "Please enter these information:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.BackColor = Color.SeaShell;
            IdLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            IdLabel.Location = new Point(24, 202);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(186, 37);
            IdLabel.TabIndex = 3;
            IdLabel.Text = "Your Subcode:";
            // 
            // reservebookLabel
            // 
            reservebookLabel.AutoSize = true;
            reservebookLabel.BackColor = Color.SeaShell;
            reservebookLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            reservebookLabel.Location = new Point(24, 275);
            reservebookLabel.Name = "reservebookLabel";
            reservebookLabel.Size = new Size(469, 37);
            reservebookLabel.TabIndex = 4;
            reservebookLabel.Text = "Code of the book you want to reserve:";
            // 
            // ReserveButton
            // 
            ReserveButton.Location = new Point(643, 435);
            ReserveButton.Name = "ReserveButton";
            ReserveButton.Size = new Size(181, 61);
            ReserveButton.TabIndex = 5;
            ReserveButton.Text = "Done";
            ReserveButton.UseVisualStyleBackColor = true;
            ReserveButton.Click += ReserveButton_Click;
            // 
            // Addingbutton
            // 
            Addingbutton.BackColor = Color.LightSalmon;
            Addingbutton.Location = new Point(50, 435);
            Addingbutton.Name = "Addingbutton";
            Addingbutton.Size = new Size(181, 61);
            Addingbutton.TabIndex = 6;
            Addingbutton.Text = "Add me first";
            Addingbutton.UseVisualStyleBackColor = false;
            Addingbutton.Click += Addingbutton_Click;
            // 
            // NameGridView
            // 
            NameGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NameGridView.Location = new Point(978, 90);
            NameGridView.Name = "NameGridView";
            NameGridView.RowHeadersWidth = 82;
            NameGridView.RowTemplate.Height = 41;
            NameGridView.Size = new Size(390, 353);
            NameGridView.TabIndex = 7;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1399, 536);
            Controls.Add(NameGridView);
            Controls.Add(Addingbutton);
            Controls.Add(ReserveButton);
            Controls.Add(reservebookLabel);
            Controls.Add(IdLabel);
            Controls.Add(label1);
            Controls.Add(BookCodeTxt);
            Controls.Add(SubcodeTxt);
            Name = "Reservation";
            Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)NameGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SubcodeTxt;
        private TextBox BookCodeTxt;
        private Label label1;
        private Label IdLabel;
        private Label reservebookLabel;
        private Button ReserveButton;
        private Button Addingbutton;
        private DataGridView NameGridView;
    }
}