Public MustInherit Class Beverage
    Private m_desc As String = "Unknown beverage"

    Overridable Property Description As String
        Get
            Return m_desc
        End Get
        Set(value As String)
            m_desc = value
        End Set
    End Property

    Public MustOverride Function cost() As Double
End Class

Public Class Espresso
    Inherits Beverage

    Public Sub New()
        Description = "Espresso"
    End Sub

    Public Overrides Function cost() As Double
        Return 1.99
    End Function
End Class

Public Class HouseBlend
    Inherits Beverage

    Public Sub New()
        Description = "House Blend Coffee"
    End Sub

    Public Overrides Function cost() As Double
        Return 0.89
    End Function
End Class

Public Class RegularRoast
    Inherits Beverage

    Public Sub New()
        Description = "Regular Roast"
    End Sub

    Public Overrides Function cost() As Double
        Return 0.5
    End Function
End Class

Public Class DarkRoast
    Inherits Beverage

    Public Sub New()
        Description = "Dark Roast"
    End Sub

    Public Overrides Function cost() As Double
        Return 0.99
    End Function
End Class

Public Class Decaf
    Inherits Beverage

    Public Sub New()
        Description = "Decaf"
    End Sub

    Public Overrides Function cost() As Double
        Return 1.05
    End Function
End Class
