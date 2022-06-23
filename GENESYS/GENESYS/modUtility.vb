Imports System.Net.NetworkInformation


Module modUtility

    Public Sub ClearTextBox(ByVal Root As Control)

        For Each ctrl As Control In Root.Controls
            ClearTextBox(ctrl)
            If TypeOf ctrl Is TextBox Then
                CType(ctrl, TextBox).Text = String.Empty
            End If
        Next ctrl

    End Sub


End Module
