Imports BDList_TOOLS

Public Module PossessionStatesUtils

    Public Function GetImage(possessionState As PossessionStates) As Image

        Dim img As Image = Nothing

        Select possessionState
            Case PossessionStates.InDelivery : img = My.Resources.uncheck_delivery
            Case PossessionStates.InPossession : img = My.Resources.check
            Case PossessionStates.missing : img = My.Resources.uncheck
            Case PossessionStates.Reserved : img = My.Resources.uncheck_reserved
            Case PossessionStates.Wanted : img = My.Resources.uncheck_but_wanted
            Case PossessionStates.ToOrderAtBDfugue : img = My.Resources.to_order_at_bdfugue
            Case PossessionStates.ToReserveAtCultura : img = My.Resources.to_reserve_at_cultura
            Case PossessionStates.Present : img = My.Resources.present
        End Select

        Return img

    End Function


End Module
