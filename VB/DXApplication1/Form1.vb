Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms

Namespace DXApplication1
	Partial Public Class Form1
		Inherits DevExpress.XtraEditors.XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'videoRentDataSet.Customer' table. You can move, or remove it, as needed.
			Me.customerTableAdapter.Fill(Me.videoRentDataSet.Customer)
		End Sub


		Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawGroupRow
		   TryCast(e.Info, GridGroupRowInfo).GroupText = "Your custom text"
		End Sub
	End Class
End Namespace
