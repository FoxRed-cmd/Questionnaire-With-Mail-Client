namespace Questionnaire
{
    partial class EmailSendForm
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
            Label label1;
            Label label2;
            txtEmail = new TextBox();
            txtMessage = new TextBox();
            btnAdd = new Button();
            btnSend = new Button();
            txtSubject = new TextBox();
            addFileName = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Mono", 9F);
            label1.Location = new Point(16, 12);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Mono", 9F);
            label2.Location = new Point(16, 65);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 6;
            label2.Text = "Тема";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Cascadia Mono", 9F);
            txtEmail.Location = new Point(16, 35);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(365, 25);
            txtEmail.TabIndex = 0;
            // 
            // txtMessage
            // 
            txtMessage.Font = new Font("Cascadia Mono", 9F);
            txtMessage.Location = new Point(16, 121);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(365, 131);
            txtMessage.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Image = Properties.Resources.add_attachment;
            btnAdd.Location = new Point(195, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(39, 29);
            btnAdd.TabIndex = 3;
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAddClick;
            // 
            // btnSend
            // 
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnSend.Location = new Point(240, 258);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(141, 29);
            btnSend.TabIndex = 4;
            btnSend.Text = "Отправить";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += BtnSendClick;
            // 
            // txtSubject
            // 
            txtSubject.Font = new Font("Cascadia Mono", 9F);
            txtSubject.Location = new Point(16, 88);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(365, 25);
            txtSubject.TabIndex = 1;
            // 
            // addFileName
            // 
            addFileName.AutoSize = true;
            addFileName.Font = new Font("Cascadia Mono", 9F);
            addFileName.Location = new Point(16, 262);
            addFileName.Name = "addFileName";
            addFileName.Size = new Size(81, 20);
            addFileName.TabIndex = 7;
            addFileName.Text = "FileName";
            // 
            // EmailSendForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 297);
            Controls.Add(addFileName);
            Controls.Add(label2);
            Controls.Add(txtSubject);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Controls.Add(btnAdd);
            Controls.Add(txtMessage);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "EmailSendForm";
            Text = "Отправка по Email";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private TextBox txtMessage;
        private Button btnAdd;
        private Button btnSend;
        private TextBox txtSubject;
        private Label addFileName;
    }
}