Imports System
Public Class Avail

    Dim table As New DataTable("Table")

    Private Sub Avail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        table.Columns.Add("UNITS")
        table.Columns.Add("STATUS")
        table.Columns.Add("EVENT#")
        table.Columns.Add("LOCATION")
        table.Columns.Add("COMMENT")
        Me.Text = "Dispatch Units | " + GetUnits().Count.ToString + " Units"
        Dim units = GetUnits()
        Dim i As Integer = 0
        For Each un As Unit In units
            table.Rows.Add(un.callsign, un.status, un.kald, un.location, un.comment)
            i = i + 1
        Next

        DataGridView1.DataSource = table
        DataGridView1.ReadOnly = True
        DataGridView1.DefaultCellStyle.SelectionBackColor = DataGridView1.DefaultCellStyle.BackColor
        DataGridView1.DefaultCellStyle.SelectionForeColor = DataGridView1.DefaultCellStyle.ForeColor

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        DataGridView1.ClearSelection()
    End Sub

    Private Sub DataGridView1_ColumnAdded(sender As Object, e As DataGridViewColumnEventArgs) Handles DataGridView1.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles DataGridView1.KeyDown
        If e.KeyCode = Keys.F10 Then
            callPopup("change_comment")
        End If
    End Sub
End Class
