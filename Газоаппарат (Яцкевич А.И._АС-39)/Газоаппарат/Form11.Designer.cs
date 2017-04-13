namespace Газоаппарат
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            this.брестГазDataSet = new Газоаппарат.БрестГазDataSet();
            this.карточка_складского_учетаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.карточка_складского_учетаTableAdapter = new Газоаппарат.БрестГазDataSetTableAdapters.Карточка_складского_учетаTableAdapter();
            this.tableAdapterManager = new Газоаппарат.БрестГазDataSetTableAdapters.TableAdapterManager();
            this.карточка_складского_учетаBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.карточка_складского_учетаBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.карточка_складского_учетаDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.брестГазDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.карточка_складского_учетаBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.карточка_складского_учетаBindingNavigator)).BeginInit();
            this.карточка_складского_учетаBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.карточка_складского_учетаDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // брестГазDataSet
            // 
            this.брестГазDataSet.DataSetName = "БрестГазDataSet";
            this.брестГазDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // карточка_складского_учетаBindingSource
            // 
            this.карточка_складского_учетаBindingSource.DataMember = "Карточка_складского_учета";
            this.карточка_складского_учетаBindingSource.DataSource = this.брестГазDataSet;
            // 
            // карточка_складского_учетаTableAdapter
            // 
            this.карточка_складского_учетаTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Газоаппарат.БрестГазDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Виды_работTableAdapter = null;
            this.tableAdapterManager.Выполнение_работTableAdapter = null;
            this.tableAdapterManager.Журнал_учета_заявок_на_ремонт_оборудованияTableAdapter = null;
            this.tableAdapterManager.ЗаявкаTableAdapter = null;
            this.tableAdapterManager.Карточка_складского_учетаTableAdapter = this.карточка_складского_учетаTableAdapter;
            this.tableAdapterManager.Накладная_на_внутреннее_перемещение_оборудованияTableAdapter = null;
            this.tableAdapterManager.Наряд_заданиеTableAdapter = null;
            this.tableAdapterManager.ОборудованиеTableAdapter = null;
            this.tableAdapterManager.ОтделыTableAdapter = null;
            this.tableAdapterManager.Поставщик_оборудованияTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            this.tableAdapterManager.Список_работTableAdapter = null;
            // 
            // карточка_складского_учетаBindingNavigator
            // 
            this.карточка_складского_учетаBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.карточка_складского_учетаBindingNavigator.BindingSource = this.карточка_складского_учетаBindingSource;
            this.карточка_складского_учетаBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.карточка_складского_учетаBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.карточка_складского_учетаBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.карточка_складского_учетаBindingNavigatorSaveItem});
            this.карточка_складского_учетаBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.карточка_складского_учетаBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.карточка_складского_учетаBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.карточка_складского_учетаBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.карточка_складского_учетаBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.карточка_складского_учетаBindingNavigator.Name = "карточка_складского_учетаBindingNavigator";
            this.карточка_складского_учетаBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.карточка_складского_учетаBindingNavigator.Size = new System.Drawing.Size(485, 25);
            this.карточка_складского_учетаBindingNavigator.TabIndex = 0;
            this.карточка_складского_учетаBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
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
            // карточка_складского_учетаBindingNavigatorSaveItem
            // 
            this.карточка_складского_учетаBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.карточка_складского_учетаBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("карточка_складского_учетаBindingNavigatorSaveItem.Image")));
            this.карточка_складского_учетаBindingNavigatorSaveItem.Name = "карточка_складского_учетаBindingNavigatorSaveItem";
            this.карточка_складского_учетаBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.карточка_складского_учетаBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.карточка_складского_учетаBindingNavigatorSaveItem.Click += new System.EventHandler(this.карточка_складского_учетаBindingNavigatorSaveItem_Click);
            // 
            // карточка_складского_учетаDataGridView
            // 
            this.карточка_складского_учетаDataGridView.AutoGenerateColumns = false;
            this.карточка_складского_учетаDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.карточка_складского_учетаDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.карточка_складского_учетаDataGridView.DataSource = this.карточка_складского_учетаBindingSource;
            this.карточка_складского_учетаDataGridView.Location = new System.Drawing.Point(12, 58);
            this.карточка_складского_учетаDataGridView.Name = "карточка_складского_учетаDataGridView";
            this.карточка_складского_учетаDataGridView.Size = new System.Drawing.Size(450, 220);
            this.карточка_складского_учетаDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Номер_КСУ";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер_КСУ";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата_заведения_карточки";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата_заведения_карточки";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Номер_накладной";
            this.dataGridViewTextBoxColumn3.HeaderText = "Номер_накладной";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "номер_записи";
            this.dataGridViewTextBoxColumn4.HeaderText = "номер_записи";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(124, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Карточка складского учета";
            // 
            // Form11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 318);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.карточка_складского_учетаDataGridView);
            this.Controls.Add(this.карточка_складского_учетаBindingNavigator);
            this.Name = "Form11";
            this.Text = "Карточка складского учета";
            this.Load += new System.EventHandler(this.Form11_Load);
            ((System.ComponentModel.ISupportInitialize)(this.брестГазDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.карточка_складского_учетаBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.карточка_складского_учетаBindingNavigator)).EndInit();
            this.карточка_складского_учетаBindingNavigator.ResumeLayout(false);
            this.карточка_складского_учетаBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.карточка_складского_учетаDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private БрестГазDataSet брестГазDataSet;
        private System.Windows.Forms.BindingSource карточка_складского_учетаBindingSource;
        private БрестГазDataSetTableAdapters.Карточка_складского_учетаTableAdapter карточка_складского_учетаTableAdapter;
        private БрестГазDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator карточка_складского_учетаBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton карточка_складского_учетаBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView карточка_складского_учетаDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Label label1;
    }
}