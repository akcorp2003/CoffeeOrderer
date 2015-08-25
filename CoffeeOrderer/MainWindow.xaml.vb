Imports System
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Media.Imaging

Class MainWindow

    Private m_AKstore As AKCoffeeStore
    Private m_condimentlist As New List(Of String)
    Private m_executeSelectionChanged As Boolean = True

    Public Event ChangeCoffee As EventHandler

    Private Sub CoffeeTypes_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles CoffeeTypes.SelectionChanged

        Dim content As ListBoxItem = CType(CoffeeTypes.SelectedItem, ListBoxItem)

        If m_AKstore.Currently_Serving_Beverage IsNot Nothing Then
            'Dim desc As String() = m_AKstore.Currently_Serving_Beverage.Description.Split(",")
            'REM by design, the first element is the base beverage, check that
            'If Not desc(0) = content.Content.ToString() Then
            '    OnChangeCoffee(EventArgs.Empty)
            'End If
            OnChangeCoffee(EventArgs.Empty)
        End If
        m_AKstore.Process_Order(content.Content.ToString())

        Price.Content = Convert.ToString(m_AKstore.Beverage_Cost)
        Beverage_Desc.Text = m_AKstore.Currently_Serving_Beverage.Description

    End Sub

    Private Sub CondimentList_SelectionChanged(sender As Object, e As SelectionChangedEventArgs) Handles CondimentList.SelectionChanged

        If Not m_executeSelectionChanged Then
            Return
        End If

        If CoffeeTypes.SelectedItem Is Nothing Then
            MessageBox.Show("I can't add condiments without a coffee!!")
            CondimentList.UnselectAll()
            Return
        End If

        For Each condiment In CondimentList.SelectedItems
            Dim stuff As ListBoxItem = CType(condiment, ListBoxItem)
            Dim condimentitem As String = stuff.Content.ToString()
            If m_condimentlist.Count = 0 Then
                m_AKstore.Process_Order(condimentitem)
                m_condimentlist.Add(condimentitem)
            ElseIf Not m_condimentlist.Contains(condimentitem) And CondimentList.SelectedItems.Count < m_condimentlist.Count Then
                REM customer removed an item
            ElseIf m_condimentlist.Contains(condimentitem) Then
                Continue For
            Else
                m_AKstore.Process_Order(condimentitem)
                m_condimentlist.Add(condimentitem)
            End If

        Next

        Price.Content = Convert.ToString(m_AKstore.Beverage_Cost)
        Beverage_Desc.Text = m_AKstore.Currently_Serving_Beverage.Description

    End Sub

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        Dim mystore As New AKCoffeeStore
        m_AKstore = mystore
        AddHandler Me.ChangeCoffee, AddressOf Me.UnselectAllCondiments
    End Sub

    Private Sub ComboBoxItem_Selected(sender As Object, e As RoutedEventArgs)

    End Sub

    Public Property Store As AKCoffeeStore
        Get
            Return m_AKstore
        End Get
        Set(value As AKCoffeeStore)
            m_AKstore = value
        End Set
    End Property

    Public Sub UnselectAllCondiments()
        m_condimentlist.Clear()
        m_executeSelectionChanged = False
        CondimentList.UnselectAll()
        m_executeSelectionChanged = True
    End Sub

    Protected Overridable Sub OnChangeCoffee(e As EventArgs)
        RaiseEvent ChangeCoffee(Me, e)
    End Sub


End Class
