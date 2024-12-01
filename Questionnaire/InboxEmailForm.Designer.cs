namespace Questionnaire
{
    partial class InboxEmailForm
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
            InboxTitle = new Label();
            inboxList = new ListView();
            columnFrom = new ColumnHeader();
            columnDate = new ColumnHeader();
            columnFile = new ColumnHeader();
            SaveButton = new Button();
            SuspendLayout();
            // 
            // InboxTitle
            // 
            InboxTitle.AutoSize = true;
            InboxTitle.Location = new Point(14, 9);
            InboxTitle.Name = "InboxTitle";
            InboxTitle.Size = new Size(261, 20);
            InboxTitle.TabIndex = 1;
            InboxTitle.Text = "Входящие сообщения с данными";
            // 
            // inboxList
            // 
            inboxList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            inboxList.Columns.AddRange(new ColumnHeader[] { columnFrom, columnDate, columnFile });
            inboxList.Location = new Point(12, 32);
            inboxList.Name = "inboxList";
            inboxList.Size = new Size(429, 267);
            inboxList.TabIndex = 2;
            inboxList.UseCompatibleStateImageBehavior = false;
            inboxList.View = View.Details;
            // 
            // columnFrom
            // 
            columnFrom.Text = "Отправитель";
            // 
            // columnDate
            // 
            columnDate.Text = "Дата";
            // 
            // columnFile
            // 
            columnFile.Text = "Файл";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.Location = new Point(327, 305);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(114, 29);
            SaveButton.TabIndex = 3;
            SaveButton.Text = "Сохранить";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButtonClick;
            // 
            // InboxEmailForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 340);
            Controls.Add(SaveButton);
            Controls.Add(inboxList);
            Controls.Add(InboxTitle);
            Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "InboxEmailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Входящие";
            Load += InboxEmailFormLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label InboxTitle;
        private ListView inboxList;
        private ColumnHeader columnFrom;
        private ColumnHeader columnDate;
        private ColumnHeader columnFile;
        private Button SaveButton;
    }
}