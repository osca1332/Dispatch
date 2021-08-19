
Public Class Calls
    Private Function GenRandomInt(min As Int32, max As Int32) As Int32
        Static staticRandomGenerator As New System.Random
        Return staticRandomGenerator.Next(min, max + 1)
    End Function

    Private Sub Events_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshData.Enabled = False
        datetime_box.Text = DateTime.Now
        event_box.Text = GenRandomInt(0, 9999).ToString

        initGridView()




    End Sub

    Dim table As New DataTable("Table")
    Function initGridView()
        table.Columns.Add("EVENT#")
        table.Columns.Add("TIME")
        table.Columns.Add("LOCATION")
        table.Columns.Add("DESC")
        table.Columns.Add("CONTACT")


        DataGridView1.DataSource = table
        DataGridView1.ReadOnly = True
        DataGridView1.DefaultCellStyle.SelectionBackColor = DataGridView1.DefaultCellStyle.BackColor
        DataGridView1.DefaultCellStyle.SelectionForeColor = DataGridView1.DefaultCellStyle.ForeColor
    End Function

    Private Sub RefreshData_Tick(sender As Object, e As EventArgs) Handles RefreshData.Tick
        datetime_box.Text = DateTime.Now
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        table.Rows.Add(event_box.Text, datetime_box.Text, loc_box.Text, desc_crime.Text, sirname_box.Text + "," + name_box.Text + "," + phone_box.Text + "," + bday_box.Text)

        clearFields()
    End Sub

    Private Function clearFields()
        loc_box.Text = ""
        desc_crime.Text = ""
        sirname_box.Text = "Sirname"
        name_box.Text = "Firstname"
        bday_box.Text = "Birthday"
        phone_box.Text = ""
        event_box.Text = GenRandomInt(0, 9999).ToString
        datetime_box.Text = DateTime.Now.ToString
    End Function

    Private Function toggleFields(bool As Boolean)
        loc_box.Enabled = bool
        desc_crime.Enabled = bool
        sirname_box.Enabled = bool
        name_box.Enabled = bool
        bday_box.Enabled = bool
        phone_box.Enabled = bool
        event_box.Enabled = bool
        datetime_box.Enabled = bool
    End Function

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick, DataGridView1.CellDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If
        toggleFields(False)
        Dim contact = table.Rows(e.RowIndex)("CONTACT").ToString.Split(",")

        loc_box.Text = table.Rows(e.RowIndex)("LOCATION").ToString
        desc_crime.Text = table.Rows(e.RowIndex)("DESC").ToString
        sirname_box.Text = contact(0)
        name_box.Text = contact(1)
        bday_box.Text = contact(3)
        phone_box.Text = contact(2)
        event_box.Text = table.Rows(e.RowIndex)("EVENT#").ToString
        datetime_box.Text = table.Rows(e.RowIndex)("TIME").ToString
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex = -1 Then
            Return
        End If
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Deleting Event!", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            table.Rows.Remove(table.Rows(e.RowIndex))
        ElseIf result = DialogResult.No Then
            Return
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        clearFields()
        toggleFields(True)
    End Sub
End Class