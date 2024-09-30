namespace HDD_Abstract_HamTruuTuong
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_IT = new Button();
            btn_Bizz = new Button();
            txt_Css = new TextBox();
            txt_Java = new TextBox();
            txt_MKTing = new TextBox();
            txt_KT = new TextBox();
            txt_Bhang = new TextBox();
            SuspendLayout();
            // 
            // btn_IT
            // 
            btn_IT.Location = new Point(113, 356);
            btn_IT.Name = "btn_IT";
            btn_IT.Size = new Size(90, 34);
            btn_IT.TabIndex = 0;
            btn_IT.Text = "SinhvienIT";
            btn_IT.UseVisualStyleBackColor = true;
            btn_IT.Click += btn_IT_Click;
            // 
            // btn_Bizz
            // 
            btn_Bizz.Location = new Point(490, 356);
            btn_Bizz.Name = "btn_Bizz";
            btn_Bizz.RightToLeft = RightToLeft.No;
            btn_Bizz.Size = new Size(90, 34);
            btn_Bizz.TabIndex = 0;
            btn_Bizz.Text = "SinhvienBizz";
            btn_Bizz.UseVisualStyleBackColor = true;
            btn_Bizz.Click += Form1_Click;
            // 
            // txt_Css
            // 
            txt_Css.Location = new Point(109, 301);
            txt_Css.Name = "txt_Css";
            txt_Css.Size = new Size(100, 24);
            txt_Css.TabIndex = 1;
            // 
            // txt_Java
            // 
            txt_Java.Location = new Point(109, 271);
            txt_Java.Name = "txt_Java";
            txt_Java.Size = new Size(100, 24);
            txt_Java.TabIndex = 1;
            // 
            // txt_MKTing
            // 
            txt_MKTing.Location = new Point(490, 301);
            txt_MKTing.Name = "txt_MKTing";
            txt_MKTing.Size = new Size(100, 24);
            txt_MKTing.TabIndex = 1;
            // 
            // txt_KT
            // 
            txt_KT.Location = new Point(490, 271);
            txt_KT.Name = "txt_KT";
            txt_KT.Size = new Size(100, 24);
            txt_KT.TabIndex = 1;
            // 
            // txt_Bhang
            // 
            txt_Bhang.Location = new Point(490, 241);
            txt_Bhang.Name = "txt_Bhang";
            txt_Bhang.Size = new Size(100, 24);
            txt_Bhang.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 480);
            Controls.Add(txt_Bhang);
            Controls.Add(txt_KT);
            Controls.Add(txt_Java);
            Controls.Add(txt_MKTing);
            Controls.Add(txt_Css);
            Controls.Add(btn_Bizz);
            Controls.Add(btn_IT);
            Font = new Font("Tahoma", 10F);
            Name = "Form1";
            Text = "Form1";
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_IT;
        private Button btn_Bizz;
        private TextBox txt_Css;
        private TextBox txt_Java;
        private TextBox txt_MKTing;
        private TextBox txt_KT;
        private TextBox txt_Bhang;
    }
}
