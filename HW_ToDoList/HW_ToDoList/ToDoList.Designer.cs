namespace HW_ToDoList
{
    partial class ToDoList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
            this.button_Exit = new System.Windows.Forms.Button();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.pictureBox_Down = new System.Windows.Forms.PictureBox();
            this.pictureBox_Up = new System.Windows.Forms.PictureBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_Minimaze = new System.Windows.Forms.Button();
            this.button_Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Up)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Exit
            // 
            this.button_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exit.Location = new System.Drawing.Point(570, 420);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 0;
            this.button_Exit.Text = "Выйти";
            this.button_Exit.UseVisualStyleBackColor = true;
            this.button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.LargeImageList = this.imageList1;
            this.listView.Location = new System.Drawing.Point(5, 5);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(500, 440);
            this.listView.SmallImageList = this.imageList1;
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Категория";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Описание";
            this.columnHeader2.Width = 400;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Work.png");
            this.imageList1.Images.SetKeyName(1, "Study.png");
            this.imageList1.Images.SetKeyName(2, "family.png");
            this.imageList1.Images.SetKeyName(3, "House.png");
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(585, 75);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 35);
            this.button_Add.TabIndex = 2;
            this.button_Add.Text = "Добавить";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.Button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(585, 115);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 35);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.Button_Delete_Click);
            // 
            // pictureBox_Down
            // 
            this.pictureBox_Down.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_Down.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Down.Image = global::HW_ToDoList.Properties.Resources.ArrowDown;
            this.pictureBox_Down.Location = new System.Drawing.Point(525, 115);
            this.pictureBox_Down.Name = "pictureBox_Down";
            this.pictureBox_Down.Size = new System.Drawing.Size(30, 35);
            this.pictureBox_Down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Down.TabIndex = 3;
            this.pictureBox_Down.TabStop = false;
            this.pictureBox_Down.Click += new System.EventHandler(this.PictureBox_Down_Click);
            // 
            // pictureBox_Up
            // 
            this.pictureBox_Up.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox_Up.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox_Up.Image = global::HW_ToDoList.Properties.Resources.ArrowUp;
            this.pictureBox_Up.Location = new System.Drawing.Point(525, 75);
            this.pictureBox_Up.Name = "pictureBox_Up";
            this.pictureBox_Up.Size = new System.Drawing.Size(30, 35);
            this.pictureBox_Up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_Up.TabIndex = 3;
            this.pictureBox_Up.TabStop = false;
            this.pictureBox_Up.Click += new System.EventHandler(this.PictureBox_Up_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(590, 180);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 35);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // button_Close
            // 
            this.button_Close.Location = new System.Drawing.Point(640, 5);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(25, 23);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "X";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // button_Minimaze
            // 
            this.button_Minimaze.Location = new System.Drawing.Point(610, 5);
            this.button_Minimaze.Name = "button_Minimaze";
            this.button_Minimaze.Size = new System.Drawing.Size(25, 23);
            this.button_Minimaze.TabIndex = 6;
            this.button_Minimaze.Text = "_";
            this.button_Minimaze.UseVisualStyleBackColor = true;
            this.button_Minimaze.Click += new System.EventHandler(this.Button_Minimaze_Click);
            // 
            // button_Load
            // 
            this.button_Load.Location = new System.Drawing.Point(510, 180);
            this.button_Load.Name = "button_Load";
            this.button_Load.Size = new System.Drawing.Size(75, 35);
            this.button_Load.TabIndex = 7;
            this.button_Load.Text = "Открыть";
            this.button_Load.UseVisualStyleBackColor = true;
            this.button_Load.Click += new System.EventHandler(this.Button_Load_Click);
            // 
            // ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.Controls.Add(this.button_Load);
            this.Controls.Add(this.button_Minimaze);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.pictureBox_Down);
            this.Controls.Add(this.pictureBox_Up);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.button_Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToDoList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDoList";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToDoList_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Up)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox_Up;
        private System.Windows.Forms.PictureBox pictureBox_Down;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_Minimaze;
        private System.Windows.Forms.Button button_Load;
    }
}