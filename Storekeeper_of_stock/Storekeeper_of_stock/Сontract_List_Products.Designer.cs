namespace Storekeeper_of_stock
{
    partial class Сontract_List_Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Сontract_List_Products));
            this.label1 = new System.Windows.Forms.Label();
            this.storekeeper_of_stockDataSet = new Storekeeper_of_stock.Storekeeper_of_stockDataSet();
            this.сontract_List_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сontract_List_ProductsTableAdapter = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.Сontract_List_ProductsTableAdapter();
            this.tableAdapterManager = new Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.TableAdapterManager();
            this.сontract_List_ProductsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.сontract_List_ProductsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.сontract_List_ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.storekeeper_of_stockDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сontract_List_ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сontract_List_ProductsBindingNavigator)).BeginInit();
            this.сontract_List_ProductsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сontract_List_ProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(172, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Список поставляемого сырья";
            // 
            // storekeeper_of_stockDataSet
            // 
            this.storekeeper_of_stockDataSet.DataSetName = "Storekeeper_of_stockDataSet";
            this.storekeeper_of_stockDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сontract_List_ProductsBindingSource
            // 
            this.сontract_List_ProductsBindingSource.DataMember = "Сontract_List_Products";
            this.сontract_List_ProductsBindingSource.DataSource = this.storekeeper_of_stockDataSet;
            // 
            // сontract_List_ProductsTableAdapter
            // 
            this.сontract_List_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsumerTableAdapter = null;
            this.tableAdapterManager.KSYTableAdapter = null;
            this.tableAdapterManager.NVPTableAdapter = null;
            this.tableAdapterManager.ProduсtsTableAdapter = null;
            this.tableAdapterManager.SuppliersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Storekeeper_of_stock.Storekeeper_of_stockDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.WorkersTableAdapter = null;
            this.tableAdapterManager.Сontract_List_ProductsTableAdapter = this.сontract_List_ProductsTableAdapter;
            this.tableAdapterManager.СontractTableAdapter = null;
            // 
            // сontract_List_ProductsBindingNavigator
            // 
            this.сontract_List_ProductsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.сontract_List_ProductsBindingNavigator.BindingSource = this.сontract_List_ProductsBindingSource;
            this.сontract_List_ProductsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сontract_List_ProductsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.сontract_List_ProductsBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.сontract_List_ProductsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.сontract_List_ProductsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.сontract_List_ProductsBindingNavigatorSaveItem});
            this.сontract_List_ProductsBindingNavigator.Location = new System.Drawing.Point(0, 303);
            this.сontract_List_ProductsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сontract_List_ProductsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сontract_List_ProductsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сontract_List_ProductsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сontract_List_ProductsBindingNavigator.Name = "сontract_List_ProductsBindingNavigator";
            this.сontract_List_ProductsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сontract_List_ProductsBindingNavigator.Size = new System.Drawing.Size(548, 25);
            this.сontract_List_ProductsBindingNavigator.TabIndex = 5;
            this.сontract_List_ProductsBindingNavigator.Text = "bindingNavigator1";
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
            // сontract_List_ProductsBindingNavigatorSaveItem
            // 
            this.сontract_List_ProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сontract_List_ProductsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сontract_List_ProductsBindingNavigatorSaveItem.Image")));
            this.сontract_List_ProductsBindingNavigatorSaveItem.Name = "сontract_List_ProductsBindingNavigatorSaveItem";
            this.сontract_List_ProductsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.сontract_List_ProductsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.сontract_List_ProductsBindingNavigatorSaveItem.Click += new System.EventHandler(this.сontract_List_ProductsBindingNavigatorSaveItem_Click);
            // 
            // сontract_List_ProductsDataGridView
            // 
            this.сontract_List_ProductsDataGridView.AutoGenerateColumns = false;
            this.сontract_List_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сontract_List_ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.сontract_List_ProductsDataGridView.DataSource = this.сontract_List_ProductsBindingSource;
            this.сontract_List_ProductsDataGridView.Location = new System.Drawing.Point(2, 31);
            this.сontract_List_ProductsDataGridView.Name = "сontract_List_ProductsDataGridView";
            this.сontract_List_ProductsDataGridView.Size = new System.Drawing.Size(543, 269);
            this.сontract_List_ProductsDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_Списка_Пост_Ср";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_Списка_Пост_Ср";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Номер_Продукции";
            this.dataGridViewTextBoxColumn2.HeaderText = "Номер_Продукции";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Наименование_продукции";
            this.dataGridViewTextBoxColumn3.HeaderText = "Наименование_продукции";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Стоимость_ед";
            this.dataGridViewTextBoxColumn4.HeaderText = "Стоимость_ед";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Количество_ед";
            this.dataGridViewTextBoxColumn5.HeaderText = "Количество_ед";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Сontract_List_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 328);
            this.Controls.Add(this.сontract_List_ProductsDataGridView);
            this.Controls.Add(this.сontract_List_ProductsBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "Сontract_List_Products";
            this.Text = "Список поставляемого сырья";
            this.Load += new System.EventHandler(this.Сontract_List_Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storekeeper_of_stockDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сontract_List_ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сontract_List_ProductsBindingNavigator)).EndInit();
            this.сontract_List_ProductsBindingNavigator.ResumeLayout(false);
            this.сontract_List_ProductsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сontract_List_ProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Storekeeper_of_stockDataSet storekeeper_of_stockDataSet;
        private System.Windows.Forms.BindingSource сontract_List_ProductsBindingSource;
        private Storekeeper_of_stockDataSetTableAdapters.Сontract_List_ProductsTableAdapter сontract_List_ProductsTableAdapter;
        private Storekeeper_of_stockDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сontract_List_ProductsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton сontract_List_ProductsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView сontract_List_ProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}