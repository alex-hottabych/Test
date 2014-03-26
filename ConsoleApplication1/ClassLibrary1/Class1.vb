Public Class Class1
    Sub MySub()

        If MyQuant > 0 Then
            If MyQuant.Equals(0) Then
                Return
            End If
        End If

    End Sub

    Public ReadOnly Property MyQuant() As Integer
        Get
            Throw New NotImplementedException()
        End Get
    End Property
End Class
