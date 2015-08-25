Public MustInherit Class CondimentDecorator
    Inherits Beverage

    'Public MustOverride Function getDescription() As String

    Public Overrides Function cost() As Double
        Return 0
    End Function
End Class

Public Class Mocha
    Inherits CondimentDecorator

    Private m_beverage As Beverage

    Public Sub New(ByVal beverage As Beverage)
        m_beverage = beverage
    End Sub

    Public Overrides Property Description As String
        Get
            Return m_beverage.Description + ", Mocha"
        End Get
        Set(value As String)
            m_beverage.Description += value
        End Set
    End Property

    'Public Overrides Function getDescription() As String
    '    Return m_beverage.Description + ", Soy"
    'End Function

    Public Overrides Function cost() As Double
        Return 0.2 + m_beverage.cost()
    End Function
End Class

Public Class Soy
    Inherits CondimentDecorator

    Private m_beverage As Beverage

    Public Sub New(ByVal beverage As Beverage)
        m_beverage = beverage
    End Sub

    Public Overrides Property Description As String
        Get
            Return m_beverage.Description + ", Soy"
        End Get
        Set(value As String)
            m_beverage.Description += value
        End Set
    End Property

    'Public Overrides Function getDescription() As String
    '    Return m_beverage.Description + ", Soy"
    'End Function

    Public Overrides Function cost() As Double
        Return 0.15 + m_beverage.cost()
    End Function
End Class

Public Class Whip
    Inherits CondimentDecorator

    Private m_beverage As Beverage

    Public Sub New(ByVal beverage As Beverage)
        m_beverage = beverage
    End Sub

    'Public Overrides Function getDescription() As String
    '    Return m_beverage.Description + ", Whip"
    'End Function

    Public Overrides Property Description As String
        Get
            Return m_beverage.Description + ", Whip"
        End Get
        Set(value As String)
            m_beverage.Description += value
        End Set
    End Property

    Public Overrides Function cost() As Double
        Return 0.1 + m_beverage.cost()
    End Function
End Class

Public Class Milk
    Inherits CondimentDecorator

    Private m_beverage As Beverage

    Public Sub New(ByVal beverage As Beverage)
        m_beverage = beverage
    End Sub

    Public Overrides Property Description As String
        Get
            Return m_beverage.Description + ", Milk"
        End Get
        Set(value As String)
            m_beverage.Description += value
        End Set
    End Property

    'Public Overrides Function getDescription() As String
    '    Return m_beverage.Description + ", Milk"
    'End Function

    Public Overrides Function cost() As Double
        Return 0.1 + m_beverage.cost()
    End Function
End Class

Public Class Caramel
    Inherits CondimentDecorator

    Private m_beverage As Beverage

    Public Sub New(ByVal beverage As Beverage)
        m_beverage = beverage
    End Sub

    Public Overrides Property Description As String
        Get
            Return m_beverage.Description + ", Caramel"
        End Get
        Set(value As String)
            m_beverage.Description += value
        End Set
    End Property

    'Public Overrides Function getDescription() As String
    '    Return m_beverage.Description + ", Caramel"
    'End Function

    Public Overrides Function cost() As Double
        Return 0.1 + m_beverage.cost()
    End Function
End Class
