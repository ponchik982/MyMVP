namespace MyMVP
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.UsersList = new System.Windows.Forms.DataGridView();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameFiltr = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.ComboBoxFiltr = new System.Windows.Forms.ComboBox();
            this.userCard = new UserCard.UserCard();
            ((System.ComponentModel.ISupportInitialize)(this.UsersList)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersList
            // 
            this.UsersList.Location = new System.Drawing.Point(29, 38);
            this.UsersList.MultiSelect = false;
            this.UsersList.Name = "UsersList";
            this.UsersList.ReadOnly = true;
            this.UsersList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersList.Size = new System.Drawing.Size(407, 207);
            this.UsersList.TabIndex = 0;
            this.UsersList.SelectionChanged += new System.EventHandler(this.UsersList_SelectionChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(29, 267);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // NameFiltr
            // 
            this.NameFiltr.Location = new System.Drawing.Point(135, 294);
            this.NameFiltr.Name = "NameFiltr";
            this.NameFiltr.Size = new System.Drawing.Size(100, 23);
            this.NameFiltr.TabIndex = 2;
            this.NameFiltr.Text = "Отфильтровать";
            this.NameFiltr.UseVisualStyleBackColor = true;
            this.NameFiltr.Click += new System.EventHandler(this.NameFiltr_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(29, 293);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(100, 23);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Сбросить";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // ComboBoxFiltr
            // 
            this.ComboBoxFiltr.FormattingEnabled = true;
            this.ComboBoxFiltr.Items.AddRange(new object[] {
            "Имя",
            "Логин"});
            this.ComboBoxFiltr.Location = new System.Drawing.Point(135, 267);
            this.ComboBoxFiltr.Name = "ComboBoxFiltr";
            this.ComboBoxFiltr.Size = new System.Drawing.Size(100, 21);
            this.ComboBoxFiltr.TabIndex = 4;
            // 
            // userCard
            // 
            this.userCard.Location = new System.Drawing.Point(502, 38);
            this.userCard.Name = "userCard";
            this.userCard.Size = new System.Drawing.Size(402, 237);
            this.userCard.TabIndex = 5;
            this.userCard.Load += new System.EventHandler(this.userCard_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 371);
            this.Controls.Add(this.userCard);
            this.Controls.Add(this.ComboBoxFiltr);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.NameFiltr);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.UsersList);
            this.Name = "Form1";
            this.Text = "Users";
            ((System.ComponentModel.ISupportInitialize)(this.UsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersList;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button NameFiltr;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.ComboBox ComboBoxFiltr;
        private UserCard.UserCard userCard;
    }
}

