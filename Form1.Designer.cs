namespace Inventory_control
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.入荷 = new System.Windows.Forms.Button();
            this.出荷 = new System.Windows.Forms.Button();
            this.登録 = new System.Windows.Forms.Button();
            this.バーコード = new System.Windows.Forms.Button();
            this.一覧 = new System.Windows.Forms.Button();
            this.グラフ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 入荷
            // 
            this.入荷.Location = new System.Drawing.Point(102, 25);
            this.入荷.Name = "入荷";
            this.入荷.Size = new System.Drawing.Size(226, 86);
            this.入荷.TabIndex = 0;
            this.入荷.Tag = "";
            this.入荷.Text = "入荷";
            this.入荷.UseVisualStyleBackColor = true;
            this.入荷.Click += new System.EventHandler(this.button1_Click);
            // 
            // 出荷
            // 
            this.出荷.Location = new System.Drawing.Point(102, 136);
            this.出荷.Name = "出荷";
            this.出荷.Size = new System.Drawing.Size(226, 86);
            this.出荷.TabIndex = 0;
            this.出荷.Text = "出荷";
            this.出荷.UseVisualStyleBackColor = true;
            this.出荷.Click += new System.EventHandler(this.button2_Click);
            // 
            // 登録
            // 
            this.登録.Location = new System.Drawing.Point(102, 245);
            this.登録.Name = "登録";
            this.登録.Size = new System.Drawing.Size(226, 86);
            this.登録.TabIndex = 0;
            this.登録.Text = "登録";
            this.登録.UseVisualStyleBackColor = true;
            this.登録.Click += new System.EventHandler(this.button1_Click);
            // 
            // バーコード
            // 
            this.バーコード.Location = new System.Drawing.Point(424, 25);
            this.バーコード.Name = "バーコード";
            this.バーコード.Size = new System.Drawing.Size(226, 86);
            this.バーコード.TabIndex = 0;
            this.バーコード.Text = "バーコード";
            this.バーコード.UseVisualStyleBackColor = true;
            this.バーコード.Click += new System.EventHandler(this.button1_Click);
            // 
            // 一覧
            // 
            this.一覧.Location = new System.Drawing.Point(424, 136);
            this.一覧.Name = "一覧";
            this.一覧.Size = new System.Drawing.Size(226, 86);
            this.一覧.TabIndex = 0;
            this.一覧.Text = "一覧";
            this.一覧.UseVisualStyleBackColor = true;
            this.一覧.Click += new System.EventHandler(this.button2_Click);
            // 
            // グラフ
            // 
            this.グラフ.Location = new System.Drawing.Point(424, 245);
            this.グラフ.Name = "グラフ";
            this.グラフ.Size = new System.Drawing.Size(226, 86);
            this.グラフ.TabIndex = 0;
            this.グラフ.Text = "グラフ";
            this.グラフ.UseVisualStyleBackColor = true;
            this.グラフ.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.グラフ);
            this.Controls.Add(this.一覧);
            this.Controls.Add(this.登録);
            this.Controls.Add(this.バーコード);
            this.Controls.Add(this.出荷);
            this.Controls.Add(this.入荷);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button 出荷;
        private System.Windows.Forms.Button バーコード;
        private System.Windows.Forms.Button 一覧;
        private System.Windows.Forms.Button グラフ;
        public System.Windows.Forms.Button 入荷;
        public System.Windows.Forms.Button 登録;
    }
}

