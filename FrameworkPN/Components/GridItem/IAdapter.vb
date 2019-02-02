Public Interface IAdapter

    Function GetItemsCount() As Integer
    'Function GetListViewItemType() As Type

    Function BuildNewListViewItem(position As Integer) As GridItem
    Function InitListViewItem(listViewItem As GridItem, position As Integer) As GridItem

End Interface
