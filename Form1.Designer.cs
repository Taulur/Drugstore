namespace DrugStore
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Антибактериальные препараты.");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Гормоны.");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Диагностические средства.");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Препараты, влияющие на иммунитет.");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Препараты влияющие на метаболизм.");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Препараты влияющие на психику.");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Препараты, влияющие на свертываемость крови.");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Препараты, влияющие на тонус сосудов.");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Препараты, влияющие на функцию бронхов.");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Препараты, влияющие на функции желудочно-кишечного тракта.");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Жидкие.");
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Твердые.");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Мягкие.");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Аэрозоли.");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            treeNode15.Name = "Узел0";
            treeNode15.Text = "Антибактериальные препараты.";
            treeNode16.Name = "Узел1";
            treeNode16.Text = "Гормоны.";
            treeNode17.Name = "Узел2";
            treeNode17.Text = "Диагностические средства.";
            treeNode18.Name = "Узел3";
            treeNode18.Text = "Препараты, влияющие на иммунитет.";
            treeNode19.Name = "Узел4";
            treeNode19.Text = "Препараты влияющие на метаболизм.";
            treeNode20.Name = "Узел5";
            treeNode20.Text = "Препараты влияющие на психику.";
            treeNode21.Name = "Узел6";
            treeNode21.Text = "Препараты, влияющие на свертываемость крови.";
            treeNode22.Name = "Узел7";
            treeNode22.Text = "Препараты, влияющие на тонус сосудов.";
            treeNode23.Name = "Узел8";
            treeNode23.Text = "Препараты, влияющие на функцию бронхов.";
            treeNode24.Name = "Узел9";
            treeNode24.Text = "Препараты, влияющие на функции желудочно-кишечного тракта.";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            this.treeView1.Size = new System.Drawing.Size(486, 426);
            this.treeView1.TabIndex = 0;
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(504, 12);
            this.treeView2.Name = "treeView2";
            treeNode25.Name = "Узел0";
            treeNode25.Text = "Жидкие.";
            treeNode26.Name = "Узел1";
            treeNode26.Text = "Твердые.";
            treeNode27.Name = "Узел2";
            treeNode27.Text = "Мягкие.";
            treeNode28.Name = "Узел3";
            treeNode28.Text = "Аэрозоли.";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode25,
            treeNode26,
            treeNode27,
            treeNode28});
            this.treeView2.Size = new System.Drawing.Size(134, 426);
            this.treeView2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(644, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(567, 426);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Аптека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

