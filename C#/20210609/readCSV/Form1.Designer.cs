
namespace readCSV
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
            this.button_readcsv = new System.Windows.Forms.Button();
            this.button_writeCSV = new System.Windows.Forms.Button();
            this.label_contents = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_writeCSV_name = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button_daegu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_writeCSV_age = new System.Windows.Forms.TextBox();
            this.textBox_writeCSV_hakbeon = new System.Windows.Forms.TextBox();
            this.textBox_writeCSV_hakgwa = new System.Windows.Forms.TextBox();
            this.textBox_writeCSV_gender = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGridviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridviewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_readcsv
            // 
            this.button_readcsv.Location = new System.Drawing.Point(12, 5);
            this.button_readcsv.Name = "button_readcsv";
            this.button_readcsv.Size = new System.Drawing.Size(75, 23);
            this.button_readcsv.TabIndex = 0;
            this.button_readcsv.Text = "csv읽기";
            this.button_readcsv.UseVisualStyleBackColor = true;
            this.button_readcsv.Click += new System.EventHandler(this.button_readcsv_Click);
            // 
            // button_writeCSV
            // 
            this.button_writeCSV.Location = new System.Drawing.Point(95, 5);
            this.button_writeCSV.Name = "button_writeCSV";
            this.button_writeCSV.Size = new System.Drawing.Size(75, 23);
            this.button_writeCSV.TabIndex = 1;
            this.button_writeCSV.Text = "csv쓰기";
            this.button_writeCSV.UseVisualStyleBackColor = true;
            this.button_writeCSV.Click += new System.EventHandler(this.button_writeCSV_Click);
            // 
            // label_contents
            // 
            this.label_contents.AutoSize = true;
            this.label_contents.Location = new System.Drawing.Point(21, 40);
            this.label_contents.Name = "label_contents";
            this.label_contents.Size = new System.Drawing.Size(11, 12);
            this.label_contents.TabIndex = 2;
            this.label_contents.Text = "-";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.studentGridviewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(211, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(585, 137);
            this.dataGridView1.TabIndex = 3;
            // 
            // textBox_writeCSV_name
            // 
            this.textBox_writeCSV_name.Location = new System.Drawing.Point(211, 7);
            this.textBox_writeCSV_name.Name = "textBox_writeCSV_name";
            this.textBox_writeCSV_name.Size = new System.Drawing.Size(88, 21);
            this.textBox_writeCSV_name.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 218);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(784, 203);
            this.dataGridView2.TabIndex = 5;
            // 
            // button_daegu
            // 
            this.button_daegu.Location = new System.Drawing.Point(12, 189);
            this.button_daegu.Name = "button_daegu";
            this.button_daegu.Size = new System.Drawing.Size(116, 23);
            this.button_daegu.TabIndex = 6;
            this.button_daegu.Text = "daegu csv읽기";
            this.button_daegu.UseVisualStyleBackColor = true;
            this.button_daegu.Click += new System.EventHandler(this.button_daegu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "학번";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(554, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "학과";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(681, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "성별";
            // 
            // textBox_writeCSV_age
            // 
            this.textBox_writeCSV_age.Location = new System.Drawing.Point(337, 7);
            this.textBox_writeCSV_age.Name = "textBox_writeCSV_age";
            this.textBox_writeCSV_age.Size = new System.Drawing.Size(88, 21);
            this.textBox_writeCSV_age.TabIndex = 12;
            // 
            // textBox_writeCSV_hakbeon
            // 
            this.textBox_writeCSV_hakbeon.Location = new System.Drawing.Point(463, 7);
            this.textBox_writeCSV_hakbeon.Name = "textBox_writeCSV_hakbeon";
            this.textBox_writeCSV_hakbeon.Size = new System.Drawing.Size(88, 21);
            this.textBox_writeCSV_hakbeon.TabIndex = 13;
            // 
            // textBox_writeCSV_hakgwa
            // 
            this.textBox_writeCSV_hakgwa.Location = new System.Drawing.Point(589, 6);
            this.textBox_writeCSV_hakgwa.Name = "textBox_writeCSV_hakgwa";
            this.textBox_writeCSV_hakgwa.Size = new System.Drawing.Size(88, 21);
            this.textBox_writeCSV_hakgwa.TabIndex = 14;
            // 
            // textBox_writeCSV_gender
            // 
            this.textBox_writeCSV_gender.Location = new System.Drawing.Point(708, 7);
            this.textBox_writeCSV_gender.Name = "textBox_writeCSV_gender";
            this.textBox_writeCSV_gender.Size = new System.Drawing.Size(88, 21);
            this.textBox_writeCSV_gender.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn1.HeaderText = "name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "age";
            this.dataGridViewTextBoxColumn2.HeaderText = "age";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "hakbeon";
            this.dataGridViewTextBoxColumn3.HeaderText = "hakbeon";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "hakgwa";
            this.dataGridViewTextBoxColumn4.HeaderText = "hakgwa";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "gender";
            this.dataGridViewTextBoxColumn5.HeaderText = "gender";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // studentGridviewBindingSource
            // 
            this.studentGridviewBindingSource.DataSource = typeof(readCSV.Student_Gridview);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_writeCSV_gender);
            this.Controls.Add(this.textBox_writeCSV_hakgwa);
            this.Controls.Add(this.textBox_writeCSV_hakbeon);
            this.Controls.Add(this.textBox_writeCSV_age);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_daegu);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox_writeCSV_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_contents);
            this.Controls.Add(this.button_writeCSV);
            this.Controls.Add(this.button_readcsv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridviewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_readcsv;
        private System.Windows.Forms.Button button_writeCSV;
        private System.Windows.Forms.Label label_contents;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_writeCSV_name;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button_daegu;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakbeonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakgwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_writeCSV_age;
        private System.Windows.Forms.TextBox textBox_writeCSV_hakbeon;
        private System.Windows.Forms.TextBox textBox_writeCSV_hakgwa;
        private System.Windows.Forms.TextBox textBox_writeCSV_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource studentGridviewBindingSource;
    }
}

