namespace Library_session6
{
    partial class Add_a_user
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
            FNamelabel = new Label();
            userinftextbox = new TextBox();
            cellphonelabel = new Label();
            LNamelabel = new Label();
            EmailLabel = new Label();
            NameUserTxt = new TextBox();
            Cellphoneusertxt = new TextBox();
            Emailtxt = new TextBox();
            Lnameusertxt = new TextBox();
            UserBackbutton = new Button();
            UserButtonn = new Button();
            Usergridview = new DataGridView();
            UserCallApi = new Button();
            ReserveBackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Usergridview).BeginInit();
            SuspendLayout();
            // 
            // FNamelabel
            // 
            FNamelabel.AutoSize = true;
            FNamelabel.Location = new Point(23, 113);
            FNamelabel.Name = "FNamelabel";
            FNamelabel.Size = new Size(134, 32);
            FNamelabel.TabIndex = 0;
            FNamelabel.Text = "First Name:";
            // 
            // userinftextbox
            // 
            userinftextbox.BackColor = SystemColors.ActiveCaption;
            userinftextbox.Font = new Font("Segoe UI Semibold", 10.875F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            userinftextbox.Location = new Point(23, 12);
            userinftextbox.Name = "userinftextbox";
            userinftextbox.Size = new Size(571, 46);
            userinftextbox.TabIndex = 1;
            userinftextbox.Text = "Please insert the user's information";
            // 
            // cellphonelabel
            // 
            cellphonelabel.AutoSize = true;
            cellphonelabel.Location = new Point(26, 259);
            cellphonelabel.Name = "cellphonelabel";
            cellphonelabel.Size = new Size(128, 32);
            cellphonelabel.TabIndex = 2;
            cellphonelabel.Text = "Cellphone:";
            // 
            // LNamelabel
            // 
            LNamelabel.AutoSize = true;
            LNamelabel.Location = new Point(23, 186);
            LNamelabel.Name = "LNamelabel";
            LNamelabel.Size = new Size(131, 32);
            LNamelabel.TabIndex = 3;
            LNamelabel.Text = "Last Name:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(29, 335);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(76, 32);
            EmailLabel.TabIndex = 5;
            EmailLabel.Text = "Email:";
            // 
            // NameUserTxt
            // 
            NameUserTxt.Location = new Point(255, 110);
            NameUserTxt.Name = "NameUserTxt";
            NameUserTxt.Size = new Size(320, 39);
            NameUserTxt.TabIndex = 6;
            // 
            // Cellphoneusertxt
            // 
            Cellphoneusertxt.Location = new Point(255, 259);
            Cellphoneusertxt.Name = "Cellphoneusertxt";
            Cellphoneusertxt.Size = new Size(320, 39);
            Cellphoneusertxt.TabIndex = 7;
            // 
            // Emailtxt
            // 
            Emailtxt.Location = new Point(255, 332);
            Emailtxt.Name = "Emailtxt";
            Emailtxt.Size = new Size(320, 39);
            Emailtxt.TabIndex = 8;
            // 
            // Lnameusertxt
            // 
            Lnameusertxt.Location = new Point(255, 179);
            Lnameusertxt.Name = "Lnameusertxt";
            Lnameusertxt.Size = new Size(320, 39);
            Lnameusertxt.TabIndex = 10;
            // 
            // UserBackbutton
            // 
            UserBackbutton.BackColor = SystemColors.ButtonShadow;
            UserBackbutton.CausesValidation = false;
            UserBackbutton.Location = new Point(39, 464);
            UserBackbutton.Name = "UserBackbutton";
            UserBackbutton.Size = new Size(174, 43);
            UserBackbutton.TabIndex = 13;
            UserBackbutton.Text = "Back";
            UserBackbutton.UseVisualStyleBackColor = false;
            UserBackbutton.Click += UserBackbutton_Click;
            // 
            // UserButtonn
            // 
            UserButtonn.BackColor = SystemColors.ActiveCaption;
            UserButtonn.Location = new Point(643, 503);
            UserButtonn.Name = "UserButtonn";
            UserButtonn.Size = new Size(201, 54);
            UserButtonn.TabIndex = 14;
            UserButtonn.Text = "Done";
            UserButtonn.UseVisualStyleBackColor = false;
            UserButtonn.Click += UserButtonn_Click;
            // 
            // Usergridview
            // 
            Usergridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Usergridview.Location = new Point(874, 52);
            Usergridview.Name = "Usergridview";
            Usergridview.RowHeadersWidth = 82;
            Usergridview.RowTemplate.Height = 41;
            Usergridview.Size = new Size(489, 300);
            Usergridview.TabIndex = 15;
            // 
            // UserCallApi
            // 
            UserCallApi.BackColor = Color.AliceBlue;
            UserCallApi.Location = new Point(659, 414);
            UserCallApi.Name = "UserCallApi";
            UserCallApi.Size = new Size(161, 53);
            UserCallApi.TabIndex = 16;
            UserCallApi.Text = "Call Api";
            UserCallApi.UseVisualStyleBackColor = false;
            UserCallApi.Click += UserCallApi_Click;
            // 
            // ReserveBackButton
            // 
            ReserveBackButton.BackColor = Color.SandyBrown;
            ReserveBackButton.Location = new Point(913, 451);
            ReserveBackButton.Name = "ReserveBackButton";
            ReserveBackButton.Size = new Size(233, 68);
            ReserveBackButton.TabIndex = 17;
            ReserveBackButton.Text = "Reserve a Book!";
            ReserveBackButton.UseVisualStyleBackColor = false;
            ReserveBackButton.Click += ReserveBackButton_Click;
            // 
            // Add_a_user
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1395, 584);
            Controls.Add(ReserveBackButton);
            Controls.Add(UserCallApi);
            Controls.Add(Usergridview);
            Controls.Add(UserButtonn);
            Controls.Add(UserBackbutton);
            Controls.Add(Lnameusertxt);
            Controls.Add(Emailtxt);
            Controls.Add(Cellphoneusertxt);
            Controls.Add(NameUserTxt);
            Controls.Add(EmailLabel);
            Controls.Add(LNamelabel);
            Controls.Add(cellphonelabel);
            Controls.Add(userinftextbox);
            Controls.Add(FNamelabel);
            Name = "Add_a_user";
            Text = "Add_a_user";
            ((System.ComponentModel.ISupportInitialize)Usergridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FNamelabel;
        private TextBox userinftextbox;
        private Label cellphonelabel;
        private Label LNamelabel;
        private Label EmailLabel;
        private TextBox NameUserTxt;
        private TextBox Cellphoneusertxt;
        private TextBox Emailtxt;
        private TextBox Lnameusertxt;
        private Button UserBackbutton;
        private Button UserButtonn;
        private DataGridView Usergridview;
        private Button UserCallApi;
        private Button ReserveBackButton;
    }
}