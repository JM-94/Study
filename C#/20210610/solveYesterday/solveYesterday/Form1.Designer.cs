
namespace solveYesterday
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
            this.button_readCSV = new System.Windows.Forms.Button();
            this.button_writeCSV = new System.Windows.Forms.Button();
            this.dataGridView_students = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_hakbeon = new System.Windows.Forms.Label();
            this.label_hakgwa = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_hakbeon = new System.Windows.Forms.TextBox();
            this.textBox_hakgwa = new System.Windows.Forms.TextBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.button_open_daegu = new System.Windows.Forms.Button();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hakgwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_readCSV
            // 
            this.button_readCSV.Location = new System.Drawing.Point(12, 12);
            this.button_readCSV.Name = "button_readCSV";
            this.button_readCSV.Size = new System.Drawing.Size(95, 29);
            this.button_readCSV.TabIndex = 0;
            this.button_readCSV.Text = "CSV읽기";
            this.button_readCSV.UseVisualStyleBackColor = true;
            this.button_readCSV.Click += new System.EventHandler(this.button_readCSV_Click);
            // 
            // button_writeCSV
            // 
            this.button_writeCSV.Location = new System.Drawing.Point(126, 12);
            this.button_writeCSV.Name = "button_writeCSV";
            this.button_writeCSV.Size = new System.Drawing.Size(95, 29);
            this.button_writeCSV.TabIndex = 1;
            this.button_writeCSV.Text = "CSV쓰기";
            this.button_writeCSV.UseVisualStyleBackColor = true;
            this.button_writeCSV.Click += new System.EventHandler(this.button_writeCSV_Click);
            // 
            // dataGridView_students
            // 
            this.dataGridView_students.AllowUserToAddRows = false;
            this.dataGridView_students.AllowUserToDeleteRows = false;
            this.dataGridView_students.AutoGenerateColumns = false;
            this.dataGridView_students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.hakgwaDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView_students.DataSource = this.studentBindingSource;
            this.dataGridView_students.Location = new System.Drawing.Point(0, 149);
            this.dataGridView_students.Name = "dataGridView_students";
            this.dataGridView_students.ReadOnly = true;
            this.dataGridView_students.RowTemplate.Height = 23;
            this.dataGridView_students.Size = new System.Drawing.Size(800, 290);
            this.dataGridView_students.TabIndex = 2;
            this.dataGridView_students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_students_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "나이";
            // 
            // label_hakbeon
            // 
            this.label_hakbeon.AutoSize = true;
            this.label_hakbeon.Location = new System.Drawing.Point(179, 67);
            this.label_hakbeon.Name = "label_hakbeon";
            this.label_hakbeon.Size = new System.Drawing.Size(29, 12);
            this.label_hakbeon.TabIndex = 5;
            this.label_hakbeon.Text = "학번";
            // 
            // label_hakgwa
            // 
            this.label_hakgwa.AutoSize = true;
            this.label_hakgwa.Location = new System.Drawing.Point(179, 115);
            this.label_hakgwa.Name = "label_hakgwa";
            this.label_hakgwa.Size = new System.Drawing.Size(29, 12);
            this.label_hakgwa.TabIndex = 6;
            this.label_hakgwa.Text = "학과";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "성별";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(69, 65);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(86, 21);
            this.textBox_name.TabIndex = 8;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(69, 112);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(86, 21);
            this.textBox_age.TabIndex = 9;
            // 
            // textBox_hakbeon
            // 
            this.textBox_hakbeon.Location = new System.Drawing.Point(223, 64);
            this.textBox_hakbeon.Name = "textBox_hakbeon";
            this.textBox_hakbeon.Size = new System.Drawing.Size(86, 21);
            this.textBox_hakbeon.TabIndex = 10;
            // 
            // textBox_hakgwa
            // 
            this.textBox_hakgwa.Location = new System.Drawing.Point(223, 106);
            this.textBox_hakgwa.Name = "textBox_hakgwa";
            this.textBox_hakgwa.Size = new System.Drawing.Size(86, 21);
            this.textBox_hakgwa.TabIndex = 11;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "남",
            "여"});
            this.comboBox_gender.Location = new System.Drawing.Point(362, 65);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(121, 20);
            this.comboBox_gender.TabIndex = 12;
            // 
            // button_open_daegu
            // 
            this.button_open_daegu.Location = new System.Drawing.Point(239, 12);
            this.button_open_daegu.Name = "button_open_daegu";
            this.button_open_daegu.Size = new System.Drawing.Size(95, 29);
            this.button_open_daegu.TabIndex = 13;
            this.button_open_daegu.Text = "대구csv";
            this.button_open_daegu.UseVisualStyleBackColor = true;
            this.button_open_daegu.Click += new System.EventHandler(this.button_open_daegu_Click);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "이름";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "나이";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hakgwaDataGridViewTextBoxColumn
            // 
            this.hakgwaDataGridViewTextBoxColumn.DataPropertyName = "hakgwa";
            this.hakgwaDataGridViewTextBoxColumn.HeaderText = "학과";
            this.hakgwaDataGridViewTextBoxColumn.Name = "hakgwaDataGridViewTextBoxColumn";
            this.hakgwaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "성별";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(solveYesterday.Student);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.button_open_daegu);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.textBox_hakgwa);
            this.Controls.Add(this.textBox_hakbeon);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_hakgwa);
            this.Controls.Add(this.label_hakbeon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_students);
            this.Controls.Add(this.button_writeCSV);
            this.Controls.Add(this.button_readCSV);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_students)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_readCSV;
        private System.Windows.Forms.Button button_writeCSV;
        private System.Windows.Forms.DataGridView dataGridView_students;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_hakbeon;
        private System.Windows.Forms.Label label_hakgwa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_hakbeon;
        private System.Windows.Forms.TextBox textBox_hakgwa;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakbeoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakgwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_open_daegu;
    }
}

