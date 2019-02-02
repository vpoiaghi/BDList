Imports BDList_DAO_BO.BO
Imports BDList_SERVICE

Public Interface ISyncCtrl

    Function GetPhoneService() As IService
    Function GetLocalService() As IService
    Function GetSynchroniser() As SynchroniseIdBobject
    Function GetCtrlResult() As SyncCtrlResult
    Function Control(item As SyncCtrlItem) As Boolean

End Interface
