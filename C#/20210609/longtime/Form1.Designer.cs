
namespace longtime
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
            this.button_Insa = new System.Windows.Forms.Button();
            this.button_output = new System.Windows.Forms.Button();
            this.button_txtWrite = new System.Windows.Forms.Button();
            this.textBox_contents = new System.Windows.Forms.TextBox();
            this.button_readText = new System.Windows.Forms.Button();
            this.textBox_memo = new System.Windows.Forms.TextBox();
            this.label_contents = new System.Windows.Forms.Label();
            this.button_continueWrite = new System.Windows.Forms.Button();
            this.button2_usingRead = new System.Windows.Forms.Button();
            this.label_from_using = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Insa
            // 
            this.button_Insa.Location = new System.Drawing.Point(12, 12);
            this.button_Insa.Name = "button_Insa";
            this.button_Insa.Size = new System.Drawing.Size(107, 23);
            this.button_Insa.TabIndex = 0;
            this.button_Insa.Text = "인사버튼";
            this.button_Insa.UseVisualStyleBackColor = true;
            this.button_Insa.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_output
            // 
            this.button_output.Location = new System.Drawing.Point(12, 60);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(107, 23);
            this.button_output.TabIndex = 1;
            this.button_output.Text = "텍스트박스내용";
            this.button_output.UseVisualStyleBackColor = true;
            this.button_output.Click += new System.EventHandler(this.button_output_Click);
            // 
            // button_txtWrite
            // 
            this.button_txtWrite.AutoSize = true;
            this.button_txtWrite.Location = new System.Drawing.Point(12, 108);
            this.button_txtWrite.Name = "button_txtWrite";
            this.button_txtWrite.Size = new System.Drawing.Size(107, 23);
            this.button_txtWrite.TabIndex = 2;
            this.button_txtWrite.Text = "메모장에 쓰기";
            this.button_txtWrite.UseVisualStyleBackColor = true;
            this.button_txtWrite.Click += new System.EventHandler(this.button_txtWrite_Click);
            // 
            // textBox_contents
            // 
            this.textBox_contents.Location = new System.Drawing.Point(139, 14);
            this.textBox_contents.Name = "textBox_contents";
            this.textBox_contents.Size = new System.Drawing.Size(100, 21);
            this.textBox_contents.TabIndex = 3;
            // 
            // button_readText
            // 
            this.button_readText.Location = new System.Drawing.Point(12, 162);
            this.button_readText.Name = "button_readText";
            this.button_readText.Size = new System.Drawing.Size(107, 23);
            this.button_readText.TabIndex = 4;
            this.button_readText.Text = "메모장에서 읽기";
            this.button_readText.UseVisualStyleBackColor = true;
            this.button_readText.Click += new System.EventHandler(this.button_readText_Click);
            // 
            // textBox_memo
            // 
            this.textBox_memo.Location = new System.Drawing.Point(139, 62);
            this.textBox_memo.Name = "textBox_memo";
            this.textBox_memo.Size = new System.Drawing.Size(100, 21);
            this.textBox_memo.TabIndex = 6;
            // 
            // label_contents
            // 
            this.label_contents.AutoSize = true;
            this.label_contents.Location = new System.Drawing.Point(147, 108);
            this.label_contents.Name = "label_contents";
            this.label_contents.Size = new System.Drawing.Size(38, 12);
            this.label_contents.TabIndex = 7;
            this.label_contents.Text = "label1";
            // 
            // button_continueWrite
            // 
            this.button_continueWrite.Location = new System.Drawing.Point(12, 219);
            this.button_continueWrite.Name = "button_continueWrite";
            this.button_continueWrite.Size = new System.Drawing.Size(107, 23);
            this.button_continueWrite.TabIndex = 10;
            this.button_continueWrite.Text = "이어서적기";
            this.button_continueWrite.UseVisualStyleBackColor = true;
            this.button_continueWrite.Click += new System.EventHandler(this.button_continueWrite_Click);
            // 
            // button2_usingRead
            // 
            this.button2_usingRead.AutoSize = true;
            this.button2_usingRead.Location = new System.Drawing.Point(12, 265);
            this.button2_usingRead.Name = "button2_usingRead";
            this.button2_usingRead.Size = new System.Drawing.Size(107, 23);
            this.button2_usingRead.TabIndex = 11;
            this.button2_usingRead.Text = "using으로 읽기";
            this.button2_usingRead.UseVisualStyleBackColor = true;
            this.button2_usingRead.Click += new System.EventHandler(this.button2_usingRead_Click);
            // 
            // label_from_using
            // 
            this.label_from_using.AutoSize = true;
            this.label_from_using.Location = new System.Drawing.Point(147, 270);
            this.label_from_using.Name = "label_from_using";
            this.label_from_using.Size = new System.Drawing.Size(38, 12);
            this.label_from_using.TabIndex = 12;
            this.label_from_using.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(329, 369);
            this.button1.TabIndex = 13;
            this.button1.Text = "종료";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 364);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_from_using);
            this.Controls.Add(this.button2_usingRead);
            this.Controls.Add(this.button_continueWrite);
            this.Controls.Add(this.label_contents);
            this.Controls.Add(this.textBox_memo);
            this.Controls.Add(this.button_readText);
            this.Controls.Add(this.textBox_contents);
            this.Controls.Add(this.button_txtWrite);
            this.Controls.Add(this.button_output);
            this.Controls.Add(this.button_Insa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Insa;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.Button button_txtWrite;
        private System.Windows.Forms.TextBox textBox_contents;
        private System.Windows.Forms.Button button_readText;
        private System.Windows.Forms.TextBox textBox_memo;
        private System.Windows.Forms.Label label_contents;
        private System.Windows.Forms.Button button_continueWrite;
        private System.Windows.Forms.Button button2_usingRead;
        private System.Windows.Forms.Label label_from_using;
        private System.Windows.Forms.Button button1;
    }
}

