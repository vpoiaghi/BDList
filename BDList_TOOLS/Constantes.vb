Public Module Constantes

    Public Enum PossessionStates
        missing = 0             ' Pas En possession
        InPossession = 1        ' En possession
        Wanted = 2              ' Recherché
        InDelivery = 3          ' Commandé / en cours de livraison
        Reserved = 4            ' Réservé
        ToOrderAtBDfugue = 5    ' A commander chez BDfugue
        ToReserveAtCultura = 6  ' A réserver chez Cultura
        Present = 7             ' Cadeau (à ne pas acheter car sur liste de noël ou anniversaire)
        OrderedAtBDFugue = 8    ' Commandé chez BD fugue
        ReservedAtCultura = 9   ' Réservé chez Cultura
    End Enum

End Module
