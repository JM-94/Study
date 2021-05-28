
namespace CustCar0415.UI
{
    partial class AddCar
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
            this.comboModel = new Sunny.UI.UIComboBox();
            this.comboCompany = new Sunny.UI.UIComboBox();
            this.comboColor = new Sunny.UI.UIComboBox();
            this.comboPrice = new Sunny.UI.UIComboBox();
            this.infoModel = new Sunny.UI.UISymbolLabel();
            this.infoCompany = new Sunny.UI.UISymbolLabel();
            this.infoColor = new Sunny.UI.UISymbolLabel();
            this.infoPrice = new Sunny.UI.UISymbolLabel();
            this.addCarOk = new Sunny.UI.UISymbolButton();
            this.addCarCancel = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboModel
            // 
            this.comboModel.FillColor = System.Drawing.Color.White;
            this.comboModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboModel.Items.AddRange(new object[] {
            "그랜저",
            "제네시스",
            "K8",
            "K7",
            "우루스"});
            this.comboModel.Location = new System.Drawing.Point(40, 83);
            this.comboModel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboModel.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboModel.Name = "comboModel";
            this.comboModel.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboModel.Size = new System.Drawing.Size(166, 29);
            this.comboModel.TabIndex = 0;
            this.comboModel.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboModel.SelectedIndexChanged += new System.EventHandler(this.comboModel_SelectedIndexChanged);
            // 
            // comboCompany
            // 
            this.comboCompany.FillColor = System.Drawing.Color.White;
            this.comboCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboCompany.Items.AddRange(new object[] {
            "현대",
            "기아",
            "삼성",
            "람보르기니"});
            this.comboCompany.Location = new System.Drawing.Point(418, 83);
            this.comboCompany.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboCompany.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboCompany.Name = "comboCompany";
            this.comboCompany.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboCompany.Size = new System.Drawing.Size(166, 29);
            this.comboCompany.TabIndex = 1;
            this.comboCompany.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboCompany.SelectedIndexChanged += new System.EventHandler(this.comboCompany_SelectedIndexChanged);
            // 
            // comboColor
            // 
            this.comboColor.FillColor = System.Drawing.Color.White;
            this.comboColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboColor.Items.AddRange(new object[] {
            "검정",
            "흰색",
            "노랑",
            "파랑",
            "빨강"});
            this.comboColor.Location = new System.Drawing.Point(229, 83);
            this.comboColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboColor.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboColor.Name = "comboColor";
            this.comboColor.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboColor.Size = new System.Drawing.Size(166, 29);
            this.comboColor.TabIndex = 1;
            this.comboColor.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboColor.SelectedIndexChanged += new System.EventHandler(this.comboColor_SelectedIndexChanged);
            // 
            // comboPrice
            // 
            this.comboPrice.FillColor = System.Drawing.Color.White;
            this.comboPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.comboPrice.Items.AddRange(new object[] {
            "3천만원",
            "4천만원",
            "5천만원",
            "8천만원",
            "2억6천만원"});
            this.comboPrice.Location = new System.Drawing.Point(607, 83);
            this.comboPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboPrice.MinimumSize = new System.Drawing.Size(63, 0);
            this.comboPrice.Name = "comboPrice";
            this.comboPrice.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.comboPrice.Size = new System.Drawing.Size(166, 29);
            this.comboPrice.TabIndex = 1;
            this.comboPrice.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.comboPrice.SelectedIndexChanged += new System.EventHandler(this.comboPrice_SelectedIndexChanged);
            // 
            // infoModel
            // 
            this.infoModel.BackColor = System.Drawing.Color.Transparent;
            this.infoModel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoModel.Location = new System.Drawing.Point(40, 530);
            this.infoModel.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoModel.Name = "infoModel";
            this.infoModel.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoModel.Size = new System.Drawing.Size(166, 29);
            this.infoModel.Symbol = 61882;
            this.infoModel.TabIndex = 8;
            this.infoModel.Text = "모델명";
            // 
            // infoCompany
            // 
            this.infoCompany.BackColor = System.Drawing.Color.Transparent;
            this.infoCompany.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoCompany.Location = new System.Drawing.Point(418, 530);
            this.infoCompany.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoCompany.Name = "infoCompany";
            this.infoCompany.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoCompany.Size = new System.Drawing.Size(166, 29);
            this.infoCompany.Symbol = 61869;
            this.infoCompany.TabIndex = 9;
            this.infoCompany.Text = "제조사";
            // 
            // infoColor
            // 
            this.infoColor.BackColor = System.Drawing.Color.Transparent;
            this.infoColor.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoColor.Location = new System.Drawing.Point(229, 530);
            this.infoColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoColor.Name = "infoColor";
            this.infoColor.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoColor.Size = new System.Drawing.Size(166, 29);
            this.infoColor.Symbol = 61947;
            this.infoColor.TabIndex = 10;
            this.infoColor.Text = "색상";
            // 
            // infoPrice
            // 
            this.infoPrice.BackColor = System.Drawing.Color.Transparent;
            this.infoPrice.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.infoPrice.Location = new System.Drawing.Point(607, 530);
            this.infoPrice.MinimumSize = new System.Drawing.Size(1, 1);
            this.infoPrice.Name = "infoPrice";
            this.infoPrice.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.infoPrice.Size = new System.Drawing.Size(166, 29);
            this.infoPrice.Symbol = 61785;
            this.infoPrice.TabIndex = 11;
            this.infoPrice.Text = "가격";
            // 
            // addCarOk
            // 
            this.addCarOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarOk.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarOk.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarOk.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarOk.Location = new System.Drawing.Point(268, 576);
            this.addCarOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarOk.Name = "addCarOk";
            this.addCarOk.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarOk.Size = new System.Drawing.Size(127, 36);
            this.addCarOk.Style = Sunny.UI.UIStyle.Custom;
            this.addCarOk.TabIndex = 12;
            this.addCarOk.Text = "확인";
            this.addCarOk.Click += new System.EventHandler(this.addCarOk_Click);
            // 
            // addCarCancel
            // 
            this.addCarCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarCancel.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarCancel.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarCancel.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarCancel.Location = new System.Drawing.Point(418, 576);
            this.addCarCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarCancel.Name = "addCarCancel";
            this.addCarCancel.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarCancel.Size = new System.Drawing.Size(127, 36);
            this.addCarCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCarCancel.Symbol = 61453;
            this.addCarCancel.TabIndex = 13;
            this.addCarCancel.Text = "취소";
            this.addCarCancel.Click += new System.EventHandler(this.addCarCancel_Click);
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.FillColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.FillDisableColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uiSymbolButton3.ForeHoverColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.ForePressColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.ForeSelectedColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Location = new System.Drawing.Point(754, 23);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.RectColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.RectDisableColor = System.Drawing.Color.Transparent;
            this.uiSymbolButton3.Size = new System.Drawing.Size(46, 42);
            this.uiSymbolButton3.Style = Sunny.UI.UIStyle.Custom;
            this.uiSymbolButton3.Symbol = 61453;
            this.uiSymbolButton3.SymbolSize = 40;
            this.uiSymbolButton3.TabIndex = 19;
            this.uiSymbolButton3.Click += new System.EventHandler(this.addCarCancel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::CustCar0415.Properties.Resources.gran_side;
            this.pictureBox2.Location = new System.Drawing.Point(409, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(322, 184);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::CustCar0415.Properties.Resources.gran_back;
            this.pictureBox3.Location = new System.Drawing.Point(81, 323);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(322, 184);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::CustCar0415.Properties.Resources.gran_in;
            this.pictureBox4.Location = new System.Drawing.Point(409, 323);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(322, 184);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CustCar0415.Properties.Resources.gran;
            this.pictureBox1.Location = new System.Drawing.Point(81, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // AddCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 639);
            this.ControlBox = false;
            this.Controls.Add(this.uiSymbolButton3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addCarCancel);
            this.Controls.Add(this.addCarOk);
            this.Controls.Add(this.infoPrice);
            this.Controls.Add(this.infoColor);
            this.Controls.Add(this.infoCompany);
            this.Controls.Add(this.infoModel);
            this.Controls.Add(this.comboPrice);
            this.Controls.Add(this.comboColor);
            this.Controls.Add(this.comboCompany);
            this.Controls.Add(this.comboModel);
            this.Name = "AddCar";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "차량 정보 추가";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIComboBox comboModel;
        private Sunny.UI.UIComboBox comboCompany;
        private Sunny.UI.UIComboBox comboColor;
        private Sunny.UI.UIComboBox comboPrice;
        private Sunny.UI.UISymbolLabel infoModel;
        private Sunny.UI.UISymbolLabel infoCompany;
        private Sunny.UI.UISymbolLabel infoColor;
        private Sunny.UI.UISymbolLabel infoPrice;
        private Sunny.UI.UISymbolButton addCarOk;
        private Sunny.UI.UISymbolButton addCarCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
    }
}