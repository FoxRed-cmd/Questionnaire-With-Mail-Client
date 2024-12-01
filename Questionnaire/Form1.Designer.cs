namespace Questionnaire
{
    partial class MainForm
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
            infoBox = new GroupBox();
            ageList = new ComboBox();
            womanBtn = new RadioButton();
            manBtn = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            educationTxt = new TextBox();
            lastNameTxt = new TextBox();
            firstNameTxt = new TextBox();
            secondNameTxt = new TextBox();
            radioNo = new RadioButton();
            radioYes = new RadioButton();
            questionTxt = new TextBox();
            addBtn = new Button();
            listBox = new GroupBox();
            dataList = new DataGridView();
            columnFirstName = new DataGridViewTextBoxColumn();
            columnSecondName = new DataGridViewTextBoxColumn();
            columnLastName = new DataGridViewTextBoxColumn();
            columnGender = new DataGridViewTextBoxColumn();
            columnAge = new DataGridViewTextBoxColumn();
            columnEducation = new DataGridViewTextBoxColumn();
            questionColumn = new DataGridViewTextBoxColumn();
            columnAnswer = new DataGridViewTextBoxColumn();
            filterByYes = new RadioButton();
            filterBox = new GroupBox();
            filterByAll = new RadioButton();
            filterByNo = new RadioButton();
            yesBtn = new RadioButton();
            noBtn = new RadioButton();
            addButton = new Button();
            noAnswerBtn = new RadioButton();
            menuStrip1 = new MenuStrip();
            FileToolStripMenuItem = new ToolStripMenuItem();
            OpenToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            SaveAsToolStripMenuItem = new ToolStripMenuItem();
            SendEmailToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            ExitToolStripMenuItem = new ToolStripMenuItem();
            CheckIncomingToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            infoBox.SuspendLayout();
            listBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataList).BeginInit();
            filterBox.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // infoBox
            // 
            infoBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            infoBox.Controls.Add(ageList);
            infoBox.Controls.Add(womanBtn);
            infoBox.Controls.Add(manBtn);
            infoBox.Controls.Add(label6);
            infoBox.Controls.Add(label5);
            infoBox.Controls.Add(label4);
            infoBox.Controls.Add(label3);
            infoBox.Controls.Add(label2);
            infoBox.Controls.Add(label1);
            infoBox.Controls.Add(educationTxt);
            infoBox.Controls.Add(lastNameTxt);
            infoBox.Controls.Add(firstNameTxt);
            infoBox.Controls.Add(secondNameTxt);
            infoBox.Location = new Point(417, 38);
            infoBox.Name = "infoBox";
            infoBox.Size = new Size(404, 301);
            infoBox.TabIndex = 0;
            infoBox.TabStop = false;
            infoBox.Text = "Сведения";
            // 
            // ageList
            // 
            ageList.BackColor = SystemColors.Highlight;
            ageList.FormattingEnabled = true;
            ageList.Location = new Point(141, 213);
            ageList.Name = "ageList";
            ageList.Size = new Size(72, 28);
            ageList.TabIndex = 6;
            // 
            // womanBtn
            // 
            womanBtn.AutoSize = true;
            womanBtn.Location = new Point(219, 167);
            womanBtn.Name = "womanBtn";
            womanBtn.Size = new Size(66, 24);
            womanBtn.TabIndex = 5;
            womanBtn.TabStop = true;
            womanBtn.Text = "Жен.";
            womanBtn.UseVisualStyleBackColor = true;
            // 
            // manBtn
            // 
            manBtn.AutoSize = true;
            manBtn.Location = new Point(141, 167);
            manBtn.Name = "manBtn";
            manBtn.Size = new Size(66, 24);
            manBtn.TabIndex = 4;
            manBtn.TabStop = true;
            manBtn.Text = "Муж.";
            manBtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 259);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 2;
            label6.Text = "Образование:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 213);
            label5.Name = "label5";
            label5.Size = new Size(81, 20);
            label5.TabIndex = 2;
            label5.Text = "Возраст:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 167);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 2;
            label4.Text = "Пол:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 121);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 2;
            label3.Text = "Отчество:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 75);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 2;
            label2.Text = "Имя:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 29);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Фамилия:";
            // 
            // educationTxt
            // 
            educationTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            educationTxt.BackColor = SystemColors.Highlight;
            educationTxt.BorderStyle = BorderStyle.FixedSingle;
            educationTxt.Location = new Point(141, 256);
            educationTxt.Name = "educationTxt";
            educationTxt.Size = new Size(257, 25);
            educationTxt.TabIndex = 7;
            // 
            // lastNameTxt
            // 
            lastNameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lastNameTxt.BackColor = SystemColors.Highlight;
            lastNameTxt.BorderStyle = BorderStyle.FixedSingle;
            lastNameTxt.Location = new Point(141, 118);
            lastNameTxt.Name = "lastNameTxt";
            lastNameTxt.Size = new Size(257, 25);
            lastNameTxt.TabIndex = 3;
            // 
            // firstNameTxt
            // 
            firstNameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            firstNameTxt.BackColor = SystemColors.Highlight;
            firstNameTxt.BorderStyle = BorderStyle.FixedSingle;
            firstNameTxt.Location = new Point(141, 72);
            firstNameTxt.Name = "firstNameTxt";
            firstNameTxt.Size = new Size(257, 25);
            firstNameTxt.TabIndex = 2;
            // 
            // secondNameTxt
            // 
            secondNameTxt.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            secondNameTxt.BackColor = SystemColors.Highlight;
            secondNameTxt.BorderStyle = BorderStyle.FixedSingle;
            secondNameTxt.Location = new Point(141, 26);
            secondNameTxt.Margin = new Padding(0);
            secondNameTxt.Name = "secondNameTxt";
            secondNameTxt.Size = new Size(257, 25);
            secondNameTxt.TabIndex = 1;
            // 
            // radioNo
            // 
            radioNo.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            radioNo.AutoSize = true;
            radioNo.Location = new Point(-403, 471);
            radioNo.Name = "radioNo";
            radioNo.Size = new Size(57, 24);
            radioNo.TabIndex = 5;
            radioNo.TabStop = true;
            radioNo.Text = "Нет";
            radioNo.UseVisualStyleBackColor = true;
            // 
            // radioYes
            // 
            radioYes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            radioYes.AutoSize = true;
            radioYes.Location = new Point(-463, 471);
            radioYes.Name = "radioYes";
            radioYes.Size = new Size(48, 24);
            radioYes.TabIndex = 5;
            radioYes.TabStop = true;
            radioYes.Text = "Да";
            radioYes.UseVisualStyleBackColor = true;
            // 
            // questionTxt
            // 
            questionTxt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            questionTxt.Location = new Point(417, 345);
            questionTxt.Multiline = true;
            questionTxt.Name = "questionTxt";
            questionTxt.Size = new Size(404, 120);
            questionTxt.TabIndex = 8;
            questionTxt.Text = "Какой-то вопрос?";
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addBtn.Location = new Point(-452, 530);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(106, 29);
            addBtn.TabIndex = 6;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // listBox
            // 
            listBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox.Controls.Add(dataList);
            listBox.Location = new Point(14, 38);
            listBox.Name = "listBox";
            listBox.Size = new Size(397, 426);
            listBox.TabIndex = 8;
            listBox.TabStop = false;
            listBox.Text = "Список";
            // 
            // dataList
            // 
            dataList.AllowUserToAddRows = false;
            dataList.AllowUserToDeleteRows = false;
            dataList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataList.Columns.AddRange(new DataGridViewColumn[] { columnFirstName, columnSecondName, columnLastName, columnGender, columnAge, columnEducation, questionColumn, columnAnswer });
            dataList.Location = new Point(7, 29);
            dataList.Name = "dataList";
            dataList.ReadOnly = true;
            dataList.RowHeadersWidth = 51;
            dataList.Size = new Size(383, 392);
            dataList.TabIndex = 0;
            // 
            // columnFirstName
            // 
            columnFirstName.HeaderText = "Имя";
            columnFirstName.MinimumWidth = 6;
            columnFirstName.Name = "columnFirstName";
            columnFirstName.ReadOnly = true;
            columnFirstName.Resizable = DataGridViewTriState.True;
            columnFirstName.Width = 125;
            // 
            // columnSecondName
            // 
            columnSecondName.HeaderText = "Фамилия";
            columnSecondName.MinimumWidth = 6;
            columnSecondName.Name = "columnSecondName";
            columnSecondName.ReadOnly = true;
            columnSecondName.Resizable = DataGridViewTriState.True;
            columnSecondName.SortMode = DataGridViewColumnSortMode.NotSortable;
            columnSecondName.Width = 125;
            // 
            // columnLastName
            // 
            columnLastName.HeaderText = "Отчество";
            columnLastName.MinimumWidth = 6;
            columnLastName.Name = "columnLastName";
            columnLastName.ReadOnly = true;
            columnLastName.Width = 125;
            // 
            // columnGender
            // 
            columnGender.HeaderText = "Пол";
            columnGender.MinimumWidth = 6;
            columnGender.Name = "columnGender";
            columnGender.ReadOnly = true;
            columnGender.Width = 125;
            // 
            // columnAge
            // 
            columnAge.HeaderText = "Возраст";
            columnAge.MinimumWidth = 6;
            columnAge.Name = "columnAge";
            columnAge.ReadOnly = true;
            columnAge.Width = 125;
            // 
            // columnEducation
            // 
            columnEducation.HeaderText = "Образование";
            columnEducation.MinimumWidth = 6;
            columnEducation.Name = "columnEducation";
            columnEducation.ReadOnly = true;
            columnEducation.Width = 125;
            // 
            // questionColumn
            // 
            questionColumn.HeaderText = "Вопрос";
            questionColumn.MinimumWidth = 6;
            questionColumn.Name = "questionColumn";
            questionColumn.ReadOnly = true;
            questionColumn.Width = 125;
            // 
            // columnAnswer
            // 
            columnAnswer.HeaderText = "Ответ";
            columnAnswer.MinimumWidth = 6;
            columnAnswer.Name = "columnAnswer";
            columnAnswer.ReadOnly = true;
            columnAnswer.Width = 125;
            // 
            // filterByYes
            // 
            filterByYes.AutoSize = true;
            filterByYes.Location = new Point(7, 58);
            filterByYes.Name = "filterByYes";
            filterByYes.Size = new Size(156, 24);
            filterByYes.TabIndex = 13;
            filterByYes.TabStop = true;
            filterByYes.Text = "С ответом \"Да\"";
            filterByYes.UseVisualStyleBackColor = true;
            // 
            // filterBox
            // 
            filterBox.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            filterBox.Controls.Add(filterByAll);
            filterBox.Controls.Add(filterByNo);
            filterBox.Controls.Add(filterByYes);
            filterBox.Location = new Point(14, 471);
            filterBox.Name = "filterBox";
            filterBox.Size = new Size(397, 88);
            filterBox.TabIndex = 9;
            filterBox.TabStop = false;
            filterBox.Text = "Фильтр";
            // 
            // filterByAll
            // 
            filterByAll.AutoSize = true;
            filterByAll.Location = new Point(7, 28);
            filterByAll.Name = "filterByAll";
            filterByAll.Size = new Size(57, 24);
            filterByAll.TabIndex = 12;
            filterByAll.TabStop = true;
            filterByAll.Text = "Все";
            filterByAll.UseVisualStyleBackColor = true;
            // 
            // filterByNo
            // 
            filterByNo.AutoSize = true;
            filterByNo.Location = new Point(164, 58);
            filterByNo.Name = "filterByNo";
            filterByNo.Size = new Size(165, 24);
            filterByNo.TabIndex = 14;
            filterByNo.TabStop = true;
            filterByNo.Text = "С ответом \"Нет\"";
            filterByNo.UseVisualStyleBackColor = true;
            // 
            // yesBtn
            // 
            yesBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            yesBtn.AutoSize = true;
            yesBtn.Location = new Point(575, 471);
            yesBtn.Name = "yesBtn";
            yesBtn.Size = new Size(48, 24);
            yesBtn.TabIndex = 9;
            yesBtn.TabStop = true;
            yesBtn.Text = "Да";
            yesBtn.UseVisualStyleBackColor = true;
            // 
            // noBtn
            // 
            noBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            noBtn.AutoSize = true;
            noBtn.Location = new Point(629, 471);
            noBtn.Name = "noBtn";
            noBtn.Size = new Size(57, 24);
            noBtn.TabIndex = 10;
            noBtn.TabStop = true;
            noBtn.Text = "Нет";
            noBtn.UseVisualStyleBackColor = true;
            // 
            // addButton
            // 
            addButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Location = new Point(709, 530);
            addButton.Name = "addButton";
            addButton.Size = new Size(106, 29);
            addButton.TabIndex = 11;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += AddButtonClick;
            // 
            // noAnswerBtn
            // 
            noAnswerBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            noAnswerBtn.AutoSize = true;
            noAnswerBtn.Location = new Point(692, 471);
            noAnswerBtn.Name = "noAnswerBtn";
            noAnswerBtn.Size = new Size(129, 24);
            noAnswerBtn.TabIndex = 10;
            noAnswerBtn.TabStop = true;
            noAnswerBtn.Text = "Воздержался";
            noAnswerBtn.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.DarkCyan;
            menuStrip1.Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            menuStrip1.GripMargin = new Padding(0, 20, 0, 20);
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileToolStripMenuItem });
            menuStrip1.LayoutStyle = ToolStripLayoutStyle.Flow;
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Margin = new Padding(0, 20, 0, 20);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(0);
            menuStrip1.Size = new Size(835, 34);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            FileToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenToolStripMenuItem, toolStripSeparator1, SaveAsToolStripMenuItem, toolStripSeparator3, SendEmailToolStripMenuItem, CheckIncomingToolStripMenuItem, toolStripSeparator2, ExitToolStripMenuItem });
            FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            FileToolStripMenuItem.Padding = new Padding(5);
            FileToolStripMenuItem.Size = new Size(59, 34);
            FileToolStripMenuItem.Text = "Файл";
            // 
            // OpenToolStripMenuItem
            // 
            OpenToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            OpenToolStripMenuItem.Size = new Size(254, 26);
            OpenToolStripMenuItem.Text = "Открыть";
            OpenToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
            OpenToolStripMenuItem.Click += OpenToolStripMenuItemClick;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(251, 6);
            // 
            // SaveAsToolStripMenuItem
            // 
            SaveAsToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            SaveAsToolStripMenuItem.Size = new Size(254, 26);
            SaveAsToolStripMenuItem.Text = "Сохранить как...";
            SaveAsToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
            SaveAsToolStripMenuItem.Click += SaveAsToolStripMenuItemClick;
            // 
            // SendEmailToolStripMenuItem
            // 
            SendEmailToolStripMenuItem.Name = "SendEmailToolStripMenuItem";
            SendEmailToolStripMenuItem.Size = new Size(254, 26);
            SendEmailToolStripMenuItem.Text = "Отправить по Email";
            SendEmailToolStripMenuItem.Click += SendEmailToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(251, 6);
            // 
            // ExitToolStripMenuItem
            // 
            ExitToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
            ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            ExitToolStripMenuItem.Size = new Size(254, 26);
            ExitToolStripMenuItem.Text = "Выход";
            ExitToolStripMenuItem.TextImageRelation = TextImageRelation.TextBeforeImage;
            ExitToolStripMenuItem.Click += ExitToolStripMenuItemClick;
            // 
            // CheckIncomingToolStripMenuItem
            // 
            CheckIncomingToolStripMenuItem.Name = "CheckIncomingToolStripMenuItem";
            CheckIncomingToolStripMenuItem.Size = new Size(254, 26);
            CheckIncomingToolStripMenuItem.Text = "Проверить входящие";
            CheckIncomingToolStripMenuItem.Click += CheckIncomingToolStripMenuItemClick;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(251, 6);
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(835, 571);
            Controls.Add(addButton);
            Controls.Add(noAnswerBtn);
            Controls.Add(noBtn);
            Controls.Add(yesBtn);
            Controls.Add(filterBox);
            Controls.Add(listBox);
            Controls.Add(addBtn);
            Controls.Add(radioYes);
            Controls.Add(radioNo);
            Controls.Add(infoBox);
            Controls.Add(questionTxt);
            Controls.Add(menuStrip1);
            Font = new Font("Cascadia Mono", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = SystemColors.ActiveCaptionText;
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(853, 550);
            Name = "MainForm";
            Text = "Form1";
            FormClosing += MainFormFormClosing;
            infoBox.ResumeLayout(false);
            infoBox.PerformLayout();
            listBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataList).EndInit();
            filterBox.ResumeLayout(false);
            filterBox.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox infoBox;
        private Label label1;
        private TextBox secondNameTxt;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox educationTxt;
        private TextBox lastNameTxt;
        private TextBox firstNameTxt;
        private RadioButton womanBtn;
        private RadioButton manBtn;
        private ComboBox ageList;
        private TextBox questionTxt;
        private RadioButton radioYes;
        private RadioButton radioNo;
        private Button addBtn;
        private GroupBox listBox;
        private RadioButton filterByYes;
        private GroupBox filterBox;
        private RadioButton filterByNo;
        private RadioButton yesBtn;
        private RadioButton noBtn;
        private Button addButton;
        private RadioButton filterByAll;
        private DataGridView dataList;
        private RadioButton noAnswerBtn;
        private DataGridViewTextBoxColumn columnFirstName;
        private DataGridViewTextBoxColumn columnSecondName;
        private DataGridViewTextBoxColumn columnLastName;
        private DataGridViewTextBoxColumn columnGender;
        private DataGridViewTextBoxColumn columnAge;
        private DataGridViewTextBoxColumn columnEducation;
        private DataGridViewTextBoxColumn questionColumn;
        private DataGridViewTextBoxColumn columnAnswer;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileToolStripMenuItem;
        private ToolStripMenuItem OpenToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem SaveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem ExitToolStripMenuItem;
        private ToolStripMenuItem SendEmailToolStripMenuItem;
        private ToolStripMenuItem CheckIncomingToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
    }
}
