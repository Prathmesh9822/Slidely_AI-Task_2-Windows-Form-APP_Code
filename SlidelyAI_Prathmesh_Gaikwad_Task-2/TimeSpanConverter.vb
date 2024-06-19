Imports Newtonsoft.Json
Imports System

Public Class TimeSpanConverter
    Inherits JsonConverter(Of TimeSpan)

    Public Overrides Sub WriteJson(writer As JsonWriter, value As TimeSpan, serializer As JsonSerializer)
        writer.WriteValue(value.TotalSeconds)
    End Sub

    Public Overrides Function ReadJson(reader As JsonReader, objectType As Type, existingValue As TimeSpan, hasExistingValue As Boolean, serializer As JsonSerializer) As TimeSpan
        If reader.TokenType = JsonToken.Integer Then
            Dim totalSeconds As Integer = Convert.ToInt32(reader.Value)
            Return TimeSpan.FromSeconds(totalSeconds)
        Else
            Throw New JsonSerializationException("Expected integer value for TimeSpan.")
        End If
    End Function

    Public Shadows Function CanConvert(objectType As Type) As Boolean
        Return objectType = GetType(TimeSpan)
    End Function
End Class
