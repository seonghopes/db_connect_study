namespace dbConnect
{
    partial class ExecuteNonQuery
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
            btnCreate = new Button();
            label1 = new Label();
            label2 = new Label();
            tbId = new TextBox();
            tbName = new TextBox();
            btnInsert = new Button();
            btnDrop = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(69, 23);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(193, 50);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "테이블 생성";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 105);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 1;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 158);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "Name :";
            // 
            // tbId
            // 
            tbId.Location = new Point(128, 102);
            tbId.Name = "tbId";
            tbId.Size = new Size(134, 23);
            tbId.TabIndex = 2;
            // 
            // tbName
            // 
            tbName.Location = new Point(128, 155);
            tbName.Name = "tbName";
            tbName.Size = new Size(134, 23);
            tbName.TabIndex = 2;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(69, 218);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(193, 50);
            btnInsert.TabIndex = 0;
            btnInsert.Text = "테이블 삽입";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDrop
            // 
            btnDrop.Location = new Point(69, 301);
            btnDrop.Name = "btnDrop";
            btnDrop.Size = new Size(193, 50);
            btnDrop.TabIndex = 0;
            btnDrop.Text = "테이블 삭제";
            btnDrop.UseVisualStyleBackColor = true;
            btnDrop.Click += btnDrop_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(69, 378);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(193, 50);
            btnExit.TabIndex = 0;
            btnExit.Text = "종료";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // ExecuteNonQuery
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 456);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnExit);
            Controls.Add(btnDrop);
            Controls.Add(btnInsert);
            Controls.Add(btnCreate);
            Name = "ExecuteNonQuery";
            Text = "ExecuteNonQuery";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Label label1;
        private Label label2;
        private TextBox tbId;
        private TextBox tbName;
        private Button btnInsert;
        private Button btnDrop;
        private Button btnExit;
    }
}