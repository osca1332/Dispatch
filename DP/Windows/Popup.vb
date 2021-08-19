Public Class Popup
    Private Sub Popup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Update Unit"
        unit_box.Text = ""
        comment_box.Text = ""
        location_box.Text = ""
        event_box.Text = ""
        status_box.Text = ""
    End Sub

    Private Sub confirm_btn_Click(sender As Object, e As EventArgs) Handles confirm_btn.Click
        Dim unit = unit_box.Text
        Dim comment = comment_box.Text
        Dim loc = location_box.Text
        Dim eventt = event_box.Text
        Dim status = status_box.Text
        Dim table As DataTable = Avail.DataGridView1.DataSource
        For Each row As DataRow In table.Rows
            If row.ItemArray.First.ToString = unit Then

                If comment_box.Text Is "" Then
                    comment = row("COMMENT")
                End If

                If status_box.Text Is "" Then
                    status = row("status")
                End If

                If location_box.Text Is "" Then
                    loc = row("LOCATION")
                End If

                If event_box.Text Is "" Then
                    eventt = row("EVENT#")
                End If

                row("STATUS") = status
                row("EVENT#") = eventt
                row("LOCATION") = loc
                row("COMMENT") = comment
                Hide()
                Return
            End If
        Next row
        MessageBox.Show("NO UNIT FOUND!", "ERROR!", MessageBoxButtons.OKCancel)

    End Sub
End Class