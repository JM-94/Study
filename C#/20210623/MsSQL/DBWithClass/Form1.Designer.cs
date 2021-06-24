
namespace DBWithClass
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_Insert = new System.Windows.Forms.Button();
            this.textBox_Birth = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.custidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tBCUSTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_Select = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCUSTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(255, 12);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 26;
            this.button_delete.Text = "삭제";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(174, 12);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 25;
            this.button_update.Text = "수정";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_Insert
            // 
            this.button_Insert.Location = new System.Drawing.Point(93, 12);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(75, 23);
            this.button_Insert.TabIndex = 24;
            this.button_Insert.Text = "추가";
            this.button_Insert.UseVisualStyleBackColor = true;
            this.button_Insert.Click += new System.EventHandler(this.button_Insert_Click);
            // 
            // textBox_Birth
            // 
            this.textBox_Birth.Location = new System.Drawing.Point(218, 74);
            this.textBox_Birth.Name = "textBox_Birth";
            this.textBox_Birth.Size = new System.Drawing.Size(100, 21);
            this.textBox_Birth.TabIndex = 23;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(32, 74);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(100, 21);
            this.textBox_ID.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 21;
            this.label2.Text = "BIRTH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 20;
            this.label1.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.custidDataGridViewTextBoxColumn,
            this.birthdtDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBCUSTBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(709, 331);
            this.dataGridView1.TabIndex = 19;
            // 
            // custidDataGridViewTextBoxColumn
            // 
            this.custidDataGridViewTextBoxColumn.DataPropertyName = "cust_id";
            this.custidDataGridViewTextBoxColumn.HeaderText = "cust_id";
            this.custidDataGridViewTextBoxColumn.Name = "custidDataGridViewTextBoxColumn";
            this.custidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birthdtDataGridViewTextBoxColumn
            // 
            this.birthdtDataGridViewTextBoxColumn.DataPropertyName = "birth_dt";
            this.birthdtDataGridViewTextBoxColumn.HeaderText = "birth_dt";
            this.birthdtDataGridViewTextBoxColumn.Name = "birthdtDataGridViewTextBoxColumn";
            this.birthdtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tBCUSTBindingSource
            // 
            this.tBCUSTBindingSource.DataSource = typeof(DBWithClass.TB_CUST);
            // 
            // button_Select
            // 
            this.button_Select.Location = new System.Drawing.Point(12, 12);
            this.button_Select.Name = "button_Select";
            this.button_Select.Size = new System.Drawing.Size(75, 23);
            this.button_Select.TabIndex = 18;
            this.button_Select.Text = "조회";
            this.button_Select.UseVisualStyleBackColor = true;
            this.button_Select.Click += new System.EventHandler(this.button_Select_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.textBox_Birth);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Select);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBCUSTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.TextBox textBox_Birth;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn custidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdtDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tBCUSTBindingSource;
    }
}

