Module Units
    Class Unit
        Public status As String
        Public callsign As String
        Public location As String
        Public kald As String
        Public comment As String

        Public Sub New(ByVal stat As String,
                       ByVal callsign As String,
                       ByVal kald As String,
                       ByVal location As String,
                       ByVal comment As String)
            Me.status = stat
            Me.callsign = callsign
            Me.kald = kald
            Me.location = location
            Me.comment = comment
        End Sub
    End Class


    Function GetUnits() As IEnumerable(Of Unit)
        Return New List(Of Unit) From
            {
             New Unit("D", "PB06", "0045", "PillBox", ""),
             New Unit("AV", "PB07", "0046", "PillBox", "AVAILABLE"),
             New Unit("EN", "PB08", "0057", "PillBox", ""),
             New Unit("M", "PB09", "0087", "PillBox", ""),
             New Unit("LB", "PB10", "0087", "PillBox", ""),
             New Unit("M", "PB11", "0087", "PillBox", ""),
             New Unit("AV", "PB12", "0087", "PillBox", "AVAILABLE")
            }
    End Function

End Module
