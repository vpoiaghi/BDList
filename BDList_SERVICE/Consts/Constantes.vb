Public Module Constantes

    Public Const DATA_FOLDER_PATH As String = "F:\Collections\BDs\Access\Données\"
    Public Const BOOKS_FOLDER_PATH As String = DATA_FOLDER_PATH & "Albums\"
    Public Const MAGAZINE_FOLDER_PATH As String = DATA_FOLDER_PATH & "Magazines\"
    Public Const PERSONS_FOLDER_PATH As String = DATA_FOLDER_PATH & "Personnes\"
    Public Const PURCHASES_FOLDER_PATH As String = DATA_FOLDER_PATH & "Annonces\"
    Public Const EVENTS_FOLDER_PATH As String = DATA_FOLDER_PATH & "Evenements\"
    Public Const EDITORS_FOLDER_PATH As String = DATA_FOLDER_PATH & "Editeurs\"
    Public Const SET_FOLDER_PATH As String = BOOKS_FOLDER_PATH & "00 Recueils\"
    Public Const OUT_SERIE_PATH As String = BOOKS_FOLDER_PATH & "00 HORS SERIE\"
    Public Const FESTIVALS_FOLDER_PATH As String = DATA_FOLDER_PATH & "Festivals\"

    Public Const FIRSTCOVERS_FOLDER_NAME As String = "Couvertures"
    Public Const FOURTHCOVERS_FOLDER_NAME As String = "Dos"
    Public Const INFOS_FOLDER_NAME As String = "Infos"
    Public Const GOODIES_FOLDER_NAME As String = "Para-bd"
    Public Const BOARDS_FOLDER_NAME As String = "Planches"
    Public Const MOVIES_FOLDER_NAME As String = "Videos"
    Public Const AUTOGRAPH_FOLDER_NAME As String = "Dédicaces"

    'Public Const PHONE_PARENT_DATA_FOLDER As String = "/storage/emulated/0/Android/data/bdlist.bdlist/files/"
    Public Const PHONE_PARENT_DATA_FOLDER As String = "/storage/3834-6332/Android/data/bdlist.bdlist/files/"
    Public Const PHONE_COVERS_FOLDER As String = PHONE_PARENT_DATA_FOLDER & "covers/"
    Public Const PHONE_GOODIES_FOLDER As String = PHONE_PARENT_DATA_FOLDER & "goodies/"
    Public Const PHONE_AUTOGRAPHS_FOLDER As String = PHONE_PARENT_DATA_FOLDER & "autographs/"
    Public Const PHONE_AUTHORS_FOLDER As String = PHONE_PARENT_DATA_FOLDER & "authors/"
    Public Const PHONE_EVENTS_FOLDER As String = PHONE_PARENT_DATA_FOLDER & "events/"
    Public Const PHONE_FESTIVALS_FOLDER As String = PHONE_PARENT_DATA_FOLDER & "festivals/"

    Public Const SQLITE_DATABASE_PHONE_FILE_PATH As String = PHONE_PARENT_DATA_FOLDER & "bdlist.db"

End Module
