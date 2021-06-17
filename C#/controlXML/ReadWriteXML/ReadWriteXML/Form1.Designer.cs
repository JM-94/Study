
namespace ReadWriteXML
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_readXML = new System.Windows.Forms.Button();
            this.button_writeXML = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_hakbeon = new System.Windows.Forms.TextBox();
            this.textBox_hakgwa = new System.Windows.Forms.TextBox();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.button_api = new System.Windows.Forms.Button();
            this.dataGridView_api = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hakbeonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hakgwaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.durNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durCompDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_api)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.hakbeonDataGridViewTextBoxColumn,
            this.hakgwaDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(774, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_readXML
            // 
            this.button_readXML.Location = new System.Drawing.Point(14, 186);
            this.button_readXML.Name = "button_readXML";
            this.button_readXML.Size = new System.Drawing.Size(98, 23);
            this.button_readXML.TabIndex = 1;
            this.button_readXML.Text = "읽기";
            this.button_readXML.UseVisualStyleBackColor = true;
            this.button_readXML.Click += new System.EventHandler(this.button_readXML_Click);
            // 
            // button_writeXML
            // 
            this.button_writeXML.Location = new System.Drawing.Point(118, 186);
            this.button_writeXML.Name = "button_writeXML";
            this.button_writeXML.Size = new System.Drawing.Size(100, 23);
            this.button_writeXML.TabIndex = 2;
            this.button_writeXML.Text = "쓰기(추가)";
            this.button_writeXML.UseVisualStyleBackColor = true;
            this.button_writeXML.Click += new System.EventHandler(this.button_writeXML_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 224);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "나이";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "학번";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "학과";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "성별";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(12, 239);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 21);
            this.textBox_name.TabIndex = 8;
            // 
            // textBox_age
            // 
            this.textBox_age.Location = new System.Drawing.Point(118, 239);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(100, 21);
            this.textBox_age.TabIndex = 9;
            // 
            // textBox_hakbeon
            // 
            this.textBox_hakbeon.Location = new System.Drawing.Point(224, 239);
            this.textBox_hakbeon.Name = "textBox_hakbeon";
            this.textBox_hakbeon.Size = new System.Drawing.Size(100, 21);
            this.textBox_hakbeon.TabIndex = 10;
            // 
            // textBox_hakgwa
            // 
            this.textBox_hakgwa.Location = new System.Drawing.Point(330, 239);
            this.textBox_hakgwa.Name = "textBox_hakgwa";
            this.textBox_hakgwa.Size = new System.Drawing.Size(100, 21);
            this.textBox_hakgwa.TabIndex = 11;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "남",
            "여"});
            this.comboBox_gender.Location = new System.Drawing.Point(436, 239);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(121, 20);
            this.comboBox_gender.TabIndex = 12;
            // 
            // button_api
            // 
            this.button_api.Location = new System.Drawing.Point(14, 343);
            this.button_api.Name = "button_api";
            this.button_api.Size = new System.Drawing.Size(98, 23);
            this.button_api.TabIndex = 13;
            this.button_api.Text = "api땡겨오기";
            this.button_api.UseVisualStyleBackColor = true;
            this.button_api.Click += new System.EventHandler(this.button_api_Click);
            // 
            // dataGridView_api
            // 
            this.dataGridView_api.AllowUserToAddRows = false;
            this.dataGridView_api.AllowUserToDeleteRows = false;
            this.dataGridView_api.AutoGenerateColumns = false;
            this.dataGridView_api.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_api.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.durNameDataGridViewTextBoxColumn,
            this.durIdDataGridViewTextBoxColumn,
            this.durCompDataGridViewTextBoxColumn});
            this.dataGridView_api.DataSource = this.drugBindingSource;
            this.dataGridView_api.Location = new System.Drawing.Point(11, 372);
            this.dataGridView_api.Name = "dataGridView_api";
            this.dataGridView_api.ReadOnly = true;
            this.dataGridView_api.RowTemplate.Height = 23;
            this.dataGridView_api.Size = new System.Drawing.Size(777, 327);
            this.dataGridView_api.TabIndex = 14;
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
            // hakbeonDataGridViewTextBoxColumn
            // 
            this.hakbeonDataGridViewTextBoxColumn.DataPropertyName = "hakbeon";
            this.hakbeonDataGridViewTextBoxColumn.HeaderText = "학번";
            this.hakbeonDataGridViewTextBoxColumn.Name = "hakbeonDataGridViewTextBoxColumn";
            this.hakbeonDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.studentBindingSource.DataSource = typeof(ReadWriteXML.Student);
            // 
            // drugBindingSource
            // 
            this.drugBindingSource.DataSource = typeof(ReadWriteXML.Drug);
            // 
            // durNameDataGridViewTextBoxColumn
            // 
            this.durNameDataGridViewTextBoxColumn.DataPropertyName = "DurName";
            this.durNameDataGridViewTextBoxColumn.HeaderText = "DurName";
            this.durNameDataGridViewTextBoxColumn.Name = "durNameDataGridViewTextBoxColumn";
            this.durNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durIdDataGridViewTextBoxColumn
            // 
            this.durIdDataGridViewTextBoxColumn.DataPropertyName = "DurId";
            this.durIdDataGridViewTextBoxColumn.HeaderText = "DurId";
            this.durIdDataGridViewTextBoxColumn.Name = "durIdDataGridViewTextBoxColumn";
            this.durIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durCompDataGridViewTextBoxColumn
            // 
            this.durCompDataGridViewTextBoxColumn.DataPropertyName = "DurComp";
            this.durCompDataGridViewTextBoxColumn.HeaderText = "DurComp";
            this.durCompDataGridViewTextBoxColumn.Name = "durCompDataGridViewTextBoxColumn";
            this.durCompDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 711);
            this.Controls.Add(this.dataGridView_api);
            this.Controls.Add(this.button_api);
            this.Controls.Add(this.comboBox_gender);
            this.Controls.Add(this.textBox_hakgwa);
            this.Controls.Add(this.textBox_hakbeon);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_writeXML);
            this.Controls.Add(this.button_readXML);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_api)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_readXML;
        private System.Windows.Forms.Button button_writeXML;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_hakbeon;
        private System.Windows.Forms.TextBox textBox_hakgwa;
        private System.Windows.Forms.ComboBox comboBox_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakbeonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hakgwaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button button_api;
        private System.Windows.Forms.DataGridView dataGridView_api;
        private System.Windows.Forms.DataGridViewTextBoxColumn durNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durCompDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource drugBindingSource;
    }
}

