Module Module1

    Sub Main()
        Console.WriteLine("starting")

        Dim _proxy As New SP.MsmqContractClient

        _proxy.SendMessage(Guid.NewGuid.ToString & " " & Now.ToString)

        Console.WriteLine("ending")
        Console.ReadLine()

    End Sub

End Module


'http://blogs.msdn.com/b/tomholl/archive/2008/07/12/msmq-wcf-and-iis-getting-them-to-play-nice-part-1.aspx

'MSMQ activation and setup for IIS
'http://msdn.microsoft.com/en-us/library/ms752246%28v=vs.110%29.aspx