
namespace test
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_api = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.경도DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용전력량DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.사용횟수DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.위도DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.일자DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.충전기IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.충전기타입DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.충전소IDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.충전소명칭DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 300);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(954, 410);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button_api
            // 
            this.button_api.Location = new System.Drawing.Point(12, 12);
            this.button_api.Name = "button_api";
            this.button_api.Size = new System.Drawing.Size(75, 23);
            this.button_api.TabIndex = 1;
            this.button_api.Text = "API";
            this.button_api.UseVisualStyleBackColor = true;
            this.button_api.Click += new System.EventHandler(this.button_api_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.경도DataGridViewTextBoxColumn,
            this.사용전력량DataGridViewTextBoxColumn,
            this.사용횟수DataGridViewTextBoxColumn,
            this.위도DataGridViewTextBoxColumn,
            this.일자DataGridViewTextBoxColumn,
            this.충전기IDDataGridViewTextBoxColumn,
            this.충전기타입DataGridViewTextBoxColumn,
            this.충전소IDDataGridViewTextBoxColumn,
            this.충전소명칭DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.carBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(954, 253);
            this.dataGridView1.TabIndex = 3;
            // 
            // 경도DataGridViewTextBoxColumn
            // 
            this.경도DataGridViewTextBoxColumn.DataPropertyName = "경도";
            this.경도DataGridViewTextBoxColumn.HeaderText = "경도";
            this.경도DataGridViewTextBoxColumn.Name = "경도DataGridViewTextBoxColumn";
            // 
            // 사용전력량DataGridViewTextBoxColumn
            // 
            this.사용전력량DataGridViewTextBoxColumn.DataPropertyName = "사용전력량";
            this.사용전력량DataGridViewTextBoxColumn.HeaderText = "사용전력량";
            this.사용전력량DataGridViewTextBoxColumn.Name = "사용전력량DataGridViewTextBoxColumn";
            // 
            // 사용횟수DataGridViewTextBoxColumn
            // 
            this.사용횟수DataGridViewTextBoxColumn.DataPropertyName = "사용횟수";
            this.사용횟수DataGridViewTextBoxColumn.HeaderText = "사용횟수";
            this.사용횟수DataGridViewTextBoxColumn.Name = "사용횟수DataGridViewTextBoxColumn";
            // 
            // 위도DataGridViewTextBoxColumn
            // 
            this.위도DataGridViewTextBoxColumn.DataPropertyName = "위도";
            this.위도DataGridViewTextBoxColumn.HeaderText = "위도";
            this.위도DataGridViewTextBoxColumn.Name = "위도DataGridViewTextBoxColumn";
            // 
            // 일자DataGridViewTextBoxColumn
            // 
            this.일자DataGridViewTextBoxColumn.DataPropertyName = "일자";
            this.일자DataGridViewTextBoxColumn.HeaderText = "일자";
            this.일자DataGridViewTextBoxColumn.Name = "일자DataGridViewTextBoxColumn";
            // 
            // 충전기IDDataGridViewTextBoxColumn
            // 
            this.충전기IDDataGridViewTextBoxColumn.DataPropertyName = "충전기ID";
            this.충전기IDDataGridViewTextBoxColumn.HeaderText = "충전기ID";
            this.충전기IDDataGridViewTextBoxColumn.Name = "충전기IDDataGridViewTextBoxColumn";
            // 
            // 충전기타입DataGridViewTextBoxColumn
            // 
            this.충전기타입DataGridViewTextBoxColumn.DataPropertyName = "충전기타입";
            this.충전기타입DataGridViewTextBoxColumn.HeaderText = "충전기타입";
            this.충전기타입DataGridViewTextBoxColumn.Name = "충전기타입DataGridViewTextBoxColumn";
            // 
            // 충전소IDDataGridViewTextBoxColumn
            // 
            this.충전소IDDataGridViewTextBoxColumn.DataPropertyName = "충전소ID";
            this.충전소IDDataGridViewTextBoxColumn.HeaderText = "충전소ID";
            this.충전소IDDataGridViewTextBoxColumn.Name = "충전소IDDataGridViewTextBoxColumn";
            // 
            // 충전소명칭DataGridViewTextBoxColumn
            // 
            this.충전소명칭DataGridViewTextBoxColumn.DataPropertyName = "충전소명칭";
            this.충전소명칭DataGridViewTextBoxColumn.HeaderText = "충전소명칭";
            this.충전소명칭DataGridViewTextBoxColumn.Name = "충전소명칭DataGridViewTextBoxColumn";
            // 
            // carBindingSource
            // 
            this.carBindingSource.DataSource = typeof(test.Car);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 722);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_api);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button_api;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 경도DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용전력량DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 사용횟수DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 위도DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 일자DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 충전기IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 충전기타입DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 충전소IDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 충전소명칭DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource carBindingSource;
    }
}

