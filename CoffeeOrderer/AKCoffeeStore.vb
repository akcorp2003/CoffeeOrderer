Public Class AKCoffeeStore
    Private m_AKCoffeeStore As AKCoffeeStore
    Private m_servingbeverage As Beverage

    Public Sub New()
        
    End Sub

    Public Sub New(ByVal my_store As AKCoffeeStore)
        m_AKCoffeeStore = my_store
    End Sub

    Public ReadOnly Property Store_Itself As AKCoffeeStore
        Get
            Return Me
        End Get
    End Property

    Public ReadOnly Property Beverage_Cost As Double
        Get
            Return m_servingbeverage.cost()
        End Get
    End Property

    Public ReadOnly Property Currently_Serving_Beverage As Beverage
        Get
            Return m_servingbeverage
        End Get
    End Property

    Public Function Process_Order(ByVal item As String) As String
        If item = "Espresso" Then
            m_servingbeverage = New Espresso()
        ElseIf item = "House Blend" Then
            m_servingbeverage = New HouseBlend()
        ElseIf item = "Decaf" Then
            m_servingbeverage = New Decaf()
        ElseIf item = "Regular Roast" Then
            m_servingbeverage = New RegularRoast()
        ElseIf item = "Dark Roast" Then
            m_servingbeverage = New DarkRoast()
        End If

        If item = "Milk" Then
            m_servingbeverage = New Milk(m_servingbeverage)
        ElseIf item = "Mocha" Then
            m_servingbeverage = New Mocha(m_servingbeverage)
        ElseIf item = "Soy" Then
            m_servingbeverage = New Soy(m_servingbeverage)
        ElseIf item = "Whip" Then
            m_servingbeverage = New Whip(m_servingbeverage)
        ElseIf item = "Caramel" Then
            m_servingbeverage = New Caramel(m_servingbeverage)
        End If

        Return m_servingbeverage.Description
    End Function
End Class
