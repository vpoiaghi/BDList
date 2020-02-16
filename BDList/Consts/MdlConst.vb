Module MdlConst

    Public Const SYNCHRO_WITH_PHONE_FOLER_PATH As String = "F:\Programmation\android\SD\sdcard\bdlist\donnees\"
    Public Const SYNCHRO_WITH_PHONE_SERIES_FILE_NAME As String = "series.xml"
    Public Const SYNCHRO_WITH_PHONE_COMING_FILE_NAME As String = "coming_books.xml"

    Public Const ACCESS_DATABASE_FILE_PATH As String = "F:\Collections\BDs\Access\Données\Datas.mdb"
    Public Const SQLITE_DATABASE_LOCAL_FILE_PATH As String = SYNCHRO_WITH_PHONE_FOLER_PATH & "bdlist.db"

    Public Const LOCAL_PHONE_PARENT_DATA_FOLDER As String = "F:\Programmation\android\SD\sdcard\bdlist\donnees\"
    Public Const LOCAL_PHONE_COVERS_FOLDER As String = LOCAL_PHONE_PARENT_DATA_FOLDER & "covers\"
    Public Const LOCAL_PHONE_GOODIES_FOLDER As String = LOCAL_PHONE_PARENT_DATA_FOLDER & "goodies\"
    Public Const LOCAL_PHONE_AUTOGRAPHS_FOLDER As String = LOCAL_PHONE_PARENT_DATA_FOLDER & "autographs\"
    Public Const LOCAL_PHONE_EVENTS_FOLDER As String = LOCAL_PHONE_PARENT_DATA_FOLDER & "events\"
    Public Const LOCAL_PHONE_AUTHORS_FOLDER As String = LOCAL_PHONE_PARENT_DATA_FOLDER & "authors\"

    Public Const PRM_KEY_SERIE As String = "serie"
    Public Const PRM_KEY_SERIE_ID As String = "serie_id"
    Public Const PRM_KEY_SERIE_EDITIONS As String = "serie_editions"
    Public Const PRM_KEY_SERIE_TITLES As String = "serie_titles"
    Public Const PRM_KEY_SERIE_GOODIES As String = "serie_goodies"
    Public Const PRM_KEY_EDITION As String = "edition"
    Public Const PRM_KEY_GOODY As String = "goody"
    Public Const PRM_KEY_FRM_OWNER As String = "owner"
    Public Const PRM_KEY_FRM_RELOAD As String = "reload"

End Module
