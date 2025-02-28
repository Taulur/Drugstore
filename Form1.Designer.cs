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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Все");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Антибактериальные препараты");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Гормоны");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Диагностические средства");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Препараты, влияющие на иммунитет");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Препараты влияющие на метаболизм");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Препараты влияющие на психику");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Препараты, влияющие на тонус сосудов");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Препараты, влияющие на свертываемость крови");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Препараты, влияющие на функцию бронхов");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Препараты, влияющие на функции желудочно-кишечного тракта");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Все");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("жидкие");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("твердые");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("мягкие");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("аэрозоли");
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 65);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел0";
            treeNode1.Text = "Все";
            treeNode2.Name = "Узел0";
            treeNode2.Text = "Антибактериальные препараты";
            treeNode3.Name = "Узел1";
            treeNode3.Text = "Гормоны";
            treeNode4.Name = "Узел2";
            treeNode4.Text = "Диагностические средства";
            treeNode5.Name = "Узел3";
            treeNode5.Text = "Препараты, влияющие на иммунитет";
            treeNode6.Name = "Узел4";
            treeNode6.Text = "Препараты влияющие на метаболизм";
            treeNode7.Name = "Узел5";
            treeNode7.Text = "Препараты влияющие на психику";
            treeNode8.Name = "Узел7";
            treeNode8.Text = "Препараты, влияющие на тонус сосудов";
            treeNode9.Name = "Узел6";
            treeNode9.Text = "Препараты, влияющие на свертываемость крови";
            treeNode10.Name = "Узел8";
            treeNode10.Text = "Препараты, влияющие на функцию бронхов";
            treeNode11.Name = "Узел9";
            treeNode11.Text = "Препараты, влияющие на функции желудочно-кишечного тракта";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode10,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(486, 426);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // treeView2
            // 
            this.treeView2.Location = new System.Drawing.Point(504, 65);
            this.treeView2.Name = "treeView2";
            treeNode12.Name = "Узел0";
            treeNode12.Text = "Все";
            treeNode13.Name = "Узел0";
            treeNode13.Text = "жидкие";
            treeNode14.Name = "Узел1";
            treeNode14.Text = "твердые";
            treeNode15.Name = "Узел2";
            treeNode15.Text = "мягкие";
            treeNode16.Name = "Узел3";
            treeNode16.Text = "аэрозоли";
            this.treeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16});
            this.treeView2.Size = new System.Drawing.Size(134, 426);
            this.treeView2.TabIndex = 1;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(644, 65);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(567, 426);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(465, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 26);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 503);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Аптека";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeView2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

