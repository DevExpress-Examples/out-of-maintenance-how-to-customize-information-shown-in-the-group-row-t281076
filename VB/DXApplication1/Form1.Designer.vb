Namespace DXApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.customerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.videoRentDataSet = New DXApplication1.VideoRentDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colOid = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCustomerId = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colMiddleName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colEmail = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhone = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colComments = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colPhoto = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDiscountLevel = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.customerTableAdapter = New DXApplication1.VideoRentDataSetTableAdapters.CustomerTableAdapter()
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.customerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.videoRentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.customerBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(433, 334)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' customerBindingSource
			' 
			Me.customerBindingSource.DataMember = "Customer"
			Me.customerBindingSource.DataSource = Me.videoRentDataSet
			' 
			' videoRentDataSet
			' 
			Me.videoRentDataSet.DataSetName = "VideoRentDataSet"
			Me.videoRentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colOid, Me.colCustomerId, Me.colMiddleName, Me.colEmail, Me.colAddress, Me.colPhone, Me.colComments, Me.colPhoto, Me.colDiscountLevel})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupCount = 1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colDiscountLevel, DevExpress.Data.ColumnSortOrder.Ascending)})
'			Me.gridView1.CustomDrawGroupRow += New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(Me.gridView1_CustomDrawGroupRow)
			' 
			' colOid
			' 
			Me.colOid.FieldName = "Oid"
			Me.colOid.Name = "colOid"
			Me.colOid.Visible = True
			Me.colOid.VisibleIndex = 0
			' 
			' colCustomerId
			' 
			Me.colCustomerId.FieldName = "CustomerId"
			Me.colCustomerId.Name = "colCustomerId"
			Me.colCustomerId.Visible = True
			Me.colCustomerId.VisibleIndex = 1
			' 
			' colMiddleName
			' 
			Me.colMiddleName.FieldName = "MiddleName"
			Me.colMiddleName.Name = "colMiddleName"
			Me.colMiddleName.Visible = True
			Me.colMiddleName.VisibleIndex = 2
			' 
			' colEmail
			' 
			Me.colEmail.FieldName = "Email"
			Me.colEmail.Name = "colEmail"
			Me.colEmail.Visible = True
			Me.colEmail.VisibleIndex = 3
			' 
			' colAddress
			' 
			Me.colAddress.FieldName = "Address"
			Me.colAddress.Name = "colAddress"
			Me.colAddress.Visible = True
			Me.colAddress.VisibleIndex = 4
			' 
			' colPhone
			' 
			Me.colPhone.FieldName = "Phone"
			Me.colPhone.Name = "colPhone"
			Me.colPhone.Visible = True
			Me.colPhone.VisibleIndex = 5
			' 
			' colComments
			' 
			Me.colComments.FieldName = "Comments"
			Me.colComments.Name = "colComments"
			Me.colComments.Visible = True
			Me.colComments.VisibleIndex = 6
			' 
			' colPhoto
			' 
			Me.colPhoto.FieldName = "Photo"
			Me.colPhoto.Name = "colPhoto"
			Me.colPhoto.Visible = True
			Me.colPhoto.VisibleIndex = 7
			' 
			' colDiscountLevel
			' 
			Me.colDiscountLevel.FieldName = "DiscountLevel"
			Me.colDiscountLevel.Name = "colDiscountLevel"
			Me.colDiscountLevel.Visible = True
			Me.colDiscountLevel.VisibleIndex = 8
			' 
			' customerTableAdapter
			' 
			Me.customerTableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(433, 334)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load)
			DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.customerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.videoRentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private videoRentDataSet As VideoRentDataSet
		Private customerBindingSource As System.Windows.Forms.BindingSource
		Private customerTableAdapter As VideoRentDataSetTableAdapters.CustomerTableAdapter
		Private colOid As DevExpress.XtraGrid.Columns.GridColumn
		Private colCustomerId As DevExpress.XtraGrid.Columns.GridColumn
		Private colMiddleName As DevExpress.XtraGrid.Columns.GridColumn
		Private colEmail As DevExpress.XtraGrid.Columns.GridColumn
		Private colAddress As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhone As DevExpress.XtraGrid.Columns.GridColumn
		Private colComments As DevExpress.XtraGrid.Columns.GridColumn
		Private colPhoto As DevExpress.XtraGrid.Columns.GridColumn
		Private colDiscountLevel As DevExpress.XtraGrid.Columns.GridColumn

	End Class
End Namespace

