
<ServiceContract()>
Public Interface IMsmqContract

    <OperationContract(isoneway:=True)>
    Sub SendMessage(ByVal message As String)


End Interface


