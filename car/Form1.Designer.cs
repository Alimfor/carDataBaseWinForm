namespace car
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
            this.dgv = new System.Windows.Forms.DataGridView();
            this.makeCB = new System.Windows.Forms.ComboBox();
            this.modelCB = new System.Windows.Forms.ComboBox();
            this.colorCB = new System.Windows.Forms.ComboBox();
            this.mileageNUD = new System.Windows.Forms.NumericUpDown();
            this.yearNUD = new System.Windows.Forms.NumericUpDown();
            this.volumeNUD = new System.Windows.Forms.NumericUpDown();
            this.cityCB = new System.Windows.Forms.ComboBox();
            this.priceNUD = new System.Windows.Forms.NumericUpDown();
            this.mileageL = new System.Windows.Forms.Label();
            this.yearL = new System.Windows.Forms.Label();
            this.volumeL = new System.Windows.Forms.Label();
            this.priceL = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.delBtn = new System.Windows.Forms.Button();
            this.upBtn = new System.Windows.Forms.Button();
            this.idNUD = new System.Windows.Forms.NumericUpDown();
            this.idL = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mileageNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv.Location = new System.Drawing.Point(0, 0);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(800, 217);
            this.dgv.TabIndex = 0;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // makeCB
            // 
            this.makeCB.FormattingEnabled = true;
            this.makeCB.Location = new System.Drawing.Point(244, 237);
            this.makeCB.Name = "makeCB";
            this.makeCB.Size = new System.Drawing.Size(121, 21);
            this.makeCB.TabIndex = 1;
            this.makeCB.Text = "Марка";
            this.makeCB.Click += new System.EventHandler(this.makeCB_Click);
            // 
            // modelCB
            // 
            this.modelCB.FormattingEnabled = true;
            this.modelCB.Location = new System.Drawing.Point(371, 237);
            this.modelCB.Name = "modelCB";
            this.modelCB.Size = new System.Drawing.Size(121, 21);
            this.modelCB.TabIndex = 2;
            this.modelCB.Text = "Модель";
            this.modelCB.Click += new System.EventHandler(this.modelCB_Click);
            // 
            // colorCB
            // 
            this.colorCB.FormattingEnabled = true;
            this.colorCB.Location = new System.Drawing.Point(498, 237);
            this.colorCB.Name = "colorCB";
            this.colorCB.Size = new System.Drawing.Size(121, 21);
            this.colorCB.TabIndex = 3;
            this.colorCB.Text = "Цвет";
            this.colorCB.Click += new System.EventHandler(this.colorCB_Click);
            // 
            // mileageNUD
            // 
            this.mileageNUD.Location = new System.Drawing.Point(85, 240);
            this.mileageNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.mileageNUD.Name = "mileageNUD";
            this.mileageNUD.Size = new System.Drawing.Size(120, 20);
            this.mileageNUD.TabIndex = 4;
            // 
            // yearNUD
            // 
            this.yearNUD.Location = new System.Drawing.Point(123, 281);
            this.yearNUD.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.yearNUD.Name = "yearNUD";
            this.yearNUD.Size = new System.Drawing.Size(120, 20);
            this.yearNUD.TabIndex = 5;
            // 
            // volumeNUD
            // 
            this.volumeNUD.Location = new System.Drawing.Point(139, 329);
            this.volumeNUD.Name = "volumeNUD";
            this.volumeNUD.Size = new System.Drawing.Size(120, 20);
            this.volumeNUD.TabIndex = 6;
            // 
            // cityCB
            // 
            this.cityCB.FormattingEnabled = true;
            this.cityCB.Location = new System.Drawing.Point(625, 237);
            this.cityCB.Name = "cityCB";
            this.cityCB.Size = new System.Drawing.Size(121, 21);
            this.cityCB.TabIndex = 7;
            this.cityCB.Text = "Город";
            this.cityCB.Click += new System.EventHandler(this.cityCB_Click);
            // 
            // priceNUD
            // 
            this.priceNUD.Location = new System.Drawing.Point(69, 376);
            this.priceNUD.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.priceNUD.Name = "priceNUD";
            this.priceNUD.Size = new System.Drawing.Size(120, 20);
            this.priceNUD.TabIndex = 8;
            // 
            // mileageL
            // 
            this.mileageL.AutoSize = true;
            this.mileageL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mileageL.Location = new System.Drawing.Point(16, 240);
            this.mileageL.Name = "mileageL";
            this.mileageL.Size = new System.Drawing.Size(63, 18);
            this.mileageL.TabIndex = 9;
            this.mileageL.Text = "Пробег:";
            // 
            // yearL
            // 
            this.yearL.AutoSize = true;
            this.yearL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearL.Location = new System.Drawing.Point(16, 281);
            this.yearL.Name = "yearL";
            this.yearL.Size = new System.Drawing.Size(101, 18);
            this.yearL.TabIndex = 10;
            this.yearL.Text = "Год выпуска:";
            // 
            // volumeL
            // 
            this.volumeL.AutoSize = true;
            this.volumeL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeL.Location = new System.Drawing.Point(16, 329);
            this.volumeL.Name = "volumeL";
            this.volumeL.Size = new System.Drawing.Size(117, 18);
            this.volumeL.TabIndex = 11;
            this.volumeL.Text = "Объем мотора:";
            // 
            // priceL
            // 
            this.priceL.AutoSize = true;
            this.priceL.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceL.Location = new System.Drawing.Point(16, 376);
            this.priceL.Name = "priceL";
            this.priceL.Size = new System.Drawing.Size(47, 17);
            this.priceL.TabIndex = 12;
            this.priceL.Text = "Цена:";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(441, 320);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(99, 38);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Найти";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(15, 415);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(372, 23);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Location = new System.Drawing.Point(546, 320);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(99, 38);
            this.delBtn.TabIndex = 15;
            this.delBtn.Text = "Удалить";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // upBtn
            // 
            this.upBtn.Location = new System.Drawing.Point(651, 320);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(99, 38);
            this.upBtn.TabIndex = 16;
            this.upBtn.Text = "Изменить";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // idNUD
            // 
            this.idNUD.Location = new System.Drawing.Point(546, 283);
            this.idNUD.Name = "idNUD";
            this.idNUD.Size = new System.Drawing.Size(133, 20);
            this.idNUD.TabIndex = 17;
            // 
            // idL
            // 
            this.idL.AutoSize = true;
            this.idL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.idL.Location = new System.Drawing.Point(517, 285);
            this.idL.Name = "idL";
            this.idL.Size = new System.Drawing.Size(23, 18);
            this.idL.TabIndex = 18;
            this.idL.Text = "id:";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(441, 400);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(99, 38);
            this.showBtn.TabIndex = 19;
            this.showBtn.Text = "Показать все";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(546, 400);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(99, 38);
            this.clearBtn.TabIndex = 20;
            this.clearBtn.Text = "Очистить поля";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(651, 400);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(99, 38);
            this.reportBtn.TabIndex = 21;
            this.reportBtn.Text = "Загрузить отчет";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.idL);
            this.Controls.Add(this.idNUD);
            this.Controls.Add(this.upBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.priceL);
            this.Controls.Add(this.volumeL);
            this.Controls.Add(this.yearL);
            this.Controls.Add(this.mileageL);
            this.Controls.Add(this.priceNUD);
            this.Controls.Add(this.cityCB);
            this.Controls.Add(this.volumeNUD);
            this.Controls.Add(this.yearNUD);
            this.Controls.Add(this.mileageNUD);
            this.Controls.Add(this.colorCB);
            this.Controls.Add(this.modelCB);
            this.Controls.Add(this.makeCB);
            this.Controls.Add(this.dgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mileageNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ComboBox makeCB;
        private System.Windows.Forms.ComboBox modelCB;
        private System.Windows.Forms.ComboBox colorCB;
        private System.Windows.Forms.NumericUpDown mileageNUD;
        private System.Windows.Forms.NumericUpDown yearNUD;
        private System.Windows.Forms.NumericUpDown volumeNUD;
        private System.Windows.Forms.ComboBox cityCB;
        private System.Windows.Forms.NumericUpDown priceNUD;
        private System.Windows.Forms.Label mileageL;
        private System.Windows.Forms.Label yearL;
        private System.Windows.Forms.Label volumeL;
        private System.Windows.Forms.Label priceL;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button delBtn;
        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.NumericUpDown idNUD;
        private System.Windows.Forms.Label idL;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button reportBtn;
    }
}

