namespace Admin_Cosmetic
{
    partial class Cotalog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cotalog));
            this.label1 = new System.Windows.Forms.Label();
            this.admin_CosmeticDataSet = new Admin_Cosmetic.Admin_CosmeticDataSet();
            this.cotalogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cotalogTableAdapter = new Admin_Cosmetic.Admin_CosmeticDataSetTableAdapters.CotalogTableAdapter();
            this.tableAdapterManager = new Admin_Cosmetic.Admin_CosmeticDataSetTableAdapters.TableAdapterManager();
            this.cotalogBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cotalogBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cotalogDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.admin_CosmeticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotalogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotalogBindingNavigator)).BeginInit();
            this.cotalogBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cotalogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(39, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Справочник \"Каталог услуг\"";
            // 
            // admin_CosmeticDataSet
            // 
            this.admin_CosmeticDataSet.DataSetName = "Admin_CosmeticDataSet";
            this.admin_CosmeticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cotalogBindingSource
            // 
            this.cotalogBindingSource.DataMember = "Cotalog";
            this.cotalogBindingSource.DataSource = this.admin_CosmeticDataSet;
            // 
            // cotalogTableAdapter
            // 
            this.cotalogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CosmeticTableAdapter = null;
            this.tableAdapterManager.CotalogTableAdapter = this.cotalogTableAdapter;
            this.tableAdapterManager.DPRCTableAdapter = null;
            this.tableAdapterManager.KOTVTableAdapter = null;
            this.tableAdapterManager.TariphsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Admin_Cosmetic.Admin_CosmeticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.ZNOYTableAdapter = null;
            // 
            // cotalogBindingNavigator
            // 
            this.cotalogBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cotalogBindingNavigator.BindingSource = this.cotalogBindingSource;
            this.cotalogBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cotalogBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cotalogBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cotalogBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cotalogBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.cotalogBindingNavigatorSaveItem});
            this.cotalogBindingNavigator.Location = new System.Drawing.Point(0, 298);
            this.cotalogBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cotalogBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cotalogBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cotalogBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cotalogBindingNavigator.Name = "cotalogBindingNavigator";
            this.cotalogBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cotalogBindingNavigator.Size = new System.Drawing.Size(344, 25);
            this.cotalogBindingNavigator.TabIndex = 2;
            this.cotalogBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cotalogBindingNavigatorSaveItem
            // 
            this.cotalogBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cotalogBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cotalogBindingNavigatorSaveItem.Image")));
            this.cotalogBindingNavigatorSaveItem.Name = "cotalogBindingNavigatorSaveItem";
            this.cotalogBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cotalogBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.cotalogBindingNavigatorSaveItem.Click += new System.EventHandler(this.cotalogBindingNavigatorSaveItem_Click);
            // 
            // cotalogDataGridView
            // 
            this.cotalogDataGridView.AutoGenerateColumns = false;
            this.cotalogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cotalogDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.cotalogDataGridView.DataSource = this.cotalogBindingSource;
            this.cotalogDataGridView.Location = new System.Drawing.Point(0, 34);
            this.cotalogDataGridView.Name = "cotalogDataGridView";
            this.cotalogDataGridView.Size = new System.Drawing.Size(344, 261);
            this.cotalogDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_услуги";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_услуги";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование_услуги";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование_услуги";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Время_выполнения_услуги";
            this.dataGridViewTextBoxColumn3.HeaderText = "Время_выполнения_услуги";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // Cotalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 323);
            this.Controls.Add(this.cotalogDataGridView);
            this.Controls.Add(this.cotalogBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Cotalog";
            this.Text = "Справочник \"Каталог услуг\"";
            this.Load += new System.EventHandler(this.Cotalog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_CosmeticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotalogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cotalogBindingNavigator)).EndInit();
            this.cotalogBindingNavigator.ResumeLayout(false);
            this.cotalogBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cotalogDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Admin_CosmeticDataSet admin_CosmeticDataSet;
        private System.Windows.Forms.BindingSource cotalogBindingSource;
        private Admin_CosmeticDataSetTableAdapters.CotalogTableAdapter cotalogTableAdapter;
        private Admin_CosmeticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cotalogBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton cotalogBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cotalogDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}