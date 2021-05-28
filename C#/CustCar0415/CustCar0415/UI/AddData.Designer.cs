
namespace CustCar0415.UI
{
    partial class AddData
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
            this.topLayer = new System.Windows.Forms.Panel();
            this.addCarExit = new Sunny.UI.UISymbolButton();
            this.leftLayout = new System.Windows.Forms.Panel();
            this.uiHeaderButton4 = new Sunny.UI.UIHeaderButton();
            this.addDataSell = new Sunny.UI.UIHeaderButton();
            this.addDataCust = new Sunny.UI.UIHeaderButton();
            this.addDataCar = new Sunny.UI.UIHeaderButton();
            this.centerLayout = new System.Windows.Forms.Panel();
            this.addDataStatus = new Sunny.UI.UISymbolLabel();
            this.topLayer.SuspendLayout();
            this.leftLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // topLayer
            // 
            this.topLayer.BackColor = System.Drawing.Color.Transparent;
            this.topLayer.Controls.Add(this.addDataStatus);
            this.topLayer.Controls.Add(this.addCarExit);
            this.topLayer.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayer.Location = new System.Drawing.Point(0, 0);
            this.topLayer.Name = "topLayer";
            this.topLayer.Size = new System.Drawing.Size(942, 66);
            this.topLayer.TabIndex = 0;
            this.topLayer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topLayer_MouseMove);
            // 
            // addCarExit
            // 
            this.addCarExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCarExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addCarExit.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarExit.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarExit.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addCarExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCarExit.ForeColor = System.Drawing.Color.Gold;
            this.addCarExit.Location = new System.Drawing.Point(882, 25);
            this.addCarExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCarExit.Name = "addCarExit";
            this.addCarExit.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addCarExit.Size = new System.Drawing.Size(49, 38);
            this.addCarExit.Style = Sunny.UI.UIStyle.Custom;
            this.addCarExit.Symbol = 61453;
            this.addCarExit.SymbolSize = 40;
            this.addCarExit.TabIndex = 16;
            this.addCarExit.Click += new System.EventHandler(this.addCarExit_Click);
            // 
            // leftLayout
            // 
            this.leftLayout.BackColor = System.Drawing.Color.Transparent;
            this.leftLayout.Controls.Add(this.uiHeaderButton4);
            this.leftLayout.Controls.Add(this.addDataSell);
            this.leftLayout.Controls.Add(this.addDataCust);
            this.leftLayout.Controls.Add(this.addDataCar);
            this.leftLayout.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftLayout.Location = new System.Drawing.Point(0, 66);
            this.leftLayout.Name = "leftLayout";
            this.leftLayout.Size = new System.Drawing.Size(149, 577);
            this.leftLayout.TabIndex = 1;
            // 
            // uiHeaderButton4
            // 
            this.uiHeaderButton4.CircleColor = System.Drawing.Color.Transparent;
            this.uiHeaderButton4.CircleSize = 80;
            this.uiHeaderButton4.FillColor = System.Drawing.Color.Gold;
            this.uiHeaderButton4.FillHoverColor = System.Drawing.Color.Red;
            this.uiHeaderButton4.FillPressColor = System.Drawing.Color.Red;
            this.uiHeaderButton4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiHeaderButton4.ForeColor = System.Drawing.Color.Black;
            this.uiHeaderButton4.Location = new System.Drawing.Point(3, 360);
            this.uiHeaderButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiHeaderButton4.Name = "uiHeaderButton4";
            this.uiHeaderButton4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.uiHeaderButton4.Radius = 0;
            this.uiHeaderButton4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiHeaderButton4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiHeaderButton4.Size = new System.Drawing.Size(143, 112);
            this.uiHeaderButton4.Style = Sunny.UI.UIStyle.Custom;
            this.uiHeaderButton4.Symbol = 61453;
            this.uiHeaderButton4.SymbolColor = System.Drawing.Color.Black;
            this.uiHeaderButton4.TabIndex = 3;
            this.uiHeaderButton4.Text = "종료";
            this.uiHeaderButton4.Click += new System.EventHandler(this.addCarExit_Click);
            // 
            // addDataSell
            // 
            this.addDataSell.CircleColor = System.Drawing.Color.Transparent;
            this.addDataSell.CircleSize = 80;
            this.addDataSell.FillColor = System.Drawing.Color.Gold;
            this.addDataSell.FillHoverColor = System.Drawing.Color.Red;
            this.addDataSell.FillPressColor = System.Drawing.Color.Red;
            this.addDataSell.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addDataSell.ForeColor = System.Drawing.Color.Black;
            this.addDataSell.Location = new System.Drawing.Point(3, 242);
            this.addDataSell.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataSell.Name = "addDataSell";
            this.addDataSell.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.addDataSell.Radius = 0;
            this.addDataSell.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addDataSell.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addDataSell.Size = new System.Drawing.Size(143, 112);
            this.addDataSell.Style = Sunny.UI.UIStyle.Custom;
            this.addDataSell.Symbol = 62144;
            this.addDataSell.SymbolColor = System.Drawing.Color.Black;
            this.addDataSell.TabIndex = 2;
            this.addDataSell.Text = "판매자 정보 등록";
            this.addDataSell.Click += new System.EventHandler(this.addDataSell_Click);
            // 
            // addDataCust
            // 
            this.addDataCust.CircleColor = System.Drawing.Color.Transparent;
            this.addDataCust.CircleSize = 80;
            this.addDataCust.FillColor = System.Drawing.Color.Gold;
            this.addDataCust.FillHoverColor = System.Drawing.Color.Red;
            this.addDataCust.FillPressColor = System.Drawing.Color.Red;
            this.addDataCust.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addDataCust.ForeColor = System.Drawing.Color.Black;
            this.addDataCust.Location = new System.Drawing.Point(3, 124);
            this.addDataCust.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataCust.Name = "addDataCust";
            this.addDataCust.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.addDataCust.Radius = 0;
            this.addDataCust.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addDataCust.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addDataCust.Size = new System.Drawing.Size(143, 112);
            this.addDataCust.Style = Sunny.UI.UIStyle.Custom;
            this.addDataCust.Symbol = 61447;
            this.addDataCust.SymbolColor = System.Drawing.Color.Black;
            this.addDataCust.TabIndex = 1;
            this.addDataCust.Text = "고객 정보 등록";
            this.addDataCust.Click += new System.EventHandler(this.addDataCust_Click);
            // 
            // addDataCar
            // 
            this.addDataCar.CircleColor = System.Drawing.Color.Transparent;
            this.addDataCar.CircleSize = 80;
            this.addDataCar.FillColor = System.Drawing.Color.Gold;
            this.addDataCar.FillHoverColor = System.Drawing.Color.Red;
            this.addDataCar.FillPressColor = System.Drawing.Color.Red;
            this.addDataCar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addDataCar.ForeColor = System.Drawing.Color.Black;
            this.addDataCar.Location = new System.Drawing.Point(3, 6);
            this.addDataCar.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataCar.Name = "addDataCar";
            this.addDataCar.Padding = new System.Windows.Forms.Padding(0, 8, 0, 3);
            this.addDataCar.Radius = 0;
            this.addDataCar.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.addDataCar.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.addDataCar.Size = new System.Drawing.Size(143, 112);
            this.addDataCar.Style = Sunny.UI.UIStyle.Custom;
            this.addDataCar.Symbol = 61882;
            this.addDataCar.SymbolColor = System.Drawing.Color.Black;
            this.addDataCar.TabIndex = 0;
            this.addDataCar.Text = "차량 정보 등록";
            this.addDataCar.Click += new System.EventHandler(this.addDataCar_Click);
            // 
            // centerLayout
            // 
            this.centerLayout.BackColor = System.Drawing.Color.Transparent;
            this.centerLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerLayout.Location = new System.Drawing.Point(149, 66);
            this.centerLayout.Name = "centerLayout";
            this.centerLayout.Size = new System.Drawing.Size(793, 577);
            this.centerLayout.TabIndex = 2;
            // 
            // addDataStatus
            // 
            this.addDataStatus.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addDataStatus.ForeColor = System.Drawing.Color.White;
            this.addDataStatus.Location = new System.Drawing.Point(0, 8);
            this.addDataStatus.MinimumSize = new System.Drawing.Size(1, 1);
            this.addDataStatus.Name = "addDataStatus";
            this.addDataStatus.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.addDataStatus.Size = new System.Drawing.Size(622, 46);
            this.addDataStatus.Style = Sunny.UI.UIStyle.Custom;
            this.addDataStatus.SymbolColor = System.Drawing.Color.White;
            this.addDataStatus.TabIndex = 17;
            this.addDataStatus.Text = "상태 정보";
            this.addDataStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 643);
            this.ControlBox = false;
            this.Controls.Add(this.centerLayout);
            this.Controls.Add(this.leftLayout);
            this.Controls.Add(this.topLayer);
            this.Name = "AddData";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.topLayer.ResumeLayout(false);
            this.leftLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topLayer;
        private System.Windows.Forms.Panel leftLayout;
        private System.Windows.Forms.Panel centerLayout;
        private Sunny.UI.UISymbolButton addCarExit;
        private Sunny.UI.UIHeaderButton addDataSell;
        private Sunny.UI.UIHeaderButton addDataCust;
        private Sunny.UI.UIHeaderButton addDataCar;
        private Sunny.UI.UIHeaderButton uiHeaderButton4;
        private Sunny.UI.UISymbolLabel addDataStatus;
    }
}