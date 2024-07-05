namespace KafeBar2
{
    partial class AddOrder
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.label1 = new System.Windows.Forms.Label();
            this.tbType = new System.Windows.Forms.TextBox();
            this.cbSugar = new System.Windows.Forms.CheckBox();
            this.cbNoSugar = new System.Windows.Forms.CheckBox();
            this.cbLarge = new System.Windows.Forms.CheckBox();
            this.cbSmall = new System.Windows.Forms.CheckBox();
            this.cbHot = new System.Windows.Forms.CheckBox();
            this.cbCold = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCountity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudCountity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(354, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тип:";
            // 
            // tbType
            // 
            this.tbType.Location = new System.Drawing.Point(286, 246);
            this.tbType.Name = "tbType";
            this.tbType.Size = new System.Drawing.Size(217, 22);
            this.tbType.TabIndex = 1;
            this.tbType.Validating += new System.ComponentModel.CancelEventHandler(this.tbType_Validating_1);
            // 
            // cbSugar
            // 
            this.cbSugar.AutoSize = true;
            this.cbSugar.BackColor = System.Drawing.Color.Transparent;
            this.cbSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSugar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbSugar.Location = new System.Drawing.Point(286, 274);
            this.cbSugar.Name = "cbSugar";
            this.cbSugar.Size = new System.Drawing.Size(97, 20);
            this.cbSugar.TabIndex = 2;
            this.cbSugar.Text = "Со шеќер";
            this.cbSugar.UseVisualStyleBackColor = false;
            // 
            // cbNoSugar
            // 
            this.cbNoSugar.AutoSize = true;
            this.cbNoSugar.BackColor = System.Drawing.Color.Transparent;
            this.cbNoSugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNoSugar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbNoSugar.Location = new System.Drawing.Point(397, 274);
            this.cbNoSugar.Name = "cbNoSugar";
            this.cbNoSugar.Size = new System.Drawing.Size(106, 20);
            this.cbNoSugar.TabIndex = 3;
            this.cbNoSugar.Text = "Без шеќер";
            this.cbNoSugar.UseVisualStyleBackColor = false;
            // 
            // cbLarge
            // 
            this.cbLarge.AutoSize = true;
            this.cbLarge.BackColor = System.Drawing.Color.Transparent;
            this.cbLarge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLarge.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbLarge.Location = new System.Drawing.Point(286, 300);
            this.cbLarge.Name = "cbLarge";
            this.cbLarge.Size = new System.Drawing.Size(83, 20);
            this.cbLarge.TabIndex = 4;
            this.cbLarge.Text = "Големо";
            this.cbLarge.UseVisualStyleBackColor = false;
            // 
            // cbSmall
            // 
            this.cbSmall.AutoSize = true;
            this.cbSmall.BackColor = System.Drawing.Color.Transparent;
            this.cbSmall.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSmall.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbSmall.Location = new System.Drawing.Point(397, 300);
            this.cbSmall.Name = "cbSmall";
            this.cbSmall.Size = new System.Drawing.Size(68, 20);
            this.cbSmall.TabIndex = 5;
            this.cbSmall.Text = "Мало";
            this.cbSmall.UseVisualStyleBackColor = false;
            // 
            // cbHot
            // 
            this.cbHot.AutoSize = true;
            this.cbHot.BackColor = System.Drawing.Color.Transparent;
            this.cbHot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHot.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbHot.Location = new System.Drawing.Point(286, 326);
            this.cbHot.Name = "cbHot";
            this.cbHot.Size = new System.Drawing.Size(75, 20);
            this.cbHot.TabIndex = 6;
            this.cbHot.Text = "Топло";
            this.cbHot.UseVisualStyleBackColor = false;
            // 
            // cbCold
            // 
            this.cbCold.AutoSize = true;
            this.cbCold.BackColor = System.Drawing.Color.Transparent;
            this.cbCold.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCold.ForeColor = System.Drawing.Color.SaddleBrown;
            this.cbCold.Location = new System.Drawing.Point(397, 326);
            this.cbCold.Name = "cbCold";
            this.cbCold.Size = new System.Drawing.Size(75, 20);
            this.cbCold.TabIndex = 7;
            this.cbCold.Text = "Ладно";
            this.cbCold.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label2.Location = new System.Drawing.Point(326, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Количина:";
            // 
            // nudCountity
            // 
            this.nudCountity.Location = new System.Drawing.Point(275, 372);
            this.nudCountity.Name = "nudCountity";
            this.nudCountity.Size = new System.Drawing.Size(217, 22);
            this.nudCountity.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(344, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Цена:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(264, 420);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(228, 22);
            this.tbPrice.TabIndex = 11;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnAddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnAddOrder.Location = new System.Drawing.Point(286, 448);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(105, 36);
            this.btnAddOrder.TabIndex = 12;
            this.btnAddOrder.Text = "Додади";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click_1);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelOrder.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnCancelOrder.Location = new System.Drawing.Point(404, 448);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(99, 36);
            this.btnCancelOrder.TabIndex = 13;
            this.btnCancelOrder.Text = "Откажи";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            this.btnCancelOrder.Click += new System.EventHandler(this.btnCancelOrder_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(730, 489);
            this.Controls.Add(this.btnCancelOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudCountity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCold);
            this.Controls.Add(this.cbHot);
            this.Controls.Add(this.cbSmall);
            this.Controls.Add(this.cbLarge);
            this.Controls.Add(this.cbNoSugar);
            this.Controls.Add(this.cbSugar);
            this.Controls.Add(this.tbType);
            this.Controls.Add(this.label1);
            this.Name = "AddOrder";
            this.Text = "AddOrder";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCountity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbType;
        private System.Windows.Forms.CheckBox cbSugar;
        private System.Windows.Forms.CheckBox cbNoSugar;
        private System.Windows.Forms.CheckBox cbLarge;
        private System.Windows.Forms.CheckBox cbSmall;
        private System.Windows.Forms.CheckBox cbHot;
        private System.Windows.Forms.CheckBox cbCold;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudCountity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}