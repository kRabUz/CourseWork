namespace CourseWork
{
    partial class WatchAdmin
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
            this.RouteBox = new System.Windows.Forms.ComboBox();
            this.ShipRemove = new System.Windows.Forms.Button();
            this.ShipAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.TypeEngineBox = new System.Windows.Forms.ComboBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.RouteList = new System.Windows.Forms.ListBox();
            this.CostList = new System.Windows.Forms.ListBox();
            this.TypeEngineList = new System.Windows.Forms.ListBox();
            this.TypeList = new System.Windows.Forms.ListBox();
            this.NameList = new System.Windows.Forms.ListBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RouteBox
            // 
            this.RouteBox.FormattingEnabled = true;
            this.RouteBox.Items.AddRange(new object[] {
            "Odessa ---> Liverpool",
            "Odessa ---> Gdańsk",
            "Odessa ---> Constanța"});
            this.RouteBox.Location = new System.Drawing.Point(558, 329);
            this.RouteBox.Name = "RouteBox";
            this.RouteBox.Size = new System.Drawing.Size(201, 21);
            this.RouteBox.TabIndex = 52;
            // 
            // ShipRemove
            // 
            this.ShipRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShipRemove.Location = new System.Drawing.Point(149, 356);
            this.ShipRemove.Name = "ShipRemove";
            this.ShipRemove.Size = new System.Drawing.Size(115, 34);
            this.ShipRemove.TabIndex = 51;
            this.ShipRemove.Text = "Видалити";
            this.ShipRemove.UseVisualStyleBackColor = true;
            this.ShipRemove.Click += new System.EventHandler(this.ShipRemove_Click);
            // 
            // ShipAdd
            // 
            this.ShipAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShipAdd.Location = new System.Drawing.Point(28, 356);
            this.ShipAdd.Name = "ShipAdd";
            this.ShipAdd.Size = new System.Drawing.Size(115, 34);
            this.ShipAdd.TabIndex = 50;
            this.ShipAdd.Text = "Додати";
            this.ShipAdd.UseVisualStyleBackColor = true;
            this.ShipAdd.Click += new System.EventHandler(this.ShipAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label4.Location = new System.Drawing.Point(409, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 49;
            this.label4.Text = "Вартість судна";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label3.Location = new System.Drawing.Point(275, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 26);
            this.label3.TabIndex = 48;
            this.label3.Text = "Тип двигуна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label2.Location = new System.Drawing.Point(156, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 47;
            this.label2.Text = "Тип судна ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label7.Location = new System.Drawing.Point(25, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 26);
            this.label7.TabIndex = 46;
            this.label7.Text = "Назва судна";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.label6.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label6.Location = new System.Drawing.Point(562, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 26);
            this.label6.TabIndex = 45;
            this.label6.Text = "    Маршрут судна    ";
            // 
            // CostBox
            // 
            this.CostBox.Location = new System.Drawing.Point(406, 330);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(146, 20);
            this.CostBox.TabIndex = 44;
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Passenger",
            "Conteiner",
            "Tanker"});
            this.TypeBox.Location = new System.Drawing.Point(154, 329);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(120, 21);
            this.TypeBox.TabIndex = 43;
            // 
            // TypeEngineBox
            // 
            this.TypeEngineBox.FormattingEnabled = true;
            this.TypeEngineBox.Items.AddRange(new object[] {
            "Nuclear-powered",
            "Steam-powered",
            "Motor"});
            this.TypeEngineBox.Location = new System.Drawing.Point(280, 329);
            this.TypeEngineBox.Name = "TypeEngineBox";
            this.TypeEngineBox.Size = new System.Drawing.Size(120, 21);
            this.TypeEngineBox.TabIndex = 42;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(30, 330);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(120, 20);
            this.NameBox.TabIndex = 41;
            // 
            // RouteList
            // 
            this.RouteList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RouteList.FormattingEnabled = true;
            this.RouteList.ItemHeight = 19;
            this.RouteList.Location = new System.Drawing.Point(560, 129);
            this.RouteList.Name = "RouteList";
            this.RouteList.Size = new System.Drawing.Size(201, 194);
            this.RouteList.TabIndex = 40;
            this.RouteList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RouteList_MouseClick);
            // 
            // CostList
            // 
            this.CostList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CostList.FormattingEnabled = true;
            this.CostList.ItemHeight = 19;
            this.CostList.Location = new System.Drawing.Point(406, 129);
            this.CostList.Name = "CostList";
            this.CostList.Size = new System.Drawing.Size(148, 194);
            this.CostList.TabIndex = 39;
            this.CostList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CostList_MouseClick);
            // 
            // TypeEngineList
            // 
            this.TypeEngineList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeEngineList.FormattingEnabled = true;
            this.TypeEngineList.ItemHeight = 19;
            this.TypeEngineList.Location = new System.Drawing.Point(280, 129);
            this.TypeEngineList.Name = "TypeEngineList";
            this.TypeEngineList.Size = new System.Drawing.Size(120, 194);
            this.TypeEngineList.TabIndex = 38;
            this.TypeEngineList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TypeEngineList_MouseClick);
            // 
            // TypeList
            // 
            this.TypeList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeList.FormattingEnabled = true;
            this.TypeList.ItemHeight = 19;
            this.TypeList.Location = new System.Drawing.Point(154, 129);
            this.TypeList.Name = "TypeList";
            this.TypeList.Size = new System.Drawing.Size(120, 194);
            this.TypeList.TabIndex = 37;
            this.TypeList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TypeList_MouseClick);
            // 
            // NameList
            // 
            this.NameList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameList.FormattingEnabled = true;
            this.NameList.ItemHeight = 19;
            this.NameList.Location = new System.Drawing.Point(28, 129);
            this.NameList.Name = "NameList";
            this.NameList.Size = new System.Drawing.Size(120, 194);
            this.NameList.TabIndex = 36;
            this.NameList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.NameList_MouseClick);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.Gold;
            this.BackButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(668, 391);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(103, 39);
            this.BackButton.TabIndex = 35;
            this.BackButton.Text = "Назад";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(115)))), ((int)(((byte)(182)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 66);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Редагування інформації";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WatchAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(232)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RouteBox);
            this.Controls.Add(this.ShipRemove);
            this.Controls.Add(this.ShipAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.TypeEngineBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.RouteList);
            this.Controls.Add(this.CostList);
            this.Controls.Add(this.TypeEngineList);
            this.Controls.Add(this.TypeList);
            this.Controls.Add(this.NameList);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.panel1);
            this.Name = "WatchAdmin";
            this.Text = "WatchAdmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RouteBox;
        private System.Windows.Forms.Button ShipRemove;
        private System.Windows.Forms.Button ShipAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.ComboBox TypeEngineBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.ListBox RouteList;
        private System.Windows.Forms.ListBox CostList;
        private System.Windows.Forms.ListBox TypeEngineList;
        private System.Windows.Forms.ListBox TypeList;
        private System.Windows.Forms.ListBox NameList;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}