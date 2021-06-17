
namespace CustCar0415.UI
{
    partial class UcAddCar
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucPictureBox2 = new System.Windows.Forms.PictureBox();
            this.ucPictureBox3 = new System.Windows.Forms.PictureBox();
            this.ucPictureBox4 = new System.Windows.Forms.PictureBox();
            this.ucPictureBox1 = new System.Windows.Forms.PictureBox();
            this.ucAddCarInit = new Sunny.UI.UISymbolButton();
            this.ucAddCarOk = new Sunny.UI.UISymbolButton();
            this.ucInfoPrice = new Sunny.UI.UISymbolLabel();
            this.ucInfoColor = new Sunny.UI.UISymbolLabel();
            this.ucInfoCompany = new Sunny.UI.UISymbolLabel();
            this.ucInfoModel = new Sunny.UI.UISymbolLabel();
            this.ucComboPrice = new Sunny.UI.UIComboBox();
            this.ucComboColor = new Sunny.UI.UIComboBox();
            this.ucComboCompany = new Sunny.UI.UIComboBox();
            this.ucComboModel = new Sunny.UI.UIComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPictureBox2
            // 
            this.ucPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.ucPictureBox2.Image = global::CustCar0415.Properties.Resources.gran_side;
            this.ucPictureBox2.Location = new System.Drawing.Point(392, 77);
            this.ucPictureBox2.Name = "ucPictureBox2";
            this.ucPictureBox2.Size = new System.Drawing.Size(322, 184);
            this.ucPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ucPictureBox2.TabIndex = 31;
            this.ucPictureBox2.TabStop = false;
            // 
            // ucPictureBox3
            // 
            this.ucPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.ucPictureBox3.Image = global::CustCar0415.Properties.Resources.gran_back;
            this.ucPictureBox3.Location = new System.Drawing.Point(64, 267);
            this.ucPictureBox3.Name = "ucPictureBox3";
            this.ucPictureBox3.Size = new System.Drawing.Size(322, 184);
            this.ucPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ucPictureBox3.TabIndex = 30;
            this.ucPictureBox3.TabStop = false;
            // 
            // ucPictureBox4
            // 
            this.ucPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.ucPictureBox4.Image = global::CustCar0415.Properties.Resources.gran_in;
            this.ucPictureBox4.Location = new System.Drawing.Point(392, 267);
            this.ucPictureBox4.Name = "ucPictureBox4";
            this.ucPictureBox4.Size = new System.Drawing.Size(322, 184);
            this.ucPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ucPictureBox4.TabIndex = 29;
            this.ucPictureBox4.TabStop = false;
            // 
            // ucPictureBox1
            // 
            this.ucPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.ucPictureBox1.Image = global::CustCar0415.Properties.Resources.gran;
            this.ucPictureBox1.Location = new System.Drawing.Point(64, 77);
            this.ucPictureBox1.Name = "ucPictureBox1";
            this.ucPictureBox1.Size = new System.Drawing.Size(322, 184);
            this.ucPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ucPictureBox1.TabIndex = 28;
            this.ucPictureBox1.TabStop = false;
            // 
            // ucAddCarInit
            // 
            this.ucAddCarInit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCarInit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAddCarInit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAddCarInit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAddCarInit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAddCarInit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCarInit.Location = new System.Drawing.Point(401, 520);
            this.ucAddCarInit.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCarInit.Name = "ucAddCarInit";
            this.ucAddCarInit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAddCarInit.Size = new System.Drawing.Size(127, 36);
            this.ucAddCarInit.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCarInit.Symbol = 61453;
            this.ucAddCarInit.TabIndex = 27;
            this.ucAddCarInit.Text = "초기화";
            this.ucAddCarInit.Click += new System.EventHandler(this.ucAddCarInit_Click);
            // 
            // ucAddCarOk
            // 
            this.ucAddCarOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucAddCarOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAddCarOk.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAddCarOk.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAddCarOk.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAddCarOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucAddCarOk.Location = new System.Drawing.Point(251, 520);
            this.ucAddCarOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucAddCarOk.Name = "ucAddCarOk";
            this.ucAddCarOk.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ucAddCarOk.Size = new System.Drawing.Size(127, 36);
            this.ucAddCarOk.Style = Sunny.UI.UIStyle.Custom;
            this.ucAddCarOk.TabIndex = 26;
            this.ucAddCarOk.Text = "확인";
            this.ucAddCarOk.Click += new System.EventHandler(this.ucAddCarOk_Click);
            // 
            // ucInfoPrice
            // 
            this.ucInfoPrice.BackColor = System.Drawing.Color.Transparent;
            this.ucInfoPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoPrice.Location = new System.Drawing.Point(590, 474);
            this.ucInfoPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoPrice.Name = "ucInfoPrice";
            this.ucInfoPrice.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoPrice.Size = new System.Drawing.Size(166, 29);
            this.ucInfoPrice.Symbol = 61785;
            this.ucInfoPrice.TabIndex = 25;
            this.ucInfoPrice.Text = "가격";
            // 
            // ucInfoColor
            // 
            this.ucInfoColor.BackColor = System.Drawing.Color.Transparent;
            this.ucInfoColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoColor.Location = new System.Drawing.Point(212, 474);
            this.ucInfoColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoColor.Name = "ucInfoColor";
            this.ucInfoColor.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoColor.Size = new System.Drawing.Size(166, 29);
            this.ucInfoColor.Symbol = 61947;
            this.ucInfoColor.TabIndex = 24;
            this.ucInfoColor.Text = "색상";
            // 
            // ucInfoCompany
            // 
            this.ucInfoCompany.BackColor = System.Drawing.Color.Transparent;
            this.ucInfoCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoCompany.Location = new System.Drawing.Point(401, 474);
            this.ucInfoCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoCompany.Name = "ucInfoCompany";
            this.ucInfoCompany.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoCompany.Size = new System.Drawing.Size(166, 29);
            this.ucInfoCompany.Symbol = 61869;
            this.ucInfoCompany.TabIndex = 23;
            this.ucInfoCompany.Text = "제조사";
            // 
            // ucInfoModel
            // 
            this.ucInfoModel.BackColor = System.Drawing.Color.Transparent;
            this.ucInfoModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucInfoModel.Location = new System.Drawing.Point(23, 474);
            this.ucInfoModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.ucInfoModel.Name = "ucInfoModel";
            this.ucInfoModel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.ucInfoModel.Size = new System.Drawing.Size(166, 29);
            this.ucInfoModel.Symbol = 61882;
            this.ucInfoModel.TabIndex = 22;
            this.ucInfoModel.Text = "모델명";
            // 
            // ucComboPrice
            // 
            this.ucComboPrice.FillColor = System.Drawing.Color.White;
            this.ucComboPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboPrice.Items.AddRange(new object[] {
            "3천만원",
            "4천만원",
            "5천만원",
            "8천만원",
            "2억6천만원"});
            this.ucComboPrice.Location = new System.Drawing.Point(590, 27);
            this.ucComboPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboPrice.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboPrice.Name = "ucComboPrice";
            this.ucComboPrice.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboPrice.Size = new System.Drawing.Size(166, 29);
            this.ucComboPrice.TabIndex = 19;
            this.ucComboPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboPrice.SelectedIndexChanged += new System.EventHandler(this.ucComboPrice_SelectedIndexChanged);
            // 
            // ucComboColor
            // 
            this.ucComboColor.FillColor = System.Drawing.Color.White;
            this.ucComboColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboColor.Items.AddRange(new object[] {
            "검정",
            "흰색",
            "노랑",
            "파랑",
            "빨강"});
            this.ucComboColor.Location = new System.Drawing.Point(212, 27);
            this.ucComboColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboColor.Name = "ucComboColor";
            this.ucComboColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboColor.Size = new System.Drawing.Size(166, 29);
            this.ucComboColor.TabIndex = 20;
            this.ucComboColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboColor.SelectedIndexChanged += new System.EventHandler(this.ucComboColor_SelectedIndexChanged);
            // 
            // ucComboCompany
            // 
            this.ucComboCompany.FillColor = System.Drawing.Color.White;
            this.ucComboCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboCompany.Items.AddRange(new object[] {
            "현대",
            "기아",
            "삼성",
            "람보르기니"});
            this.ucComboCompany.Location = new System.Drawing.Point(401, 27);
            this.ucComboCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboCompany.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboCompany.Name = "ucComboCompany";
            this.ucComboCompany.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboCompany.Size = new System.Drawing.Size(166, 29);
            this.ucComboCompany.TabIndex = 21;
            this.ucComboCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboCompany.SelectedIndexChanged += new System.EventHandler(this.ucComboCompany_SelectedIndexChanged);
            // 
            // ucComboModel
            // 
            this.ucComboModel.FillColor = System.Drawing.Color.White;
            this.ucComboModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.ucComboModel.Items.AddRange(new object[] {
            "그랜저",
            "제네시스",
            "K8",
            "K7",
            "우루스"});
            this.ucComboModel.Location = new System.Drawing.Point(23, 27);
            this.ucComboModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucComboModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.ucComboModel.Name = "ucComboModel";
            this.ucComboModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.ucComboModel.Size = new System.Drawing.Size(166, 29);
            this.ucComboModel.TabIndex = 18;
            this.ucComboModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucComboModel.SelectedIndexChanged += new System.EventHandler(this.ucComboModel_SelectedIndexChanged);
            // 
            // UcAddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ucPictureBox2);
            this.Controls.Add(this.ucPictureBox3);
            this.Controls.Add(this.ucPictureBox4);
            this.Controls.Add(this.ucPictureBox1);
            this.Controls.Add(this.ucAddCarInit);
            this.Controls.Add(this.ucAddCarOk);
            this.Controls.Add(this.ucInfoPrice);
            this.Controls.Add(this.ucInfoColor);
            this.Controls.Add(this.ucInfoCompany);
            this.Controls.Add(this.ucInfoModel);
            this.Controls.Add(this.ucComboPrice);
            this.Controls.Add(this.ucComboColor);
            this.Controls.Add(this.ucComboCompany);
            this.Controls.Add(this.ucComboModel);
            this.Name = "UcAddCar";
            this.Size = new System.Drawing.Size(870, 610);
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ucPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ucPictureBox2;
        private System.Windows.Forms.PictureBox ucPictureBox3;
        private System.Windows.Forms.PictureBox ucPictureBox4;
        private System.Windows.Forms.PictureBox ucPictureBox1;
        private Sunny.UI.UISymbolButton ucAddCarInit;
        private Sunny.UI.UISymbolButton ucAddCarOk;
        private Sunny.UI.UISymbolLabel ucInfoPrice;
        private Sunny.UI.UISymbolLabel ucInfoColor;
        private Sunny.UI.UISymbolLabel ucInfoCompany;
        private Sunny.UI.UISymbolLabel ucInfoModel;
        private Sunny.UI.UIComboBox ucComboPrice;
        private Sunny.UI.UIComboBox ucComboColor;
        private Sunny.UI.UIComboBox ucComboCompany;
        private Sunny.UI.UIComboBox ucComboModel;
    }
}
