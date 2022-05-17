' ============================================================================
'    Author: Kenneth Perkins
'    Date:   Nov 17, 2020
'    Taken From: http://programmingnotes.org/
'    File: Utils.vb
'    Description: Handles general utility functions
' ============================================================================
Option Strict On
Option Explicit On

Namespace Global.Utils
    Namespace Json
        Public Module modJson
            ''' <summary>
            ''' Serializes the specified value to Json
            ''' </summary>
            ''' <param name="value">The value to serialize</param> 
            ''' <param name="settings">The Newtonsoft.Json.JsonSerializerSettings used to serialize the object</param> 
            ''' <returns>The value serialized to Json</returns>
            Public Function Serialize(value As Object _
                                      , Optional settings As Newtonsoft.Json.JsonSerializerSettings = Nothing) As String
                If settings Is Nothing Then
                    settings = GetDefaultSettings()
                End If
                Return Newtonsoft.Json.JsonConvert.SerializeObject(value, settings)
            End Function

            ''' <summary>
            ''' Deserializes the specified value from Json to Object T
            ''' </summary>
            ''' <param name="value">The value to deserialize</param> 
            ''' <param name="settings">The Newtonsoft.Json.JsonSerializerSettings used to deserialize the object</param> 
            ''' <returns>The value deserialized to Object T</returns>
            Public Function Deserialize(Of T)(value As String _
                                              , Optional settings As Newtonsoft.Json.JsonSerializerSettings = Nothing) As T
                If settings Is Nothing Then
                    settings = GetDefaultSettings()
                End If
                Return Newtonsoft.Json.JsonConvert.DeserializeObject(Of T)(value, settings)
            End Function

            Private Function GetDefaultSettings() As Newtonsoft.Json.JsonSerializerSettings
                Static settings As New Newtonsoft.Json.JsonSerializerSettings With {
                    .Formatting = Newtonsoft.Json.Formatting.Indented
                }
                Return settings
            End Function
        End Module
    End Namespace
End Namespace ' http://programmingnotes.org/