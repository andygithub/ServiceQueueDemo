' NOTE: You can use the "Rename" command on the context menu to change the class name "Service1" in code, svc and config file together.
' NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.vb at the Solution Explorer and start debugging.
Public Class MsmqContract
    Implements IMsmqContract

    Public Sub New()
    End Sub


    Public Sub SendMessage(message As String) Implements IMsmqContract.SendMessage
        IO.File.AppendAllText("c:\temp\test.log", message & vbCrLf)
        Trace.WriteLine(message)
    End Sub
End Class
