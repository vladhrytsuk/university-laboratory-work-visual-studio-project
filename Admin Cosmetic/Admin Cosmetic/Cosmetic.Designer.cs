namespace Admin_Cosmetic
{
    partial class Cosmetic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cosmetic));
            this.label1 = new System.Windows.Forms.Label();
            this.admin_CosmeticDataSet = new Admin_Cosmetic.Admin_CosmeticDataSet();
            this.cosmeticBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cosmeticTableAdapter = new Admin_Cosmetic.Admin_CosmeticDataSetTableAdapters.CosmeticTableAdapter();
            this.tableAdapterManager = new Admin_Cosmetic.Admin_CosmeticDataSetTableAdapters.TableAdapterManager();
            this.cosmeticBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.cosmeticBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cosmeticDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.admin_CosmeticDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticBindingNavigator)).BeginInit();
            this.cosmeticBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(104, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Справочник \"Косметические материалы\"";
            // 
            // admin_CosmeticDataSet
            // 
            this.admin_CosmeticDataSet.DataSetName = "Admin_CosmeticDataSet";
            this.admin_CosmeticDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cosmeticBindingSource
            // 
            this.cosmeticBindingSource.DataMember = "Cosmetic";
            this.cosmeticBindingSource.DataSource = this.admin_CosmeticDataSet;
            // 
            // cosmeticTableAdapter
            // 
            this.cosmeticTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.CosmeticTableAdapter = this.cosmeticTableAdapter;
            this.tableAdapterManager.CotalogTableAdapter = null;
            this.tableAdapterManager.DPRCTableAdapter = null;
            this.tableAdapterManager.KOTVTableAdapter = null;
            this.tableAdapterManager.TariphsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Admin_Cosmetic.Admin_CosmeticDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.ZNOYTableAdapter = null;
            // 
            // cosmeticBindingNavigator
            // 
            this.cosmeticBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cosmeticBindingNavigator.BindingSource = this.cosmeticBindingSource;
            this.cosmeticBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cosmeticBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cosmeticBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cosmeticBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.cosmeticBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cosmeticBindingNavigatorSaveItem});
            this.cosmeticBindingNavigator.Location = new System.Drawing.Point(0, 258);
            this.cosmeticBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cosmeticBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cosmeticBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cosmeticBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cosmeticBindingNavigator.Name = "cosmeticBindingNavigator";
            this.cosmeticBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cosmeticBindingNavigator.Size = new System.Drawing.Size(546, 25);
            this.cosmeticBindingNavigator.TabIndex = 2;
            this.cosmeticBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // cosmeticBindingNavigatorSaveItem
            // 
            this.cosmeticBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cosmeticBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cosmeticBindingNavigatorSaveItem.Image")));
            this.cosmeticBindingNavigatorSaveItem.Name = "cosmeticBindingNavigatorSaveItem";
            this.cosmeticBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cosmeticBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.cosmeticBindingNavigatorSaveItem.Click += new System.EventHandler(this.cosmeticBindingNavigatorSaveItem_Click);
            // 
            // cosmeticDataGridView
            // 
            this.cosmeticDataGridView.AutoGenerateColumns = false;
            this.cosmeticDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cosmeticDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.cosmeticDataGridView.DataSource = this.cosmeticBindingSource;
            this.cosmeticDataGridView.Location = new System.Drawing.Point(0, 34);
            this.cosmeticDataGridView.Name = "cosmeticDataGridView";
            this.cosmeticDataGridView.Size = new System.Drawing.Size(545, 220);
            this.cosmeticDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_косметического_материла";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_косметического_материла";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Наименование_косметического_материала";
            this.dataGridViewTextBoxColumn2.HeaderText = "Наименование_косметического_материала";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Сорт_косметического_материала";
            this.dataGridViewTextBoxColumn3.HeaderText = "Сорт_косметического_материала";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Производитель";
            this.dataGridViewTextBoxColumn4.HeaderText = "Производитель";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Стоимость_единицы";
            this.dataGridViewTextBoxColumn5.HeaderText = "Стоимость_единицы";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Cosmetic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 283);
            this.Controls.Add(this.cosmeticDataGridView);
            this.Controls.Add(this.cosmeticBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Cosmetic";
            this.Text = "Справочник \"Косметические материалы\"";
            this.Load += new System.EventHandler(this.Cosmetic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.admin_CosmeticDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticBindingNavigator)).EndInit();
            this.cosmeticBindingNavigator.ResumeLayout(false);
            this.cosmeticBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cosmeticDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Admin_CosmeticDataSet admin_CosmeticDataSet;
        private System.Windows.Forms.BindingSource cosmeticBindingSource;
        private Admin_CosmeticDataSetTableAdapters.CosmeticTableAdapter cosmeticTableAdapter;
        private Admin_CosmeticDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cosmeticBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cosmeticBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView cosmeticDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}