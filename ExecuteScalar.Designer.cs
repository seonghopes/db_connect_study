namespace dbConnect
{
    partial class ExecuteScalar
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
            tbTxt_NO = new TextBox();
            label1 = new Label();
            btnSearch = new Button();
            btbExit = new Button();
            SuspendLayout();
            // 
            // tbTxt_NO
            // 
            tbTxt_NO.Location = new Point(179, 64);
            tbTxt_NO.Name = "tbTxt_NO";
            tbTxt_NO.Size = new Size(135, 23);
            tbTxt_NO.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 67);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "수험번호 :";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(161, 130);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(98, 44);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "조회";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btbExit
            // 
            btbExit.Location = new Point(161, 206);
            btbExit.Name = "btbExit";
            btbExit.Size = new Size(98, 41);
            btbExit.TabIndex = 2;
            btbExit.Text = "종료";
            btbExit.UseVisualStyleBackColor = true;
            btbExit.Click += btbExit_Click;
            // 
            // ExecuteScalar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 277);
            Controls.Add(btbExit);
            Controls.Add(btnSearch);
            Controls.Add(label1);
            Controls.Add(tbTxt_NO);
            Name = "ExecuteScalar";
            Text = "ExecuteScalar";
            Load += ExecuteScalar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbTxt_NO;
        private Label label1;
        private Button btnSearch;
        private Button btbExit;
    }
}