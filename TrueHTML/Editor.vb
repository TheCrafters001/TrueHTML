Public Class Editor
    Public Class Detail
        ' Create public properties for saving details (Code editors, page titles, etc.)
        Public Property pageTitle As String
        Public Property version As String
    End Class

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click

        ' Create an output list using properties defined from Detail.
        ' This list contains everything that needs to be converted to JSON
        Dim Output = New List(Of Detail) From {
            New Detail With {
            .pageTitle = pageTitle_txt.Text,
            .version = My.Application.Info.Version.ToString
            }
        }

        ' Serialize Output into SerializedOutput to create JSON that we can work with
        Dim SerializedOutput = Utils.Json.Serialize(Output) '

        ' Display SerializedOutput in debug console.
        Debug.WriteLine(SerializedOutput)

    End Sub
End Class
